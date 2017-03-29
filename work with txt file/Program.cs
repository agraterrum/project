﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace work_with_txt_file
{
    class Program
    {
        static void Main(string[] args)
        {
            //Чтение из файла
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\Новый текстовый документ.txt");
            System.Console.WriteLine("{0}", text);
            Console.WriteLine("\nКолличество символов = {0}", text.Length);
            
            
            
            //Подсчет количества слов
            string[] textMass = text.Split(' ');
            Console.WriteLine("Количество слов:" + textMass.Length);
            
            //Процентное соотношение символов
            char[] array = text.ToCharArray();
            int temp = 0;
            foreach (char a in array)
            {
                if (a == 'а')
                temp++;
            }
            int copy = text.Length;
            double procentOfSumbol = (double)temp /copy;
            Console.WriteLine("Колличество симоволов 'a' = {0}%", procentOfSumbol);
            
        }
    }
}
