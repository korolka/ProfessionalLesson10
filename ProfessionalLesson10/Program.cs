//Завдання 2

//Вивчіть опис шаблону Template method (Шаблонний метод).
//Зверніть увагу на застосування шаблону,
//а також на склад його учасників і зв'язку відносини між ними.
//Напишіть невелику програму мовою C#, що є абстрактною реалізацією даного шаблону.
namespace ProfessionalLesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Bmw();
            bmw.ShowInfAboutCar();

            Car audi = new Audi();
            audi.ShowInfAboutCar();
        }
    }
}