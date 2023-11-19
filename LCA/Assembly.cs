using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSoM.Database;
using Newtonsoft.Json;
using BSoM.LCA.Layers;


namespace BSoM.LCA
{
    public class Assembly
    {
        /// <summary>
        /// Assembly ID: BuildingLayer-Material-AssemblyTipe-version. For example: AW-H-SUB-1 means Außenwnad-Holz-SubAssembly-version1.
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; set; }
        /// <summary>
        /// Level of detail. LOD 1: Component; LOD 2: Assembly; LOD 3: Layer; LOD 4: Sub-layer
        /// </summary>
        [JsonProperty("lod")]
        public string LOD { get; set; }
        /// <summary>
        /// BOM-like structure to represent parent-child relationships.
        /// </summary>
        [JsonProperty("level")]
        public string Level { get; set; }
        /// <summary>
        /// Categories like Ausbau, Dämmung, Holz, Assembly, Sub-assembly.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }
        /// <summary>
        /// General description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// Thickness of the assembly.
        /// </summary>
        [JsonProperty("thickness")]
        public string Thickness { get; set; }
        /// <summary>
        /// Cost in € per m².
        /// </summary>
        [JsonProperty("cost")]
        public string Cost { get; set; }

        // The layers will be dictionaries instead of lists.
        // The key will be the BOM level and the value the layer
        // Still not sure how to deal with different kinds of layers

        /// <summary>
        /// The layers that make this assembly.
        /// </summary>
        public List<Layer> Layers { get; set; } = new List<Layer>();
    }
}
