using Newtonsoft.Json;
using System.ComponentModel;

/*Human human = new Human("Ted","Smith",23);
//human.Name = "Ted";
Console.WriteLine(human.Age);

human.Age = 35;
Console.WriteLine(human.Age);
human.Age = -35;
Console.WriteLine(human.Age);
string humanName=human.Name;
Console.WriteLine(humanName);*/
/*Console.WriteLine(Operations.Add(4, 5));
Human1 human1 = new Human1();*/
Human2 ted = new Human2("Ted", 35);
string json=JsonConvert.SerializeObject(ted);
Console.WriteLine(json);
/*************************/
Human3 ted3 = new Human3("Ted");
//ted3.name = "Ted";
ted3.Print();
Console.WriteLine(Human3.type);
readonly struct Human4
{
    public readonly string Name { get; }
    public int Age { get; }
    public Human4(string name, int age)
    {
        Name=name;
        Age=age;
    }
}
class Human3
{
    public const string type = "Human3";
    public readonly string name = "Undefined";
    public Human3(string name)
    {
        this.name = name;
    }

    public void Print() => Console.WriteLine($"{type},{name}");
}
class Calculator
{
    public void Add(int a, int b)//Add(int, int)
    {
        int result = a + b;
        Console.WriteLine(result);
    }
    //public int Add(int a, int b)//Add(int, int)
    //{
    //    int result = a + b;
    //    return result;
    //}
    public void Add(int a, int b, int c)
    {
        int result = a + b + c;
        Console.WriteLine(result);
    }
    public void Add(double a, double b, double c)
    {
        double result = a + b + c;
        Console.WriteLine(result);
    }
   public void Increment(ref int val)
    {
        val++;
        Console.WriteLine(val);
    }
    public void Increment(int val)
    {
        val++;
        Console.WriteLine(val);
    }
}
class Human2
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Human2(string name, int age)
    {
        Name=name;
        Age=age;
    }
}
class Human
{
    private string firstName ;
    private string lastName ;
    int age = 1;
    public static int retirementAge = 65;
    public Human(string firstName,string lastName,int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    public static void CheckReirementStatus(Human human)
    {
        if(human.age>=retirementAge) { Console.WriteLine("Ты видел динозавров?"); }
        else { Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - human.Age}"); }
    }
    public int Age//{get;set;}=37;
    {
        set {
            if (value < 1 || value > 120)
                Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
            else
                age = value;
        }
        get { return age; }
    }
    public string Name
    {
        get { return $"{firstName},{lastName}"; }//get=>$"{firstName},{lastName}";
        init { 
            firstName = "Undefined";
            lastName = "Undefined";
        }
    }
}
class Human1
{
    static int retirementAge;
    public static int RetirementAge => retirementAge;
    
    static Human1()
    {
        if (DateTime.Now.Year == 2020)
            retirementAge = 65;
        else
            retirementAge = 67;
    }
   public void Print()
    { Console.WriteLine(retirementAge); }
}
static class Operations
{
    public static int Add(int x, int y) => x + y;
    public static int Substract(int x, int y) => x - y;
    public static int Multiply(int x, int y) => x * y;
}
//required - обязательная инициализация поля {}