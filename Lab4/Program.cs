using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector first_vector = new Vector(2, 3, 4);
            Vector second_vector = new Vector(6, 3, 1);
      
            Console.WriteLine("Первый вектор: " + first_vector.WriteVector() + "\nВторой вектор: " + second_vector.WriteVector());

            //%-Скалярное произведение,*-Вектороное произведение
            int c = (first_vector + first_vector) % second_vector;
            Console.WriteLine("Сложение и скалярное произведение векторов:" + c);

            Vector d = first_vector * second_vector;

            Console.WriteLine("Вектороное произведение векторов:" + d.WriteVector());

            Console.WriteLine("Проверка на коллинеарность векторов:");
            Console.WriteLine( first_vector | second_vector);
             
            Console.ReadLine();
        }
    }
}
