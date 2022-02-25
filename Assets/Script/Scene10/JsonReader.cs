using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
//using Newtonsoft.Json;

public class JsonReader : MonoBehaviour
{
    public string url;

    IEnumerator SendRequest()
    {
        using UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        switch (request.result)
        {
            case UnityWebRequest.Result.ProtocolError:
            case UnityWebRequest.Result.DataProcessingError:
            case UnityWebRequest.Result.ConnectionError:
                Debug.LogWarning(request.error);
                break;
            case UnityWebRequest.Result.Success:
                ParseData(request.downloadHandler.text);
                break;
        }
    }

    public void ParseData(string dataAsString)
    {
        //var data = JsonConvert.DeserializeObject<OrcStats>(dataAsString);
    }
}
