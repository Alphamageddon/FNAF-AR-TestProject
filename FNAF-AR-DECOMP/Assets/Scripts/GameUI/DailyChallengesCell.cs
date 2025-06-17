using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengesCell : MonoBehaviour, ICellInterface<GameUI.DailyChallengesCellData>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image _icon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _title;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _description;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Slider _completionSlider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _numerator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _denominator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _isCompleteMark;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.DailyChallengesCellData data)
        {
            this.UpdateText(data:  data);
            this.UpdateSlider(data:  data);
            this.UpdateIsCompleteCheckmark(data:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateIsCompleteCheckmark(GameUI.DailyChallengesCellData data)
        {
            if(this._isCompleteMark == null)
            {
                    return;
            }
            
            this._isCompleteMark.SetActive(value:  data.dcData.IsComplete());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateText(GameUI.DailyChallengesCellData data)
        {
            this._title.text = data.dcData.Name;
            this._description.text = data.dcData.Description;
            this._numerator.text = data.dcData.CurrentCompletion.ToString();
            this._denominator.text = data.dcData.MaxCompletion.ToString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateSlider(GameUI.DailyChallengesCellData data)
        {
            this._completionSlider.maxValue = (float)data.dcData.MaxCompletion;
            if(this._completionSlider == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSprite(UnityEngine.Sprite sprite)
        {
            this._icon.overrideSprite = sprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengesCell()
        {
        
        }
    
    }

}
