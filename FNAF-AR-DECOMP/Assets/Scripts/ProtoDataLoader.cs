using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ProtoDataLoader
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.JsonParser ProtobufJsonParser;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static T DeserializeJSON<T>(string jsonSourceText)
    {
        null = null;
        if(ProtoDataLoader.ProtobufJsonParser == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoDataLoader()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static ProtoDataLoader()
    {
        ProtoDataLoader.ProtobufJsonParser = new Google.Protobuf.JsonParser(settings:  JsonParser.Settings.Default.WithIgnoreUnknownFields(ignoreUnknownFields:  true));
    }

}
