using UnityEngine;

namespace SharedTechAssets.Scripts.TSDFMinusPlanes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TSDFMinusPlanesManager : IBlockCoordAccepter, IBoundedPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float CubeLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> discretizedPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<UnityEngine.Vector2, SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager.Tile>> _heightToPlaneTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector2, SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager.TileColumn> _columnTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.TSDFMinusPlanes.HorizontalBoundedPlane> _horizontalPlanes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.TSDFMinusPlanes.VerticalBoundedPlane> _verticalPlanes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private com.illumix.IntVector3.IntVector3Cache _coordCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDFMinusPlanes.MarchingCubes _marchingCubes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDFMinusPlanes.ConnectedComponentsTracker _ccTracker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float minHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser _blockCoordDispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int HORIZONTAL_PLANE_VALUES_TO_CHECK_UNDER = -2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int HORIZONTAL_PLANE_VALUES_TO_CHECK_ABOVE = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> pointsToRemove;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float pointAddTolerance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int MULT_BEHIND_VERTICAL_PLANE;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int MULT_AHEAD_VERTICAL_PLANE;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float resolution;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int[] intBuffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, bool> updatedPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 bufferPoint2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 bufferPoint3;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(MeshBlockDispenser dispenser, SharedTechAssets.Scripts.TechInterfaces.Dispensers.BlockCoordDispenser blockCoordDispenser, com.illumix.IntVector3.IntVector3Cache coordCache)
        {
            this._coordCache = coordCache;
            this._heightToPlaneTiles = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<UnityEngine.Vector2, Tile>>();
            this._columnTiles = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, TileColumn>();
            this._horizontalPlanes = new System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.TSDFMinusPlanes.HorizontalBoundedPlane>();
            this._verticalPlanes = new System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.TSDFMinusPlanes.VerticalBoundedPlane>();
            this.discretizedPoints = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            this._ccTracker = new SharedTechAssets.Scripts.TSDFMinusPlanes.ConnectedComponentsTracker(coordCache:  coordCache);
            this._blockCoordDispenser = blockCoordDispenser;
            this._marchingCubes = new SharedTechAssets.Scripts.TSDFMinusPlanes.MarchingCubes(cache:  coordCache, dispenser:  dispenser);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager.Intersection HorizontalPlaneMeshBlockIntersection(SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager.Tile tile, SharedTechAssets.Scripts.TSDFMinusPlanes.HorizontalBoundedPlane plane)
        {
            bool val_2 = plane.PointWithinHorizontalPolygon(point:  new UnityEngine.Vector3() {x = tile.minCoords, y = V9.16B, z = V10.16B});
            val_2 = ((plane.PointWithinHorizontalPolygon(point:  new UnityEngine.Vector3() {x = tile.maxCoords, y = V9.16B, z = V10.16B})) != true) ? ((val_2 == true) ? (1 + 1) : 1) : (val_2);
            bool val_8 = plane.PointWithinHorizontalPolygon(point:  new UnityEngine.Vector3() {x = tile.minCoords, y = V9.16B, z = tile.maxCoords});
            bool val_9 = val_8;
            val_9 = (val_2 + (plane.PointWithinHorizontalPolygon(point:  new UnityEngine.Vector3() {x = tile.maxCoords, y = tile.maxCoords, z = V9.16B}))) + val_9;
            val_8 = (val_9 == false) ? 2 : ((val_9 != true) ? 1 : 0);
            return (Intersection)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool VerticalPlaneColumnIntersection(SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager.TileColumn column, SharedTechAssets.Scripts.TSDFMinusPlanes.VerticalBoundedPlane plane)
        {
            var val_4;
            UnityEngine.Vector3 val_5;
            UnityEngine.Vector3 val_6;
            float val_7;
            UnityEngine.Vector2 val_8;
            float val_9;
            float val_10;
            UnityEngine.Vector2 val_11;
            var val_12;
            var val_13;
            val_4 = plane;
            if(val_4 != null)
            {
                    val_5 = plane.MinCoord;
                val_6 = plane.MaxCoord;
            }
            else
            {
                    val_5 = 0f;
                val_7 = 1.099368E-36f;
                val_6 = 0f;
            }
            
            if(column != null)
            {
                    val_8 = column.minCoords;
                val_11 = column.maxCoords;
                val_12 = val_8;
                val_13 = V8.16B;
            }
            else
            {
                    val_4 = 28;
                val_8 = 2.105703E-38f;
                val_10 = 0f;
                val_11 = 8.96831E-44f;
                val_13 = 0f;
                val_12 = 2.105703E-38f;
                val_5 = val_5;
                val_9 = 0f;
            }
            
            if((this.lineSegmentIntersection(x1:  val_5, x2:  val_6, y1:  val_7, y2:  V13.16B, x3:  2.105703E-38f, x4:  val_8, y3:  0f, y4:  val_10)) == true)
            {
                    return true;
            }
            
            if((this.lineSegmentIntersection(x1:  val_5, x2:  val_6, y1:  val_7, y2:  V13.16B, x3:  8.96831E-44f, x4:  val_11, y3:  0f, y4:  val_9)) == true)
            {
                    return true;
            }
            
            if((this.lineSegmentIntersection(x1:  val_5, x2:  val_6, y1:  val_7, y2:  V13.16B, x3:  val_8, x4:  8.96831E-44f, y3:  val_10, y4:  0f)) == false)
            {
                    return this.lineSegmentIntersection(x1:  val_5, x2:  val_6, y1:  val_7, y2:  V13.16B, x3:  2.105703E-38f, x4:  val_11, y3:  0f, y4:  val_9);
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool sameSigns(float a, float b)
        {
            if((a <= 0f) || (b <= 0f))
            {
                    return (bool)((a < 0) ? 1 : 0) & ((b < 0) ? 1 : 0);
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool lineSegmentIntersection(float x1, float x2, float y1, float y2, float x3, float x4, float y3, float y4)
        {
            var val_14;
            float val_1 = x1 - x2;
            float val_3 = x1 * y2;
            float val_4 = y2 - y1;
            val_3 = (x2 * y1) - val_3;
            float val_5 = val_4 * x3;
            val_5 = val_5 + (val_1 * y3);
            val_5 = val_3 + val_5;
            if(val_5 != 0f)
            {
                    val_4 = val_4 * x4;
                val_1 = val_1 * y4;
                val_1 = val_4 + val_1;
                val_1 = val_3 + val_1;
                if(val_1 != 0f)
            {
                    if(val_5 > 0f)
            {
                    if(val_1 > 0f)
            {
                    return false;
            }
            
            }
            
                if(val_5 < 0)
            {
                    if(val_1 < 0)
            {
                    return false;
            }
            
            }
            
            }
            
            }
            
            float val_7 = x3 - x4;
            float val_9 = y4 - y3;
            x3 = x3 * y4;
            x1 = val_9 * x1;
            y1 = val_7 * y1;
            x3 = (x4 * y3) - x3;
            x1 = y1 + x1;
            x1 = x3 + x1;
            val_14 = 1;
            if(x1 == 0f)
            {
                    return (bool)val_14;
            }
            
            x2 = val_9 * x2;
            x2 = (val_7 * y2) + x2;
            x2 = x3 + x2;
            if(x2 == 0f)
            {
                    return (bool)val_14;
            }
            
            if((x1 > 0f) && (x2 > 0f))
            {
                    return false;
            }
            
            val_14 = ((x2 >= 0) ? 1 : 0) | ((x1 >= 0) ? 1 : 0);
            return (bool)val_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalBoundedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center)
        {
            SharedTechAssets.Scripts.TSDFMinusPlanes.HorizontalBoundedPlane val_1 = new SharedTechAssets.Scripts.TSDFMinusPlanes.HorizontalBoundedPlane(height:  center.y, boundary:  boundary, id:  id);
            if(center.y < 0)
            {
                    this.minHeight = center.y;
            }
            
            this._horizontalPlanes.set_Item(key:  id, value:  val_1);
            this.HideHorizontalIntersectingPoints(plane:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HideHorizontalIntersectingPointsOnPlane(SharedTechAssets.Scripts.TSDFMinusPlanes.HorizontalBoundedPlane plane, System.Collections.Generic.Dictionary<UnityEngine.Vector2, SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager.Tile> planeTiles)
        {
            var val_3;
            var val_4;
            var val_14;
            var val_27;
            var val_28;
            var val_29;
            var val_33;
            var val_35;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = planeTiles.Values.GetEnumerator();
            val_27 = 1152921523037452128;
            val_28 = 0;
            val_29 = 0;
            label_52:
            if((1250808224 & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            if(val_3 != 0)
            {
                goto label_52;
            }
            
            Intersection val_6 = this.HorizontalPlaneMeshBlockIntersection(tile:  val_5, plane:  plane);
            if(val_6 == 0)
            {
                goto label_6;
            }
            
            if(val_6 != 1)
            {
                goto label_52;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector3> val_7 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            HashSet.Enumerator<T> val_8 = val_5._masterDomain.GetEnumerator();
            do
            {
                label_15:
                if((1250808192 & 1) == 0)
            {
                goto label_22;
            }
            
                UnityEngine.Vector3 val_9 = val_4.position;
            }
            while((plane.PointWithinHorizontalPolygon(point:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) == false);
            
            com.illumix.IntVector3.IntVector3 val_11 = this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            bool val_12 = this.discretizedPoints.Remove(item:  val_11);
            this.updatedPoints.set_Item(key:  val_11, value:  false);
            null.Add(item:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            goto label_15;
            label_6:
            mem2[0] = 1;
            HashSet.Enumerator<T> val_13 = val_5._masterDomain.GetEnumerator();
            label_20:
            if((1250808192 & 1) == 0)
            {
                goto label_21;
            }
            
            UnityEngine.Vector3 val_16 = val_14.position;
            com.illumix.IntVector3.IntVector3 val_17 = this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            bool val_18 = this.discretizedPoints.Remove(item:  val_17);
            this.updatedPoints.set_Item(key:  val_17, value:  false);
            goto label_20;
            label_22:
            long val_19 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523037524352});
            if(((163 == 0) ? 163 : 163) == 163)
            {
                
            }
            else
            {
                    if( != 0)
            {
                
            }
            
            }
            
            val_33 = 0;
            goto label_36;
            label_41:
            UnityEngine.Vector3 val_21 = null.Item[0];
            bool val_22 = val_5._masterDomain.Remove(item:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            val_33 = 1;
            label_36:
            if(val_33 < null.Count)
            {
                goto label_41;
            }
            
            goto label_52;
            label_21:
            long val_24 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523037524352});
            if(((0 == 0) ? 303 : 0) != 303)
            {
                goto label_44;
            }
            
            if(val_5 != null)
            {
                goto label_50;
            }
            
            goto label_49;
            label_44:
            if( == 0)
            {
                goto label_47;
            }
            
            if(val_5 != null)
            {
                goto label_50;
            }
            
            goto label_49;
            label_47:
            if(val_5 != null)
            {
                goto label_50;
            }
            
            label_49:
            label_50:
            val_5._masterDomain.Clear();
            goto label_52;
            label_3:
            val_35 = 342;
            long val_26 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523037524384});
            if( == 0)
            {
                    return;
            }
            
            if(342 == 0)
            {
                    return;
            }
            
            if(342 == 342)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HideHorizontalIntersectingPoints(SharedTechAssets.Scripts.TSDFMinusPlanes.HorizontalBoundedPlane plane)
        {
            SharedTechAssets.Scripts.TSDFMinusPlanes.ConnectedComponentsTracker val_4;
            var val_5 = -3;
            do
            {
                int val_4 = plane.discretizedHeight;
                val_4 = val_5 + val_4;
                int val_1 = val_4 + 1;
                if((this._heightToPlaneTiles.ContainsKey(key:  val_1)) != false)
            {
                    this.HideHorizontalIntersectingPointsOnPlane(plane:  plane, planeTiles:  this._heightToPlaneTiles.Item[val_1]);
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 != 0);
            
            this._ccTracker.UpdateVoxels(changes:  this.updatedPoints);
            this.SendBlockCoordEvents(pointsToUpdate:  this._ccTracker.changedVoxels);
            val_4 = this._ccTracker;
            if(this._ccTracker != null)
            {
                goto label_8;
            }
            
            val_4 = this._ccTracker;
            if(val_4 == null)
            {
                goto label_9;
            }
            
            label_8:
            this._marchingCubes.PerformMarchingCubes(discretizedPoints:  this._ccTracker.VisibleCoords, updatedPoints:  this._ccTracker.changedVoxels);
            this.updatedPoints.Clear();
            return;
            label_9:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HideIntersectingPointsInColumn(SharedTechAssets.Scripts.TSDFMinusPlanes.VerticalBoundedPlane plane, SharedTechAssets.Scripts.TSDFMinusPlanes.TSDFMinusPlanesManager.TileColumn col)
        {
            var val_4;
            var val_17;
            var val_18;
            var val_22;
            SharedTechAssets.Scripts.TSDFMinusPlanes.ConnectedComponentsTracker val_24;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = col.tiles.Values.GetEnumerator();
            val_17 = 0;
            val_18 = 0;
            label_31:
            if((1251317920 & 1) == 0)
            {
                goto label_32;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            HashSet.Enumerator<T> val_6 = val_5._masterDomain.GetEnumerator();
            do
            {
                label_12:
                if((1251317888 & 1) == 0)
            {
                goto label_13;
            }
            
                UnityEngine.Vector3 val_7 = val_4.position;
            }
            while((this.IsPointCloseToVerticalPlane(point:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, plane:  plane)) == false);
            
            com.illumix.IntVector3.IntVector3 val_9 = this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            bool val_10 = this.discretizedPoints.Remove(item:  val_9);
            this.updatedPoints.set_Item(key:  val_9, value:  false);
            this.pointsToRemove.Add(item:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            goto label_12;
            label_13:
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523038034048});
            if(((136 == 0) ? 136 : 136) == 136)
            {
                
            }
            else
            {
                    if( != 0)
            {
                
            }
            
            }
            
            val_22 = 0;
            goto label_24;
            label_29:
            UnityEngine.Vector3 val_13 = this.pointsToRemove.Item[0];
            bool val_14 = val_5._masterDomain.Remove(item:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            val_22 = 1;
            label_24:
            if(val_22 < this.pointsToRemove.Count)
            {
                goto label_29;
            }
            
            this.pointsToRemove.Clear();
            goto label_31;
            label_32:
            long val_16 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523038034080});
            this._ccTracker.UpdateVoxels(changes:  this.updatedPoints);
            this.SendBlockCoordEvents(pointsToUpdate:  this._ccTracker.changedVoxels);
            val_24 = this._ccTracker;
            if(this._ccTracker != null)
            {
                goto label_47;
            }
            
            val_24 = this._ccTracker;
            if(val_24 == null)
            {
                goto label_48;
            }
            
            label_47:
            this._marchingCubes.PerformMarchingCubes(discretizedPoints:  this._ccTracker.VisibleCoords, updatedPoints:  this._ccTracker.changedVoxels);
            this.updatedPoints.Clear();
            return;
            label_48:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsPointCloseToVerticalPlane(UnityEngine.Vector3 point, SharedTechAssets.Scripts.TSDFMinusPlanes.VerticalBoundedPlane plane)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = plane.Center, y = V11.16B, z = V12.16B});
            float val_4 = this.pointAddTolerance;
            float val_3 = (float)-this.MULT_BEHIND_VERTICAL_PLANE;
            val_3 = val_4 * val_3;
            if(val_3 >= 0)
            {
                    return false;
            }
            
            val_4 = val_4 * (float)this.MULT_AHEAD_VERTICAL_PLANE;
            if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = plane.Normal, y = V11.16B, z = V12.16B})) >= 0)
            {
                    return false;
            }
            
            return plane.PointWithinVerticalPolygon(point:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalBoundedPlaneUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
            SharedTechAssets.Scripts.TSDFMinusPlanes.HorizontalBoundedPlane val_1 = this._horizontalPlanes.Item[id];
            if(this.minHeight > height)
            {
                    this.minHeight = height;
            }
            
            int val_2 = val_1.DiscretizeVal(val:  height);
            val_1.Boundary = boundary;
            if(val_2 != val_1.discretizedHeight)
            {
                    val_1.discretizedHeight = val_2;
            }
            
            this.HideHorizontalIntersectingPoints(plane:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalBoundedPlaneRemove(int id)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalBoundedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal)
        {
            var val_8 = this;
            SharedTechAssets.Scripts.TSDFMinusPlanes.VerticalBoundedPlane val_1 = new SharedTechAssets.Scripts.TSDFMinusPlanes.VerticalBoundedPlane(normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, boundary:  boundary, center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            this._verticalPlanes.set_Item(key:  id, value:  val_1);
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this._columnTiles.Keys.GetEnumerator();
            do
            {
                label_7:
                if((1251937976 & 1) == 0)
            {
                    return;
            }
            
                TileColumn val_4 = this._columnTiles.Item[new UnityEngine.Vector2() {x = normal.x, y = normal.y}];
            }
            while((this.VerticalPlaneColumnIntersection(column:  val_4, plane:  val_1)) == false);
            
            this.HideIntersectingPointsInColumn(plane:  val_1, col:  val_4);
            goto label_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalBoundedPlaneUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal)
        {
            var val_8 = this;
            SharedTechAssets.Scripts.TSDFMinusPlanes.VerticalBoundedPlane val_1 = this._verticalPlanes.Item[id];
            val_1.Update(normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, boundary:  boundary, center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this._columnTiles.Keys.GetEnumerator();
            do
            {
                label_8:
                if((1252116536 & 1) == 0)
            {
                    return;
            }
            
                TileColumn val_4 = this._columnTiles.Item[new UnityEngine.Vector2() {x = normal.x, y = normal.y}];
            }
            while((this.VerticalPlaneColumnIntersection(column:  val_4, plane:  val_1)) == false);
            
            this.HideIntersectingPointsInColumn(plane:  val_1, col:  val_4);
            goto label_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalBoundedPlaneRemove(int id)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.IntVector3.IntVector3 DiscretizeVertex(UnityEngine.Vector3 vertex)
        {
            var val_7 = 0;
            do
            {
                float val_5 = this.resolution;
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
            
            return (com.illumix.IntVector3.IntVector3)this._coordCache.GenerateIntVector(x:  this.intBuffer[0], y:  this.intBuffer[1], z:  this.intBuffer[2]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void printUpdatedPoints()
        {
            var val_7 = this;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this.updatedPoints.Keys.GetEnumerator();
            label_5:
            if((1252817128 & 1) == 0)
            {
                goto label_3;
            }
            
            bool val_4 = this.updatedPoints.Item[0.emailUIDataHandler];
            goto label_5;
            label_3:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523039533288});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendBlockCoordEvents(System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, bool> pointsToUpdate)
        {
            var val_7;
            var val_28;
            var val_29;
            var val_30;
            val_28 = pointsToUpdate;
            val_29 = this;
            System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> val_1 = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.List<UnityEngine.Vector3>> val_2 = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.List<UnityEngine.Vector3>>();
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.List<UnityEngine.Vector3>> val_3 = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.List<UnityEngine.Vector3>>();
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_5 = val_28.Keys.GetEnumerator();
            label_18:
            if((1253038624 & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_8 = val_7.emailUIDataHandler;
            com.illumix.IntVector3.IntVector3 val_9 = this._marchingCubes.GetBlockKey(discretePoint:  val_8);
            if((val_1.Add(item:  val_9)) != false)
            {
                    System.Collections.Generic.List<UnityEngine.Vector3> val_11 = new System.Collections.Generic.List<UnityEngine.Vector3>();
                val_2.set_Item(key:  val_9, value:  null);
                System.Collections.Generic.List<UnityEngine.Vector3> val_12 = new System.Collections.Generic.List<UnityEngine.Vector3>();
                val_3.set_Item(key:  val_9, value:  null);
            }
            
            if(val_28.Item[val_8] == false)
            {
                goto label_10;
            }
            
            UnityEngine.Vector3 val_15 = 0.IntVectorToVertexPosition(intVertex:  val_8, resolution:  this.resolution);
            val_2.Item[val_9].Add(item:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            goto label_18;
            label_10:
            UnityEngine.Vector3 val_17 = 0.IntVectorToVertexPosition(intVertex:  val_8, resolution:  this.resolution);
            val_3.Item[val_9].Add(item:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            goto label_18;
            label_3:
            val_30 = 0;
            HashSet.Enumerator<T> val_20 = val_1.GetEnumerator();
            label_43:
            if((1253038592 & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_21 = val_7.emailUIDataHandler;
            UnityEngine.Vector3 val_23 = 0.IntVectorToVertexPosition(intVertex:  this._marchingCubes.BlockKeyToResolutionSpace(blockKey:  val_21), resolution:  this.resolution);
            this._blockCoordDispenser.UpdateBlockEvent(center:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, pointsToAdd:  val_2.Item[val_21], pointsToRemove:  val_3.Item[val_21]);
            goto label_43;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBlockUpdatedEvent(UnityEngine.Vector3 center, System.Collections.Generic.List<UnityEngine.Vector3> pointsToAdd, System.Collections.Generic.List<UnityEngine.Vector3> pointsToRemove)
        {
            var val_21;
            com.illumix.IntVector3.IntVector3 val_42;
            System.Collections.Generic.HashSet<UnityEngine.Vector3> val_43;
            float val_44;
            float val_45;
            var val_49;
            var val_50;
            var val_51;
            SharedTechAssets.Scripts.TSDFMinusPlanes.ConnectedComponentsTracker val_52;
            val_42 = 0;
            val_43 = 0;
            goto label_1;
            label_42:
            UnityEngine.Vector3 val_1 = pointsToAdd.Item[0];
            val_44 = val_1.x;
            val_45 = val_1.z;
            if(val_1.y < 0)
            {
                    if(this._horizontalPlanes.Count > 0)
            {
                goto label_36;
            }
            
            }
            
            com.illumix.IntVector3.IntVector3 val_3 = this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = val_44, y = val_1.y, z = val_45});
            if((this._heightToPlaneTiles.ContainsKey(key:  val_3.Item2)) != true)
            {
                    this._heightToPlaneTiles.set_Item(key:  val_3.Item2, value:  new System.Collections.Generic.Dictionary<UnityEngine.Vector2, Tile>());
            }
            
            this.bufferPoint2 = new UnityEngine.Vector2(x:  center.x, y:  center.z);
            if((this._columnTiles.ContainsKey(key:  new UnityEngine.Vector2() {x = this.bufferPoint2, y = V14.16B})) != true)
            {
                    this._columnTiles.set_Item(key:  new UnityEngine.Vector2() {x = this.bufferPoint2, y = V14.16B}, value:  new TSDFMinusPlanesManager.TileColumn(center:  new UnityEngine.Vector2() {x = this.bufferPoint2, y = V14.16B}));
            }
            
            TileColumn val_11 = this._columnTiles.Item[new UnityEngine.Vector2() {x = this.bufferPoint2, y = V14.16B}];
            System.Collections.Generic.Dictionary<UnityEngine.Vector2, Tile> val_13 = this._heightToPlaneTiles.Item[val_3.Item2];
            this.bufferPoint2 = new UnityEngine.Vector2(x:  center.x, y:  center.z);
            if((val_13.ContainsKey(key:  new UnityEngine.Vector2() {x = this.bufferPoint2, y = V14.16B})) != true)
            {
                    TSDFMinusPlanesManager.Tile val_16 = new TSDFMinusPlanesManager.Tile(center:  new UnityEngine.Vector3() {x = this.bufferPoint3, y = V14.16B, z = V15.16B});
                val_13.set_Item(key:  new UnityEngine.Vector2() {x = this.bufferPoint2, y = V14.16B}, value:  val_16);
                val_11.tiles.set_Item(key:  val_1.y, value:  val_16);
            }
            
            Tile val_17 = val_13.Item[new UnityEngine.Vector2() {x = this.bufferPoint2, y = V14.16B}];
            if(val_17.completelyHidden == true)
            {
                goto label_36;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_19 = this._verticalPlanes.Values.GetEnumerator();
            label_28:
            if((1253429120 & 1) == 0)
            {
                goto label_27;
            }
            
            if((this.IsPointCloseToVerticalPlane(point:  new UnityEngine.Vector3() {x = val_44, y = val_1.y, z = val_45}, plane:  val_21.emailUIDataHandler)) == false)
            {
                goto label_28;
            }
            
            val_49 = 1;
            goto label_30;
            label_27:
            val_49 = 0;
            label_30:
            long val_24 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523040145280});
            if(((413 == 0) ? 413 : 413) == 413)
            {
                    val_50 = val_21;
                val_43 = 0;
            }
            else
            {
                    val_50 = 0;
            }
            
            if(( & 1) == 0)
            {
                    bool val_26 = this.discretizedPoints.Add(item:  val_3);
                this.updatedPoints.set_Item(key:  val_3, value:  true);
                bool val_27 = val_17.points.Add(item:  new UnityEngine.Vector3() {x = val_44, y = val_1.y, z = val_45});
            }
            
            label_36:
            val_42 = 1;
            label_1:
            if(val_42 < pointsToAdd.Count)
            {
                goto label_42;
            }
            
            val_51 = 0;
            goto label_43;
            label_59:
            UnityEngine.Vector3 val_29 = pointsToRemove.Item[0];
            val_44 = val_29.x;
            val_45 = val_29.z;
            val_42 = this.DiscretizeVertex(vertex:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
            if((this.discretizedPoints.Contains(item:  val_42)) != false)
            {
                    bool val_32 = this.discretizedPoints.Remove(item:  val_42);
                this.bufferPoint2 = new UnityEngine.Vector2(x:  center.x, y:  center.z);
                Tile val_36 = this._heightToPlaneTiles.Item[val_42.Item2].Item[new UnityEngine.Vector2() {x = this.bufferPoint2, y = V14.16B}];
                val_43 = val_36.points;
                if((val_43.Contains(item:  new UnityEngine.Vector3() {x = val_44, y = val_29.y, z = val_45})) != false)
            {
                    bool val_38 = val_36.points.Remove(item:  new UnityEngine.Vector3() {x = val_44, y = val_29.y, z = val_45});
                if((this.updatedPoints.ContainsKey(key:  val_42)) != true)
            {
                    this.updatedPoints.set_Item(key:  val_42, value:  false);
            }
            
            }
            
            }
            
            val_51 = 1;
            label_43:
            if(val_51 < pointsToRemove.Count)
            {
                goto label_59;
            }
            
            this._ccTracker.UpdateVoxels(changes:  this.updatedPoints);
            this.SendBlockCoordEvents(pointsToUpdate:  this._ccTracker.changedVoxels);
            val_52 = this._ccTracker;
            if(this._ccTracker != null)
            {
                goto label_62;
            }
            
            val_52 = this._ccTracker;
            if(val_52 == null)
            {
                goto label_63;
            }
            
            label_62:
            this._marchingCubes.PerformMarchingCubes(discretizedPoints:  this._ccTracker.VisibleCoords, updatedPoints:  this._ccTracker.changedVoxels);
            this.updatedPoints.Clear();
            return;
            label_63:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TSDFMinusPlanesManager()
        {
            this.minHeight = -1.175494E-38f;
            this.pointsToRemove = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.pointAddTolerance = 0.05f;
            this.MULT_BEHIND_VERTICAL_PLANE = 2;
            this.MULT_AHEAD_VERTICAL_PLANE = 1;
            this.resolution = 7.346868E-41f;
            this.intBuffer = new int[3];
            this.updatedPoints = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean>();
        }
    
    }

}
