using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;


namespace ConsoleApp55555555
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!555555555555");
            string str1 = "[{\"Name\":\"qd\",\"ProUrl\":\"123\"}]";
            var file_objs = new JArray();
            try
            {
                file_objs = JArray.Parse(str1);
            }
            catch (Exception ex)
            {
                
                return;
            }

            string name;
            string url;
                        // string hh = "[{\"mid\": \"123456\",\"nid\": \"321\",\"data\": [{\"mid\": \"1\",\"name\": \"111\" },{\"mid\": \"2\",\"name\": \"222\"}, {\"mid\": \"3\",\"name\": \"333\" },{\"mid\": \"4\",\"name\": \"444\"},{\"mid\": \"5\",\"name\": \"555\" }    ]},{\"mid\": \"123456\",\"nid\": \"321\",\"data\": [ {\"mid\": \"1\",\"name\": \"111\" }, {\"mid\": \"2\",\"name\": \"222\" }, {\"mid\": \"3\",\"name\": \"333\"},{\"mid\": \"4\",\"name\": \"444\" }, {\"mid\": \"5\", \"name\": \"555\" } ]}\r\n]";

                        // string hh = "[{\"mid\": \"123456\",\"nid\": \"321\",\"data\": [{\"mid\": \"1\",\"name\": \"111\" },{\"mid\": \"2\",\"name\": \"222\"}, {\"mid\": \"3\",\"name\": \"333\" },{\"mid\": \"4\",\"name\": \"444\"},{\"mid\": \"5\",\"name\": \"555\" }    ]},{\"mid\": \"123456\",\"nid\": \"321\",\"data\": [ {\"mid\": \"1\",\"name\": \"111\" }, {\"mid\": \"2\",\"name\": \"222\" }, {\"mid\": \"3\",\"name\": \"333\"},{\"mid\": \"4\",\"name\": \"444\" }, {\"mid\": \"5\", \"name\": \"555\" } ]}\r\n]";
                        JArray jArray = JArray.Parse(str1);
            foreach (var jj in jArray)
            {
                // string job= jj.ToString();
                //JObject jObject=JObject.Parse(job);
                JObject job = (JObject)jj;

                if (jArray.Contains("Name"))
                {
                    JArray datArray = JArray.Parse(job["Name"].ToString());
                    foreach (var item in datArray)
                    {
                        JObject jdata = (JObject)item;

                        name = jdata["Name"].ToString();
                    }
                }

                if (file_objs.Contains("ProUrl"))
                {
                    JArray datArray = JArray.Parse(job["ProUrl"].ToString());
                    foreach (var item in datArray)
                    {
                        JObject jdata = (JObject)item;

                        name = jdata["name"].ToString();
                    }
                }

            }
            //if (json.Contains("name"))
            //{

            //};
            //if (json.IndexOf("\"Name\":") > -1)
            //{
            //    //存在name属性
            //    string jsonText1 = json[0].ToString();
            //    string jsonText2 = json[1].ToString();
            //    string jsonText3 = json[2].ToString();

            //    var mJObj = JObject.Parse(jsonText2);
            //}

           

           // mJObj.Add(); //新增，没试过


          
        }
    }
}
