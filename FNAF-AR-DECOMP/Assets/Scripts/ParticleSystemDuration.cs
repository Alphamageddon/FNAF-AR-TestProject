using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ParticleSystemDuration : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.ParticleSystem[] particleSystems;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float GetDuration()
    {
        goto label_1;
        label_6:
        float val_2 = ParticleSystemDuration.GetIndividualDuration(particle:  this.particleSystems[0]);
        0 = 1;
        label_1:
        if(0 < this.particleSystems.Length)
        {
            goto label_6;
        }
        
        return System.Linq.Enumerable.Max(source:  new Boo.Lang.List<System.Single>());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static float GetIndividualDuration(UnityEngine.ParticleSystem particle)
    {
        var val_4;
        float val_14;
        MainModule val_1 = particle.main;
        float val_2 = val_1.m_ParticleSystem.duration;
        MinMaxCurve val_3 = val_1.m_ParticleSystem.startLifetime;
        val_14 = val_4.targetValue;
        EmissionModule val_7 = particle.emission;
        if(1390897656 < 1)
        {
            goto label_2;
        }
        
        if(val_2 > val_14)
        {
                val_14 = val_2;
        }
        
        label_8:
        TrailModule val_8 = particle.trails;
        if(val_8.m_ParticleSystem.enabled == false)
        {
                return (float)val_14;
        }
        
        TrailModule val_10 = particle.trails;
        val_14 = val_14 + val_4.targetValue;
        return (float)val_14;
        label_2:
        val_14 = val_2 + val_14;
        if(particle != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ParticleSystemDuration()
    {
    
    }

}
