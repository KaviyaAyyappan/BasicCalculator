using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculatorExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1.Addition " + " 2.substraction " + " 3.Multiplication " + " 4.Division ");
            Console.WriteLine("Select the calculation:");
            int calculate = Convert.ToInt32(Console.ReadLine());
            switch (calculate)
            {
                case 1:
                    double add = number1 + number2;
                    Console.WriteLine("The addition value is: " + add);
                    break;
                case 2:
                    double sub = number1 - number2;
                    Console.WriteLine("The substraction value is:" + sub);
                    break;
                case 3:
                    double multiply = number1 * number2;
                    Console.WriteLine("The multiply is:" + multiply);
                    break;
                case 4:
                    double Divi = number1 / number2;
                    Console.WriteLine("The Division is" + Divi);
                    break;
            }
            Console.ReadLine();
            //if (calculate == 1)
            //{   
            //    double add = number1 + number2;
            //    Console.WriteLine("The addition value is: " + add);          
            //}
            //else if (calculate == 2)
            //{   
            //    double sub = number1 - number2;
            //    Console.WriteLine("The substraction value is:" + sub);    
            //}
            //else if(calculate ==3)          
            //{
            //    double multiply = number1 * number2;
            //    Console.WriteLine("The multiply is:" + multiply); 
            //}
            //else
            //{
            //    double Divi = number1 / number2;
            //    Console.WriteLine("The Division is" + Divi);
            //}
            //Console.Read();

        }
    }
}
