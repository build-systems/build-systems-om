using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSoM.LCA.Layers.FramingParts
{
    // Frame that will go to framing layer
    public class Frame
    {
        private Dictionary<string, Material> materialOptions = new Dictionary<string, Material>();
        private int tagCounter = 0;

        /// <summary>
        /// Return the dictionary of material options.
        /// </summary>
        public Dictionary<string, Material> MaterialOptions
        {
            get { return materialOptions; }
        }

        /// <summary>
        /// The thickness of the frame. Should be limited to standard values.
        /// </summary>
        public double Thickness { get; set; }
        /// <summary>
        /// Dictionary of material options. They should be named Option A, Option B, etc.
        /// </summary>
        public Dictionary<string, Material> OptionAttributes { get; set; } = new Dictionary<string, Material>();
    }
}
