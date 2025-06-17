using UnityEngine;

namespace SharedTechAssets.Scripts.ObjectPinner.GeometryHandler
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SemanticGeometryFilter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly System.Collections.Generic.HashSet<string> filteredCombinations;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsPinFiltered(string handlerName, string label)
        {
            var val_2 = null;
            if(SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SemanticGeometryFilter.filteredCombinations != null)
            {
                    return SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SemanticGeometryFilter.filteredCombinations.Contains(item:  handlerName + "_" + label);
            }
            
            return SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SemanticGeometryFilter.filteredCombinations.Contains(item:  handlerName + "_" + label);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SemanticGeometryFilter()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SemanticGeometryFilter()
        {
            System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
            if(val_1 != null)
            {
                    bool val_2 = val_1.Add(item:  "MeshBlockGeometryHandler_tvmonitor");
            }
            else
            {
                    bool val_3 = val_1.Add(item:  "MeshBlockGeometryHandler_tvmonitor");
            }
            
            bool val_4 = val_1.Add(item:  "SupportedHorizontalPlaneGeometryHandler_tvmonitor");
            SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SemanticGeometryFilter.filteredCombinations = val_1;
        }
    
    }

}
