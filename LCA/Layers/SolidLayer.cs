using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSoM.LCA.Layers
{
    // The solid layers that make this assembly. Layers with a single material.

    public class SolidLayer : Layer
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
        /// Add a new option to the dictionary.
        /// </summary>
        /// <param name="option"></param>
        public void AddMaterialOption(Material option)
        {
            string tag = GetNextTag();
            materialOptions.Add(tag, option);
        }
        /// <summary>
        /// Return the next option as a letter
        /// </summary>
        /// <returns></returns>
        private string GetNextTag()
        {
            char tag = (char)('A' + (tagCounter) % 26);
            tagCounter++;
            return tag.ToString();
        }
    }
}
