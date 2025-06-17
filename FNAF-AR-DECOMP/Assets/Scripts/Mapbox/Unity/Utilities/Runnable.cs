using UnityEngine;

namespace Mapbox.Unity.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Runnable : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, Mapbox.Unity.Utilities.Runnable.Routine> m_Routines;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_NextRoutineId;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Utilities.Runnable Instance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Utilities.Runnable get_Instance()
        {
            return Mapbox.Unity.Utilities.Singleton<Mapbox.Unity.Utilities.Runnable>.Instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int Run(System.Collections.IEnumerator routine)
        {
            if((new Runnable.Routine(a_enumerator:  routine)) != null)
            {
                    return (int)(Runnable.Routine)[1152921519676668832].<ID>k__BackingField;
            }
            
            return (int)(Runnable.Routine)[1152921519676668832].<ID>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Stop(int ID)
        {
            int val_4 = ID;
            Routine val_2 = 0;
            Mapbox.Unity.Utilities.Runnable val_1 = Mapbox.Unity.Utilities.Runnable.Instance;
            if((val_1.m_Routines.TryGetValue(key:  val_4 = ID, value: out  val_2)) == false)
            {
                    return;
            }
            
            val_4 = val_2;
            mem[20] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsRunning(int id)
        {
            Mapbox.Unity.Utilities.Runnable val_1 = Mapbox.Unity.Utilities.Runnable.Instance;
            if(val_1.m_Routines != null)
            {
                    return val_1.m_Routines.ContainsKey(key:  id);
            }
            
            return val_1.m_Routines.ContainsKey(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateRoutines()
        {
            var val_5;
            System.Collections.Generic.Dictionary<System.Int32, Routine> val_16 = this.m_Routines;
            if(val_16.Count < 1)
            {
                    return;
            }
            
            System.Collections.Generic.List<Routine> val_2 = null;
            val_16 = val_2;
            val_2 = new System.Collections.Generic.List<Routine>();
            Dictionary.Enumerator<TKey, TValue> val_3 = this.m_Routines.GetEnumerator();
            label_6:
            if(((-2109683760) & 1) == 0)
            {
                goto label_4;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_7 = val_5.trackableId;
            val_2.Add(item:  val_7.m_SubId1);
            goto label_6;
            label_4:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519677032400});
            List.Enumerator<T> val_10 = val_2.GetEnumerator();
            label_16:
            if(((-2109683800) & 1) == 0)
            {
                goto label_14;
            }
            
            bool val_12 = 0.emailUIDataHandler.MoveNext();
            goto label_16;
            label_14:
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519677032360});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Runnable()
        {
            this.m_Routines = new System.Collections.Generic.Dictionary<System.Int32, Routine>();
            this.m_NextRoutineId = 1;
        }
    
    }

}
