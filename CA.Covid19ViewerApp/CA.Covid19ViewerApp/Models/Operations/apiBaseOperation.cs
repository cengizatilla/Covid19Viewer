using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace CA.Covid19ViewerApp.Models.Operations
{
    public static class apiBaseOperation
    {
        public static string readApiAddress(string apiAddress)
        {
            string contextData = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader readStream = null;
            try
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }
                    contextData = readStream.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                response.Close();
                readStream.Close();
            }
            return contextData == null ? string.Empty : contextData;
        }
    }
}