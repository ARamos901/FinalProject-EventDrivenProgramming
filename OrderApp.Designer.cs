namespace FinalProject
{
    partial class OrderApp
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
            this.components = new System.ComponentModel.Container();
            this.MenuItemslistBox = new System.Windows.Forms.ListBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveItembutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beveragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dessertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainCoursesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dessertsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.Tip_textBox = new System.Windows.Forms.TextBox();
            this.Subtotal_label = new System.Windows.Forms.Label();
            this.Tax_label = new System.Windows.Forms.Label();
            this.Tip_label = new System.Windows.Forms.Label();
            this.Total_label = new System.Windows.Forms.Label();
            this.SaveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItemslistBox
            // 
            this.MenuItemslistBox.FormattingEnabled = true;
            this.MenuItemslistBox.ItemHeight = 16;
            this.MenuItemslistBox.Location = new System.Drawing.Point(12, 65);
            this.MenuItemslistBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuItemslistBox.Name = "MenuItemslistBox";
            this.MenuItemslistBox.Size = new System.Drawing.Size(328, 164);
            this.MenuItemslistBox.TabIndex = 0;
            this.MenuItemslistBox.SelectedIndexChanged += new System.EventHandler(this.MenuItemslistBox_SelectedIndexChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(372, 65);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(81, 22);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Subtotal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total:";
            // 
            // RemoveItembutton
            // 
            this.RemoveItembutton.Location = new System.Drawing.Point(21, 261);
            this.RemoveItembutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveItembutton.Name = "RemoveItembutton";
            this.RemoveItembutton.Size = new System.Drawing.Size(100, 42);
            this.RemoveItembutton.TabIndex = 5;
            this.RemoveItembutton.Text = "Remove Item";
            this.RemoveItembutton.UseVisualStyleBackColor = true;
            this.RemoveItembutton.Click += new System.EventHandler(this.RemoveItembutton_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(573, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.LoadStripMenuItem,
            this.SaveStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exToolStripMenuItem
            // 
            this.exToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppsToolStripMenuItem,
            this.beveragesToolStripMenuItem,
            this.mainCoursesToolStripMenuItem,
            this.dessertsToolStripMenuItem});
            this.exToolStripMenuItem.Name = "exToolStripMenuItem";
            this.exToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.exToolStripMenuItem.Text = "Menu Items";
            // 
            // AppsToolStripMenuItem
            // 
            this.AppsToolStripMenuItem.Name = "AppsToolStripMenuItem";
            this.AppsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AppsToolStripMenuItem.Text = "Appetizers";
            this.AppsToolStripMenuItem.Click += new System.EventHandler(this.AppsToolStripMenuItem_Click);
            // 
            // beveragesToolStripMenuItem
            // 
            this.beveragesToolStripMenuItem.Name = "beveragesToolStripMenuItem";
            this.beveragesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.beveragesToolStripMenuItem.Text = "Beverages";
            this.beveragesToolStripMenuItem.Click += new System.EventHandler(this.beveragesToolStripMenuItem_Click);
            // 
            // mainCoursesToolStripMenuItem
            // 
            this.mainCoursesToolStripMenuItem.Name = "mainCoursesToolStripMenuItem";
            this.mainCoursesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mainCoursesToolStripMenuItem.Text = "Main Courses";
            this.mainCoursesToolStripMenuItem.Click += new System.EventHandler(this.mainCoursesToolStripMenuItem_Click);
            // 
            // dessertsToolStripMenuItem
            // 
            this.dessertsToolStripMenuItem.Name = "dessertsToolStripMenuItem";
            this.dessertsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dessertsToolStripMenuItem.Text = "Desserts";
            this.dessertsToolStripMenuItem.Click += new System.EventHandler(this.dessertsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.nameToolStripMenuItem,
            this.mainCoursesToolStripMenuItem1,
            this.dessertsToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 100);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 24);
            this.toolStripMenuItem1.Text = "Appetizers";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.AppsToolStripMenuItem_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.nameToolStripMenuItem.Text = "Beverages";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.beveragesToolStripMenuItem_Click);
            // 
            // mainCoursesToolStripMenuItem1
            // 
            this.mainCoursesToolStripMenuItem1.Name = "mainCoursesToolStripMenuItem1";
            this.mainCoursesToolStripMenuItem1.Size = new System.Drawing.Size(166, 24);
            this.mainCoursesToolStripMenuItem1.Text = "Main Courses";
            this.mainCoursesToolStripMenuItem1.Click += new System.EventHandler(this.mainCoursesToolStripMenuItem_Click);
            // 
            // dessertsToolStripMenuItem1
            // 
            this.dessertsToolStripMenuItem1.Name = "dessertsToolStripMenuItem1";
            this.dessertsToolStripMenuItem1.Size = new System.Drawing.Size(166, 24);
            this.dessertsToolStripMenuItem1.Text = "Desserts";
            this.dessertsToolStripMenuItem1.Click += new System.EventHandler(this.dessertsToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tip% :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Tip_textBox
            // 
            this.Tip_textBox.Location = new System.Drawing.Point(427, 31);
            this.Tip_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tip_textBox.Name = "Tip_textBox";
            this.Tip_textBox.Size = new System.Drawing.Size(55, 22);
            this.Tip_textBox.TabIndex = 9;
            this.Tip_textBox.TextChanged += new System.EventHandler(this.Tip_textBox_TextChanged_1);
            // 
            // Subtotal_label
            // 
            this.Subtotal_label.AutoSize = true;
            this.Subtotal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtotal_label.Location = new System.Drawing.Point(449, 65);
            this.Subtotal_label.Name = "Subtotal_label";
            this.Subtotal_label.Size = new System.Drawing.Size(55, 20);
            this.Subtotal_label.TabIndex = 10;
            this.Subtotal_label.Text = "holder";
            // 
            // Tax_label
            // 
            this.Tax_label.AutoSize = true;
            this.Tax_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax_label.Location = new System.Drawing.Point(449, 140);
            this.Tax_label.Name = "Tax_label";
            this.Tax_label.Size = new System.Drawing.Size(55, 20);
            this.Tax_label.TabIndex = 11;
            this.Tax_label.Text = "holder";
            // 
            // Tip_label
            // 
            this.Tip_label.AutoSize = true;
            this.Tip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_label.Location = new System.Drawing.Point(449, 102);
            this.Tip_label.Name = "Tip_label";
            this.Tip_label.Size = new System.Drawing.Size(55, 20);
            this.Tip_label.TabIndex = 12;
            this.Tip_label.Text = "holder";
            // 
            // Total_label
            // 
            this.Total_label.AutoSize = true;
            this.Total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_label.Location = new System.Drawing.Point(449, 178);
            this.Total_label.Name = "Total_label";
            this.Total_label.Size = new System.Drawing.Size(55, 20);
            this.Total_label.TabIndex = 13;
            this.Total_label.Text = "holder";
            // 
            // SaveStripMenuItem
            // 
            this.SaveStripMenuItem.Name = "SaveStripMenuItem";
            this.SaveStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SaveStripMenuItem.Text = "Save Order";
            this.SaveStripMenuItem.Click += new System.EventHandler(this.SaveStripMenuItem_Click);
            // 
            // LoadStripMenuItem
            // 
            this.LoadStripMenuItem.Name = "LoadStripMenuItem";
            this.LoadStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.LoadStripMenuItem.Text = "Load Order";
            this.LoadStripMenuItem.Click += new System.EventHandler(this.LoadStripMenuItem_Click);
            // 
            // OrderApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 313);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.Total_label);
            this.Controls.Add(this.Tip_label);
            this.Controls.Add(this.Tax_label);
            this.Controls.Add(this.Subtotal_label);
            this.Controls.Add(this.Tip_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RemoveItembutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.MenuItemslistBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderApp";
            this.Text = "Gwynedd Mercy Online Menu";
            this.Load += new System.EventHandler(this.OrderApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MenuItemslistBox;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveItembutton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beveragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dessertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tip_textBox;
        private System.Windows.Forms.Label Subtotal_label;
        private System.Windows.Forms.Label Tax_label;
        private System.Windows.Forms.Label Tip_label;
        private System.Windows.Forms.Label Total_label;
        private System.Windows.Forms.ToolStripMenuItem mainCoursesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dessertsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadStripMenuItem;
    }
}