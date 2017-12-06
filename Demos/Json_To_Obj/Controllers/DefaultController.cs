using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace Json_To_Obj.Controllers
{
    public class DefaultController : ApiController
    {
        public void ConvertToJson()
        {
            JavaScriptSerializer jsSer = new JavaScriptSerializer();
            var result = jsSer.Deserialize(Name.jsonString, typeof(Name));
        }
    }
    public class Name
    {
        public int[] Values { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public static string jsonString = "[{\"FirstName\" :\"Divide\",\"LastName\":\"Jones\",\"values\" : [0,1,2]}";

        public Name ConvertToName(string json)
        {

            Name namess = new Name();


            return namess;
        }
    }
}
