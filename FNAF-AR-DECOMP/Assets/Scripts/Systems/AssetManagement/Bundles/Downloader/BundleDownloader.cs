using UnityEngine;

namespace Systems.AssetManagement.Bundles.Downloader
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BundleDownloader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <NumSegmentsFinished>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <FailedAssetCount>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string UnreferencedBundleSegmentName = "Unreferenced Bundles Segment";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.BundleLoader _bundleLoader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.Config.BundleTableOfContents _bundleTableOfContents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.Config.IBundleDownloadConfig _bundleDownloadConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData> _progressCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _completeCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Systems.AssetManagement.Bundles.Downloader.BundleSegment> _segments;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<Systems.AssetManagement.Bundles.Downloader.BundleSegment> _pendingSegmentDownloads;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _completed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _total;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumSegmentsFinished { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int FailedAssetCount { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_NumSegmentsFinished()
        {
            return (int)this.<NumSegmentsFinished>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_NumSegmentsFinished(int value)
        {
            this.<NumSegmentsFinished>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_FailedAssetCount()
        {
            return (int)this.<FailedAssetCount>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_FailedAssetCount(int value)
        {
            this.<FailedAssetCount>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PrepareForDownloads(System.Collections.Generic.Dictionary<string, Systems.AssetManagement.Bundles.BundleState> bundleStateLookup, Systems.AssetManagement.Bundles.Config.BundleTableOfContents bundleTableOfContents, Systems.AssetManagement.Bundles.Config.IBundleDownloadConfig bundleDownloadConfig, System.Action completeCallback)
        {
            this._bundleTableOfContents = bundleTableOfContents;
            this._bundleDownloadConfig = bundleDownloadConfig;
            this._completeCallback = completeCallback;
            this.GenerateBundleDownloadSegments(bundleStateLookup:  bundleStateLookup);
            if(this._segments.Count != 0)
            {
                    return;
            }
            
            if(this._completeCallback != null)
            {
                    this._completeCallback.Invoke();
            }
            
            this._completeCallback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsSegmentFinished(string segmentName)
        {
            string val_4;
            var val_5;
            val_4 = segmentName;
            if((this._segments.ContainsKey(key:  val_4)) != false)
            {
                    val_4 = this._segments.Item[val_4];
                var val_3 = (val_2.IsDownloadComplete == true) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 1;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddSegmentToQueue(string segmentName)
        {
            System.Collections.Generic.Queue<Systems.AssetManagement.Bundles.Downloader.BundleSegment> val_5;
            if((this.IsSegmentFinished(segmentName:  segmentName)) == true)
            {
                    return;
            }
            
            val_5 = this._pendingSegmentDownloads;
            if((val_5.Contains(item:  this._segments.Item[segmentName])) != false)
            {
                    return;
            }
            
            this._pendingSegmentDownloads.Enqueue(item:  this._segments.Item[segmentName]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddUnreferencedSegmentToQueue()
        {
            this.AddSegmentToQueue(segmentName:  "Unreferenced Bundles Segment");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartDownloads(System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData> progressCallback)
        {
            Systems.AssetManagement.Bundles.BundleDownloadProgressData val_4;
            int val_5;
            this._progressCallback = progressCallback;
            this._completed = 0;
            int val_1 = this.CalculateDownloadCount();
            this._total = val_1;
            if(val_1 == 0)
            {
                goto label_1;
            }
            
            if(this._progressCallback == null)
            {
                goto label_2;
            }
            
            Systems.AssetManagement.Bundles.BundleDownloadProgressData val_2 = null;
            val_4 = val_2;
            val_2 = new Systems.AssetManagement.Bundles.BundleDownloadProgressData();
            if(val_4 == null)
            {
                goto label_3;
            }
            
            .Complete = this._completed;
            val_5 = this._total;
            goto label_4;
            label_1:
            if(this._progressCallback == null)
            {
                goto label_5;
            }
            
            Systems.AssetManagement.Bundles.BundleDownloadProgressData val_3 = new Systems.AssetManagement.Bundles.BundleDownloadProgressData();
            if(val_3 == null)
            {
                goto label_6;
            }
            
            .Complete = 1;
            goto label_7;
            label_3:
            mem[16] = this._completed;
            val_5 = this._total;
            label_4:
            .Total = val_5;
            this._progressCallback.Invoke(obj:  val_2);
            label_2:
            this.DownloadBundlesForCurrentSegment();
            return;
            label_6:
            mem[16] = 1;
            label_7:
            .Total = 1;
            this._progressCallback.Invoke(obj:  val_3);
            label_5:
            if(this._completeCallback != null)
            {
                    this._completeCallback.Invoke();
            }
            
            this._completeCallback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool AreAllSegmentsLoaded()
        {
            var val_7;
            var val_8;
            val_7 = this._segments.Values;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = val_7.GetEnumerator();
            label_5:
            if((1641280648 & 1) == 0)
            {
                goto label_3;
            }
            
            val_7 = 0.emailUIDataHandler;
            if(val_3._emailIdsToBeSetToReadOnServer != null)
            {
                goto label_5;
            }
            
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523427996808});
            val_8 = 0;
            return (bool)val_8;
            label_3:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523427996808});
            val_8 = 1;
            return (bool)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FinishDownloadingBundles()
        {
            if(this._completeCallback != null)
            {
                    this._completeCallback.Invoke();
            }
            
            this._completeCallback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateBundleDownloadSegments(System.Collections.Generic.Dictionary<string, Systems.AssetManagement.Bundles.BundleState> bundleStateLookup)
        {
            var val_5;
            var val_33;
            var val_35;
            var val_36;
            var val_40;
            var val_41;
            System.Collections.Generic.Dictionary<TKey, TValue> val_43;
            var val_44;
            var val_45;
            var val_47;
            var val_48;
            System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = bundleStateLookup.Keys.GetEnumerator();
            label_5:
            if((1641626528 & 1) == 0)
            {
                goto label_3;
            }
            
            bool val_7 = val_1.Add(item:  val_5.emailUIDataHandler);
            goto label_5;
            label_3:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523428342688});
            val_33 = 0;
            System.Collections.Generic.Dictionary<System.String, Systems.AssetManagement.Bundles.Downloader.BundleSegment> val_10 = new System.Collections.Generic.Dictionary<System.String, Systems.AssetManagement.Bundles.Downloader.BundleSegment>();
            mem[1152921523428354880] = val_10;
            var val_39 = mem[1152921523428354856];
            if((mem[1152921523428354856] + 286) == 0)
            {
                goto label_14;
            }
            
            var val_36 = mem[1152921523428354856] + 176;
            var val_37 = 0;
            val_36 = val_36 + 8;
            label_13:
            if(((mem[1152921523428354856] + 176 + 8) + -8) == null)
            {
                goto label_12;
            }
            
            val_37 = val_37 + 1;
            val_36 = val_36 + 16;
            if(val_37 < (mem[1152921523428354856] + 286))
            {
                goto label_13;
            }
            
            goto label_14;
            label_12:
            var val_38 = val_36;
            val_38 = val_38 + 1;
            val_39 = val_39 + val_38;
            val_35 = val_39 + 296;
            label_14:
            val_36 = mem[1152921523428354856].GetBundleDownloadSegmentConfigs();
            if(val_36 == null)
            {
                    System.Collections.Generic.List<Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig> val_12 = null;
                val_36 = val_12;
                val_12 = new System.Collections.Generic.List<Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig>();
                if(val_36 == null)
            {
                goto label_56;
            }
            
            }
            
            label_56:
            var val_40 = 0;
            val_40 = val_40 + 1;
            System.Collections.Generic.IEnumerator<T> val_14 = val_12.GetEnumerator();
            label_55:
            var val_41 = 0;
            val_41 = val_41 + 1;
            if(val_14.MoveNext() == false)
            {
                goto label_26;
            }
            
            var val_42 = 0;
            val_42 = val_42 + 1;
            new Systems.AssetManagement.Bundles.Downloader.BundleSegment() = new Systems.AssetManagement.Bundles.Downloader.BundleSegment(config:  val_14.Current);
            List.Enumerator<T> val_20 = (Systems.AssetManagement.Bundles.Downloader.BundleSegment)[1152921523428419648].Config.BundleNames.GetEnumerator();
            label_42:
            if((1641626496 & 1) == 0)
            {
                goto label_35;
            }
            
            GameUI.EmailUIDataHandler val_21 = val_5.emailUIDataHandler;
            if((bundleStateLookup.ContainsKey(key:  val_21)) == false)
            {
                goto label_42;
            }
            
            (Systems.AssetManagement.Bundles.Downloader.BundleSegment)[1152921523428419648].BundleStates.Enqueue(item:  bundleStateLookup.Item[val_21]);
            bool val_24 = val_1.Remove(item:  val_21);
            goto label_42;
            label_35:
            val_40 = 0;
            val_41 = 0;
            long val_25 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523428342656});
            if(((214 == 0) ? 214 : 214) == 214)
            {
                
            }
            
            val_10.Add(key:  val_18 + 16, value:  new Systems.AssetManagement.Bundles.Downloader.BundleSegment());
            goto label_55;
            label_26:
            val_44 = 0;
            val_43 = 0;
            val_45 = 257;
            if(val_14 == null)
            {
                
            }
            else
            {
                    var val_43 = 0;
                val_43 = val_43 + 1;
                val_14.Dispose();
            }
            
            if((( == 0) ? 257 : ()) != 257)
            {
                goto label_75;
            }
            
            val_47 = 0;
            if(val_1 != null)
            {
                goto label_79;
            }
            
            goto label_77;
            label_75:
            if( != false)
            {
                    val_43 = 0;
            }
            
            if(val_1 != null)
            {
                goto label_79;
            }
            
            label_77:
            label_79:
            if(val_1.Count < 1)
            {
                    return;
            }
            
            .SegmentName = "Unreferenced Bundles Segment";
            .BundleNames = 0;
            .ConcurrentMax = 1;
            .SegmentCompleteCallback = 0;
            HashSet.Enumerator<T> val_32 = val_1.GetEnumerator();
            label_86:
            if((1641626472 & 1) == 0)
            {
                goto label_82;
            }
            
            (Systems.AssetManagement.Bundles.Downloader.BundleSegment)[1152921523428448336].BundleStates.Enqueue(item:  bundleStateLookup.Item[0.emailUIDataHandler]);
            goto label_86;
            label_82:
            val_47 = 366;
            val_48 = val_43;
            long val_35 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523428342632});
            val_43 = mem[1152921523428354880];
            val_10.Add(key:  (Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig)[1152921523428444240].SegmentName, value:  new Systems.AssetManagement.Bundles.Downloader.BundleSegment(config:  new Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int CalculateDownloadCount()
        {
            var val_3;
            Queue.Enumerator<T> val_1 = this._pendingSegmentDownloads.GetEnumerator();
            val_3 = 0;
            goto label_2;
            label_5:
            val_3 = (???.Count) + val_3;
            label_2:
            if((1641833880 & 1) != 0)
            {
                goto label_5;
            }
            
            return (int)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DownloadBundlesForCurrentSegment()
        {
            string val_12;
            System.Collections.Generic.HashSet<System.String> val_13;
            var val_14;
            val_12 = this;
            if((this._pendingSegmentDownloads == null) || (this._pendingSegmentDownloads.Count == 0))
            {
                goto label_2;
            }
            
            Systems.AssetManagement.Bundles.Downloader.BundleSegment val_2 = this._pendingSegmentDownloads.Peek();
            if(val_2.IsStartingBundleDownloads == true)
            {
                    return;
            }
            
            if(val_2.BundleStates.Count != 0)
            {
                goto label_7;
            }
            
            val_13 = val_2.InProgressDownloads;
            if(val_13.Count == 0)
            {
                goto label_9;
            }
            
            label_7:
            val_2.IsStartingBundleDownloads = true;
            goto label_10;
            label_19:
            Systems.AssetManagement.Bundles.BundleState val_5 = val_2.BundleStates.Peek();
            bool val_7 = val_2.InProgressDownloads.Add(item:  val_5.<Info>k__BackingField.name);
            this.DownloadBundle(state:  val_2.BundleStates.Dequeue());
            label_10:
            if(val_2.BundleStates.Count >= 1)
            {
                    if(val_2.InProgressDownloads.Count < val_2.Config.ConcurrentMax)
            {
                goto label_19;
            }
            
            }
            
            val_13 = val_2.InProgressDownloads;
            val_2.IsStartingBundleDownloads = false;
            if(val_13.Count != 0)
            {
                    return;
            }
            
            label_9:
            this.MarkCurrentSegmentFinished();
            return;
            label_2:
            val_14 = null;
            val_14 = null;
            val_12 = Systems.AssetManagement.Bundles.Downloader.BundleDownloader.UnreferencedBundleSegmentName;
            ConsoleLogger.LogError(className:  val_12, functionName:  "DownloadBundlesForCurrentSegment", logString:  "Can\'t download bundles for null segment");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MarkCurrentSegmentFinished()
        {
            var val_5;
            if((this._pendingSegmentDownloads == null) || (this._pendingSegmentDownloads.Count == 0))
            {
                goto label_2;
            }
            
            int val_5 = this.<NumSegmentsFinished>k__BackingField;
            val_5 = val_5 + 1;
            this.<NumSegmentsFinished>k__BackingField = val_5;
            this._pendingSegmentDownloads.Dequeue().MarkFinished();
            if(this._pendingSegmentDownloads.Count < 1)
            {
                goto label_6;
            }
            
            this.DownloadBundlesForCurrentSegment();
            return;
            label_2:
            val_5 = null;
            val_5 = null;
            ConsoleLogger.LogError(className:  Systems.AssetManagement.Bundles.Downloader.BundleDownloader.UnreferencedBundleSegmentName, functionName:  "MarkCurrentSegmentFinished", logString:  "Can\'t mark null segment finished");
            return;
            label_6:
            if(this.AreAllSegmentsLoaded() == false)
            {
                    return;
            }
            
            if(this._completeCallback != null)
            {
                    this._completeCallback.Invoke();
            }
            
            this._completeCallback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DownloadBundle(Systems.AssetManagement.Bundles.BundleState state)
        {
            UnityEngine.CachedAssetBundle val_7;
            Systems.AssetManagement.Bundles.LoadingStatus val_7 = state.<Status>k__BackingField;
            val_7 = val_7 - 1;
            if(val_7 > 1)
            {
                goto label_2;
            }
            
            goto label_3;
            label_2:
            if((UnityEngine.Caching.IsVersionCached(cachedBundle:  new UnityEngine.CachedAssetBundle() {m_Name = state.<Info>k__BackingField.m_Name, m_Hash = new UnityEngine.Hash128() {m_u32_0 = state.<Info>k__BackingField.m_Name, m_u32_1 = state.<Info>k__BackingField.m_Name, m_u32_2 = mem[state.<Info>k__BackingField + 16], m_u32_3 = mem[state.<Info>k__BackingField + 16]}})) == false)
            {
                goto label_4;
            }
            
            val_7;
            label_3:
            this.MarkBundleFinished(info:  new UnityEngine.CachedAssetBundle() {m_Name = state.<Info>k__BackingField.m_Name, m_Hash = new UnityEngine.Hash128() {m_u32_0 = state.<Info>k__BackingField.m_Name, m_u32_1 = state.<Info>k__BackingField.m_Name, m_u32_2 = mem[state.<Info>k__BackingField + 16], m_u32_3 = mem[state.<Info>k__BackingField + 16]}});
            return;
            label_4:
            if((this._bundleTableOfContents.LocalToC.ContainsKey(key:  state.<Info>k__BackingField.m_Name.emailUIDataHandler)) != false)
            {
                    UnityEngine.Hash128 val_5 = this._bundleTableOfContents.LocalToC.Item[state.<Info>k__BackingField.m_Name.emailUIDataHandler];
                if((UnityEngine.Hash128.op_Equality(hash1:  new UnityEngine.Hash128() {m_u32_0 = val_5.m_u32_0, m_u32_1 = val_5.m_u32_1, m_u32_2 = val_5.m_u32_2, m_u32_3 = val_5.m_u32_3}, hash2:  new UnityEngine.Hash128() {m_u32_0 = 1642404944, m_u32_1 = 268435460})) != false)
            {
                    mem[1152921523429202096] = this;
                mem[1152921523429202104] = System.Void Systems.AssetManagement.Bundles.Downloader.BundleDownloader::DownloadSuccess(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle);
                mem[1152921523429202080] = System.Void Systems.AssetManagement.Bundles.Downloader.BundleDownloader::DownloadSuccess(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle);
                mem[1152921523429206192] = this;
                mem[1152921523429206200] = System.Void Systems.AssetManagement.Bundles.Downloader.BundleDownloader::DownloadFailure(UnityEngine.CachedAssetBundle info);
                mem[1152921523429206176] = System.Void Systems.AssetManagement.Bundles.Downloader.BundleDownloader::DownloadFailure(UnityEngine.CachedAssetBundle info);
                this._bundleLoader.CacheBundle(state:  state, onSuccess:  new Systems.AssetManagement.Bundles.BundleLoadSuccess(), onFailure:  new Systems.AssetManagement.Bundles.BundleLoadFailure());
                return;
            }
            
            }
            
            mem[1152921523429214384] = this;
            mem[1152921523429214392] = System.Void Systems.AssetManagement.Bundles.Downloader.BundleDownloader::DownloadSuccess(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle);
            mem[1152921523429214368] = System.Void Systems.AssetManagement.Bundles.Downloader.BundleDownloader::DownloadSuccess(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle);
            mem[1152921523429218480] = this;
            mem[1152921523429218488] = System.Void Systems.AssetManagement.Bundles.Downloader.BundleDownloader::DownloadFailure(UnityEngine.CachedAssetBundle info);
            mem[1152921523429218464] = System.Void Systems.AssetManagement.Bundles.Downloader.BundleDownloader::DownloadFailure(UnityEngine.CachedAssetBundle info);
            this._bundleLoader.DownloadBundle(state:  state, onSuccess:  new Systems.AssetManagement.Bundles.BundleLoadSuccess(), onFailure:  new Systems.AssetManagement.Bundles.BundleLoadFailure());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DownloadSuccess(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle)
        {
            this.MarkBundleFinished(info:  new UnityEngine.CachedAssetBundle() {m_Name = info.m_Name, m_Hash = new UnityEngine.Hash128() {m_u32_0 = 1642634704, m_u32_1 = 268435460, m_u32_2 = info.m_Hash.m_u32_2}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DownloadFailure(UnityEngine.CachedAssetBundle info)
        {
            var val_3;
            int val_3 = this.<FailedAssetCount>k__BackingField;
            val_3 = val_3 + 1;
            this.<FailedAssetCount>k__BackingField = val_3;
            val_3 = null;
            val_3 = null;
            ConsoleLogger.LogError(className:  Systems.AssetManagement.Bundles.Downloader.BundleDownloader.UnreferencedBundleSegmentName, functionName:  "DownloadBundle", logString:  System.String.Format(format:  "Failed to download \'{0}:{1}\'", arg0:  info.m_Name.emailUIDataHandler, arg1:  1152921523429491712));
            this.MarkBundleFinished(info:  new UnityEngine.CachedAssetBundle() {m_Name = info.m_Name, m_Hash = new UnityEngine.Hash128() {m_u32_0 = 1642779600, m_u32_1 = 268435460, m_u32_2 = info.m_Hash.m_u32_2}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MarkBundleFinished(UnityEngine.CachedAssetBundle info)
        {
            int val_5;
            int val_5 = this._completed;
            val_5 = val_5 + 1;
            this._completed = val_5;
            if(this._progressCallback != null)
            {
                    Systems.AssetManagement.Bundles.BundleDownloadProgressData val_1 = new Systems.AssetManagement.Bundles.BundleDownloadProgressData();
                if(val_1 != null)
            {
                    .Complete = this._completed;
                val_5 = this._total;
            }
            else
            {
                    mem[16] = this._completed;
                val_5 = this._total;
            }
            
                .Total = val_5;
                this._progressCallback.Invoke(obj:  val_1);
            }
            
            if(this._pendingSegmentDownloads == null)
            {
                    return;
            }
            
            if(this._pendingSegmentDownloads.Peek() == null)
            {
                    return;
            }
            
            bool val_4 = val_2.InProgressDownloads.Remove(item:  info.m_Name.emailUIDataHandler);
            this.DownloadBundlesForCurrentSegment();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BundleDownloader(Systems.AssetManagement.Bundles.BundleLoader bundleLoader)
        {
            this._pendingSegmentDownloads = new System.Collections.Generic.Queue<Systems.AssetManagement.Bundles.Downloader.BundleSegment>();
            this._bundleLoader = bundleLoader;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            if(this._pendingSegmentDownloads == null)
            {
                goto label_2;
            }
            
            label_5:
            if(this._pendingSegmentDownloads.Count <= 0)
            {
                goto label_2;
            }
            
            this._pendingSegmentDownloads.Dequeue().MarkFinished();
            if(this._pendingSegmentDownloads != null)
            {
                goto label_5;
            }
            
            label_2:
            this._pendingSegmentDownloads = 0;
            if(this._segments != null)
            {
                    this._segments.Clear();
            }
            
            this._bundleTableOfContents = 0;
            this._bundleDownloadConfig = 0;
            this._bundleLoader = 0;
            this._completeCallback = 0;
            this._segments = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static BundleDownloader()
        {
            Systems.AssetManagement.Bundles.Downloader.BundleDownloader.UnreferencedBundleSegmentName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
