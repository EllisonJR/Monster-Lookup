namespace Monster_LookUp
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.specialTraitsBox = new System.Windows.Forms.RichTextBox();
            this.actionsBox = new System.Windows.Forms.RichTextBox();
            this.statBlockBox = new System.Windows.Forms.RichTextBox();
            this.quoteBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regionalEffectsBox = new System.Windows.Forms.RichTextBox();
            this.legendaryActionsBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lairActionsBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.extrasBox = new System.Windows.Forms.RichTextBox();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sizeListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(12, 339);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 225);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_PopulateMonsterData);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TableUpdate);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1492, 580);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // specialTraitsBox
            // 
            this.specialTraitsBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialTraitsBox.Location = new System.Drawing.Point(624, 50);
            this.specialTraitsBox.Name = "specialTraitsBox";
            this.specialTraitsBox.ReadOnly = true;
            this.specialTraitsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.specialTraitsBox.Size = new System.Drawing.Size(300, 514);
            this.specialTraitsBox.TabIndex = 7;
            this.specialTraitsBox.Text = "";
            // 
            // actionsBox
            // 
            this.actionsBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionsBox.Location = new System.Drawing.Point(940, 50);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.ReadOnly = true;
            this.actionsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.actionsBox.Size = new System.Drawing.Size(300, 514);
            this.actionsBox.TabIndex = 8;
            this.actionsBox.Text = "";
            // 
            // statBlockBox
            // 
            this.statBlockBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statBlockBox.Location = new System.Drawing.Point(1582, 50);
            this.statBlockBox.Name = "statBlockBox";
            this.statBlockBox.ReadOnly = true;
            this.statBlockBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.statBlockBox.Size = new System.Drawing.Size(310, 381);
            this.statBlockBox.TabIndex = 9;
            this.statBlockBox.Text = "";
            // 
            // quoteBox
            // 
            this.quoteBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteBox.Location = new System.Drawing.Point(1582, 445);
            this.quoteBox.Name = "quoteBox";
            this.quoteBox.ReadOnly = true;
            this.quoteBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.quoteBox.Size = new System.Drawing.Size(310, 119);
            this.quoteBox.TabIndex = 10;
            this.quoteBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Special Traits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(936, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Actions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1578, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stat Block";
            // 
            // regionalEffectsBox
            // 
            this.regionalEffectsBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionalEffectsBox.Location = new System.Drawing.Point(378, 614);
            this.regionalEffectsBox.Name = "regionalEffectsBox";
            this.regionalEffectsBox.ReadOnly = true;
            this.regionalEffectsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.regionalEffectsBox.Size = new System.Drawing.Size(350, 416);
            this.regionalEffectsBox.TabIndex = 14;
            this.regionalEffectsBox.Text = "";
            // 
            // legendaryActionsBox
            // 
            this.legendaryActionsBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legendaryActionsBox.Location = new System.Drawing.Point(746, 614);
            this.legendaryActionsBox.Name = "legendaryActionsBox";
            this.legendaryActionsBox.ReadOnly = true;
            this.legendaryActionsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.legendaryActionsBox.Size = new System.Drawing.Size(350, 416);
            this.legendaryActionsBox.TabIndex = 15;
            this.legendaryActionsBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(742, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Legendary Actions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Regional Effects";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lair Actions";
            // 
            // lairActionsBox
            // 
            this.lairActionsBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lairActionsBox.Location = new System.Drawing.Point(12, 614);
            this.lairActionsBox.Name = "lairActionsBox";
            this.lairActionsBox.ReadOnly = true;
            this.lairActionsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lairActionsBox.Size = new System.Drawing.Size(350, 416);
            this.lairActionsBox.TabIndex = 18;
            this.lairActionsBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1111, 587);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Extras";
            // 
            // extrasBox
            // 
            this.extrasBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasBox.Location = new System.Drawing.Point(1115, 614);
            this.extrasBox.Name = "extrasBox";
            this.extrasBox.ReadOnly = true;
            this.extrasBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.extrasBox.Size = new System.Drawing.Size(350, 416);
            this.extrasBox.TabIndex = 20;
            this.extrasBox.Text = "";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(1256, 50);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(310, 514);
            this.descriptionBox.TabIndex = 22;
            this.descriptionBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1252, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Description";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.sizeListBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(591, 283);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // sizeListBox
            // 
            this.sizeListBox.CheckOnClick = true;
            this.sizeListBox.FormattingEnabled = true;
            this.sizeListBox.Items.AddRange(new object[] {
            "Tiny",
            "Small",
            "Medium",
            "Large",
            "Huge",
            "Gargantuan",
            "Colossal"});
            this.sizeListBox.Location = new System.Drawing.Point(3, 3);
            this.sizeListBox.Name = "sizeListBox";
            this.sizeListBox.Size = new System.Drawing.Size(120, 109);
            this.sizeListBox.TabIndex = 0;
            this.sizeListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1042);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.extrasBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lairActionsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.legendaryActionsBox);
            this.Controls.Add(this.regionalEffectsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quoteBox);
            this.Controls.Add(this.statBlockBox);
            this.Controls.Add(this.actionsBox);
            this.Controls.Add(this.specialTraitsBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox specialTraitsBox;
        private System.Windows.Forms.RichTextBox actionsBox;
        private System.Windows.Forms.RichTextBox statBlockBox;
        private System.Windows.Forms.RichTextBox quoteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox regionalEffectsBox;
        private System.Windows.Forms.RichTextBox legendaryActionsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox lairActionsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox extrasBox;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckedListBox sizeListBox;
    }
}

