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
        /// Material subfolder name, without path
        /// </summary>
        public static string MaterialTag => "Material";
        /// <summary>
        /// Assembly subfolder name, without path
        /// </summary>
        public static string AssemblyTag => "Assembly";
        /// <summary>
        /// Component subfolder name, without path
        /// </summary>
        public static string ComponentTag => "Component";
        /// <summary>
        /// Returns path for the material library folder
        /// </summary>
        /// <returns></returns>
        public static string MaterialFolder() => System.IO.Path.Combine(Folder, MaterialTag);
        /// <summary>
        /// Returns path for the assembly library folder
        /// </summary>
        /// <returns></returns>
        public static string AssemblyFolder() => System.IO.Path.Combine(Folder, AssemblyTag);
        /// <summary>
        /// Returns path for the component library folder
        /// </summary>
        /// <returns></returns>
        public static string ComponentFolder() => System.IO.Path.Combine(Folder, ComponentTag);
        /// <summary>
        /// Returns a list of json files where each is a material
        /// </summary>
        /// <returns></returns>
        public static List<string> MaterialFiles() => Directory.GetFiles(MaterialFolder(), "*.json").ToList();
        /// <summary>
        /// Returns a list of json files where each is an assembly
        /// </summary>
        /// <returns></returns>
        public static List<string> AssemblyFiles() => Directory.GetFiles(AssemblyFolder(), "*.json").ToList();
        /// <summary>
        /// Returns a list of json files where each is a component
        /// </summary>
        /// <returns></returns>
        public static List<string> ComponentFiles() => Directory.GetFiles(ComponentFolder(), "*.json").ToList();
    }
}
