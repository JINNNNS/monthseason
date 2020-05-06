using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            String month = Console.ReadLine();

            switch (month)
            {
                case "12": case "12월":
                case "01": case "1월": case "1":
                case "02": case "2월": case "2":
                    Console.WriteLine("겨울입니다");
                    break;

                case "3":  case "3월": case "03":
                case "4": case "4월": case "04":
                case "5": case "5월": case "05":
                    Console.WriteLine("봄 입니다");
                    break;

                case "6":  case "6월": case "06":
                case "7": case "7월": case "07":
                case "8": case "8월": case "08":
                    Console.WriteLine("여름 입니다");
                    break;

                case "9":  case "9월": case "09":
                case "10": case "10월": 
                case "11": case "11월": 
                    Console.WriteLine("가을 입니다");
                    break;

                default:
                    Console.WriteLine("어느 행성에 살고 계신겁니까?");
                    break;

            }
        }
    }
}
