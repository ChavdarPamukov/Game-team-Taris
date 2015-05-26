using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftUni_Battle_In_The_Sea.Forms
{
    public partial class PopupNotificationForm : Form
    {
        private String _defaultText = "The point of the game is to guess which \n" + 
                                        "cell contains the enemy ship.\n"+
                                        "On the first stage, you need to specify the cell,\n" +
                                        "which will contain your OWN ship\n"+
                                        "On the second stage, you start guessing enemy cells,\n" +
                                        "hoping that one of them will contain their ship.\n"+
                                        "To EXIT the application at any point, simply type in 'exit',\n"+
                                       "in the popup text box and hit Enter, or press OK";
      
        public PopupNotificationForm()
        {
            InitializeComponent();
            this.SetText(this._defaultText);
        }

        public void SetText(String text)
        {
            this.label1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopupNotificationForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
