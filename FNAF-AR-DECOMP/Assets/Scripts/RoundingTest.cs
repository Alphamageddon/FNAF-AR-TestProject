using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class RoundingTest : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool activate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float precision;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 orig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 Pos;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.Pos = this.orig;
        mem[1152921519006472676] = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this.activate != false)
        {
                this.Pos = RoundingTest.RoundUpToNearest(passednumber:  this.orig, roundto:  this.precision);
        }
        else
        {
                this.Pos = this.orig;
            mem[1152921519006588772] = ???;
        }
        
        this.transform.position = new UnityEngine.Vector3() {x = this.Pos, y = V9.16B, z = V10.16B};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float RoundUpToNearest(float passednumber, float roundto)
    {
        float val_1 = passednumber;
        if(roundto == 0f)
        {
                return (float)val_1;
        }
        
        passednumber = val_1 / roundto;
        val_1 = passednumber * roundto;
        return (float)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float RoundDownToNearest(float passednumber, float roundto)
    {
        float val_1 = passednumber;
        if(roundto == 0f)
        {
                return (float)val_1;
        }
        
        passednumber = val_1 / roundto;
        val_1 = passednumber * roundto;
        return (float)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public RoundingTest()
    {
        this.precision = 0.05f;
        this.orig = 0;
        mem[1152921519006928856] = 0;
    }

}
