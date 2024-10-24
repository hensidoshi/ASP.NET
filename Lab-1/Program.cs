//using System;

//class Candidate
//{
//    int ID;
//    String Name;
//    int Age;
//    double Weight;
//    double Height;

//    void GetCandidateDetails()
//    {
//        Console.WriteLine("Enter Candidate Details:");
//        Console.Write("ID: ");
//        ID = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Name: ");
//        Name = Console.ReadLine();
//        Console.Write("Age: ");
//        Age = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Weight (kg): ");
//        Weight = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Height (m): ");
//        Height = Convert.ToDouble(Console.ReadLine());
//    }
//    public void DisplayCandidateDetails()
//    {
//        Console.WriteLine("\nCandidate Details:");
//        Console.WriteLine("ID: " + ID);
//        Console.WriteLine("Name: " + Name);
//        Console.WriteLine("Age: " + Age);
//        Console.WriteLine("Weight: " + Weight + " kg");
//        Console.WriteLine("Height: " + Height + " m");
//    }
//    public static void Main(String[] args)
//    {
//        Candidate candidate = new Candidate();
//        candidate.GetCandidateDetails();
//        candidate.DisplayCandidateDetails();
//    }
//}

//using System;

//class Staff
//{
//     string Name;
//     string Department;
//     string Designation;
//     int Experience;
//     double Salary;

//    public void AcceptDetails()
//    {
//        Console.WriteLine("Enter Staff Details:");
//        Console.Write("Name: ");
//        Name = Console.ReadLine();
//        Console.Write("Department: ");
//        Department = Console.ReadLine();
//        Console.Write("Designation: ");
//        Designation = Console.ReadLine();
//        Console.Write("Experience (years): ");
//        Experience = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Salary: ");
//        Salary = Convert.ToDouble(Console.ReadLine());
//    }

//    public void DisplayDetails()
//    {
//        Console.WriteLine("\nStaff Details:");
//        Console.WriteLine("Name: " + Name);
//        Console.WriteLine("Department: " + Department);
//        Console.WriteLine("Designation: " + Designation);
//        Console.WriteLine("Experience: " + Experience + " years");
//        Console.WriteLine("Salary: " + Salary);
//    }

//    // Method to check if the staff member is HOD (Head of Department)
//    public bool IsHOD()
//    {
//        return Designation.ToLower() == "hod";
//    }
//    public static void Main()
//    {
//        Staff[] staffMembers = new Staff[5];

//        for (int i = 0; i < 5; i++)
//        {
//            staffMembers[i] = new Staff();
//            staffMembers[i].AcceptDetails();
//        }

//        Console.WriteLine("\nStaff who are HOD (Head of Department):");
//        foreach (var staff in staffMembers)
//        {
//            if (staff.IsHOD())
//            {
//                Console.WriteLine("Name: " + staff.Name);
//                Console.WriteLine("Salary: " + staff.Salary);
//                Console.WriteLine();
//            }
//        }
//    }
//}

//using System;

//class Bank_Account
//{
//    int Account_no;
//    String Email;
//    String Username;
//    String Account_type;
//    double Account_Balance;

//    void GetBankAccountDetails()
//    {
//        Console.WriteLine("Enter Account Details:");
//        Console.Write("Account Number: ");
//        Account_no = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Email: ");
//        Email = Console.ReadLine();
//        Console.Write("User Name: ");
//        Username = Console.ReadLine();
//        Console.Write("Account Type: ");
//        Account_type = Console.ReadLine();
//        Console.Write("Account Balance: ");
//        Account_Balance = Convert.ToDouble(Console.ReadLine());
//    }

//    void DisplayDetails()
//    {
//        Console.WriteLine("\nAccount Details:");
//        Console.WriteLine("Account Number: " + Account_no);
//        Console.WriteLine("Email: " + Email);
//        Console.WriteLine("User Name: " + Username);
//        Console.WriteLine("Account Type: " + Account_type);
//        Console.WriteLine("Account Balance: " + Account_Balance);
//    }

