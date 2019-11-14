using System;

namespace University
{
   public class Car
    {
        string nameCar;
        int yearOfIssue;
        string fuel;
    

    public Car (string nameCar, int yearOfIssue, string fuel)
    {
        this.nameCar = nameCar;
        this.yearOfIssue = yearOfIssue;
        this.fuel = fuel;
    }


    public override bool Equals(object obj)
    {
        Car car = obj as Car;
        return car.nameCar.Equals(this.nameCar) && car.yearOfIssue.Equals(this.yearOfIssue) && car.fuel == this.fuel;
    }


    public override string ToString()
    {
        return nameCar + " " + yearOfIssue + " " + fuel;
    }

   }
}
