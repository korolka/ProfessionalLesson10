using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalLesson10
{
    abstract class Car
    {
        protected abstract void ModelPresenter();

        protected abstract void Speed();


        public void ShowInfAboutCar()
        {
            ModelPresenter();
            Speed();
        }
    }

    class Bmw : Car
    {
        protected override void ModelPresenter()
        {
            Console.WriteLine("Model : BMW M2");
        }

        protected override void Speed()
        {
            Console.WriteLine("Max speed : 300");
        }
    }

    class Audi : Car 
    {
        protected override void ModelPresenter()
        {
            Console.WriteLine("Model : AUDI RS6");
        }

        protected override void Speed()
        {
            Console.WriteLine("Max speed : 350");
        }
    }

}