//    public static void Main(String[] args)
//    {
//        Bank_Account account = new Bank_Account();
//        account.GetBankAccountDetails();
//        account.DisplayDetails();

//    }
//}

//using System;

//class Student
//{
//     int Enrollment_No;
//     string Student_Name;
//     int Semester;
//     double CPI;
//     double SPI;

//    public Student(int Enrollment_No, string Student_Name, int Semester, double CPI, double SPI)
//    {
//        this.Enrollment_No = Enrollment_No;
//        this.Student_Name = Student_Name;
//        this.Semester = Semester;
//        this.CPI = CPI;
//        this.SPI = SPI;
//    }

//    void GetStudentDetails()
//    {
//        Console.WriteLine("Enter Student Details:");
//        Console.Write("Enrollment Number: ");
//        Enrollment_No = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Student Name: ");
//        Student_Name = Console.ReadLine();
//        Console.Write("Semester: ");
//        Semester = Convert.ToInt32(Console.ReadLine());
//        Console.Write("CPI: ");
//        CPI = Convert.ToDouble(Console.ReadLine());
//        Console.Write("SPI: ");
//        SPI = Convert.ToDouble(Console.ReadLine());
//    }

//    void DisplayStudentDetails()
//    {
//        Console.WriteLine("Student Details:");
//        Console.WriteLine("Enrollment No: " + Enrollment_No);
//        Console.WriteLine("Student Name: " + Student_Name);
//        Console.WriteLine("Semester: " + Semester);
//        Console.WriteLine("CPI: " + CPI);
//        Console.WriteLine("SPI: " + SPI);
//    }

//    public static void Main()
//    {
//        Student student = new Student(0, "", 0, 0.0, 0.0);
//        student.GetStudentDetails();
//        student.DisplayStudentDetails();
//    }
//}

//using System;

//class Rectangle
//{
//     double length;
//     double width;
//     double area;

//    public Rectangle(double length, double width)
//    {
//        this.length = length;
//        this.width = width;
//    }

//    public void CalculateArea()
//    {
//        area = length * width;
//    }
//    void GetDetails()
//    {
//        Console.Write("Length :");
//        length=Convert.ToDouble(Console.ReadLine());
//        Console.Write("Width :");
//        width = Convert.ToDouble(Console.ReadLine());
//    }
//     void DisplayDetails()
//    {
//        Console.WriteLine("\nRectangle Details:");
//        Console.WriteLine("Length: " + length);
//        Console.WriteLine("Width: " + width);
//        Console.WriteLine("Area: " + area);
//    }

//    public static void Main()
//    {
//        Rectangle rect = new Rectangle(0, 0);
//        rect.GetDetails();
//        rect.CalculateArea();
//        rect.DisplayDetails();
//    }
//}

//using System;

//class Account_Details
//{
//    protected string Account_No;
//    protected string Account_Type;
//    protected double Balance;

//    public Account_Details(string accountNo, string accountType, double balance)
//    {
//        Account_No = accountNo;
//        Account_Type = accountType;
//        Balance = balance;
//    }

//    public void DisplayAccountDetails()
//    {
//        Console.WriteLine("\nAccount Details:");
//        Console.WriteLine("Account Number: " + Account_No);
//        Console.WriteLine("Account Type: " + Account_Type);
//        Console.WriteLine("Balance: " + Balance);
//    }
//}

//class Interest : Account_Details
//{
//    public Interest(string accountNo, string accountType, double balance) : base(accountNo, accountType, balance)
//    {

//    }

//    public void CalculateAndDisplayInterest()
//    {
//        double interestRate = 0.05;
//        double totalInterest = Balance * interestRate;
//        Console.WriteLine("\nInterest Calculation:");
//        Console.WriteLine("Balance: " + Balance);
//        Console.WriteLine("Interest Rate: " + (interestRate * 100) + "%");
//        Console.WriteLine("Total Interest: " + totalInterest);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Interest account = new Interest("ACC123456", "Savings", 10000.0);
//        account.DisplayAccountDetails();
//        account.CalculateAndDisplayInterest();
//    }
//}

