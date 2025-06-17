using UnityEngine;

namespace SRF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class SRMonoBehaviourEx : SRMonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.IList<SRF.SRMonoBehaviourEx.FieldInfo>> _checkedFields;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void CheckFields(SRF.SRMonoBehaviourEx instance, bool justSet = False)
        {
            System.Type val_8;
            if(SRF.SRMonoBehaviourEx._checkedFields == null)
            {
                goto label_1;
            }
            
            label_8:
            System.Type val_1 = instance.GetType();
            val_8 = instance.GetType();
            if((SRF.SRMonoBehaviourEx._checkedFields.TryGetValue(key:  val_8, value: out  0)) != true)
            {
                    System.Collections.Generic.List<FieldInfo> val_5 = SRF.SRMonoBehaviourEx.ScanType(t:  val_1);
                val_8 = SRF.SRMonoBehaviourEx._checkedFields;
                val_8.Add(key:  val_1, value:  val_5);
            }
            
            SRF.SRMonoBehaviourEx.PopulateObject(cache:  val_5, instance:  instance, justSet:  justSet);
            return;
            label_1:
            SRF.SRMonoBehaviourEx._checkedFields = new System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.IList<FieldInfo>>();
            if(instance != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void PopulateObject(System.Collections.Generic.IList<SRF.SRMonoBehaviourEx.FieldInfo> cache, SRF.SRMonoBehaviourEx instance, bool justSet)
        {
            var val_3;
            System.Type val_4;
            var val_5;
            var val_6;
            var val_20;
            System.Type val_22;
            System.Type val_23;
            System.Object[] val_24;
            object val_25;
            object val_26;
            val_20 = 0;
            goto label_1;
            label_39:
            var val_22 = 0;
            val_22 = val_22 + 1;
            T val_2 = cache.Item[0];
            val_22 = val_4;
            val_23 = val_6;
            val_24 = System.Collections.Generic.EqualityComparer<System.Object>.Default;
            if((val_24 & 1) == 0)
            {
                goto label_25;
            }
            
            if(val_5 == false)
            {
                goto label_10;
            }
            
            if(val_23 == 0)
            {
                    val_23 = val_22;
            }
            
            object val_8 = SRF.Service.SRServiceManager.GetService(t:  val_23);
            if(val_8 == null)
            {
                goto label_14;
            }
            
            val_25 = instance;
            val_26 = val_8;
            goto label_15;
            label_10:
            if((val_3 & 65280) == 0)
            {
                goto label_16;
            }
            
            val_24 = System.Collections.Generic.EqualityComparer<System.Object>.Default;
            if((val_24 & 1) == 0)
            {
                goto label_19;
            }
            
            label_16:
            if(justSet == true)
            {
                goto label_25;
            }
            
            goto label_21;
            label_14:
            object[] val_12 = new object[2];
            val_24 = val_12;
            if(val_24 == null)
            {
                goto label_22;
            }
            
            if(val_22 != 0)
            {
                goto label_23;
            }
            
            goto label_27;
            label_19:
            val_25 = instance;
            val_26 = instance.GetComponent(type:  val_22);
            label_15:
            val_22.SetValue(obj:  val_25, value:  val_26);
            goto label_25;
            label_22:
            if(val_22 == 0)
            {
                goto label_27;
            }
            
            label_23:
            label_27:
            val_24[0] = val_22;
            val_24[1] = val_23;
            val_22 = System.String.Format(format:  "Field {0} import failed (Type {1})", args:  val_12);
            UnityEngine.Debug.LogWarning(message:  val_22);
            label_25:
            val_20 = 1;
            label_1:
            var val_23 = 0;
            val_23 = val_23 + 1;
            if(val_20 < cache.Count)
            {
                goto label_39;
            }
            
            return;
            label_21:
            if((val_3 & 255) != 0)
            {
                    val_22.SetValue(obj:  instance, value:  instance.CachedGameObject.AddComponent(componentType:  val_22));
            }
            
            UnityEngine.UnassignedReferenceException val_21 = new UnityEngine.UnassignedReferenceException(message:  System.String.Format(format:  "Field {0} is unassigned, but marked with RequiredFieldAttribute", args:  new object[1]));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.List<SRF.SRMonoBehaviourEx.FieldInfo> ScanType(System.Type t)
        {
            var val_6;
            System.Collections.Generic.List<T> val_7;
            var val_8;
            var val_9;
            bool val_10;
            System.Type val_11;
            bool val_12;
            bool val_13;
            System.Collections.Generic.List<FieldInfo> val_1 = null;
            val_7 = val_1;
            val_1 = new System.Collections.Generic.List<FieldInfo>();
            SRF.RequiredFieldAttribute val_2 = SRF.Helpers.SRReflection.GetAttribute<SRF.RequiredFieldAttribute>(t:  t);
            val_8 = 1152921520747493648;
            val_9 = 0;
            goto label_2;
            label_15:
            val_6 = 0;
            val_10 = SRF.Helpers.SRReflection.GetAttribute<SRF.RequiredFieldAttribute>(t:  System.Type.__il2cppRuntimeField_byval_arg);
            SRF.ImportAttribute val_4 = SRF.Helpers.SRReflection.GetAttribute<SRF.ImportAttribute>(t:  System.Type.__il2cppRuntimeField_byval_arg);
            if((val_2 == null) && (val_10 == null))
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            if(val_4 != null)
            {
                    val_11 = val_4.Service;
                val_6 = 0;
                val_10 = 0;
                val_12 = 1;
            }
            else
            {
                    if(val_10 != null)
            {
                    val_13 = val_3._autoCreate;
                val_10 = val_3._autoSearch;
            }
            else
            {
                    if(val_2 != null)
            {
                    val_10 = val_2._autoSearch;
            }
            else
            {
                    val_10 = val_2._autoSearch;
            }
            
                val_13 = val_2._autoCreate;
            }
            
                val_12 = false;
                val_11 = 0;
            }
            
            val_1.Add(item:  new FieldInfo() {AutoCreate = (val_13 == true) ? 1 : 0, AutoSet = val_10, Field = System.Type.__il2cppRuntimeField_byval_arg, Import = val_12, ImportType = val_11});
            val_7 = val_7;
            val_8 = 1152921520747493648;
            label_6:
            val_9 = 1;
            label_2:
            if(val_9 < 0)
            {
                goto label_15;
            }
            
            return (System.Collections.Generic.List<FieldInfo>)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            SRF.SRMonoBehaviourEx.CheckFields(instance:  this, justSet:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Start()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Update()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void FixedUpdate()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnEnable()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnDisable()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnDestroy()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SRMonoBehaviourEx()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
