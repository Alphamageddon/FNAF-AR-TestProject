using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SnapTerrainRaycastModifier : MeshModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int RAY_LENGTH = 50;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.LayerMask _terrainMask;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double scaledX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double scaledY;
        
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
            var val_5;
            var val_11;
            var val_17;
            var val_47;
            var val_48;
            float val_50;
            float val_51;
            val_47 = tile;
            Mapbox.Utils.RectD val_1 = val_47.Rect;
            Mapbox.Utils.Vector2d val_6 = val_5.Max;
            double val_47 = (double)val_47.TileScale;
            val_47 = val_6.x * val_47;
            this.scaledX = val_47;
            Mapbox.Utils.RectD val_8 = val_47.Rect;
            Mapbox.Utils.Vector2d val_13 = val_11.Max;
            double val_48 = (double)val_47.TileScale;
            val_48 = val_13.y * val_48;
            this.scaledY = val_48;
            List.Enumerator<T> val_15 = feature.Points.GetEnumerator();
            goto label_7;
            label_35:
            GameUI.EmailUIDataHandler val_18 = val_17.emailUIDataHandler;
            val_48 = 0;
            goto label_8;
            label_34:
            UnityEngine.Vector3 val_19 = val_18.Item[0];
            UnityEngine.Vector3 val_20 = val_18.Item[0];
            val_20.z = val_20.z + S15;
            double val_49 = (double)val_19.x + md.PositionInTile;
            val_49 = (this.scaledX * 0.5) + val_49;
            double val_24 = (this.scaledY * 0.5) + (double)val_20.z;
            val_49 = val_49 / this.scaledX;
            val_24 = val_24 / this.scaledY;
            UnityEngine.Vector3 val_26 = val_18.Item[0];
            UnityEngine.Vector3 val_28 = val_47.transform.position;
            UnityEngine.Vector3 val_29 = val_18.Item[0];
            UnityEngine.Vector3 val_31 = val_47.transform.position;
            float val_32 = val_26.x + md.PositionInTile;
            float val_50 = 25f;
            val_5 = 0;
            val_50 = (val_47.QueryHeightData(x:  (float)val_49, y:  (float)val_24)) + val_50;
            val_32 = val_32 + val_28.x;
            val_31.z = (val_29.z + this.scaledY) + val_31.z;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.down;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, direction:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  250f, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this._terrainMask}))) != false)
            {
                    UnityEngine.Vector3 val_37 = val_18.Item[0];
                val_50 = val_37.y;
                UnityEngine.Vector3 val_39 = val_47.transform.position;
                val_5 = 0;
                val_39.y = (val_50 + this.scaledY) - val_39.y;
                UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_51 = val_41.y;
                val_18.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_41.x, y = val_51, z = val_41.z});
            }
            else
            {
                    UnityEngine.Vector3 val_42 = val_18.Item[0];
                val_50 = val_42.z;
                val_5 = 0;
                UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_50}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_51 = val_43.y;
                val_18.set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_43.x, y = val_51, z = val_43.z});
            }
            
            val_48 = 1;
            label_8:
            if(val_48 < val_18.Count)
            {
                goto label_34;
            }
            
            label_7:
            if(((-2073145232) & 1) != 0)
            {
                goto label_35;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SnapTerrainRaycastModifier()
        {
            mem[1152921519713740232] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
