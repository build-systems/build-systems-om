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
        /// The thickness of the frame. Should be limited to standard values. This will dictate the thickness of the Layer itself.
        /// </summary>
        public double Thickness { get; set; }
        /// <summary>
        /// Width of the framing piece.
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// Distance between the center line of each framing piece
        /// </summary>
        public double Spread { get; set; }

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
        /// Return the next option letter.
        /// </summary>
        /// <returns></returns>
        private string GetNextTag()
        {
            char tag = (char)('A' + (tagCounter) % 26);
            tagCounter++;
            return tag.ToString();
        }

        public Frame (List<Material> options, double thickness, double width, double spread)
        {
            this.Thickness = thickness;
            this.Width = width;
            this.Spread = spread;
            foreach (Material option in options)
            {
                string tag = GetNextTag();
                materialOptions.Add(tag, option);
            }
        }
    }
}
