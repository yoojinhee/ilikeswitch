using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilikeswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("학년 입력 : ");
            int level = int.Parse(Console.ReadLine());
            int re=0;
            switch (level)
            {
                case 1:re = 12;break;
                case 2:re = 18;break;
                case 3:re = 10;break;
                case 4:re = 18;break;
            }
            Console.WriteLine("수강해야하는 전공 학점: " + re + "학점");
        }
    }
}
