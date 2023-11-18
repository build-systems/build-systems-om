using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSoM.LCA.Layers
{
    // The composit layers that make this assembly. Layers with a mix of materials, like concrete + steel.

    public class CompositeLayer : Layer
    {
        public List<double> Ratio { get; set; }
        /// <summary>
        /// Dictionary of material options. They should be named Option A, Option B, etc.
        /// </summary>
        //public Dictionary<string, MaterialOption> OptionAttributes { get; set; } = new Dictionary<string, MaterialOption>();
    }
}
