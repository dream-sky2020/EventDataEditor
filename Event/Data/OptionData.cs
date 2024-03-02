using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Data
{
    public class OptionData
    {
        public string OptionID { get; set; }
        public string OptionName { get; set; }
        public string OptionText { get; set; }

        public bool IfComfirm { get; set; }

        public string IfComfirmText { get; set; }

        public List<PrerequisiteData> Prerequisites { get; set; }

        public List<SubsequentData> Subsequents { get; set; }

        public OptionData() 
        {
            OptionID= Guid.NewGuid().ToString();
            OptionName = "新选项";
            OptionText = "将该文本删除，替换为你想要的文字，并且按下修改并保存，OptionText将会替换该文本框内的内容，同样，按下修改事件名，OptionName也会替换为旁边文本框的内容";
            IfComfirm = false;
            IfComfirmText = "将该文本删除，替换为你想要的文字，并且按下修改并保存，IfComfirmText将会替换该文本框内的内容，按下是否确认按钮，当玩家选择选项后是否确认";
            Prerequisites = new List<PrerequisiteData>();
            Subsequents= new List<SubsequentData>();

        }
        public override string ToString()
        {
            string result="";
            result += $"Name:{OptionName}";
            if (IfComfirm == true) 
            {
                result += $"  需要确认";
            }
            return result;
        }

    }
}
