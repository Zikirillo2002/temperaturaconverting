using System;

namespace temperaturaconverting

{

    internal class Program
    {

        static void Main(string[] args)
        {
            double convertnum, temp_;
            bool isnumber1, isnumber2;
            Console.WriteLine("1). Selsiy [ C ]     --->  Kelvin [ K ]");
            Console.WriteLine("2). Selsiy [ C ]     --->  Farangeyt [ F ]");
            Console.WriteLine("3). Kelvin [ K ]     --->  Selsiy [ C ] ");
            Console.WriteLine("4). Kelvin [ K ]     --->  Farangeyt [ F ] ");
            Console.WriteLine("5). Farangeyt [ F ]  --->  Selsiy [ C ] ");
            Console.WriteLine("6). Farangeyt [ F ]  --->  Kelvin [ K ] ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Kerakli konvertatsiya turini tartib raqamini kiriting : ");
            isnumber1 = double.TryParse(Console.ReadLine(), out convertnum);
            Console.WriteLine();
            while (!isnumber1 || (convertnum > 6 || convertnum < 1))
            {
                Console.WriteLine("Tartib raqamini xato kiritdingiz !!! ");
                Console.WriteLine("Iltimos boshqa raqamni kiriting !!! ");
                Console.WriteLine();
                Console.Write(" Kerakli konvertatsiya turini tartib raqamini kiriting : ");
                isnumber1 = double.TryParse(Console.ReadLine(), out convertnum);
                Console.WriteLine();
            }
            Console.Write(" Haroratni kiriting : ");
            isnumber1 = double.TryParse(Console.ReadLine(), out temp_);
            Console.WriteLine();
            while (!isnumber1)
            {
                Console.WriteLine("Siz noto'g'ri son kiritdingiz !!! ");
                Console.WriteLine("Tekshirib boshqa son kiriting !!! ");
                Console.WriteLine();
                Console.Write(" Haroratni kiriting : ");
                isnumber1 = double.TryParse(Console.ReadLine(), out temp_);
                Console.WriteLine();
            }
            switch(convertnum)
            {
                case 1:
                    Console.WriteLine($" Natija : {temp_} ( C ) --> {temp_ + 273} ( K )"); break;
                case 2:
                    Console.WriteLine($" Natija : {temp_} ( C ) --> {temp_ * 1.8 + 32} ( F )"); break;
                case 3:
                    Console.WriteLine($" Natija : {temp_} ( K ) --> {temp_ - 273} ( C )"); break;
                case 4:
                    Console.WriteLine($" Natija : {temp_} ( K ) --> {(temp_ - 273) * 1.8 + 32} ( F )"); break;
                case 5:
                    Console.WriteLine($" Natija : {temp_} ( F ) --> {(temp_ - 32) / 1.8} ( C )"); break;
                case 6:
                    Console.WriteLine($" Natija : {temp_} ( F ) --> {(temp_ - 32) / 1.8 + 273} ( K )"); break;
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();

            Main(args);
        }

    }

}