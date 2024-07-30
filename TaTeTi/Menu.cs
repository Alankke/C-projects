using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaTeTi
{
    public partial class MenuWindow : Form
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void jugarButton_Click(object sender, EventArgs e)
        {
            if (player1TextBox != null && player2TextBox != null)
            {
                MainWindow mainWindow = new(player1TextBox.Text.Trim(), player2TextBox.Text.Trim());
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Debe introducir los nombres de los jugadores", "Dato Faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
