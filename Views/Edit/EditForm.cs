using System.Windows.Forms;
using Presenters.Edit;
using System;
using Models.VideoGameModel;
using Models.ServiceModels;

namespace Views.Edit
{
    public partial class EditForm : Form, IEditView
    {
        private readonly IEditPresenter _presenter;
        
        public string FormName { set => Text = value; }

        public string Title { get => tbTitle.Text; set => tbTitle.Text = value; }
        public string Developer { get => tbDeveloper.Text; set => tbDeveloper.Text = value; }
        public string Publisher { get => tbPublisher.Text; set => tbPublisher.Text = value; }
        public string Website { get => tbWebsite.Text; set => tbWebsite.Text = value; }
        public DateTime ReleaseDate { get => dtpReleaseDate.Value; set => dtpReleaseDate.Value = value; }
        
        public bool PC { get => cbPC.Checked; set => cbPC.Checked = value; }
        public bool PlayStation { get => cbPlayStation.Checked; set => cbPlayStation.Checked = value; }
        public bool Xbox { get => cbXbox.Checked; set => cbXbox.Checked = value; }
        public bool Android { get => cbAndroid.Checked; set => cbAndroid.Checked = value; }
        public bool iOS { get => cbiOS.Checked; set => cbiOS.Checked = value; }

        public bool Action { get => cbAction.Checked; set => cbAction.Checked = value; }
        public bool Adventure { get => cbAdventure.Checked; set => cbAdventure.Checked = value; }
        public bool RPG { get => cbRPG.Checked; set => cbRPG.Checked = value; }
        public bool Strategy { get => cbStrategy.Checked; set => cbStrategy.Checked = value; }
        public bool Racing { get => cbRacing.Checked; set => cbRacing.Checked = value; }
        
        public string About { get => tbAbout.Text; set => tbAbout.Text = value; }

        public EditForm(bool editMode)
        {
            InitializeComponent();

            _presenter = new EditPresenter(this, editMode);
            if (editMode) _presenter.LoadInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_presenter.EditMode) VideoGameService.Game = new VideoGame();
            if (_presenter.CollectInfo()) Close();
            else MessageBox.Show(
                "Invalid data!", 
                "Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error, 
                MessageBoxDefaultButton.Button1, 
                MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
