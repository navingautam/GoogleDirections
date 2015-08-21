using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessors.DriveMate
{
    public class DeliveryMapInfo
    {
        
        public string GetDirectionDataJson(string request)
        {
            string _sData = string.Empty;
            string me = string.Empty;
            try
            {
                if (request.ToLower().IndexOf("http:") > -1)
                {
                    System.Net.WebClient wc = new System.Net.WebClient();
                    byte[] response = wc.DownloadData(request);
                    _sData = System.Text.Encoding.ASCII.GetString(response);

                }
                else
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(request);
                    _sData = sr.ReadToEnd();
                    sr.Close();
                }
                
            }
            catch { _sData = "unable to connect to server "; }
            return _sData;
        }
    }
}
