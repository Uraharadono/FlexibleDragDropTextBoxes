namespace FlexibleDragDropTextBoxes
{
    partial class MainForm
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
            this.resizableBtn = new System.Windows.Forms.Button();
            this.resizableDragDropBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resizableBtn
            // 
            this.resizableBtn.Location = new System.Drawing.Point(43, 41);
            this.resizableBtn.Name = "resizableBtn";
            this.resizableBtn.Size = new System.Drawing.Size(248, 43);
            this.resizableBtn.TabIndex = 0;
            this.resizableBtn.Text = "Resizable Text Boxes (only)";
            this.resizableBtn.UseVisualStyleBackColor = true;
            this.resizableBtn.Click += new System.EventHandler(this.resizableBtn_Click);
            // 
            // resizableDragDropBtn
            // 
            this.resizableDragDropBtn.Location = new System.Drawing.Point(43, 85);
            this.resizableDragDropBtn.Name = "resizableDragDropBtn";
            this.resizableDragDropBtn.Size = new System.Drawing.Size(248, 43);
            this.resizableDragDropBtn.TabIndex = 1;
            this.resizableDragDropBtn.Text = "Resizable Text Boxes (with drag and drop)";
            this.resizableDragDropBtn.UseVisualStyleBackColor = true;
            this.resizableDragDropBtn.Click += new System.EventHandler(this.resizableDragDropBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 241);
            this.Controls.Add(this.resizableDragDropBtn);
            this.Controls.Add(this.resizableBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resizableBtn;
        private System.Windows.Forms.Button resizableDragDropBtn;
    }
}