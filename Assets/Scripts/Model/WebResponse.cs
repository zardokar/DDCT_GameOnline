using System.IO;

public class WebResponse 
{
    private string StatusDescription;
    private string responsedata;

    public WebResponse(string StatusDescription, string responsedata)
    {
        this.responsedata                = responsedata;
        this.StatusDescription      = StatusDescription;
    }

    public WebResponse(string StatusDescription, Stream responseStream)
    {
        this.StatusDescription      = StatusDescription;

        Stream dataStream           = responseStream;
        StreamReader reader         = new StreamReader (dataStream);
        this.responsedata           = reader.ReadToEnd ();

        reader.Close();
        dataStream.Close();
    }

    public string getStringDataResponse()
    {
        return this.responsedata;
    }

}
