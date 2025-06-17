using UnityEngine;

namespace SimpleDiskUtils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DiskUtils
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int CheckAvailableSpace(bool isExternalStorage = True)
        {
            bool val_1 = isExternalStorage;
            object[] val_3 = new object[1];
            if(val_3 == null)
            {
                goto label_1;
            }
            
            if(val_1 == true)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_1 == false)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_3[0] = val_1;
            return (int)new UnityEngine.AndroidJavaClass(className:  "com.dikra.diskutils.DiskUtils").CallStatic<System.Int32>(methodName:  "availableSpace", args:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int CheckTotalSpace(bool isExternalStorage = True)
        {
            bool val_1 = isExternalStorage;
            object[] val_3 = new object[1];
            if(val_3 == null)
            {
                goto label_1;
            }
            
            if(val_1 == true)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_1 == false)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_3[0] = val_1;
            return (int)new UnityEngine.AndroidJavaClass(className:  "com.dikra.diskutils.DiskUtils").CallStatic<System.Int32>(methodName:  "totalSpace", args:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int CheckBusySpace(bool isExternalStorage = True)
        {
            bool val_1 = isExternalStorage;
            object[] val_3 = new object[1];
            if(val_3 == null)
            {
                goto label_1;
            }
            
            if(val_1 == true)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_1 == false)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_3[0] = val_1;
            return (int)new UnityEngine.AndroidJavaClass(className:  "com.dikra.diskutils.DiskUtils").CallStatic<System.Int32>(methodName:  "busySpace", args:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void DeleteFile(string filePath)
        {
            if((System.IO.File.Exists(path:  filePath)) == false)
            {
                    return;
            }
            
            System.IO.File.Delete(path:  filePath);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SaveFile(object obj, string filePath)
        {
            int val_9;
            string val_10;
            object val_11;
            string val_12;
            string val_13;
            if((obj.GetType() & 1) == 0)
            {
                goto label_3;
            }
            
            label_7:
            val_9 = filePath.Length - 1;
            if()
            {
                goto label_5;
            }
            
            if((filePath.Chars[val_9] & 65535) != ('/'))
            {
                goto label_7;
            }
            
            val_9 = val_9 + 1;
            if(filePath == null)
            {
                goto label_8;
            }
            
            val_10 = filePath.Substring(startIndex:  0, length:  val_9);
            goto label_9;
            label_5:
            val_11 = obj;
            val_12 = filePath;
            val_13 = "";
            goto label_10;
            label_8:
            val_10 = 0.Substring(startIndex:  0, length:  val_9);
            label_9:
            val_12 = filePath.Substring(startIndex:  val_9);
            val_11 = obj;
            val_13 = val_10;
            label_10:
            SimpleDiskUtils.DiskUtils.SaveFile(obj:  val_11, dirPath:  val_13, fileName:  val_12);
            return;
            label_3:
            System.ArgumentException val_8 = new System.ArgumentException(message:  "Passed data is invalid: not serializable.", paramName:  "obj");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SaveFile(object obj, string dirPath, string fileName)
        {
            string val_10 = fileName;
            if((obj.GetType() & 1) != 0)
            {
                    if((System.String.op_Equality(a:  dirPath, b:  "")) != true)
            {
                    if((dirPath.EndsWith(value:  "/")) != false)
            {
                    string val_4 = dirPath + val_10;
            }
            
                val_10 = dirPath + "/"("/") + val_10;
                if((System.IO.Directory.Exists(path:  dirPath)) != true)
            {
                    System.IO.DirectoryInfo val_7 = System.IO.Directory.CreateDirectory(path:  dirPath);
            }
            
            }
            
                System.IO.File.WriteAllBytes(path:  val_10, bytes:  SimpleDiskUtils.DiskUtils.ObjectToByteArray(obj:  obj));
                return;
            }
            
            System.ArgumentException val_9 = new System.ArgumentException(message:  "Passed data is invalid: not serializable.", paramName:  "obj");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T LoadFile<T>(string filePath)
        {
            if((System.IO.File.Exists(path:  filePath)) == false)
            {
                    return 0;
            }
            
            System.Byte[] val_2 = System.IO.File.ReadAllBytes(path:  filePath);
            __RuntimeMethodHiddenParam = ???;
            goto __RuntimeMethodHiddenParam + 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SaveTextFile(string str, string filePath)
        {
            int val_7;
            string val_8;
            string val_9;
            string val_10;
            string val_11;
            label_4:
            val_7 = filePath.Length - 1;
            if()
            {
                goto label_2;
            }
            
            if((filePath.Chars[val_7] & 65535) != ('/'))
            {
                goto label_4;
            }
            
            val_7 = val_7 + 1;
            if(filePath == null)
            {
                goto label_5;
            }
            
            val_8 = filePath.Substring(startIndex:  0, length:  val_7);
            goto label_6;
            label_2:
            val_9 = str;
            val_10 = filePath;
            val_11 = "";
            goto label_7;
            label_5:
            val_8 = 0.Substring(startIndex:  0, length:  val_7);
            label_6:
            val_10 = filePath.Substring(startIndex:  val_7);
            val_9 = str;
            val_11 = val_8;
            label_7:
            SimpleDiskUtils.DiskUtils.SaveTextFile(str:  val_9, dirPath:  val_11, fileName:  val_10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SaveTextFile(string str, string dirPath, string fileName)
        {
            string val_8 = fileName;
            if((System.String.op_Equality(a:  dirPath, b:  "")) != true)
            {
                    if((dirPath.EndsWith(value:  "/")) != false)
            {
                    string val_3 = dirPath + val_8;
            }
            
                val_8 = dirPath + "/"("/") + val_8;
                if((System.IO.Directory.Exists(path:  dirPath)) != true)
            {
                    System.IO.DirectoryInfo val_6 = System.IO.Directory.CreateDirectory(path:  dirPath);
            }
            
            }
            
            if((new System.IO.StreamWriter(path:  val_8)) == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string LoadTextFile<T>(string filePath)
        {
            var val_3;
            if((System.IO.File.Exists(path:  filePath)) == false)
            {
                    return (string)0;
            }
            
            System.IO.StreamReader val_2 = null;
            val_3 = val_2;
            val_2 = new System.IO.StreamReader(path:  filePath);
            0 = val_3;
            return (string)0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static byte[] ObjectToByteArray(object obj)
        {
            var val_5;
            var val_6;
            if(obj == null)
            {
                goto label_1;
            }
            
            if(obj == null)
            {
                goto label_2;
            }
            
            val_5 = null;
            val_6 = obj;
            if(val_6 != null)
            {
                    return (System.Byte[])val_6;
            }
            
            label_1:
            val_6 = 0;
            return (System.Byte[])val_6;
            label_2:
            System.IO.MemoryStream val_3 = new System.IO.MemoryStream();
            new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(serializationStream:  val_3, graph:  obj);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_3.Dispose();
            if(0 == 0)
            {
                    return (System.Byte[])val_6;
            }
            
            if(65 == 65)
            {
                    return (System.Byte[])val_6;
            }
            
            return (System.Byte[])val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T ByteArrayToObject<T>(byte[] bytes)
        {
            var val_6;
            var val_7;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter() = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            val_6 = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(serializationStream:  val_1);
            if(val_6 != null)
            {
                    val_7 = val_6;
                if(val_7 == null)
            {
                    val_7 = 0;
            }
            
                val_6 = 0;
            }
            else
            {
                    val_7 = 0;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_1.Dispose();
            if(val_6 == null)
            {
                    return (object)val_7;
            }
            
            if(62 == 62)
            {
                    return (object)val_7;
            }
            
            return (object)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DiskUtils()
        {
        
        }
    
    }

}
