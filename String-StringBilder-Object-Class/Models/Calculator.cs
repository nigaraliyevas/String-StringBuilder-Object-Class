using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_StringBilder_Object_Class.Models
{
    class Calculator
    {
        public int FirstNum;
        public int SecondNum;
        public void Calculation(int firstNum,int secondNum) {
            Console.WriteLine("Enter first number:");
            firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator sign:");
            string operatorSign=Console.ReadLine();
            int res= operatorSign switch
                {
                    "*" => firstNum * secondNum,
                    "/" => firstNum / secondNum,
                    "+"=> firstNum + secondNum,
                    "-" => firstNum - secondNum,
                };
            Console.WriteLine($"Result is {res}");
        }
    }
}
