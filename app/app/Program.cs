using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("██████╗░███╗░░░███╗██╗  ░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░████████╗░█████╗░██████╗░\r\n██╔══██╗████╗░████║██║  ██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗\r\n██████╦╝██╔████╔██║██║  ██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║░░░██║░░░██║░░██║██████╔╝\r\n██╔══██╗██║╚██╔╝██║██║  ██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║░░░██║░░░██║░░██║██╔══██╗\r\n██████╦╝██║░╚═╝░██║██║  ╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║\r\n╚═════╝░╚═╝░░░░░╚═╝╚═╝  ░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝\r\n");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your weight (kg): ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your height (cm): ");
            int height = Convert.ToInt32(Console.ReadLine());
            decimal usheight = Convert.ToDecimal(height);
            usheight = usheight / 100;

            decimal bmi = weight / (usheight * usheight);
            bmi = Math.Round(bmi, 1);
            Console.Write($"\r\n\nSo {name} your body mass index is: {bmi} \r\n");
            Console.Write("Here is the table of BMI quantities: \r\nBMI less than 16.0: Severe Thinness\r\nBMI 16.0 - 16.9: Moderate Thinness\r\nBMI 17.0 - 18.4: Mild Thinness\r\nBMI 18.5 - 24.9: Normal Weight\r\nBMI 25.0 - 29.9: Overweight\r\nBMI 30.0 - 34.9: Obesity Class I\r\nBMI 35.0 - 39.9: Obesity Class II\r\nBMI 40.0 and above: Obesity Class III (Morbid Obesity)\r\n");
            float usbmi = (float)bmi;

            if (usbmi < 16)
            {
                Console.Write($"Your BMI is: Severe Thinness ({usbmi})\r\n");
            }
            else if (usbmi >= 16 && usbmi < 17)
            {
                Console.Write($"Your BMI is: Moderate Thinness ({usbmi})\r\n");
            }
            else if (usbmi >= 17 && usbmi < 18.5)
            {
                Console.Write($"Your BMI is: Mild Thinness ({usbmi})\r\n");
            }
            else if (usbmi >= 18.5 && usbmi < 25)
            {
                Console.Write($"Your BMI is: Normal Weight ({usbmi})\r\n");
            }
            else if (usbmi >= 25 && usbmi < 30)
            {
                Console.Write($"Your BMI is: Overweight ({usbmi})\r\n");
            }
            else if (usbmi >= 30 && usbmi < 35)
            {
                Console.Write($"Your BMI is: Obesity Class I ({usbmi})\r\n");
            }
            else if (usbmi >= 35 && usbmi < 40)
            {
                Console.Write($"Your BMI is: Obesity Class II ({usbmi})\r\n");
            }
            else if (usbmi >= 40)
            {
                Console.Write($"Your BMI is: Obesity Class III ({usbmi})\r\n");
            }
        }
    }
}
