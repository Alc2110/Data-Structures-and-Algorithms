using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.Graphs.EdgeWeightedGraphs;

namespace DataStructures.Graphs.EdgeWeightedGraphs.Algorithms
{
    public interface IShortestPaths
    {
        /// <summary>
        /// Distance from S to V.
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns>Distance. Infinity if no path from S to V.</returns>
        double DistanceTo(int vertex);

        /// <summary>
        /// Gets whether a path from S to V exists.
        /// </summary>                                                                                                                                                                                                                                               
        /// <param name="vertex"></param>
        /// <returns></returns>
        Boolean HasPathTo(int vertex);

        /// <summary>
        /// Edges forming path from S to V.
        /// </summary>
        /// <param name="vertext"></param>
        /// <returns>Null if none.</returns>
        IEnumerable<DirectedEdge> PathTo(int vertext);
    }
}
