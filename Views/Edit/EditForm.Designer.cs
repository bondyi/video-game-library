namespace Views.Edit
{
    partial class EditForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tbAbout = new System.Windows.Forms.TextBox();
            this.lbAbout = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lbReleaseDate = new System.Windows.Forms.Label();
            this.gbPlatform = new System.Windows.Forms.GroupBox();
            this.cbiOS = new System.Windows.Forms.CheckBox();
            this.cbAndroid = new System.Windows.Forms.CheckBox();
            this.cbXbox = new System.Windows.Forms.CheckBox();
            this.cbPlayStation = new System.Windows.Forms.CheckBox();
            this.cbPC = new System.Windows.Forms.CheckBox();
            this.gbGenre = new System.Windows.Forms.GroupBox();
            this.cbRacing = new System.Windows.Forms.CheckBox();
            this.cbAction = new System.Windows.Forms.CheckBox();
            this.cbRPG = new System.Windows.Forms.CheckBox();
            this.cbStrategy = new System.Windows.Forms.CheckBox();
            this.cbAdventure = new System.Windows.Forms.CheckBox();
            this.tbDeveloper = new System.Windows.Forms.TextBox();
            this.lbDeveloper = new System.Windows.Forms.Label();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.lbWebsite = new System.Windows.Forms.Label();
            this.gbPlatform.SuspendLayout();
            this.gbGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(639, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbAbout
            // 
            this.tbAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbAbout.Location = new System.Drawing.Point(401, 9);
            this.tbAbout.Multiline = true;
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Size = new System.Drawing.Size(328, 294);
            this.tbAbout.TabIndex = 25;
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbAbout.Location = new System.Drawing.Point(317, 9);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(49, 17);
            this.lbAbout.TabIndex = 8;
            this.lbAbout.Text = "About:";
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTitle.Location = new System.Drawing.Point(116, 6);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(164, 23);
            this.tbTitle.TabIndex = 9;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(39, 17);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Title:";
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReleaseDate.Location = new System.Drawing.Point(116, 110);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(88, 23);
            this.dtpReleaseDate.TabIndex = 13;
            // 
            // lbReleaseDate
            // 
            this.lbReleaseDate.AutoSize = true;
            this.lbReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbReleaseDate.Location = new System.Drawing.Point(12, 113);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(96, 17);
            this.lbReleaseDate.TabIndex = 4;
            this.lbReleaseDate.Text = "Release date:";
            // 
            // gbPlatform
            // 
            this.gbPlatform.Controls.Add(this.cbiOS);
            this.gbPlatform.Controls.Add(this.cbAndroid);
            this.gbPlatform.Controls.Add(this.cbXbox);
            this.gbPlatform.Controls.Add(this.cbPlayStation);
            this.gbPlatform.Controls.Add(this.cbPC);
            this.gbPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gbPlatform.Location = new System.Drawing.Point(15, 139);
            this.gbPlatform.Name = "gbPlatform";
            this.gbPlatform.Size = new System.Drawing.Size(125, 140);
            this.gbPlatform.TabIndex = 5;
            this.gbPlatform.TabStop = false;
            this.gbPlatform.Text = "Platforms";
            // 
            // cbiOS
            // 
            this.cbiOS.AutoSize = true;
            this.cbiOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.95F);
            this.cbiOS.Location = new System.Drawing.Point(6, 112);
            this.cbiOS.Name = "cbiOS";
            this.cbiOS.Size = new System.Drawing.Size(43, 17);
            this.cbiOS.TabIndex = 18;
            this.cbiOS.Text = "iOS";
            this.cbiOS.UseVisualStyleBackColor = true;
            // 
            // cbAndroid
            // 
            this.cbAndroid.AutoSize = true;
            this.cbAndroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.95F);
            this.cbAndroid.Location = new System.Drawing.Point(6, 89);
            this.cbAndroid.Name = "cbAndroid";
            this.cbAndroid.Size = new System.Drawing.Size(62, 17);
            this.cbAndroid.TabIndex = 17;
            this.cbAndroid.Text = "Android";
            this.cbAndroid.UseVisualStyleBackColor = true;
            // 
            // cbXbox
            // 
            this.cbXbox.AutoSize = true;
            this.cbXbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.95F);
            this.cbXbox.Location = new System.Drawing.Point(6, 66);
            this.cbXbox.Name = "cbXbox";
            this.cbXbox.Size = new System.Drawing.Size(50, 17);
            this.cbXbox.TabIndex = 16;
            this.cbXbox.Text = "Xbox";
            this.cbXbox.UseVisualStyleBackColor = true;
            // 
            // cbPlayStation
            // 
            this.cbPlayStation.AutoSize = true;
            this.cbPlayStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.95F);
            this.cbPlayStation.Location = new System.Drawing.Point(6, 43);
            this.cbPlayStation.Name = "cbPlayStation";
            this.cbPlayStation.Size = new System.Drawing.Size(79, 17);
            this.cbPlayStation.TabIndex = 15;
            this.cbPlayStation.Text = "PlayStation";
            this.cbPlayStation.UseVisualStyleBackColor = true;
            // 
            // cbPC
            // 
            this.cbPC.AutoSize = true;
            this.cbPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.95F);
            this.cbPC.Location = new System.Drawing.Point(6, 20);
            this.cbPC.Name = "cbPC";
            this.cbPC.Size = new System.Drawing.Size(40, 17);
            this.cbPC.TabIndex = 14;
            this.cbPC.Text = "PC";
            this.cbPC.UseVisualStyleBackColor = true;
            // 
            // gbGenre
            // 
            this.gbGenre.Controls.Add(this.cbRacing);
            this.gbGenre.Controls.Add(this.cbAction);
            this.gbGenre.Controls.Add(this.cbRPG);
            this.gbGenre.Controls.Add(this.cbStrategy);
            this.gbGenre.Controls.Add(this.cbAdventure);
            this.gbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gbGenre.Location = new System.Drawing.Point(146, 139);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(125, 140);
            this.gbGenre.TabIndex = 6;
            this.gbGenre.TabStop = false;
            this.gbGenre.Text = "Genres";
            // 
            // cbRacing
            // 
            this.cbRacing.AutoSize = true;
            this.cbRacing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbRacing.Location = new System.Drawing.Point(6, 112);
            this.cbRacing.Name = "cbRacing";
            this.cbRacing.Size = new System.Drawing.Size(60, 17);
            this.cbRacing.TabIndex = 31;
            this.cbRacing.Text = "Racing";
            this.cbRacing.UseVisualStyleBackColor = true;
            // 
            // cbAction
            // 
            this.cbAction.AutoSize = true;
            this.cbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbAction.Location = new System.Drawing.Point(6, 20);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(56, 17);
            this.cbAction.TabIndex = 27;
            this.cbAction.Text = "Action";
            this.cbAction.UseVisualStyleBackColor = true;
            // 
            // cbRPG
            // 
            this.cbRPG.AutoSize = true;
            this.cbRPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbRPG.Location = new System.Drawing.Point(6, 66);
            this.cbRPG.Name = "cbRPG";
            this.cbRPG.Size = new System.Drawing.Size(49, 17);
            this.cbRPG.TabIndex = 29;
            this.cbRPG.Text = "RPG";
            this.cbRPG.UseVisualStyleBackColor = true;
            // 
            // cbStrategy
            // 
            this.cbStrategy.AutoSize = true;
            this.cbStrategy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbStrategy.Location = new System.Drawing.Point(6, 89);
            this.cbStrategy.Name = "cbStrategy";
            this.cbStrategy.Size = new System.Drawing.Size(65, 17);
            this.cbStrategy.TabIndex = 30;
            this.cbStrategy.Text = "Strategy";
            this.cbStrategy.UseVisualStyleBackColor = true;
            // 
            // cbAdventure
            // 
            this.cbAdventure.AutoSize = true;
            this.cbAdventure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbAdventure.Location = new System.Drawing.Point(6, 43);
            this.cbAdventure.Name = "cbAdventure";
            this.cbAdventure.Size = new System.Drawing.Size(75, 17);
            this.cbAdventure.TabIndex = 28;
            this.cbAdventure.Text = "Adventure";
            this.cbAdventure.UseVisualStyleBackColor = true;
            // 
            // tbDeveloper
            // 
            this.tbDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbDeveloper.Location = new System.Drawing.Point(116, 32);
            this.tbDeveloper.Name = "tbDeveloper";
            this.tbDeveloper.Size = new System.Drawing.Size(164, 23);
            this.tbDeveloper.TabIndex = 10;
            // 
            // lbDeveloper
            // 
            this.lbDeveloper.AutoSize = true;
            this.lbDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDeveloper.Location = new System.Drawing.Point(12, 35);
            this.lbDeveloper.Name = "lbDeveloper";
            this.lbDeveloper.Size = new System.Drawing.Size(77, 17);
            this.lbDeveloper.TabIndex = 1;
            this.lbDeveloper.Text = "Developer:";
            // 
            // tbPublisher
            // 
            this.tbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPublisher.Location = new System.Drawing.Point(116, 58);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(164, 23);
            this.tbPublisher.TabIndex = 11;
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPublisher.Location = new System.Drawing.Point(12, 61);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(71, 17);
            this.lbPublisher.TabIndex = 2;
            this.lbPublisher.Text = "Publisher:";
            // 
            // tbWebsite
            // 
            this.tbWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbWebsite.Location = new System.Drawing.Point(116, 84);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(164, 23);
            this.tbWebsite.TabIndex = 12;
            // 
            // lbWebsite
            // 
            this.lbWebsite.AutoSize = true;
            this.lbWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbWebsite.Location = new System.Drawing.Point(12, 87);
            this.lbWebsite.Name = "lbWebsite";
            this.lbWebsite.Size = new System.Drawing.Size(63, 17);
            this.lbWebsite.TabIndex = 3;
            this.lbWebsite.Text = "Website:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 361);
            this.ControlBox = false;
            this.Controls.Add(this.tbWebsite);
            this.Controls.Add(this.lbWebsite);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.lbPublisher);
            this.Controls.Add(this.tbDeveloper);
            this.Controls.Add(this.lbDeveloper);
            this.Controls.Add(this.gbPlatform);
            this.Controls.Add(this.gbGenre);
            this.Controls.Add(this.lbReleaseDate);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.tbAbout);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EditForm";
            this.TopMost = true;
            this.gbPlatform.ResumeLayout(false);
            this.gbPlatform.PerformLayout();
            this.gbGenre.ResumeLayout(false);
            this.gbGenre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbAbout;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label lbReleaseDate;
        private System.Windows.Forms.GroupBox gbPlatform;
        private System.Windows.Forms.CheckBox cbiOS;
        private System.Windows.Forms.CheckBox cbAndroid;
        private System.Windows.Forms.CheckBox cbXbox;
        private System.Windows.Forms.CheckBox cbPlayStation;
        private System.Windows.Forms.CheckBox cbPC;
        private System.Windows.Forms.GroupBox gbGenre;
        private System.Windows.Forms.TextBox tbDeveloper;
        private System.Windows.Forms.Label lbDeveloper;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.Label lbWebsite;
        private System.Windows.Forms.CheckBox cbRacing;
        private System.Windows.Forms.CheckBox cbAction;
        private System.Windows.Forms.CheckBox cbRPG;
        private System.Windows.Forms.CheckBox cbStrategy;
        private System.Windows.Forms.CheckBox cbAdventure;
    }
}