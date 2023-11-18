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
        public static string Path 
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

        public static string MaterialPath() => System.IO.Path.Combine(Path, Material);
        public static string AssemblyPath() => System.IO.Path.Combine(Path, Material);
        public static string ComponentPath() => System.IO.Path.Combine(Path, Material);
    }
}
