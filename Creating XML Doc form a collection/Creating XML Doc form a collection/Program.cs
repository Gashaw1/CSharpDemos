using System.Xml.Linq;
using System.Linq;

namespace Creating_XML_Doc_form_a_collection
{
    public class User
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }

        //smaple collection data
        public User[] UserData()
        {
            User[] users = new User[5];
            users[0] = new User { userID = 100, userName = "Akal", userEmail = "@akalemail.com" };
            users[1] = new User { userID = 300, userName = "hana", userEmail = "@hanaemail.com" };
            users[2] = new User { userID = 400, userName = "mena", userEmail = "@menamail.com" };
            users[3] = new User { userID = 500, userName = "temsm", userEmail = "@tesmaemail.com" };
            users[4] = new User { userID = 600, userName = "Teddy", userEmail = "@teddyemail.com" };

            return users;
        }
        //convert to xml
        public void ConvertToxML()
        {
            User ur = new User();
            ur.UserData();
            XDocument myXDocument = new XDocument(
            new XDeclaration("1.1", "utf-8", "yes"),
            new XComment("User xml Data"),
            new XElement("Users", from user in ur.UserData()
                                  select new XElement("User", new XAttribute("userID", user.userID),
                                  new XElement("userName", user.userName),
                                  new XElement("userEmali", user.userEmail)
            )));

            //where to save
            myXDocument.Save(@"C:\Users\User\Desktop\CSharpDemos\Creating XML Doc form a collection\Creating XML Doc form a collection\UserData.xml");
        }
        //get data from xml document
        public 
    }
    class Program
    {
        static void Main(string[] args)
        {
            User ur = new User();
            ur.ConvertToxML();

        }
    }
}
