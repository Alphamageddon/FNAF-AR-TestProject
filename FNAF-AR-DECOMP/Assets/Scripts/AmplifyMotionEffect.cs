using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AmplifyMotionEffect : AmplifyMotionEffectBase
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AmplifyMotionEffect FirstInstance { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AmplifyMotionEffect Instance { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AmplifyMotionEffect get_FirstInstance()
    {
        var val_4;
        if(AmplifyMotionEffectBase.FirstInstance == null)
        {
                return (AmplifyMotionEffect)val_4;
        }
        
        val_4 = 0;
        return (AmplifyMotionEffect)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AmplifyMotionEffect get_Instance()
    {
        var val_4;
        if(AmplifyMotionEffectBase.Instance == null)
        {
                return (AmplifyMotionEffect)val_4;
        }
        
        val_4 = 0;
        return (AmplifyMotionEffect)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AmplifyMotionEffect()
    {
    
    }

}
