namespace Views.Details
{
    partial class DetailsForm
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbReleaseDate = new System.Windows.Forms.Label();
            this.llWebsite = new System.Windows.Forms.LinkLabel();
            this.lbPlatformsView = new System.Windows.Forms.Label();
            this.lbPlatforms = new System.Windows.Forms.Label();
            this.lbGenresView = new System.Windows.Forms.Label();
            this.lbGenres = new System.Windows.Forms.Label();
            this.lbDeveloperView = new System.Windows.Forms.Label();
            this.lbDeveloper = new System.Windows.Forms.Label();
            this.lbPublisherView = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lbAboutView = new System.Windows.Forms.Label();
            this.tbAbout = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lbTitle.Location = new System.Drawing.Point(9, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(94, 31);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "lbTitle";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbReleaseDate
            // 
            this.lbReleaseDate.AutoSize = true;
            this.lbReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbReleaseDate.Location = new System.Drawing.Point(12, 45);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(115, 20);
            this.lbReleaseDate.TabIndex = 1;
            this.lbReleaseDate.Text = "lbReleaseDate";
            this.lbReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llWebsite
            // 
            this.llWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.llWebsite.Location = new System.Drawing.Point(12, 146);
            this.llWebsite.Name = "llWebsite";
            this.llWebsite.Size = new System.Drawing.Size(418, 22);
            this.llWebsite.TabIndex = 2;
            this.llWebsite.TabStop = true;
            this.llWebsite.Text = "Website";
            this.llWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llWebsite_LinkClicked);
            // 
            // lbPlatformsView
            // 
            this.lbPlatformsView.AutoSize = true;
            this.lbPlatformsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPlatformsView.Location = new System.Drawing.Point(12, 129);
            this.lbPlatformsView.Name = "lbPlatformsView";
            this.lbPlatformsView.Size = new System.Drawing.Size(71, 17);
            this.lbPlatformsView.TabIndex = 3;
            this.lbPlatformsView.Text = "Platforms:";
            // 
            // lbPlatforms
            // 
            this.lbPlatforms.AutoSize = true;
            this.lbPlatforms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lbPlatforms.Location = new System.Drawing.Point(116, 130);
            this.lbPlatforms.Name = "lbPlatforms";
            this.lbPlatforms.Size = new System.Drawing.Size(86, 16);
            this.lbPlatforms.TabIndex = 6;
            this.lbPlatforms.Text = "lbPlatforms";
            // 
            // lbGenresView
            // 
            this.lbGenresView.AutoSize = true;
            this.lbGenresView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGenresView.Location = new System.Drawing.Point(12, 112);
            this.lbGenresView.Name = "lbGenresView";
            this.lbGenresView.Size = new System.Drawing.Size(59, 17);
            this.lbGenresView.TabIndex = 7;
            this.lbGenresView.Text = "Genres:";
            // 
            // lbGenres
            // 
            this.lbGenres.AutoSize = true;
            this.lbGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lbGenres.Location = new System.Drawing.Point(116, 113);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.Size = new System.Drawing.Size(71, 16);
            this.lbGenres.TabIndex = 8;
            this.lbGenres.Text = "lbGenres";
            // 
            // lbDeveloperView
            // 
            this.lbDeveloperView.AutoSize = true;
            this.lbDeveloperView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDeveloperView.Location = new System.Drawing.Point(12, 78);
            this.lbDeveloperView.Name = "lbDeveloperView";
            this.lbDeveloperView.Size = new System.Drawing.Size(77, 17);
            this.lbDeveloperView.TabIndex = 9;
            this.lbDeveloperView.Text = "Developer:";
            // 
            // lbDeveloper
            // 
            this.lbDeveloper.AutoSize = true;
            this.lbDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lbDeveloper.Location = new System.Drawing.Point(116, 79);
            this.lbDeveloper.Name = "lbDeveloper";
            this.lbDeveloper.Size = new System.Drawing.Size(94, 16);
            this.lbDeveloper.TabIndex = 10;
            this.lbDeveloper.Text = "lbDeveloper";
            // 
            // lbPublisherView
            // 
            this.lbPublisherView.AutoSize = true;
            this.lbPublisherView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPublisherView.Location = new System.Drawing.Point(12, 95);
            this.lbPublisherView.Name = "lbPublisherView";
            this.lbPublisherView.Size = new System.Drawing.Size(71, 17);
            this.lbPublisherView.TabIndex = 11;
            this.lbPublisherView.Text = "Publisher:";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lbPublisher.Location = new System.Drawing.Point(116, 96);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(86, 16);
            this.lbPublisher.TabIndex = 12;
            this.lbPublisher.Text = "lbPublisher";
            // 
            // lbAboutView
            // 
            this.lbAboutView.AutoSize = true;
            this.lbAboutView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAboutView.Location = new System.Drawing.Point(12, 207);
            this.lbAboutView.Name = "lbAboutView";
            this.lbAboutView.Size = new System.Drawing.Size(56, 20);
            this.lbAboutView.TabIndex = 13;
            this.lbAboutView.Text = "About:";
            // 
            // tbAbout
            // 
            this.tbAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbAbout.Location = new System.Drawing.Point(12, 230);
            this.tbAbout.Multiline = true;
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.ReadOnly = true;
            this.tbAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAbout.Size = new System.Drawing.Size(468, 319);
            this.tbAbout.TabIndex = 14;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 561);
            this.Controls.Add(this.tbAbout);
            this.Controls.Add(this.lbAboutView);
            this.Controls.Add(this.lbPublisher);
            this.Controls.Add(this.lbPublisherView);
            this.Controls.Add(this.lbDeveloper);
            this.Controls.Add(this.lbDeveloperView);
            this.Controls.Add(this.lbGenres);
            this.Controls.Add(this.lbGenresView);
            this.Controls.Add(this.lbPlatforms);
            this.Controls.Add(this.lbPlatformsView);
            this.Controls.Add(this.llWebsite);
            this.Controls.Add(this.lbReleaseDate);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbAbout;

        private System.Windows.Forms.Label lbAboutView;

        private System.Windows.Forms.Label lbPublisherView;
        private System.Windows.Forms.Label lbPublisher;

        private System.Windows.Forms.Label lbDeveloperView;

        private System.Windows.Forms.Label lbDeveloper;

        private System.Windows.Forms.Label lbGenres;
        private System.Windows.Forms.Label lbGenresView;

        private System.Windows.Forms.Label lbPlatforms;
        private System.Windows.Forms.Label lbPlatformsView;

        private System.Windows.Forms.LinkLabel llWebsite;

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbReleaseDate;
    }
}