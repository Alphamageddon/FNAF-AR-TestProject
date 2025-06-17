using UnityEngine;

namespace Game.Localization
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TextMeshProUGUILocalizer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Game.Localization.TextMeshProUGUILocalizer>> _textMeshProUGUILocalizersByLocId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _localizationId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _textMeshProUgui;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _originalString;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RedoAllLocalizationLookups()
        {
            var val_4;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_12 = null;
            val_12 = null;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = Game.Localization.TextMeshProUGUILocalizer._textMeshProUGUILocalizersByLocId.Keys.GetEnumerator();
            val_13 = 0;
            label_18:
            if(((-810628640) & 1) == 0)
            {
                goto label_5;
            }
            
            val_14 = null;
            val_14 = null;
            List.Enumerator<T> val_7 = Game.Localization.TextMeshProUGUILocalizer._textMeshProUGUILocalizersByLocId.Item[val_4.emailUIDataHandler].GetEnumerator();
            label_12:
            if(((-810628672) & 1) == 0)
            {
                goto label_10;
            }
            
            val_4.emailUIDataHandler.DoLocalizationNow();
            goto label_12;
            label_10:
            val_15 = val_13;
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525271054784});
            if((((82 == 0) ? 82 : 82) == 82) || ( == 0))
            {
                goto label_18;
            }
            
            goto label_18;
            label_5:
            val_16 = 107;
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525271054816});
            if( == 0)
            {
                    return;
            }
            
            if(82 == 0)
            {
                    return;
            }
            
            if(82 == 107)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool EnsureGlobalLookupExists(Game.Localization.TextMeshProUGUILocalizer textMeshProUguiLocalizer)
        {
            var val_6;
            var val_7;
            var val_8;
            string val_9;
            var val_10;
            var val_11;
            var val_12;
            val_6 = null;
            val_6 = null;
            val_7 = null;
            if((Game.Localization.TextMeshProUGUILocalizer._textMeshProUGUILocalizersByLocId.ContainsKey(key:  textMeshProUguiLocalizer._localizationId)) == false)
            {
                goto label_5;
            }
            
            val_8 = null;
            val_9 = textMeshProUguiLocalizer._localizationId;
            if((Game.Localization.TextMeshProUGUILocalizer._textMeshProUGUILocalizersByLocId.Item[val_9].Contains(item:  textMeshProUguiLocalizer)) == false)
            {
                goto label_10;
            }
            
            val_10 = 1;
            return (bool)val_10;
            label_5:
            val_11 = null;
            val_9 = Game.Localization.TextMeshProUGUILocalizer._textMeshProUGUILocalizersByLocId;
            System.Collections.Generic.List<Game.Localization.TextMeshProUGUILocalizer> val_4 = new System.Collections.Generic.List<Game.Localization.TextMeshProUGUILocalizer>();
            val_4.Add(item:  textMeshProUguiLocalizer);
            val_9.Add(key:  textMeshProUguiLocalizer._localizationId, value:  val_4);
            goto label_16;
            label_10:
            val_12 = null;
            val_12 = null;
            val_9 = textMeshProUguiLocalizer._localizationId;
            Game.Localization.TextMeshProUGUILocalizer._textMeshProUGUILocalizersByLocId.Item[val_9].Add(item:  textMeshProUguiLocalizer);
            label_16:
            val_10 = 0;
            return (bool)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EnsureTextMeshProUGUILink()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this._textMeshProUgui)) != true)
            {
                    TMPro.TextMeshProUGUI val_3 = this.gameObject.GetComponent<TMPro.TextMeshProUGUI>();
                this._textMeshProUgui = val_3;
                this._originalString = val_3.text;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this._textMeshProUgui)) != false)
            {
                    return;
            }
            
            ConsoleLogger.LogError(className:  "TextMeshProUGUILocalizer", functionName:  "EnsureTextMeshProUGUILink", logString:  "Can\'t find TextMeshProUGUI component on " + this.gameObject.name);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DoLocalizationNow()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this)) == false)
            {
                    return;
            }
            
            this.EnsureTextMeshProUGUILink();
            if((UnityEngine.Object.op_Implicit(exists:  this._textMeshProUgui)) == false)
            {
                    return;
            }
            
            if(Game.Localization.LocalizationDomain._localizationDomain == null)
            {
                    return;
            }
            
            GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void Game.Localization.TextMeshProUGUILocalizer::DoLocalizationNowCallback(Game.Localization.ILocalization iLocalization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DoLocalizationNowCallback(Game.Localization.ILocalization iLocalization)
        {
            TMPro.TextMeshProUGUI val_9;
            string val_10;
            string val_12;
            string val_13;
            val_9 = 1152921504851574784;
            if((UnityEngine.Object.op_Implicit(exists:  this)) == false)
            {
                    return;
            }
            
            val_9 = this._textMeshProUgui;
            if((UnityEngine.Object.op_Implicit(exists:  val_9)) == false)
            {
                    return;
            }
            
            val_10 = this._localizationId;
            var val_10 = 0;
            val_10 = val_10 + 1;
            string val_4 = iLocalization.GetLocalizedString(localizedStringId:  val_10, originalString:  this._originalString);
            if((System.String.IsNullOrEmpty(value:  val_4)) != false)
            {
                    string[] val_6 = new string[6];
                val_6[0] = "Can\'t find loc string. localizationId:\'";
                val_6[1] = this._localizationId;
                val_6[2] = "\' originalString:";
                val_6[3] = this._originalString;
                val_6[4] = " GameObject:";
                val_10 = Game.Localization.TextMeshProUGUILocalizer.GetTransformHierarchy(transform:  this.transform);
                val_6[5] = val_10;
                ConsoleLogger.LogError(className:  "TextMeshProUGUILocalizer", functionName:  "DoLocalizationNowCallback", logString:  +val_6);
                val_12 = this._originalString;
                val_13 = val_12;
            }
            else
            {
                    val_12 = this._textMeshProUgui;
                val_13 = val_4;
            }
            
            val_12.text = val_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string GetTransformHierarchy(UnityEngine.Transform transform)
        {
            if((UnityEngine.Object.op_Implicit(exists:  transform.parent)) == false)
            {
                    return "";
            }
            
            return transform.parent + "/"("/") + transform.name;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            if((Game.Localization.TextMeshProUGUILocalizer.EnsureGlobalLookupExists(textMeshProUguiLocalizer:  this)) != false)
            {
                    return;
            }
            
            this.DoLocalizationNow();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TextMeshProUGUILocalizer()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static TextMeshProUGUILocalizer()
        {
            Game.Localization.TextMeshProUGUILocalizer._textMeshProUGUILocalizersByLocId = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Game.Localization.TextMeshProUGUILocalizer>>();
        }
    
    }

}
