using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadsorTails
{
    public partial class headsOrTailsForm : Form
    {
        public headsOrTailsForm()
        {
            InitializeComponent();
        }
        
        private void showHeadsButton_Click(object sender, EventArgs e)
        {
            // when heads button is clicked, picture box is displayed, tails picture box is hidden
            headsPictureBox.Visible = true;
            tailsPictureBox.Visible = false;
        }

        private void showTailsButton_Click(object sender, EventArgs e)
        {
            //when tails button is clicked, tails picture box is displayed and heads picture box is hidden
            tailsPictureBox.Visible = true;
            headsPictureBox.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //when exit button is clicked, the form closes
            this.Close();
        }
    }
}
