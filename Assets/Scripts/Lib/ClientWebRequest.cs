using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;

public class ClientWebRequest
{
    public static WebResponse requestWeb(string url)
    {
        // Create a request for the URL. 	
        WebRequest wclient          = WebRequest.Create(url);

        // If required by the server, set the credentials.
        wclient.Credentials         = CredentialCache.DefaultCredentials;

        // Get the response.
        HttpWebResponse response    = (HttpWebResponse)wclient.GetResponse ();

        // 
        WebResponse result          = new WebResponse(response.StatusDescription, response.GetResponseStream());

        // Cleanup the streams and the response.
        response.Close();

        return result;
    }
}
