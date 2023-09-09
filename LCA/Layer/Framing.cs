using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSoM.LCA.Layer
{
    // The framing layers that make this assembly.
    public class Framing
    {
        /// <summary>
        /// The total thickness is the sum of the clamp and the frame thickness.
        /// </summary>
        public double Thickness { get; set; }
        /// <summary>
        /// Piece used to install the frame in place.
        /// </summary>
        public Clamp Clamp { get; set; }
        /// <summary>
        /// The structural part of the framing layer.
        /// </summary>
        public Frame Frame { get; set; }
        /// <summary>
        /// The insulation part of the framing layer.
        /// </summary>
        public Insulation Insulation { get; set; }
    }
}
