using System.Collections;
using UnityEngine;

public class ReportController : MonoBehaviour
{
	public static ReportController Instance;

	public Transform ReportParent;

	public Report ReportPrefab;

	private string reportData;

	private string cachedMapEntities;

	private void Awake()
	{
		Instance = this;
	}

	private void Start()
	{
		reportData = null;
		StartCoroutine(ConvertMapEntities());
	}

	private IEnumerator ConvertMapEntities()
	{
		yield return new WaitUntil(() => reportData != null);
		Debug.Log(reportData);
		yield return null;
	}

	public void SetReportData(string data)
	{
		reportData = data;
	}
}
