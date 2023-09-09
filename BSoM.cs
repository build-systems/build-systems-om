using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSoM.LCA
{

    /* General notes
     * 
     * The BHoM uses ENUM to list possible options,
     * for example we can use for a method to create components instead of having one object for each.
     * We would need an enum file llisting Außenwand, Innenwand, etc.
     * Check how they use enum:
     * [Description("Typically a term utilised in BIM practices to clearly identify the scope of work being account for. Equivalents for LOD classifications can offen times be linked to design and construction phases common to the projects locale.")]
     * public virtual LevelOfDevelopment LevelOfDevelopment { get; set; } = LevelOfDevelopment.Undefined;
     * 
     * Enum > LevelOfDevelopment (folder Enum and file with same name)
     * 
     * Check how they create descriptions:
     * [Description("Identifies the overall construction scope for the project. Set True if New Construction exists within your project.")]
     * public virtual bool ConstructionScopeNew { get; set; } = false;
     * 
     * What is this "public virtual"?
     * 
     * What is an interface? They use for the LCA phases, see:
     * BHoM LifeCycleAssessment_oM > ILifeCycleAssessmentPhaseData
     * 
     * What is the difference between a component and a class when creating a new item here?
     * 
     * Improve enum namings. Talk to Daniel
     * 
     * Having wall > component > assembly
     * This way we can also start planning for windows as geometry
     */

}
