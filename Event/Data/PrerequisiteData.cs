using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Data
{
    public class PrerequisiteData
    {
        public string PrerequisiteID { get; set; }
        public string PrerequisiteName { get; set; }
        public Prerequisite_TagOrAttribute TagOrAttribute { get; set; }

        public Prerequisite_SatisfyAllOrOne SatisfyAllOrOne { get; set; }

        public Prerequisite_RequireEntitiyType RequireEntitiyType { get; set; }

        public string EntitiyName_IfPrerequisiteToOtherEntities { get; set; }

        public string TagOrAttributeName { get; set; }

        public Prerequisite_RequireExistOrNot RequireExistOrNot { get; set; }

        public float Bigger_IfRequirementAttribute { get; set; }

        public float Smaller_IfRequirementAttribute { get; set; }


        public PrerequisiteData() 
        {
            PrerequisiteID= Guid.NewGuid().ToString();
            PrerequisiteName = "新要求";
            TagOrAttribute = Prerequisite_TagOrAttribute.Attribute;
            SatisfyAllOrOne = Prerequisite_SatisfyAllOrOne.All;
            RequireEntitiyType = Prerequisite_RequireEntitiyType.PlayerCharacter;
            EntitiyName_IfPrerequisiteToOtherEntities = "默认实体名称";
            TagOrAttributeName = "默认名";
            RequireExistOrNot = Prerequisite_RequireExistOrNot.Exist;
            Bigger_IfRequirementAttribute = 0f;
            Smaller_IfRequirementAttribute = 0f;
        }
        public override string ToString()
        {
            string result = "";
            result += $"{PrerequisiteName} ";

            switch (RequireEntitiyType)
            {
                case Prerequisite_RequireEntitiyType.PlayerCharacter:
                    {
                        result += $"对主控";
                    }
                    break;
                case Prerequisite_RequireEntitiyType.OtherEntities:
                    {
                        result += $"对({EntitiyName_IfPrerequisiteToOtherEntities})";
                    }
                    break;
            }

            switch (TagOrAttribute)
            {
                case Prerequisite_TagOrAttribute.Tag:
                    {

                        switch (RequireExistOrNot)
                        {
                            case Prerequisite_RequireExistOrNot.Exist:
                                {
                                    result += $"需要拥有标签:({TagOrAttributeName})";
                                }
                                break;
                            case Prerequisite_RequireExistOrNot.NotExist:
                                {
                                    result += $"需要没有标签:({TagOrAttributeName})";
                                }
                                break;
                        }

                    }
                    break;
                case Prerequisite_TagOrAttribute.Attribute:
                    {
                        result += $"需要:{Bigger_IfRequirementAttribute}<=属性({TagOrAttributeName})<={Smaller_IfRequirementAttribute}";
                    }
                    break;
            }

            return result;
        }
    }
}
