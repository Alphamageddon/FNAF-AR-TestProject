using UnityEngine;

namespace SRDebugger.UI.Tabs
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InfoTabController : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const char Tick = '\x2713';
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const char Cross = '\xd7';
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string NameColor = "#BCBCBC";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, SRDebugger.UI.Controls.InfoBlock> _infoBlocks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.UI.Controls.InfoBlock InfoBlockPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform LayoutContainer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            this.OnEnable();
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Refresh()
        {
            var val_14;
            var val_19;
            var val_20;
            var val_21;
            SRDebugger.Services.ISystemInformationService val_1 = SRF.Service.SRServiceManager.GetService<SRDebugger.Services.ISystemInformationService>();
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_14 = 0;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_14 = 0;
            System.Collections.Generic.IEnumerator<T> val_5 = val_1.GetCategories().GetEnumerator();
            label_27:
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_14 = 0;
            if(val_5.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            T val_9 = val_5.Current;
            if((this._infoBlocks.ContainsKey(key:  val_9)) == true)
            {
                goto label_27;
            }
            
            this._infoBlocks.Add(key:  val_9, value:  this.CreateBlock(title:  val_9));
            goto label_27;
            label_18:
            val_19 = 0;
            val_20 = 82;
            val_21 = 1152921505148272640;
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_14 = 0;
                val_5.Dispose();
            }
            
            if( == 82)
            {
                
            }
            else
            {
                    if( != false)
            {
                    val_14 = 0;
                val_19 = 0;
            }
            
            }
            
            Dictionary.Enumerator<TKey, TValue> val_13 = this._infoBlocks.GetEnumerator();
            label_50:
            if((1152008600 & 1) == 0)
            {
                goto label_51;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_14 = 0.trackableId;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_14 = 1;
            System.Collections.Generic.IList<SRDebugger.InfoEntry> val_17 = val_1.GetInfo(category:  val_14.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, SRDebugger.UI.Controls.InfoBlock>::get_Key()));
            val_17.FillInfoBlock(block:  val_14.m_SubId1, info:  val_17);
            goto label_50;
            label_51:
            long val_18 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921522938724760});
            if( == 0)
            {
                    return;
            }
            
            if(157 == 0)
            {
                    return;
            }
            
            if(157 == 157)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FillInfoBlock(SRDebugger.UI.Controls.InfoBlock block, System.Collections.Generic.IList<SRDebugger.InfoEntry> info)
        {
            var val_34;
            var val_35;
            var val_39;
            var val_41;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            var val_38 = 0;
            val_38 = val_38 + 1;
            System.Collections.Generic.IEnumerator<T> val_3 = info.GetEnumerator();
            label_22:
            label_19:
            var val_39 = 0;
            val_39 = val_39 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_40 = 0;
            val_40 = val_40 + 1;
            T val_7 = val_3.Current;
            if(val_7.Title.Length <= 0)
            {
                goto label_19;
            }
            
            int val_11 = val_7.Title.Length;
            goto label_22;
            label_11:
            val_34 = 0;
            val_35 = 73;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_41 = 0;
                val_41 = val_41 + 1;
                val_3.Dispose();
            }
            
            if( != 73)
            {
                goto label_36;
            }
            
            if(info != null)
            {
                goto label_40;
            }
            
            goto label_38;
            label_36:
            if( != false)
            {
                    val_34 = 0;
            }
            
            if(info != null)
            {
                goto label_40;
            }
            
            label_38:
            label_40:
            var val_42 = 0;
            val_42 = val_42 + 1;
            System.Collections.Generic.IEnumerator<T> val_15 = info.GetEnumerator();
            label_78:
            var val_43 = 0;
            val_43 = val_43 + 1;
            val_39 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(val_15.MoveNext() == false)
            {
                goto label_50;
            }
            
            var val_44 = 0;
            val_44 = val_44 + 1;
            T val_19 = val_15.Current;
            if((1 & 1) == 0)
            {
                    System.Text.StringBuilder val_20 = val_1.AppendLine();
            }
            
            System.Text.StringBuilder val_21 = val_1.Append(value:  "<color=");
            System.Text.StringBuilder val_22 = val_1.Append(value:  "#BCBCBC");
            System.Text.StringBuilder val_23 = val_1.Append(value:  ">");
            System.Text.StringBuilder val_25 = val_1.Append(value:  val_19.Title);
            System.Text.StringBuilder val_26 = val_1.Append(value:  ": ");
            System.Text.StringBuilder val_27 = val_1.Append(value:  "</color>");
            val_41 = val_19.Title.Length;
            goto label_67;
            label_69:
            System.Text.StringBuilder val_30 = val_1.Append(value:  ' ');
            val_41 = val_41 + 1;
            label_67:
            if(val_41 <= (0 + 2))
            {
                goto label_69;
            }
            
            if(val_19.Value != null)
            {
                    if(null == null)
            {
                goto label_72;
            }
            
            }
            
            System.Text.StringBuilder val_33 = val_1.Append(value:  val_19.Value);
            goto label_78;
            label_72:
            object val_34 = val_19.Value;
            System.Text.StringBuilder val_36 = val_1.Append(value:  (null == 0) ? 215 : 10003);
            goto label_78;
            label_50:
            if(val_15 == null)
            {
                
            }
            else
            {
                    var val_45 = 0;
                val_45 = val_45 + 1;
                val_39 = public System.Void System.IDisposable::Dispose();
                val_15.Dispose();
            }
            
            if((( != false) && (309 != 0)) && (309 != 309))
            {
                    val_39 = 0;
            }
            
            if((block + 72) == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.UI.Controls.InfoBlock CreateBlock(string title)
        {
            SRDebugger.UI.Controls.InfoBlock val_1 = SRInstantiate.Instantiate<SRDebugger.UI.Controls.InfoBlock>(prefab:  this.InfoBlockPrefab);
            val_1.CachedTransform.SetParent(parent:  this.LayoutContainer, worldPositionStays:  false);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InfoTabController()
        {
            this._infoBlocks = new System.Collections.Generic.Dictionary<System.String, SRDebugger.UI.Controls.InfoBlock>();
        }
    
    }

}
