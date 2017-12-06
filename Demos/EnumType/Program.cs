using System;

namespace EnumType
{

    class Program
    {

        static void Main(string[] args)
        {


            //Group group = Group.Users | Group.Supervisor | Group.Managers | Group.Administrators;

            User.userGroup = Group.Supervisor | Group.Users;
            Console.WriteLine(User.userGroup);


            //var value = Enum.GetValues(typeof(Group));

            //foreach (var r in value)
            //{
            //    var res = r;
            //    Console.WriteLine(res);
            //}
            //Console.WriteLine(value);
            Console.Read();
        }
    }
    [Flags]
    public enum Group
    {
        Users = 1,
        Supervisor = 2,
        Managers = 4,
        Administrators = 8
    }
    public class User
    {
        public static Group userGroup { get; set; }
    }
}
