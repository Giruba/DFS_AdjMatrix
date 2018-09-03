using System;
using System.Collections.Generic;
using System.Text;

namespace DepthFirstSearchUsingAdjacencyMatrix
{
    class Graph
    {
        private int Vertices;
        private int[,] AdjacencyMatrix;

        private Graph() { }

        public Graph(int Vertices, int[,] adjMatrix) {
            this.Vertices = Vertices;
            this.AdjacencyMatrix = adjMatrix;
        }

        public void DFS(int startVertex) {
            Boolean []visisted = new Boolean[this.Vertices];
            Console.WriteLine("The Depth First Search is as follows");
            DFSUtil(startVertex, this.AdjacencyMatrix, visisted);
            Console.ReadKey();
        }


        private void DFSUtil(int startVertex, int[,] matrix, Boolean[] visited) {

            visited[startVertex] = true;
            Console.Write(startVertex + "->");
            for (int i = 0; i < Vertices; i++) {
                if (AdjacencyMatrix[i, startVertex] == 1 && false == visited[i]) {
                    DFSUtil(i, matrix, visited);
                }
            }
        }


        public void DisplayAdjacencyMatrix() {
            for (int i = 0; i < Vertices; i++) {
                for (int j = 0; j < Vertices; j++) {
                    Console.Write(AdjacencyMatrix[i,j]);
                }
                Console.WriteLine();
            }

        }

    }
}
