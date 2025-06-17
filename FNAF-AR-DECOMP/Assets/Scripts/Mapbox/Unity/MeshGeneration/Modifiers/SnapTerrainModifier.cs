using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SnapTerrainModifier : MeshModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double scaledX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double scaledY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter;
        
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
            var val_4;
            var val_11;
            var val_39;
            float val_41;
            System.Collections.Generic.List<UnityEngine.Vector3> val_42;
            var val_43;
            double val_44;
            float val_45;
            val_39 = tile;
            Mapbox.Utils.RectD val_1 = val_39.Rect;
            Mapbox.Utils.Vector2d val_6 = val_4.Max;
            double val_39 = (double)val_39.TileScale;
            val_39 = val_6.x * val_39;
            this.scaledX = val_39;
            Mapbox.Utils.RectD val_8 = val_39.Rect;
            Mapbox.Utils.Vector2d val_13 = val_11.Max;
            val_41 = val_13.y;
            double val_40 = (double)val_39.TileScale;
            val_40 = val_41 * val_40;
            this.scaledY = val_40;
            val_42 = md.Vertices;
            int val_15 = val_42.Count;
            this._counter = val_15;
            if(val_15 >= 1)
            {
                    val_43 = 1152921504840871936;
                var val_42 = 0;
                val_44 = 0.5;
                do
            {
                UnityEngine.Vector3 val_16 = md.Vertices.Item[0];
                UnityEngine.Vector3 val_17 = md.Vertices.Item[0];
                val_17.z = val_17.z + S14;
                double val_41 = (double)val_16.x + md.PositionInTile;
                val_41 = (this.scaledX * val_44) + val_41;
                double val_21 = (this.scaledY * val_44) + (double)val_17.z;
                val_41 = val_41 / this.scaledX;
                val_21 = val_21 / this.scaledY;
                float val_22 = val_39.QueryHeightData(x:  (float)val_41, y:  (float)val_21);
                val_42 = md.Vertices;
                UnityEngine.Vector3 val_23 = val_42.Item[0];
                val_4 = 0;
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_41 = val_24.x;
                val_45 = val_24.z;
                val_42.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_41, y = val_24.y, z = val_45});
                val_42 = val_42 + 1;
            }
            while(val_42 < this._counter);
            
                return;
            }
            
            List.Enumerator<T> val_25 = feature.Points.GetEnumerator();
            val_43 = 1152921519706114784;
            val_44 = 0.5;
            goto label_21;
            label_31:
            GameUI.EmailUIDataHandler val_26 = val_4.emailUIDataHandler;
            int val_27 = val_26.Count;
            this._counter = val_27;
            if(val_27 >= 1)
            {
                    do
            {
                UnityEngine.Vector3 val_28 = val_26.Item[0];
                UnityEngine.Vector3 val_29 = val_26.Item[0];
                val_29.z = val_29.z + S14;
                double val_43 = (double)val_28.x + md.PositionInTile;
                val_43 = (this.scaledX * val_44) + val_43;
                double val_33 = (this.scaledY * val_44) + (double)val_29.z;
                val_43 = val_43 / this.scaledX;
                val_33 = val_33 / this.scaledY;
                float val_34 = val_39.QueryHeightData(x:  (float)val_43, y:  (float)val_33);
                UnityEngine.Vector3 val_35 = val_26.Item[0];
                val_4 = 0;
                UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_41 = val_36.x;
                val_45 = val_36.z;
                val_26.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_41, y = val_36.y, z = val_45});
                val_42 = 0 + 1;
            }
            while(val_42 < this._counter);
            
            }
            
            label_21:
            if(((-2073575376) & 1) != 0)
            {
                goto label_31;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SnapTerrainModifier()
        {
            mem[1152921519713314184] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
