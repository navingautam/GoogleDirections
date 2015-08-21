using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataProcessors.DriveMate
{
    public class DirectionsHelper
    {
        public bool getDirections(string origin, string destination, string alternatives, string waypoints)
        {
           
            try
            {
                DeliveryMapInfo dmi = new DeliveryMapInfo();

                string request = "http://maps.googleapis.com/maps/api/directions/json?origin=" + origin + "&destination=" + destination + "&alternatives=" + alternatives + "&waypoints=" + waypoints;

                string response = dmi.GetDirectionDataJson(request);

                dynamic jsonObj = JsonConvert.DeserializeObject(response);
                
                string status = jsonObj.status;
                              
                
                if (status == "NOT_FOUND" || status =="ZERO_RESULTS")
                    return false;
                string htmlcontent = "<html>"+"\n";
                htmlcontent = htmlcontent+"<head>"+"\n";
                htmlcontent = htmlcontent + "<title>Directions</title>" + "\n";
                htmlcontent = htmlcontent + "</head>" + "\n";
                htmlcontent = htmlcontent + "<body>" + "\n";

                foreach (var route in jsonObj.routes)
                {
                    htmlcontent = htmlcontent + "<h1>Summary: " + route.summary + "</h1>" + "\n";
                    foreach (var leg in route.legs)
                    {
                        htmlcontent = htmlcontent + "<table border=1>" + "\n";
                        htmlcontent = htmlcontent + "<tr><td><b>Leg</td><td>" + leg.duration.text + "</td></tr>" + "\n";
                        foreach (var step in leg.steps)
                        {
                            htmlcontent = htmlcontent + "<tr><td>" + step.html_instructions + "</td><td>" + step.duration.text + "</td></tr>" + "\n";
                        }
                        htmlcontent = htmlcontent + "</table>" + "\n";
                    }
                    htmlcontent = htmlcontent + "<br />" + "\n";
                }
                htmlcontent = htmlcontent + "</body>" + "\n";
                htmlcontent = htmlcontent + "</html>" + "\n";

                StreamWriter file = new StreamWriter(@"..\..\Output\directions_file.html");
                file.WriteLine(htmlcontent);

                file.Close();
                return true;
            }
            catch(Exception ex)
            {
                
            }
            return false;
            
        }
    }
}
