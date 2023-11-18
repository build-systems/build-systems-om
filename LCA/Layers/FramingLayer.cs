using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSoM.LCA.Layers.FramingParts;

namespace BSoM.LCA.Layers
{
    // The framing layers that make this assembly.
    public class FramingLayer : Layer
    {
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
