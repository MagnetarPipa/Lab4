using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Vector
    {
        private int _x;
        private int _y;
        private int _z;

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public int Z { get => _z; set => _z = value; }

        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
       
        public static Vector operator +(Vector first, Vector second)
        {
            return new Vector(first.X + second.X, first.Y + second.Y, first.Z + second.Z);
        }
        public static int operator %(Vector first, Vector second)
        {
            int X2 = first.X * second.X;
            int Y2 = first.Y * second.Y;
            int Z2 = first.Z * second.Z;

            return X2 + Y2 + Z2;
        }
        public static Vector operator *(Vector first, Vector second)
        {
            int X2 = (first.Y * second.Z) - (first.Z * second.Y);
            int Y2 = (first.Z * second.X) - (first.X * second.Z);
            int Z2 = (first.X * second.Y) - (first.Y * second.X);

            return new Vector(X2, Y2, Z2);
        }
        //Перезагружать оператор || нельзя,ссылка на источник в Read.Me
        public static string operator |(Vector first, Vector second)
        {

            int X2 = first.X / second.X;
            int Y2 = first.Y / second.Y;
            int Z2 = first.Z / second.Z;

            if (X2 == Y2 && Y2 == Z2 && X2 == Z2)
            {
                return "Коллиниарены";
            }
            else
            {
                return "Не коллиниарены";
            }

        }
        public string WriteVector()
        {
            return $"Vector({_x},{_y},{_z})";
        }

        //public override string ToString()
        //{
        //    return $"Vector({_x},{_y},{_z})";
        //}
    }
}
