using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace src
{
    class Program
    {
        class Smartphone
        {
            public string Model;
            public int Price;
            public int Size;
            public Smartphone(string model, int price, int size)
            {
                Model = model;
                Price = price;
                Size = size;
            }
        }
        static int CompareSmartphones(Smartphone A, Smartphone B)
        {
            int ires;

            ires = 0;
            if (A.Model.Length < B.Model.Length)
                ires = -1;
            if (A.Model.Length > B.Model.Length)
                ires = 1;
            if (A.Model.Length == B.Model.Length)
            {
                if (A.Size < B.Size)
                    ires = -1;
                if (A.Size > B.Size)
                    ires = 1;
            }
            return ires;
        }
        public class GadgetFactory
        {

        }
        static void Main(string[] args)
        {
            List<Smartphone> SmartPhones = new List<Smartphone>();
            Console.Write("Введите размер массива:");
            int N = Convert.ToInt16(Console.ReadLine());
            for (int i=0; i<N; i++)
            {
                Console.Write("Введите модель:");
                string model = Console.ReadLine();
                Console.Write("Введите цену:");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите размер диагонали экрана:");
                int size = Convert.ToInt16(Console.ReadLine());
                SmartPhones.Add(new Smartphone(model, price, size));
            }
            Console.WriteLine("Список смартфонов до сортировки:");
            foreach (Smartphone smartphone in SmartPhones)
                Console.WriteLine($"{smartphone.Model} ; {smartphone.Price} ; {smartphone.Size}");
            SmartPhones.Sort(CompareSmartphones);
            Console.WriteLine("Список смартфонов после сортировки:");
            foreach (Smartphone smartphone in SmartPhones)
                Console.WriteLine($"{smartphone.Model} ; {smartphone.Price} ; {smartphone.Size}");
            Console.ReadKey();
        }
    }
}
