using UnityEngine;
using System.Collections.Generic;

public class MultiDebugAnimatronicSpawner : MonoBehaviour
{
    public List<string> PlushSuitIdsToSpawn = new List<string>();
    public bool SpawnAllAvailable = false;
    public float spawnInterval = 0.5f;
    public Vector3 baseSpawnPosition = Vector3.zero;
    public Vector3 offset = new Vector3(1.5f, 0, 0);

    private Animatronic3DDomain animDomain;
    private CPU_DATA.Root cpuRoot;
    private PLUSHSUIT_DATA.Root plushRoot;
    private ATTACK_DATA.Root attackRoot;

    void Start()
    {
        LoadMasterData();
        if (SpawnAllAvailable)
        {
            PlushSuitIdsToSpawn.Clear();
            foreach (var entry in plushRoot.Entries)
                PlushSuitIdsToSpawn.Add(entry.Logical);
        }

        StartCoroutine(SpawnAll());
    }

    private void LoadMasterData()
    {
        animDomain = GameLifecycleProxy.GetMasterDomain().Animatronic3DDomain;
        cpuRoot = (CPU_DATA.Root)ConstantVariables.Instance.MasterDataDownloader.GetMasterDataDeserialized(typeof(CPU_DATA));
        plushRoot = (PLUSHSUIT_DATA.Root)ConstantVariables.Instance.MasterDataDownloader.GetMasterDataDeserialized(typeof(PLUSHSUIT_DATA));
        attackRoot = (ATTACK_DATA.Root)ConstantVariables.Instance.MasterDataDownloader.GetMasterDataDeserialized(typeof(ATTACK_DATA));
    }

    private IEnumerator<WaitForSeconds> SpawnAll()
    {
        for (int i = 0; i < PlushSuitIdsToSpawn.Count; i++)
        {
            SpawnOne(PlushSuitIdsToSpawn[i], i);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnOne(string id, int index)
    {
        var cpu = cpuRoot.Entries.Find(e => e.Logical == id);
        var plush = plushRoot.Entries.Find(e => e.Logical == id);
        var attack = attackRoot.Entries.Find(e => e.Logical == id);

        if (cpu == null || plush == null || attack == null)
        {
            Debug.LogWarning($"[Spawn] Skipped {id} - missing data.");
            return;
        }

        var config = new AnimatronicConfigData(new CPUData(cpu), new PlushSuitData(plush), new AttackProfile(attack));
        var request = new CreationRequest(config, null);

        // Set position after creation
        request.OnRequestComplete += (completedRequest) =>
        {
            if (completedRequest.Animatronic3D != null)
            {
                Vector3 spawnPos = baseSpawnPosition + offset * index;
                completedRequest.Animatronic3D.transform.position = spawnPos;
                Debug.Log($"[Spawn] Placed: {id} at {spawnPos}");
            }
        };

        animDomain.CreateAnimatronic3D(request);
    }
}
