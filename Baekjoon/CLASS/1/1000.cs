using System;

// 문제
// 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
//
// 입력
// 첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)
//
// 출력
// 첫째 줄에 A+B를 출력한다.

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();

            Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
        }
    }
}