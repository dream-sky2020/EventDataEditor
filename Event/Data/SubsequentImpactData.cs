using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Data
{
    
    public class SubsequentImpactData
    {
        public SubsequentImpact_TagOrAttribute SubsequentImpactTagOrAttribute { get; set; }

        public SubsequentImpact_ImpactEntitiyType SubsequentImpactEntitiyType { get; set; }

        public string EntitiyName_IfSubsequentImpactToOtherEntities { get; set; }

        public string TagOrAttributeName { get; set; }

        public float ImpactAttributeValue_IfSubsequentImpactAttribute { get; set; }

        public SubsequentImpact_AddOrRemoveTag AddOrRemoveTag_IfSubsequentImpactTag { get; set; }

        public SubsequentImpactData() 
        {
            SubsequentImpactTagOrAttribute = SubsequentImpact_TagOrAttribute.Tag;
            SubsequentImpactEntitiyType = SubsequentImpact_ImpactEntitiyType.PlayerCharacter;
            EntitiyName_IfSubsequentImpactToOtherEntities = "默认名称";
            TagOrAttributeName = "默认名称";
            ImpactAttributeValue_IfSubsequentImpactAttribute = 0;
            AddOrRemoveTag_IfSubsequentImpactTag = SubsequentImpact_AddOrRemoveTag.AddTag;
        }
    }
}
