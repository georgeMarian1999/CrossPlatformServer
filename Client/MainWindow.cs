using Model.Model;
using Problem11.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MainWindow : Form
    {
        private List<DTOBJCursa> Curse ;
        private List<DTOBJPart> Participanti ;
        private readonly ClientCtrl ctrl;
        public MainWindow(ClientCtrl Ctrl)
        {
            InitializeComponent();
            this.ctrl = Ctrl;
            this.Curse = ctrl.getCurrent();
            InitCapacitateBox();
            PopulateCurseTabel();
            PopulateParticipantiTabel();

            ctrl.updateEvent += Update;
        }
        private void updateTabelList(DataGridView dataGridView,List<DTOBJCursa> newdata)
        {

            dataGridView.DataSource = null;
            dataGridView.DataSource = newdata;
        

        }
        public delegate void UpdateTabelListCallback(DataGridView dataGridView, List<DTOBJCursa> data);
        
        public void Update(object sender,UserEventArgs e)
        {
            if (e.EventType == Event.NEW_SUBMIT)
            {
                DTOBJCursa[] dTOBJCursa = (DTOBJCursa[])e.Data;
                this.Curse.Clear();
                foreach (DTOBJCursa c in dTOBJCursa)
                {
                    this.Curse.Add(c);
                }
                CurseTabel.BeginInvoke(new UpdateTabelListCallback(this.updateTabelList), new Object[] { CurseTabel, this.Curse });
            }
        }
        private void InitCapacitateBox()
        {
            for (int i = 0; i < this.Curse.Count(); i++)
            {
                this.CapacitateBox.Items.Add(this.Curse.ElementAt(i).Capacitate);
            }
        }
        private void PopulateParticipantiTabel()
        {
            this.PartTabel.AutoGenerateColumns = false;
            this.PartTabel.AllowUserToAddRows = false;
            //this.PartTabel.DataSource = this.Participanti;

            DataGridViewTextBoxColumn columnID = new DataGridViewTextBoxColumn();
            columnID.Name = "IdParticipant";
            columnID.HeaderText = "Id Participant";
            columnID.DataPropertyName = "idParticipant";
            this.PartTabel.Columns.Add(columnID);

            DataGridViewTextBoxColumn columnNume = new DataGridViewTextBoxColumn();
            columnNume.Name = "Nume";
            columnNume.HeaderText = "Nume";
            columnNume.DataPropertyName = "Nume";
            this.PartTabel.Columns.Add(columnNume);

            DataGridViewTextBoxColumn columnCapacitate = new DataGridViewTextBoxColumn();
            columnCapacitate.Name = "Capacitate";
            columnCapacitate.HeaderText = "Capacitate";
            columnCapacitate.DataPropertyName = "Capacitate";
            this.PartTabel.Columns.Add(columnCapacitate);
        }
        private void PopulateCurseTabel()

        {
            this.CurseTabel.AutoGenerateColumns = false;
            this.CurseTabel.AllowUserToAddRows = false;
            this.CurseTabel.DataSource = this.Curse;

            DataGridViewTextBoxColumn columnID = new DataGridViewTextBoxColumn();
            columnID.Name = "IdCursa";
            columnID.HeaderText = "Id Cursa";
            columnID.DataPropertyName = "IdCursa";
            this.CurseTabel.Columns.Add(columnID);

            DataGridViewTextBoxColumn columnCapacitate = new DataGridViewTextBoxColumn();
            columnCapacitate.Name = "Capacitate";
            columnCapacitate.HeaderText = "Capacitate";
            columnCapacitate.DataPropertyName = "Capacitate";
            this.CurseTabel.Columns.Add(columnCapacitate);

            DataGridViewTextBoxColumn columnNr = new DataGridViewTextBoxColumn();
            columnNr.Name = "NrInscrisi";
            columnNr.HeaderText = "Nr Inscrisi";
            columnNr.DataPropertyName = "NrInscrisi";
            this.CurseTabel.Columns.Add(columnNr);
        }

        private void LogoutBttnClick(object sender, EventArgs e)
        {
            ctrl.logout();
            Application.Exit();
        }
        private void DeletePartTabel()
        {
            this.PartTabel.DataSource = null;
            //this.PartTabel.Refresh();
        }
        private void handleClear_Search(object sender, EventArgs e)
        {
            this.SearchTextBox.Text = "";
            DeletePartTabel();
        }

        private void handleSearch(object sender, EventArgs e)
        {
            String Team = this.SearchTextBox.Text;
            this.Participanti = ctrl.searchByTeam(Team);
            this.PartTabel.DataSource = this.Participanti;
        }

        private void handleSubmit(object sender, EventArgs e)
        {
            String capacitateString = this.CapacitateBox.SelectedItem.ToString();
            int capacitate = int.Parse(capacitateString);
            string numepart = this.NumePartTxt.Text;
            string numeechipa = this.NumeEchipaTxt.Text;
            DTOInfoSubmit infoSubmit = new DTOInfoSubmit(capacitate, numepart, numeechipa);
            ctrl.submit_insc(infoSubmit);
            MessageBox.Show("Participant inscris cu succes");
            this.NumePartTxt.Text = "";
            this.NumeEchipaTxt.Text = "";
        }

        private void ClearInscText(object sender, EventArgs e)
        {
            this.NumePartTxt.Text = "";
            this.NumeEchipaTxt.Text = "";
        }
    }
}