//using System;
//
//public class Prorgram
//{
//    public static void Main()
//    {
//        Salary salary = new Salary();
//        salary.Display();
//    }
//}
//class Salary
//{
//    double Basic, TA, DA, HRA, GrossSalary;
//    public Salary()
//    {
//        DA = 3000;
//        HRA = 5000;
//        Console.WriteLine("Please enter basic salary : ");
//        this.Basic = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Please enter TA : ");
//        this.TA = Convert.ToDouble(Console.ReadLine());
//        GrossSalary = Basic + TA + HRA + DA;
//    }
//    public void Display()
//    {
//        Console.WriteLine("\nBasic salary : " + Basic);
//        Console.WriteLine("Dearness allowence : " + DA);
//        Console.WriteLine("Housing rent allowence : " + HRA);
//        Console.WriteLine("Travelling allowence : " + TA);
//        Console.WriteLine("Gross Salary : " + GrossSalary);
//    }
//}

//using System;
//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Distance 1 : ");
//        double dist1 = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Distance 2 : ");
//        double dist2 = Convert.ToDouble(Console.ReadLine());
//        Distance d = new Distance(dist1, dist2);
//        d.Sum();
//        d.Display();
//    }
//}
//public class Distance
//{
//    double dist1, dist2, dist3;
//    public Distance(double dist1, double dist2)
//    {
//        this.dist1 = dist1;
//        this.dist2 = dist2;
//    }
//    public void Sum()
//    {
//        this.dist3 = this.dist1 + this.dist2;
//    }
//    public void Display()
//    {
//        Console.WriteLine("Answer : {0}", this.dist3);
//    }
//}

//using System;
//class Furniture
//{
//    String Material;
//    Double Price;
//    public void GetData()
//    {
//        Console.Write("Enter Material : ");
//        Material = Console.ReadLine();
//        Console.Write("Enter Price : ");
//        Price = Convert.ToDouble(Console.ReadLine());
//    }
//    public void ShowData()
//    {
//        Console.WriteLine("Material : " + Material);
//        Console.WriteLine("Price : " + Price);
//    }
//}
//class Table : Furniture
//{
//    int Height, Surface_Area;
//    public void GetData()
//    {
//        base.GetData();
//        Console.Write("Enter height: ");
//        Height = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Enter surface area: "); Surface_Area = Convert.ToInt32(Console.ReadLine());
//    }
//    public void ShowData()
//    {
//        base.ShowData();
//        Console.WriteLine("Height : " + Height);
//        Console.WriteLine("Surface Area : " + Surface_Area);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Table objTable = new Table();
//        objTable.GetData();
//        objTable.ShowData();
//    }
//}

using System;
interface Gross
{
    public Double Gross_Salary();
}
class Employee
{
    public string Name;
    public double Basic_Salary;
    public void Basic_Sal()
    {
        Console.Write("Name: ");
        this.Name = Console.ReadLine();
        Console.Write("Salary: ");
        this.Basic_Salary = Convert.ToDouble(Console.ReadLine());
    }
}
class Salary : Employee, Gross
{
    double HRA, TA, DA;
    public Salary()
    {
        Basic_Sal();
        Console.Write("TA: ");
        TA = Convert.ToDouble(Console.ReadLine());
        Console.Write("DA: ");
        DA = Convert.ToDouble(Console.ReadLine());
        Console.Write("HRA: ");
        HRA = Convert.ToDouble(Console.ReadLine());
    }
    public Double Gross_Salary()
    {
        return (Basic_Salary + HRA + TA + DA);
    }
    public void Display_Salary()
    {
        Console.WriteLine("Name: {0}, Salary : {1}", Name, Gross_Salary());
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Salary s = new Salary();
        s.Display_Salary();
    }
}
