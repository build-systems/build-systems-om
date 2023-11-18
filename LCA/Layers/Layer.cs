using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSoM.LCA.Layers
{
    // Main layer class, it has the basic information about the layer.
    // The next classes should iherit from this one ?

    public class Layer
    {
        /// <summary>
        /// Level of detail. LOD 1: Component; LOD 2: Assembly; LOD 3: Layer; LOD 4: Sub-layer or Material
        /// </summary>
        public int LOD { get; set; } = 3;
        /// <summary>
        /// BOM-like structure to represent parent-child relationships.
        /// </summary>
        public string Level { get; set; }
        /// <summary>
        /// Categories like Ausbau, Dämmung, Holz, Assembly, Sub-assembly.
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// General description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Thickness of the assembly.
        /// </summary>
        public double Thickness { get; set; }
        /// <summary>
        /// Cost in € per m².
        /// </summary>
        public double Cost { get; set; }
    }
}
