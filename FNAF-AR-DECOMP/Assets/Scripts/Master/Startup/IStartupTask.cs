using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IStartupTask
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Execute(Master.Startup.StartupSequencer parent); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Teardown(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int GetSize(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetName(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract int GetPartialProgress(); // 0
    
    }

}
