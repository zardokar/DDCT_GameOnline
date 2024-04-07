using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebRequestCaller : MonoBehaviour
{
    public string Target_URL = "https://docs.unity3d.com/Manual/index.html";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log( ClientWebRequest.requestWeb(Target_URL).getStringDataResponse() );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
