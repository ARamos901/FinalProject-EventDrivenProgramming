namespace FinalProject
{
    partial class SelectionForm
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
            this.AppsListBox = new System.Windows.Forms.ListBox();
            this.BevsListBox = new System.Windows.Forms.ListBox();
            this.MainsListBox = new System.Windows.Forms.ListBox();
            this.DessertListBox = new System.Windows.Forms.ListBox();
            this.AddItemsbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppsListBox
            // 
            this.AppsListBox.FormattingEnabled = true;
            this.AppsListBox.ItemHeight = 16;
            this.AppsListBox.Location = new System.Drawing.Point(63, 74);
            this.AppsListBox.Name = "AppsListBox";
            this.AppsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.AppsListBox.Size = new System.Drawing.Size(254, 212);
            this.AppsListBox.TabIndex = 1;
            // 
            // BevsListBox
            // 
            this.BevsListBox.FormattingEnabled = true;
            this.BevsListBox.ItemHeight = 16;
            this.BevsListBox.Location = new System.Drawing.Point(63, 74);
            this.BevsListBox.Name = "BevsListBox";
            this.BevsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.BevsListBox.Size = new System.Drawing.Size(254, 212);
            this.BevsListBox.TabIndex = 2;
            // 
            // MainsListBox
            // 
            this.MainsListBox.FormattingEnabled = true;
            this.MainsListBox.ItemHeight = 16;
            this.MainsListBox.Location = new System.Drawing.Point(63, 74);
            this.MainsListBox.Name = "MainsListBox";
            this.MainsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.MainsListBox.Size = new System.Drawing.Size(254, 212);
            this.MainsListBox.TabIndex = 3;
            // 
            // DessertListBox
            // 
            this.DessertListBox.FormattingEnabled = true;
            this.DessertListBox.ItemHeight = 16;
            this.DessertListBox.Location = new System.Drawing.Point(63, 74);
            this.DessertListBox.Name = "DessertListBox";
            this.DessertListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.DessertListBox.Size = new System.Drawing.Size(254, 212);
            this.DessertListBox.TabIndex = 4;
            this.DessertListBox.SelectedIndexChanged += new System.EventHandler(this.DessertListBox_SelectedIndexChanged);
            // 
            // AddItemsbutton
            // 
            this.AddItemsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemsbutton.Location = new System.Drawing.Point(127, 313);
            this.AddItemsbutton.Name = "AddItemsbutton";
            this.AddItemsbutton.Size = new System.Drawing.Size(107, 42);
            this.AddItemsbutton.TabIndex = 5;
            this.AddItemsbutton.Text = "Add Items";
            this.AddItemsbutton.UseVisualStyleBackColor = true;
            this.AddItemsbutton.Click += new System.EventHandler(this.AddItemsbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please Select Your Item(s)";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddItemsbutton);
            this.Controls.Add(this.DessertListBox);
            this.Controls.Add(this.MainsListBox);
            this.Controls.Add(this.BevsListBox);
            this.Controls.Add(this.AppsListBox);
            this.Name = "SelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectionForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AppsListBox;
        private System.Windows.Forms.ListBox BevsListBox;
        private System.Windows.Forms.ListBox MainsListBox;
        private System.Windows.Forms.ListBox DessertListBox;
        private System.Windows.Forms.Button AddItemsbutton;
        private System.Windows.Forms.Label label1;
    }
}