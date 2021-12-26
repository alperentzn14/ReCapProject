using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        //Const Method InMemory Product List
        public InMemoryCarDal()
        {
            //oracle,sql,postgresql,mongoDB...
            _car = new List<Car> {
            new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=105,Description="mercedes-benz",ModelYear="2010"},
     

            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);
            _car.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
        /*public List<Car> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();

        }*/

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
