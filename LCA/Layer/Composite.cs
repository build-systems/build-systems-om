using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSoM.LCA.Layer
{
    // The composit layers that make this assembly. Layers with a mix of materials, like concrete + steel.

    public class Composite
    {
        public List<double> Ratio { get; set; }
        /// <summary>
        /// Dictionary of material options. They should be named Option A, Option B, etc.
        /// </summary>
        public Dictionary<string, MaterialOptions> OptionAttributes { get; set; } = new Dictionary<string, MaterialOptions>();
    }
}
