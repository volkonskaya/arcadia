using System;

namespace Singleton
{
    class Single
    {
        private static Single instance;

        private Single() //constructor
        { }

        public static Single GetInstance()
        {
            if (instance == null)
                instance = new Single();
            return instance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Single s1 = Single.GetInstance();
            Single s2 = Single.GetInstance();

            if (s1.GetHashCode() == s2.GetHashCode())
            {
                Console.WriteLine("HashCode of s1 = HashCode of s2");
            }
            else
            {
                Console.WriteLine("HashCode of s1 != HashCode of s2");
            }
        }
    }
}
