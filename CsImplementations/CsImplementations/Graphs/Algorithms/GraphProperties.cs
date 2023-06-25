using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.Graphs;

namespace DataStructures.Graphs.Algorithms
{
    /// <summary>
    /// Calculates several properties of a Graph.
    /// </summary>
    public class GraphProperties
    {
        private readonly Graph _g;

        public GraphProperties(Graph graph)
        {
            this._g = graph;
        }

        /// <summary>
        /// Eccentricity of a vertex v is the length of the shortest path from that vertex to the furthest vertex from v.
        /// </summary>
        /// <param name="v">Vertex.</param>
        /// <returns>Eccentricity of v.</returns>
        public int Eccentricity(int v)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Diameter of a graph is the maximum eccentricity of any vertex.
        /// </summary>
        /// <returns>Diameter of the graph.</returns>
        public int Diameter()
        {
            throw new NotImplementedException();
        }

        public int Radius()
        {
            throw new NotImplementedException();
        }

        public int Center()
        {
            throw new NotImplementedException();
        }
    }//class
}
