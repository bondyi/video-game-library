using System.Windows.Forms;
using Presenters.Main;
using System;
using System.ComponentModel;
using Models.VideoGameModel;
using Models.ServiceModels;
using Presenters.Details;
using Views.Details;
using Views.Edit;

namespace Views.Main
{
    public partial class MainForm : Form, IMainView
    {
        private readonly IMainPresenter _presenter;

        public string FiltrationString => tbFiltrationString.Text;

        public bool FiltrationTitle => rbFiltrationTitle.Checked;
        public bool FiltrationDeveloper => rbFiltrationDeveloper.Checked;
        public bool FiltrationPublisher => rbFiltrationPublisher.Checked;

        public bool ReleaseDate => cbReleaseDate.Checked;
        public DateTime DateTimeFrom => dtpFrom.Value;
        public DateTime DateTimeTo => dtpTo.Value;

        public bool PC => cbPC.Checked;
        public bool PlayStation => cbPlayStation.Checked;
        public bool Xbox => cbXbox.Checked;
        public bool Android => cbAndroid.Checked;
        public bool iOS => cbiOS.Checked;

        public bool Action => cbAction.Checked;
        public bool Adventure => cbAdventure.Checked;
        public bool RPG => cbRPG.Checked;
        public bool Strategy => cbStrategy.Checked;
        public bool Racing => cbRacing.Checked;

        public bool SortByTitle => rbTitle.Checked;

        public bool SortByAscending => rbAscending.Checked;

        public BindingList<VideoGame> VideoGameList
        {
            get => lbVideoGameList.DataSource as BindingList<VideoGame>;
            set => lbVideoGameList.DataSource = value;
        }

        public MainForm()
        {
            InitializeComponent();

            _presenter = new MainPresenter(this);
        }

        public void Message(string text, string caption)
        {
            MessageBox.Show(
                text, 
                caption, 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button1, 
                MessageBoxOptions.DefaultDesktopOnly);
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new EditForm(false).ShowDialog();
            
            lbVideoGameList.BeginUpdate();
            _presenter.AddVideoGame();
            lbVideoGameList.EndUpdate();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbVideoGameList.Items.Count == 0) { Message("Choose a video game!", "Message"); return; }

            var result = MessageBox.Show(
                "Are you sure you want to delete the selected video game?", 
                "Confirmation", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button1, 
                MessageBoxOptions.DefaultDesktopOnly);

            if (result != DialogResult.Yes) return;
            
            lbVideoGameList.BeginUpdate();
            _presenter.DeleteVideoGame((VideoGame)lbVideoGameList.SelectedItem);
            lbVideoGameList.EndUpdate();
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbVideoGameList.Items.Count > 0)
            {
                VideoGameService.Game = (VideoGame)lbVideoGameList.SelectedItem;
                new EditForm(true).ShowDialog();
                
                lbVideoGameList.BeginUpdate();
                _presenter.EditVideoGame();
                lbVideoGameList.EndUpdate();
            }
            else Message("Choose a video game!", "Message"); 
        }
        
        private void btnFind_Click(object sender, EventArgs e)
        {
            lbVideoGameList.BeginUpdate();
            _presenter.Find();
            lbVideoGameList.EndUpdate();
        }
        
        private void cbReleaseDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReleaseDate.Checked)
            {
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
            }
            else
            {
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
            }
        }
        
        private void rbTitle_CheckedChanged(object sender, EventArgs e) => _presenter.Sort();
        private void rbAscending_CheckedChanged(object sender, EventArgs e) => _presenter.Sort();

        private void lbVideoGameList_DoubleClick(object sender, EventArgs e)
        {
            if (lbVideoGameList.Items.Count == 0) return;

            VideoGameService.Game = (VideoGame) lbVideoGameList.SelectedItem;
            new DetailsForm().Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => _presenter.Serialize();
    }
}
