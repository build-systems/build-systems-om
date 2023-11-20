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
        private Frame _frame;
        private Insulation _insulation;

        /// <summary>
        /// Piece used to install the frame in place.
        /// </summary>
        public Clamp Clamp { get; set; }
        /// <summary>
        /// The structural part of the framing layer.
        /// </summary>
        public Frame Frame 
        {
            get 
            {
                return _frame;
            }
            set 
            {
                // How to set the value for insulation width automatically?
                _frame = value;
                Thickness = value.Thickness;
                //_insulation.Width = value.Spread - value.Thickness;
            }
        }
        /// <summary>
        /// The insulation part of the framing layer.
        /// </summary>
        public Insulation Insulation { get; set; }

        public FramingLayer (Frame frame, Insulation insulation)
        {
            this.Frame = frame;
            this.Insulation = insulation;
        }
        public FramingLayer(Frame frame, Insulation insulation, Clamp clamp)
        {
            this.Frame = frame;
            this.Insulation = insulation;
            this.Clamp = clamp;
        }
    }
}
