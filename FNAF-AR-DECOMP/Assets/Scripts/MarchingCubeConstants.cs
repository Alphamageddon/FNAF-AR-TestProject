using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class MarchingCubeConstants
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static com.illumix.IntVector3.IntVector3[] edgeIdxToCoords;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.Dictionary<int, int> InverseEdge;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int[] edgeTable;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int[,] triTable;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static MarchingCubeConstants()
    {
        com.illumix.IntVector3.IntVector3[] val_1 = new com.illumix.IntVector3.IntVector3[12];
        com.illumix.IntVector3.IntVector3 val_2 = new com.illumix.IntVector3.IntVector3(item1:  0, item2:  0, item3:  0);
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_2 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_2;
        val_1[1] = new com.illumix.IntVector3.IntVector3(item1:  1, item2:  0, item3:  0);
        val_1[2] = new com.illumix.IntVector3.IntVector3(item1:  0, item2:  0, item3:  1);
        val_1[3] = new com.illumix.IntVector3.IntVector3(item1:  0, item2:  0, item3:  0);
        val_1[4] = new com.illumix.IntVector3.IntVector3(item1:  0, item2:  1, item3:  0);
        val_1[5] = new com.illumix.IntVector3.IntVector3(item1:  1, item2:  1, item3:  0);
        val_1[6] = new com.illumix.IntVector3.IntVector3(item1:  0, item2:  1, item3:  1);
        val_1[7] = new com.illumix.IntVector3.IntVector3(item1:  0, item2:  1, item3:  0);
        val_1[8] = new com.illumix.IntVector3.IntVector3(item1:  0, item2:  0, item3:  0);
        val_1[9] = new com.illumix.IntVector3.IntVector3(item1:  1, item2:  0, item3:  0);
        val_1[10] = new com.illumix.IntVector3.IntVector3(item1:  1, item2:  0, item3:  1);
        val_1[11] = new com.illumix.IntVector3.IntVector3(item1:  0, item2:  0, item3:  1);
        MarchingCubeConstants.edgeIdxToCoords = val_1;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_14 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        if(val_14 != null)
        {
                val_14.Add(key:  0, value:  6);
            val_14.Add(key:  1, value:  7);
            val_14.Add(key:  2, value:  4);
            val_14.Add(key:  3, value:  5);
            val_14.Add(key:  4, value:  2);
            val_14.Add(key:  5, value:  3);
            val_14.Add(key:  6, value:  0);
        }
        else
        {
                val_14.Add(key:  0, value:  6);
            val_14.Add(key:  1, value:  7);
            val_14.Add(key:  2, value:  4);
            val_14.Add(key:  3, value:  5);
            val_14.Add(key:  4, value:  2);
            val_14.Add(key:  5, value:  3);
            val_14.Add(key:  6, value:  0);
        }
        
        val_14.Add(key:  7, value:  1);
        MarchingCubeConstants.InverseEdge = val_14;
        MarchingCubeConstants.edgeTable = new int[256] {0, 265, 515, 778, 1030, 1295, 1541, 1804, 2060, 2309, 2575, 2822, 3082, 3331, 3593, 3840, 400, 153, 915, 666, 1430, 1183, 1941, 1692, 2460, 2197, 2975, 2710, 3482, 3219, 3993, 3728, 560, 825, 51, 314, 1590, 1855, 1077, 1340, 2620, 2869, 2111, 2358, 3642, 3891, 3129, 3376, 928, 681, 419, 170, 1958, 1711, 1445, 1196, 2988, 2725, 2479, 2214, 4010, 3747, 3497, 3232, 1120, 1385, 1635, 1898, 102, 367, 613, 876, 3180, 3429, 3695, 3942, 2154, 2403, 2665, 2912, 1520, 1273, 2035, 1786, 502, 255, 1013, 764, 3580, 3317, 4095, 3830, 2554, 2291, 3065, 2800, 1616, 1881, 1107, 1370, 598, 863, 85, 348, 3676, 3925, 3167, 3414, 2650, 2899, 2137, 2384, 1984, 1737, 1475, 1226, 966, 719, 453, 204, 4044, 3781, 3535, 3270, 3018, 2755, 2505, 2240, 2240, 2505, 2755, 3018, 3270, 3535, 3781, 4044, 204, 453, 719, 966, 1226, 1475, 1737, 1984, 2384, 2137, 2899, 2650, 3414, 3167, 3925, 3676, 348, 85, 863, 598, 1370, 1107, 1881, 1616, 2800, 3065, 2291, 2554, 3830, 4095, 3317, 3580, 764, 1013, 255, 502, 1786, 2035, 1273, 1520, 2912, 2665, 2403, 2154, 3942, 3695, 3429, 3180, 876, 613, 367, 102, 1898, 1635, 1385, 1120, 3232, 3497, 3747, 4010, 2214, 2479, 2725, 2988, 1196, 1445, 1711, 1958, 170, 419, 681, 928, 3376, 3129, 3891, 3642, 2358, 2111, 2869, 2620, 1340, 1077, 1855, 1590, 314, 51, 825, 560, 3728, 3993, 3219, 3482, 2710, 2975, 2197, 2460, 1692, 1941, 1183, 1430, 666, 915, 153, 400, 3840, 3593, 3331, 3082, 2822, 2575, 2309, 2060, 1804, 1541, 1295, 1030, 778, 515, 265, 0};
        MarchingCubeConstants.triTable = null;
    }

}
