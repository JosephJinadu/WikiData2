namespace WikiPrototype2
{
    partial class WikiData2
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
            System.Windows.Forms.Button SearchBtn;
            this.Categorycombobox = new System.Windows.Forms.ComboBox();
            this.LinearRadioBtn = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ListView = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Structure = new System.Windows.Forms.GroupBox();
            this.NonLinearRadioBtn = new System.Windows.Forms.RadioButton();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Edittn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.Searchtxtbox = new System.Windows.Forms.TextBox();
            this.Nametxtbox = new System.Windows.Forms.TextBox();
            this.Defintiontxtbox = new System.Windows.Forms.TextBox();
            this.LblCategory = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblDefintion = new System.Windows.Forms.Label();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            SearchBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.Structure.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new System.Drawing.Point(798, 24);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new System.Drawing.Size(135, 50);
            SearchBtn.TabIndex = 11;
            SearchBtn.Text = "Search ";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Categorycombobox
            // 
            this.Categorycombobox.FormattingEnabled = true;
            this.Categorycombobox.Location = new System.Drawing.Point(970, 106);
            this.Categorycombobox.Name = "Categorycombobox";
            this.Categorycombobox.Size = new System.Drawing.Size(228, 33);
            this.Categorycombobox.TabIndex = 0;
            // 
            // LinearRadioBtn
            // 
            this.LinearRadioBtn.AutoSize = true;
            this.LinearRadioBtn.Location = new System.Drawing.Point(23, 58);
            this.LinearRadioBtn.Name = "LinearRadioBtn";
            this.LinearRadioBtn.Size = new System.Drawing.Size(109, 29);
            this.LinearRadioBtn.TabIndex = 1;
            this.LinearRadioBtn.TabStop = true;
            this.LinearRadioBtn.Text = "Linear ";
            this.LinearRadioBtn.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 799);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1835, 42);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(237, 32);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Category});
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(0, -2);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(656, 603);
            this.ListView.TabIndex = 4;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 228;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 193;
            // 
            // Structure
            // 
            this.Structure.Controls.Add(this.NonLinearRadioBtn);
            this.Structure.Controls.Add(this.LinearRadioBtn);
            this.Structure.Location = new System.Drawing.Point(970, 255);
            this.Structure.Name = "Structure";
            this.Structure.Size = new System.Drawing.Size(200, 167);
            this.Structure.TabIndex = 5;
            this.Structure.TabStop = false;
            this.Structure.Text = "Structure ";
            // 
            // NonLinearRadioBtn
            // 
            this.NonLinearRadioBtn.AutoSize = true;
            this.NonLinearRadioBtn.Location = new System.Drawing.Point(23, 93);
            this.NonLinearRadioBtn.Name = "NonLinearRadioBtn";
            this.NonLinearRadioBtn.Size = new System.Drawing.Size(155, 29);
            this.NonLinearRadioBtn.TabIndex = 2;
            this.NonLinearRadioBtn.TabStop = true;
            this.NonLinearRadioBtn.Text = "Non-Linear ";
            this.NonLinearRadioBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(0, 607);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(136, 86);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add ";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Edittn
            // 
            this.Edittn.Location = new System.Drawing.Point(165, 607);
            this.Edittn.Name = "Edittn";
            this.Edittn.Size = new System.Drawing.Size(136, 86);
            this.Edittn.TabIndex = 8;
            this.Edittn.Text = "Edit";
            this.Edittn.UseVisualStyleBackColor = true;
            this.Edittn.Click += new System.EventHandler(this.Edittn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(332, 607);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(128, 86);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(492, 607);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(144, 86);
            this.ResetBtn.TabIndex = 10;
            this.ResetBtn.Text = "Reset ";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Searchtxtbox
            // 
            this.Searchtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Searchtxtbox.Location = new System.Drawing.Point(956, 33);
            this.Searchtxtbox.Multiline = true;
            this.Searchtxtbox.Name = "Searchtxtbox";
            this.Searchtxtbox.Size = new System.Drawing.Size(270, 41);
            this.Searchtxtbox.TabIndex = 12;
            // 
            // Nametxtbox
            // 
            this.Nametxtbox.Location = new System.Drawing.Point(970, 185);
            this.Nametxtbox.Multiline = true;
            this.Nametxtbox.Name = "Nametxtbox";
            this.Nametxtbox.Size = new System.Drawing.Size(228, 40);
            this.Nametxtbox.TabIndex = 13;
            // 
            // Defintiontxtbox
            // 
            this.Defintiontxtbox.Location = new System.Drawing.Point(907, 463);
            this.Defintiontxtbox.Multiline = true;
            this.Defintiontxtbox.Name = "Defintiontxtbox";
            this.Defintiontxtbox.Size = new System.Drawing.Size(341, 311);
            this.Defintiontxtbox.TabIndex = 14;
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(809, 114);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(111, 25);
            this.LblCategory.TabIndex = 15;
            this.LblCategory.Text = "Category :";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(840, 200);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(80, 25);
            this.LblName.TabIndex = 16;
            this.LblName.Text = "Name :";
            // 
            // LblDefintion
            // 
            this.LblDefintion.AutoSize = true;
            this.LblDefintion.Location = new System.Drawing.Point(902, 425);
            this.LblDefintion.Name = "LblDefintion";
            this.LblDefintion.Size = new System.Drawing.Size(108, 25);
            this.LblDefintion.TabIndex = 17;
            this.LblDefintion.Text = "Definition ";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(1359, 288);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(249, 54);
            this.OpenBtn.TabIndex = 3;
            this.OpenBtn.Text = "Open ";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(1359, 212);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(249, 56);
            this.SaveBtn.TabIndex = 18;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // WikiData2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1835, 841);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LblDefintion);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.Defintiontxtbox);
            this.Controls.Add(this.Nametxtbox);
            this.Controls.Add(this.Searchtxtbox);
            this.Controls.Add(SearchBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.Edittn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Structure);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Categorycombobox);
            
            this.Text = "WikiData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WikiData2_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Structure.ResumeLayout(false);
            this.Structure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Categorycombobox;
        private System.Windows.Forms.RadioButton LinearRadioBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.GroupBox Structure;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button Edittn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.TextBox Searchtxtbox;
        private System.Windows.Forms.TextBox Nametxtbox;
        private System.Windows.Forms.TextBox Defintiontxtbox;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblDefintion;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.RadioButton NonLinearRadioBtn;
    }
}

