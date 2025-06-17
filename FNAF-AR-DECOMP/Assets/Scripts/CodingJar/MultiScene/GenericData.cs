using UnityEngine;

namespace CodingJar.MultiScene
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public struct GenericData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Object object;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string string;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GenericData(UnityEngine.Object obj)
        {
            mem[1152921520122610144] = obj;
            mem[1152921520122610152] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GenericData(string str)
        {
            mem[1152921520122730336] = 0;
            mem[1152921520122730344] = str;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static CodingJar.MultiScene.GenericData op_Implicit(UnityEngine.Object obj)
        {
            return new CodingJar.MultiScene.GenericData() {object = obj};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static CodingJar.MultiScene.GenericData op_Implicit(string str)
        {
            return new CodingJar.MultiScene.GenericData() {string = str};
        }
    
    }

}
