namespace FlexibleDragDropTextBoxes
{
    partial class FlexibleTextBoxWithDragAndDrop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertiesListBox = new System.Windows.Forms.ListBox();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            this.addNewTextBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // propertiesListBox
            // 
            this.propertiesListBox.FormattingEnabled = true;
            this.propertiesListBox.Location = new System.Drawing.Point(536, 116);
            this.propertiesListBox.Name = "propertiesListBox";
            this.propertiesListBox.Size = new System.Drawing.Size(252, 329);
            this.propertiesListBox.TabIndex = 0;
            this.propertiesListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.propertiesListBox_MouseDown);
            // 
            // drawingPanel
            // 
            this.drawingPanel.AllowDrop = true;
            this.drawingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawingPanel.Location = new System.Drawing.Point(12, 12);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(518, 433);
            this.drawingPanel.TabIndex = 1;
            this.drawingPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.drawingPanel_DragDrop);
            this.drawingPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.drawingPanel_DragEnter);
            this.drawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseClick);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(536, 12);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(118, 37);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // addNewTextBox
            // 
            this.addNewTextBox.Location = new System.Drawing.Point(537, 55);
            this.addNewTextBox.Name = "addNewTextBox";
            this.addNewTextBox.Size = new System.Drawing.Size(117, 39);
            this.addNewTextBox.TabIndex = 3;
            this.addNewTextBox.Text = "Add new";
            this.addNewTextBox.UseVisualStyleBackColor = true;
            this.addNewTextBox.Click += new System.EventHandler(this.addNewTextBox_Click);
            // 
            // FlexibleTextBoxWithDragAndDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewTextBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.propertiesListBox);
            this.Name = "FlexibleTextBoxWithDragAndDrop";
            this.Text = "FlexibleTextBoxWithDragAndDrop";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox propertiesListBox;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button addNewTextBox;
    }
}