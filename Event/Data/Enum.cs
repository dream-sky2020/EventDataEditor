using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Data
{
    public enum SubsequentImpact_TagOrAttribute
    {
        Tag,
        Attribute
    }
    public enum Prerequisite_TagOrAttribute
    {
        Tag,
        Attribute
    }
    public enum SubsequentImpact_ImpactEntitiyType
    {
        PlayerCharacter,
        OtherEntities
    }
    public enum Prerequisite_RequireEntitiyType
    {
        PlayerCharacter,
        OtherEntities
    }
    public enum Prerequisite_SatisfyAllOrOne
    {
        All,
        One
    }
    public enum Prerequisite_RequireExistOrNot
    {
        Exist,
        NotExist
    }
    public enum SubsequentImpact_AddOrRemoveTag 
    {
        AddTag,
        RemoveTag,
    }
}
