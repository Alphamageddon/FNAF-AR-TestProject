using UnityEngine;

namespace SharedTechAssets.Scripts.TSDF2
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TSDF_Updater
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDF2.TSDF_Manager domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDF2.TSDF_Config2 config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int[] intBuffer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TSDF_Updater(SharedTechAssets.Scripts.TSDF2.TSDF_Manager tsdfDomain)
        {
            this.domain = tsdfDomain;
            this.config = tsdfDomain.config;
            this.intBuffer = new int[3];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float CalculateNorm(UnityEngine.Vector3 v)
        {
            v.x = v.x * v.x;
            v.x = v.x + (v.x * v.x);
            float val_2 = v.x * v.x;
            val_2 = v.x + val_2;
            if(v.x < _TYPE_MAX_)
            {
                    return (float)val_2;
            }
            
            return (float)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.IntVector3.IntVector3 DiscretizeVertex(UnityEngine.Vector3 vertex)
        {
            var val_7 = 0;
            do
            {
                TSDF_Properties val_5 = this.domain.config.props;
                val_5 = System.Math.Abs(vertex.x) / val_5;
                int val_6 = (int)val_5;
                val_5 = val_5 - (float)val_6;
                val_6 = ((val_5 > 0.5f) ? 1 : 0) + val_6;
                int val_2 = (vertex.x < 0) ? (-val_6) : (val_6);
                val_2 = val_2 << 1;
                val_7 = val_7 + 1;
                this.intBuffer[val_7] = val_2;
            }
            while(val_7 != 3);
            
            return (com.illumix.IntVector3.IntVector3)this.domain.GenerateIntVector(x:  this.intBuffer[0], y:  this.intBuffer[1], z:  this.intBuffer[2]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double GetDistance(UnityEngine.Vector3 vertex, UnityEngine.Vector3 cameraPos)
        {
            vertex.x = vertex.x - cameraPos.x;
            vertex.y = vertex.y - cameraPos.y;
            vertex.z = vertex.z - cameraPos.z;
            double val_1 = (double)vertex.x;
            double val_2 = (double)vertex.y;
            double val_3 = (double)vertex.z;
            val_1 = val_1 * val_1;
            val_2 = val_2 * val_2;
            val_3 = val_3 * val_3;
            val_1 = val_1 + val_2;
            val_1 = val_3 + val_1;
            if(val_2 <= _TYPE_MAX_)
            {
                    return (double)val_2;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateInBand(UnityEngine.Vector3 vertex, UnityEngine.Vector3 cameraPt, SharedTechAssets.Scripts.TSDF2.TSDF_Manager.TSDF_Data data)
        {
            var val_36;
            SharedTechAssets.Scripts.TSDF2.TSDF_Updater val_37;
            SharedTechAssets.Scripts.TSDF2.TSDF_Config2 val_38;
            SharedTechAssets.Scripts.TSDF2.TSDF_Config2 val_40;
            float val_41;
            float val_42;
            TSDF_Properties val_43;
            float val_44;
            SharedTechAssets.Scripts.TSDF2.TSDF_Manager val_45;
            float val_46;
            float val_47;
            var val_48;
            float val_49;
            float val_50;
            float val_51;
            var val_52;
            var val_53;
            float val_54;
            float val_55;
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>> val_56;
            SharedTechAssets.Scripts.TSDF2.TSDF_Config2 val_57;
            int val_58;
            SharedTechAssets.Scripts.TSDF2.TSDF_Config2 val_59;
            var val_61;
            com.illumix.IntVector3.IntVector3 val_62;
            var val_63;
            val_36 = 1152921523051391520;
            val_37 = this;
            SharedTechAssets.Scripts.TSDF2.VoxelBlock val_28 = 0;
            val_38 = this.config;
            if(val_38 == null)
            {
                goto label_1;
            }
            
            goto label_2;
            label_1:
            val_40 = this.config;
            if(val_40 == null)
            {
                goto label_3;
            }
            
            val_38 = val_40;
            label_2:
            label_60:
            label_61:
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = vertex.x, y = vertex.y, z = vertex.z}, b:  new UnityEngine.Vector3() {x = cameraPt.x, y = cameraPt.y, z = cameraPt.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  this.CalculateNorm(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}));
            val_41 = val_3.x;
            val_42 = val_3.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  V15.16B);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = vertex.x, y = vertex.y, z = vertex.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_43 = this.config.props;
            val_44 = val_5.x;
            val_45 = this.domain;
            float val_6 = S15 + S15;
            val_6 = val_6 / val_43;
            val_46 = val_5.y;
            val_47 = val_5.z;
            val_48 = (int)val_6 + 1;
            if(val_48 < (1.401298E-45f))
            {
                    return;
            }
            
            val_40 = 1152921504621436928;
            val_49 = val_43 * val_3.y;
            val_46 = val_43 * val_42;
            val_44 = 1f;
            val_50 = V15.16B;
            label_59:
            val_45 = this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = val_44, y = val_46, z = val_47});
            if((val_45.GenerateIntVector(x:  0, y:  999, z:  0)) == val_45)
            {
                goto label_23;
            }
            
            com.illumix.IntVector3.IntVector3 val_10 = this.domain.GetBlockKey(discretePoint:  val_45);
            if((data.tsdfStore.TryGetValue(key:  val_10, value: out  0)) != true)
            {
                    System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, SharedTechAssets.Scripts.TSDF2.Voxel> val_13 = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, SharedTechAssets.Scripts.TSDF2.Voxel>();
                data.tsdfStore.set_Item(key:  val_10, value:  val_13);
            }
            
            if((val_13.ContainsKey(key:  val_45)) != true)
            {
                    .sdf = 0f;
                .weight = 0f;
                val_13.set_Item(key:  val_45, value:  new SharedTechAssets.Scripts.TSDF2.Voxel());
            }
            
            SharedTechAssets.Scripts.TSDF2.Voxel val_16 = val_13.Item[val_45];
            val_51 = val_44;
            if(this.config.weightSystem != 0)
            {
                    float val_33 = System.Math.Abs(val_50);
                val_33 = val_33 / S15;
                val_51 = val_44 - val_33;
            }
            
            if(val_16 != null)
            {
                    val_52 = val_16;
                float val_34 = val_16.sdf;
                val_53 = val_16 + 16;
                val_34 = val_34 * (val_16 + 16 + 4);
                val_54 = val_51 + (val_16 + 16 + 4);
                val_34 = (val_50 * val_51) + val_34;
                val_34 = val_34 / val_54;
                mem2[0] = val_34;
                mem2[0] = val_54;
            }
            else
            {
                    val_53 = val_16;
                float val_18 = (1.68059E-38f) * val_16.weight;
                val_55 = val_50;
                val_18 = (val_55 * val_51) + val_18;
                val_43 = this.config.props;
                val_18 = val_18 / (val_51 + (val_16 + 20));
                mem[16] = val_18;
                val_49 = val_49;
                val_46 = val_46;
                val_47 = val_47;
                val_44 = 1f;
                mem2[0] = val_51 + (val_16 + 20);
                val_54 = mem[val_16 + 20];
                val_54 = val_16 + 20;
                val_52 = 16;
            }
            
            if(val_54 > (float)this.config.maxWeight)
            {
                    mem2[0] = (float)this.config.maxWeight;
            }
            
            val_56 = data.lastUpdatedBlocks;
            if((data.lastUpdatedBlocks.ContainsKey(key:  val_10)) == true)
            {
                goto label_29;
            }
            
            val_57 = this.config;
            if(val_57 == null)
            {
                goto label_30;
            }
            
            val_58 = this.config.blockSize;
            val_59 = val_57;
            goto label_33;
            label_30:
            val_59 = this.config;
            val_58 = this.config.blockSize;
            if(val_59 == null)
            {
                goto label_32;
            }
            
            val_57 = val_59;
            goto label_33;
            label_32:
            val_57 = this.config;
            if(val_57 == null)
            {
                goto label_34;
            }
            
            label_33:
            val_56 = data.lastUpdatedBlocks;
            data.lastUpdatedBlocks.set_Item(key:  val_10, value:  new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>(capacity:  (this.config.blockSize * val_58) * this.config.blockSize));
            val_37 = val_37;
            val_36 = val_36;
            label_29:
            bool val_26 = data.blocksToUpdateCoords.Add(item:  val_10);
            val_40 = 1152921504621436928;
            if(System.Math.Abs(val_52) <= this.config.props)
            {
                    if((val_16 + 20) >= this.config.weightThreshold)
            {
                goto label_43;
            }
            
            }
            
            val_38 = val_45;
            if((mem[16].TryGetValue(key:  val_10, value: out  val_28)) == false)
            {
                goto label_57;
            }
            
            val_38 = val_28;
            if((mem[16].Contains(item:  val_45)) == false)
            {
                goto label_57;
            }
            
            val_61 = 1152921518993332992;
            val_62 = val_45;
            val_63 = 0;
            goto label_51;
            label_43:
            val_38 = val_45;
            if((mem[16].TryGetValue(key:  val_10, value: out  val_28)) == false)
            {
                goto label_54;
            }
            
            val_38 = val_28;
            if((mem[16].Contains(item:  val_45)) == true)
            {
                goto label_57;
            }
            
            label_54:
            val_61 = 1152921518993332992;
            val_63 = 1;
            val_62 = val_45;
            label_51:
            data.lastUpdatedBlocks.Item[val_10].set_Item(key:  val_62, value:  true);
            label_57:
            float val_36 = val_44;
            val_42 = val_55 - val_43;
            val_47 = val_46 + val_47;
            val_36 = (val_43 * val_41) + val_36;
            float val_37 = val_46;
            val_37 = val_49 + val_37;
            label_23:
            val_48 = val_48 - 1;
            if(val_48 != 0)
            {
                goto label_59;
            }
            
            return;
            label_3:
            if(this.config != null)
            {
                goto label_60;
            }
            
            if(this.config != null)
            {
                goto label_61;
            }
            
            label_34:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add_FeaturePoints(UnityEngine.Vector3[] points, UnityEngine.Vector3 cameraPosition)
        {
            goto label_0;
            label_4:
            this.UpdateInBand(vertex:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 1.85775E-36f}, cameraPt:  new UnityEngine.Vector3() {x = cameraPosition.x, y = cameraPosition.y, z = cameraPosition.z}, data:  new TSDF_Data() {tsdfStore = this.domain.data, cachedBlocks = this.domain.data, lastUpdatedBlocks = cameraPosition.x});
            0 = 1;
            label_0:
            if(0 < points.Length)
            {
                goto label_4;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Add_DepthModel_Depth(UnityEngine.Vector3[,] vertices, bool[,] keepMask, UnityEngine.Vector3 cameraPt)
        {
            var val_9;
            var val_10;
            SharedTechAssets.Scripts.TSDF2.TSDF_Config2 val_12;
            val_9 = 0;
            goto label_1;
            label_27:
            val_10 = 0;
            goto label_2;
            label_25:
            var val_1 = 0 + (16824064 * 0);
            val_1 = vertices + (val_1 * 12);
            val_12 = this.config;
            if(this.config.useMask == false)
            {
                goto label_7;
            }
            
            val_12 = mem[this.config.useMask + 16];
            val_12 = this.config.useMask + 16;
            if((keepMask[0 + (val_12 * 0)]) == false)
            {
                goto label_22;
            }
            
            label_7:
            if(this.config.useBlockMask == false)
            {
                goto label_13;
            }
            
            com.illumix.IntVector3.IntVector3 val_4 = this.domain.GetBlockKey(discretePoint:  this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = ((16824064 * 0) + 0 * 12) + vertices + 32, y = ((16824064 * 0) + 0 * 12) + vertices + 32 + 4, z = ((16824064 * 0) + 0 * 12) + vertices + 40}));
            if((this.domain.ContainsKey(key:  val_4)) == false)
            {
                goto label_22;
            }
            
            SharedTechAssets.Scripts.TSDF2.VoxelBlock val_6 = this.domain.Item[val_4];
            if(val_6.tsdfCoords.Count == 0)
            {
                goto label_22;
            }
            
            label_13:
            this.UpdateInBand(vertex:  new UnityEngine.Vector3() {x = ((16824064 * 0) + 0 * 12) + vertices + 32, y = ((16824064 * 0) + 0 * 12) + vertices + 32 + 4, z = ((16824064 * 0) + 0 * 12) + vertices + 40}, cameraPt:  new UnityEngine.Vector3() {x = cameraPt.x, y = cameraPt.y, z = cameraPt.z}, data:  new TSDF_Data() {tsdfStore = this.domain.data, cachedBlocks = this.domain.data, lastUpdatedBlocks = ((16824064 * 0) + 0 * 12) + vertices + 32, blocksToUpdateCoords = ((16824064 * 0) + 0 * 12) + vertices + 32, coordsToUpdate = 1152921518993873408});
            label_22:
            val_10 = 1;
            label_2:
            if(val_10 < (vertices.GetLength(dimension:  1)))
            {
                goto label_25;
            }
            
            val_9 = 1;
            label_1:
            if(val_9 < (vertices.GetLength(dimension:  0)))
            {
                goto label_27;
            }
        
        }
    
    }

}
