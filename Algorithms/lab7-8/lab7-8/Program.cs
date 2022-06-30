using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
	class Program
	{
		static string[] cities = { "Київ", "Житомир", "Біла Церква", "Прилуки", "Новоград-Волинський",
			"Рівне", "Луцьк", "Бердичів", "Вінниця", "Хмельницький", "Тернопіль", "Шепетівка", "Умань",
			"Черкаси", "Кременчуг", "Полтава", "Харків", "Суми", "Миргород" };

		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
			int[,] graph =
			{
				{0,135,78,128,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
				{0,0,0,0,80,0,0,38,0,0,0,115,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,0,0,0,0,0,0,115,146,0,181,0,0,0 },
				{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,175,109 },
				{0,0,0,0,0,100,0,0,0,0,0,0,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,68,0,0,0,0,0,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,0,0,73,0,0,0,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,0,0,0,110,0,0,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,0,0,0,0,104,0,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,0,0,0,0,0,0,0,0,105,0,0,0,0 },
				{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,130,0,0 },
				{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
				{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 }
			};
			int distance = 0;
			string beginning = "";
			int j = 0;
			bool[] visitedDFS = new bool[graph.GetLength(0)];
			bool[] visitedBFS = new bool[graph.GetLength(0)];
			Console.WriteLine("DFS");
			DFS(j, graph, visitedDFS, distance, beginning);
			Console.WriteLine("\n");
			Console.WriteLine("BFS");
			BFS(j, graph, visitedBFS);
			Console.ReadKey();
		}
		static void DFS(int j, int[,] graph, bool[] visited, int distance = 0, string beginning = "")
		{
			if (beginning == "")
				beginning = cities[j];
			visited[j] = true;
			for (int i = 0; i < graph.GetLength(0); i++)
			{
				if (graph[j, i] != 0 && visited[i] != true)
				{
					int finaldistance = distance + graph[j, i];
					Console.WriteLine(beginning + " --> " + cities[i] + ": " + finaldistance + " кілометрів");
					DFS(i, graph, visited, finaldistance, beginning);
				}
			}
		}
		static void BFS(int j, int[,] graph, bool[] visited)
		{
			int[] distance = new int[graph.GetLength(0)];
			string beginning = cities[j];
			Queue<int> q = new Queue<int>();
			visited[j] = true;
			q.Enqueue(j);
			while (q.Count != 0)
			{
				j = q.Dequeue();
				for (int i = 0; i < graph.GetLength(0); i++)
				{
					if (graph[j, i] != 0 && visited[i] != true)
					{
						visited[i] = true;
						q.Enqueue(i);
						distance[i] = distance[j] + graph[j, i];
						Console.WriteLine(beginning + " --> " + cities[i] + ": " + distance[i] + " кілометрів");
					}
				}
			}
		}
	}
}
