using System;
using System.Collections.Generic;

namespace ShapeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define a Shape reference
            IShape shape = null;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Enter number for function you would like to open:");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Exit Program");
                string command = Console.ReadLine();
              
                switch (command)
                {
                    case "1":
                        bool close = false;
                        while (!close)
                        {
                            // menu to select a shape
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("Enter number for the shape you would like to select:");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("1. Rectangle");
                            Console.WriteLine("2. Circle");
                            Console.WriteLine("3. Square");
                            Console.WriteLine("4. Trapezoid");
                            Console.WriteLine("5. Close");
                            string type = Console.ReadLine();
                            int c = 0;
                            switch (type)
                            {
                                case "1":
                                    //if rectangle, get length and height
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Enter rectangle length");
                                    Console.WriteLine("----------------------");
                                    double l = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Enter rectangle height");
                                    Console.WriteLine("----------------------");
                                    double h = Double.Parse(Console.ReadLine());
                                    shape = new Rectangle(l, h);
                                    break;

                                case "2":
                                    //if circle, get radius
                                    Console.WriteLine("-------------------");
                                    Console.WriteLine("Enter circle radius");
                                    Console.WriteLine("-------------------");
                                    double r = Double.Parse(Console.ReadLine());
                                    shape = new Circle(r);
                                    break;
                                case "3":
                                    //if square get the sides
                                    Console.WriteLine("-----------------------------");
                                    Console.WriteLine("Enter the square side lengths");
                                    Console.WriteLine("-----------------------------");
                                    double s = double.Parse(Console.ReadLine());
                                    shape = new Square(s);
                                    break;

                                case "4":
                                    //if trapezoid choose what method you would like to solve for
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("Enter number for what you would like to solve for:");
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("1. Area");
                                    Console.WriteLine("2. Perimeter");
                                    c = Convert.ToInt32(Console.ReadLine());
                                    //if solving trapezoid area
                                    if (c == 1)
                                    {                                     
                                        Console.WriteLine("-------------------");
                                        Console.WriteLine("Enter base number 1");
                                        Console.WriteLine("-------------------");
                                        double b1 = double.Parse(Console.ReadLine());
                                        Console.WriteLine("-------------------");
                                        Console.WriteLine("Enter base number 2");
                                        Console.WriteLine("-------------------");
                                        double b2 = double.Parse(Console.ReadLine());
                                        Console.WriteLine("------------");
                                        Console.WriteLine("Enter height");
                                        Console.WriteLine("------------");
                                        double th = double.Parse(Console.ReadLine());
                                        shape = new Trapezoid(b1, b2, 0, 0, th);
                                        Console.WriteLine("---------------------------");
                                        Console.WriteLine($"Area is: {shape.GetArea()}");
                                        break;
                                    }
                                    //if solving trapezoid perimeter
                                    else if (c == 2)
                                    {
                                        Console.WriteLine("-------------------");
                                        Console.WriteLine("Enter base number 1");
                                        Console.WriteLine("-------------------");
                                        double b1 = double.Parse(Console.ReadLine());
                                        Console.WriteLine("-------------------");
                                        Console.WriteLine("Enter base number 2");
                                        Console.WriteLine("-------------------");
                                        double b2 = double.Parse(Console.ReadLine());
                                        Console.WriteLine("-------------------");
                                        Console.WriteLine("Enter side number 1");
                                        Console.WriteLine("-------------------");
                                        double s1 = double.Parse(Console.ReadLine());
                                        Console.WriteLine("-------------------");
                                        Console.WriteLine("Enter side number 2");
                                        Console.WriteLine("-------------------");
                                        double s2 = double.Parse(Console.ReadLine());
                                        Console.WriteLine("-------------------------------------");
                                        shape = new Trapezoid(b1, b2, s1, s2, 0);
                                        Console.WriteLine($"Perimeter is: {shape.GetPerimeter()}");
                                        break;
                                    }
                                    else
                                    {
                                        close = true;
                                        break;
                                    }
                                    //close the calculator program
                                case "5":
                                    close = true;
                                    break;

                                    //if wrong input is selected
                                default:
                                    Console.WriteLine("Wrong Selection. Please try again");
                                    c = 1;
                                    break;
                            }

                            if (c == 0 && !close )
                            {
                                //menu to select what to solve
                                Console.WriteLine("--------------------------------------------------");
                                Console.WriteLine("Enter number for what you would like to solve for:");
                                Console.WriteLine("--------------------------------------------------");
                                Console.WriteLine("1. Area");
                                Console.WriteLine("2. Perimeter");
                                string operation = Console.ReadLine();

                                switch (operation)
                                {
                                    case "1":
                                        //solve area
                                        Console.WriteLine("----------------------------------------------------");
                                        Console.WriteLine($"Area is: {shape.GetArea()}");
                                        break;

                                    case "2":
                                        //solve perimeter
                                        Console.WriteLine("----------------------------------------------------");
                                        Console.WriteLine($"Perimeter is: {shape.GetPerimeter()}");
                                        break;
                                    default:
                                        Console.WriteLine("Wrong Selection. Bye");
                                        break;
                                }
                            }
                            
                            
                        }
                        break;
                        
                        //close program
                    case "2":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("You have put in a wrong command. Please try again");
                        break;
                }
            }
        }

    }
}
