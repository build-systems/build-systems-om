using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSoM.LCA.Layer
{
    // The solid layers that make this assembly. Layers with a single material.

    public class Solid
    {
        /// <summary>
        /// Thickness of the assembly.
        /// </summary>
        public string Thickness { get; set; }
        /// <summary>
        /// Dictionary of material options. They should be named Option A, Option B, etc.
        /// </summary>
        public Dictionary<string, MaterialOptions> OptionAttributes { get; set; } = new Dictionary<string, MaterialOptions>();
    }
}
