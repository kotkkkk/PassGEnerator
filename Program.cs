using System;

namespace PassGenerator
{
    class PassGet
    {
        public string GetPass(int col)
        {
            int[] PassArr = new int[col];
            Random rnd = new Random();
            string Passwd = "";
            for (int i = 0; i < PassArr.Length; i++)
            {
                PassArr[i] = rnd.Next(50, 100);
                Passwd += (char)PassArr[i];
            }
            return Passwd;
        }


    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("какой длины вы хотите пароль?");
            PassGet objPass = new PassGet();
            int MaxPass = Convert.ToInt32(Console.ReadLine());
            string Passwd = objPass.GetPass(MaxPass);
            Console.Clear();
            Console.WriteLine("пароль: {0}", Passwd);
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;


        }
    }
}