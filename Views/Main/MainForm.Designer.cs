namespace Views.Main
{
    partial class MainForm
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
            this.gbFiltration = new System.Windows.Forms.GroupBox();
            this.gbReleaseDate = new System.Windows.Forms.GroupBox();
            this.cbReleaseDate = new System.Windows.Forms.CheckBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.gbPlatform = new System.Windows.Forms.GroupBox();
            this.cbiOS = new System.Windows.Forms.CheckBox();
            this.cbAndroid = new System.Windows.Forms.CheckBox();
            this.cbXbox = new System.Windows.Forms.CheckBox();
            this.cbPlayStation = new System.Windows.Forms.CheckBox();
            this.cbPC = new System.Windows.Forms.CheckBox();
            this.gbGenre = new System.Windows.Forms.GroupBox();
            this.cbRacing = new System.Windows.Forms.CheckBox();
            this.cbAction = new System.Windows.Forms.CheckBox();
            this.cbStrategy = new System.Windows.Forms.CheckBox();
            this.cbAdventure = new System.Windows.Forms.CheckBox();
            this.cbRPG = new System.Windows.Forms.CheckBox();
            this.gbTitle = new System.Windows.Forms.GroupBox();
            this.rbFiltrationDeveloper = new System.Windows.Forms.RadioButton();
            this.rbFiltrationTitle = new System.Windows.Forms.RadioButton();
            this.rbFiltrationPublisher = new System.Windows.Forms.RadioButton();
            this.tbFiltrationString = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.gbVideoGameList = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbVideoGameList = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.gbParams = new System.Windows.Forms.GroupBox();
            this.rbReleaseDate = new System.Windows.Forms.RadioButton();
            this.rbTitle = new System.Windows.Forms.RadioButton();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.rbDescending = new System.Windows.Forms.RadioButton();
            this.rbAscending = new System.Windows.Forms.RadioButton();
            this.gbFiltration.SuspendLayout();
            this.gbReleaseDate.SuspendLayout();
            this.gbPlatform.SuspendLayout();
            this.gbGenre.SuspendLayout();
            this.gbTitle.SuspendLayout();
            this.gbVideoGameList.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.gbParams.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltration
            // 
            this.gbFiltration.Controls.Add(this.gbReleaseDate);
            this.gbFiltration.Controls.Add(this.gbPlatform);
            this.gbFiltration.Controls.Add(this.gbGenre);
            this.gbFiltration.Controls.Add(this.gbTitle);
            this.gbFiltration.Controls.Add(this.btnFind);
            this.gbFiltration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbFiltration.Location = new System.Drawing.Point(12, 12);
            this.gbFiltration.Name = "gbFiltration";
            this.gbFiltration.Size = new System.Drawing.Size(281, 402);
            this.gbFiltration.TabIndex = 0;
            this.gbFiltration.TabStop = false;
            this.gbFiltration.Text = "Filtration";
            // 
            // gbReleaseDate
            // 
            this.gbReleaseDate.Controls.Add(this.cbReleaseDate);
            this.gbReleaseDate.Controls.Add(this.dtpTo);
            this.gbReleaseDate.Controls.Add(this.dtpFrom);
            this.gbReleaseDate.Controls.Add(this.lbTo);
            this.gbReleaseDate.Controls.Add(this.lbFrom);
            this.gbReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gbReleaseDate.Location = new System.Drawing.Point(7, 137);
            this.gbReleaseDate.Name = "gbReleaseDate";
            this.gbReleaseDate.Size = new System.Drawing.Size(268, 71);
            this.gbReleaseDate.TabIndex = 4;
            this.gbReleaseDate.TabStop = false;
            this.gbReleaseDate.Text = "Release date";
            // 
            // cbReleaseDate
            // 
            this.cbReleaseDate.Location = new System.Drawing.Point(6, 31);
            this.cbReleaseDate.Name = "cbReleaseDate";
            this.cbReleaseDate.Size = new System.Drawing.Size(16, 24);
            this.cbReleaseDate.TabIndex = 10;
            this.cbReleaseDate.UseVisualStyleBackColor = true;
            this.cbReleaseDate.CheckedChanged += new System.EventHandler(this.cbReleaseDate_CheckedChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Enabled = false;
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(168, 29);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(88, 23);
            this.dtpTo.TabIndex = 9;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(55, 29);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(88, 23);
            this.dtpFrom.TabIndex = 8;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(149, 36);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(19, 13);
            this.lbTo.TabIndex = 7;
            this.lbTo.Text = "to:";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(25, 36);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(30, 13);
            this.lbFrom.TabIndex = 6;
            this.lbFrom.Text = "from:";
            // 
            // gbPlatform
            // 
            this.gbPlatform.Controls.Add(this.cbiOS);
            this.gbPlatform.Controls.Add(this.cbAndroid);
            this.gbPlatform.Controls.Add(this.cbXbox);
            this.gbPlatform.Controls.Add(this.cbPlayStation);
            this.gbPlatform.Controls.Add(this.cbPC);
            this.gbPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gbPlatform.Location = new System.Drawing.Point(6, 214);
            this.gbPlatform.Name = "gbPlatform";
            this.gbPlatform.Size = new System.Drawing.Size(125, 136);
            this.gbPlatform.TabIndex = 3;
            this.gbPlatform.TabStop = false;
            this.gbPlatform.Text = "Platforms";
            // 
            // cbiOS
            // 
            this.cbiOS.AutoSize = true;
            this.cbiOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.95F);
            this.cbiOS.Location = new System.Drawing.Point(6, 111);
            this.cbiOS.Name = "cbiOS";
            this.cbiOS.Size = new System.Drawing.Size(43, 17);
            this.cbiOS.TabIndex = 10;
            this.cbiOS.Text = "iOS";
            this.cbiOS.UseVisualStyleBackColor = true;
            // 
            // cbAndroid
            // 
            this.cbAndroid.AutoSize = true;
            this.cbAndroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.95F);
            this.cbAndroid.Location = new System.Drawing.Point(6, 88);
            this.cbAndroid.Name = "cbAndroid";
            this.cbAndroid.Size = new System.Drawing.Size(62, 17);
            this.cbAndroid.TabIndex = 9;
            this.cbAndroid.Text = "Android";
            this.cbAndroid.UseVisualStyleBackColor = true;
            // 
            // cbXbox
            // 
            this.cbXbox.AutoSize = true;
            this.cbXbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.95F);
            this.cbXbox.Location = new System.Drawing.Point(6, 65);
            this.cbXbox.Name = "cbXbox";
            this.cbXbox.Size = new System.Drawing.Size(50, 17);
            this.cbXbox.TabIndex = 8;
            this.cbXbox.Text = "Xbox";
            this.cbXbox.UseVisualStyleBackColor = true;
            // 
            // cbPlayStation
            // 
            this.cbPlayStation.AutoSize = true;
            this.cbPlayStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.95F);
            this.cbPlayStation.Location = new System.Drawing.Point(6, 42);
            this.cbPlayStation.Name = "cbPlayStation";
            this.cbPlayStation.Size = new System.Drawing.Size(79, 17);
            this.cbPlayStation.TabIndex = 7;
            this.cbPlayStation.Text = "PlayStation";
            this.cbPlayStation.UseVisualStyleBackColor = true;
            // 
            // cbPC
            // 
            this.cbPC.AutoSize = true;
            this.cbPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.95F);
            this.cbPC.Location = new System.Drawing.Point(6, 19);
            this.cbPC.Name = "cbPC";
            this.cbPC.Size = new System.Drawing.Size(40, 17);
            this.cbPC.TabIndex = 6;
            this.cbPC.Text = "PC";
            this.cbPC.UseVisualStyleBackColor = true;
            // 
            // gbGenre
            // 
            this.gbGenre.Controls.Add(this.cbRacing);
            this.gbGenre.Controls.Add(this.cbAction);
            this.gbGenre.Controls.Add(this.cbStrategy);
            this.gbGenre.Controls.Add(this.cbAdventure);
            this.gbGenre.Controls.Add(this.cbRPG);
            this.gbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gbGenre.Location = new System.Drawing.Point(137, 214);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(138, 136);
            this.gbGenre.TabIndex = 2;
            this.gbGenre.TabStop = false;
            this.gbGenre.Text = "Genres";
            // 
            // cbRacing
            // 
            this.cbRacing.AutoSize = true;
            this.cbRacing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbRacing.Location = new System.Drawing.Point(6, 111);
            this.cbRacing.Name = "cbRacing";
            this.cbRacing.Size = new System.Drawing.Size(60, 17);
            this.cbRacing.TabIndex = 13;
            this.cbRacing.Text = "Racing";
            this.cbRacing.UseVisualStyleBackColor = true;
            // 
            // cbAction
            // 
            this.cbAction.AutoSize = true;
            this.cbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbAction.Location = new System.Drawing.Point(6, 19);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(56, 17);
            this.cbAction.TabIndex = 9;
            this.cbAction.Text = "Action";
            this.cbAction.UseVisualStyleBackColor = true;
            // 
            // cbStrategy
            // 
            this.cbStrategy.AutoSize = true;
            this.cbStrategy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbStrategy.Location = new System.Drawing.Point(6, 88);
            this.cbStrategy.Name = "cbStrategy";
            this.cbStrategy.Size = new System.Drawing.Size(65, 17);
            this.cbStrategy.TabIndex = 12;
            this.cbStrategy.Text = "Strategy";
            this.cbStrategy.UseVisualStyleBackColor = true;
            // 
            // cbAdventure
            // 
            this.cbAdventure.AutoSize = true;
            this.cbAdventure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbAdventure.Location = new System.Drawing.Point(6, 42);
            this.cbAdventure.Name = "cbAdventure";
            this.cbAdventure.Size = new System.Drawing.Size(75, 17);
            this.cbAdventure.TabIndex = 10;
            this.cbAdventure.Text = "Adventure";
            this.cbAdventure.UseVisualStyleBackColor = true;
            // 
            // cbRPG
            // 
            this.cbRPG.AutoSize = true;
            this.cbRPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbRPG.Location = new System.Drawing.Point(6, 65);
            this.cbRPG.Name = "cbRPG";
            this.cbRPG.Size = new System.Drawing.Size(49, 17);
            this.cbRPG.TabIndex = 11;
            this.cbRPG.Text = "RPG";
            this.cbRPG.UseVisualStyleBackColor = true;
            // 
            // gbTitle
            // 
            this.gbTitle.Controls.Add(this.rbFiltrationDeveloper);
            this.gbTitle.Controls.Add(this.rbFiltrationTitle);
            this.gbTitle.Controls.Add(this.rbFiltrationPublisher);
            this.gbTitle.Controls.Add(this.tbFiltrationString);
            this.gbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gbTitle.Location = new System.Drawing.Point(6, 22);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Size = new System.Drawing.Size(257, 109);
            this.gbTitle.TabIndex = 1;
            this.gbTitle.TabStop = false;
            this.gbTitle.Text = "Name";
            // 
            // rbFiltrationDeveloper
            // 
            this.rbFiltrationDeveloper.Location = new System.Drawing.Point(6, 83);
            this.rbFiltrationDeveloper.Name = "rbFiltrationDeveloper";
            this.rbFiltrationDeveloper.Size = new System.Drawing.Size(104, 22);
            this.rbFiltrationDeveloper.TabIndex = 5;
            this.rbFiltrationDeveloper.Text = "Developer";
            this.rbFiltrationDeveloper.UseVisualStyleBackColor = true;
            // 
            // rbFiltrationTitle
            // 
            this.rbFiltrationTitle.Checked = true;
            this.rbFiltrationTitle.Location = new System.Drawing.Point(6, 45);
            this.rbFiltrationTitle.Name = "rbFiltrationTitle";
            this.rbFiltrationTitle.Size = new System.Drawing.Size(104, 22);
            this.rbFiltrationTitle.TabIndex = 4;
            this.rbFiltrationTitle.TabStop = true;
            this.rbFiltrationTitle.Text = "Title";
            this.rbFiltrationTitle.UseVisualStyleBackColor = true;
            // 
            // rbFiltrationPublisher
            // 
            this.rbFiltrationPublisher.Location = new System.Drawing.Point(6, 64);
            this.rbFiltrationPublisher.Name = "rbFiltrationPublisher";
            this.rbFiltrationPublisher.Size = new System.Drawing.Size(104, 22);
            this.rbFiltrationPublisher.TabIndex = 3;
            this.rbFiltrationPublisher.Text = "Publisher";
            this.rbFiltrationPublisher.UseVisualStyleBackColor = true;
            // 
            // tbFiltrationString
            // 
            this.tbFiltrationString.Location = new System.Drawing.Point(6, 19);
            this.tbFiltrationString.Name = "tbFiltrationString";
            this.tbFiltrationString.Size = new System.Drawing.Size(245, 20);
            this.tbFiltrationString.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFind.Location = new System.Drawing.Point(6, 356);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(269, 40);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // gbVideoGameList
            // 
            this.gbVideoGameList.Controls.Add(this.btnAdd);
            this.gbVideoGameList.Controls.Add(this.btnDelete);
            this.gbVideoGameList.Controls.Add(this.lbVideoGameList);
            this.gbVideoGameList.Controls.Add(this.btnEdit);
            this.gbVideoGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbVideoGameList.Location = new System.Drawing.Point(299, 12);
            this.gbVideoGameList.Name = "gbVideoGameList";
            this.gbVideoGameList.Size = new System.Drawing.Size(423, 537);
            this.gbVideoGameList.TabIndex = 2;
            this.gbVideoGameList.TabStop = false;
            this.gbVideoGameList.Text = "Videogame list";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(132, 491);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(299, 491);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbVideoGameList
            // 
            this.lbVideoGameList.DisplayMember = "Title";
            this.lbVideoGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbVideoGameList.FormattingEnabled = true;
            this.lbVideoGameList.ItemHeight = 16;
            this.lbVideoGameList.Location = new System.Drawing.Point(6, 22);
            this.lbVideoGameList.Name = "lbVideoGameList";
            this.lbVideoGameList.Size = new System.Drawing.Size(411, 452);
            this.lbVideoGameList.TabIndex = 6;
            this.lbVideoGameList.DoubleClick += new System.EventHandler(this.lbVideoGameList_DoubleClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEdit.Location = new System.Drawing.Point(6, 491);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.gbParams);
            this.gbSort.Controls.Add(this.gbOrder);
            this.gbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbSort.Location = new System.Drawing.Point(12, 420);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(281, 129);
            this.gbSort.TabIndex = 1;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "Sorting";
            // 
            // gbParams
            // 
            this.gbParams.Controls.Add(this.rbReleaseDate);
            this.gbParams.Controls.Add(this.rbTitle);
            this.gbParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gbParams.Location = new System.Drawing.Point(6, 22);
            this.gbParams.Name = "gbParams";
            this.gbParams.Size = new System.Drawing.Size(269, 48);
            this.gbParams.TabIndex = 1;
            this.gbParams.TabStop = false;
            this.gbParams.Text = "Properties";
            // 
            // rbReleaseDate
            // 
            this.rbReleaseDate.AutoSize = true;
            this.rbReleaseDate.Location = new System.Drawing.Point(165, 20);
            this.rbReleaseDate.Name = "rbReleaseDate";
            this.rbReleaseDate.Size = new System.Drawing.Size(88, 17);
            this.rbReleaseDate.TabIndex = 1;
            this.rbReleaseDate.Text = "Release date";
            this.rbReleaseDate.UseVisualStyleBackColor = true;
            // 
            // rbTitle
            // 
            this.rbTitle.AutoSize = true;
            this.rbTitle.Checked = true;
            this.rbTitle.Location = new System.Drawing.Point(16, 20);
            this.rbTitle.Name = "rbTitle";
            this.rbTitle.Size = new System.Drawing.Size(45, 17);
            this.rbTitle.TabIndex = 0;
            this.rbTitle.TabStop = true;
            this.rbTitle.Text = "Title";
            this.rbTitle.UseVisualStyleBackColor = true;
            this.rbTitle.CheckedChanged += new System.EventHandler(this.rbTitle_CheckedChanged);
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.rbDescending);
            this.gbOrder.Controls.Add(this.rbAscending);
            this.gbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gbOrder.Location = new System.Drawing.Point(6, 76);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(269, 47);
            this.gbOrder.TabIndex = 0;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order";
            // 
            // rbDescending
            // 
            this.rbDescending.AutoSize = true;
            this.rbDescending.Location = new System.Drawing.Point(163, 19);
            this.rbDescending.Name = "rbDescending";
            this.rbDescending.Size = new System.Drawing.Size(82, 17);
            this.rbDescending.TabIndex = 1;
            this.rbDescending.Text = "Descending";
            this.rbDescending.UseVisualStyleBackColor = true;
            // 
            // rbAscending
            // 
            this.rbAscending.AutoSize = true;
            this.rbAscending.Checked = true;
            this.rbAscending.Location = new System.Drawing.Point(16, 19);
            this.rbAscending.Name = "rbAscending";
            this.rbAscending.Size = new System.Drawing.Size(75, 17);
            this.rbAscending.TabIndex = 0;
            this.rbAscending.TabStop = true;
            this.rbAscending.Text = "Ascending";
            this.rbAscending.UseVisualStyleBackColor = true;
            this.rbAscending.CheckedChanged += new System.EventHandler(this.rbAscending_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.gbSort);
            this.Controls.Add(this.gbVideoGameList);
            this.Controls.Add(this.gbFiltration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Videogame Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.gbFiltration.ResumeLayout(false);
            this.gbReleaseDate.ResumeLayout(false);
            this.gbReleaseDate.PerformLayout();
            this.gbPlatform.ResumeLayout(false);
            this.gbPlatform.PerformLayout();
            this.gbGenre.ResumeLayout(false);
            this.gbGenre.PerformLayout();
            this.gbTitle.ResumeLayout(false);
            this.gbTitle.PerformLayout();
            this.gbVideoGameList.ResumeLayout(false);
            this.gbSort.ResumeLayout(false);
            this.gbParams.ResumeLayout(false);
            this.gbParams.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox cbReleaseDate;

        private System.Windows.Forms.TextBox tbFiltrationString;

        private System.Windows.Forms.RadioButton rbFiltrationTitle;
        private System.Windows.Forms.RadioButton rbFiltrationDeveloper;
        private System.Windows.Forms.RadioButton rbFiltrationPublisher;

        #endregion

        private System.Windows.Forms.GroupBox gbFiltration;
        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox gbVideoGameList;
        private System.Windows.Forms.GroupBox gbPlatform;
        private System.Windows.Forms.GroupBox gbGenre;
        private System.Windows.Forms.CheckBox cbiOS;
        private System.Windows.Forms.CheckBox cbAndroid;
        private System.Windows.Forms.CheckBox cbXbox;
        private System.Windows.Forms.CheckBox cbPlayStation;
        private System.Windows.Forms.CheckBox cbPC;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.RadioButton rbDescending;
        private System.Windows.Forms.RadioButton rbAscending;
        private System.Windows.Forms.GroupBox gbParams;
        private System.Windows.Forms.RadioButton rbReleaseDate;
        private System.Windows.Forms.RadioButton rbTitle;
        private System.Windows.Forms.ListBox lbVideoGameList;
        private System.Windows.Forms.GroupBox gbReleaseDate;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox cbRacing;
        private System.Windows.Forms.CheckBox cbAction;
        private System.Windows.Forms.CheckBox cbStrategy;
        private System.Windows.Forms.CheckBox cbAdventure;
        private System.Windows.Forms.CheckBox cbRPG;
    }
}