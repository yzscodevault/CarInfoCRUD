using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a table “Cars”. Add columns like VIN, Make, Model, Year, Price etc.

//Create a Windows forms app to display records in grid. Perform basic CRUD.

namespace Assignment6._2
{
    interface CarsCRUD
    {
        ICollection<Car> GetCars();//get a record/row from table Car
        void AddRecord(Car ACar);//adding a new record by feeding a new instance of car which has the new info
        void DeleteRecord(Car ACar);//delete a record by feeding an instance of a car
        void UpdateRecord(string VIN, Car ACar);//change the column(s) of a row by specifying VIN #, and the new instance of car which has updated info
        Car FindACar(string vin);//retrieve a record/row from table/class model car, by feeding VIN #
    }
    class CarRecords : CarsCRUD
    {
        CarsEntities carsEntities;
        public CarRecords()
        {
            carsEntities = new CarsEntities();
        }
        public void AddRecord(Car ACar)
        {
            carsEntities.Cars.Add(ACar);
            carsEntities.SaveChanges();
        }

        public void DeleteRecord(Car ACar)
        {
            carsEntities.Cars.Remove(ACar);
            carsEntities.SaveChanges();
        }

        public Car FindACar(string vin)
        {
            var foundCar = carsEntities.Cars.First(v => v.VIN == vin);
            //var foundCar = carsEntities.Cars.Find(vin);
            if (foundCar != null)
            {
                return foundCar;
            }
            else
            {
                return null;
            }
        }

        public ICollection<Car> GetCars()//as data source for data grid in form
        {
            return carsEntities.Cars.ToList();
        }

        public void UpdateRecord(string VIN, Car ACar)
        {
            var cartoupdate = carsEntities.Cars.Find(VIN);
            cartoupdate.Make = ACar.Make;
            cartoupdate.Model = ACar.Model;
            cartoupdate.Year = ACar.Year;
            cartoupdate.Price = ACar.Price;
            carsEntities.SaveChanges();
        }
    }
}
