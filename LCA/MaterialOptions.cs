using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSoM.LCA
{
    public class MaterialOptions
    {
        /// <summary>
        /// Add a new option to the dictionary.
        /// </summary>
        /// <param name="option"></param>
        public void AddMaterialOption(int tagCounter, Dictionary<string, Material> materialOptions, Material option)
        {
            string tag = GetNextTag(tagCounter);
            materialOptions.Add(tag, option);
        }
        /// <summary>
        /// Return the next option as a letter
        /// </summary>
        /// <returns></returns>
        private string GetNextTag(int tagCounter)
        {
            char tag = (char)('A' + (tagCounter) % 26);
            tagCounter++;
            return tag.ToString();
        }
    }
}
