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
        /// <summary>
        /// The thickness of the frame. Should be limited to standard values.
        /// </summary>
        public double Thickness { get; set; }
        /// <summary>
        /// Dictionary of material options. They should be named Option A, Option B, etc.
        /// </summary>
        //public Dictionary<string, MaterialOption> OptionAttributes { get; set; } = new Dictionary<string, MaterialOption>();
    }
}
