using System;
using System.Windows.Forms;

namespace Event
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNewEventData_button = new System.Windows.Forms.Button();
            this.EventList_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveEventData_button = new System.Windows.Forms.Button();
            this.ChangeEventDataName_button = new System.Windows.Forms.Button();
            this.OptionList_listView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrerequisiteList_listView = new System.Windows.Forms.ListView();
            this.PrerequisiteDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventName_textBox = new System.Windows.Forms.TextBox();
            this.SubsequentList_listView = new System.Windows.Forms.ListView();
            this.SubsequentDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EntitiyName_textBox = new System.Windows.Forms.TextBox();
            this.SearchEvent_textBox = new System.Windows.Forms.TextBox();
            this.SearchEvent_button = new System.Windows.Forms.Button();
            this.OptionName_textBox = new System.Windows.Forms.TextBox();
            this.ChangeOptionName_button = new System.Windows.Forms.Button();
            this.RemoveOptionData_button = new System.Windows.Forms.Button();
            this.AddNewOptionData_button = new System.Windows.Forms.Button();
            this.RemovePrerequisiteData_button = new System.Windows.Forms.Button();
            this.IfComfirm_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ToPlayerCharacter_radioButton = new System.Windows.Forms.RadioButton();
            this.ToOtherEntities_radioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox = new System.Windows.Forms.GroupBox();
            this.TagOrAttributeName_textBox = new System.Windows.Forms.TextBox();
            this.ChangeAndSaveRequirementTagOrAttributeName_button = new System.Windows.Forms.Button();
            this.AddNewRequirementAttribute_button = new System.Windows.Forms.Button();
            this.AddNewRequirementTag_button = new System.Windows.Forms.Button();
            this.RequirementTagType_groupBox = new System.Windows.Forms.GroupBox();
            this.NeedExist_radioButton = new System.Windows.Forms.RadioButton();
            this.NeedNotExist_radioButton = new System.Windows.Forms.RadioButton();
            this.PrerequisiteSatisfyAllOrOne_groupBox = new System.Windows.Forms.GroupBox();
            this.SatisfyAll_radioButton = new System.Windows.Forms.RadioButton();
            this.SatisfyOne_radioButton = new System.Windows.Forms.RadioButton();
            this.AddImpactTag_button = new System.Windows.Forms.Button();
            this.AddImpactAttribute_button = new System.Windows.Forms.Button();
            this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox = new System.Windows.Forms.GroupBox();
            this.SubsequentImpactPlayerCharacter_radioButton = new System.Windows.Forms.RadioButton();
            this.SubsequentImpactOtherEntities_radioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.RemoveSubsequentData_button = new System.Windows.Forms.Button();
            this.SubsequentImpactEntitiyName_textBox = new System.Windows.Forms.TextBox();
            this.SubsequentName_textBox = new System.Windows.Forms.TextBox();
            this.ChangeSubsequentName_button = new System.Windows.Forms.Button();
            this.AddSubsequentData_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SubsequentProbabilityFactor_textBox = new System.Windows.Forms.TextBox();
            this.ChangeProbabilityFactor_button = new System.Windows.Forms.Button();
            this.SubsequentImpactList_listView = new System.Windows.Forms.ListView();
            this.SubsequentImpactDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddOrRemoveTag_groupBox = new System.Windows.Forms.GroupBox();
            this.AddTag_radioButton = new System.Windows.Forms.RadioButton();
            this.RemoveTag_radioButton = new System.Windows.Forms.RadioButton();
            this.SubsequentImpactTagOrAttributeName_textBox = new System.Windows.Forms.TextBox();
            this.ChangeAndSaveSubsequentImpactTagOrAttributeName_button = new System.Windows.Forms.Button();
            this.ImpactAttributeValue_textBox = new System.Windows.Forms.TextBox();
            this.ChangeAndSaveImpactAttributeValue_button = new System.Windows.Forms.Button();
            this.Bigger_textBox = new System.Windows.Forms.TextBox();
            this.ChangeAndSaveBigger_button = new System.Windows.Forms.Button();
            this.Smaller_textBox = new System.Windows.Forms.TextBox();
            this.ChangeAndSaveSmaller_button = new System.Windows.Forms.Button();
            this.ChangeAndSaveEntitiyName_button = new System.Windows.Forms.Button();
            this.ChangeAndSaveOptionText_button = new System.Windows.Forms.Button();
            this.ChangeAndSaveEventText_button = new System.Windows.Forms.Button();
            this.ChangeAndSaveIfComfirmText_button = new System.Windows.Forms.Button();
            this.ChangeAndSaveSubsequentText_button = new System.Windows.Forms.Button();
            this.ChangeAndSaveSubsequentImpactEntitiyName__button = new System.Windows.Forms.Button();
            this.SaveEventListDataInFile_button = new System.Windows.Forms.Button();
            this.FilePath_textBox = new System.Windows.Forms.TextBox();
            this.OpenFolderFile_button = new System.Windows.Forms.Button();
            this.OpenEventListJsonFile_button = new System.Windows.Forms.Button();
            this.EventText_textBox = new System.Windows.Forms.TextBox();
            this.Debug_listView = new System.Windows.Forms.ListView();
            this.DebugID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DebugText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClearDebugListView_button = new System.Windows.Forms.Button();
            this.SelectedEvent_label = new System.Windows.Forms.Label();
            this.OptionText_textBox = new System.Windows.Forms.TextBox();
            this.IfComfirmText_textBox = new System.Windows.Forms.TextBox();
            this.SelectedOption_label = new System.Windows.Forms.Label();
            this.SelectedPrerequisite_label = new System.Windows.Forms.Label();
            this.ChangePrerequisiteName_button = new System.Windows.Forms.Button();
            this.PrerequisiteName_textBox = new System.Windows.Forms.TextBox();
            this.RemoveSubsequentImpactData_button = new System.Windows.Forms.Button();
            this.SubsequentText_textBox = new System.Windows.Forms.TextBox();
            this.SelectedSubsequent_label = new System.Windows.Forms.Label();
            this.SelectedSubsequentImpact_label = new System.Windows.Forms.Label();
            this.FileName_textBox = new System.Windows.Forms.TextBox();
            this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox.SuspendLayout();
            this.RequirementTagType_groupBox.SuspendLayout();
            this.PrerequisiteSatisfyAllOrOne_groupBox.SuspendLayout();
            this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox.SuspendLayout();
            this.AddOrRemoveTag_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewEventData_button
            // 
            this.AddNewEventData_button.Location = new System.Drawing.Point(118, 65);
            this.AddNewEventData_button.Name = "AddNewEventData_button";
            this.AddNewEventData_button.Size = new System.Drawing.Size(90, 21);
            this.AddNewEventData_button.TabIndex = 0;
            this.AddNewEventData_button.Text = "生成新事件";
            this.AddNewEventData_button.UseVisualStyleBackColor = true;
            this.AddNewEventData_button.Click += new System.EventHandler(this.AddNewEventData_button_Click);
            // 
            // EventList_listView
            // 
            this.EventList_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.EventList_listView.HideSelection = false;
            this.EventList_listView.Location = new System.Drawing.Point(12, 39);
            this.EventList_listView.Name = "EventList_listView";
            this.EventList_listView.Size = new System.Drawing.Size(100, 478);
            this.EventList_listView.TabIndex = 1;
            this.EventList_listView.UseCompatibleStateImageBehavior = false;
            this.EventList_listView.View = System.Windows.Forms.View.Details;
            this.EventList_listView.SelectedIndexChanged += new System.EventHandler(this.EventList_listView_SelectedIndexChanged);
            this.EventList_listView.Click += new System.EventHandler(this.EventList_listView_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EventName";
            this.columnHeader1.Width = 80;
            // 
            // RemoveEventData_button
            // 
            this.RemoveEventData_button.Location = new System.Drawing.Point(118, 38);
            this.RemoveEventData_button.Name = "RemoveEventData_button";
            this.RemoveEventData_button.Size = new System.Drawing.Size(90, 21);
            this.RemoveEventData_button.TabIndex = 3;
            this.RemoveEventData_button.Text = "移除事件";
            this.RemoveEventData_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RemoveEventData_button.UseVisualStyleBackColor = true;
            this.RemoveEventData_button.Click += new System.EventHandler(this.RemoveEventData_button_Click);
            // 
            // ChangeEventDataName_button
            // 
            this.ChangeEventDataName_button.Location = new System.Drawing.Point(118, 92);
            this.ChangeEventDataName_button.Name = "ChangeEventDataName_button";
            this.ChangeEventDataName_button.Size = new System.Drawing.Size(90, 21);
            this.ChangeEventDataName_button.TabIndex = 4;
            this.ChangeEventDataName_button.Text = "修改事件名";
            this.ChangeEventDataName_button.UseVisualStyleBackColor = true;
            this.ChangeEventDataName_button.Click += new System.EventHandler(this.ChangeEventDataName_button_Click);
            // 
            // OptionList_listView
            // 
            this.OptionList_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.OptionList_listView.HideSelection = false;
            this.OptionList_listView.Location = new System.Drawing.Point(319, 39);
            this.OptionList_listView.Name = "OptionList_listView";
            this.OptionList_listView.Size = new System.Drawing.Size(100, 505);
            this.OptionList_listView.TabIndex = 7;
            this.OptionList_listView.UseCompatibleStateImageBehavior = false;
            this.OptionList_listView.View = System.Windows.Forms.View.Details;
            this.OptionList_listView.SelectedIndexChanged += new System.EventHandler(this.OptionList_listView_SelectedIndexChanged);
            this.OptionList_listView.Click += new System.EventHandler(this.OptionList_listView_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "OptionName";
            this.columnHeader2.Width = 80;
            // 
            // PrerequisiteList_listView
            // 
            this.PrerequisiteList_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PrerequisiteDetail});
            this.PrerequisiteList_listView.HideSelection = false;
            this.PrerequisiteList_listView.Location = new System.Drawing.Point(626, 38);
            this.PrerequisiteList_listView.Name = "PrerequisiteList_listView";
            this.PrerequisiteList_listView.Size = new System.Drawing.Size(296, 250);
            this.PrerequisiteList_listView.TabIndex = 8;
            this.PrerequisiteList_listView.UseCompatibleStateImageBehavior = false;
            this.PrerequisiteList_listView.View = System.Windows.Forms.View.Details;
            this.PrerequisiteList_listView.SelectedIndexChanged += new System.EventHandler(this.PrerequisiteList_listView_SelectedIndexChanged);
            this.PrerequisiteList_listView.Click += new System.EventHandler(this.PrerequisiteList_listView__Click);
            // 
            // PrerequisiteDetail
            // 
            this.PrerequisiteDetail.Text = "PrerequisiteDetail";
            this.PrerequisiteDetail.Width = 380;
            // 
            // EventName_textBox
            // 
            this.EventName_textBox.Location = new System.Drawing.Point(214, 93);
            this.EventName_textBox.Name = "EventName_textBox";
            this.EventName_textBox.Size = new System.Drawing.Size(99, 21);
            this.EventName_textBox.TabIndex = 9;
            // 
            // SubsequentList_listView
            // 
            this.SubsequentList_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubsequentDetail});
            this.SubsequentList_listView.HideSelection = false;
            this.SubsequentList_listView.Location = new System.Drawing.Point(626, 321);
            this.SubsequentList_listView.Name = "SubsequentList_listView";
            this.SubsequentList_listView.Size = new System.Drawing.Size(200, 223);
            this.SubsequentList_listView.TabIndex = 11;
            this.SubsequentList_listView.UseCompatibleStateImageBehavior = false;
            this.SubsequentList_listView.View = System.Windows.Forms.View.Details;
            this.SubsequentList_listView.SelectedIndexChanged += new System.EventHandler(this.SubsequentList_listView_SelectedIndexChanged);
            this.SubsequentList_listView.Click += new System.EventHandler(this.SubsequentList_listView_Click);
            // 
            // SubsequentDetail
            // 
            this.SubsequentDetail.Text = "SubsequentDetail";
            this.SubsequentDetail.Width = 240;
            // 
            // EntitiyName_textBox
            // 
            this.EntitiyName_textBox.Location = new System.Drawing.Point(1120, 93);
            this.EntitiyName_textBox.Name = "EntitiyName_textBox";
            this.EntitiyName_textBox.Size = new System.Drawing.Size(100, 21);
            this.EntitiyName_textBox.TabIndex = 13;
            // 
            // SearchEvent_textBox
            // 
            this.SearchEvent_textBox.Location = new System.Drawing.Point(12, 523);
            this.SearchEvent_textBox.Name = "SearchEvent_textBox";
            this.SearchEvent_textBox.ReadOnly = true;
            this.SearchEvent_textBox.Size = new System.Drawing.Size(100, 21);
            this.SearchEvent_textBox.TabIndex = 16;
            // 
            // SearchEvent_button
            // 
            this.SearchEvent_button.Location = new System.Drawing.Point(118, 523);
            this.SearchEvent_button.Name = "SearchEvent_button";
            this.SearchEvent_button.Size = new System.Drawing.Size(90, 21);
            this.SearchEvent_button.TabIndex = 17;
            this.SearchEvent_button.Text = "搜索";
            this.SearchEvent_button.UseVisualStyleBackColor = true;
            this.SearchEvent_button.Click += new System.EventHandler(this.SearchEvent_button_Click);
            // 
            // OptionName_textBox
            // 
            this.OptionName_textBox.Location = new System.Drawing.Point(521, 91);
            this.OptionName_textBox.Name = "OptionName_textBox";
            this.OptionName_textBox.Size = new System.Drawing.Size(99, 21);
            this.OptionName_textBox.TabIndex = 23;
            // 
            // ChangeOptionName_button
            // 
            this.ChangeOptionName_button.Location = new System.Drawing.Point(425, 91);
            this.ChangeOptionName_button.Name = "ChangeOptionName_button";
            this.ChangeOptionName_button.Size = new System.Drawing.Size(90, 21);
            this.ChangeOptionName_button.TabIndex = 21;
            this.ChangeOptionName_button.Text = "修改选项名";
            this.ChangeOptionName_button.UseVisualStyleBackColor = true;
            this.ChangeOptionName_button.Click += new System.EventHandler(this.ChangeOptionName_button_Click);
            // 
            // RemoveOptionData_button
            // 
            this.RemoveOptionData_button.Location = new System.Drawing.Point(425, 39);
            this.RemoveOptionData_button.Name = "RemoveOptionData_button";
            this.RemoveOptionData_button.Size = new System.Drawing.Size(90, 21);
            this.RemoveOptionData_button.TabIndex = 20;
            this.RemoveOptionData_button.Text = "移除选项";
            this.RemoveOptionData_button.UseVisualStyleBackColor = true;
            this.RemoveOptionData_button.Click += new System.EventHandler(this.RemoveOptionData_button_Click);
            // 
            // AddNewOptionData_button
            // 
            this.AddNewOptionData_button.Location = new System.Drawing.Point(425, 64);
            this.AddNewOptionData_button.Name = "AddNewOptionData_button";
            this.AddNewOptionData_button.Size = new System.Drawing.Size(90, 21);
            this.AddNewOptionData_button.TabIndex = 18;
            this.AddNewOptionData_button.Text = "生成新选项";
            this.AddNewOptionData_button.UseVisualStyleBackColor = true;
            this.AddNewOptionData_button.Click += new System.EventHandler(this.AddNewOptionData_button_Click);
            // 
            // RemovePrerequisiteData_button
            // 
            this.RemovePrerequisiteData_button.Location = new System.Drawing.Point(928, 38);
            this.RemovePrerequisiteData_button.Name = "RemovePrerequisiteData_button";
            this.RemovePrerequisiteData_button.Size = new System.Drawing.Size(90, 21);
            this.RemovePrerequisiteData_button.TabIndex = 25;
            this.RemovePrerequisiteData_button.Text = "移除前置要求";
            this.RemovePrerequisiteData_button.UseVisualStyleBackColor = true;
            this.RemovePrerequisiteData_button.Click += new System.EventHandler(this.RemovePrerequisiteData_button_Click);
            // 
            // IfComfirm_checkBox
            // 
            this.IfComfirm_checkBox.AutoSize = true;
            this.IfComfirm_checkBox.Location = new System.Drawing.Point(425, 332);
            this.IfComfirm_checkBox.Name = "IfComfirm_checkBox";
            this.IfComfirm_checkBox.Size = new System.Drawing.Size(96, 16);
            this.IfComfirm_checkBox.TabIndex = 30;
            this.IfComfirm_checkBox.Text = "是否需要确认";
            this.IfComfirm_checkBox.UseVisualStyleBackColor = true;
            this.IfComfirm_checkBox.CheckedChanged += new System.EventHandler(this.IfComfirm_checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "事件文本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 39;
            this.label2.Text = "选项文本";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "确认文本";
            // 
            // ToPlayerCharacter_radioButton
            // 
            this.ToPlayerCharacter_radioButton.AutoSize = true;
            this.ToPlayerCharacter_radioButton.Checked = true;
            this.ToPlayerCharacter_radioButton.Location = new System.Drawing.Point(6, 17);
            this.ToPlayerCharacter_radioButton.Name = "ToPlayerCharacter_radioButton";
            this.ToPlayerCharacter_radioButton.Size = new System.Drawing.Size(119, 16);
            this.ToPlayerCharacter_radioButton.TabIndex = 42;
            this.ToPlayerCharacter_radioButton.TabStop = true;
            this.ToPlayerCharacter_radioButton.Text = "对主控的前置条件";
            this.ToPlayerCharacter_radioButton.UseVisualStyleBackColor = true;
            this.ToPlayerCharacter_radioButton.CheckedChanged += new System.EventHandler(this.ToPlayerCharacter_radioButton_CheckedChanged);
            // 
            // ToOtherEntities_radioButton
            // 
            this.ToOtherEntities_radioButton.AutoSize = true;
            this.ToOtherEntities_radioButton.Location = new System.Drawing.Point(6, 39);
            this.ToOtherEntities_radioButton.Name = "ToOtherEntities_radioButton";
            this.ToOtherEntities_radioButton.Size = new System.Drawing.Size(119, 16);
            this.ToOtherEntities_radioButton.TabIndex = 43;
            this.ToOtherEntities_radioButton.Text = "对实体的前置条件";
            this.ToOtherEntities_radioButton.UseVisualStyleBackColor = true;
            this.ToOtherEntities_radioButton.CheckedChanged += new System.EventHandler(this.ToOtherEntities_radioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1127, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 44;
            this.label4.Text = "要求实体名称";
            // 
            // PrerequisiteToPlayerCharacterOrOtherEntities_groupBox
            // 
            this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox.Controls.Add(this.ToPlayerCharacter_radioButton);
            this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox.Controls.Add(this.ToOtherEntities_radioButton);
            this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox.Location = new System.Drawing.Point(1120, 116);
            this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox.Name = "PrerequisiteToPlayerCharacterOrOtherEntities_groupBox";
            this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox.Size = new System.Drawing.Size(186, 68);
            this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox.TabIndex = 45;
            this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox.TabStop = false;
            this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox.Text = "前置条件要求对象类型";
            // 
            // TagOrAttributeName_textBox
            // 
            this.TagOrAttributeName_textBox.Location = new System.Drawing.Point(1024, 193);
            this.TagOrAttributeName_textBox.Name = "TagOrAttributeName_textBox";
            this.TagOrAttributeName_textBox.Size = new System.Drawing.Size(90, 21);
            this.TagOrAttributeName_textBox.TabIndex = 54;
            // 
            // ChangeAndSaveRequirementTagOrAttributeName_button
            // 
            this.ChangeAndSaveRequirementTagOrAttributeName_button.Location = new System.Drawing.Point(928, 193);
            this.ChangeAndSaveRequirementTagOrAttributeName_button.Name = "ChangeAndSaveRequirementTagOrAttributeName_button";
            this.ChangeAndSaveRequirementTagOrAttributeName_button.Size = new System.Drawing.Size(90, 21);
            this.ChangeAndSaveRequirementTagOrAttributeName_button.TabIndex = 53;
            this.ChangeAndSaveRequirementTagOrAttributeName_button.Text = "修属/Tag名";
            this.ChangeAndSaveRequirementTagOrAttributeName_button.UseVisualStyleBackColor = true;
            this.ChangeAndSaveRequirementTagOrAttributeName_button.Click += new System.EventHandler(this.ChangeAndSaveRequirementTagOrAttributeName_button_Click);
            // 
            // AddNewRequirementAttribute_button
            // 
            this.AddNewRequirementAttribute_button.Location = new System.Drawing.Point(1024, 92);
            this.AddNewRequirementAttribute_button.Name = "AddNewRequirementAttribute_button";
            this.AddNewRequirementAttribute_button.Size = new System.Drawing.Size(90, 21);
            this.AddNewRequirementAttribute_button.TabIndex = 51;
            this.AddNewRequirementAttribute_button.Text = "生成属性要求";
            this.AddNewRequirementAttribute_button.UseVisualStyleBackColor = true;
            this.AddNewRequirementAttribute_button.Click += new System.EventHandler(this.AddNewRequirementAttribute_button_Click);
            // 
            // AddNewRequirementTag_button
            // 
            this.AddNewRequirementTag_button.Location = new System.Drawing.Point(928, 92);
            this.AddNewRequirementTag_button.Name = "AddNewRequirementTag_button";
            this.AddNewRequirementTag_button.Size = new System.Drawing.Size(90, 21);
            this.AddNewRequirementTag_button.TabIndex = 56;
            this.AddNewRequirementTag_button.Text = "生成标签要求";
            this.AddNewRequirementTag_button.UseVisualStyleBackColor = true;
            this.AddNewRequirementTag_button.Click += new System.EventHandler(this.AddNewRequirementTag_button_Click);
            // 
            // RequirementTagType_groupBox
            // 
            this.RequirementTagType_groupBox.Controls.Add(this.NeedExist_radioButton);
            this.RequirementTagType_groupBox.Controls.Add(this.NeedNotExist_radioButton);
            this.RequirementTagType_groupBox.Location = new System.Drawing.Point(928, 220);
            this.RequirementTagType_groupBox.Name = "RequirementTagType_groupBox";
            this.RequirementTagType_groupBox.Size = new System.Drawing.Size(186, 68);
            this.RequirementTagType_groupBox.TabIndex = 70;
            this.RequirementTagType_groupBox.TabStop = false;
            this.RequirementTagType_groupBox.Text = "标签要求类型";
            // 
            // NeedExist_radioButton
            // 
            this.NeedExist_radioButton.AutoSize = true;
            this.NeedExist_radioButton.Checked = true;
            this.NeedExist_radioButton.Location = new System.Drawing.Point(6, 17);
            this.NeedExist_radioButton.Name = "NeedExist_radioButton";
            this.NeedExist_radioButton.Size = new System.Drawing.Size(83, 16);
            this.NeedExist_radioButton.TabIndex = 42;
            this.NeedExist_radioButton.TabStop = true;
            this.NeedExist_radioButton.Text = "存在该标签";
            this.NeedExist_radioButton.UseVisualStyleBackColor = true;
            this.NeedExist_radioButton.CheckedChanged += new System.EventHandler(this.NeedExist_radioButton_CheckedChanged);
            // 
            // NeedNotExist_radioButton
            // 
            this.NeedNotExist_radioButton.AutoSize = true;
            this.NeedNotExist_radioButton.Location = new System.Drawing.Point(6, 39);
            this.NeedNotExist_radioButton.Name = "NeedNotExist_radioButton";
            this.NeedNotExist_radioButton.Size = new System.Drawing.Size(83, 16);
            this.NeedNotExist_radioButton.TabIndex = 43;
            this.NeedNotExist_radioButton.Text = "没有该标签";
            this.NeedNotExist_radioButton.UseVisualStyleBackColor = true;
            this.NeedNotExist_radioButton.CheckedChanged += new System.EventHandler(this.NeedNotExist_radioButton_CheckedChanged);
            // 
            // PrerequisiteSatisfyAllOrOne_groupBox
            // 
            this.PrerequisiteSatisfyAllOrOne_groupBox.Controls.Add(this.SatisfyAll_radioButton);
            this.PrerequisiteSatisfyAllOrOne_groupBox.Controls.Add(this.SatisfyOne_radioButton);
            this.PrerequisiteSatisfyAllOrOne_groupBox.Location = new System.Drawing.Point(928, 116);
            this.PrerequisiteSatisfyAllOrOne_groupBox.Name = "PrerequisiteSatisfyAllOrOne_groupBox";
            this.PrerequisiteSatisfyAllOrOne_groupBox.Size = new System.Drawing.Size(186, 68);
            this.PrerequisiteSatisfyAllOrOne_groupBox.TabIndex = 46;
            this.PrerequisiteSatisfyAllOrOne_groupBox.TabStop = false;
            this.PrerequisiteSatisfyAllOrOne_groupBox.Text = "前置条件满足类型";
            // 
            // SatisfyAll_radioButton
            // 
            this.SatisfyAll_radioButton.AutoSize = true;
            this.SatisfyAll_radioButton.Checked = true;
            this.SatisfyAll_radioButton.Location = new System.Drawing.Point(6, 17);
            this.SatisfyAll_radioButton.Name = "SatisfyAll_radioButton";
            this.SatisfyAll_radioButton.Size = new System.Drawing.Size(71, 16);
            this.SatisfyAll_radioButton.TabIndex = 42;
            this.SatisfyAll_radioButton.TabStop = true;
            this.SatisfyAll_radioButton.Text = "全部满足";
            this.SatisfyAll_radioButton.UseVisualStyleBackColor = true;
            this.SatisfyAll_radioButton.CheckedChanged += new System.EventHandler(this.SatisfyAll_radioButton_CheckedChanged);
            // 
            // SatisfyOne_radioButton
            // 
            this.SatisfyOne_radioButton.AutoSize = true;
            this.SatisfyOne_radioButton.Location = new System.Drawing.Point(6, 39);
            this.SatisfyOne_radioButton.Name = "SatisfyOne_radioButton";
            this.SatisfyOne_radioButton.Size = new System.Drawing.Size(83, 16);
            this.SatisfyOne_radioButton.TabIndex = 43;
            this.SatisfyOne_radioButton.Text = "有一个满足";
            this.SatisfyOne_radioButton.UseVisualStyleBackColor = true;
            this.SatisfyOne_radioButton.CheckedChanged += new System.EventHandler(this.SatisfyOne_radioButton_CheckedChanged);
            // 
            // AddImpactTag_button
            // 
            this.AddImpactTag_button.Location = new System.Drawing.Point(1130, 294);
            this.AddImpactTag_button.Name = "AddImpactTag_button";
            this.AddImpactTag_button.Size = new System.Drawing.Size(90, 21);
            this.AddImpactTag_button.TabIndex = 78;
            this.AddImpactTag_button.Text = "生成影响标签";
            this.AddImpactTag_button.UseVisualStyleBackColor = true;
            this.AddImpactTag_button.Click += new System.EventHandler(this.AddImpactTag_button_Click);
            // 
            // AddImpactAttribute_button
            // 
            this.AddImpactAttribute_button.Location = new System.Drawing.Point(1226, 294);
            this.AddImpactAttribute_button.Name = "AddImpactAttribute_button";
            this.AddImpactAttribute_button.Size = new System.Drawing.Size(90, 21);
            this.AddImpactAttribute_button.TabIndex = 77;
            this.AddImpactAttribute_button.Text = "生成影响属性";
            this.AddImpactAttribute_button.UseVisualStyleBackColor = true;
            this.AddImpactAttribute_button.Click += new System.EventHandler(this.AddImpactAttribute_button_Click);
            // 
            // SubsequentImpactPlayerCharacterOrOtherEntities_groupBox
            // 
            this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox.Controls.Add(this.SubsequentImpactPlayerCharacter_radioButton);
            this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox.Controls.Add(this.SubsequentImpactOtherEntities_radioButton);
            this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox.Location = new System.Drawing.Point(1130, 318);
            this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox.Name = "SubsequentImpactPlayerCharacterOrOtherEntities_groupBox";
            this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox.Size = new System.Drawing.Size(186, 53);
            this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox.TabIndex = 76;
            this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox.TabStop = false;
            this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox.Text = "影响对象类型";
            // 
            // SubsequentImpactPlayerCharacter_radioButton
            // 
            this.SubsequentImpactPlayerCharacter_radioButton.AutoSize = true;
            this.SubsequentImpactPlayerCharacter_radioButton.Checked = true;
            this.SubsequentImpactPlayerCharacter_radioButton.Location = new System.Drawing.Point(6, 17);
            this.SubsequentImpactPlayerCharacter_radioButton.Name = "SubsequentImpactPlayerCharacter_radioButton";
            this.SubsequentImpactPlayerCharacter_radioButton.Size = new System.Drawing.Size(119, 16);
            this.SubsequentImpactPlayerCharacter_radioButton.TabIndex = 42;
            this.SubsequentImpactPlayerCharacter_radioButton.TabStop = true;
            this.SubsequentImpactPlayerCharacter_radioButton.Text = "对主控的后续影响";
            this.SubsequentImpactPlayerCharacter_radioButton.UseVisualStyleBackColor = true;
            this.SubsequentImpactPlayerCharacter_radioButton.CheckedChanged += new System.EventHandler(this.SubsequentImpactPlayerCharacter_radioButton_CheckedChanged);
            // 
            // SubsequentImpactOtherEntities_radioButton
            // 
            this.SubsequentImpactOtherEntities_radioButton.AutoSize = true;
            this.SubsequentImpactOtherEntities_radioButton.Location = new System.Drawing.Point(6, 39);
            this.SubsequentImpactOtherEntities_radioButton.Name = "SubsequentImpactOtherEntities_radioButton";
            this.SubsequentImpactOtherEntities_radioButton.Size = new System.Drawing.Size(119, 16);
            this.SubsequentImpactOtherEntities_radioButton.TabIndex = 43;
            this.SubsequentImpactOtherEntities_radioButton.Text = "对实体的后续影响";
            this.SubsequentImpactOtherEntities_radioButton.UseVisualStyleBackColor = true;
            this.SubsequentImpactOtherEntities_radioButton.CheckedChanged += new System.EventHandler(this.SubsequentImpactOtherEntities_radioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1233, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 75;
            this.label5.Text = "影响实体名称";
            // 
            // RemoveSubsequentData_button
            // 
            this.RemoveSubsequentData_button.Location = new System.Drawing.Point(832, 348);
            this.RemoveSubsequentData_button.Name = "RemoveSubsequentData_button";
            this.RemoveSubsequentData_button.Size = new System.Drawing.Size(90, 21);
            this.RemoveSubsequentData_button.TabIndex = 72;
            this.RemoveSubsequentData_button.Text = "移除后续结果";
            this.RemoveSubsequentData_button.UseVisualStyleBackColor = true;
            this.RemoveSubsequentData_button.Click += new System.EventHandler(this.RemoveSubsequentData_button_Click);
            // 
            // SubsequentImpactEntitiyName_textBox
            // 
            this.SubsequentImpactEntitiyName_textBox.Location = new System.Drawing.Point(1226, 402);
            this.SubsequentImpactEntitiyName_textBox.Name = "SubsequentImpactEntitiyName_textBox";
            this.SubsequentImpactEntitiyName_textBox.Size = new System.Drawing.Size(90, 21);
            this.SubsequentImpactEntitiyName_textBox.TabIndex = 71;
            // 
            // SubsequentName_textBox
            // 
            this.SubsequentName_textBox.Location = new System.Drawing.Point(928, 321);
            this.SubsequentName_textBox.Name = "SubsequentName_textBox";
            this.SubsequentName_textBox.Size = new System.Drawing.Size(90, 21);
            this.SubsequentName_textBox.TabIndex = 84;
            // 
            // ChangeSubsequentName_button
            // 
            this.ChangeSubsequentName_button.Location = new System.Drawing.Point(832, 321);
            this.ChangeSubsequentName_button.Name = "ChangeSubsequentName_button";
            this.ChangeSubsequentName_button.Size = new System.Drawing.Size(90, 21);
            this.ChangeSubsequentName_button.TabIndex = 83;
            this.ChangeSubsequentName_button.Text = "修改结果名称";
            this.ChangeSubsequentName_button.UseVisualStyleBackColor = true;
            this.ChangeSubsequentName_button.Click += new System.EventHandler(this.ChangeSubsequentName_button_Click);
            // 
            // AddSubsequentData_button
            // 
            this.AddSubsequentData_button.Location = new System.Drawing.Point(927, 348);
            this.AddSubsequentData_button.Name = "AddSubsequentData_button";
            this.AddSubsequentData_button.Size = new System.Drawing.Size(90, 21);
            this.AddSubsequentData_button.TabIndex = 85;
            this.AddSubsequentData_button.Text = "生成后续结果";
            this.AddSubsequentData_button.UseVisualStyleBackColor = true;
            this.AddSubsequentData_button.Click += new System.EventHandler(this.AddSubsequentData_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(832, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 91;
            this.label8.Text = "后续结果文本";
            // 
            // SubsequentProbabilityFactor_textBox
            // 
            this.SubsequentProbabilityFactor_textBox.Location = new System.Drawing.Point(928, 294);
            this.SubsequentProbabilityFactor_textBox.Name = "SubsequentProbabilityFactor_textBox";
            this.SubsequentProbabilityFactor_textBox.Size = new System.Drawing.Size(90, 21);
            this.SubsequentProbabilityFactor_textBox.TabIndex = 93;
            // 
            // ChangeProbabilityFactor_button
            // 
            this.ChangeProbabilityFactor_button.Location = new System.Drawing.Point(832, 294);
            this.ChangeProbabilityFactor_button.Name = "ChangeProbabilityFactor_button";
            this.ChangeProbabilityFactor_button.Size = new System.Drawing.Size(90, 21);
            this.ChangeProbabilityFactor_button.TabIndex = 92;
            this.ChangeProbabilityFactor_button.Text = "修改概率因数";
            this.ChangeProbabilityFactor_button.UseVisualStyleBackColor = true;
            this.ChangeProbabilityFactor_button.Click += new System.EventHandler(this.ChangeProbabilityFactor_button_Click);
            // 
            // SubsequentImpactList_listView
            // 
            this.SubsequentImpactList_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubsequentImpactDetail});
            this.SubsequentImpactList_listView.HideSelection = false;
            this.SubsequentImpactList_listView.Location = new System.Drawing.Point(1024, 321);
            this.SubsequentImpactList_listView.Name = "SubsequentImpactList_listView";
            this.SubsequentImpactList_listView.Size = new System.Drawing.Size(100, 223);
            this.SubsequentImpactList_listView.TabIndex = 94;
            this.SubsequentImpactList_listView.UseCompatibleStateImageBehavior = false;
            this.SubsequentImpactList_listView.View = System.Windows.Forms.View.Details;
            this.SubsequentImpactList_listView.SelectedIndexChanged += new System.EventHandler(this.SubsequentImpactList_listView_SelectedIndexChanged);
            this.SubsequentImpactList_listView.Click += new System.EventHandler(this.SubsequentImpactList_listView_Click);
            // 
            // SubsequentImpactDetail
            // 
            this.SubsequentImpactDetail.Text = "SubsequentImpactDetail";
            this.SubsequentImpactDetail.Width = 200;
            // 
            // AddOrRemoveTag_groupBox
            // 
            this.AddOrRemoveTag_groupBox.Controls.Add(this.AddTag_radioButton);
            this.AddOrRemoveTag_groupBox.Controls.Add(this.RemoveTag_radioButton);
            this.AddOrRemoveTag_groupBox.Location = new System.Drawing.Point(1130, 476);
            this.AddOrRemoveTag_groupBox.Name = "AddOrRemoveTag_groupBox";
            this.AddOrRemoveTag_groupBox.Size = new System.Drawing.Size(186, 68);
            this.AddOrRemoveTag_groupBox.TabIndex = 71;
            this.AddOrRemoveTag_groupBox.TabStop = false;
            this.AddOrRemoveTag_groupBox.Text = "标签影响类型";
            // 
            // AddTag_radioButton
            // 
            this.AddTag_radioButton.AutoSize = true;
            this.AddTag_radioButton.Checked = true;
            this.AddTag_radioButton.Location = new System.Drawing.Point(6, 17);
            this.AddTag_radioButton.Name = "AddTag_radioButton";
            this.AddTag_radioButton.Size = new System.Drawing.Size(71, 16);
            this.AddTag_radioButton.TabIndex = 42;
            this.AddTag_radioButton.TabStop = true;
            this.AddTag_radioButton.Text = "添加标签";
            this.AddTag_radioButton.UseVisualStyleBackColor = true;
            this.AddTag_radioButton.CheckedChanged += new System.EventHandler(this.AddTag_radioButton_CheckedChanged);
            // 
            // RemoveTag_radioButton
            // 
            this.RemoveTag_radioButton.AutoSize = true;
            this.RemoveTag_radioButton.Location = new System.Drawing.Point(6, 39);
            this.RemoveTag_radioButton.Name = "RemoveTag_radioButton";
            this.RemoveTag_radioButton.Size = new System.Drawing.Size(71, 16);
            this.RemoveTag_radioButton.TabIndex = 43;
            this.RemoveTag_radioButton.Text = "抹去标签";
            this.RemoveTag_radioButton.UseVisualStyleBackColor = true;
            this.RemoveTag_radioButton.CheckedChanged += new System.EventHandler(this.RemoveTag_radioButton_CheckedChanged);
            // 
            // SubsequentImpactTagOrAttributeName_textBox
            // 
            this.SubsequentImpactTagOrAttributeName_textBox.Location = new System.Drawing.Point(1226, 429);
            this.SubsequentImpactTagOrAttributeName_textBox.Name = "SubsequentImpactTagOrAttributeName_textBox";
            this.SubsequentImpactTagOrAttributeName_textBox.Size = new System.Drawing.Size(90, 21);
            this.SubsequentImpactTagOrAttributeName_textBox.TabIndex = 100;
            // 
            // ChangeAndSaveSubsequentImpactTagOrAttributeName_button
            // 
            this.ChangeAndSaveSubsequentImpactTagOrAttributeName_button.Location = new System.Drawing.Point(1130, 429);
            this.ChangeAndSaveSubsequentImpactTagOrAttributeName_button.Name = "ChangeAndSaveSubsequentImpactTagOrAttributeName_button";
            this.ChangeAndSaveSubsequentImpactTagOrAttributeName_button.Size = new System.Drawing.Size(90, 21);
            this.ChangeAndSaveSubsequentImpactTagOrAttributeName_button.TabIndex = 99;
            this.ChangeAndSaveSubsequentImpactTagOrAttributeName_button.Text = "修属/Tag名";
            this.ChangeAndSaveSubsequentImpactTagOrAttributeName_button.UseVisualStyleBackColor = true;
            this.ChangeAndSaveSubsequentImpactTagOrAttributeName_button.Click += new System.EventHandler(this.ChangeAndSaveSubsequentImpactTagOrAttributeName_button_Click);
            // 
            // ImpactAttributeValue_textBox
            // 
            this.ImpactAttributeValue_textBox.Location = new System.Drawing.Point(1226, 456);
            this.ImpactAttributeValue_textBox.Name = "ImpactAttributeValue_textBox";
            this.ImpactAttributeValue_textBox.Size = new System.Drawing.Size(90, 21);
            this.ImpactAttributeValue_textBox.TabIndex = 102;
            // 
            // ChangeAndSaveImpactAttributeValue_button
            // 
            this.ChangeAndSaveImpactAttributeValue_button.Location = new System.Drawing.Point(1130, 456);
            this.ChangeAndSaveImpactAttributeValue_button.Name = "ChangeAndSaveImpactAttributeValue_button";
            this.ChangeAndSaveImpactAttributeValue_button.Size = new System.Drawing.Size(90, 21);
            this.ChangeAndSaveImpactAttributeValue_button.TabIndex = 101;
            this.ChangeAndSaveImpactAttributeValue_button.Text = "属性修改值";
            this.ChangeAndSaveImpactAttributeValue_button.UseVisualStyleBackColor = true;
            this.ChangeAndSaveImpactAttributeValue_button.Click += new System.EventHandler(this.ChangeAndSaveImpactAttributeValue_button_Click);
            // 
            // Bigger_textBox
            // 
            this.Bigger_textBox.Location = new System.Drawing.Point(1216, 240);
            this.Bigger_textBox.Name = "Bigger_textBox";
            this.Bigger_textBox.Size = new System.Drawing.Size(90, 21);
            this.Bigger_textBox.TabIndex = 104;
            // 
            // ChangeAndSaveBigger_button
            // 
            this.ChangeAndSaveBigger_button.Location = new System.Drawing.Point(1120, 240);
            this.ChangeAndSaveBigger_button.Name = "ChangeAndSaveBigger_button";
            this.ChangeAndSaveBigger_button.Size = new System.Drawing.Size(90, 21);
            this.ChangeAndSaveBigger_button.TabIndex = 103;
            this.ChangeAndSaveBigger_button.Text = "修改属性大于";
            this.ChangeAndSaveBigger_button.UseVisualStyleBackColor = true;
            this.ChangeAndSaveBigger_button.Click += new System.EventHandler(this.ChangeAndSaveBigger_button_Click);
            // 
            // Smaller_textBox
            // 
            this.Smaller_textBox.Location = new System.Drawing.Point(1216, 267);
            this.Smaller_textBox.Name = "Smaller_textBox";
            this.Smaller_textBox.Size = new System.Drawing.Size(90, 21);
            this.Smaller_textBox.TabIndex = 106;
            // 
            // ChangeAndSaveSmaller_button
            // 
            this.ChangeAndSaveSmaller_button.Location = new System.Drawing.Point(1120, 267);
            this.ChangeAndSaveSmaller_button.Name = "ChangeAndSaveSmaller_button";
            this.ChangeAndSaveSmaller_button.Size = new System.Drawing.Size(90, 21);
            this.ChangeAndSaveSmaller_button.TabIndex = 105;
            this.ChangeAndSaveSmaller_button.Text = "修改属性小于";
            this.ChangeAndSaveSmaller_button.UseVisualStyleBackColor = true;
            this.ChangeAndSaveSmaller_button.Click += new System.EventHandler(this.ChangeAndSaveSmaller_button_Click);
            // 
            // ChangeAndSaveEntitiyName_button
            // 
            this.ChangeAndSaveEntitiyName_button.Location = new System.Drawing.Point(1226, 93);
            this.ChangeAndSaveEntitiyName_button.Name = "ChangeAndSaveEntitiyName_button";
            this.ChangeAndSaveEntitiyName_button.Size = new System.Drawing.Size(80, 21);
            this.ChangeAndSaveEntitiyName_button.TabIndex = 107;
            this.ChangeAndSaveEntitiyName_button.Text = "修改并保存";
            this.ChangeAndSaveEntitiyName_button.UseVisualStyleBackColor = true;
            this.ChangeAndSaveEntitiyName_button.Click += new System.EventHandler(this.ChangeAndSaveEntitiyName_button_Click);
            // 
            // ChangeAndSaveOptionText_button
            // 
            this.ChangeAndSaveOptionText_button.Location = new System.Drawing.Point(540, 119);
            this.ChangeAndSaveOptionText_button.Name = "ChangeAndSaveOptionText_button";
            this.ChangeAndSaveOptionText_button.Size = new System.Drawing.Size(80, 21);
            this.ChangeAndSaveOptionText_button.TabIndex = 108;
            this.ChangeAndSaveOptionText_button.Text = "修改并保存";
            this.ChangeAndSaveOptionText_button.UseVisualStyleBackColor = true;
            this.ChangeAndSaveOptionText_button.Click += new System.EventHandler(this.ChangeAndSaveOptionText_button_Click);
            // 
            // ChangeAndSaveEventText_button
            // 
            this.ChangeAndSaveEventText_button.Location = new System.Drawing.Point(233, 119);
            this.ChangeAndSaveEventText_button.Name = "ChangeAndSaveEventText_button";
            this.ChangeAndSaveEventText_button.Size = new System.Drawing.Size(80, 21);
            this.ChangeAndSaveEventText_button.TabIndex = 109;
            this.ChangeAndSaveEventText_button.Text = "修改并保存";
            this.ChangeAndSaveEventText_button.UseVisualStyleBackColor = true;
            this.ChangeAndSaveEventText_button.Click += new System.EventHandler(this.ChangeAndSaveEventText_button_Click);
            // 
            // ChangeAndSaveIfComfirmText_button
            // 
            this.ChangeAndSaveIfComfirmText_button.Location = new System.Drawing.Point(540, 348);
            this.ChangeAndSaveIfComfirmText_button.Name = "ChangeAndSaveIfComfirmText_button";
            this.ChangeAndSaveIfComfirmText_button.Size = new System.Drawing.Size(80, 21);
            this.ChangeAndSaveIfComfirmText_button.TabIndex = 110;
            this.ChangeAndSaveIfComfirmText_button.Text = "修改并保存";
            this.ChangeAndSaveIfComfirmText_button.UseVisualStyleBackColor = true;
            this.ChangeAndSaveIfComfirmText_button.Click += new System.EventHandler(this.ChangeAndSaveIfComfirmText_button_Click);
            // 
            // ChangeAndSaveSubsequentText_button
            // 
            this.ChangeAndSaveSubsequentText_button.Location = new System.Drawing.Point(928, 375);
            this.ChangeAndSaveSubsequentText_button.Name = "ChangeAndSaveSubsequentText_button";
            this.ChangeAndSaveSubsequentText_button.Size = new System.Drawing.Size(90, 21);
            this.ChangeAndSaveSubsequentText_button.TabIndex = 111;
            this.ChangeAndSaveSubsequentText_button.Text = "修改并保存";
            this.ChangeAndSaveSubsequentText_button.UseVisualStyleBackColor = true;
            this.ChangeAndSaveSubsequentText_button.Click += new System.EventHandler(this.ChangeAndSaveSubsequentText_button_Click);
            // 
            // ChangeAndSaveSubsequentImpactEntitiyName__button
            // 
            this.ChangeAndSaveSubsequentImpactEntitiyName__button.Location = new System.Drawing.Point(1130, 402);
            this.ChangeAndSaveSubsequentImpactEntitiyName__button.Name = "ChangeAndSaveSubsequentImpactEntitiyName__button";
            this.ChangeAndSaveSubsequentImpactEntitiyName__button.Size = new System.Drawing.Size(90, 21);
            this.ChangeAndSaveSubsequentImpactEntitiyName__button.TabIndex = 112;
            this.ChangeAndSaveSubsequentImpactEntitiyName__button.Text = "修改并保存";
            this.ChangeAndSaveSubsequentImpactEntitiyName__button.UseVisualStyleBackColor = true;
            this.ChangeAndSaveSubsequentImpactEntitiyName__button.Click += new System.EventHandler(this.ChangeAndSaveSubsequentImpactEntitiyName__button_Click);
            // 
            // SaveEventListDataInFile_button
            // 
            this.SaveEventListDataInFile_button.Location = new System.Drawing.Point(12, 551);
            this.SaveEventListDataInFile_button.Name = "SaveEventListDataInFile_button";
            this.SaveEventListDataInFile_button.Size = new System.Drawing.Size(100, 21);
            this.SaveEventListDataInFile_button.TabIndex = 113;
            this.SaveEventListDataInFile_button.Text = "保存到文件夹";
            this.SaveEventListDataInFile_button.UseVisualStyleBackColor = true;
            this.SaveEventListDataInFile_button.Click += new System.EventHandler(this.SaveEventListDataInFile_button_Click);
            // 
            // FilePath_textBox
            // 
            this.FilePath_textBox.Location = new System.Drawing.Point(118, 552);
            this.FilePath_textBox.Name = "FilePath_textBox";
            this.FilePath_textBox.Size = new System.Drawing.Size(502, 21);
            this.FilePath_textBox.TabIndex = 114;
            // 
            // OpenFolderFile_button
            // 
            this.OpenFolderFile_button.Location = new System.Drawing.Point(626, 552);
            this.OpenFolderFile_button.Name = "OpenFolderFile_button";
            this.OpenFolderFile_button.Size = new System.Drawing.Size(95, 21);
            this.OpenFolderFile_button.TabIndex = 115;
            this.OpenFolderFile_button.Text = "选择文件夹";
            this.OpenFolderFile_button.UseVisualStyleBackColor = true;
            this.OpenFolderFile_button.Click += new System.EventHandler(this.OpenFolderFile_button_Click);
            // 
            // OpenEventListJsonFile_button
            // 
            this.OpenEventListJsonFile_button.Location = new System.Drawing.Point(731, 552);
            this.OpenEventListJsonFile_button.Name = "OpenEventListJsonFile_button";
            this.OpenEventListJsonFile_button.Size = new System.Drawing.Size(95, 21);
            this.OpenEventListJsonFile_button.TabIndex = 116;
            this.OpenEventListJsonFile_button.Text = "添加事件列表";
            this.OpenEventListJsonFile_button.UseVisualStyleBackColor = true;
            this.OpenEventListJsonFile_button.Click += new System.EventHandler(this.OpenEventListJsonFile_button_Click);
            // 
            // EventText_textBox
            // 
            this.EventText_textBox.Location = new System.Drawing.Point(118, 146);
            this.EventText_textBox.Multiline = true;
            this.EventText_textBox.Name = "EventText_textBox";
            this.EventText_textBox.Size = new System.Drawing.Size(195, 371);
            this.EventText_textBox.TabIndex = 118;
            // 
            // Debug_listView
            // 
            this.Debug_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DebugID,
            this.DebugText});
            this.Debug_listView.HideSelection = false;
            this.Debug_listView.Location = new System.Drawing.Point(12, 579);
            this.Debug_listView.Name = "Debug_listView";
            this.Debug_listView.Size = new System.Drawing.Size(1304, 97);
            this.Debug_listView.TabIndex = 120;
            this.Debug_listView.UseCompatibleStateImageBehavior = false;
            this.Debug_listView.View = System.Windows.Forms.View.Details;
            // 
            // DebugID
            // 
            this.DebugID.Text = "DebugID";
            this.DebugID.Width = 100;
            // 
            // DebugText
            // 
            this.DebugText.Text = "DebugText";
            this.DebugText.Width = 1200;
            // 
            // ClearDebugListView_button
            // 
            this.ClearDebugListView_button.Location = new System.Drawing.Point(1241, 552);
            this.ClearDebugListView_button.Name = "ClearDebugListView_button";
            this.ClearDebugListView_button.Size = new System.Drawing.Size(75, 21);
            this.ClearDebugListView_button.TabIndex = 121;
            this.ClearDebugListView_button.Text = "ClearDebug";
            this.ClearDebugListView_button.UseVisualStyleBackColor = true;
            this.ClearDebugListView_button.Click += new System.EventHandler(this.ClearDebugListView_button_Click);
            // 
            // SelectedEvent_label
            // 
            this.SelectedEvent_label.AutoSize = true;
            this.SelectedEvent_label.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectedEvent_label.Location = new System.Drawing.Point(12, 9);
            this.SelectedEvent_label.Name = "SelectedEvent_label";
            this.SelectedEvent_label.Size = new System.Drawing.Size(64, 27);
            this.SelectedEvent_label.TabIndex = 122;
            this.SelectedEvent_label.Text = "选择的事件： \r\n\r\n无";
            // 
            // OptionText_textBox
            // 
            this.OptionText_textBox.Location = new System.Drawing.Point(425, 146);
            this.OptionText_textBox.Multiline = true;
            this.OptionText_textBox.Name = "OptionText_textBox";
            this.OptionText_textBox.Size = new System.Drawing.Size(195, 180);
            this.OptionText_textBox.TabIndex = 123;
            // 
            // IfComfirmText_textBox
            // 
            this.IfComfirmText_textBox.Location = new System.Drawing.Point(425, 375);
            this.IfComfirmText_textBox.Multiline = true;
            this.IfComfirmText_textBox.Name = "IfComfirmText_textBox";
            this.IfComfirmText_textBox.Size = new System.Drawing.Size(195, 169);
            this.IfComfirmText_textBox.TabIndex = 124;
            // 
            // SelectedOption_label
            // 
            this.SelectedOption_label.AutoSize = true;
            this.SelectedOption_label.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectedOption_label.Location = new System.Drawing.Point(425, 9);
            this.SelectedOption_label.Name = "SelectedOption_label";
            this.SelectedOption_label.Size = new System.Drawing.Size(64, 27);
            this.SelectedOption_label.TabIndex = 125;
            this.SelectedOption_label.Text = "选择的选项： \r\n\r\n无";
            // 
            // SelectedPrerequisite_label
            // 
            this.SelectedPrerequisite_label.AutoSize = true;
            this.SelectedPrerequisite_label.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectedPrerequisite_label.Location = new System.Drawing.Point(932, 8);
            this.SelectedPrerequisite_label.Name = "SelectedPrerequisite_label";
            this.SelectedPrerequisite_label.Size = new System.Drawing.Size(64, 27);
            this.SelectedPrerequisite_label.TabIndex = 126;
            this.SelectedPrerequisite_label.Text = "选择的选项： \r\n\r\n无";
            // 
            // ChangePrerequisiteName_button
            // 
            this.ChangePrerequisiteName_button.Location = new System.Drawing.Point(928, 65);
            this.ChangePrerequisiteName_button.Name = "ChangePrerequisiteName_button";
            this.ChangePrerequisiteName_button.Size = new System.Drawing.Size(90, 21);
            this.ChangePrerequisiteName_button.TabIndex = 127;
            this.ChangePrerequisiteName_button.Text = "修改要求名";
            this.ChangePrerequisiteName_button.UseVisualStyleBackColor = true;
            this.ChangePrerequisiteName_button.Click += new System.EventHandler(this.ChangePrerequisiteName_button_Click);
            // 
            // PrerequisiteName_textBox
            // 
            this.PrerequisiteName_textBox.Location = new System.Drawing.Point(1024, 65);
            this.PrerequisiteName_textBox.Name = "PrerequisiteName_textBox";
            this.PrerequisiteName_textBox.Size = new System.Drawing.Size(90, 21);
            this.PrerequisiteName_textBox.TabIndex = 128;
            // 
            // RemoveSubsequentImpactData_button
            // 
            this.RemoveSubsequentImpactData_button.Location = new System.Drawing.Point(1130, 375);
            this.RemoveSubsequentImpactData_button.Name = "RemoveSubsequentImpactData_button";
            this.RemoveSubsequentImpactData_button.Size = new System.Drawing.Size(90, 21);
            this.RemoveSubsequentImpactData_button.TabIndex = 129;
            this.RemoveSubsequentImpactData_button.Text = "移除影响";
            this.RemoveSubsequentImpactData_button.UseVisualStyleBackColor = true;
            this.RemoveSubsequentImpactData_button.Click += new System.EventHandler(this.RemoveSubsequentImpactData_button_Click);
            // 
            // SubsequentText_textBox
            // 
            this.SubsequentText_textBox.Location = new System.Drawing.Point(832, 402);
            this.SubsequentText_textBox.Multiline = true;
            this.SubsequentText_textBox.Name = "SubsequentText_textBox";
            this.SubsequentText_textBox.Size = new System.Drawing.Size(186, 142);
            this.SubsequentText_textBox.TabIndex = 130;
            // 
            // SelectedSubsequent_label
            // 
            this.SelectedSubsequent_label.AutoSize = true;
            this.SelectedSubsequent_label.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectedSubsequent_label.Location = new System.Drawing.Point(626, 291);
            this.SelectedSubsequent_label.Name = "SelectedSubsequent_label";
            this.SelectedSubsequent_label.Size = new System.Drawing.Size(82, 27);
            this.SelectedSubsequent_label.TabIndex = 131;
            this.SelectedSubsequent_label.Text = "选择的后续结果： \r\n\r\n无";
            // 
            // SelectedSubsequentImpact_label
            // 
            this.SelectedSubsequentImpact_label.AutoSize = true;
            this.SelectedSubsequentImpact_label.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectedSubsequentImpact_label.Location = new System.Drawing.Point(1024, 291);
            this.SelectedSubsequentImpact_label.Name = "SelectedSubsequentImpact_label";
            this.SelectedSubsequentImpact_label.Size = new System.Drawing.Size(82, 27);
            this.SelectedSubsequentImpact_label.TabIndex = 132;
            this.SelectedSubsequentImpact_label.Text = "选择的后续影响： \r\n\r\n无";
            // 
            // FileName_textBox
            // 
            this.FileName_textBox.Location = new System.Drawing.Point(832, 552);
            this.FileName_textBox.Name = "FileName_textBox";
            this.FileName_textBox.Size = new System.Drawing.Size(186, 21);
            this.FileName_textBox.TabIndex = 133;
            this.FileName_textBox.Text = "默认文件名称";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 683);
            this.Controls.Add(this.FileName_textBox);
            this.Controls.Add(this.SelectedSubsequentImpact_label);
            this.Controls.Add(this.SelectedSubsequent_label);
            this.Controls.Add(this.SubsequentText_textBox);
            this.Controls.Add(this.RemoveSubsequentImpactData_button);
            this.Controls.Add(this.PrerequisiteName_textBox);
            this.Controls.Add(this.ChangePrerequisiteName_button);
            this.Controls.Add(this.SelectedPrerequisite_label);
            this.Controls.Add(this.SelectedOption_label);
            this.Controls.Add(this.IfComfirmText_textBox);
            this.Controls.Add(this.OptionText_textBox);
            this.Controls.Add(this.SelectedEvent_label);
            this.Controls.Add(this.ClearDebugListView_button);
            this.Controls.Add(this.Debug_listView);
            this.Controls.Add(this.EventText_textBox);
            this.Controls.Add(this.OpenEventListJsonFile_button);
            this.Controls.Add(this.OpenFolderFile_button);
            this.Controls.Add(this.FilePath_textBox);
            this.Controls.Add(this.SaveEventListDataInFile_button);
            this.Controls.Add(this.ChangeAndSaveSubsequentImpactEntitiyName__button);
            this.Controls.Add(this.ChangeAndSaveSubsequentText_button);
            this.Controls.Add(this.ChangeAndSaveIfComfirmText_button);
            this.Controls.Add(this.ChangeAndSaveEventText_button);
            this.Controls.Add(this.ChangeAndSaveOptionText_button);
            this.Controls.Add(this.ChangeAndSaveEntitiyName_button);
            this.Controls.Add(this.Smaller_textBox);
            this.Controls.Add(this.ChangeAndSaveSmaller_button);
            this.Controls.Add(this.Bigger_textBox);
            this.Controls.Add(this.ChangeAndSaveBigger_button);
            this.Controls.Add(this.ImpactAttributeValue_textBox);
            this.Controls.Add(this.ChangeAndSaveImpactAttributeValue_button);
            this.Controls.Add(this.SubsequentImpactTagOrAttributeName_textBox);
            this.Controls.Add(this.ChangeAndSaveSubsequentImpactTagOrAttributeName_button);
            this.Controls.Add(this.AddOrRemoveTag_groupBox);
            this.Controls.Add(this.SubsequentImpactList_listView);
            this.Controls.Add(this.SubsequentProbabilityFactor_textBox);
            this.Controls.Add(this.ChangeProbabilityFactor_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddSubsequentData_button);
            this.Controls.Add(this.SubsequentName_textBox);
            this.Controls.Add(this.ChangeSubsequentName_button);
            this.Controls.Add(this.AddImpactTag_button);
            this.Controls.Add(this.AddImpactAttribute_button);
            this.Controls.Add(this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RemoveSubsequentData_button);
            this.Controls.Add(this.SubsequentImpactEntitiyName_textBox);
            this.Controls.Add(this.PrerequisiteSatisfyAllOrOne_groupBox);
            this.Controls.Add(this.RequirementTagType_groupBox);
            this.Controls.Add(this.AddNewRequirementTag_button);
            this.Controls.Add(this.TagOrAttributeName_textBox);
            this.Controls.Add(this.ChangeAndSaveRequirementTagOrAttributeName_button);
            this.Controls.Add(this.AddNewRequirementAttribute_button);
            this.Controls.Add(this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IfComfirm_checkBox);
            this.Controls.Add(this.RemovePrerequisiteData_button);
            this.Controls.Add(this.OptionName_textBox);
            this.Controls.Add(this.ChangeOptionName_button);
            this.Controls.Add(this.RemoveOptionData_button);
            this.Controls.Add(this.AddNewOptionData_button);
            this.Controls.Add(this.SearchEvent_button);
            this.Controls.Add(this.SearchEvent_textBox);
            this.Controls.Add(this.EntitiyName_textBox);
            this.Controls.Add(this.SubsequentList_listView);
            this.Controls.Add(this.EventName_textBox);
            this.Controls.Add(this.PrerequisiteList_listView);
            this.Controls.Add(this.OptionList_listView);
            this.Controls.Add(this.ChangeEventDataName_button);
            this.Controls.Add(this.RemoveEventData_button);
            this.Controls.Add(this.EventList_listView);
            this.Controls.Add(this.AddNewEventData_button);
            this.Name = "Main";
            this.Text = "事件数据编辑器";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox.ResumeLayout(false);
            this.PrerequisiteToPlayerCharacterOrOtherEntities_groupBox.PerformLayout();
            this.RequirementTagType_groupBox.ResumeLayout(false);
            this.RequirementTagType_groupBox.PerformLayout();
            this.PrerequisiteSatisfyAllOrOne_groupBox.ResumeLayout(false);
            this.PrerequisiteSatisfyAllOrOne_groupBox.PerformLayout();
            this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox.ResumeLayout(false);
            this.SubsequentImpactPlayerCharacterOrOtherEntities_groupBox.PerformLayout();
            this.AddOrRemoveTag_groupBox.ResumeLayout(false);
            this.AddOrRemoveTag_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void EventList_listView_MouseClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private System.Windows.Forms.Button AddNewEventData_button;
        private System.Windows.Forms.ListView EventList_listView;
        private System.Windows.Forms.Button RemoveEventData_button;
        private System.Windows.Forms.Button ChangeEventDataName_button;
        private System.Windows.Forms.ListView OptionList_listView;
        private System.Windows.Forms.ListView PrerequisiteList_listView;
        private System.Windows.Forms.TextBox EventName_textBox;
        private System.Windows.Forms.ListView SubsequentList_listView;
        private System.Windows.Forms.TextBox EntitiyName_textBox;
        private System.Windows.Forms.TextBox SearchEvent_textBox;
        private System.Windows.Forms.Button SearchEvent_button;
        private System.Windows.Forms.TextBox OptionName_textBox;
        private System.Windows.Forms.Button ChangeOptionName_button;
        private System.Windows.Forms.Button RemoveOptionData_button;
        private System.Windows.Forms.Button AddNewOptionData_button;
        private System.Windows.Forms.Button RemovePrerequisiteData_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton ToPlayerCharacter_radioButton;
        private System.Windows.Forms.RadioButton ToOtherEntities_radioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox PrerequisiteToPlayerCharacterOrOtherEntities_groupBox;
        private System.Windows.Forms.TextBox TagOrAttributeName_textBox;
        private System.Windows.Forms.Button ChangeAndSaveRequirementTagOrAttributeName_button;
        private System.Windows.Forms.Button AddNewRequirementAttribute_button;
        private System.Windows.Forms.Button AddNewRequirementTag_button;
        private System.Windows.Forms.GroupBox RequirementTagType_groupBox;
        private System.Windows.Forms.RadioButton NeedExist_radioButton;
        private System.Windows.Forms.RadioButton NeedNotExist_radioButton;
        private System.Windows.Forms.GroupBox PrerequisiteSatisfyAllOrOne_groupBox;
        private System.Windows.Forms.RadioButton SatisfyAll_radioButton;
        private System.Windows.Forms.RadioButton SatisfyOne_radioButton;
        private System.Windows.Forms.Button AddImpactTag_button;
        private System.Windows.Forms.Button AddImpactAttribute_button;
        private System.Windows.Forms.GroupBox SubsequentImpactPlayerCharacterOrOtherEntities_groupBox;
        private System.Windows.Forms.RadioButton SubsequentImpactPlayerCharacter_radioButton;
        private System.Windows.Forms.RadioButton SubsequentImpactOtherEntities_radioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RemoveSubsequentData_button;
        private System.Windows.Forms.TextBox SubsequentImpactEntitiyName_textBox;
        private System.Windows.Forms.TextBox SubsequentName_textBox;
        private System.Windows.Forms.Button ChangeSubsequentName_button;
        private System.Windows.Forms.Button AddSubsequentData_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SubsequentProbabilityFactor_textBox;
        private System.Windows.Forms.Button ChangeProbabilityFactor_button;
        private System.Windows.Forms.ListView SubsequentImpactList_listView;
        private System.Windows.Forms.GroupBox AddOrRemoveTag_groupBox;
        private System.Windows.Forms.RadioButton AddTag_radioButton;
        private System.Windows.Forms.RadioButton RemoveTag_radioButton;
        private System.Windows.Forms.TextBox SubsequentImpactTagOrAttributeName_textBox;
        private System.Windows.Forms.Button ChangeAndSaveSubsequentImpactTagOrAttributeName_button;
        private System.Windows.Forms.TextBox ImpactAttributeValue_textBox;
        private System.Windows.Forms.Button ChangeAndSaveImpactAttributeValue_button;
        private System.Windows.Forms.TextBox Bigger_textBox;
        private System.Windows.Forms.Button ChangeAndSaveBigger_button;
        private System.Windows.Forms.TextBox Smaller_textBox;
        private System.Windows.Forms.Button ChangeAndSaveSmaller_button;
        private System.Windows.Forms.Button ChangeAndSaveEntitiyName_button;
        private System.Windows.Forms.Button ChangeAndSaveOptionText_button;
        private System.Windows.Forms.Button ChangeAndSaveEventText_button;
        private System.Windows.Forms.Button ChangeAndSaveIfComfirmText_button;
        private System.Windows.Forms.Button ChangeAndSaveSubsequentText_button;
        private System.Windows.Forms.Button ChangeAndSaveSubsequentImpactEntitiyName__button;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button SaveEventListDataInFile_button;
        private System.Windows.Forms.TextBox FilePath_textBox;
        private System.Windows.Forms.Button OpenFolderFile_button;
        private System.Windows.Forms.Button OpenEventListJsonFile_button;
        private System.Windows.Forms.TextBox EventText_textBox;
        private ListView Debug_listView;
        private ColumnHeader DebugID;
        private ColumnHeader DebugText;
        private Button ClearDebugListView_button;
        private Label SelectedEvent_label;
        private TextBox OptionText_textBox;
        private TextBox IfComfirmText_textBox;
        private Label SelectedOption_label;
        private CheckBox IfComfirm_checkBox;
        private ColumnHeader PrerequisiteDetail;
        private Button ChangePrerequisiteName_button;
        private TextBox PrerequisiteName_textBox;
        private Label SelectedPrerequisite_label;
        private Button RemoveSubsequentImpactData_button;
        private TextBox SubsequentText_textBox;
        private Label SelectedSubsequent_label;
        private ColumnHeader SubsequentDetail;
        private Label SelectedSubsequentImpact_label;
        private ColumnHeader SubsequentImpactDetail;
        private TextBox FileName_textBox;
    }
}