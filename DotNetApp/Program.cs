using DotNetApp.Abstraction;
using DotNetApp.Abstraction.Cars;
using DotNetApp.BasicTopics;
using DotNetApp.Car;
using DotNetApp.Car.Hyundai.Cars;
using DotNetApp.Car.Mahindra.Cars;
using DotNetApp.Car.Maruti;
using DotNetApp.Car.Maruti.Cars;
using DotNetApp.MyAbstraction;
using System.Diagnostics;
using System.Numerics;
//using BookApp;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
class Program

{
   public static void Main()






        //21-05-2026 Class+Home 
        //Interface

        //Clean Method
        //(( //ICar swift = new Swift();
        //CarHelper.ShowCarDetails(swift, "Swift");

        //ICar thar = new Thar();
        //CarHelper.ShowCarDetails(thar, "Thar");

        //ICar creta = new Creta();
        //CarHelper.ShowCarDetails(creta, "Creta");))
    {

        //01-06-2026
        //Array At Class+Home

        int[] arr = new int[5];

        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 4;
        arr[4] = 5;

        foreach (int i in arr)
        {
            Console.WriteLine(i);

        }

        int[] arr1 = [60,70,80];

        foreach (int i in arr1) 
        {

            Console.WriteLine(i);
        
        }

        object[] arr3 = new object[3];

        arr3[0] = 90;
        arr3[1] = 100;
        arr3[2] = "Asim";

        foreach (var i in arr3)
        {

            Console.WriteLine(i);
        }
        


        //23-05-2026 At Class+Home

        //IVehicle v1 = new Swift();
        //v1.Brake();

        //ITyres v2 = new Swift();
        //v2.Brake();
        //Console.WriteLine("=====================\n");



        //IVehicle v3 = new Thar();
        //v3.Brake();

        //ITyres v4 = new Thar();
        //v4.Brake();
        //Console.WriteLine("=====================\n");




        //IVehicle v5 = new Creta();
        //v5.Brake();

        //ITyres v6 = new Creta();
        //v6.Brake();
        //Console.WriteLine("=====================\n");







        //ICar swift = new Swift();
        //swift.Refuel();
        //swift.Start();
        //swift.Drive();
        //swift.Stop();
        //swift.Service();
        //swift.Tyres();
        //swift.HatchBackCar();
        //Console.WriteLine("\n-----------------\n");

        //ICar thar = new Thar();

        //thar.Refuel();
        //thar.Start();
        //thar.Drive();
        //thar.Stop();
        //thar.Service();
        //thar.Tyres();
        //thar.SuvCar();
        //Console.WriteLine("\n-----------------\n");


        //ICar creta = new Creta();
        //creta.Refuel();
        //creta.Start();
        //creta.Drive();
        //creta.Stop();
        //creta.Service();
        //creta.Tyres();
        //creta.SuvCar();


        //18-05-2026 Class+Home
        //Abstract Method

        //19-05-2026 At Class+Home

        //Porche911 brand = new Porche911();
        //brand.Start();
        //brand.Brand();

        //Bmw car1 = new Bmw(1);
        //Bmw car2 = new Bmw(2);

        //Maruti car3 = new Maruti(3);
        //Maruti car4 = new Maruti(4);

        //car1.Start();
        //car2.Start();

        //car3.Start();
        //car4.Start();




        //BmwAbstract bmw = new BmwAbstract();
        //bmw.Start();

        //MarutiAbstract maruti = new MarutiAbstract();
        //maruti .Start();

        //Intheritance parent-child

        //practiceset home 14-5-2026
        //ShopKeeper shopKeeper = new ShopKeeper();
        //ShopName shopkeeper = new ShopKeeper("Asim", "Cashier", 30000);
        //shopkeeper.Show();

        //ShopCleaner shopCleaner = new ShopCleaner();
        //ShopName shopcleaner = new ShopCleaner("Dayaan", "Cleaner", 15000);
        //shopcleaner.Show();



        


        //14-05-2026 class
        //EmployeeInherit[] employees = new EmployeeInherit[5];
        //employees[0] = new EmployeeInherit();
        //employees[1] = new DeveloperInherit();
        //employees[2] = new ManagerInherit();


        //employees[0].GroupData();
        //employees[1].GroupData();
        //employees[2].GroupData();


        //EmployeeInherit e = new DeveloperInherit(101, "Dayaan");
        //e.Show();








        //Casting

        //1.Implicit casting
        //Console.WriteLine("Implicit Casting\n\n");

        //int a1 = 10;
        //long res1 = a1;
        //Console.WriteLine($"Int 10 To long Res1 = {res1} > Implicit Casting\n");

        //int a2 = 20;
        //double res2 = a2;
        //Console.WriteLine($"Int 20 To Double Res2 = {res2} > Implicit Casting\n");

        //int a3 = 30;
        //float res3 = a3;
        //Console.WriteLine($"Int 30 To Float Res3 = {res3} > Implicit Casting\n");

        //float a4 = 3.14f;
        //double res4 = a4;
        //Console.WriteLine($"Float 3.14 To Double Res4 = {res4} > Implicit Casting\n");


        //char a5 = '1';
        //int res5 = (int)a5;
        //Console.WriteLine($"Char '1' To Int Res5 = {a5} > Implicit Casting\n\n");





        //2. Explicit casting
        //Console.WriteLine("Explicit Casting\n\n");

        //double x1 = 9.99;
        //int res6 = (int)x1;
        //Console.WriteLine($"Double 9.99 To Int Res6= {res6} > Explicit Casting\n");

        //float x2 = 3.15f;
        //int res7 = (int)x2;
        //Console.WriteLine($"Float 3.15 To Int Res7= {res7} > Explicit Casting\n");

        //long x3 = 1000000;
        //int res8 = (int)x3;
        //Console.WriteLine($"Long 1000000 To Int Res8= {res8} > Explicit Casting\n");

        //char x4 = '1';
        //int res9 = (int)x4;
        //Console.WriteLine($"Char '1' To Int Res9= {res9} > Explicit Casting\n");

        //int x5 = 66;
        //char res10 = (char)x5;
        //Console.WriteLine($"Int 66 To Char Res9= {res10} >Explicit Casting\n");


        //double x6 = 65.9;
        //float res11 = (float)x6;
        //Console.WriteLine($"Double 65.9 To Float Res11= {res11} > Explicit Casting\n");

        //double x7 = 65.9;
        //char res12 = (char)x7;
        //Console.WriteLine($"Double 65.9 To Char Res12= {res12} > Explicit Casting\n");



        //Data Conversion 
        //1. int.Parse (Only Accepts String)

        //Console.WriteLine("Data Conversion\n\n");
        //string dc1 = "123";
        //int res13 = int.Parse(dc1);
        //Console.WriteLine($"String \"123\" To Int Res13= {res13} > Data Conversion By int.Parse\n");

        //int res14 =  int.Parse("123");
        //Console.WriteLine($"Directly Passing Res14 {res14} > Data Conversion By int.Parse\n");

        //2. convert.Int32 (Anything to Anything)

        //string dc2 = "123";
        //int res15 = Convert.ToInt32(dc2);
        //Console.WriteLine($"String \"123\" To Int Res15 = {res15} > Data Conversion By convert.Int32\n");

        //double dc3 = 9.3;
        //int res16 = Convert.ToInt32(dc3);
        //Console.WriteLine($"Double 9.3 To Int  Res16 = {res16} > Data Conversion By convert.Int32\n");


        //bool dc4 = true;
        //int res17 = Convert.ToInt32(dc4);
        //Console.WriteLine($"Bool True To Int  Res17 = {res17} > Data Conversion By convert.Int32\n");

        //bool dc5 = false;
        //int res18 = Convert.ToInt32(dc5);
        //Console.WriteLine($"Bool false To Int  Res18 = {res18} > Data Conversion By convert.Int32\n");

        //3. convert.ToString (int To String) > Runs Smoothly And Safe On Null

        //int dc6 = 123;
        //string res19 = Convert.ToString(dc6);
        //Console.WriteLine($"Int 123 To String  Res19 = {res19} > Data Conversion By convert.ToString\n");


        //int dc7 = 1;
        //bool res20 = Convert.ToBoolean(dc7);
        //Console.WriteLine($"Int 1 To Bool  Res20 = {res20} > Data Conversion By convert.ToBoolean\n");

        //int dc8 = 0;
        //bool res21 = Convert.ToBoolean(dc8);
        //Console.WriteLine($"Int 0 To Bool  Res21 = {res21} > Data Conversion By convert.ToBoolean\n");


        //4. ToString ( Anything To String) > Gives Error On Null

        //int dc9 = 12;
        //string res22 = dc9.ToString();
        //Console.WriteLine($"Int 12 To String  Res22 = {res22} > Data Conversion By ToString\n");





        //05-05-2026 home - string Extention (Extension Method) 


        //string str = "logic Hub software soLutions";
        //str = str.ToPascalCase();
        //Console.WriteLine($"To Pascal Case:{str}\n"); //LogicHubSoftwareSolutions



        //string str2 = "Logic Hub software SoLutions";
        //str2 = str2.ToCamelCase();
        //Console.WriteLine($"To Camel Case:{str2}"); //logicHubSoftwareSolutions


        //Studnt.cs practice set
        //Using Default Constructor

        //Studnt s1 = new Studnt();


        //Dynamic Method To Return Multiple Values
        //var Obj = Mix.MulRet();
        //Console.WriteLine($"Emp Id:{Obj.id}\n\nEmp Name:{Obj.name}\n\n" +
        //$"Student Roll No:{Obj.roll}\n\nStudent marks:{Obj.marks}\n");


        //Another method to return multiple Values
        //var Get = Mix.MulRet();

        //Console.WriteLine($"Emp Id:{Get.emp.Id}\nEmp Name:{Get.emp.Name}\n" +
        //    $"Student Roll No:{Get.std.Roll}\nStudent Marks:{Get.std.Marks}");


        //tuple+Shortcut at home 01-05

        //var val = new TupleShortCtHome
        //{
        //    Name = "Dayaan",
        //    Id = 101,
        //    Salary = 120000,
        //    Email = "dayaan3@gmail.com"
        //};

        //var val2 = new TupleShortCtHome
        //{
        //    Name = "Asim",
        //    Id = 102,
        //    Salary = 130000,
        //    Email = "asim7@gmail.com"


        //};

        //var gt = val.GetData();
        //var gt2 = val2.GetData();

        //Console.WriteLine($"Name:{gt.name}\n\nId:{gt.id}\n\nSalary:{gt.salary}\n\nEmail:{gt.email}\n\n");
        //Console.WriteLine($"Name:{gt2.name}\n\nId:{gt2.id}\n\nSalary:{gt2.salary}\n\nEmail:{gt2.email}");



        ////out param at home 01-05///

        //OutParam.MulRet(30, 10, out int c, out int d);
        //Console.WriteLine($"a + b = {c}\na - b = {d}");

        //Return through another class at home 01-05

        //ReturnValue v = Cal.Mul(2, 3);
        //Console.WriteLine($"x = {v.Num1}\ny = {v.Num2}\nx + y = {v.Num3}\nx * y = {v.Num4}");

        //30-4-2026 Class
        //ShortcutM shortcut = new()
        // var shortcut = new ShortcutM

        //{
        //    Name = "anees khan",
        //  Email = "anees@gmail.com"
        //};
        //Console.WriteLine(shortcut.Name);
        //Console.WriteLine(shortcut.Email);



        ////Tuple method
        //(int sum, int mul) = TupleM.GetData(1, 4);
        //Console.WriteLine($"{sum},{mul}");


        //MixedPrac s1 = new MixedPrac();
        //s1.Name = "Asim";
        //s1.Age = 19;
        //s1.Gpa = 4.00;
        //s1.ShowInfo();
        //Console.WriteLine($"{s1}\n");

        //MixedPrac s2 = new MixedPrac();
        //s2.ShowInfo();
        //Console.WriteLine($"{s2}\n");

        //MixedPrac s3 = new MixedPrac(22,3.0);
        //s3.ShowInfo();
        //Console.WriteLine($"{s3}\n");


        




        //default method

        //int[] arr = { 500, 300, 400, 500, 600 };
        //string result = DefaultM.Sum("Anees", "anees@gmail.com", 100, 200, 300, 400, 500, 600, 700, 800, 900, 100);
        //Console.WriteLine(result);

        //Manager2 s1 = new Manager2();
        //s1.Name = "Sayhaan";
        //s1.Id = 101;
        //Manager2.SetManager2("Delhi Public School");
        //s1.Showmanager2();

        //static topic
        //manager at tution 27-04-26

        //Manager e1 = new Manager();
        //e1.Name = "Anees";
        //e1.Id = 100;
        //Manager.SetManager("Logic Software Solutions");
        //e1.ShowDetails();


        //25-04-26 at tution

        //NewStdPrac std1 = new NewStdPrac();
        //std1.Age = 20;
        //var getAge = std1.Age;
        //Console.WriteLine($"Age:{getAge}\n");

        //std1.Name = "Dayaan";
        //var getName = std1.Name;
        //Console.WriteLine($"Name:{getName}\n");

        //std1.Division = 12;
        //var getDivision = std1.Division;
        //Console.WriteLine($"Division:{getDivision}th\n");


        //std1.Address = "Srinagar";
        //var getAddress = std1.Address;
        //Console.WriteLine($"Address:{getAddress}\n");

        //std1.RoleNo = 77;
        //var getRollNo = std1.RoleNo;
        //Console.WriteLine($"Roll No:{getRollNo}\n");


        //EncapPracAtHome

        //EncapPrac s1 = new EncapPrac();

        //s1.SetId(101);
        //s1.GetId();
        //Console.WriteLine($"{s1.GetId()}\n");


        //s1.SetName("Dayaan");
        //s1.GetName();
        //Console.WriteLine($"{s1.GetName()}\n");


        //s1.SetAge(21);
        //s1.GetAge();
        //Console.WriteLine($"{s1.GetAge()}\n");


        //set get dotnet method

        //Developer2 dev1 = new Developer2();
        //dev1.Id = 1;
        //int devId = dev1.Id;

        //dev1.Name = "Dayaan";
        //string devName = dev1.Name;

        //dev1.Role = "SDE lvl 1";
        //string devRole = dev1.Role;

        //Console.WriteLine($"Developer ID: {devId}");
        //Console.WriteLine($"Developer Name: {devName}");
        //Console.WriteLine($"Developer Role: {devRole}\n");


        //Tester tes1 = new Tester();

        //tes1.Id = 1;
        //int tesId = tes1.Id;

        //tes1.Name = "Anees";
        //string tesName = tes1.Name;

        //tes1.Role = "Senior Tester";
        //string tesRole =tes1.Role;

        //Console.WriteLine($"Tester ID: {tesId}");
        //Console.WriteLine($"Tester Name: {tesName}");
        //Console.WriteLine($"Tester Role: {tesRole}");















        //EncapPracAtClass


        //Encapsulate emp1 = new Encapsulate();
        //emp1.SetId(101);
        //emp1.GetId();
        //emp1.SetName("As");
        //emp1.GetName();
        //emp1.SetAge(25);
        //emp1.GetAge();
        //emp1.SetSalary(25000);
        //emp1.GetSalary();














        //Yest overload prac

        //OverLoadPrac sum1 = new OverLoadPrac();
        //sum1.Add(2, 3);
        //sum1.Add(5, 2, 4);
        //sum1.Add(3, 3, 3, 3);
        //sum1.Add(6, 7, 5, 6, 7);
        //sum1.Add(1, 4);


        //      Employee emp = new Employee();
        //        emp.SetEmployeeData(101, "Asim", 60000);
        //        emp.ShowEmployeeData();


        //        Student std = new Student();
        //        std.SetStudentData(110, "Dayaan", "Srinagar");
        //        std.ShowStudentData();

        //        Calculator n= new Calculator();
        //        n.Add(10, 20);

        //NewPractice t = new NewPractice();
        //t.Add(20, 5);
        //Console.WriteLine($"x={t.x},y={t.y} res={t.Res}");

        //Subtraction subtraction = new Subtraction();
        //subtraction.Sub(t.x,t.y);

        //Books Book1 = new Books();
        //Books Book2 = new Books();
        //Books book3 = new Books();

        //Console.WriteLine($"Book 1\n");
        //Book1.SetBook("The Hundred Stories", 200, "Mir Dayaan", 8);
        //Book1.Purchased();

        //Console.WriteLine($"Book 2\n");
        //Book2.SetBook("Door To Life", 300, "Asim", 7);
        //Book2.Purchased();

        //Console.WriteLine($"Book 3\n");
        //book3.SetBook("The Magician", 400, "Uzair", 9);
        //book3.Purchased();


        //Student2 s2 = new Student2();
        //s2.ShowStudent();

        //Student2  s3 = new Student2(102,"Dayaan",20);
        //s3.ShowStudent();


        //Customer customer = new Customer();
        //customer.ShowProducts();

        //Customer customer2 = new Customer("Juice",05);

        //Customer customer3 = new Customer();
        //customer3.ChangeProductNumQuan("Oil",09);


        //   Employee2 employee1 = new Employee2(101, "Asim", 77000, "Wed Dev");


        //   Employee2 employee2=employee1;
        //   employee2.Change(100,"Dayaan",99000,"Cyber Security Analyst");



        //Employee2 employee3 = new Employee2(employee1);

        //Employee2 employee4 = new Employee2(true);


        //   employee1.Show();
        //   employee2.Show();
        //   employee3.Show();



        //OVERLOADING
        //THROUGH CONSTRUCTOR

        //Developer dev1 = new Developer(101,"Asim","Sgr","asim@7","123","Dev");
        //dev1.ShowData();


        //Developer dev2 = dev1;
        //dev2.ShowData();

        //Developer dev3 = new Developer(dev1);
        //dev3.ShowData();


        ////THROUGH OVERLOADING

        //Developer dev4 = new Developer();
        //dev4.SetData(102,"Moomin","Kanipora","moomin@12","9908998877","Dr");
        //dev4.ShowData();




        //Developer dev5 = new Developer();
        //dev5.SetData(103,"Haitham","Hyderpora","haitham@333","Scientist");
        //dev5.ShowData();



        //Developer dev6 = new Developer();
        //dev6.SetData("Teacher","23223332");
        //dev6.ShowData();


        //Developer dev7 = new Developer();
        //dev7.SetData("Dayaan","Chralipora","dayaan@33");
        //dev7.ShowData();






        //Developer dev8 = new Developer();
        //dev8.SetData("Teacher","12345");
        //dev8.ShowData();







    }


}