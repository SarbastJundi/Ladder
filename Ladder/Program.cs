using System;

/*
 * Sarbast Jundi
 * Högskolan i Skövde
 * 
 */

namespace Ladder
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                long h = Int64.Parse(split[0]), v = Int64.Parse(split[1]);
                Console.WriteLine(Math.Ceiling((double)h/Math.Sin((double)v/90 * (Math.PI)/2)));

            }

        }

    }
}