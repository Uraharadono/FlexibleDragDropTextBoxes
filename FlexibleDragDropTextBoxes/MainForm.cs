using System;
using System.Windows.Forms;

namespace FlexibleDragDropTextBoxes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void resizableBtn_Click(object sender, EventArgs e)
        {
            FlexibleTextBox frm = new FlexibleTextBox();
            frm.Show();
        }

        private void resizableDragDropBtn_Click(object sender, EventArgs e)
        {
            FlexibleTextBoxWithDragAndDrop frm = new FlexibleTextBoxWithDragAndDrop();
            frm.Show();
        }
    }
}
