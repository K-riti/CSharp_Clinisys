// using System;

// namespace OOPs

// {

//     class MotorVehicle

//     {

//         private int wheel, gear;

//         private string fuelType = "";

//         float price, tankCap;




//         public MotorVehicle()

//         {

//             System.Console.WriteLine("This is a template for motor vehicle");

//         }



//         //Encapsulation

//         public void setWheel(int i)

//         {

//             this.wheel = i;

//         }



//         public void setgear(int i)

//         {

//             this.gear = i;

//         }



//         public void setFuelType(string f)

//         {

//             this.fuelType = f;

//         }



//     }



//     class Bike : MotorVehicle

//     {

//         string clour = "";

//         public Bike()

//         {

//             System.Console.WriteLine("This is a bike template");

//             setWheel(2);

//             setgear(4);

//         }



//         public void setcolor(string col)

//         {

//             this.clour = col;

//         }

//     }



//     class Car : MotorVehicle

//     {

//         string clour = "";

//         public Car()

//         {

//             System.Console.WriteLine("This is a car template");

//             setWheel(4);

//             setgear(6);

//         }



//         public void setcolor(string col)

//         {

//             this.clour = col;

//         }



//         //Method Overloading

//         public void setFuelType(string f1, string f2)

//         {

//             System.Console.WriteLine("This car can run on both {0} and {1}", f1, f2);

//         }



//     }



//     class Program

//     {

//         static void Main(string[] args)

//         {

//             Bike b1 = new Bike();

//             b1.setcolor("Silver");

//             b1.setFuelType("Petrol");



//             Car c1 = new Car();

//             c1.setcolor("Blue");

//             c1.setFuelType("Petrol", "Electricity");




//         }

//     }

// }

