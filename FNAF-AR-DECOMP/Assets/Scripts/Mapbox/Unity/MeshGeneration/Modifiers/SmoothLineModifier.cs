using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SmoothLineModifier : MeshModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int _maxEdgeSectionCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int _preferredEdgeSectionLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter2;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Unity.MeshGeneration.Modifiers.ModifierType Type { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Unity.MeshGeneration.Modifiers.ModifierType get_Type()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature, Mapbox.Unity.MeshGeneration.Data.MeshData md, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> val_22;
            Mapbox.Unity.MeshGeneration.Modifiers.SmoothLineModifier val_23;
            int val_24;
            var val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            val_22 = feature.Points;
            val_23 = this;
            int val_1 = val_22.Count;
            mem[1152921519712690132] = val_1;
            if(val_1 < 1)
            {
                    return;
            }
            
            label_33:
            System.Collections.Generic.List<UnityEngine.Vector3> val_2 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            val_24 = feature.Points.Item[0].Count;
            mem[1152921519712690136] = val_24;
            val_25 = 1;
            goto label_6;
            label_32:
            UnityEngine.Vector3 val_6 = X25.Item[0].Item[0];
            val_2.Add(item:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_8 = feature.Points.Item[0].Item[0];
            UnityEngine.Vector3 val_10 = feature.Points.Item[0].Item[1];
            val_26 = val_10.x;
            val_27 = val_8.z;
            val_28 = (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_27}, b:  new UnityEngine.Vector3() {x = val_26, y = val_10.y, z = val_10.z})) / (float)mem[1152921519712690128];
            float val_12 = System.Math.Min(val1:  (float)mem[1152921519712690124], val2:  val_28);
            val_29 = 1f;
            if(val_12 > val_29)
            {
                    var val_22 = 2;
                do
            {
                UnityEngine.Vector3 val_14 = feature.Points.Item[0].Item[0];
                val_26 = val_14.z;
                UnityEngine.Vector3 val_16 = feature.Points.Item[0].Item[1];
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_26}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, t:  UnityEngine.Mathf.Min(a:  1f, b:  1f / val_12));
                val_29 = val_19.x;
                val_28 = val_19.y;
                val_27 = val_19.z;
                val_2.Add(item:  new UnityEngine.Vector3() {x = val_29, y = val_28, z = val_27});
                val_22 = val_22 + 1;
            }
            while(val_12 > 2f);
            
            }
            
            val_23 = this;
            UnityEngine.Vector3 val_21 = feature.Points.Item[0].Item[1];
            val_2.Add(item:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            val_24 = mem[1152921519712690136];
            val_25 = 2;
            label_6:
            if(val_25 < val_24)
            {
                goto label_32;
            }
            
            feature.Points.set_Item(index:  0, value:  val_2);
            val_22 = 0 + 1;
            if(val_22 < mem[1152921519712690132])
            {
                goto label_33;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SmoothLineModifier()
        {
            this._maxEdgeSectionCount = 40;
            this._preferredEdgeSectionLength = 10;
            mem[1152921519712879944] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
