using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSoM.LCA
{
    public class Assembly
    {

        /// <summary>
        /// Level of detail. LOD 1: Component; LOD 2: Assembly; LOD 3: Layer; LOD 4: Sub-layer
        /// </summary>
        public string LOD { get; set; }
        /// <summary>
        /// BOM-like structure to represent parent-child relationships.
        /// </summary>
        public string Level { get; set; }
        /// <summary>
        /// Categories like Ausbau, Dämmung, Holz, Assembly, Sub-assembly.
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Assembly ID: BuildingLayer-Material-AssemblyTipe-version. For example: AW-H-SUB-1 means Außenwnad-Holz-SubAssembly-version1.
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// General description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Thickness of the assembly.
        /// </summary>
        public string Thickness { get; set; }
        /// <summary>
        /// Cost in € per m².
        /// </summary>
        public string Kosten { get; set; }

        // I am still not sure how to deal with these layers.
        // Ideally they would stay in a single list,
        // as a single object with different parameters.

        /// <summary>
        /// The layers that make this assembly.
        /// </summary>
        public List<Layers> Layers { get; set; } = new List<Layers>();
    }
}
