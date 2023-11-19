using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BSoM.LCA
{
    public class Material
    {
        /// <summary>
        /// Material ID
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; set; }
        /// <summary>
        /// Material name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Measurement unit (ex. m3 or kg)
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }
        /// <summary>
        /// Weight in kg
        /// </summary>
        [JsonProperty("weight_kg")]
        public double Weight { get; set; }
        /// <summary>
        /// Linear density in kg/m
        /// </summary>
        [JsonProperty("linear_density")]
        public double DensityLinear { get; set; }
        /// <summary>
        /// Area density in kg/m2
        /// </summary>
        [JsonProperty("area_density")]
        public double DensityArea { get; set; }
        /// <summary>
        /// Desity in kg/m3
        /// </summary>
        [JsonProperty("density")]
        public double Density { get; set; }
        /// <summary>
        /// Conversion factor
        /// </summary>
        [JsonProperty("conversion_factor")]
        public double ConversionFactor { get; set; }
        /// <summary>
        /// Conversion factor per kg
        /// </summary>
        [JsonProperty("conversion_factor_kg")]
        public double ConversionFactorKg { get; set; }
        /// <summary>
        /// MJ per unit during phases A1 to A3
        /// </summary>
        [JsonProperty("penrt_a1toa3")]
        public double PENRT_A1ToA3 { get; set; }
        /// <summary>
        /// MJ per unit during phase C3
        /// </summary>
        [JsonProperty("penrt_c3")]
        public double PENRT_C3 { get; set; }
        /// <summary>
        /// MJ per unit during phase C4
        /// </summary>
        [JsonProperty("penrt_c4")]
        public double PENRT_C4 { get; set; }
        /// <summary>
        /// MJ per unit during phase D1
        /// </summary>
        [JsonProperty("penrt_D1")]
        public double PENRT_D1 { get; set; }
        /// <summary>
        /// CO2eq per unit during phases A1 to A3
        /// </summary>
        [JsonProperty("gwp_a1toa3")]
        public double GWP_A1ToA3 { get; set; }
        /// <summary>
        /// CO2eq per unit during phase C3
        /// </summary>
        [JsonProperty("gwp_c3")]
        public double GWP_C3 { get; set; }
        /// <summary>
        /// CO2eq per unit during phase C4
        /// </summary>
        [JsonProperty("gwp_c4")]
        public double GWP_C4 { get; set; }
        /// <summary>
        /// CO2eq per unit during phase D1
        /// </summary>
        [JsonProperty("gwp_d1")]
        public double GWP_D1 { get; set; }
    }
}
