using UnityEngine;

namespace Systems.AssetManagement.Bundles.Config
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BundleTableOfContents
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> LocalToC;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> ServerToC;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> BuildTableOfContentsFromString(string tableOfContentsString)
        {
            return (System.Collections.Generic.Dictionary<System.String, UnityEngine.Hash128>)Systems.AssetManagement.Bundles.Config.BundleTableOfContents.StringToTableOfContents(tableOfContentsString:  tableOfContentsString);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string BuildStringFromTableOfContents(System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> tableOfContents)
        {
            return (string)Systems.AssetManagement.Bundles.Config.BundleTableOfContents.TableOfContentsToString(tableOfContents:  tableOfContents);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> BuildTableOfContentsFromManifest(UnityEngine.AssetBundleManifest manifest)
        {
            return (System.Collections.Generic.Dictionary<System.String, UnityEngine.Hash128>)Systems.AssetManagement.Bundles.Config.BundleTableOfContents.ManifestToTableOfContents(manifest:  manifest);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoadTableOfContentsFromUri(Systems.AssetManagement.Files.IFileCache fileCache, string uri, System.Action<System.Collections.Generic.Dictionary<string, UnityEngine.Hash128>> resultCallback)
        {
            IntPtr val_6;
            BundleTableOfContents.<>c__DisplayClass6_0 val_1 = new BundleTableOfContents.<>c__DisplayClass6_0();
            .resultCallback = resultCallback;
            .FilePath = uri;
            .FileLoadSuccess = new System.Action<Systems.AssetManagement.Files.FileLoadSettings, UnityEngine.Networking.DownloadHandler>(object:  val_1, method:  System.Void BundleTableOfContents.<>c__DisplayClass6_0::<LoadTableOfContentsFromUri>b__0(Systems.AssetManagement.Files.FileLoadSettings settings, UnityEngine.Networking.DownloadHandler downloadHandler));
            System.Action<Systems.AssetManagement.Files.FileLoadSettings> val_4 = null;
            val_6 = System.Void BundleTableOfContents.<>c__DisplayClass6_0::<LoadTableOfContentsFromUri>b__1(Systems.AssetManagement.Files.FileLoadSettings settings);
            val_4 = new System.Action<Systems.AssetManagement.Files.FileLoadSettings>(object:  val_1, method:  val_6);
            .FileLoadFailure = val_4;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = 0;
            fileCache.LoadFileFromPath(settings:  new Systems.AssetManagement.Files.FileLoadSettings());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> StringToTableOfContents(string tableOfContentsString)
        {
            string val_9;
            var val_10;
            var val_11;
            var val_12;
            System.Collections.Generic.Dictionary<System.String, UnityEngine.Hash128> val_1 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Hash128>();
            System.IO.StringReader val_2 = new System.IO.StringReader(s:  tableOfContentsString);
            label_15:
            if((System.String.IsNullOrWhiteSpace(value:  val_2)) == true)
            {
                goto label_2;
            }
            
            char[] val_4 = new char[1];
            val_4[0] = ',';
            System.String[] val_5 = val_2.Split(separator:  val_4);
            if(val_5.Length != 2)
            {
                goto label_7;
            }
            
            UnityEngine.Hash128 val_6 = UnityEngine.Hash128.Parse(hashString:  val_5[1]);
            val_9 = val_5[0];
            val_1.Add(key:  val_9, value:  new UnityEngine.Hash128() {m_u32_0 = val_6.m_u32_0, m_u32_1 = val_6.m_u32_1, m_u32_2 = val_6.m_u32_2, m_u32_3 = val_6.m_u32_3});
            goto label_15;
            label_7:
            val_10 = null;
            val_10 = null;
            val_9 = "StringToTableOfContents";
            ConsoleLogger.LogError(className:  Systems.AssetManagement.Bundles.Config.BundleTableOfContents.ClassName, functionName:  val_9, logString:  "Table of contents line \'" + val_2 + "\' does not contain two elements separated by a comma");
            goto label_15;
            label_2:
            val_11 = 0;
            val_12 = 127;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_2.Dispose();
            if( == false)
            {
                    return val_1;
            }
            
            if( == 127)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string TableOfContentsToString(System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> tableOfContents)
        {
            object val_3;
            int val_10 = System.String.alignConst;
            Dictionary.Enumerator<TKey, TValue> val_1 = tableOfContents.GetEnumerator();
            goto label_2;
            label_3:
            val_10 = val_10 + System.String.Format(format:  "{0},{1}\n", arg0:  val_3.emailUIDataHandler, arg1:  val_3)(System.String.Format(format:  "{0},{1}\n", arg0:  val_3.emailUIDataHandler, arg1:  val_3));
            label_2:
            if((1646195952 & 1) != 0)
            {
                goto label_3;
            }
            
            return (string)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> ManifestToTableOfContents(UnityEngine.AssetBundleManifest manifest)
        {
            var val_4;
            System.Collections.Generic.Dictionary<System.String, UnityEngine.Hash128> val_1 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Hash128>();
            val_4 = 0;
            goto label_2;
            label_7:
            string val_4 = manifest.GetAllAssetBundles()[0];
            UnityEngine.Hash128 val_3 = manifest.GetAssetBundleHash(assetBundleName:  val_4);
            val_1.Add(key:  val_4, value:  new UnityEngine.Hash128() {m_u32_0 = val_3.m_u32_0, m_u32_1 = val_3.m_u32_1, m_u32_2 = val_3.m_u32_2, m_u32_3 = val_3.m_u32_3});
            val_4 = 1;
            label_2:
            if(val_4 < val_2.Length)
            {
                goto label_7;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BundleTableOfContents()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static BundleTableOfContents()
        {
            Systems.AssetManagement.Bundles.Config.BundleTableOfContents.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
