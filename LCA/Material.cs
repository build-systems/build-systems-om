using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BSoM.LCA
{
    public class Material
    {
        /// <summary>
        /// Material ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Material name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Measurement unit (ex. m3 or kg)
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// Weight in kg
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Linear density in kg/m
        /// </summary>
        public double DensityLinear { get; set; }
        /// <summary>
        /// Area density in kg/m2
        /// </summary>
        public double DensityArea { get; set; }
        /// <summary>
        /// Desity in kg/m3
        /// </summary>
        public double Density { get; set; }
        /// <summary>
        /// Conversion factor
        /// </summary>
        public double ConversionFactor { get; set; }
        /// <summary>
        /// Conversion factor per kg
        /// </summary>
        public double ConversionFactorKg { get; set; }
        /// <summary>
        /// MJ per unit during phases A1 to A3
        /// </summary>
        public double PENRT_A1ToA3 { get; set; }
        /// <summary>
        /// MJ per unit during phase C3
        /// </summary>
        public double PENRT_C3 { get; set; }
        /// <summary>
        /// MJ per unit during phase C4
        /// </summary>
        public double PENRT_C4 { get; set; }
        /// <summary>
        /// MJ per unit during phase D1
        /// </summary>
        public double PENRT_D1 { get; set; }
        /// <summary>
        /// CO2eq per unit during phases A1 to A3
        /// </summary>
        public double GWP_A1ToA3 { get; set; }
        /// <summary>
        /// CO2eq per unit during phase C3
        /// </summary>
        public double GWP_C3 { get; set; }
        /// <summary>
        /// CO2eq per unit during phase C4
        /// </summary>
        public double GWP_C4 { get; set; }
        /// <summary>
        /// CO2eq per unit during phase D1
        /// </summary>
        public double GWP_D1 { get; set; }
    }
}
