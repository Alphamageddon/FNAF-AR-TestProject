using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DisplayAnimatronic : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Name;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int index;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool debug;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float DisplayRate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float DisplayTimer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<UnityEngine.Transform> origAnimatronicList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<UnityEngine.Transform> animatronicList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 origPos;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float timeLeft;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        string val_24;
        var val_25;
        var val_26;
        var val_27;
        System.Collections.Generic.List<UnityEngine.Transform> val_28;
        string val_29;
        System.DateTime val_1 = System.DateTime.Now;
        UnityEngine.Random.InitState(seed:  val_1.dateData.Ticks);
        val_24 = "";
        val_25 = 0;
        goto label_3;
        label_10:
        T val_24 = this.GetComponentsInChildren<UnityEngine.Transform>()[0];
        if((System.String.op_Inequality(a:  val_24.name, b:  "Animatronics")) != false)
        {
                this.origAnimatronicList.Add(item:  val_24);
            val_24 = val_24 + val_24.name + ", ";
        }
        
        val_25 = 1;
        label_3:
        if(val_25 < val_3.Length)
        {
            goto label_10;
        }
        
        if(this.debug != false)
        {
                UnityEngine.Debug.Log(message:  val_24);
        }
        
        var val_25 = this.origAnimatronicList.Count;
        if(val_25 >= 1)
        {
                val_26 = 1152921518864941648;
            do
        {
            int val_10 = UnityEngine.Random.Range(min:  0, max:  this.origAnimatronicList.Count);
            this.animatronicList.Add(item:  this.origAnimatronicList.Item[val_10]);
            this.origAnimatronicList.RemoveAt(index:  val_10);
            val_25 = val_25 - 1;
        }
        while(val_25 != 0);
        
        }
        
        if(this.debug == false)
        {
            goto label_21;
        }
        
        val_27 = 0;
        val_28 = this.animatronicList;
        val_29 = "";
        val_26 = 1152921518850221328;
        goto label_22;
        label_26:
        val_29 = val_29 + this.animatronicList.SyncRoot.Item[0].name + ", ";
        val_27 = 1;
        label_22:
        if(val_27 < this.animatronicList.SyncRoot.Count)
        {
            goto label_26;
        }
        
        UnityEngine.Debug.Log(message:  val_29);
        goto label_29;
        label_21:
        val_28 = this.animatronicList;
        label_29:
        this.Name = this.animatronicList.SyncRoot.Item[0].name;
        this.animatronicList.Item[0].transform.GetComponent<UnityEngine.UI.RawImage>().enabled = true;
        UnityEngine.Vector3 val_23 = this.animatronicList.Item[this.index].transform.position;
        this.origPos = val_23;
        mem[1152921518865037396] = val_23.y;
        mem[1152921518865037400] = val_23.z;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DisplayAnimatronic()
    {
        this.DisplayRate = 1f;
        this.origAnimatronicList = new System.Collections.Generic.List<UnityEngine.Transform>();
        this.animatronicList = new System.Collections.Generic.List<UnityEngine.Transform>();
        this.timeLeft = 1f;
    }

}
