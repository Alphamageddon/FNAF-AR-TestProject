using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GameSparksDataDownloader
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<string, System.Action<byte[]>> requestMap;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.MonoBehaviour coroutineRunner;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameSparksDataDownloader(UnityEngine.MonoBehaviour behaviour)
    {
        this.requestMap = new System.Collections.Generic.Dictionary<System.String, System.Action<System.Byte[]>>();
        this.coroutineRunner = behaviour;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void GetDownloadableFile(string file, System.Action<byte[]> callback)
    {
        GameSparks.Api.Requests.GetDownloadableRequest val_1 = new GameSparks.Api.Requests.GetDownloadableRequest();
        GameSparks.Api.Requests.GetDownloadableRequest val_2 = val_1.SetShortCode(shortCode:  file);
        this.requestMap.Add(key:  file, value:  callback);
        val_1.Send(callback:  new System.Action<GameSparks.Api.Responses.GetDownloadableResponse>(object:  this, method:  System.Void GameSparksDataDownloader::OnGetDownloadableResponse(GameSparks.Api.Responses.GetDownloadableResponse response)));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnGetDownloadableResponse(GameSparks.Api.Responses.GetDownloadableResponse response)
    {
        string val_9;
        if(response == null)
        {
            goto label_1;
        }
        
        if(response.HasErrors == true)
        {
            goto label_2;
        }
        
        val_9 = response.ShortCode;
        goto label_3;
        label_1:
        if(0.HasErrors == false)
        {
            goto label_4;
        }
        
        label_2:
        ConsoleLogger.LogError(className:  "GameSparksDataDownloader", functionName:  "OnGetDownloadableResponse", logString:  "Error: "("Error: ") + 0.Errors.JSON);
        return;
        label_4:
        val_9 = 0.ShortCode;
        label_3:
        this.GetCallbackFromCodeAndGetDataFileFromUrl(shortCode:  val_9, url:  response.Url);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void GetCallbackFromCodeAndGetDataFileFromUrl(string shortCode, string url)
    {
        string val_6 = url;
        System.Action<System.Byte[]> val_1 = 0;
        bool val_2 = this.requestMap.TryGetValue(key:  shortCode, value: out  val_1);
        if(val_2 != false)
        {
                val_6 = val_2.GetDataFileFromServer(url:  val_6 = url, callback:  val_1);
            UnityEngine.Coroutine val_4 = this.coroutineRunner.StartCoroutine(routine:  val_6);
            bool val_5 = this.requestMap.Remove(key:  shortCode);
            return;
        }
        
        ConsoleLogger.LogError(className:  "GameSparksDataDownloader", functionName:  "OnGetDownloadableResponse", logString:  "Unable to find Callback");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator GetDataFileFromServer(string url, System.Action<byte[]> callback)
    {
        GameSparksDataDownloader.<GetDataFileFromServer>d__6 val_1 = new GameSparksDataDownloader.<GetDataFileFromServer>d__6(<>1__state:  0);
        if(val_1 != null)
        {
                .url = url;
        }
        else
        {
                mem[32] = url;
        }
        
        .callback = callback;
        return (System.Collections.IEnumerator)val_1;
    }

}
