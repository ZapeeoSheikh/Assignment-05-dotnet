using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using code_file_05;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car mycar = new Car();
            mycar.Name = "Telsa";
            mycar.Company = "Tesla Motors";
            mycar.Model = 159;
            mycar.Color = "Red";
            mycar.IsAuto = true;
            mycar.EnginePower = 6000;
            mycar.MaxSpeed = 130.50;
            mycar.IsFamilyCar = true;
            mycar.Price = 10000000;


            Car mycar2 = new Car();
            mycar2.Name = "Mazda MX-5";
            mycar2.Company = "Ferrari";
            mycar2.Model = 5;
            mycar2.Color = "Misty Blue";
            mycar2.IsAuto = false;
            mycar2.EnginePower = 10000;
            mycar2.MaxSpeed = 330.50;
            mycar2.IsFamilyCar = false;
            mycar2.Price = 500000000;


            Car mycar3 = new Car();
            mycar3.Name = "Aventador";
            mycar3.Company = "Lamborghini";
            mycar3.Model = 1;
            mycar3.Color = "Green";
            mycar3.IsAuto = false;
            mycar3.EnginePower = 6498;
            mycar3.MaxSpeed = 759.01;
            mycar3.IsFamilyCar = false;
            mycar3.Price = 900000000;

            List<Car> cars = new List<Car>();
            cars.Add(mycar);
            cars.Add(mycar2);
            cars.Add(mycar3);

            foreach (var items in cars)
            {
                Console.WriteLine($"This is {items.Name}, manufactured by {items.Company}. It's model number is {items.Model} and color is {items.Color}.\nIt's engine power is {items.EnginePower} Whereas, Maximum speed is {items.MaxSpeed}kmph.\nYou can buy it for only {items.Price} pkr.\n\n");
            }



            /* Muhammad Rameez 
                Assignment 05
                Date : January 07, 2022
                Course : asp.net by Mentorsh
            */
        }
    }
}