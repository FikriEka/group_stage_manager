using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForm___Group_Stage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTeamList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            TeamList.Add(new Team(inputTeamTextBox.Text));
            updateTeamListBox();

            // Set the InputTeamTextBox empty
            inputTeamTextBox.Text = "";
            inputTeamTextBox.Focus();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            TeamList.RemoveAt(teamListBox.SelectedIndex);
            updateTeamListBox();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            inputTeamTextBox.Enabled = false;
            submitButton.Enabled = false;
            removeButton.Enabled = false;

            generateTableStandingDataGrid();
        }

        private void updateTeamListBox()
        {
            teamListBox.DataSource = TeamList;
            teamListBox.DisplayMember = "Name";
        }

        private void generateTableStandingDataGrid()
        {
            List<Team> teams = TeamList.ToList();
            int rank = 0;
            var columns = from t in teams
                          orderby t.Name
                          select new
                          {
                              Rank = ++rank,
                              Name = t.Name,
                              MP = t.MatchPlayed,
                              Win = t.Win,
                              Draw = t.Draw,
                              Lose = t.Lose,
                              SF = t.ScoredFor,
                              SA = t.ScoredAgainst,
                              SD = t.ScoreDiff,
                              Points = t.Points
                          };

            tableStandingDataGrid.DataSource = columns.ToList();
            tableStandingDataGrid.AutoResizeColumns();
        }
    }
}
