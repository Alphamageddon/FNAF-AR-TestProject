using UnityEngine;

namespace Game.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AudioEventLookup
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string RtpcPrefix = "RTPC_";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, Game.Audio.AudioEvent> _audioEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, Game.Audio.AudioParameter> _audioParameters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Audio.AudioEvent GetAudioEventByName(string eventName, string animatronicId)
        {
            return Game.Audio.AudioEventLookup.GetItemFromLookup<Game.Audio.AudioEvent>(id:  animatronicId + "_" + eventName, lookup:  this._audioEvents);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Audio.AudioEvent GetAudioEventByName(string eventName)
        {
            return Game.Audio.AudioEventLookup.GetItemFromLookup<Game.Audio.AudioEvent>(id:  eventName, lookup:  this._audioEvents);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Audio.AudioEvent GetAudioEvent(Game.Audio.AudioEventName name, string animatronicId)
        {
            return (Game.Audio.AudioEvent)Game.Audio.AudioEventLookup.GetItemFromLookup<Game.Audio.AudioEvent>(id:  System.String.Format(format:  "{0}_{1}", arg0:  animatronicId, arg1:  name), lookup:  this._audioEvents);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Audio.AudioEvent GetAudioEvent(Game.Audio.AudioEventName name)
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = name});
            return (Game.Audio.AudioEvent)Game.Audio.AudioEventLookup.GetItemFromLookup<Game.Audio.AudioEvent>(id:  name.ToString(), lookup:  this._audioEvents);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Audio.AudioParameter GetAudioParameter(Game.Audio.AudioParameterName name)
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = name});
            return (Game.Audio.AudioParameter)Game.Audio.AudioEventLookup.GetItemFromLookup<Game.Audio.AudioParameter>(id:  name.ToString(), lookup:  this._audioParameters);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static T GetItemFromLookup<T>(string id, System.Collections.Generic.IReadOnlyDictionary<string, T> lookup)
        {
            var val_4;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(lookup, typeof(__RuntimeMethodHiddenParam + 48), slot: 0) + 8];
            val_4 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(lookup, typeof(__RuntimeMethodHiddenParam + 48), slot: 0) + 8;
            if((lookup & 1) == 0)
            {
                    return 0;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 2;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(lookup, typeof(__RuntimeMethodHiddenParam + 48), slot: 2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool IsRtpcEntry(string gameAudioEvent)
        {
            if(gameAudioEvent != null)
            {
                    return gameAudioEvent.StartsWith(value:  "RTPC_");
            }
            
            return gameAudioEvent.StartsWith(value:  "RTPC_");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool DoesEventNameExist(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO eventInfo)
        {
            var val_4;
            if(eventInfo != null)
            {
                    val_4 = (System.String.IsNullOrWhiteSpace(value:  eventInfo.Name)) ^ 1;
                return (bool)val_4 & 1;
            }
            
            val_4 = 0;
            return (bool)val_4 & 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessRtpcEntry(ProtoData.AUDIO_DATA.Types.ENTRY entry)
        {
            var val_16;
            var val_17;
            WWISEEVENTINFO val_18;
            val_16 = "RTPC_";
            if("RTPC_" == null)
            {
                    val_16 = "RTPC_";
            }
            
            string val_3 = entry.GameAudioEvent.Remove(startIndex:  0, count:  Length);
            if((this._audioParameters.ContainsKey(key:  val_3)) != false)
            {
                    val_17 = null;
                val_17 = null;
                string[] val_5 = new string[5];
                val_5[0] = "Cannot add duplicate entry for \'";
                val_5[1] = entry.GameAudioEvent;
                val_5[2] = "\' with id \'";
                val_5[3] = val_3;
                val_5[4] = "\'";
                ConsoleLogger.LogError(className:  Game.Audio.AudioEventLookup.RtpcPrefix, functionName:  "ProcessRtpcEntry", logString:  +val_5);
                return;
            }
            
            if(entry.WwiseAudioEvents == null)
            {
                    return;
            }
            
            WWISEAUDIOEVENTS val_9 = entry.WwiseAudioEvents;
            if(val_9 != null)
            {
                    val_18 = val_9.Event1;
            }
            else
            {
                    val_18 = 0;
            }
            
            if((Game.Audio.AudioEventLookup.DoesEventNameExist(eventInfo:  val_18)) == false)
            {
                    return;
            }
            
            this._audioParameters.Add(key:  val_3, value:  new Game.Audio.AudioParameter(name:  entry.WwiseAudioEvents.Event1.Name));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessEventEntry(ProtoData.AUDIO_DATA.Types.ENTRY entry)
        {
            var val_19;
            string val_1 = entry.GameAudioEvent;
            if((this._audioParameters.ContainsKey(key:  val_1)) != false)
            {
                    val_19 = null;
                val_19 = null;
                string[] val_3 = new string[5];
                val_3[0] = "Cannot add duplicate entry for \'";
                val_3[1] = entry.GameAudioEvent;
                val_3[2] = "\' with id \'";
                val_3[3] = val_1;
                val_3[4] = "\'";
                ConsoleLogger.LogError(className:  Game.Audio.AudioEventLookup.RtpcPrefix, functionName:  "ProcessEventEntry", logString:  +val_3);
                return;
            }
            
            Game.Audio.AudioEvent val_6 = new Game.Audio.AudioEvent();
            if(entry.WwiseAudioEvents != null)
            {
                    Game.Audio.AudioEventLookup.ProcessWwiseEventInfo(eventInfo:  entry.WwiseAudioEvents.Event1, audioEvent:  val_6);
                Game.Audio.AudioEventLookup.ProcessWwiseEventInfo(eventInfo:  entry.WwiseAudioEvents.Event2, audioEvent:  val_6);
                Game.Audio.AudioEventLookup.ProcessWwiseEventInfo(eventInfo:  entry.WwiseAudioEvents.Event3, audioEvent:  val_6);
                Game.Audio.AudioEventLookup.ProcessWwiseEventInfo(eventInfo:  entry.WwiseAudioEvents.Event4, audioEvent:  val_6);
                Game.Audio.AudioEventLookup.ProcessWwiseEventInfo(eventInfo:  entry.WwiseAudioEvents.Event5, audioEvent:  val_6);
            }
            
            if((Game.Audio.AudioEvent)[1152921525410336848].Names.Count < 1)
            {
                    return;
            }
            
            this._audioEvents.Add(key:  val_1, value:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void ProcessWwiseEventInfo(ProtoData.AUDIO_DATA.Types.ENTRY.Types.WWISEAUDIOEVENTS.Types.WWISEEVENTINFO eventInfo, Game.Audio.AudioEvent audioEvent)
        {
            if((Game.Audio.AudioEventLookup.DoesEventNameExist(eventInfo:  eventInfo)) == false)
            {
                    return;
            }
            
            audioEvent.Names.Add(item:  eventInfo.Name);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AudioEventLookup(ProtoData.AUDIO_DATA audioData)
        {
            var val_24;
            var val_25;
            var val_26;
            var val_29;
            var val_30;
            this._audioEvents = new System.Collections.Generic.Dictionary<System.String, Game.Audio.AudioEvent>();
            this._audioParameters = new System.Collections.Generic.Dictionary<System.String, Game.Audio.AudioParameter>();
            val_24 = 1152921504685174784;
            val_25 = "RTPC_";
            val_26 = audioData.Entries.GetEnumerator();
            label_21:
            var val_26 = 0;
            val_26 = val_26 + 1;
            if(val_26.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            T val_8 = val_26.Current;
            if(((val_8 == 0) || ((System.String.IsNullOrWhiteSpace(value:  val_8.GameAudioEvent)) == true)) || ((System.String.op_Equality(a:  val_8.GameAudioEvent, b:  "RTPC_")) == true))
            {
                goto label_21;
            }
            
            if((Game.Audio.AudioEventLookup.IsRtpcEntry(gameAudioEvent:  val_8.GameAudioEvent)) == false)
            {
                goto label_19;
            }
            
            this.ProcessRtpcEntry(entry:  val_8);
            goto label_21;
            label_19:
            this.ProcessEventEntry(entry:  val_8);
            goto label_21;
            label_8:
            val_29 = 0;
            val_30 = 132;
            if(val_26 == null)
            {
                
            }
            else
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_26.Dispose();
            }
            
            if( == 132)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_26 = ???;
            val_30 = ???;
            val_24 = ???;
            val_25 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AudioEventLookup()
        {
            Game.Audio.AudioEventLookup.RtpcPrefix = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
