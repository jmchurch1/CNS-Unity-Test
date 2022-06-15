using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WebRequest : MonoBehaviour
{
    public JSONAccess jsonAccess;
    private void Start()
    {
        StartCoroutine(GetRequest("https://ccf-api.hubmapconsortium.org/v1/scene"));
    }

    IEnumerator GetRequest(string url)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            yield return webRequest.SendWebRequest();

            string[] pages = url.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                    Debug.LogError("Connection Error");
                    break;
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    // create variable to hold text drawn from webpage
                    string webRequestText = webRequest.downloadHandler.text;
                    // call function to parse the json
                    jsonAccess.JsonFormatting(webRequestText);
                    // show json in debug log
                    Debug.Log(pages[page] + ":\nReceived" + webRequestText);
                    break;
            }
        }
    }
}
