using Event.Data;
using Event.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Event
{
    public partial class Main : Form
    {
        public List<EventData> eventDatas = new List<EventData>();

        public bool ifSelectedEvent;
        public EventData eventData_SelectedEvent;
        public ListViewItem listView_SelectedEventListItem;

        public bool ifSelectedOption;
        public OptionData optionData_SelectedOption;
        public ListViewItem listView_SelectedOptionListItem;

        public bool ifSelectedPrerequisite;
        public PrerequisiteData prerequisiteData_SelectedPrerequisite;
        public ListViewItem listView_SelectedPrerequisiteListItem;

        public bool ifSelectedSubsequent;
        public SubsequentData subsequentData_SelectedSubsequent;
        public ListViewItem listView_SelectedSubsequentListItem;

        public bool ifSelectedSubsequentImpact;
        public SubsequentImpactData subsequentImpactData_SelectedSubsequentImpact;
        public ListViewItem listView_SelectedSubsequentImpactListItem;

        public int index_createEvent = 0;

        public int index_createOption = 0;

        public int index_createPrerequisite=0;

        public int index_createSubsequent=0;

        public int index_createSubsequentImpact = 0;


        public string OpenFilePath;


        int index_Debug = 0;
        //string lastest_Debug = null;
        //List<string> list_Debug = new List<string>();


        public delegate void ReturnVoid_EventHandle();

        //ReturnVoid_EventHandle UpdateAll_Data;

        ReturnVoid_EventHandle UpdateSelectedEvent_Data;
        ReturnVoid_EventHandle CancelSelectedEvent_Data;

        ReturnVoid_EventHandle CancelSelectedEventAndFollowUp_Data;

        ReturnVoid_EventHandle UpdateSelectedOption_Data;
        ReturnVoid_EventHandle CancelSelectedOption_Data;

        ReturnVoid_EventHandle CancelSelectedOptionAndFollowUp_Data;

        ReturnVoid_EventHandle UpdateSelectedPrerequisite_Data;
        ReturnVoid_EventHandle CancelSelectedPrerequisite_Data;

        ReturnVoid_EventHandle CancelSelectedPrerequisiteAndFollowUp_Data;

        ReturnVoid_EventHandle UpdateSelectedSubsequent_Data;
        ReturnVoid_EventHandle CancelSelectedSubsequent_Data;

        ReturnVoid_EventHandle CancelSelectedSubsequentAndFollowUp_Data;

        ReturnVoid_EventHandle UpdateSelectedSubsequentImpact_Data;
        ReturnVoid_EventHandle CancelSelectedSubsequentImpact_Data;

        ReturnVoid_EventHandle UpdateAll_View;

        ReturnVoid_EventHandle UpdateAllLabel;



        ReturnVoid_EventHandle UpdateAllEvent_View;

        ReturnVoid_EventHandle UpdateAllEventAndFollowUp_View;

        ReturnVoid_EventHandle UpdateEventList_ListView;
        ReturnVoid_EventHandle UpdateSelectedEvent_View;

        ReturnVoid_EventHandle UpdateSelectedEventAndFollowUp_View;



        ReturnVoid_EventHandle UpdateAllOption_View;

        ReturnVoid_EventHandle UpdateAllOptionAndFollowUp_View;

        ReturnVoid_EventHandle UpdateOptionList_ListView;
        ReturnVoid_EventHandle UpdateSelectedOption_View;

        ReturnVoid_EventHandle UpdateSelectedOptionAndFollowUp_View;


        ReturnVoid_EventHandle UpdateAllPrerequisite_View;

        ReturnVoid_EventHandle UpdateAllPrerequisiteAndFollowUp_View;

        ReturnVoid_EventHandle UpdatePrerequisiteList_ListView;
        ReturnVoid_EventHandle UpdateSelectedPrerequisite_View;

        ReturnVoid_EventHandle UpdateSelectedPrerequisiteAndFollowUp_View;

        ReturnVoid_EventHandle UpdateAllSubsequent_View;

        ReturnVoid_EventHandle UpdateAllSubsequentAndFollowUp_View;

        ReturnVoid_EventHandle UpdateSubsequentList_ListView;
        ReturnVoid_EventHandle UpdateSelectedSubsequent_View;

        ReturnVoid_EventHandle UpdateSelectedSubsequentAndFollowUp_View;

        ReturnVoid_EventHandle UpdateAllSubsequentImpact_View;

        ReturnVoid_EventHandle UpdateSubsequentImpactList_ListView;
        ReturnVoid_EventHandle UpdateSelectedSubsequentImpact_View;


        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            #region UpdateAllLabel



            #endregion


            #region UpdateAllLabel



            #endregion

            UpdateSelectedEvent_Data += UpdateData_UpdateSelectedEventData;
            CancelSelectedEvent_Data += UpdateData_CancelSelectedEventData;

            UpdateSelectedOption_Data += UpdateData_UpdateSelectedOptionData;
            CancelSelectedOption_Data += UpdateData_CancelSelectedOptionData;

            UpdateSelectedPrerequisite_Data += UpdateData_UpdateSelectedPrerequisiteData;
            CancelSelectedPrerequisite_Data += UpdateData_CancelSelectedPrerequisiteData;

            UpdateSelectedSubsequent_Data += UpdateData_UpdateSelectedSubsequentData;
            CancelSelectedSubsequent_Data += UpdateData_CancelSelectedSubsequentData;

            UpdateSelectedSubsequentImpact_Data += UpdateData_UpdateSelectedSubsequentImpactData;
            CancelSelectedSubsequentImpact_Data += UpdateData_CancelSelectedSubsequentImpactData;
            ////


            UpdatePrerequisiteList_ListView += UpdateView_UpdatePrerequisiteList_ListView;

            UpdateSelectedPrerequisite_View += UpdateView_UpdateSelectedPrerequisite_Label;
            UpdateSelectedPrerequisite_View += UpdateView_UpdateSelectedPrerequisite_TextBoxAndRadioButton;

            UpdateAllPrerequisite_View += UpdatePrerequisiteList_ListView;
            UpdateAllPrerequisite_View += UpdateSelectedPrerequisite_View;

            ////

            UpdateOptionList_ListView += UpdateView_UpdateOptionList_ListView;

            UpdateSelectedOption_View += UpdateView_UpdateSelectedOption_Label;
            UpdateSelectedOption_View += UpdateView_UpdateSelectedOption_TextBoxAndCheckBox;


            UpdateAllOption_View += UpdateOptionList_ListView;
            UpdateAllOption_View += UpdateSelectedOption_View;

            ////


            UpdateEventList_ListView += UpdateView_UpdateEventList_ListView;

            UpdateSelectedEvent_View += UpdateView_UpdateSelectedEvent_Label;
            UpdateSelectedEvent_View += UpdateView_UpdateSelectedEvent_TextBox;


            UpdateAllEvent_View += UpdateEventList_ListView;
            UpdateAllEvent_View += UpdateSelectedEvent_View;


            ////

            UpdateSubsequentList_ListView += UpdateView_UpdateSubsequentList_ListView;

            UpdateSelectedSubsequent_View += UpdateView_UpdateSelectedSubsequent_Label;
            UpdateSelectedSubsequent_View += UpdateView_UpdateSelectedSubsequent_TextBox;


            UpdateAllSubsequent_View += UpdateSubsequentList_ListView;
            UpdateAllSubsequent_View += UpdateSelectedSubsequent_View;


            ///

            UpdateSubsequentImpactList_ListView += UpdateView_UpdateSubsequentImpactList_ListView;

            UpdateSelectedSubsequentImpact_View += UpdateView_UpdateSelectedSubsequentImpact_Label;
            UpdateSelectedSubsequentImpact_View += UpdateView_UpdateSelectedSubsequentImpact_TextBoxAndRadioButton;


            UpdateAllSubsequentImpact_View += UpdateSubsequentImpactList_ListView;
            UpdateAllSubsequentImpact_View += UpdateSelectedSubsequentImpact_View;


            ///

            UpdateSelectedSubsequentAndFollowUp_View += UpdateSelectedSubsequent_View;
            UpdateSelectedSubsequentAndFollowUp_View += UpdateAllSubsequentImpact_View;

            UpdateAllSubsequentAndFollowUp_View += UpdateAllSubsequent_View;
            UpdateAllSubsequentAndFollowUp_View += UpdateAllSubsequentImpact_View;

            UpdateSelectedOptionAndFollowUp_View += UpdateSelectedOption_View;
            UpdateSelectedOptionAndFollowUp_View += UpdateAllPrerequisite_View;
            UpdateSelectedOptionAndFollowUp_View += UpdateAllSubsequentImpact_View;
            UpdateSelectedOptionAndFollowUp_View += UpdateAllSubsequent_View;

            UpdateAllOptionAndFollowUp_View += UpdateAllOption_View;
            UpdateAllOptionAndFollowUp_View += UpdateAllPrerequisite_View;
            UpdateAllOptionAndFollowUp_View += UpdateAllSubsequentImpact_View;
            UpdateAllOptionAndFollowUp_View += UpdateAllSubsequent_View;
            //UpdateAllOptionAndFollowUp_View += UpdateAllSubsequent_View;

            UpdateSelectedEventAndFollowUp_View += UpdateSelectedEvent_View;
            UpdateSelectedEventAndFollowUp_View += UpdateAllOption_View;
            UpdateSelectedEventAndFollowUp_View += UpdateAllPrerequisite_View;
            UpdateSelectedEventAndFollowUp_View += UpdateAllSubsequentImpact_View;
            UpdateSelectedEventAndFollowUp_View += UpdateAllSubsequent_View;


            UpdateAllEventAndFollowUp_View += UpdateAllEvent_View;
            UpdateAllEventAndFollowUp_View += UpdateAllOption_View;
            UpdateAllEventAndFollowUp_View += UpdateAllPrerequisite_View;
            UpdateAllEventAndFollowUp_View += UpdateAllSubsequentImpact_View;
            UpdateAllEventAndFollowUp_View += UpdateAllSubsequent_View;


            UpdateAll_View += UpdateAllEvent_View;
            UpdateAll_View += UpdateAllOption_View;
            UpdateAll_View += UpdateAllPrerequisite_View;
            UpdateAll_View += UpdateAllSubsequent_View;
            UpdateAll_View += UpdateAllSubsequentImpact_View;
            ////

            CancelSelectedEventAndFollowUp_Data += CancelSelectedEvent_Data;
            CancelSelectedEventAndFollowUp_Data += CancelSelectedOption_Data;
            CancelSelectedEventAndFollowUp_Data += CancelSelectedPrerequisite_Data;
            CancelSelectedEventAndFollowUp_Data += CancelSelectedSubsequent_Data;
            CancelSelectedEventAndFollowUp_Data += CancelSelectedSubsequentImpact_Data;

            CancelSelectedOptionAndFollowUp_Data += CancelSelectedOption_Data;
            CancelSelectedOptionAndFollowUp_Data += CancelSelectedPrerequisite_Data;
            CancelSelectedOptionAndFollowUp_Data += CancelSelectedSubsequent_Data;
            CancelSelectedOptionAndFollowUp_Data += CancelSelectedSubsequentImpact_Data;

            CancelSelectedPrerequisiteAndFollowUp_Data += CancelSelectedPrerequisite_Data;

            CancelSelectedSubsequentAndFollowUp_Data += CancelSelectedSubsequent_Data;
            CancelSelectedSubsequentAndFollowUp_Data += CancelSelectedSubsequentImpact_Data;
            /*
                         CancelSelectedEventAndFollowUp_Data;

             CancelSelectedEventAndFollowUp_Data;

             CancelSelectedOption_Data;

            CancelSelectedOptionAndFollowUp_Data;

             UpdateSelectedPrerequisite_Data;
             CancelSelectedPrerequisite_Data;

             CancelSelectedPrerequisiteAndFollowUp_Data;

             UpdateSelectedSubsequent_Data;
             CancelSelectedSubsequent_Data;

             CancelSelectedSubsequentAndFollowUp_Data;
             */


            ///











            UpdateAll_View?.Invoke();
        }


        #region  OpenFileAndSaveFile


        private void OpenFolderFile_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = folderBrowserDialog.SelectedPath;  //selected folder path
                FilePath_textBox.Text = folder;
            }
        }

        private void OpenEventListJsonFile_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDailog = new OpenFileDialog();

            //openDailog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            openDailog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";

            if (openDailog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileFullPath=openDailog.FileName;
                string filePath = Path.GetDirectoryName(fileFullPath);
                string fileName = Path.GetFileNameWithoutExtension(fileFullPath);


                FilePath_textBox.Text = filePath;
                FileName_textBox.Text = fileName;

                eventDatas = JsonManager.LoadJsonStringToObject<List<EventData>>(SaveAndLoadManager.LoadFileToText(fileFullPath));
                UpdateView_UpdateEventList_ListView();
            }
        }

        private void SaveEventListDataInFile_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePath_textBox.Text))
            {
                Debug("Error! SaveEventListDataInFile_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(FilePath_textBox.Text)");
                return;
            }
            if (SaveAndLoadManager.IfExistFolderInPath(FilePath_textBox.Text) == false)
            {
                Debug("Error! SaveEventListDataInFile_button_Click(object sender, EventArgs e) (SaveAndLoadManager.IfExistFolderInPath(FilePath_textBox.Text)==false) ");
                return;
            }
            if (string.IsNullOrEmpty(FileName_textBox.Text))
            {
                Debug("Error! SaveEventListDataInFile_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(FileName_textBox.Text)");
                return;
            }
            string jsonstring = JsonManager.LoadObjectToJsonString(eventDatas);

            if (string.IsNullOrEmpty(jsonstring))
            {
                Debug("Error! SaveEventListDataInFile_button_Click(object sender, EventArgs e) (string.IsNullOrEmpty(jsonstring))  ");
                return;
            }

            SaveAndLoadManager.SaveTextToFile(FilePath_textBox.Text, FileName_textBox.Text + ".json", jsonstring);

        }


        #endregion

        /*
         public ListViewItem GetSelectedEventListViewItem()
{
    if (EventList_listView.SelectedItems.Count > 0)
    {
        return EventList_listView.SelectedItems[0];
    }
    else
    {
        Debug("GetSelectedEventListViewItem()无法返回值  EventList_listView.SelectedItems.Count > 0 请选择事件列表中的事件");
        return null;
    }
}
 */
        #region  EventData

        #region  EventData_Data
        public void AddNewEventData(EventData newEventData)
        {
            eventDatas.Add(newEventData);
        }
        public void RemoveEventData(EventData removedEventData)
        {
            if (eventDatas == null || eventDatas.Count == 0)
            {
                Console.WriteLine("Error! RemoveEventData() eventDatas == null || eventDatas.Count == 0");
            }
            else
            {
                if (eventDatas.Contains(removedEventData))
                {
                    eventDatas.Remove(removedEventData);
                }
                else
                {
                    Console.WriteLine("Error! RemoveEventData() eventDatas.Contains(removedEventData)==false");

                }
            }
        }
        public void RemoveEventData(object removedEventData)
        {
            if (removedEventData != null && removedEventData is EventData)
            {
                RemoveEventData(removedEventData as EventData);
            }
            else
            {
                Console.WriteLine("Error! RemoveEventData(object removedEventData) (removedEventData != null && removedEventData is EventData)==false");
            }
        }

        public bool TryGetSelectedEventDataAndListViewItemFromNowView(out EventData eventData, out ListViewItem listViewItem) 
        {
            if (EventList_listView.SelectedItems.Count == 0 ||
                EventList_listView.SelectedItems[0] == null ||
                EventList_listView.SelectedItems[0].Tag is EventData == false
                )
            {
                eventData = null;
                listViewItem = null;
                return false;
            }
            else 
            {
                eventData = EventList_listView.SelectedItems[0].Tag as EventData;
                listViewItem = EventList_listView.SelectedItems[0];
                return true;
            }
        }

        public bool IfHaveSelectedEventData()
        {
            return ifSelectedEvent;
        }
        public EventData GetSelectedEventData()
        {
            if (IfHaveSelectedEventData() == true) return eventData_SelectedEvent; else return null;
        }
        public ListViewItem GetSelectedEventListViewItem()
        {
            if (IfHaveSelectedEventData() == true) return listView_SelectedEventListItem; else return null;
        }
        public void UpdateData_UpdateSelectedEventData()
        {
            if (TryGetSelectedEventDataAndListViewItemFromNowView(out EventData get_eventData, out ListViewItem get_listViewItem) == true)
            {
                ifSelectedEvent = true;
                listView_SelectedEventListItem = get_listViewItem;
                eventData_SelectedEvent=get_eventData;
            }
            else 
            {
                ifSelectedEvent = false;
            }
        }
        public void UpdateData_CancelSelectedEventData() 
        {
            ifSelectedEvent = false;
        }

        #endregion


        #region  EventData_View
        public void AddNewEventListViewItem(EventData eventData)
        {
            string name_ListViewItem;
            if (string.IsNullOrEmpty(eventData.EventName))
            {
                name_ListViewItem = "无名的事件";
            }
            else
            {
                name_ListViewItem = eventData.EventName;

            }
            ListViewItem listViewItem = new ListViewItem(name_ListViewItem);
            listViewItem.Tag = eventData;

            EventList_listView.Items.Add(listViewItem);

        }
        public void RemoveSelectedEventListViewItem()
        {
            if (EventList_listView.SelectedItems.Count > 0)
            {
                EventList_listView.Items.Remove(EventList_listView.SelectedItems[0]);
            }
            else
            {
                Debug("请选择事件列表中的事件");
            }
        }

        public void ClearEventList()
        {
            EventList_listView.Items.Clear();
        }
        public void ChangeEventName_TextBox(string name)
        {
            EventName_textBox.Text = name;

        }
        public void ChangeEventText_TextBox(string text)
        {
            //EventText_textBox
            EventText_textBox.Text = text;
        }



        public void UpdateView_UpdateEventList(List<EventData> eventDatas)
        {
            ClearEventList();
            if (eventDatas == null || eventDatas.Count == 0)
            {
                Debug("UpdateEventList函数传入的eventDatas为空");
            }
            else
            {
                foreach (EventData eventData in eventDatas)
                {
                    AddNewEventListViewItem(eventData);
                }
            }
        }
        public void UpdateView_UpdateEventList_ListView()
        {
            if (eventDatas == null || eventDatas.Count == 0)
            {
                Debug("事件列表为空");

            }
            UpdateView_UpdateEventList(eventDatas);
        }
        public void UpdateView_UpdateSelectedEvent_Label()
        {

            if (ifSelectedEvent == false)
            {
                SelectedEvent_label.Text = "选择的事件: \n \n空";
            }
            else
            {
                SelectedEvent_label.Text = $"选择的事件: \n事件ID;{eventData_SelectedEvent.EventId} \n事件名;{eventData_SelectedEvent.EventName}";
            }
        }
        public void UpdateView_UpdateSelectedEvent_TextBox() 
        {
            //Update——EventNameTextBox
            //Update——EventNameTextBox

            EventData get_eventData = GetSelectedEventData();

            if (get_eventData == null) 
            {
                EventText_textBox.ReadOnly = true;
                EventName_textBox.ReadOnly= true;

                EventText_textBox.Text= string.Empty;
                EventName_textBox.Text = string.Empty;

            }
            else 
            {
                EventText_textBox.ReadOnly = false;
                EventName_textBox.ReadOnly = false;

                EventText_textBox.Text = get_eventData.EventText;
                EventName_textBox.Text = get_eventData.EventName;

            }
        }

        /*
                 public void UpdateEventNameTextBox(EventData eventData) 
        {
        }
        public void UpdateEventNameTextBox()
        {
            ListViewItem selectedListViewItem = GetSelectedEventListViewItem();

            if (selectedListViewItem != null)
            {
                if (selectedListViewItem.Tag != null && selectedListViewItem.Tag is EventData)
                {
                    UpdateEventNameTextBox(selectedListViewItem.Tag as EventData);
                }
                else
                {
                    Debug("Error!  UpdateEventName() (selectedListViewItem.Tag != null && selectedListViewItem.Tag is EventData)==false");
                }
            }
            else 
            {
                Debug("Error!  UpdateEventName() (selectedListViewItem != null)==false");
            }
        }
        public void UpdateEventTextTextBox(EventData eventData)
        {
            if (eventDatas == null || eventDatas.Count == 0)
            {
                Debug("Error!  UpdateEventText(EventData eventData)传入eventData为空");
            }
            else
            {
                if (string.IsNullOrEmpty(eventData.EventText)==true)
                {
                    Debug("UpdateEventText传入eventData.EventName为空");
                }
                else
                {
                    ChangeEventText_TextBox(eventData.EventText);
                }
            }
        }
        public void UpdateEventTextTextBox()
        {
            ListViewItem selectedListViewItem = GetSelectedEventListViewItem();

            if (selectedListViewItem != null)
            {
                if (selectedListViewItem.Tag != null && selectedListViewItem.Tag is EventData)
                {
                    UpdateEventTextTextBox(selectedListViewItem.Tag as EventData);
                }
                else
                {
                    Debug("Error!  UpdateEventName() (selectedListViewItem.Tag != null && selectedListViewItem.Tag is EventData)==false");
                }
            }
            else
            {
                Debug("Error!  UpdateEventName() (selectedListViewItem != null)==false");
            }
        }
         */



        #endregion



        #region  EventList_EventHandler

        private void EventList_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EventList_listView_SelectedIndexChanged当选择选项后，选项变化才会触发
            //GetSelectedEventListViewItem();记住,当EventList_listView_SelectedIndexChanged事件发生时，SelectedItems为空GetSelectedEventListViewItem无法返回值
        }
        private void EventList_listView_Click(object sender, EventArgs e)
        {
            CancelSelectedEventAndFollowUp_Data?.Invoke();
            UpdateSelectedEvent_Data?.Invoke();
            UpdateSelectedEventAndFollowUp_View?.Invoke();

            //Debug("EventList_listView_Click(object sender, EventArgs e)");
        }
        private void RemoveEventData_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedEventData() != null) 
            {
                 RemoveEventData(GetSelectedEventData());
            }
            else 
            {
                Debug("Error! RemoveEventData_button_Click(object sender, EventArgs e) selectedListViewItem == null");
                return;
            }


            CancelSelectedEventAndFollowUp_Data?.Invoke();
            UpdateAllEventAndFollowUp_View?.Invoke();
            CancelSelectedEventAndFollowUp_Data?.Invoke();
            UpdateAllEventAndFollowUp_View?.Invoke();

        }

        private void AddNewEventData_button_Click(object sender, EventArgs e)
        { 
            EventData neweventdata = new EventData();
            neweventdata.EventName= neweventdata.EventName+index_createEvent.ToString();
            index_createEvent++;
            //Debug($"Create New EventData EventName:{neweventdata.EventName}  EventText:{neweventdata.EventText}");
            AddNewEventData(neweventdata);


            UpdateAllEventAndFollowUp_View?.Invoke();

        }

        private void ChangeEventDataName_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedEventData() == null||GetSelectedEventListViewItem()==null)
            {
                Debug("Error! ChangeEventDataName_button_Click(object sender, EventArgs e) selectedListViewItem == null");
                return;
            }
            if (string.IsNullOrEmpty(EventName_textBox.Text) == true)
            {
                Debug("Error! ChangeEventDataName_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(EventName_textBox.Text)==false");
                return;
            }
            GetSelectedEventData().EventName = EventName_textBox.Text;
            GetSelectedEventListViewItem().Text = EventName_textBox.Text;
            Debug($"{GetSelectedEventListViewItem().Text}+{EventName_textBox.Text}");

            GetSelectedEventListViewItem().Name = EventName_textBox.Text;

            // UpdateSelectedEvent_View?.Invoke();  BUG无法及时更新ListView上的内容
            UpdateSelectedEventAndFollowUp_View?.Invoke();

        }
        private void ChangeAndSaveEventText_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedEventData() == null || GetSelectedEventListViewItem() == null)
            {
                Debug("Error! ChangeEventDataName_button_Click(object sender, EventArgs e) selectedListViewItem == null");
                return;
            }
            if (string.IsNullOrEmpty(EventText_textBox.Text) == true)
            {
                Debug("Error! ChangeEventDataName_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(EventName_textBox.Text)==false");
                return;
            }
            GetSelectedEventData().EventText = EventText_textBox.Text;

            //UpdateSelectedEvent_View?.Invoke();
        }

        private void SearchEvent_button_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion


        #region  OptionData


        #region  OptionData_Data
        public bool IfHaveSelectedOptionList() 
        {
            if (IfHaveSelectedEventData() == true && GetSelectedEventData().Options != null && GetSelectedEventData().Options.Count > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public List<OptionData> GetSelectedOptionList() 
        {
            if (IfHaveSelectedOptionList() == true)
            {
                return GetSelectedEventData().Options;
            }
            else 
            {
                return null;
            }
        }
        public void AddNewOptionData(OptionData newOptionData)
        {
            if (GetSelectedEventData() == null)
            {
                Debug("没有选中的事件数据，无法添加选项数据");
                return;
            }

            GetSelectedEventData().Options.Add(newOptionData);

        }
        public void RemoveOptionData(OptionData removedOptionData)
        {
            if (GetSelectedEventData() == null)
            {
                Debug("没有选中的事件数据，无法减去选项数据");
                return;
            }
            if (GetSelectedEventData().Options == null || GetSelectedEventData().Options.Count == 0)
            {
                Debug("选中的事件数据的选项数据列表为空，无法减去选项数据");
                return;
            }
            GetSelectedEventData().Options.Remove(removedOptionData);

        }

        public bool TryGetSelectedOptionDataAndListViewItemFromNowView(out OptionData optionData, out ListViewItem listViewItem) 
        {
            if (IfHaveSelectedEventData() == false ||
                OptionList_listView.SelectedItems.Count == 0 ||
                OptionList_listView.SelectedItems[0] == null ||
                OptionList_listView.SelectedItems[0].Tag is OptionData == false
                )
            {
                optionData = null;
                listViewItem = null;
                return false;
            }
            else
            {
                optionData = OptionList_listView.SelectedItems[0].Tag as OptionData;
                listViewItem = OptionList_listView.SelectedItems[0];
                return true;
            }
        }
        public bool IfHaveSelectedOptionData()
        {
            return ifSelectedOption;
        }
        public OptionData GetSelectedOptionData()
        {
            if (IfHaveSelectedOptionData() == true) return optionData_SelectedOption; else return null;
        }
        public ListViewItem GetSelectedOptionListViewItem()
        {
            if (IfHaveSelectedOptionData() == true) return listView_SelectedOptionListItem; else return null;
        }
        public void UpdateData_UpdateSelectedOptionData()
        {
            if (TryGetSelectedOptionDataAndListViewItemFromNowView(out OptionData get_optionData, out ListViewItem get_listViewItem))
            {
                ifSelectedOption = true;
                listView_SelectedOptionListItem = get_listViewItem;
                optionData_SelectedOption = get_optionData;
            }
            else 
            {
                ifSelectedOption = false;
            }
        }
        public void UpdateData_CancelSelectedOptionData() 
        {
            ifSelectedOption = false;
        }

        #endregion

        #region  OptionData_View
        public void AddNewOptionListViewItem(OptionData optionData)
        {
            string name_ListViewItem;
            if (string.IsNullOrEmpty(optionData.OptionName))
            {
                name_ListViewItem = "无名的选项";
            }
            else
            {
                name_ListViewItem = optionData.OptionName;

            }
            ListViewItem listViewItem = new ListViewItem(name_ListViewItem);
            listViewItem.Tag = optionData;

            OptionList_listView.Items.Add(listViewItem);

        }
        public void RemoveSelectedOptionListViewItem()
        {
            if (OptionList_listView.SelectedItems.Count > 0)
            {
                OptionList_listView.Items.Remove(OptionList_listView.SelectedItems[0]);
            }
            else
            {
                Debug("请选择事件列表中的事件");
            }
        }

        public void ClearOptionList()
        {
            OptionList_listView.Items.Clear();
        }
        public void ChangeOptionName_TextBox(string name)
        {
            OptionName_textBox.Text = name;

        }
        public void ChangeOptionText_TextBox(string text)
        {
            //EventText_textBox  OptionText_textBox
            OptionText_textBox.Text= text;
        }
        public void ChangeOptionIfComfirmText_TextBox(string text)
        {
            //EventText_textBox  OptionText_textBox             IfComfirmText_textBox.Text = text;
            IfComfirmText_textBox.Text=text;
        }

        public void UpdateView_UpdateOptionList_ListView(List<OptionData> optionDatas)
        {
            ClearOptionList();
            if (optionDatas == null || optionDatas.Count == 0)
            {
                Debug("UpdateView_UpdateOptionList_ListView函数传入的optionDatas为空");
            }
            else
            {
                foreach (OptionData optionData in optionDatas)
                {
                    AddNewOptionListViewItem(optionData);
                }
            }
        }
        public void UpdateView_UpdateOptionList_ListView()
        {
            if (IfHaveSelectedOptionList()==false)
            {
                Debug("选项列表为空");
            }
            UpdateView_UpdateOptionList_ListView(GetSelectedOptionList());
        }
        public void UpdateView_UpdateSelectedOption_Label()
        {

            if (ifSelectedOption == false)
            {
                SelectedOption_label.Text = "选择的选项: \n \n空";
            }
            else
            {
                SelectedOption_label.Text = $"选择的选项: \n选项ID;{optionData_SelectedOption.OptionID} \n选项名;{optionData_SelectedOption.OptionName}";
            }
        }
        public void UpdateView_UpdateSelectedOption_TextBoxAndCheckBox()
        {
            //Update——EventNameTextBox
            //Update——EventNameTextBox

            OptionData get_optionData = GetSelectedOptionData();

            if (get_optionData == null)
            {
                OptionName_textBox.ReadOnly = true;
                OptionText_textBox.ReadOnly = true;
                IfComfirmText_textBox.ReadOnly=true;
                IfComfirm_checkBox.AutoCheck = false;

                OptionName_textBox.Text = string.Empty;
                OptionText_textBox.Text = string.Empty;
                IfComfirmText_textBox.Text= string.Empty;
                IfComfirm_checkBox.Checked = false;
            }
            else
            {
                OptionName_textBox.ReadOnly = false;
                OptionText_textBox.ReadOnly = false;
                IfComfirmText_textBox.ReadOnly = false;
                IfComfirm_checkBox.AutoCheck = true;

                OptionName_textBox.Text = get_optionData.OptionName;
                OptionText_textBox.Text=get_optionData.OptionText;
                IfComfirmText_textBox.Text = get_optionData.IfComfirmText;
                IfComfirm_checkBox.Checked = get_optionData.IfComfirm;

                //EventText_textBox.Text = get_eventData.EventText;
                //EventName_textBox.Text = get_eventData.EventName;

            }
        }
        #endregion

        #region  OptionData_EventHandler
        private void OptionList_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void OptionList_listView_Click(object sender, EventArgs e)
        {
            CancelSelectedOptionAndFollowUp_Data?.Invoke();
            UpdateSelectedOption_Data?.Invoke();
            UpdateSelectedOptionAndFollowUp_View?.Invoke();

        }
        private void RemoveOptionData_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedOptionData() != null)
            {
                RemoveOptionData(GetSelectedOptionData());
            }
            else
            {
                Debug("Error! RemoveOptionData_button_Click(object sender, EventArgs e)   (GetSelectedOptionData() != null)");
                return;
            }


            CancelSelectedOptionAndFollowUp_Data?.Invoke();
            UpdateAllOptionAndFollowUp_View?.Invoke();
            CancelSelectedOptionAndFollowUp_Data?.Invoke();
            UpdateAllOptionAndFollowUp_View?.Invoke();
        }
        private void AddNewOptionData_button_Click(object sender, EventArgs e)
        {
            OptionData newoptiondata = new OptionData();
            newoptiondata.OptionName = newoptiondata.OptionName + index_createOption.ToString();
            index_createOption++;
            //Debug($"Create New EventData EventName:{neweventdata.EventName}  EventText:{neweventdata.EventText}");
            AddNewOptionData(newoptiondata);

            UpdateAllOptionAndFollowUp_View?.Invoke();
        }
        private void ChangeAndSaveOptionText_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedOptionData() == null || GetSelectedOptionListViewItem() == null)
            {
                Debug("Error! ChangeAndSaveOptionText_button_Click(object sender, EventArgs e) (GetSelectedOptionData() == null || GetSelectedOptionListViewItem() == null) ");
                return;
            }
            if (string.IsNullOrEmpty(OptionText_textBox.Text) == true)
            {
                Debug("Error! ChangeAndSaveOptionText_button_Click(object sender, EventArgs e)  (string.IsNullOrEmpty(OptionText_textBox.Text) == true) ");
                return;
            }
            GetSelectedOptionData().OptionText = OptionText_textBox.Text;
        }
        private void ChangeAndSaveIfComfirmText_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedOptionData() == null || GetSelectedOptionListViewItem() == null)
            {
                Debug("Error! ChangeAndSaveIfComfirmText_button_Click(object sender, EventArgs e) (GetSelectedOptionData() == null || GetSelectedOptionListViewItem() == null) ");
                return;
            }
            if (string.IsNullOrEmpty(IfComfirmText_textBox.Text) == true)
            {
                Debug("Error! ChangeAndSaveIfComfirmText_button_Click(object sender, EventArgs e)  (string.IsNullOrEmpty(OptionText_textBox.Text) == true) ");
                return;
            }
            GetSelectedOptionData().IfComfirmText = IfComfirmText_textBox.Text;
        }
        private void ChangeOptionName_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedOptionData() == null || GetSelectedOptionListViewItem() == null)
            {
                Debug("Error! ChangeOptionName_button_Click(object sender, EventArgs e) (GetSelectedOptionData() == null || GetSelectedOptionListViewItem() == null)");
                return;
            }
            if (string.IsNullOrEmpty(OptionName_textBox.Text) == true)
            {
                Debug("Error! ChangeOptionName_button_Click(object sender, EventArgs e) (string.IsNullOrEmpty(OptionText_textBox.Text) == true)");
                return;
            }
            GetSelectedOptionData().OptionName = OptionName_textBox.Text;
            GetSelectedOptionListViewItem().Text = OptionName_textBox.Text;
            //Debug($"{GetSelectedEventListViewItem().Text}+{EventName_textBox.Text}");

            GetSelectedOptionListViewItem().Name = OptionName_textBox.Text;

            // UpdateSelectedEvent_View?.Invoke();  BUG无法及时更新ListView上的内容
            UpdateSelectedOptionAndFollowUp_View?.Invoke();
        }
        private void IfComfirm_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GetSelectedOptionData() == null || GetSelectedOptionListViewItem() == null)
            {
                Debug("Error! IfComfirm_checkBox_CheckedChanged(object sender, EventArgs e) (GetSelectedOptionData() == null || GetSelectedOptionListViewItem() == null)");
                return;
            }

            GetSelectedOptionData().IfComfirm = IfComfirm_checkBox.Checked;
        }
        #endregion

        #endregion

        #region  PrerequisiteData

        #region  PrerequisiteData_Data

        public bool IfHaveSelectedPrerequisiteList()
        {
            // if (IfHaveSelectedOptionData() == true && GetSelectedOptionData().Prerequisites != null && GetSelectedOptionData().Prerequisites.Count > 0)
            if (IfHaveSelectedOptionData() == true && GetSelectedOptionData().Prerequisites != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<PrerequisiteData> GetSelectedPrerequisiteList()
        {
            //
            if (IfHaveSelectedOptionData() == true)
            {
                return GetSelectedOptionData().Prerequisites;
            }
            else
            {
                return null;
            }
        }
        public void AddNewPrerequisiteData(PrerequisiteData newPrerequisiteData)
        {
            //
            if (GetSelectedOptionData() == null)
            {
                Debug("没有选中的选项数据，无法添加前置数据");
                return;
            }

            GetSelectedOptionData().Prerequisites.Add(newPrerequisiteData);

        }
        public void RemovePrerequisiteData(PrerequisiteData newPrerequisiteData)
        {
            //
            if (GetSelectedOptionData() == null)
            {
                Debug("没有选中的选项数据，无法添加前置数据");
                return;
            }
            if (GetSelectedOptionData().Prerequisites == null || GetSelectedOptionData().Prerequisites.Count == 0)
            {
                Debug("选中的选项数据的前置数据列表为空，无法减去前置数据");
                return;
            }
            GetSelectedOptionData().Prerequisites.Remove(newPrerequisiteData);

        }
        public bool TryGetSelectedPrerequisiteDataAndListViewItemFromNowView(out PrerequisiteData get_prerequisiteData, out ListViewItem get_listViewItem)
        {
            if (IfHaveSelectedEventData() == false ||
                IfHaveSelectedOptionData() == false ||
                PrerequisiteList_listView.SelectedItems.Count == 0 ||
                PrerequisiteList_listView.SelectedItems[0] == null ||
                PrerequisiteList_listView.SelectedItems[0].Tag is PrerequisiteData == false
                )
            {
                get_listViewItem = null;
                get_prerequisiteData = null;
                return true;
            }
            else 
            {
                get_listViewItem = PrerequisiteList_listView.SelectedItems[0];
                get_prerequisiteData = PrerequisiteList_listView.SelectedItems[0].Tag as PrerequisiteData;
                return true;

            }
        }
        public bool IfHaveSelectedPrerequisiteData()
        {
            //
            return ifSelectedPrerequisite;
        }
        public PrerequisiteData GetSelectedPrerequisiteData()
        {
            //
            if (IfHaveSelectedPrerequisiteData() == true) return prerequisiteData_SelectedPrerequisite; else return null;
        }
        public ListViewItem GetSelectedPrerequisiteListViewItem()
        {
            //

            if (IfHaveSelectedPrerequisiteData() == true) return listView_SelectedPrerequisiteListItem; else return null;
        }
        public void UpdateData_UpdateSelectedPrerequisiteData()
        {            //
            if (TryGetSelectedPrerequisiteDataAndListViewItemFromNowView(out PrerequisiteData get_prerequisiteData, out ListViewItem get_listViewItem))
            {
                ifSelectedPrerequisite = true;
                listView_SelectedPrerequisiteListItem = get_listViewItem;
                prerequisiteData_SelectedPrerequisite = get_prerequisiteData;
            }
            else
            {
                ifSelectedPrerequisite = false;
            }
        }
        public void UpdateData_CancelSelectedPrerequisiteData()
        {            //

            ifSelectedPrerequisite = false;
        }

        #endregion


        #region  PrerequisiteData_View

        public void AddNewPrerequisiteListViewItem(PrerequisiteData prerequisiteData)
        {
            string name_ListViewItem;
            if (string.IsNullOrEmpty(prerequisiteData.PrerequisiteName))
            {
                name_ListViewItem = "无名的前置条件";
            }
            else
            {
                name_ListViewItem = prerequisiteData.ToString();

            }
            ListViewItem listViewItem = new ListViewItem(name_ListViewItem);
            listViewItem.Tag = prerequisiteData;

            PrerequisiteList_listView.Items.Add(listViewItem);

        }
        public void RemoveSelectedPrerequisiteListViewItem()
        {
            if (PrerequisiteList_listView.SelectedItems.Count > 0)
            {
                PrerequisiteList_listView.Items.Remove(PrerequisiteList_listView.SelectedItems[0]);
            }
            else
            {
                Debug("请选择前置条件列表中的前置条件");
            }
        }

        public void ClearPrerequisiteList()
        {
            PrerequisiteList_listView.Items.Clear();
        }
        public void UpdateView_UpdatePrerequisiteList_ListView(List<PrerequisiteData> prerequisiteDatas)
        {
            ClearPrerequisiteList();
            if (prerequisiteDatas == null || prerequisiteDatas.Count == 0)
            {
                Debug("UpdateView_UpdatePrerequisiteList_ListView函数传入的prerequisiteDatas为空");
            }
            else
            {
                foreach (PrerequisiteData prerequisiteData in prerequisiteDatas)
                {
                    AddNewPrerequisiteListViewItem(prerequisiteData);
                }
            }
        }
        public void UpdateView_UpdatePrerequisiteList_ListView()
        {
            if (IfHaveSelectedPrerequisiteList() == false)
            {
                Debug("前置条件列表为空");
            }
            UpdateView_UpdatePrerequisiteList_ListView(GetSelectedPrerequisiteList());
        }

        public void UpdateView_UpdateSelectedPrerequisite_Label()
        {

            if (ifSelectedPrerequisite == false)
            {
                SelectedPrerequisite_label.Text = "选择的前置条件: \n \n空";
            }
            else
            {
                SelectedPrerequisite_label.Text = $"选择的前置条件: \n前置条件ID;{prerequisiteData_SelectedPrerequisite.PrerequisiteID} " +
                    $"\n前置条件名;{prerequisiteData_SelectedPrerequisite.PrerequisiteName}";
            }
        }
        public void UpdateView_UpdateSelectedPrerequisite_TextBoxAndRadioButton()
        {
            //Update——EventNameTextBox
            //Update——EventNameTextBox

            PrerequisiteData get_PrerequisiteData = GetSelectedPrerequisiteData();

            if (get_PrerequisiteData == null)
            {
                PrerequisiteName_textBox.ReadOnly = true;
                EntitiyName_textBox.ReadOnly = true;
                TagOrAttributeName_textBox.ReadOnly = true;

                Bigger_textBox.ReadOnly = true;
                Smaller_textBox.ReadOnly = true;

                PrerequisiteName_textBox.Text = string.Empty;
                EntitiyName_textBox.Text = string.Empty;
                TagOrAttributeName_textBox.Text = string.Empty;

                Bigger_textBox.Text = string.Empty;
                Smaller_textBox.Text = string.Empty;

                SatisfyAll_radioButton.Checked = false;
                SatisfyOne_radioButton.Checked = false;
                ToPlayerCharacter_radioButton.Checked = false;
                ToOtherEntities_radioButton.Checked = false;
                NeedExist_radioButton.Checked = false;
                NeedNotExist_radioButton.Checked = false;

                SatisfyAll_radioButton.AutoCheck = false;
                SatisfyOne_radioButton.AutoCheck = false;
                ToPlayerCharacter_radioButton.AutoCheck = false;
                ToOtherEntities_radioButton.AutoCheck = false;
                NeedExist_radioButton.AutoCheck = false;
                NeedNotExist_radioButton.AutoCheck = false;
            }
            else
            {
                PrerequisiteName_textBox.ReadOnly = false;
                EntitiyName_textBox.ReadOnly = false;
                TagOrAttributeName_textBox.ReadOnly = false;



                PrerequisiteName_textBox.Text = get_PrerequisiteData.PrerequisiteName;
                EntitiyName_textBox.Text = get_PrerequisiteData.EntitiyName_IfPrerequisiteToOtherEntities;
                TagOrAttributeName_textBox.Text = get_PrerequisiteData.TagOrAttributeName;

                SatisfyAll_radioButton.AutoCheck = true;
                SatisfyOne_radioButton.AutoCheck = true;
                ToPlayerCharacter_radioButton.AutoCheck = true;
                ToOtherEntities_radioButton.AutoCheck = true;

                switch (get_PrerequisiteData.TagOrAttribute) 
                {
                    case Prerequisite_TagOrAttribute.Tag: 
                        {
                            Bigger_textBox.Text = string.Empty;
                            Smaller_textBox.Text = string.Empty;

                            Bigger_textBox.ReadOnly = true;
                            Smaller_textBox.ReadOnly = true;

                            NeedExist_radioButton.AutoCheck = true;
                            NeedNotExist_radioButton.AutoCheck = true;

                            switch (get_PrerequisiteData.RequireExistOrNot)
                            {
                                case Prerequisite_RequireExistOrNot.Exist:
                                    {
                                        NeedExist_radioButton.Checked = true;
                                        NeedNotExist_radioButton.Checked = false;
                                    }
                                    break;
                                case Prerequisite_RequireExistOrNot.NotExist:
                                    {
                                        NeedExist_radioButton.Checked = false;
                                        NeedNotExist_radioButton.Checked = true;
                                    }
                                    break;
                            }


                        }
                        break;
                    case Prerequisite_TagOrAttribute.Attribute: 
                        {
                            Bigger_textBox.Text = get_PrerequisiteData.Bigger_IfRequirementAttribute.ToString();
                            Smaller_textBox.Text = get_PrerequisiteData.Smaller_IfRequirementAttribute.ToString();

                            Bigger_textBox.ReadOnly = false;
                            Smaller_textBox.ReadOnly = false;

                            NeedExist_radioButton.AutoCheck = false;
                            NeedNotExist_radioButton.AutoCheck = false;

                            NeedExist_radioButton.Checked = false;
                            NeedNotExist_radioButton.Checked = false;


                        }
                        break;

                }

                switch (get_PrerequisiteData.RequireEntitiyType) 
                {
                    case Prerequisite_RequireEntitiyType.PlayerCharacter:
                        {
                            ToPlayerCharacter_radioButton.Checked = true;
                            ToOtherEntities_radioButton.Checked = false;
                        }
                        break;
                    case Prerequisite_RequireEntitiyType.OtherEntities:
                        {
                            ToPlayerCharacter_radioButton.Checked = false;
                            ToOtherEntities_radioButton.Checked = true;
                        }
                        break;
                }
                switch (get_PrerequisiteData.SatisfyAllOrOne)
                {
                    case Prerequisite_SatisfyAllOrOne.All:
                        {
                            SatisfyAll_radioButton.Checked = true;
                            SatisfyOne_radioButton.Checked = false;
                        }
                        break;
                    case Prerequisite_SatisfyAllOrOne.One:
                        {
                            SatisfyAll_radioButton.Checked = false;
                            SatisfyOne_radioButton.Checked = true;
                        }
                        break;
                }
                //EventText_textBox.Text = get_eventData.EventText;
                //EventName_textBox.Text = get_eventData.EventName;

            }
        }

        #endregion


        #region  PrerequisiteData_EventHandler
        private void PrerequisiteList_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PrerequisiteList_listView__Click(object sender, EventArgs e)
        {
            UpdateSelectedPrerequisite_Data?.Invoke();
            UpdateSelectedPrerequisite_View?.Invoke();
        }
        private void RemovePrerequisiteData_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedPrerequisiteData() != null)
            {
                RemovePrerequisiteData(GetSelectedPrerequisiteData());
            }
            else
            {
                Debug("Error! RemovePrerequisiteData_button_Click(object sender, EventArgs e)   (GetSelectedPrerequisiteData() != null)");
                return;
            }


            CancelSelectedPrerequisite_Data?.Invoke();
            UpdateAllPrerequisite_View?.Invoke();
            CancelSelectedPrerequisite_Data?.Invoke();
            UpdateAllPrerequisite_View?.Invoke();
        }
        private void AddNewRequirementTag_button_Click(object sender, EventArgs e)
        {
            PrerequisiteData newPrerequisiteData = new PrerequisiteData();
            newPrerequisiteData.PrerequisiteName = newPrerequisiteData.PrerequisiteName + index_createPrerequisite.ToString();
            newPrerequisiteData.TagOrAttribute = Prerequisite_TagOrAttribute.Tag;

            index_createPrerequisite++;
            //Debug($"Create New EventData EventName:{neweventdata.EventName}  EventText:{neweventdata.EventText}");
            AddNewPrerequisiteData(newPrerequisiteData);

            UpdateAllPrerequisite_View?.Invoke();
        }

        private void AddNewRequirementAttribute_button_Click(object sender, EventArgs e)
        {
            PrerequisiteData newPrerequisiteData = new PrerequisiteData();
            newPrerequisiteData.PrerequisiteName = newPrerequisiteData.PrerequisiteName + index_createPrerequisite.ToString();
            newPrerequisiteData.TagOrAttribute = Prerequisite_TagOrAttribute.Attribute;

            index_createPrerequisite++;
            //Debug($"Create New EventData EventName:{neweventdata.EventName}  EventText:{neweventdata.EventText}");
            AddNewPrerequisiteData(newPrerequisiteData);

            UpdateAllPrerequisite_View?.Invoke();
        }
        private void ChangePrerequisiteName_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)
            {
                Debug("Error! ChangePrerequisiteName_button_Click(object sender, EventArgs e) (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)");
                return;
            }
            if (string.IsNullOrEmpty(PrerequisiteName_textBox.Text) == true)
            {
                Debug("Error! ChangePrerequisiteName_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(PrerequisiteName_textBox.Text)==false");
                return;
            }
            GetSelectedPrerequisiteData().PrerequisiteName = PrerequisiteName_textBox.Text;
            GetSelectedPrerequisiteListViewItem().Text = PrerequisiteName_textBox.Text;
            //Debug($"{GetSelectedPrerequisiteListViewItem().Text}+{EventName_textBox.Text}");

            GetSelectedPrerequisiteListViewItem().Name = PrerequisiteName_textBox.Text;

            // UpdateSelectedEvent_View?.Invoke();  BUG无法及时更新ListView上的内容
            UpdatePrerequisiteList_ListView?.Invoke();
        }
        private void ChangeAndSaveEntitiyName_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)
            {
                Debug("Error! ChangeAndSaveEntitiyName_button_Click(object sender, EventArgs e) (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)");
                return;
            }
            if (string.IsNullOrEmpty(EntitiyName_textBox.Text) == true)
            {
                Debug("Error! ChangeAndSaveEntitiyName_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(PrerequisiteName_textBox.Text)==false");
                return;
            }
            GetSelectedPrerequisiteData().EntitiyName_IfPrerequisiteToOtherEntities = EntitiyName_textBox.Text;

            // UpdateSelectedEvent_View?.Invoke();  BUG无法及时更新ListView上的内容
            UpdatePrerequisiteList_ListView?.Invoke();
        }
        private void ChangeAndSaveRequirementTagOrAttributeName_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)
            {
                Debug("Error! ChangeAndSaveRequirementTagOrAttributeName_button_Click(object sender, EventArgs e) (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)");
                return;
            }
            if (string.IsNullOrEmpty(TagOrAttributeName_textBox.Text) == true)
            {
                Debug("Error! ChangeAndSaveRequirementTagOrAttributeName_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(PrerequisiteName_textBox.Text)==false");
                return;
            }
            GetSelectedPrerequisiteData().TagOrAttributeName = TagOrAttributeName_textBox.Text;

            // UpdateSelectedEvent_View?.Invoke();  BUG无法及时更新ListView上的内容
            UpdatePrerequisiteList_ListView?.Invoke();
        }

        private void ChangeAndSaveBigger_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)
            {
                Debug("Error! ChangeAndSaveBigger_button_Click(object sender, EventArgs e) (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)");
                return;
            }
            if (string.IsNullOrEmpty(Bigger_textBox.Text) == true)
            {
                Debug("Error! ChangeAndSaveBigger_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(PrerequisiteName_textBox.Text)==false");
                return;
            }
            if (float.TryParse(Bigger_textBox.Text, out float result)==true)
            {
                GetSelectedPrerequisiteData().Bigger_IfRequirementAttribute = result;

                UpdatePrerequisiteList_ListView?.Invoke();
            }
            else 
            {
                Debug("Error! ChangeAndSaveBigger_button_Click(object sender, EventArgs e) (float.TryParse(Bigger_textBox.Text, out float result))==false");
                return;
            }
        }

        private void ChangeAndSaveSmaller_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)
            {
                Debug("Error! ChangeAndSaveSmaller_button_Click(object sender, EventArgs e) (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)");
                return;
            }
            if (string.IsNullOrEmpty(Smaller_textBox.Text) == true)
            {
                Debug("Error! ChangeAndSaveSmaller_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(PrerequisiteName_textBox.Text)==false");
                return;
            }
            if (float.TryParse(Smaller_textBox.Text, out float result) == true)
            {
                GetSelectedPrerequisiteData().Smaller_IfRequirementAttribute = result;

                UpdatePrerequisiteList_ListView?.Invoke();
            }
            else
            {
                Debug("Error! ChangeAndSaveSmaller_button_Click(object sender, EventArgs e) (float.TryParse(Bigger_textBox.Text, out float result))==false");
                return;
            }
        }
        private void SatisfyAll_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)
            {
                Debug("Error! SatisfyAll_radioButton_CheckedChanged(object sender, EventArgs e) (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)");
                return;
            }

            GetSelectedPrerequisiteData().SatisfyAllOrOne = Prerequisite_SatisfyAllOrOne.All;
            UpdatePrerequisiteList_ListView?.Invoke();

        }

        private void SatisfyOne_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)
            {
                Debug("Error! SatisfyOne_radioButton_CheckedChanged(object sender, EventArgs e) (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)");
                return;
            }

            GetSelectedPrerequisiteData().SatisfyAllOrOne = Prerequisite_SatisfyAllOrOne.One;
            UpdatePrerequisiteList_ListView?.Invoke();
        }

        private void ToPlayerCharacter_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)
            {
                Debug("Error! ToPlayerCharacter_radioButton_CheckedChanged(object sender, EventArgs e) (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)");
                return;
            }

            GetSelectedPrerequisiteData().RequireEntitiyType = Prerequisite_RequireEntitiyType.PlayerCharacter;
            UpdatePrerequisiteList_ListView?.Invoke();
        }

        private void ToOtherEntities_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)
            {
                Debug("Error! ToOtherEntities_radioButton_CheckedChanged(object sender, EventArgs e) (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)");
                return;
            }

            GetSelectedPrerequisiteData().RequireEntitiyType = Prerequisite_RequireEntitiyType.OtherEntities;
            UpdatePrerequisiteList_ListView?.Invoke();
        }

        private void NeedExist_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)
            {
                Debug("Error! NeedExist_radioButton_CheckedChanged(object sender, EventArgs e) (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)");
                return;
            }
        }

        private void NeedNotExist_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)
            {
                Debug("Error! NeedNotExist_radioButton_CheckedChanged(object sender, EventArgs e) (GetSelectedPrerequisiteData() == null || GetSelectedPrerequisiteListViewItem() == null)");
                return;
            }
        }
        #endregion

        #endregion
        /*
             string detailsstring = "";

switch (prerequisiteData.TagOrAttribute) 
{
    case Prerequisite_TagOrAttribute.Tag: 
        {

            detailsstring += $"标签:{prerequisiteData.TagOrAttributeName}";

            switch (prerequisiteData.RequireExistOrNot) 
            {
                case Prerequisite_RequireExistOrNot.Exist: 
                    {
                        detailsstring += "   需要该标签存在";
                    }
                    break;
                case Prerequisite_RequireExistOrNot.NotExist: 
                    {
                        detailsstring += "   需要该标签不存在";
                    }
                    break;
            }
            switch (prerequisiteData.RequireEntitiyType)
            {
                case Prerequisite_RequireEntitiyType.PlayerCharacter: 
                    {
                        detailsstring += "   对主控";
                    } break;
                case Prerequisite_RequireEntitiyType.OtherEntities: 
                    {
                        detailsstring += $"   对{prerequisiteData.EntitiyName_IfPrerequisiteToOtherEntities}";
                    }
                    break;
            }
        }
        break;
    case Prerequisite_TagOrAttribute.Attribute: 
        {


            detailsstring += $"{prerequisiteData.Bigger_IfRequirementAttribute}<=属性:{prerequisiteData.TagOrAttributeName}<={prerequisiteData.Smaller_IfRequirementAttribute}";


            switch (prerequisiteData.RequireEntitiyType)
            {
                case Prerequisite_RequireEntitiyType.PlayerCharacter:
                    {
                        detailsstring += "   对主控";
                    }
                    break;
                case Prerequisite_RequireEntitiyType.OtherEntities:
                    {
                        detailsstring += $"   对{prerequisiteData.EntitiyName_IfPrerequisiteToOtherEntities}";
                    }
                    break;
            }
        }
        break;
}
 */

        #region Subsequent

        #region Subsequent_Data

        public bool IfHaveSelectedSubsequentList()
        {
            //if (IfHaveSelectedOptionData() == true && GetSelectedOptionData().Subsequents != null && GetSelectedOptionData().Subsequents.Count > 0)
            if (IfHaveSelectedOptionData() == true && GetSelectedOptionData().Subsequents != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<SubsequentData> GetSelectedSubsequentList()
        {
            //
            if (IfHaveSelectedSubsequentList() == true)
            {
                return GetSelectedOptionData().Subsequents;
            }
            else
            {
                return null;
            }
        }
        public void AddNewSubsequentData(SubsequentData newSubsequentData)
        {
            //
            if (GetSelectedSubsequentList() == null)
            {
                Debug("没有选中的影响数据，无法添加影响数据");
                return;
            }

            GetSelectedSubsequentList().Add(newSubsequentData);

        }
        public void RemoveSubsequentData(SubsequentData newSubsequentData)
        {
            //
            if (GetSelectedSubsequentList() == null)
            {
                Debug("没有选中的影响数据，无法添加影响数据");
                return;
            }
            if (GetSelectedSubsequentList() == null || GetSelectedSubsequentList().Count == 0)
            {
                Debug("选中的影响数据列表为空，无法减去影响数据");
                return;
            }
            GetSelectedSubsequentList().Remove(newSubsequentData);

        }
        public bool TryGetSelectedSubsequentDataAndListViewItemFromNowView(out SubsequentData subsequentData,out ListViewItem listViewItem) 
        {
            if (IfHaveSelectedEventData() == false ||
                IfHaveSelectedOptionData() == false ||
                SubsequentList_listView.SelectedItems.Count == 0 ||
                SubsequentList_listView.SelectedItems[0] == null ||
                SubsequentList_listView.SelectedItems[0].Tag is SubsequentData == false
                )
            {
                subsequentData = null;
                listViewItem = null;
                return false;
            }
            else 
            {
                subsequentData = SubsequentList_listView.SelectedItems[0].Tag as SubsequentData;
                listViewItem = SubsequentList_listView.SelectedItems[0];
                return true;

            }
        }
        public bool IfHaveSelectedSubsequentData()
        {
            //
            return ifSelectedSubsequent;
        }
        public SubsequentData GetSelectedSubsequentData()
        {
            //
            if (IfHaveSelectedSubsequentData() == true) return subsequentData_SelectedSubsequent; else return null;
        }
        public ListViewItem GetSelectedSubsequentListViewItem()
        {
            //

            if (IfHaveSelectedSubsequentData() == true) return listView_SelectedSubsequentListItem; else return null;
        }
        public void UpdateData_UpdateSelectedSubsequentData()
        {            //
            if (TryGetSelectedSubsequentDataAndListViewItemFromNowView(out SubsequentData get_subsequentData, out ListViewItem get_listViewItem))
            {
                subsequentData_SelectedSubsequent = get_subsequentData;
                listView_SelectedSubsequentListItem = get_listViewItem;
                ifSelectedSubsequent = true;
            }
            else 
            {
                ifSelectedSubsequent = false;
            }
        }
        public void UpdateData_CancelSelectedSubsequentData()
        {            //

            ifSelectedSubsequent = false;
        }


        #endregion

        #region Subsequent_View

        public void AddNewSubsequentListViewItem(SubsequentData subsequentData)
        {
            string name_ListViewItem;
            if (string.IsNullOrEmpty(subsequentData.SubsequentName))
            {
                name_ListViewItem = "无名";
            }
            else
            {
                name_ListViewItem = subsequentData.ToString();

            }
            ListViewItem listViewItem = new ListViewItem(name_ListViewItem);
            listViewItem.Tag = subsequentData;

            SubsequentList_listView.Items.Add(listViewItem);

        }
        public void RemoveSelectedSubsequentListViewItem()
        {
            if (SubsequentList_listView.SelectedItems.Count > 0)
            {
                SubsequentList_listView.Items.Remove(SubsequentList_listView.SelectedItems[0]);
            }
            else
            {
                Debug("请选择事件列表中的事件");
            }
        }
        public void ClearSubsequentList()
        {
            SubsequentList_listView.Items.Clear();
        }
        public void UpdateView_UpdateSubsequentList_ListView(List<SubsequentData> subsequentDatas)
        {
            ClearSubsequentList();
            if (subsequentDatas == null || subsequentDatas.Count == 0)
            {
                Debug("UpdateView_UpdateSubsequentList_ListView函数传入的subsequentDatas为空");
            }
            else
            {
                foreach (SubsequentData subsequentData in subsequentDatas)
                {
                    AddNewSubsequentListViewItem(subsequentData);
                }
            }
        }
        public void UpdateView_UpdateSubsequentList_ListView()
        {
            if (IfHaveSelectedSubsequentList() == false)
            {
                Debug("影响列表为空");
            }
            UpdateView_UpdateSubsequentList_ListView(GetSelectedSubsequentList());
        }
        public void UpdateView_UpdateSelectedSubsequent_Label() 
        {
            if (ifSelectedSubsequent == false)
            {
                SelectedSubsequent_label.Text = "选择的后续结果: \n \n空";
            }
            else
            {
                SelectedSubsequent_label.Text = $"选择的后续结果: \n " +
                    $"\n后续结果名;{subsequentData_SelectedSubsequent.SubsequentName}";
            }
        }
        public void UpdateView_UpdateSelectedSubsequent_TextBox() 
        {
            SubsequentData get_SubsequentData = GetSelectedSubsequentData();

            if (get_SubsequentData == null)
            {
                SubsequentName_textBox.ReadOnly = true;
                SubsequentProbabilityFactor_textBox.ReadOnly = true;
                SubsequentText_textBox.ReadOnly = true;

                SubsequentName_textBox.Text = string.Empty;
                SubsequentProbabilityFactor_textBox.Text = string.Empty;
                SubsequentText_textBox.Text = string.Empty;
            }
            else
            {
                SubsequentName_textBox.ReadOnly = false;
                SubsequentProbabilityFactor_textBox.ReadOnly = false;
                SubsequentText_textBox.ReadOnly = false;

                SubsequentName_textBox.Text = get_SubsequentData.SubsequentName;
                SubsequentProbabilityFactor_textBox.Text = get_SubsequentData.SubsequentProbabilityFactor.ToString();
                SubsequentText_textBox.Text = get_SubsequentData.SubsequentText;

                //EventText_textBox.Text = get_eventData.EventText;
                //EventName_textBox.Text = get_eventData.EventName;

            }
        }


        #endregion

        #region Subsequent_EventHandler


        private void SubsequentList_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SubsequentList_listView_Click(object sender, EventArgs e) 
        {
            CancelSelectedSubsequentAndFollowUp_Data?.Invoke();
            UpdateSelectedSubsequent_Data?.Invoke();
            UpdateSelectedSubsequentAndFollowUp_View?.Invoke();
        }

        private void RemoveSubsequentData_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedSubsequentData() != null)
            {
                RemoveSubsequentData(GetSelectedSubsequentData());
            }
            else
            {
                Debug("Error! RemoveSubsequentData_button_Click(object sender, EventArgs e)   (GetSelectedSubsequentData() != null)");
                return;
            }


            CancelSelectedSubsequentAndFollowUp_Data?.Invoke();
            UpdateAllSubsequentAndFollowUp_View?.Invoke();
            CancelSelectedSubsequentAndFollowUp_Data?.Invoke();
            UpdateAllSubsequentAndFollowUp_View?.Invoke();
        }
        private void AddSubsequentData_button_Click(object sender, EventArgs e)
        {
            SubsequentData newsubsequentData = new SubsequentData();

            newsubsequentData.SubsequentName= newsubsequentData.SubsequentName+ index_createSubsequent.ToString();

            index_createSubsequent++;
            //Debug($"Create New EventData EventName:{neweventdata.EventName}  EventText:{neweventdata.EventText}");
            AddNewSubsequentData(newsubsequentData);

            UpdateAllSubsequentAndFollowUp_View?.Invoke();
        }
        private void ChangeSubsequentName_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedSubsequentData() == null || GetSelectedSubsequentListViewItem() == null)
            {
                Debug("Error! ChangeSubsequentName_button_Click(object sender, EventArgs e)  (GetSelectedSubsequentData() == null || GetSelectedSubsequentListViewItem() == null)");
                return;
            }
            if (string.IsNullOrEmpty(SubsequentName_textBox.Text) == true)
            {
                Debug("Error! ChangeSubsequentName_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(SubsequentName_textBox.Text)==false");
                return;
            }
            GetSelectedSubsequentData().SubsequentName = SubsequentName_textBox.Text;

            UpdateAllSubsequent_View?.Invoke();
        }
        private void ChangeProbabilityFactor_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedSubsequentData() == null || GetSelectedSubsequentListViewItem() == null)
            {
                Debug("Error! ChangeProbabilityFactor_button_Click(object sender, EventArgs e)  (GetSelectedSubsequentData() == null || GetSelectedSubsequentListViewItem() == null)");
                return;
            }
            if (string.IsNullOrEmpty(SubsequentProbabilityFactor_textBox.Text) == true)
            {
                Debug("Error! ChangeProbabilityFactor_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(SubsequentName_textBox.Text)==false");
                return;
            }
            if (float.TryParse(SubsequentProbabilityFactor_textBox.Text, out float result) == true)
            {
                GetSelectedSubsequentData().SubsequentProbabilityFactor = result;

                UpdateAllSubsequent_View?.Invoke();
            }
            else 
            {
                Debug("Error! ChangeProbabilityFactor_button_Click(object sender, EventArgs e) (float.TryParse(SubsequentProbabilityFactor_textBox.Text, out float result) == true)");
                return;
            }

        }
        private void ChangeAndSaveSubsequentText_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedSubsequentData() == null || GetSelectedSubsequentListViewItem() == null)
            {
                Debug("Error! ChangeAndSaveSubsequentText_button_Click(object sender, EventArgs e)  (GetSelectedSubsequentData() == null || GetSelectedSubsequentListViewItem() == null)");
                return;
            }
            if (string.IsNullOrEmpty(SubsequentText_textBox.Text) == true)//SubsequentText_textBox
            {
                Debug("Error! ChangeAndSaveSubsequentText_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(SubsequentText_textBox.Text)==false");
                return;
            }
            GetSelectedSubsequentData().SubsequentText = SubsequentText_textBox.Text;

        }

        #endregion


        #endregion

        #region SubsequentImpact

        #region SubsequentImpact_Data

        public bool IfHaveSelectedSubsequentImpactList()
        {
            //if (IfHaveSelectedOptionData() == true && GetSelectedOptionData().Subsequents != null && GetSelectedOptionData().Subsequents.Count > 0)
            if (IfHaveSelectedSubsequentData() == true && GetSelectedSubsequentData().SubsequentImpacts != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<SubsequentImpactData> GetSelectedSubsequentImpactList()
        {
            //
            if (IfHaveSelectedSubsequentImpactList() == true)
            {
                return GetSelectedSubsequentData().SubsequentImpacts;
            }
            else
            {
                return null;
            }
        }
        public void AddNewSubsequentImpactData(SubsequentImpactData newSubsequentImpactData)
        {
            //
            if (GetSelectedSubsequentImpactList() == null)
            {
                Debug("没有选中的影响列表数据，无法添加影响数据");
                return;
            }

            GetSelectedSubsequentImpactList().Add(newSubsequentImpactData);

        }
        public void RemoveSubsequentImpactData(SubsequentImpactData newSubsequentImpactData)
        {
            //
            if (GetSelectedSubsequentImpactList() == null)
            {
                Debug("没有选中的影响列表数据，无法减去影响数据");
                return;
            }
            if (GetSelectedSubsequentImpactList().Count == 0)
            {
                Debug("选中的影响数据列表为空，无法减去影响数据");
                return;
            }
            GetSelectedSubsequentImpactList().Remove(newSubsequentImpactData);

        }
        public bool TryGetSelectedSubsequentImpactDataAndListViewItemFromNowView(out SubsequentImpactData subsequentImpactData,out ListViewItem listViewItem) 
        {
            if (IfHaveSelectedEventData() == false ||
                IfHaveSelectedOptionData() == false ||
                IfHaveSelectedSubsequentData() == false ||
                SubsequentImpactList_listView.SelectedItems.Count == 0 ||
                SubsequentImpactList_listView.SelectedItems[0] == null ||
                SubsequentImpactList_listView.SelectedItems[0].Tag is SubsequentImpactData == false) 
            {
                listViewItem = null;
                subsequentImpactData = null;
                return false;
            }
            else 
            {
                listViewItem = SubsequentImpactList_listView.SelectedItems[0];
                subsequentImpactData = SubsequentImpactList_listView.SelectedItems[0].Tag as SubsequentImpactData;
                return true;

            }
        }
        public bool IfHaveSelectedSubsequentImpactData()
        {
            //
            return ifSelectedSubsequentImpact;
        }
        public SubsequentImpactData GetSelectedSubsequentImpactData()
        {
            //
            if (IfHaveSelectedSubsequentImpactData() == true) return subsequentImpactData_SelectedSubsequentImpact; else return null;
        }
        public ListViewItem GetSelectedSubsequentImpactListViewItem()
        {
            //

            if (IfHaveSelectedSubsequentImpactData() == true) return listView_SelectedSubsequentImpactListItem; else return null;
        }
        public void UpdateData_UpdateSelectedSubsequentImpactData()
        {            //
            if (TryGetSelectedSubsequentImpactDataAndListViewItemFromNowView(out SubsequentImpactData get_subsequentImpactData, out ListViewItem get_listViewItem))
            {
                listView_SelectedSubsequentImpactListItem = get_listViewItem;
                subsequentImpactData_SelectedSubsequentImpact = get_subsequentImpactData;

                ifSelectedSubsequentImpact = true;
            }
            else 
            {
                ifSelectedSubsequentImpact = false;
            }
        }
        public void UpdateData_CancelSelectedSubsequentImpactData()
        {            //

            ifSelectedSubsequentImpact = false;
        }

        #endregion

        #region SubsequentImpact_View

        public void AddNewSubsequentImpactListViewItem(SubsequentImpactData subsequentImpactData)
        {
            string name_ListViewItem="";



            switch (subsequentImpactData.SubsequentImpactTagOrAttribute)
            {
                case SubsequentImpact_TagOrAttribute.Tag: 
                    {

                        switch (subsequentImpactData.SubsequentImpactEntitiyType)
                        {
                            case SubsequentImpact_ImpactEntitiyType.PlayerCharacter: 
                                {
                                    name_ListViewItem += "对主控";
                                }
                                break;
                            case SubsequentImpact_ImpactEntitiyType.OtherEntities: 
                                {
                                    name_ListViewItem += $"对{subsequentImpactData.EntitiyName_IfSubsequentImpactToOtherEntities}";
                                }
                                break;
                        }

                        switch (subsequentImpactData.AddOrRemoveTag_IfSubsequentImpactTag)
                        {
                            case SubsequentImpact_AddOrRemoveTag.AddTag: 
                                {
                                    name_ListViewItem += $"   添加{subsequentImpactData.TagOrAttributeName}标签";
                                }
                                break;
                            case SubsequentImpact_AddOrRemoveTag.RemoveTag: 
                                {
                                    name_ListViewItem += $"   移除{subsequentImpactData.TagOrAttributeName}标签";
                                }
                                break;
                        }


                    }
                    break;
                case SubsequentImpact_TagOrAttribute.Attribute: 
                    {

                        switch (subsequentImpactData.SubsequentImpactEntitiyType)
                        {
                            case SubsequentImpact_ImpactEntitiyType.PlayerCharacter:
                                {
                                    name_ListViewItem += "对主控";
                                }
                                break;
                            case SubsequentImpact_ImpactEntitiyType.OtherEntities:
                                {
                                    name_ListViewItem += $"对{subsequentImpactData.EntitiyName_IfSubsequentImpactToOtherEntities}";
                                }
                                break;
                        }

                        name_ListViewItem += $"   对{subsequentImpactData.TagOrAttributeName}属性 {subsequentImpactData.ImpactAttributeValue_IfSubsequentImpactAttribute}";

                    }
                    break;

            }

            ListViewItem listViewItem = new ListViewItem(name_ListViewItem);


            listViewItem.Tag = subsequentImpactData;

            SubsequentImpactList_listView.Items.Add(listViewItem);

        }
        public void RemoveSelectedSubsequentImpactListViewItem()
        {
            if (SubsequentImpactList_listView.SelectedItems.Count > 0)
            {
                SubsequentImpactList_listView.Items.Remove(SubsequentImpactList_listView.SelectedItems[0]);
            }
            else
            {
                Debug("请选择影响列表中的影响");
            }
        }
        public void ClearSubsequentImpactList()
        {
            SubsequentImpactList_listView.Items.Clear();
        }
        public void UpdateView_UpdateSubsequentImpactList_ListView(List<SubsequentImpactData> subsequentImpactDatas)
        {
            ClearSubsequentImpactList();
            if (subsequentImpactDatas == null || subsequentImpactDatas.Count == 0)
            {
                Debug("UpdateView_UpdateSubsequentImpactList_ListView函数传入的subsequentImpactDatas为空");
            }
            else
            {
                foreach (SubsequentImpactData subsequentImpactData in subsequentImpactDatas)
                {
                    AddNewSubsequentImpactListViewItem(subsequentImpactData);
                }
            }
        }
        public void UpdateView_UpdateSubsequentImpactList_ListView()
        {
            if (IfHaveSelectedSubsequentImpactList() == false)
            {
                Debug("影响列表为空");
            }
            UpdateView_UpdateSubsequentImpactList_ListView(GetSelectedSubsequentImpactList());
        }
        public void UpdateView_UpdateSelectedSubsequentImpact_Label()
        {
            if (ifSelectedSubsequentImpact == false)
            {
                SelectedSubsequentImpact_label.Text = "选择的影响信息: \n \n空";
            }
            else
            {
                SelectedSubsequentImpact_label.Text = $"选择的影响信息: \n " +
                    $"\n有";
            }
        }
        public void UpdateView_UpdateSelectedSubsequentImpact_TextBoxAndRadioButton()
        {
            SubsequentImpactData get_SubsequentImpactData = GetSelectedSubsequentImpactData();

            if (get_SubsequentImpactData == null)
            {
                SubsequentImpactEntitiyName_textBox.ReadOnly = true;
                SubsequentImpactTagOrAttributeName_textBox.ReadOnly = true;
                ImpactAttributeValue_textBox.ReadOnly = true;

                SubsequentImpactEntitiyName_textBox.Text = string.Empty;
                SubsequentImpactTagOrAttributeName_textBox.Text = string.Empty;
                ImpactAttributeValue_textBox.Text = string.Empty;


                SubsequentImpactPlayerCharacter_radioButton.AutoCheck = false;
                SubsequentImpactOtherEntities_radioButton.AutoCheck = false;

                AddTag_radioButton.AutoCheck = false;
                RemoveTag_radioButton.AutoCheck = false;


                SubsequentImpactPlayerCharacter_radioButton.Checked = false;
                SubsequentImpactOtherEntities_radioButton.Checked = false;

                AddTag_radioButton.Checked = false;
                RemoveTag_radioButton.Checked = false;
            }
            else
            {
                SubsequentImpactEntitiyName_textBox.ReadOnly = false;
                SubsequentImpactTagOrAttributeName_textBox.ReadOnly = false;

                SubsequentImpactEntitiyName_textBox.Text = get_SubsequentImpactData.EntitiyName_IfSubsequentImpactToOtherEntities;
                SubsequentImpactTagOrAttributeName_textBox.Text = get_SubsequentImpactData.TagOrAttributeName;

                SubsequentImpactPlayerCharacter_radioButton.AutoCheck = true;
                SubsequentImpactOtherEntities_radioButton.AutoCheck = true;

                switch (get_SubsequentImpactData.SubsequentImpactEntitiyType)
                {
                    case SubsequentImpact_ImpactEntitiyType.PlayerCharacter:
                        {
                            SubsequentImpactPlayerCharacter_radioButton.Checked = true;
                            SubsequentImpactOtherEntities_radioButton.Checked = false;
                        }
                        break;
                    case SubsequentImpact_ImpactEntitiyType.OtherEntities:
                        {
                            SubsequentImpactPlayerCharacter_radioButton.Checked = false;
                            SubsequentImpactOtherEntities_radioButton.Checked = true;
                        }
                        break;
                }



                switch (get_SubsequentImpactData.SubsequentImpactTagOrAttribute)
                {
                    case SubsequentImpact_TagOrAttribute.Tag:
                        {

                            AddTag_radioButton.AutoCheck = true;
                            RemoveTag_radioButton.AutoCheck = true;

                            ImpactAttributeValue_textBox.ReadOnly = true;

                            switch (get_SubsequentImpactData.AddOrRemoveTag_IfSubsequentImpactTag)
                            {
                                case SubsequentImpact_AddOrRemoveTag.AddTag:
                                    {
                                        AddTag_radioButton.Checked = true;
                                        RemoveTag_radioButton.Checked = false;
                                    }
                                    break;
                                case SubsequentImpact_AddOrRemoveTag.RemoveTag:
                                    {
                                        AddTag_radioButton.Checked = false;
                                        RemoveTag_radioButton.Checked = true;
                                    }
                                    break;
                            }


                        }
                        break;
                    case SubsequentImpact_TagOrAttribute.Attribute:
                        {
                            AddTag_radioButton.AutoCheck = false;
                            RemoveTag_radioButton.AutoCheck = false;

                            ImpactAttributeValue_textBox.ReadOnly = false;


                            ImpactAttributeValue_textBox.Text= get_SubsequentImpactData.ImpactAttributeValue_IfSubsequentImpactAttribute.ToString();
                        }
                        break;

                }
                //EventText_textBox.Text = get_eventData.EventText;
                //EventName_textBox.Text = get_eventData.EventName;

            }
        }

        #endregion

        #region SubsequentImpact_EventHandler

        private void SubsequentImpactList_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SubsequentImpactList_listView_Click(object sender, EventArgs e)
        {
            UpdateSelectedSubsequentImpact_Data?.Invoke();
            UpdateSelectedSubsequentImpact_View?.Invoke();
        }

        private void RemoveSubsequentImpactData_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedSubsequentImpactData() != null)
            {
                RemoveSubsequentImpactData(GetSelectedSubsequentImpactData());
            }
            else
            {
                Debug("Error! RemoveSubsequentImpactData_button_Click(object sender, EventArgs e)   (GetSelectedSubsequentImpactData() == null)");
                return;
            }


            CancelSelectedSubsequentImpact_Data?.Invoke();
            UpdateAllSubsequentImpact_View?.Invoke();
            CancelSelectedSubsequentImpact_Data?.Invoke();
            UpdateAllSubsequentImpact_View?.Invoke();
        }
        private void AddImpactTag_button_Click(object sender, EventArgs e)
        {
            SubsequentImpactData newsubsequentImpactData = new SubsequentImpactData();

            newsubsequentImpactData.SubsequentImpactTagOrAttribute = SubsequentImpact_TagOrAttribute.Tag;

            AddNewSubsequentImpactData(newsubsequentImpactData);

            UpdateAllSubsequentImpact_View?.Invoke();
        }

        private void AddImpactAttribute_button_Click(object sender, EventArgs e)
        {
            SubsequentImpactData newsubsequentImpactData = new SubsequentImpactData();

            newsubsequentImpactData.SubsequentImpactTagOrAttribute = SubsequentImpact_TagOrAttribute.Attribute;

            AddNewSubsequentImpactData(newsubsequentImpactData);

            UpdateAllSubsequentImpact_View?.Invoke();
        }



        private void SubsequentImpactPlayerCharacter_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GetSelectedSubsequentImpactData() == null)
            {
                Debug("Error! SubsequentImpactPlayerCharacter_radioButton_CheckedChanged(object sender, EventArgs e) (GetSelectedSubsequentImpactData() == null)");
                return;
            }

            GetSelectedSubsequentImpactData().SubsequentImpactEntitiyType = SubsequentImpact_ImpactEntitiyType.PlayerCharacter;

            UpdateSubsequentImpactList_ListView?.Invoke();

        }
        private void SubsequentImpactOtherEntities_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GetSelectedSubsequentImpactData() == null)
            {
                Debug("Error! SubsequentImpactOtherEntities_radioButton_CheckedChanged(object sender, EventArgs e) (GetSelectedSubsequentImpactData() == null)");
                return;
            }

            GetSelectedSubsequentImpactData().SubsequentImpactEntitiyType = SubsequentImpact_ImpactEntitiyType.OtherEntities;

            UpdateSubsequentImpactList_ListView?.Invoke();
        }
        private void AddTag_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GetSelectedSubsequentImpactData() == null)
            {
                Debug("Error! AddTag_radioButton_CheckedChanged(object sender, EventArgs e) (GetSelectedSubsequentImpactData() == null)");
                return;
            }

            GetSelectedSubsequentImpactData().AddOrRemoveTag_IfSubsequentImpactTag = SubsequentImpact_AddOrRemoveTag.AddTag;

            UpdateSubsequentImpactList_ListView?.Invoke();
        }
        private void RemoveTag_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GetSelectedSubsequentImpactData() == null)
            {
                Debug("Error! AddTag_radioButton_CheckedChanged(object sender, EventArgs e) (GetSelectedSubsequentImpactData() == null)");
                return;
            }

            GetSelectedSubsequentImpactData().AddOrRemoveTag_IfSubsequentImpactTag = SubsequentImpact_AddOrRemoveTag.RemoveTag;

            UpdateSubsequentImpactList_ListView?.Invoke();
        }



        private void ChangeAndSaveSubsequentImpactEntitiyName__button_Click(object sender, EventArgs e)
        {
            if (GetSelectedSubsequentImpactData() == null)
            {
                Debug("Error! ChangeAndSaveSubsequentImpactEntitiyName__button_Click(object sender, EventArgs e) (GetSelectedSubsequentImpactData() == null)");
                return;
            }
            if (string.IsNullOrEmpty(SubsequentImpactEntitiyName_textBox.Text) == true)
            {
                Debug("Error! ChangeAndSaveSubsequentImpactEntitiyName__button_Click(object sender, EventArgs e) string.IsNullOrEmpty(SubsequentImpactEntitiyName_textBox.Text)==false");
                return;
            }
            GetSelectedSubsequentImpactData().EntitiyName_IfSubsequentImpactToOtherEntities = SubsequentImpactEntitiyName_textBox.Text;

            UpdateSubsequentImpactList_ListView.Invoke();
        }

        private void ChangeAndSaveSubsequentImpactTagOrAttributeName_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedSubsequentImpactData() == null)
            {
                Debug("Error! ChangeAndSaveSubsequentImpactTagOrAttributeName_button_Click(object sender, EventArgs e) (GetSelectedSubsequentImpactData() == null)");
                return;
            }
            if (string.IsNullOrEmpty(SubsequentImpactTagOrAttributeName_textBox.Text) == true)
            {
                Debug("Error! ChangeAndSaveSubsequentImpactTagOrAttributeName_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(SubsequentImpactTagOrAttributeName_textBox.Text)==false");
                return;
            }
            GetSelectedSubsequentImpactData().TagOrAttributeName = SubsequentImpactTagOrAttributeName_textBox.Text;

            UpdateSubsequentImpactList_ListView.Invoke();
        }

        private void ChangeAndSaveImpactAttributeValue_button_Click(object sender, EventArgs e)
        {
            if (GetSelectedSubsequentImpactData() == null)
            {
                Debug("Error! ChangeAndSaveImpactAttributeValue_button_Click(object sender, EventArgs e) (GetSelectedSubsequentImpactData() == null)");
                return;
            }
            if (string.IsNullOrEmpty(ImpactAttributeValue_textBox.Text) == true)
            {
                Debug("Error! ChangeAndSaveImpactAttributeValue_button_Click(object sender, EventArgs e) string.IsNullOrEmpty(ImpactAttributeValue_textBox.Text)==false");
                return;
            }
            if (float.TryParse(ImpactAttributeValue_textBox.Text, out float result) == true)
            {
                GetSelectedSubsequentImpactData().ImpactAttributeValue_IfSubsequentImpactAttribute = result;

                UpdateSubsequentImpactList_ListView?.Invoke();
            }
            else
            {
                Debug("Error! ChangeAndSaveImpactAttributeValue_button_Click(object sender, EventArgs e) (float.TryParse(ImpactAttributeValue_textBox.Text, out float result))==false");
                return;
            }

        }
        #endregion 


        #endregion











        #region  Debug


        public void Debug(string text)
        {
            ListViewItem listViewItem = new ListViewItem(index_Debug.ToString());
            listViewItem.SubItems.Add(text);
            Debug_listView.Items.Add(listViewItem);

            index_Debug += 1;
        }

        private void ClearDebugListView_button_Click(object sender, EventArgs e)
        {
            Debug_listView.Items.Clear();
        }









        #endregion




    }
}
