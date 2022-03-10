using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCsApp
{
    
    //DayThree Task
    /*public interface Vehicles
    {
        void cars();
    }
    
    public class Drive : Vehicles
    {
        public void cars()
        {
            Console.WriteLine("this is car");
        }
    }

    public interface Person
    {
        void userInfo();
        void setuserInfo(string name,int age,int amount);
    }

    public interface Company
    {
        void insorunceInfo();
    }

    public class Insorunce : Company, Person
    {
        public string name;
        public int age;
        public int amount;

       public void  setuserInfo(string name, int age, int amount)
        {
            this.name = name;
            this.age = age; 
            this.amount = amount;
        }

        public void userInfo()
        {
            Console.WriteLine("Name : " + this.name);
            Console.WriteLine("Age : " + this.age);
        }

        public void insorunceInfo()
        {
            if(this.age <= 25)
            {
                Console.WriteLine("Insorunce : " + this.amount * 10 / 100);
            }
            else
            {
                Console.WriteLine("Insorunce : " + this.amount * 20/ 100);
            }
        }
    }
*/

    
    internal class Program
    {
        Program()
        {
            //constructor
        }
        static void Main(string[] args)
        {

            /* String msg = "Hello Word";
             Console.WriteLine(msg);

             //data-type
             //c# is strongly typed language
             int numberone = 100;
             Console.WriteLine(numberone);

             int FirstNum;
             FirstNum = 1020;
             Console.WriteLine(FirstNum);
             FirstNum = numberone;
             Console.WriteLine(FirstNum);

             //explicitly typed
             int m = 10;



             //implicitly typed
             var j = 100121;      //var cannot asign multiple variable

             //data-type
             // 1)value typed    2) refrence typed
             //1.1)simple  1.2)enum   1.3)struct   1.4)nullable
             //2.1)class type   2.2)interface  2.3)


             string s = "hello world";
             char[] ch = { 'h', 'e', 'l', 'l', 'o' };

             string s1 = new string(ch);

             foreach (char c in ch)
             {
                 Console.WriteLine(c);
             }

             string s2 = @"test@gmail.com";
             Console.Write(s2);
             Console.WriteLine(s2);

             string s3 = "hi \n" + "hello \n" + "value";
             Console.WriteLine(s3);

             string ename = "Dr." + "Mahesh" + "idd";

             string firstname = "Mahesh";
             string secondname = "idd";

             string parson = firstname + secondname;

             string fullname = $"Dr. {firstname} + {secondname}";  // string interpolation
            */

            //DayOne Task 1 : odd even

           /* Console.WriteLine("Enter the Numner : ");
            string num = Console.ReadLine();
            int number = Convert.ToInt32(num);


            if (number % 2 == 0)
            {
                Console.WriteLine("The Given Number " + number + " is Even");
            }
            else
            {
                Console.WriteLine("The Given Number " + number + " is Odd");
            }
            */
            
            //DayOne Task 2 : divide  the string into two half if string length is more then 5

            /*console.writeline("enter the string");
            string s4=console.readline();   

            if(s4.length >= 5)
            {
                console.writeline(s4.substring(0,(s4.length/2)));
                console.writeline(s4.substring((s4.length / 2)));
            }
            else
            {
                console.writeline(s4);
            }*/


            // DayOne Task 3 : concanate two string if length is more then five

           /* console.writeline("enter the first string : ");
            string firststring = console.readline();
            console.writeline("enter the second string : ");
            string secondstring = console.readline();

            if((firststring.length >= 5) && (secondname.length >=5))
            {
                string thirdstring=firststring + secondname;
                console.writeline(thirdstring); 
            }
            else
            {
                string thirdstring="";  
                console.writeline(thirdstring); 
            }*/


            //DayOne Task 4 : factorial of number

            /*Console.WriteLine("Enter the Number : ");
            string fact = Console.ReadLine();  
            int factnum = Convert.ToInt32(fact);
            int temp = factnum;
            int factnumber = 1;

            while(factnum > 1)
            {
                factnumber = factnumber * factnum;
                factnum--;
            }

            Console.WriteLine("Factorial of "+ temp + " : " + factnumber);
            */


            // DayTwo task 1: Print message from given Odd-Even number

            /*Console.WriteLine("enter the Number");
            string strnumber = Console.ReadLine(); 
            int numberthree = Convert.ToInt32(strnumber);

            if(numberthree % 2 == 0)
            {
                Console.WriteLine("Hello Even");
            }
            else
            {
                Console.WriteLine("Hello Odd");
            }*/

             //date-time in-built function

           /* DateTime dt = new DateTime();
            Console.WriteLine(dt);

            DateTime dt1 = new DateTime(2022, 03, 21, 03, 30, 45, DateTimeKind.Utc);
            Console.WriteLine(dt1); 

            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);

            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);

            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            DateTime currentDateTimeUtc = DateTime.UtcNow;
            Console.WriteLine(currentDateTimeUtc);*/



            //DayTwo Task 2 : get the birthdate as string from user and calculate the age

            /*
            Console.WriteLine("Enter the Birth Date");
            string birth = Console.ReadLine();
            DateTime birthdate= Convert.ToDateTime(birth);
            DateTime today = DateTime.Today;

            int year=Math.Abs(birthdate.Year- today.Year);
            int month = Math.Abs(birthdate.Month - today.Month);
            int day = Math.Abs(birthdate.Day - today.Day);

            Console.WriteLine("your Age is : Year " + year + " Month " + month + " Days " + day);
            */


            //DayTwo Task 3 : convert the Datetime to string

            /*DateTime today = DateTime.Today;
            string strbirth = today.ToString();
            Console.WriteLine(strbirth);*/



            // struct 
           /* Person person = new Person(1,"abc","surat","surat");
            

            Console.WriteLine(person.Id);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Address);
            Console.WriteLine(person.City); */


            // stringbuilder
            /*StringBuilder sb=new StringBuilder("Good Morning",50);
            Console.WriteLine(sb);   
            string s=sb.ToString();
            Console.WriteLine(s);   

            for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine(s[i]);
            }

            sb.Append(" James");
            Console.WriteLine(sb);  
            Console.WriteLine(sb.GetType());

            sb.Insert(6, "Good");
            Console.WriteLine(sb);

            sb.Remove(6, 4);
            Console.WriteLine(sb);

            sb.Replace("Morning", "Night");
            Console.WriteLine(sb);
            */

            //DayTwo Task 4: append Name using string Builder
            /*
            Console.WriteLine("Enter the Full Name : ");
            string fullname= Console.ReadLine();

            StringBuilder FullName= new StringBuilder(fullname);
            Console.WriteLine("Your Name : "+ FullName);

            Console.WriteLine("You want to append (yes/no) ? ");
            string c = Console.ReadLine();

            if(c=="yes")
            {
                Console.WriteLine("append name : ");
               string s= Console.ReadLine();
                FullName.Append(s);
                Console.WriteLine("your Full Name : " + FullName);
            }*/


            //DayTwo Task 5 :  struct function stringbuilder gettype amd typeof
            
            /*Person person= new Person();
            Console.WriteLine("Enter the First Nsme : ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter the Last Nsme : ");
            string lname = Console.ReadLine();
            person.set(fname, lname);
            person.get();

            int a = 0;
            Console.WriteLine(a.GetType());

            Console.WriteLine(a.GetType() == typeof(int));*/

            
            //nullable
            /*
            Nullable<int> i = null;
            Console.WriteLine(i);
            int? a=null;
            Console.WriteLine(a);*/

            //DayTwo Task 6 : creat a srtuct it hold the value of customer 

           /* Console.WriteLine("Enter the Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Amount : ");
            int amount = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Customer customer = new Customer(name,amount,age); 

            switch(customer.Age)
            {
                case int n when (n <= 25):
                    Console.WriteLine("your 10% loan  : " + customer.Amount*10/100);
                    break;
                    case int n when (n > 25 && n <= 30):
                    Console.WriteLine("your 20% loan : " + customer.Amount*20/100);
                    break;
                case int n when (n >30  && n <= 35):
                    Console.WriteLine("your 30% loan : " + customer.Amount*30/100);
                    break;
                case int n when (n > 35 && n <= 40):
                    Console.WriteLine("your 35% loan : " + customer.Amount*35/100);
                    break;
                case int n when (n > 40 && n <= 45):
                    Console.WriteLine("your 40% loan : " + customer.Amount*40/100);
                    break;
                case int n when (n > 45 && n <= 50):
                    Console.WriteLine("your 45% loan : " + customer.Amount*45/100);
                    break;
                default:
                    Console.WriteLine("your 50% loan : " + customer.Amount*50/100); 
                    break ;
            }
           */



            //enum
            /*  Console.WriteLine(months.january);

            int p= (int)months.january; 
            Console.WriteLine(p);

            dynamic psqw = "james";

            Console.WriteLine(psqw.GetType());*/


            //interface
            /* Vehicles vehicles = new Drive();
             vehicles.cars();*/



            //DayThree Task
            /*Insorunce person = new Insorunce();
            person.setuserInfo("abc", 20, 50000);
            person.userInfo();
            person.insorunceInfo(); */



            

            /*int[] num = new int[5];
            int[][] number = new int[5][];
            int k = 0;
            Console.WriteLine("enter the array Size : ");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {

                num[i] = Convert.ToInt32(Console.ReadLine()); 
                if (i==num.Length-1)
                {
                    number[k++]=num;
                }
               
            }

            for(int i=0; i < 5; i++)
            {
                for(int j=0; j < 5; j++)
                {
                    Console.WriteLine(number[j][i]);    
                }
            }*/


            //DayThree Task : 
            /* string[] name = new string[9]  { "Mahesh","reena","hina", "Mike", "Raj","tejal", "Praveen", "Dinesh","jaya" };
             char[] xender = new char[] { 'm', 'f', 'f', 'm', 'm','f','m','m','f' };

             //for(int i = 0; i < name.Length; i++)
             //{
             //    Console.WriteLine("Name : "+ name[i] + "   || Age : " + age[i]);
             //}

             string[] male = new string[5];
             string[] female = new string[5];
             int m = 0;
             int f=0;

             for (int i = 0; i < name.Length; i++)
             {
                 if(xender[i]=='m')
                 {
                     male[m++] = name[i];
                 }
                 else if(xender[i]=='f')
                 {
                     female[f++] = name[i];  
                 }
             }


             Console.WriteLine("male : ");

             foreach (string m1 in male)
                 Console.WriteLine(m1);


             Console.WriteLine("\nfemale : ");
             foreach (string f1 in female)
                 Console.WriteLine(f1);

             //Console.WriteLine("binary search : "+ Array.BinarySearch(name, "reena"));
             int[] age = new int[5] { 10, 46, 85, 30, 22 };
             Array.Sort(age);
             int flag = Array.BinarySearch(age, 22);
             Console.WriteLine(flag);*/





            //ArrayList: size is increasing dynamicly and helps you add diffrente data type

            /* ArrayList a= new ArrayList();
             a.Add(10);
             a.Add("abc");
             a.Add('x');
             a.Add(true);
             a.Add(10.20);

             int[] arr = { 10, 20, 30 };

             a.AddRange(arr);
             Console.WriteLine(a.Count);
            // Console.WriteLine(a[6]);
             Console.WriteLine(a.Contains(10));

             ArrayList number = new ArrayList();
            */


            //List
            /*
                        var number = new List<int>();


                        int[] arr = { 10, 20, 30 };
                        number.AddRange(arr); 
                        number.Add(2);
                        number.Add(3);
                        number.Add(5);
                        number.Add(4);
                        number.Add(1);


                        foreach (int i in number)  
                            Console.WriteLine(i);
                        number.Sort();
                        foreach (int i in number)
                            Console.WriteLine(i);

                        Console.WriteLine(number.Count);
                        //Console.WriteLine(number);
            */




            //Daythree Task 1 : change the last name by user input
            /* var customers = new List<Customers>()
             {
                 new Customers(){ Id=1, fname="James", lname="poter"},
                 new Customers(){ Id=2, fname="peter", lname="parker"},
                new Customers(){ Id=3, fname="parker", lname="parker"}

             };

             foreach (Customers customer in customers)
                 Console.WriteLine("Id : "+ customer.Id + "  First Name : "+ customer.fname + "  Last Name : "+ customer.lname);


             Console.WriteLine("enter the Id that you want to update : ");
             int id = Convert.ToInt32(Console.ReadLine()); 

             foreach (var i in customers)
             {
                 if (i.Id == id)
                 {
                     Console.WriteLine("enter the last name : ");
                     i.lname = Console.ReadLine();
                     Console.WriteLine("updated customer : \nId : " + i.Id + "  First Name : " + i.fname + "  Last Name : " + i.lname);

                 }

             }*/



            /*
              DtStation<int> dtStation = new DtStation<int>();
              dtStation.trans = 1000;

              KeyValue<string, string> kv = new KeyValue<string, string>();
              kv.Key = "Id";
              kv.Value = "1";
              Console.WriteLine(kv.Key + " :  " + kv.Value);*/



            //sortedList
            /*SortedList<int, string> list = new SortedList<int, string>();

            list.Add(1, "james");
            list.Add(2, "Roy");
            list.Add(3, "David");

            foreach (var kvp in list)
                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);*/


            /*SortedList<int, string> import_list = new SortedList<int, string>();
            import_list.Add(100, "usa");
            import_list.Add(200, "uk");
            import_list.Add(300, "uae");
            import_list.Add(400, "wi");

            SortedList<int, string> export_list = new SortedList<int, string>();
            export_list.Add(500, "India");
            export_list.Add(600, "rusia");
            export_list.Add(700, "srilanka");
            export_list.Add(800, "thailand");

            Console.WriteLine("Exaport List : ");
            foreach (var export in export_list)
                Console.WriteLine(export.Value);

            Console.WriteLine("where you want to exaport");
            string expt = Console.ReadLine();
            int expocost;
            foreach (var export in export_list)
                if (export.Value == expt)
                    expocost =Convert.ToInt32( export.Key);

            Console.WriteLine("Import List : ");
            foreach (var import in import_list)
                Console.WriteLine(import.Value);

            Console.WriteLine("where you want to import");
            string impt = Console.ReadLine();
            int impocost;
            foreach (var import in import_list)
                if (import.Value == impt)
                    impocost = import.Key;

            Console.WriteLine("cost is :" + expocost);*/


            /*Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "james");
            dictionary.Add(2, "poter");

            foreach ( KeyValuePair<int, string> dic in dictionary)
                Console.WriteLine("key : {0} , Value : {1}",dic.Key, dic.Value);*/

            /*
                        Dictionary<int, string> import = new Dictionary<int, string>();
                        import.Add(1, "usa");
                        import.Add(2, "india");
                        import.Add(3, "thiland");
                        import.Add(4, "westIndies");
                        Console.WriteLine("import Port : ");
                        foreach (KeyValuePair<int, string> imp in import)
                            Console.WriteLine( imp.Value);
                        Console.WriteLine("enter the port name from where you want impot");
                        string impt=Console.ReadLine();

                        Dictionary<int, string> export = new Dictionary<int, string>();
                        export.Add(1, "uk");
                        export.Add(2, "srilanka");
                        export.Add(3, "uae");
                        export.Add(4, "rusia");
                        Console.WriteLine("Export Port : ");
                        foreach (KeyValuePair<int, string> exp in export)
                            Console.WriteLine(exp.Value);
                        Console.WriteLine("enter the port name from where you want expot");
                        string expt = Console.ReadLine();
            */

                        List<string> user = new List<string>();

                        Console.WriteLine("enter Your Name : ");
                        user.Add(Console.ReadLine());
                        Console.WriteLine("enter Your Phone Number : ");
                        user.Add(Console.ReadLine());

                        user.Add(user[0].Substring(0,3) + user[1].Substring(0,3));
                        //user.Add("james poter");
                        //user.Add("9099593541");
                        //user.Add("james@123");

                        Console.WriteLine("Enter Best Friend Name : ");
                        user.Add(Console.ReadLine());
                       // Console.WriteLine("Enter Your Pet Name : ");
                        //user.Add(Console.ReadLine());
                        //Console.WriteLine("enter Primary School Name : ");
                        //user.Add(Console.ReadLine());


                        Console.WriteLine("Hello "+ user[0]);
                        Console.WriteLine("Your Phone Number is " + user[1]);
                        Console.WriteLine("Generated Password is " + user[2]);

                        Dictionary<string, int> LoginPage = new Dictionary<string, int>();
                        LoginPage.Add("FirstTime Login", 1);
                        LoginPage.Add("Login", 2);
                        LoginPage.Add("Forgot Password", 3);
                        LoginPage.Add("Logout", 4);
                        int flagmain=1;
            
            while (flagmain)
            {

                        Console.WriteLine("\nChoose any one");
                        foreach (var person in LoginPage)
                        {
                            Console.WriteLine(person.Key);
                        }

                        string option = Console.ReadLine();

                        if(LoginPage[option]==1)
                        {

                            int flag = 1;

                            while (flag == 1)
                            {
                                Console.WriteLine("\nLogin");
                                Console.WriteLine("User Name : ");

                                string name = Console.ReadLine();

                                Console.WriteLine("Password : ");
                                string pass = Console.ReadLine();

                                if (name == user[0] && pass == user[2])
                                {
                                    Console.WriteLine("Login Successfull");
                                    Console.WriteLine("Enter the new Password : ");
                                    user[0] = Console.ReadLine();
                                    flag = 0;
                                }
                                else
                                {
                                    Console.WriteLine("Enter the Valid Information");
                                }
                            }

                        }
                        else if(LoginPage[option]==2)
                        {

                            int flag = 1;

                            while (flag == 1)
                            {
                                Console.WriteLine("\nLogin");
                                Console.WriteLine("User Name : ");

                                string name = Console.ReadLine();

                                Console.WriteLine("Password : ");
                                string pass = Console.ReadLine();

                                if (name == user[0] && pass == user[2])
                                {
                                    Console.WriteLine("Login Successfull");
                                    flag = 0;
                                }
                                else
                                {
                                    Console.WriteLine("Enter the Valid Information");
                                }
                            }

                        }
                        else if (LoginPage[option]==3)
                        {

                            int flag = 1;

                            while (flag == 1)
                            {
                                Console.WriteLine("enter your Best friend Name : ");
                                string friendname = Console.ReadLine();

                                if (friendname == user[3])
                                {
                                    Console.WriteLine("Enter the new Password : ");
                                    user[0] = Console.ReadLine();
                                    flag = 0;
                                }
                                else
                                {
                                    Console.WriteLine("Enter the Valid Information");
                                }
                            }

                        }
                        else if(LoginPage[option]==4)
                        {
                            flagmain=0;
                        }
                        
            }
                        Console.WriteLine("Hello " + user[0]);
                        Console.WriteLine("your Phone Number is " + user[1]);
                        Console.WriteLine("updated password is " + user[2]);
         
                        SortedList<string,int> port_list = new SortedList<string, int>();
                        port_list.Add("usa", 1);
                        port_list.Add("uk",2);
                        port_list.Add("uae",3);
                        port_list.Add("india",4);
                        port_list.Add("rusia",5);
                        port_list.Add("thailand",6);

                        SortedList<string, int> port_cost = new SortedList<string, int>();
                        port_cost.Add("usa", 103);
                        port_cost.Add("uk", 402);
                        port_cost.Add("uae", 302);
                        port_cost.Add("india", 200);
                        port_cost.Add("rusia", 742);
                        port_cost.Add("thailand", 003);


                        Console.WriteLine("Port List : ");
                        foreach (var port in port_list)
                            Console.WriteLine(port.Key); 
                        Console.WriteLine("enter the port Name from where you want to export");
                        string export=Console.ReadLine();
                        string appointdate = "10/03/2022";
                        DateTime apdate = DateTime.Parse(appointdate);
                        int asign=0;

                        if(port_list.ContainsKey(export))
                        {
                            asign = Convert.ToInt32(port_list[export]);
                        }

                        Console.WriteLine("Port List : ");
                        foreach (var port in port_list)
                        {
                            if(Convert.ToInt32(port.Value) != asign)
                            {
                                Console.WriteLine(port.Key);
                            }
                        }
                        Console.WriteLine("enter the port Name where you want to import");
                        string import=Console.ReadLine();
                        Console.WriteLine("ID : " + port_list[export]+"  source : " + export );
                        Console.WriteLine("ID : " + port_list[import]+"  source : " + import);
                        Console.WriteLine("Cost : " + Math.Abs(port_cost[export] + port_cost[import]) * 10);


                        Console.WriteLine("you want to edit the appointment ? (yes/no) ");
                        string strflag=Console.ReadLine();

                        if(strflag=="yes")
                        {
                            Console.WriteLine("enter the Today Date : ");
                            string today = Console.ReadLine();
                            DateTime day = DateTime.Parse(today);

                            if (Math.Abs(apdate.Day - day.Day) > 3)
                            {
                                Console.WriteLine("can't edit");
                            }
                            else
                            {
                                Console.WriteLine("Port List : ");
                                foreach (var port in port_list)
                                    Console.WriteLine(port.Key);
                                Console.WriteLine("enter the port Name from where you want to export");
                                string export1 = Console.ReadLine();
                                string appointdate1 = "10/03/2022";
                                DateTime apdate1 = DateTime.Parse(appointdate1);
                                int asign1 = 0;

                                if (port_list.ContainsKey(export1))
                                {
                                    asign = Convert.ToInt32(port_list[export1]);
                                }

                                Console.WriteLine("Port List : ");
                                foreach (var port in port_list)
                                {
                                    if (Convert.ToInt32(port.Value) != asign1)
                                    {
                                        Console.WriteLine(port.Key);
                                    }
                                }
                                Console.WriteLine("enter the port Name where you want to import");
                                string import1 = Console.ReadLine();
                                Console.WriteLine("ID : " + port_list[export1] + "  source : " + export1);
                                Console.WriteLine("ID : " + port_list[import1] + "  source : " + import1);
                                Console.WriteLine("Cost : " + Math.Abs(port_cost[export1] + port_cost[import1]) * 10);
                            }
                        }

        }

        /*
               class DtStation<T>
                {
                    public T trans { get; set; }
                }

                class KeyValue<TKey, TValue>
                {
                    public TKey Key { get; set; } 
                    public TValue Value { get; set; }
                }*/


        /*  public class Customers
          {
              public int Id  {get; set; }
              public string fname { get; set; }

              public string lname { get; set; }
          }*/



        //enum months
        //{
        //    january,
        //    february,
        //    march
        //}

        //DayTwo Task 5 :  struct function stringbuilder gettype amd typeof
        /*struct Person
        {
            public StringBuilder FirstName;
            public StringBuilder LastName;

            public void set(string fname,string lname)
            {
                this.FirstName = new StringBuilder(fname);
                this.LastName = new StringBuilder(lname);  
            }

            public void get()
            {
                Console.WriteLine($"Full Name : {this.FirstName} {this.LastName}");
                Console.WriteLine("First Name : " + this.FirstName);  
                Console.WriteLine("Last NAme : " + this.LastName);
            }
        }*/

        /*struct Person
        {
            public int Id;
            public string Name;
            public string Address;
            public string City;

            public Person(int Id, string Name, string Address, string City)
            {
                this.Id = Id;
                this.Name = Name;   
                this.Address = Address;
                this.City = City;

            }

        }*/

         //DayTwo Task 6 : creat a srtuct it hold the value of customer 
        /*     struct Customer
         {
             public string Name;
             public int Amount;
             public int Age;

             public Customer(string name, int amount, int age)
             {
                 this.Name = name;
                 this.Amount = amount;
                 this.Age = age;
             }
         }*/

    }
}
