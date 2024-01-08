using System;
using System.Collections.Generic;

// 문제
//     그래프를 DFS로 탐색한 결과와 BFS로 탐색한 결과를 출력하는 프로그램을 작성하시오. 단, 방문할 수 있는 정점이 여러 개인 경우에는 정점 번호가 작은 것을 먼저 방문하고, 더 이상 방문할 수 있는 점이 없는 경우 종료한다. 정점 번호는 1번부터 N번까지이다.
//
//     입력
//     첫째 줄에 정점의 개수 N(1 ≤ N ≤ 1,000), 간선의 개수 M(1 ≤ M ≤ 10,000), 탐색을 시작할 정점의 번호 V가 주어진다. 다음 M개의 줄에는 간선이 연결하는 두 정점의 번호가 주어진다. 어떤 두 정점 사이에 여러 개의 간선이 있을 수 있다. 입력으로 주어지는 간선은 양방향이다.
//
//     출력
//     첫째 줄에 DFS를 수행한 결과를, 그 다음 줄에는 BFS를 수행한 결과를 출력한다. V부터 방문된 점을 순서대로 출력하면 된다.

namespace baekjoon
{
    class Program
    {
        static int[] input;

        static int N;
        static int M;
        static int V;

        static public int[,] map = new int[1001, 1001];
        static public bool[] visited = new bool[1001];

        static public Queue<int> queue = new Queue<int>();
        static public Stack<int> stack = new Stack<int>();

        static void Reset()
        {
            for (int i = 1; i <= N; i++)
            {
                visited[i] = false;
            }
        }
        static void DFS(int V)
        {
            visited[V] = true;

            Console.Write(V + " ");
            for (int i = 1; i <= N; i++)
            {
                if (map[V, i] == 1 && visited[i] == false)
                {
                    DFS(i);
                }
            }
        }
        static void BFS(int V)
        {
            queue.Enqueue(V);
            visited[V] = true;

            int start = V;
            while (queue.Count != 0)
            {
                start = queue.Dequeue();
                Console.Write(start + " ");
                for (int i = 1; i <= N; i++)
                {
                    if(map[start, i] == 1 && visited[i] == false)
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            N = input[0];
            M = input[1];
            V = input[2];

            for (int i = 0; i < M; i++)
            {
                int[] mArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                map[mArray[0], mArray[1]] = 1;
                map[mArray[1], mArray[0]] = 1;
            }

            Reset();
            DFS(V);
            Console.WriteLine();
            Reset();
            BFS(V);
        }
    }
}