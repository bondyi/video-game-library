using System;
using System.Windows.Forms;
using Presenters.Details;
using Models.ServiceModels;

namespace Views.Details
{
    public partial class DetailsForm : Form, IDetailsView
    {
        private readonly IDetailsPresenter _presenter;

        public string Title { get => lbTitle.Text; set => lbTitle.Text = value; }
        public string About { get => tbAbout.Text; set => tbAbout.Text = value; }
        public string Platforms { get => lbPlatforms.Text; set => lbPlatforms.Text = value; }
        public string Genres { get => lbGenres.Text; set => lbGenres.Text = value; }
        public string ReleaseDate { get => lbReleaseDate.Text; set => lbReleaseDate.Text = value; }
        public string Developer { get => lbDeveloper.Text; set => lbDeveloper.Text = value; }
        public string Publisher { get => lbPublisher.Text; set => lbPublisher.Text = value; }

        public DetailsForm()
        {
            InitializeComponent();

            _presenter = new DetailsPresenter(this);
        }

        private void DetailsForm_Load(object sender, EventArgs e) => _presenter.LoadInfo();

        private void llWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(VideoGameService.Website);
        }
    }
}