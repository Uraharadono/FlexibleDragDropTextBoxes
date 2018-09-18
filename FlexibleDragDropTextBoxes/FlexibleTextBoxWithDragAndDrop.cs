using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FlexibleDragDropTextBoxes
{
    public partial class FlexibleTextBoxWithDragAndDrop : Form
    {
        // Used as data source for propertiesListBox
        private List<string> registeredSampleProperties = new List<string>();

        // Used to reset all of the data in propertiesListBox
        private readonly List<string> registeredSamplePropertiesBackupData;
        // Index of selected item
        private int selectedPropertyItemIndex { get; set; }

        // Set enum that controls type of selection
        private Mode selectionMode = Mode.Select;

        public FlexibleTextBoxWithDragAndDrop()
        {
            InitializeComponent();

            for (int i = 0; i < 20; i++)
            {
                registeredSampleProperties.Add($"Item {i}");
            }

            registeredSamplePropertiesBackupData = registeredSampleProperties;
            propertiesListBox.DataSource = registeredSampleProperties;
        }


        /* *****************************************************
         * PropertiesListBox events
         ***************************************************** */
        private void propertiesListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox chk = sender as ListBox;
            if (chk == null) return;
            selectedPropertyItemIndex = chk.IndexFromPoint(e.X, e.Y);

            if (selectedPropertyItemIndex >= 0 & e.Button == MouseButtons.Left)
                chk.DoDragDrop(chk.Items[selectedPropertyItemIndex].ToString(), DragDropEffects.Move);
        }


        /* *****************************************************
         * Drawing panel events
         ***************************************************** */
        private void drawingPanel_DragEnter(object sender, DragEventArgs e)
        {
            //  e.Effect = e.Data.GetDataPresent(typeof(string)) ? DragDropEffects.Move : DragDropEffects.None; // used this one to check if it's checkbox
            e.Effect = DragDropEffects.Move;
        }
        private void drawingPanel_DragDrop(object sender, DragEventArgs e)
        {
            // Literally means, If we dragged from propertiesListBox on top right of form
            if (e.Data.GetData(e.Data.GetFormats()[0]) is string)
            {
                var selectedListItem = e.Data.GetData(typeof(string)).ToString();

                #region Old method - no resize
                // TextBox txt = new TextBox();
                // txt.Width = 370;
                // txt.Height = 30;
                // txt.ReadOnly = true;
                // txt.Text = selectedListItem;
                // var locationOnForm = drawingPanel.PointToClient(new Point(e.X, e.Y));

                // if (locationOnForm.X + txt.Width > drawingPanel.Width)
                //     locationOnForm.X = drawingPanel.Width - txt.Width;

                // if (locationOnForm.Y + txt.Height > drawingPanel.Height)
                //     locationOnForm.Y = drawingPanel.Height - txt.Height;

                // if (locationOnForm.X < 0)
                //     locationOnForm.X = 0;

                // if (locationOnForm.Y < 0)
                //     locationOnForm.Y = 0;

                // var x = locationOnForm.X / 8 * 8;
                // var y = locationOnForm.Y / 8 * 8;

                // var snappedLocation = new Point(x, y);

                // txt.Location = snappedLocation;

                // txt.Parent = drawingPanel;

                // txt.MouseDown += c_MouseDown;
                // txt.KeyPress += t_KeyPress;
                // txt.KeyDown += t_KeyDown;
                #endregion

                FlexibleTextBoxControl txt = new FlexibleTextBoxControl();
                txt.ReadOnly = true;
                txt.Text = selectedListItem;
                txt.Parent = drawingPanel;

                // Add newly generated textbox to this panel
                drawingPanel.Controls.Add(txt);
                // then remove this label from our list box
                RemoveAndRebindPropertiesListBoxDataGrid(selectedListItem);
            }
        }
        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectionMode == Mode.TextBox)
            {
                FlexibleTextBoxControl textbox = new FlexibleTextBoxControl();
                textbox.Location = e.Location;
                drawingPanel.Controls.Add(textbox);

                // Return to Select Mode
                SetSelectionMode();
            }
        }


        /* *****************************************************
         * Button events
         ***************************************************** */
        private void resetBtn_Click(object sender, EventArgs e)
        {
            propertiesListBox.DataSource = null;
            propertiesListBox.DataSource = registeredSamplePropertiesBackupData;
            drawingPanel.Controls.Clear();
        }
        private void addNewTextBox_Click(object sender, EventArgs e)
        {
            selectionMode = Mode.TextBox;
        }


        /* *****************************************************
         * Utilities
         ***************************************************** */
        private void SetSelectionMode()
        {
            selectionMode = Mode.TextBox;
        }

        private void RemoveAndRebindPropertiesListBoxDataGrid(string valToRemove)
        {
            registeredSampleProperties = registeredSampleProperties.Where(s => s != valToRemove).ToList();
            propertiesListBox.DataSource = null;
            propertiesListBox.DataSource = registeredSampleProperties;
        }
    }
}
