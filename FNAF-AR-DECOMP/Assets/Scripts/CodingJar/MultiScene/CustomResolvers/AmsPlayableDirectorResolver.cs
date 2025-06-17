using UnityEngine;

namespace CodingJar.MultiScene.CustomResolvers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static class AmsPlayableDirectorResolver
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void AddCustomResolver()
        {
            mem[1152921520126094928] = 0;
            mem[1152921520126094936] = static System.Boolean CodingJar.MultiScene.CustomResolvers.AmsPlayableDirectorResolver::HandleCrossSceneReference(CodingJar.MultiScene.RuntimeCrossSceneReference xRef);
            mem[1152921520126094912] = static System.Boolean CodingJar.MultiScene.CustomResolvers.AmsPlayableDirectorResolver::HandleCrossSceneReference(CodingJar.MultiScene.RuntimeCrossSceneReference xRef);
            CodingJar.MultiScene.AmsCrossSceneReferenceResolver.AddCustomResolver(customResolver:  new AmsCrossSceneReferenceResolver.ResolveCrossSceneReferenceDelegate());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool HandleCrossSceneReference(CodingJar.MultiScene.RuntimeCrossSceneReference xRef)
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = 1152921520126289488;
            if(xRef._sourceObject == null)
            {
                    return (bool)val_7;
            }
            
            if(null == null)
            {
                goto label_3;
            }
            
            label_11:
            val_7 = 0;
            return (bool)val_7;
            label_3:
            if((xRef._sourceField.StartsWith(value:  "m_SceneBindings")) == false)
            {
                goto label_5;
            }
            
            CodingJar.MultiScene.CustomResolvers.AmsPlayableDirectorResolver.PlayableDirector_SceneBindings(xRef:  new CodingJar.MultiScene.RuntimeCrossSceneReference() {DEPRECATED_fromObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _toObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _data = new GenericDataBundle()});
            val_8 = 1;
            if(xRef._sourceField != null)
            {
                goto label_8;
            }
            
            goto label_7;
            label_5:
            val_8 = 0;
            if(xRef._sourceField != null)
            {
                goto label_8;
            }
            
            label_7:
            label_8:
            if((xRef._sourceField.StartsWith(value:  "m_ExposedReferences")) == false)
            {
                goto label_9;
            }
            
            CodingJar.MultiScene.CustomResolvers.AmsPlayableDirectorResolver.PlayableDirector_ExposedReferences(xRef:  new CodingJar.MultiScene.RuntimeCrossSceneReference() {DEPRECATED_fromObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _toObject = new CodingJar.MultiScene.UniqueObject() {scene = new AmsSceneReference()}, _data = new GenericDataBundle()});
            goto label_10;
            label_9:
            if(val_8 == 0)
            {
                goto label_11;
            }
            
            label_10:
            val_9 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  null)) == false)
            {
                    return (bool)val_7;
            }
            
            if(state != 1)
            {
                    return (bool)val_7;
            }
            
            object[] val_6 = new object[2];
            val_6[0] = ;
            val_6[1] = ;
            CodingJar.MultiScene.AmsDebug.LogWarning(context:  null, message:  "To prevent issues, delay the PlayableDirector \'{0}\' until after cross-scene references are loaded. Cross-Scene Reference: {1}", parms:  val_6);
            RebuildGraph();
            return (bool)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void PlayableDirector_ExposedReferences(CodingJar.MultiScene.RuntimeCrossSceneReference xRef)
        {
            var val_9;
            var val_10;
            val_9 = 0;
            val_10 = 0;
            goto label_4;
            label_18:
            CodingJar.MultiScene.GenericData val_2 = xRef._data.data.Item[0];
            object[] val_3 = new object[2];
            if(val_3 == null)
            {
                goto label_6;
            }
            
            if(val_2.string != null)
            {
                goto label_7;
            }
            
            goto label_10;
            label_6:
            if(val_2.string == null)
            {
                goto label_10;
            }
            
            label_7:
            label_10:
            val_3[0] = val_2.string;
            val_3[1] = 1152921520126555488;
            CodingJar.MultiScene.AmsDebug.Log(context:  xRef._sourceObject, message:  "Restoring PlayableDirector Exposed Binding {0} = {1}", parms:  val_3);
            UnityEngine.PropertyName val_4 = UnityEngine.PropertyName.op_Implicit(name:  val_2.string);
            ClearReferenceValue(id:  new UnityEngine.PropertyName() {id = val_4.id & 4294967295});
            UnityEngine.PropertyName val_6 = UnityEngine.PropertyName.op_Implicit(name:  val_2.string);
            SetReferenceValue(id:  new UnityEngine.PropertyName() {id = val_6.id & 4294967295}, value:  xRef._sourceObject);
            val_10 = 2;
            label_4:
            if(val_10 < xRef._data.data.Count)
            {
                goto label_18;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void PlayableDirector_SceneBindings(CodingJar.MultiScene.RuntimeCrossSceneReference xRef)
        {
            var val_5;
            var val_6;
            val_5 = 0;
            val_6 = 0;
            goto label_4;
            label_17:
            CodingJar.MultiScene.GenericData val_2 = xRef._data.data.Item[0];
            object[] val_3 = new object[2];
            if(val_3 == null)
            {
                goto label_6;
            }
            
            if(val_2.object != null)
            {
                goto label_7;
            }
            
            goto label_10;
            label_6:
            if(val_2.object == null)
            {
                goto label_10;
            }
            
            label_7:
            label_10:
            val_3[0] = val_2.object;
            val_3[1] = 1152921520126815344;
            CodingJar.MultiScene.AmsDebug.Log(context:  xRef._sourceObject, message:  "Restoring PlayableDirector Scene Binding {0} = {1}", parms:  val_3);
            SetGenericBinding(key:  val_2.object, value:  xRef._sourceObject);
            val_6 = 2;
            label_4:
            if(val_6 < xRef._data.data.Count)
            {
                goto label_17;
            }
        
        }
    
    }

}
