using System;
namespace krisna_test_3
{
	public class User
	{

        //      public int id = 0;
        //public string name = string.Empty;

        //      public User()
        //{
        //	// constructor name
        //}

        //public void getUserDetails(int uid, string uname)
        //{
        //	id = uid;
        //	uname = name;

        //	Console.WriteLine("id {0}, Name: {1}", id, name);
        //}

        //public int Designtion { get; set; }
        //public string Location { get; set; }

        public string Name;
        private string Location;
        public User()
        {
            Console.WriteLine("Base Class Constructor");
        }

        public void GetUserDetails(string loc)
        {
            Location = loc;
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Locartion: {0}", Location);
        }
    }

    public class Details : User
    {
        public int Age;
        public Details()
        {
            Console.WriteLine("Chill Class Constructor");
        }

        public void getAge()
        {
            Console.WriteLine("Age: {0}", Age);
        }
    }
}

