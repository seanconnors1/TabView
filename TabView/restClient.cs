using System;
using System.IO;
using System.Net;
using System.Text;

namespace TabView
{

    //Different Rest Commands. Defines the names of them for the program
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class restClient
    {
        //End point is the area where the URIs are held
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        //Intiates values for endPoint and httpMethod
        public restClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        ////Send out the HTTP request
        public String makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: 404");
                }
                //Process the response strem (the JSON, XML, or HTML)

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }//End of Stream reader
                    }
                }//End of using response Stream
            }//End of using response


            return strResponseValue;
        }
    }
}
