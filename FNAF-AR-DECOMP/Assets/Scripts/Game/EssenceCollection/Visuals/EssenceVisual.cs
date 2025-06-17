using UnityEngine;

namespace Game.EssenceCollection.Visuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceVisual : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _nodeVisuals;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.MoteVisual _motePrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.ThreatPillVisual _threatPillPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Audio.Components.AkAudioEmitter _akAudioEmitter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <EssenceType>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _inUse;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EssenceType { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject NodeVisuals { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Visuals.MoteVisual MotePrefab { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Visuals.ThreatPillVisual ThreatPillPrefab { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Audio.Components.AkAudioEmitter AkAudioEmitter { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool InUse { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_EssenceType()
        {
            return (string)this.<EssenceType>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EssenceType(string value)
        {
            this.<EssenceType>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject get_NodeVisuals()
        {
            return (UnityEngine.GameObject)this._nodeVisuals;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Visuals.MoteVisual get_MotePrefab()
        {
            return (Game.EssenceCollection.Visuals.MoteVisual)this._motePrefab;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Visuals.ThreatPillVisual get_ThreatPillPrefab()
        {
            return (Game.EssenceCollection.Visuals.ThreatPillVisual)this._threatPillPrefab;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Audio.Components.AkAudioEmitter get_AkAudioEmitter()
        {
            return (Systems.Audio.Components.AkAudioEmitter)this._akAudioEmitter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_InUse()
        {
            return (bool)this._inUse;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_InUse(bool value)
        {
            this._inUse = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceVisual()
        {
        
        }
    
    }

}
