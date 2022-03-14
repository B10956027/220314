using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentNo = { 1, 2, 3, 4, 5 };
            string[] studentName = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] computerScore = { 80, 65, 100, 98, 83 };
            int[] programScore = { 75, 67, 93, 25, 82 };
            int[] animationScore = { 60, 62, 91, 50, 87 };

            while (true)
            {
                Console.WriteLine("請輸入座號(1-5)");
                var input = Console.ReadLine();
                int inputStudentNo = int.Parse(input);
                int arrayIndex = Array.IndexOf(studentNo,inputStudentNo);
                if (arrayIndex > -1) {
                    Console.WriteLine("姓名:" + studentName[arrayIndex]);
                    Console.WriteLine("電腦概論:" + computerScore[arrayIndex]);
                    Console.WriteLine("程式設計:" + programScore[arrayIndex]);
                    Console.WriteLine("動畫設計:" + animationScore[arrayIndex]);
                }
                else
                {
                    Console.WriteLine("沒有這個座號");
                }
                    
            }

        }
    }
}
