using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnweightedAndUnguidedGraph
{
    public class Graph<T>
    {
        public List<Vertex<T>> Vertices { get; private set; }

        public int VertexCount => Vertices.Count;

        public void AddVertex(Vertex<T> vertex)
        {
            if(vertex.Value == null || vertex == null)
            {
                return;
            }
            if (vertex.Value == null || vertex.Neighbors.Count > 0 || !Vertices.Contains(vertex)) return;
            Vertices.Add(vertex);
        }

        public bool RemoveVertex(Vertex<T> vertex)
        {
            if(Vertices.Contains(vertex))
            {
                vertex.Neighbors = null;
                Vertices.Remove(vertex);
                return true;
            }
            return false;
        }

        public bool AddEdge(Vertex<T> a, Vertex<T> b)
        {
            if (a == null || b == null || Vertices.Contains(a) || Vertices.Contains(b)) return false;
            a.Neighbors.Add(b);
            b.Neighbors.Add(a);
            return true;

        }

        public bool RemoveEdge(Vertex<T> a, Vertex<T> b)
        {
            if (a != null && b != null && b.Neighbors.Contains(a) && a.Neighbors.Contains(b))
            {
                a.Neighbors.Remove(b);
                b.Neighbors.Remove(a); 
            }
            return false;
        }

        public Vertex<T> Search(T value)
        {
            int k = -1;

            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].Value.Equals(value))
                {
                    k = i;
                }
            }
            if (k == -1)
            {
                return null;
            }
            else return Vertices[k];
        }

    }
}
