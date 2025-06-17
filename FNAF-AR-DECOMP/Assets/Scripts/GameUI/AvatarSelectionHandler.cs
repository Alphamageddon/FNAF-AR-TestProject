using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AvatarSelectionHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.Transform avatarCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly GameUI.AvatarCell avatarCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<ICellInterface<GameUI.AvatarCellDataPack>> avatarCells;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> SelectAvatarCell;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<GameUI.ProfileAvatarSet> availableAvatars;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearCells()
        {
            var val_3;
            System.Collections.Generic.List<ICellInterface<GameUI.AvatarCellDataPack>> val_12;
            UnityEngine.Object val_13;
            val_12 = this;
            if(this.avatarCells == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.avatarCells.GetEnumerator();
            goto label_12;
            label_14:
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            val_13 = 0.gameObject;
            if(val_13 != 0)
            {
                    UnityEngine.Object.Destroy(obj:  0.gameObject);
            }
            
            label_12:
            if(((-1263820944) & 1) != 0)
            {
                goto label_14;
            }
            
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524817862512});
            val_12 = this.avatarCells;
            val_12.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AvatarSelectionHandler(UnityEngine.Transform avatarCellParent, GameUI.AvatarCell avatarCellPrefab, System.Action<string> SelectAvatarCell, System.Collections.Generic.List<GameUI.ProfileAvatarSet> availableAvatars)
        {
            val_1 = new System.Object();
            this.avatarCellParent = avatarCellParent;
            this.avatarCellPrefab = avatarCellPrefab;
            this.SelectAvatarCell = SelectAvatarCell;
            this.availableAvatars = val_1;
            this.avatarCells = new System.Collections.Generic.List<ICellInterface<GameUI.AvatarCellDataPack>>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GenerateCells()
        {
            var val_3;
            var val_11;
            var val_12;
            System.Action<System.String> val_13;
            var val_15;
            val_11 = this;
            this.ClearCells();
            List.Enumerator<T> val_1 = this.availableAvatars.GetEnumerator();
            label_20:
            if(((-1263475072) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            val_12 = public static GameUI.AvatarCell UnityEngine.Object::Instantiate<GameUI.AvatarCell>(GameUI.AvatarCell original, UnityEngine.Transform parent);
            GameUI.AvatarCell val_5 = UnityEngine.Object.Instantiate<GameUI.AvatarCell>(original:  this.avatarCellPrefab, parent:  this.avatarCellParent);
            new GameUI.AvatarCellDataPack() = new System.Object();
            if(new GameUI.AvatarCellDataPack() != null)
            {
                    .id = val_4._masterDomain;
                val_13 = this.SelectAvatarCell;
            }
            else
            {
                    mem[16] = val_4._masterDomain;
                val_13 = this.SelectAvatarCell;
            }
            
            .SelectCell = val_13;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = 0;
            val_15 = public System.Void ICellInterface<T>::SetData(T data);
            val_5.SetData(data:  null);
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_15 = 1;
            val_5.SetSprite(sprite:  val_4._serverGameUIDataModel);
            this.avatarCells.Add(item:  val_5);
            goto label_20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
            this.ClearCells();
        }
    
    }

}
