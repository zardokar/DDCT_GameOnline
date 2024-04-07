using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class ClientWebRequest
{
    public static void requestWeb(string url)
    {
        // Create a request for the URL. 	
        WebRequest wclient  = WebRequest.Create(url);

        // If required by the server, set the credentials.
        wclient.Credentials = CredentialCache.DefaultCredentials;

        // Get the response.
        HttpWebResponse response = (HttpWebResponse)wclient.GetResponse ();

        Debug.Log( response.StatusDescription );
    }
}
