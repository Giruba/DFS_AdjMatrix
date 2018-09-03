using System;

namespace DepthFirstSearchUsingAdjacencyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Depth First Search using Adjacency Matrix!");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Enter the number of vertices");
            int noOfVertices = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements [" + noOfVertices + "*" + noOfVertices + "=" + (noOfVertices * noOfVertices) + "]");
            int [,]adjMatrix = new int[noOfVertices, noOfVertices];
            for (int i = 0; i < noOfVertices; i++) {
                for (int j = 0; j < noOfVertices; j++) {
                    adjMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Graph g = new Graph(noOfVertices, adjMatrix);
            Console.WriteLine("The adjacency Matrix is");
            g.DisplayAdjacencyMatrix();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter the start index");
            int startIndex = int.Parse(Console.ReadLine());
            g.DFS(startIndex);
        }
    }
}
