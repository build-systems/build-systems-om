using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BSoM.Database
{
    public static class Info
    {
        /// <summary>
        /// Database root folder path
        /// </summary>
        public static string Folder 
        {
            get
            {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                string ghaPath = assembly.Location;
                // Get the directory from the gha file.
                string directoryPath = System.IO.Path.GetDirectoryName(ghaPath);
                // Combine with the directory.
                string libPath = System.IO.Path.Combine(directoryPath, "Resources/BuildSystems");
                return libPath;
            }
        }
        /// <summary>
        /// Material subfolder
        /// </summary>
        public static string Material => "Material";
        /// <summary>
        /// Assembly subfolder
        /// </summary>
        public static string Assembly => "Assembly";
        /// <summary>
        /// Component subfolder
        /// </summary>
        public static string Component => "Component";
        /// <summary>
        /// Return the Material folder in which the json files are stored
        /// </summary>
        /// <returns></returns>
        public static string MaterialFolder() => System.IO.Path.Combine(Folder, Material);
        /// <summary>
        /// Return the Assembly folder in which the json files are stored
        /// </summary>
        /// <returns></returns>
        public static string AssemblyFolder() => System.IO.Path.Combine(Folder, Assembly);
        public static string ComponentFolder() => System.IO.Path.Combine(Folder, Component);
        public static List<string> MaterialFiles() => Directory.GetFiles(MaterialFolder(), "*.json").ToList();
        public static List<string> AssemblyFiles() => Directory.GetFiles(AssemblyFolder(), "*.json").ToList();
        public static List<string> ComponentFiles() => Directory.GetFiles(ComponentFolder(), "*.json").ToList();
    }
}
