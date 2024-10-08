﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnweightedAndUnguidedGraph
{
    public class Vertex<T>
    {
        public T Value { get; set; }    
        public List<Vertex<T>> Neighbors { get; set; }

        public int NeighborCount => Neighbors.Count;

        public Vertex(T value)
        {
            Value = value; 
        }
    }

}
