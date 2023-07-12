//Завдання 4

//Реалізуйте шаблон NVI у власній ієрархії успадкування.
namespace ProfessionalEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person jun = new Junior("Vlad", 22);
            Person middle = new Middle("Andrey", 30);
            Person senior = new Senior("Sasha", 50);
            string name;
            int age;
            (name, age) = jun.TempleMethod();
            Console.WriteLine(name + " " + age);

            (name, age) = middle.TempleMethod();
            Console.WriteLine(name + " " + age);

            (name, age) = senior.TempleMethod();
            Console.WriteLine(name + " " + age);
        }
    }
}