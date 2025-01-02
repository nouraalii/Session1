using System.Reflection.Emit;

namespace Assignment
{
    internal class Program
    {

        #region Part1
        //Part1
        #region Question1
        //static double CalcDistance(Point p1, Point p2)
        //{
        //    double XDef = p2.X - p1.X;
        //    double YDef = p2.Y - p1.Y;
        //    return Math.Sqrt(XDef * XDef + YDef * YDef);
        //} 
        #endregion


        #region Question2
        //static Person FindOldestPerson(Person[] persons)
        //{
        //    Person oldest = persons[0];
        //    for (int i = 1; i < persons.Length; i++)
        //    {
        //        if (persons[i].Age > oldest.Age)
        //        {
        //            oldest = persons[i];
        //        }
        //    }
        //    return oldest;
        //} 
        #endregion
        #endregion

        #region Question 4 part 2
        static int BoxingUnboxingCount = 0;
        static int CompareEmployeesByHireDate(Employee e1, Employee e2)
        {
            BoxingUnboxingCount++;
            return e1.HireDate.ToDateTime().CompareTo(e2.HireDate.ToDateTime());
        }
        #endregion

        static void Main(string[] args)
        {
            #region Part1
            //Part 1
            #region Question1
            //Console.WriteLine("Enter Point1");
            //Console.WriteLine("Enter X1");
            //double X1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Y1");
            //double Y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Point2");
            //Console.WriteLine("Enter X2");
            //double X2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Y2");
            //double Y2 = double.Parse(Console.ReadLine());


            //Point point1 = new Point { X = X1 , Y = Y1 };
            //Point point2 = new Point { X = X2 , Y = Y2 };


            //double distance = CalcDistance(point1, point2);
            //Console.WriteLine(distance); 
            #endregion


            #region Question2
            //Person[] persons = new Person[3];

            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"Enter the data of the person{i+1}");
            //    Console.WriteLine("Enter Name");
            //    persons[i].Name=Console.ReadLine();

            //    Console.WriteLine("Enter Age");
            //    persons[i].Age=int.Parse(Console.ReadLine());
            //}

            //Person oldest = FindOldestPerson(persons);

            //Console.WriteLine($"The oldest person is {oldest.Name}, aged {oldest.Age}."); 
            #endregion
            #endregion

            #region Part2
            //Part2
            #region Question1
            //Console.WriteLine("Enter Employee Details:");

            //Console.Write("Enter ID: ");
            //int id = int.Parse(Console.ReadLine());

            //Console.Write("Enter Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter Gender (M/F): ");
            //string gender = Console.ReadLine();

            //Console.Write("Enter Security Privilege (Guest, Developer, Secretary, DBA): ");
            //string securityInput = Console.ReadLine();
            //SecurityLevel Level = Enum.Parse<SecurityLevel>(securityInput, true);

            //Console.Write("Enter Salary: ");
            //double salary = double.Parse(Console.ReadLine());

            //Console.Write("Enter Hire Date (YYYY-MM-DD): ");
            //string[] hireDateParts = Console.ReadLine().Split('-');
            //Hiring_Date hireDate = new Hiring_Date(
            //    int.Parse(hireDateParts[2]), 
            //    int.Parse(hireDateParts[1]), 
            //    int.Parse(hireDateParts[0]) 
            //);


            //Employee emp = new Employee(id, name, Level, salary, hireDate, gender);

            //Console.WriteLine($"\nEmployee Details:\n{emp}");
            #endregion

            #region Question3 and 4
            //Employee[] EmpArr = new Employee[]
            //{
            //    new Employee(1, "Noura", SecurityLevel.DBA, 5000, new Hiring_Date(1, 5, 2024), "F"),
            //    new Employee(2, "Ali", SecurityLevel.Guest, 3000, new Hiring_Date(12, 7, 2023), "M"),
            //    new Employee(3, "Ahmed", SecurityLevel.Developer, 7000, new Hiring_Date(25, 12, 2022), "M")
            //};

            //Console.WriteLine("Before Sorting:");
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(EmpArr[i]);
            //}

            //Array.Sort(EmpArr, CompareEmployeesByHireDate);

            //Console.WriteLine("After Sorting:");
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(EmpArr[i]);
            //}

            //Console.WriteLine($"Boxing and Unboxing occurred {BoxingUnboxingCount} times during sorting.");
            #endregion 
            #endregion



        }
    }
}
