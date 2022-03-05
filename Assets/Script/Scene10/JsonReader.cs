using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
//using Newtonsoft.Json;

public class JsonReader : MonoBehaviour
{
    public string url;
    public TextAsset text;

    OrcStats orc;

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
                ParseDataFromResources(text.text);
                break;
            case UnityWebRequest.Result.Success:
                Debug.Log("Sent succesfully");
                Debug.Log(request.downloadHandler.text);

                ParseData(request.downloadHandler.text);
                break;
        }
    }

    public void ParseData(string dataAsString)
    {
        //var data = JsonConvert.DeserializeObject<OrcStats>(dataAsString);
        orc = new OrcStats();
        orc = JsonUtility.FromJson<OrcStats>(dataAsString);
    }

    public void ParseDataFromResources(string text)
    {
        orc = new OrcStats();
        orc = JsonUtility.FromJson<OrcStats>(text);
    }

    private void Start()
    {
        StartCoroutine(SendRequest());
    }
}
