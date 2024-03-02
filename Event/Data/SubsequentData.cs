using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Data
{
    public class SubsequentData
    {
        public string SubsequentID { get; set; }

        public string SubsequentName { get; set; }

        public string SubsequentText { get; set; }

        public float SubsequentProbabilityFactor { get; set; }

        public List<SubsequentImpactData> SubsequentImpacts { get; set; }


        public SubsequentData() 
        {
            SubsequentID = Guid.NewGuid().ToString();
            SubsequentName = "新后续";
            SubsequentText = "将该文本删除，替换为你想要的文字，并且按下修改并保存，SubsequentText将会替换该文本框内的内容，同样，按下修改结果名称，SubsequentName也会替换为旁边文本框的内容";
            SubsequentProbabilityFactor = 1f;
            SubsequentImpacts= new List<SubsequentImpactData>();
        }

        public override string ToString()
        {
            return $"{SubsequentName} 概念因素:{SubsequentProbabilityFactor}";
        }
    }
}
