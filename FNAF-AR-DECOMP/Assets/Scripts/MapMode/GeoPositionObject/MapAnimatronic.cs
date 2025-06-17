using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapAnimatronic : GeoPositionObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntity <animatronicEntity>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _billboardCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float lostConnectionBlinkSpeedScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject Container;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject UnidentifiedIconContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.CameraBillboard UnidentifiedIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.CameraBillboard Billboard;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.BoxCollider Collider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.AnimatronicStatusIcon[] Icons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject FriendIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _icon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _showIcon;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Utils.Vector2d geoPosition { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntity animatronicEntity { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Mapbox.Utils.Vector2d get_geoPosition()
        {
            AnimatronicEntity.GeoPositionData val_1 = this.<animatronicEntity>k__BackingField.geoPositionData;
            if(val_1 != null)
            {
                    return val_1.geoPosition;
            }
            
            return val_1.geoPosition;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntity get_animatronicEntity()
        {
            return (AnimatronicEntity.AnimatronicEntity)this.<animatronicEntity>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_animatronicEntity(AnimatronicEntity.AnimatronicEntity value)
        {
            this.<animatronicEntity>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateRenderer()
        {
            if((this.<animatronicEntity>k__BackingField.stateData.animatronicState) != 13)
            {
                    return;
            }
            
            this.UpdateBlinkingDefault();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HideAllIcons()
        {
            goto label_0;
            label_5:
            this.Icons[0].Hide();
            0 = 1;
            label_0:
            if(0 < this.Icons.Length)
            {
                goto label_5;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateStateIcons()
        {
            this.HideAllIcons();
            if(this.IsAttacking() == false)
            {
                goto label_0;
            }
            
            MapMode.AnimatronicStatusIcon val_10 = this.Icons[5];
            if(val_10 != null)
            {
                goto label_30;
            }
            
            label_31:
            label_30:
            val_10.Show();
            return;
            label_0:
            if((this.<animatronicEntity>k__BackingField.malfunctioningData.isMalfunctioning) == false)
            {
                goto label_6;
            }
            
            if(this.Icons[0] != null)
            {
                goto label_30;
            }
            
            goto label_31;
            label_6:
            if((this.<animatronicEntity>k__BackingField.stateData.animatronicState) != 10)
            {
                goto label_13;
            }
            
            if(this.Icons[1] != null)
            {
                goto label_30;
            }
            
            goto label_31;
            label_13:
            if((this.<animatronicEntity>k__BackingField.stateData.animatronicState) != 11)
            {
                goto label_20;
            }
            
            if(this.Icons[2] != null)
            {
                goto label_30;
            }
            
            goto label_31;
            label_20:
            if((this.<animatronicEntity>k__BackingField.originData.originState) != 1)
            {
                    return;
            }
            
            if(this.Icons[3] != null)
            {
                goto label_30;
            }
            
            goto label_31;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBlinkingDefault()
        {
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 * this.lostConnectionBlinkSpeedScale;
            var val_3 = (((UnityEngine.Mathf.RoundToInt(f:  val_1)) & 1) != 0) ? 1 : 0;
            goto typeof(MapMode.GeoPositionObject.MapAnimatronic).__il2cppRuntimeField_178;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVisibility()
        {
            if((this.<animatronicEntity>k__BackingField.stateData.animatronicState) == 3)
            {
                    this = ???;
            }
            else
            {
                    this.UpdateStateIcons();
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimatronicEntity(AnimatronicEntity.AnimatronicEntity animatronicEntity, UnityEngine.Camera billboardCamera)
        {
            var val_4;
            System.Action val_5;
            this.<animatronicEntity>k__BackingField = animatronicEntity;
            this._billboardCamera = billboardCamera;
            val_4 = 0;
            this.UnidentifiedIcon._camera = billboardCamera;
            goto label_2;
            label_8:
            MapMode.AnimatronicStatusIcon val_4 = this.Icons[0];
            val_4 = 1;
            this.Icons[0x0][0].Billboard._camera = this._billboardCamera;
            label_2:
            if(val_4 < this.Icons.Length)
            {
                goto label_8;
            }
            
            this.UpdateVisibility();
            val_5 = System.Delegate.Combine(a:  animatronicEntity.StateChanged, b:  new System.Action(object:  this, method:  public System.Void MapMode.GeoPositionObject.MapAnimatronic::OnStateChanged()));
            if(animatronicEntity == null)
            {
                goto label_10;
            }
            
            if(val_5 != null)
            {
                goto label_11;
            }
            
            goto label_14;
            label_10:
            if(val_5 == null)
            {
                goto label_14;
            }
            
            label_11:
            if(null != null)
            {
                    val_5 = 0;
            }
            
            label_14:
            animatronicEntity.StateChanged = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMapIconLoadedSuccessfully(Animatronics.Animatronic3d.PrefabManagement.MapIconContainer container)
        {
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  container.Prefab, parent:  this.Container.transform);
            this._icon = val_3;
            Mapbox.Examples.CameraBillboard val_4 = val_3.GetComponentInChildren<Mapbox.Examples.CameraBillboard>();
            this.Billboard = val_4;
            if(val_4 != 0)
            {
                    if(this._billboardCamera != 0)
            {
                    this.Billboard._camera = this._billboardCamera;
                this.Billboard.Initialized = true;
            }
            
            }
            
            this.FriendIcon.transform.SetParent(parent:  this._icon.transform, worldPositionStays:  false);
            this.FriendIcon.gameObject.SetActive(value:  ((this.<animatronicEntity>k__BackingField.originData.originState) == 4) ? 1 : 0);
            this.ToggleAnimatronicIcon(show:  this._showIcon);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMapIconLoadFailure(string error)
        {
            ConsoleLogger.LogError(className:  "GeoPositionObject.Container", functionName:  "CreateAnimatronic", logString:  "Failed to load Map UnidentifiedIcon!");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStateChanged()
        {
            this.UpdateVisibility();
            if((this.<animatronicEntity>k__BackingField.stateData.expressDelivery) == false)
            {
                    return;
            }
            
            this.ToggleAnimatronicIcon(show:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.UpdateRenderer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsAttacking()
        {
            return (bool)(((this.<animatronicEntity>k__BackingField.stateData.animatronicState) | 1) == 3) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanTap()
        {
            OriginState val_2 = this.<animatronicEntity>k__BackingField.originData.originState;
            AnimatronicState val_4 = this.<animatronicEntity>k__BackingField.stateData.animatronicState;
            if(val_4 <= 9)
            {
                    var val_7 = 1;
                val_7 = val_7 << val_4;
                val_7 = val_7 & 526;
                if(val_7 != 0)
            {
                    return false;
            }
            
            }
            
            var val_6 = ((val_4 & 4294967294) != 10) ? 1 : 0;
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ToggleVisibility(bool show)
        {
            if(this.Container.activeSelf ^ show == false)
            {
                    return;
            }
            
            this.Container.SetActive(value:  show);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleAnimatronicIcon(bool show)
        {
            if(this._icon == 0)
            {
                    return;
            }
            
            this._icon.SetActive(value:  show);
            this.UnidentifiedIconContainer.SetActive(value:  (~show) & 1);
            this.AdjustCollider();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetIconVisibility(bool show)
        {
            this._showIcon = show;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AdjustCollider()
        {
            UnityEngine.Transform val_1 = this.Billboard.transform;
            UnityEngine.Vector3 val_2 = val_1.localScale;
            this.Collider.size = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_3 = val_1.localPosition;
            this.Collider.center = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapAnimatronic()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
