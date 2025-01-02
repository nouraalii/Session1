namespace Session1Demo
{
    //class
    //struct
    //interface
    //enum
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            //struct:Value types:stack

            //Employee
            //Id, Name,Salary

            //point
            //Point P01;
            //Declare for object from type point
            //P01:Object
            //Allocate UnInitialized 8 bytes at stack (X,Y)

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01.X=12;
            //P01.Y=12;

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);


            //P01 = new Point(1, 2);
            //////new : used for select the constructor
            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);

            ////Console.WriteLine(P01);//Session1Demo.Point

            //P01.PrintPoint();

            //Console.WriteLine(P01.ToString); 
            #endregion


            #region OOP Overview
            //OOP : object oriented programming 
            //programming paradigm
            //OOP : the paradigm is used for build any business

            //class:Blueprint of the object
            //object:specific instance of the class

            //4 pillars
            //===================
            //1.Encapsulation
            //2.Inheritance
            //3.Polymorphism
            //4.Abstraction 
            #endregion


            #region Encapsulation
            //1.Encapsulation
            //class or struct 
            //seperate the data (Attributes) definition fro its use
            //[Setter Getter Method-Properties]

            //Employee
            //Id , Name , Salary


            //1.End user access data itself
            //2.No Data Validation
            //3.No Read only filed


            //Apply Encapsulation
            //1.Make all data(Attributes) private
            //2.Access data through:
            //2.1 Setter Getter Method
            //2.2 Properties

            //Employee E01 = new Employee(1,"Ahmed",-12000);
            //Console.WriteLine(E01);

            ////Id:Read Only Attributes

            //E01.getId();

            //E01.id = 1;
            //E01.name= "Ahmed";
            //E01.salary = 12000;

            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);

            //E01.SetId(1);
            //E01.setName("Ahmed");
            //E01.setSalary(12000);

            //Console.WriteLine(E01.getId());
            //Console.WriteLine(E01.getName());
            //Console.WriteLine(E01.getSalary());

            //Console.WriteLine(E01);

            //Employee E01 = new Employee();
            //E01.Id = 12;
            //E01.Name = "Noura Ali";
            //E01.Salary = 12000;
            //E01.Address = "Cairo";

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);
            //Console.WriteLine(E01.Address); 
            #endregion


            #region Indexer
            //Indexer:special property
            //       1.named this

            ////PhoneBook:
            //PhoneBook phoneBook = new PhoneBook(3);
            //phoneBook.AddPerson("Ahmed", 111, 0);
            //phoneBook.AddPerson("Ali", 222, 1);
            //phoneBook.AddPerson("Omar", 333, 2);

            ////Console.WriteLine(phoneBook.getNumber("Ahmed"));

            ////phoneBook.UpdateNumber("Ahmed",999);

            ////Console.WriteLine(phoneBook.getNumber("Ahmed"));

            //Console.WriteLine(phoneBook["Ahmed"]);//long
            //phoneBook["Ahmed"] = 11111;//long

            //Console.WriteLine(phoneBook.getNumber("Ahmed"));

            //Console.WriteLine(phoneBook[1111]); 
            #endregion


            //class : Refernece type : Heap

            //Car:Id Model Speed

            Car C01;
            //Declare For Reference (Pointer ) from type car
            //C01 : can refer to object from type car or any class inherited from car
            //C01 : refer to null 
            //Console.WriteLine(C01);

            //8 Bytes will be allocated at stack for the refernce "C01"
            //0 Bytes will be allocated at Heap

            //C01 = new Car(1);
            //C01 = new Car(1,200);
            C01 = new Car(1,200,"XYZ");
            //new
            //1.Allocate the number of required bytes at the heap for the object
            //2.Initialized the allocated bytes with the default value of the datatypes
            //3.call user-defined constructor if exists
            //4.Assign the object to the reference

            //Console.WriteLine(C01.Id);
            //Console.WriteLine(C01.Speed);
            //Console.WriteLine(C01.Model);

            Console.WriteLine(C01);//Session1Demo
        }
    }
}
