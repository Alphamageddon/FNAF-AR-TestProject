using UnityEngine;

namespace Animatronics.Animatronic3d
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IAnimatronic3DDomain
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void CreateAnimatronic3D(Animatronics.Animatronic3d.CreationRequest request); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void CreateMapIcon(AnimatronicEntity.AnimatronicConfigData configData, System.Action<Animatronics.Animatronic3d.PrefabManagement.MapIconContainer> onSuccess, System.Action<string> onFailure); // 0
    
    }

}
