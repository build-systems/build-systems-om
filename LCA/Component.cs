using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSoM.LCA
{
    public class Component
    {
        /// <summary>
        /// The ID of the component. It is the combination of the Local, Statics, Structure and the version.
        /// Example: Trenndecke, tragent, Holzmassiv, version A = TD-tr-HM-A
        /// </summary>
        [JsonProperty("")]
        public string ID { get; set; }
        /// <summary>
        /// Before called Bauteil. It is the location of the component, for example: Dachdecke, Trennwand, Boden, etc.
        /// </summary>
        [JsonProperty("")]
        public Local Category { get; set; } = Local.Undefined;
        /// <summary>
        /// It is the statics of the component, for example: Tragend, Nichttragend, etc.
        /// </summary>
        [JsonProperty("")]
        public Statics Statics { get; set; } = Statics.Undefined;
        /// <summary>
        /// Before called Bauart. It is the main material of the component, for example: Beton, Holz, etc.
        /// </summary>
        [JsonProperty("")]
        public Structure Structure { get; set; } = Structure.Undefined;
        /// <summary>
        /// Beschreibung. A description of the component.
        /// </summary>
        [JsonProperty("")]
        public string Description { get; set; }
        /// <summary>
        /// Gebaeudeklasse. Specific for Germany.
        /// </summary>
        [JsonProperty("")]
        public BuildingClass BuildingClass { get; set; } = BuildingClass.Undefined;
        /// <summary>
        /// Brandschutz. Specific for Germany.
        /// </summary>
        [JsonProperty("")]
        public FireProtection FireProtection { get; set; } = FireProtection.Undefined;
        /// <summary>
        /// Efficiency against heat transfer.
        /// </summary>
        [JsonProperty("")]
        public double UValue { get; set; }
        /// <summary>
        /// Impact Sound Level.
        /// </summary>
        [JsonProperty("")]
        public double Lnw { get; set; }
        /// <summary>
        /// Spectrum adaptation term for impact sound transmission ranging between 50 and 2500 Hz.
        /// </summary>
        [JsonProperty("")]
        public double Ci502500 { get; set; }
        /// <summary>
        /// Weighted sound reduction index.
        /// </summary>
        [JsonProperty("")]
        public double Rw { get; set; }
        /// <summary>
        /// Spectrum adaptation C ranging between 50 and 5000 Hz.
        /// </summary>
        [JsonProperty("")]
        public double C505000 { get; set; }
        /// <summary>
        /// Spectrum adaptation Ctr ranging between 50 and 5000 Hz.
        /// </summary>
        [JsonProperty("")]
        public double Ctr505000 { get; set; }
        /// <summary>
        /// Description of the component missing.
        /// </summary>
        [JsonProperty("")]
        public double C { get; set; }
        /// <summary>
        /// Installationsebene. Layer within the component where installations such as electrical wiring, plumbing, and other utility services are placed. 
        /// </summary>
        [JsonProperty("")]
        public InstallationLayer InstallationLayer { get; set; } = InstallationLayer.Undefined;
        /// <summary>
        /// Quelle. Reference where the component was taken from (website, book, etc.).
        /// </summary>
        [JsonProperty("")]
        public string Reference { get; set; }
        /// <summary>
        /// Super Aufbau. The top layers of the component, finishing.
        /// </summary>
        [JsonProperty("")]
        public Assembly SuperAssembly { get; set; }
        /// <summary>
        /// Main Aufbau. The main layers of the component, structural.
        /// </summary>
        [JsonProperty("")]
        public Assembly MainAssembly { get; set; }
        /// <summary>
        /// Sub Aufbau. The top layers of the component, finishing.
        /// </summary>
        [JsonProperty("")]
        public Assembly SubAssembly { get; set; }
        /// <summary>
        /// The total cost of the component.
        /// </summary>
        [JsonProperty("")]
        public double Cost { get; set; }
        /// <summary>
        /// The total thickness of the component.
        /// </summary>
        [JsonProperty("")]
        public double Thicknes { get; set; }
        /// <summary>
        /// The average MJ per m2 of the component for the phases A1 to A3.
        /// </summary>
        [JsonProperty("")]
        public double PENRT_A1ToA3 { get; set; }
        /// <summary>
        /// The average MJ per m2 of the component for the phase C3.
        /// </summary>
        [JsonProperty("")]
        public double PENRT_C3 { get; set; }
        /// <summary>
        /// The average MJ per m2 of the component for the phase C4.
        /// </summary>
        [JsonProperty("")]
        public double PENRT_C4 { get; set; }
        /// <summary>
        /// The average MJ per m2 of the component for the phase D1.
        /// </summary>
        [JsonProperty("")]
        public double PENRT_D1 { get; set; }
        /// <summary>
        /// The average kg CO2eq per m2 of the component for the phases A1 to A3.
        /// </summary>
        [JsonProperty("")]
        public double GWP_A1ToA3 { get; set; }
        /// <summary>
        /// The average kg CO2eq per m2 of the component for the phase C3.
        /// </summary>
        [JsonProperty("")]
        public double GWP_C3 { get; set; }
        /// <summary>
        /// The average kg CO2eq per m2 of the component for the phase C4.
        /// </summary>
        [JsonProperty("")]
        public double GWP_C4 { get; set; }
        /// <summary>
        /// The average kg CO2eq per m2 of the component for the phase D1.
        /// </summary>
        [JsonProperty("")]
        public double GWP_D1 { get; set; }
    }
}
