using Event.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class EventData
    {
        public string EventId { get; set; }
        public string EventName { get; set; }
        public string EventText { get; set; }

        public List<OptionData> Options { get; set; }

        public EventData() 
        {
            EventId=Guid.NewGuid().ToString();
            EventName = "新事件";
            EventText = "将该文本删除，替换为你想要的文字，并且按下修改并保存，EventText将会替换该文本框内的内容，同样，按下修改事件名，EventName也会替换为旁边文本框的内容";
            Options = new List<OptionData>();
        }


    }
}
