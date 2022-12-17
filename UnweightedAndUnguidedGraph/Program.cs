namespace UnweightedAndUnguidedGraph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph<int> graph = new Graph<int>();

            Vertex<int> v = new Vertex<int>(1);

            graph.AddVertex(v);
            Vertex<int> q = graph.Search(1);
        }
    }
}