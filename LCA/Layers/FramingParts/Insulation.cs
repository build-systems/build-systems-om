using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSoM.LCA.Layers.FramingParts
{
    // Insulation that will go to framing layer
    public class Insulation
    {
        /// <summary>
        /// The thickness of the insulation. Should be limited to standard values.
        /// </summary>
        public double Thickness { get; set; }
        /// <summary>
        /// Width of insulation. This value is automatically calculated when adding a Frame to FramingLayer.
        /// </summary>
        public double Width { get; set; }

        // Dictionary of material options. Keys as A, B, C, etc.
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
        /// Return the next option a letter.
        /// </summary>
        /// <returns></returns>
        private string GetNextTag()
        {
            char tag = (char)('A' + (tagCounter) % 26);
            tagCounter++;
            return tag.ToString();
        }

        public Insulation(List<Material> options, double thickness)
        {
            this.Thickness = thickness;
            foreach (Material option in options)
            {
                string tag = GetNextTag();
                materialOptions.Add(tag, option);
            }
        }
        public Insulation(double thickness, Material option)
        {
            this.Thickness = thickness;
            string tag = GetNextTag();
            materialOptions.Add(tag, option);
        }
        public Insulation(double thickness)
        {
            this.Thickness = thickness;
        }
    }
}
