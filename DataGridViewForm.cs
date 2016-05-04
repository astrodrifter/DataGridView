using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataViewGrid_Example {

    public partial class DataGridViewForm : Form {

        BindingList<Player> players = new BindingList<Player>();

        private int numberofPlayers = 0;
        private const int MAX_PLAYERS = 10;

        private string[] defaultNames = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

        /// <summary>
        /// The form's constructor.
        /// </summary>
        public DataGridViewForm() {
            InitializeComponent();
            playerBindingSource.DataSource = players;
        }

        /// <summary>
        /// Event-handler for when the "Add player" button is clicked.
        /// </summary>
        private void addPlayerButton_Click(object sender, EventArgs e) {

            if (numberofPlayers < MAX_PLAYERS) {
                players.Add(new Player(defaultNames[numberofPlayers]));
                numberofPlayers += 1;
                //RefreshPlayersInfoInDataGridView();
            } else {
                MessageBox.Show("No more players allowed.");
            }
        } // end addPlayerButton_Click

        /// <summary>
        /// Event-handler for when the "Add player" button is clicked.
        /// </summary>
        private void showValuesButton_Click(object sender, EventArgs e) {
            string message = "";
            foreach (Player player in players) {
                message += player.Name + "\t" + player.GamePoints + "\t" + player.HighestPoints + "\n";
            }
            MessageBox.Show(message);

        } // end showValuesButton_Click

        /// <summary>
        /// Closes the form whenever the Escape key is pressed.  You can ignore this code.
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Escape) {
                Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        } // end ProcessCmdKey

    }
}
