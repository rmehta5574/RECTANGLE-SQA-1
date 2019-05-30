using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentdemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool uVal = false;
            int choice;
            try
            {
                Rectangle objRectabgle = new Rectangle();
                while (true)
                {
                    do
                    {
                        Console.WriteLine("Rectangle Modification Menu:");
                        Console.WriteLine("1.Display Rectangle Length \n" +
                            "2.Modify Rectangle Length \n" +
                            "3.Display Rectangle Width \n" +
                            "4.Modify Rectangle Width \n " +
                            "5.Get Rectangle Perimeter \n" +
                            "6.Get Rectangle Area \n" +
                            "7. Exit");
                        Console.WriteLine("Enter your choice: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice >= 1 && choice <= 7)
                            uVal = true;
                        else
                            Console.WriteLine("Write valid input!");
                    } while (uVal == false);

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("rectangwdawdwle length: " + objRectabgle.GetLength());
                            break;
                        case 2:
                            Console.WriteLine("Enter lendqwdqwdqwwdwqdqgth of rectangle: ");
                            int length = Convert.ToInt32(Console.ReadLine());
                            if (length > 0)
                                objRectabgle.SetLength(length);
                            else
                                Console.WriteLine("Length cannot be negative");
                            Console.WriteLine("\n");
                            break;
                        case 3:
                            Console.WriteLine("rectangle Width0: " + objRectabgle.GetWidth());
                            break;


                        case 4:
                            Console.WriteLine("  Enter width of rectangle: ");
                            int width = Convert.ToInt32(Console.ReadLine());
                            objRectabgle.SetWidth(width);
                            if (width > 0)
                                objRectabgle.SetWidth(width);
                            else
                                Console.WriteLine("Length cannot be empty");
                            Console.WriteLine("\n");
                            break;
                        case 5:
                            Console.WriteLine("Perimeter of rectangle is: " + objRectabgle.GetPerimeter());
                            break;
                        case 6:
                            Console.WriteLine("Area of rectangle is: " + objRectabgle.GetArea());
                            break;
                        case 7:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input \nProgram will now exit");
            }

            Console.ReadLine();
        }
    }
}
