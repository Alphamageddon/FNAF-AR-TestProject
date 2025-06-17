using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FlashGraphic : UIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DecayTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color DefaultColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color FlashColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Graphic Target;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.Target == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.Target == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this.Target == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void Update()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Flash()
        {
            if(this.Target == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FlashGraphic()
        {
            this.DecayTime = 0.15f;
            this.DefaultColor = 0;
            mem[1152921520760553840] = 0;
            mem[1152921520760553848] = 0;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.FlashColor = val_1;
            mem[1152921520760553856] = val_1.g;
            mem[1152921520760553860] = val_1.b;
            mem[1152921520760553864] = val_1.a;
        }
    
    }

}
