using UnityEngine;

namespace PlayFab.ProfilesModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class EntityPermissionStatement : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Action;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Comment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object Condition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ProfilesModels.EffectType Effect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object Principal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Resource;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EntityPermissionStatement()
        {
            val_1 = new System.Object();
        }
    
    }

}
