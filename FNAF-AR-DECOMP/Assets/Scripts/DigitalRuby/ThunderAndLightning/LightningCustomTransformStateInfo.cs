using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningCustomTransformStateInfo
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DigitalRuby.ThunderAndLightning.LightningCustomTransformState <State>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DigitalRuby.ThunderAndLightning.LightningBoltParameters <Parameters>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 BoltStartPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 BoltEndPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Transform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform StartTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform EndTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object UserInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo> cache;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningCustomTransformState State { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningBoltParameters Parameters { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningCustomTransformState get_State()
        {
            return (DigitalRuby.ThunderAndLightning.LightningCustomTransformState)this.<State>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_State(DigitalRuby.ThunderAndLightning.LightningCustomTransformState value)
        {
            this.<State>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningBoltParameters get_Parameters()
        {
            return (DigitalRuby.ThunderAndLightning.LightningBoltParameters)this.<Parameters>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Parameters(DigitalRuby.ThunderAndLightning.LightningBoltParameters value)
        {
            this.<Parameters>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo GetOrCreateStateInfo()
        {
            var val_5;
            System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo> val_6;
            var val_7;
            var val_8;
            val_5 = null;
            val_5 = null;
            val_6 = DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo.cache;
            val_7 = null;
            if(val_6.Count != 0)
            {
                    val_7 = null;
                val_6 = DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo.cache.Count - 1;
                val_8 = DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo.cache.Item[val_6];
                DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo.cache.RemoveAt(index:  val_6);
                return (DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo)val_8;
            }
            
            DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo val_4 = null;
            val_8 = val_4;
            val_4 = new DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo();
            return (DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ReturnStateInfoToCache(DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo info)
        {
            var val_1;
            if(info == null)
            {
                    return;
            }
            
            info.EndTransform = 0;
            info.Transform = 0;
            val_1 = null;
            val_1 = null;
            DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo.cache.Add(item:  info);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningCustomTransformStateInfo()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static LightningCustomTransformStateInfo()
        {
            DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo.cache = new System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo>();
        }
    
    }

}
