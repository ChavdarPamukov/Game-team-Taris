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
    public partial class PopupInputForm : Form
    {
        public PopupInputForm()
        {
            InitializeComponent();
        }

        public void SetLabel(String label)
        {
            this.label2.Text = label;
            this.textBox1.Focus();
            this.textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String GetUserInput()
        {
            return this.textBox1.Text;
        }

        private void PopupInputForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void TextBoxKeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        this.button1_Click(sender, e);
        //        e.Handled = true;
        //    }
        //}

        //private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.textBox1.Text = "-2";
        //    this.Close();
        //}

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    this.textBox1.Text = "-2";
        //    Application.Exit();
        //}
    }
}
