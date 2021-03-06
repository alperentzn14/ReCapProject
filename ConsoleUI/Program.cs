using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());


            foreach (var car in carManager.GetByDailyPrice(10,500000))
            {
                Console.WriteLine(car.DailyPrice);
            }
        }
    }
}
