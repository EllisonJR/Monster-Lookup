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
            this.monsterTypeCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.monsterSubtypeCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.environmentCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.broadAlignmentCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.alignmentCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.actionCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.traitsCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.legendaryActCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.skillsCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.sensesCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.savingThrowCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.langCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.moveTypeCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.resistanceCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.immunityCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.weaknessCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.minEXP = new System.Windows.Forms.RichTextBox();
            this.maxEXP = new System.Windows.Forms.RichTextBox();
            this.avgHPmax = new System.Windows.Forms.RichTextBox();
            this.avgHPmin = new System.Windows.Forms.RichTextBox();
            this.CRmax = new System.Windows.Forms.RichTextBox();
            this.CRmin = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.profMax = new System.Windows.Forms.RichTextBox();
            this.profMin = new System.Windows.Forms.RichTextBox();
            this.floatBox = new System.Windows.Forms.CheckBox();
            this.legendaryBox = new System.Windows.Forms.CheckBox();
            this.lairBox = new System.Windows.Forms.CheckBox();
            this.telepathyBox = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ACmax = new System.Windows.Forms.RichTextBox();
            this.ACmin = new System.Windows.Forms.RichTextBox();
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
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(12, 309);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 197);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_PopulateMonsterData);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(16, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TableUpdate);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(1492, 546);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // specialTraitsBox
            // 
            this.specialTraitsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specialTraitsBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialTraitsBox.Location = new System.Drawing.Point(624, 40);
            this.specialTraitsBox.Name = "specialTraitsBox";
            this.specialTraitsBox.ReadOnly = true;
            this.specialTraitsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.specialTraitsBox.Size = new System.Drawing.Size(300, 466);
            this.specialTraitsBox.TabIndex = 7;
            this.specialTraitsBox.Text = "";
            // 
            // actionsBox
            // 
            this.actionsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actionsBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionsBox.Location = new System.Drawing.Point(940, 40);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.ReadOnly = true;
            this.actionsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.actionsBox.Size = new System.Drawing.Size(300, 466);
            this.actionsBox.TabIndex = 8;
            this.actionsBox.Text = "";
            // 
            // statBlockBox
            // 
            this.statBlockBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statBlockBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statBlockBox.Location = new System.Drawing.Point(1582, 40);
            this.statBlockBox.Name = "statBlockBox";
            this.statBlockBox.ReadOnly = true;
            this.statBlockBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.statBlockBox.Size = new System.Drawing.Size(310, 381);
            this.statBlockBox.TabIndex = 9;
            this.statBlockBox.Text = "";
            // 
            // quoteBox
            // 
            this.quoteBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quoteBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteBox.Location = new System.Drawing.Point(1582, 435);
            this.quoteBox.Name = "quoteBox";
            this.quoteBox.ReadOnly = true;
            this.quoteBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.quoteBox.Size = new System.Drawing.Size(310, 71);
            this.quoteBox.TabIndex = 10;
            this.quoteBox.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Special Traits";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(936, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Actions";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1578, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stat Block";
            // 
            // regionalEffectsBox
            // 
            this.regionalEffectsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regionalEffectsBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionalEffectsBox.Location = new System.Drawing.Point(377, 546);
            this.regionalEffectsBox.Name = "regionalEffectsBox";
            this.regionalEffectsBox.ReadOnly = true;
            this.regionalEffectsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.regionalEffectsBox.Size = new System.Drawing.Size(350, 443);
            this.regionalEffectsBox.TabIndex = 14;
            this.regionalEffectsBox.Text = "";
            // 
            // legendaryActionsBox
            // 
            this.legendaryActionsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.legendaryActionsBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legendaryActionsBox.Location = new System.Drawing.Point(745, 546);
            this.legendaryActionsBox.Name = "legendaryActionsBox";
            this.legendaryActionsBox.ReadOnly = true;
            this.legendaryActionsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.legendaryActionsBox.Size = new System.Drawing.Size(350, 443);
            this.legendaryActionsBox.TabIndex = 15;
            this.legendaryActionsBox.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(741, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Legendary Actions";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Regional Effects";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lair Actions";
            // 
            // lairActionsBox
            // 
            this.lairActionsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lairActionsBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lairActionsBox.Location = new System.Drawing.Point(11, 546);
            this.lairActionsBox.Name = "lairActionsBox";
            this.lairActionsBox.ReadOnly = true;
            this.lairActionsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lairActionsBox.Size = new System.Drawing.Size(350, 443);
            this.lairActionsBox.TabIndex = 18;
            this.lairActionsBox.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1110, 519);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Extras";
            // 
            // extrasBox
            // 
            this.extrasBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.extrasBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasBox.Location = new System.Drawing.Point(1114, 546);
            this.extrasBox.Name = "extrasBox";
            this.extrasBox.ReadOnly = true;
            this.extrasBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.extrasBox.Size = new System.Drawing.Size(350, 443);
            this.extrasBox.TabIndex = 20;
            this.extrasBox.Text = "";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionBox.Font = new System.Drawing.Font("Libre Baskerville", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(1256, 40);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(310, 466);
            this.descriptionBox.TabIndex = 22;
            this.descriptionBox.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Libre Baskerville", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1252, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Description";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.sizeListBox);
            this.flowLayoutPanel1.Controls.Add(this.monsterTypeCheckBoxList);
            this.flowLayoutPanel1.Controls.Add(this.monsterSubtypeCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.environmentCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.broadAlignmentCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.alignmentCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.actionCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.traitsCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.legendaryActCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.skillsCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.sensesCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.savingThrowCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.langCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.moveTypeCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.resistanceCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.immunityCheckListBox);
            this.flowLayoutPanel1.Controls.Add(this.weaknessCheckListBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(591, 132);
            this.flowLayoutPanel1.TabIndex = 31;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // sizeListBox
            // 
            this.sizeListBox.AccessibleName = "mons.size";
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
            // monsterTypeCheckBoxList
            // 
            this.monsterTypeCheckBoxList.AccessibleName = "mons.monsterType";
            this.monsterTypeCheckBoxList.CheckOnClick = true;
            this.monsterTypeCheckBoxList.FormattingEnabled = true;
            this.monsterTypeCheckBoxList.Items.AddRange(new object[] {
            "Aberration",
            "Beast",
            "Celestial",
            "Construct",
            "Dragon",
            "Elemental",
            "Fey",
            "Fiend",
            "Giant",
            "Humanoid",
            "Monstrosity",
            "Ooze",
            "Plant",
            "Undead"});
            this.monsterTypeCheckBoxList.Location = new System.Drawing.Point(129, 3);
            this.monsterTypeCheckBoxList.Name = "monsterTypeCheckBoxList";
            this.monsterTypeCheckBoxList.Size = new System.Drawing.Size(120, 109);
            this.monsterTypeCheckBoxList.TabIndex = 1;
            this.monsterTypeCheckBoxList.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // monsterSubtypeCheckListBox
            // 
            this.monsterSubtypeCheckListBox.AccessibleName = "mons.monsterSubtype";
            this.monsterSubtypeCheckListBox.CheckOnClick = true;
            this.monsterSubtypeCheckListBox.FormattingEnabled = true;
            this.monsterSubtypeCheckListBox.Items.AddRange(new object[] {
            "Angel",
            "Animated Object",
            "Beholder",
            "Blight",
            "Bugbear",
            "Demon",
            "Devil",
            "Dinosaur",
            "Drow",
            "Fungi",
            "Genie",
            "Gith",
            "Gnoll",
            "Goblin",
            "Golem",
            "Hag",
            "Hobgoblin",
            "Kuo-Toa",
            "Lycanthrope",
            "Lizardfolk",
            "Mephit",
            "Modron",
            "Mummy",
            "Kobold",
            "Myconid",
            "Naga",
            "Orc",
            "Skeleton",
            "Slaadi",
            "Yuan-Ti",
            "Yugoloth"});
            this.monsterSubtypeCheckListBox.Location = new System.Drawing.Point(255, 3);
            this.monsterSubtypeCheckListBox.Name = "monsterSubtypeCheckListBox";
            this.monsterSubtypeCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.monsterSubtypeCheckListBox.TabIndex = 4;
            this.monsterSubtypeCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // environmentCheckListBox
            // 
            this.environmentCheckListBox.AccessibleName = "mons.environment";
            this.environmentCheckListBox.CheckOnClick = true;
            this.environmentCheckListBox.FormattingEnabled = true;
            this.environmentCheckListBox.Items.AddRange(new object[] {
            "Arctic",
            "Coastal",
            "Desert",
            "Forest",
            "Grassland",
            "Hill",
            "Mountain",
            "Swamp",
            "Underdark",
            "Underwater",
            "Urban"});
            this.environmentCheckListBox.Location = new System.Drawing.Point(381, 3);
            this.environmentCheckListBox.Name = "environmentCheckListBox";
            this.environmentCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.environmentCheckListBox.TabIndex = 3;
            this.environmentCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // broadAlignmentCheckListBox
            // 
            this.broadAlignmentCheckListBox.AccessibleName = "aligns.broadAlignment";
            this.broadAlignmentCheckListBox.CheckOnClick = true;
            this.broadAlignmentCheckListBox.FormattingEnabled = true;
            this.broadAlignmentCheckListBox.Items.AddRange(new object[] {
            "Good",
            "Neutral",
            "Evil",
            "-"});
            this.broadAlignmentCheckListBox.Location = new System.Drawing.Point(507, 3);
            this.broadAlignmentCheckListBox.Name = "broadAlignmentCheckListBox";
            this.broadAlignmentCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.broadAlignmentCheckListBox.TabIndex = 6;
            this.broadAlignmentCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // alignmentCheckListBox
            // 
            this.alignmentCheckListBox.AccessibleName = "mons.alignment";
            this.alignmentCheckListBox.CheckOnClick = true;
            this.alignmentCheckListBox.FormattingEnabled = true;
            this.alignmentCheckListBox.Items.AddRange(new object[] {
            "Lawful Good",
            "Neutral Good",
            "Chaotic Good",
            "Lawful Neutral",
            "Neutral",
            "Chaotic Neutral",
            "Lawful Evil",
            "Neutral Evil",
            "Chaotic Evil",
            "Unaligned"});
            this.alignmentCheckListBox.Location = new System.Drawing.Point(633, 3);
            this.alignmentCheckListBox.Name = "alignmentCheckListBox";
            this.alignmentCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.alignmentCheckListBox.TabIndex = 5;
            this.alignmentCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // actionCheckListBox
            // 
            this.actionCheckListBox.AccessibleName = "mons_actions.actionName";
            this.actionCheckListBox.CheckOnClick = true;
            this.actionCheckListBox.FormattingEnabled = true;
            this.actionCheckListBox.Items.AddRange(new object[] {
            "Talon.",
            "Javelin.",
            "Multiattack.",
            "Tentacle.",
            "Enslave.",
            "Tail.",
            "Mace.",
            "Healing Touch.",
            "Greatsword.",
            "Slaying Longbow.",
            "Flying Sword.",
            "Slam.",
            "Longsword.",
            "Smother."});
            this.actionCheckListBox.Location = new System.Drawing.Point(759, 3);
            this.actionCheckListBox.Name = "actionCheckListBox";
            this.actionCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.actionCheckListBox.TabIndex = 7;
            this.actionCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // traitsCheckListBox
            // 
            this.traitsCheckListBox.AccessibleName = "mons_traits.traitName";
            this.traitsCheckListBox.CheckOnClick = true;
            this.traitsCheckListBox.FormattingEnabled = true;
            this.traitsCheckListBox.Items.AddRange(new object[] {
            "Dive Attack.",
            "Amphibious.",
            "Mucous Cloud.",
            "Probing Telepathy.",
            "Angelic Weapons.",
            "Innate Spellcasting.",
            "Magic Resistance.",
            "Divine Awareness.",
            "Antimagic Susceptability.",
            "False Appearance.",
            "Damage Transfer."});
            this.traitsCheckListBox.Location = new System.Drawing.Point(885, 3);
            this.traitsCheckListBox.Name = "traitsCheckListBox";
            this.traitsCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.traitsCheckListBox.TabIndex = 8;
            this.traitsCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // legendaryActCheckListBox
            // 
            this.legendaryActCheckListBox.AccessibleName = "mons_leg_acts.legendaryActionName";
            this.legendaryActCheckListBox.CheckOnClick = true;
            this.legendaryActCheckListBox.FormattingEnabled = true;
            this.legendaryActCheckListBox.Items.AddRange(new object[] {
            "Detect.",
            "Tail Swipe.",
            "Psychic Drain (Costs 2 Actions).",
            "Searing Burst (Costs 2 Actions).",
            "Blinding Gaze (Costs 3 Actions).",
            "Teleport."});
            this.legendaryActCheckListBox.Location = new System.Drawing.Point(1011, 3);
            this.legendaryActCheckListBox.Name = "legendaryActCheckListBox";
            this.legendaryActCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.legendaryActCheckListBox.TabIndex = 12;
            this.legendaryActCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // skillsCheckListBox
            // 
            this.skillsCheckListBox.AccessibleName = "mons_skills.skillName";
            this.skillsCheckListBox.CheckOnClick = true;
            this.skillsCheckListBox.FormattingEnabled = true;
            this.skillsCheckListBox.Items.AddRange(new object[] {
            "Perception",
            "History",
            "Insight"});
            this.skillsCheckListBox.Location = new System.Drawing.Point(1137, 3);
            this.skillsCheckListBox.Name = "skillsCheckListBox";
            this.skillsCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.skillsCheckListBox.TabIndex = 9;
            this.skillsCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // sensesCheckListBox
            // 
            this.sensesCheckListBox.AccessibleName = "mons_senses.senseName";
            this.sensesCheckListBox.CheckOnClick = true;
            this.sensesCheckListBox.FormattingEnabled = true;
            this.sensesCheckListBox.Items.AddRange(new object[] {
            "Darkvision",
            "Truesight",
            "Blindsight"});
            this.sensesCheckListBox.Location = new System.Drawing.Point(1263, 3);
            this.sensesCheckListBox.Name = "sensesCheckListBox";
            this.sensesCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.sensesCheckListBox.TabIndex = 10;
            this.sensesCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // savingThrowCheckListBox
            // 
            this.savingThrowCheckListBox.AccessibleName = "mons_saving.ability_modifier";
            this.savingThrowCheckListBox.CheckOnClick = true;
            this.savingThrowCheckListBox.FormattingEnabled = true;
            this.savingThrowCheckListBox.Items.AddRange(new object[] {
            "Wisdom",
            "Charisma",
            "Constitution",
            "Intelligence",
            "Desterity",
            "Strength"});
            this.savingThrowCheckListBox.Location = new System.Drawing.Point(1389, 3);
            this.savingThrowCheckListBox.Name = "savingThrowCheckListBox";
            this.savingThrowCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.savingThrowCheckListBox.TabIndex = 14;
            this.savingThrowCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // langCheckListBox
            // 
            this.langCheckListBox.AccessibleName = "mons_langs.languageName";
            this.langCheckListBox.CheckOnClick = true;
            this.langCheckListBox.FormattingEnabled = true;
            this.langCheckListBox.Items.AddRange(new object[] {
            "Abyssal",
            "Aquan",
            "Auran",
            "Celestial",
            "Common",
            "Deep Speech",
            "Draconic",
            "Dwarvish",
            "Druidic",
            "Elvish",
            "Giant",
            "Gnomish",
            "Goblin",
            "Gnoll",
            "Halfling",
            "Ignan",
            "Infernal",
            "Orc",
            "Primordial",
            "Sylvan",
            "Terran",
            "Undercommon",
            "Aarakocra",
            "None"});
            this.langCheckListBox.Location = new System.Drawing.Point(1515, 3);
            this.langCheckListBox.Name = "langCheckListBox";
            this.langCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.langCheckListBox.TabIndex = 11;
            this.langCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // moveTypeCheckListBox
            // 
            this.moveTypeCheckListBox.AccessibleName = "mons_movetypes.movementType";
            this.moveTypeCheckListBox.CheckOnClick = true;
            this.moveTypeCheckListBox.FormattingEnabled = true;
            this.moveTypeCheckListBox.Items.AddRange(new object[] {
            "Walk",
            "Burrow",
            "Climb",
            "Fly",
            "Swim"});
            this.moveTypeCheckListBox.Location = new System.Drawing.Point(1641, 3);
            this.moveTypeCheckListBox.Name = "moveTypeCheckListBox";
            this.moveTypeCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.moveTypeCheckListBox.TabIndex = 13;
            this.moveTypeCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // resistanceCheckListBox
            // 
            this.resistanceCheckListBox.AccessibleName = "mons_resistances.source";
            this.resistanceCheckListBox.CheckOnClick = true;
            this.resistanceCheckListBox.FormattingEnabled = true;
            this.resistanceCheckListBox.Items.AddRange(new object[] {
            "Acid",
            "Bludgeoning",
            "Cold",
            "Fire",
            "Force",
            "Lightning",
            "Necrotic",
            "Piercing",
            "Poison",
            "Psychic",
            "Radiant",
            "Slashing",
            "Thunder",
            "Bludgeoning, Piercing, and Slashing from nonmagical weapons"});
            this.resistanceCheckListBox.Location = new System.Drawing.Point(1767, 3);
            this.resistanceCheckListBox.Name = "resistanceCheckListBox";
            this.resistanceCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.resistanceCheckListBox.TabIndex = 15;
            this.resistanceCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // immunityCheckListBox
            // 
            this.immunityCheckListBox.AccessibleName = "mons_immunities.source";
            this.immunityCheckListBox.CheckOnClick = true;
            this.immunityCheckListBox.FormattingEnabled = true;
            this.immunityCheckListBox.Items.AddRange(new object[] {
            "Blinded",
            "Charmed",
            "Deafened",
            "Exhaustion",
            "Frightened",
            "Grappled",
            "Incapacitated",
            "Invisible",
            "Paralyzed",
            "Petrified",
            "Poisoned",
            "Prone",
            "Restrained",
            "Stunned",
            "Unconscious",
            "Acid",
            "Bludgeoning",
            "Cold",
            "Fire",
            "Force",
            "Lightning",
            "Necrotic",
            "Piercing",
            "Poison",
            "Psychic",
            "Radiant",
            "Slashing",
            "Thunder",
            "Bludgeoning, Piercing, and Slashing from nonmagical weapons"});
            this.immunityCheckListBox.Location = new System.Drawing.Point(1893, 3);
            this.immunityCheckListBox.Name = "immunityCheckListBox";
            this.immunityCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.immunityCheckListBox.TabIndex = 16;
            this.immunityCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // weaknessCheckListBox
            // 
            this.weaknessCheckListBox.AccessibleName = "mons_weak.source";
            this.weaknessCheckListBox.CheckOnClick = true;
            this.weaknessCheckListBox.FormattingEnabled = true;
            this.weaknessCheckListBox.Items.AddRange(new object[] {
            "Acid",
            "Bludgeoning",
            "Cold",
            "Fire",
            "Force",
            "Lightning",
            "Necrotic",
            "Piercing",
            "Poison",
            "Psychic",
            "Radiant",
            "Slashing",
            "Thunder",
            "Bludgeoning, Piercing, and Slashing from nonmagical weapons"});
            this.weaknessCheckListBox.Location = new System.Drawing.Point(2019, 3);
            this.weaknessCheckListBox.Name = "weaknessCheckListBox";
            this.weaknessCheckListBox.Size = new System.Drawing.Size(120, 109);
            this.weaknessCheckListBox.TabIndex = 17;
            this.weaknessCheckListBox.SelectedIndexChanged += new System.EventHandler(this.TableUpdate);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(532, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // minEXP
            // 
            this.minEXP.AccessibleDescription = "min";
            this.minEXP.AccessibleName = "mons_CRs.expReward";
            this.minEXP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minEXP.Location = new System.Drawing.Point(121, 179);
            this.minEXP.Name = "minEXP";
            this.minEXP.Size = new System.Drawing.Size(69, 20);
            this.minEXP.TabIndex = 33;
            this.minEXP.Text = "";
            this.minEXP.TextChanged += new System.EventHandler(this.TableUpdate);
            this.minEXP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxInputChecker);
            // 
            // maxEXP
            // 
            this.maxEXP.AccessibleDescription = "max";
            this.maxEXP.AccessibleName = "mons_CRs.expReward";
            this.maxEXP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxEXP.Location = new System.Drawing.Point(208, 179);
            this.maxEXP.Name = "maxEXP";
            this.maxEXP.Size = new System.Drawing.Size(69, 20);
            this.maxEXP.TabIndex = 34;
            this.maxEXP.Text = "";
            this.maxEXP.TextChanged += new System.EventHandler(this.TableUpdate);
            this.maxEXP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxInputChecker);
            // 
            // avgHPmax
            // 
            this.avgHPmax.AccessibleDescription = "max";
            this.avgHPmax.AccessibleName = "mons_CRs.proficiencyBonus";
            this.avgHPmax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avgHPmax.Location = new System.Drawing.Point(208, 205);
            this.avgHPmax.Name = "avgHPmax";
            this.avgHPmax.Size = new System.Drawing.Size(69, 20);
            this.avgHPmax.TabIndex = 36;
            this.avgHPmax.Text = "";
            this.avgHPmax.TextChanged += new System.EventHandler(this.TableUpdate);
            this.avgHPmax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxInputChecker);
            // 
            // avgHPmin
            // 
            this.avgHPmin.AccessibleDescription = "min";
            this.avgHPmin.AccessibleName = "mons_CRs.proficiencyBonus";
            this.avgHPmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avgHPmin.Location = new System.Drawing.Point(121, 205);
            this.avgHPmin.Name = "avgHPmin";
            this.avgHPmin.Size = new System.Drawing.Size(69, 20);
            this.avgHPmin.TabIndex = 35;
            this.avgHPmin.Text = "";
            this.avgHPmin.TextChanged += new System.EventHandler(this.TableUpdate);
            this.avgHPmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxInputChecker);
            // 
            // CRmax
            // 
            this.CRmax.AccessibleDescription = "max";
            this.CRmax.AccessibleName = "mons.challengeRating";
            this.CRmax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CRmax.Location = new System.Drawing.Point(208, 229);
            this.CRmax.Name = "CRmax";
            this.CRmax.Size = new System.Drawing.Size(69, 20);
            this.CRmax.TabIndex = 38;
            this.CRmax.Text = "";
            this.CRmax.TextChanged += new System.EventHandler(this.TableUpdate);
            this.CRmax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxInputChecker);
            // 
            // CRmin
            // 
            this.CRmin.AccessibleDescription = "min";
            this.CRmin.AccessibleName = "mons.challengeRating";
            this.CRmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CRmin.Location = new System.Drawing.Point(121, 229);
            this.CRmin.Name = "CRmin";
            this.CRmin.Size = new System.Drawing.Size(69, 20);
            this.CRmin.TabIndex = 37;
            this.CRmin.Text = "";
            this.CRmin.TextChanged += new System.EventHandler(this.TableUpdate);
            this.CRmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxInputChecker);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "EXP Reward";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Challenge Rating";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Average Health";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "--";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(192, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "--";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(192, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "--";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(192, 258);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "--";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Proficiency Bonus";
            // 
            // profMax
            // 
            this.profMax.AccessibleDescription = "max";
            this.profMax.AccessibleName = "mons_CRs.proficiencyBonus";
            this.profMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profMax.Location = new System.Drawing.Point(208, 255);
            this.profMax.Name = "profMax";
            this.profMax.Size = new System.Drawing.Size(69, 20);
            this.profMax.TabIndex = 46;
            this.profMax.Text = "";
            this.profMax.TextChanged += new System.EventHandler(this.TableUpdate);
            this.profMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxInputChecker);
            // 
            // profMin
            // 
            this.profMin.AccessibleDescription = "max";
            this.profMin.AccessibleName = "mons_CRs.proficiencyBonus";
            this.profMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profMin.Location = new System.Drawing.Point(121, 255);
            this.profMin.Name = "profMin";
            this.profMin.Size = new System.Drawing.Size(69, 20);
            this.profMin.TabIndex = 45;
            this.profMin.Text = "";
            this.profMin.TextChanged += new System.EventHandler(this.TableUpdate);
            this.profMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxInputChecker);
            // 
            // floatBox
            // 
            this.floatBox.AccessibleDescription = "trueFalse";
            this.floatBox.AccessibleName = "mons.canHover";
            this.floatBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.floatBox.AutoSize = true;
            this.floatBox.Location = new System.Drawing.Point(311, 181);
            this.floatBox.Name = "floatBox";
            this.floatBox.Size = new System.Drawing.Size(71, 17);
            this.floatBox.TabIndex = 53;
            this.floatBox.Text = "Can Float";
            this.floatBox.UseVisualStyleBackColor = true;
            this.floatBox.CheckStateChanged += new System.EventHandler(this.TableUpdate);
            // 
            // legendaryBox
            // 
            this.legendaryBox.AccessibleDescription = "notNull";
            this.legendaryBox.AccessibleName = "mons_leg_acts.monsterName";
            this.legendaryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.legendaryBox.AutoSize = true;
            this.legendaryBox.Location = new System.Drawing.Point(311, 257);
            this.legendaryBox.Name = "legendaryBox";
            this.legendaryBox.Size = new System.Drawing.Size(136, 17);
            this.legendaryBox.TabIndex = 54;
            this.legendaryBox.Text = "Has Legendary Actions";
            this.legendaryBox.UseVisualStyleBackColor = true;
            this.legendaryBox.CheckStateChanged += new System.EventHandler(this.TableUpdate);
            // 
            // lairBox
            // 
            this.lairBox.AccessibleDescription = "notNull";
            this.lairBox.AccessibleName = "mons_lairs.monsterName";
            this.lairBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lairBox.AutoSize = true;
            this.lairBox.Location = new System.Drawing.Point(311, 231);
            this.lairBox.Name = "lairBox";
            this.lairBox.Size = new System.Drawing.Size(65, 17);
            this.lairBox.TabIndex = 55;
            this.lairBox.Text = "Has Lair";
            this.lairBox.UseVisualStyleBackColor = true;
            this.lairBox.CheckStateChanged += new System.EventHandler(this.TableUpdate);
            // 
            // telepathyBox
            // 
            this.telepathyBox.AccessibleDescription = "trueFalse";
            this.telepathyBox.AccessibleName = "mons.telepathy";
            this.telepathyBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telepathyBox.AutoSize = true;
            this.telepathyBox.Location = new System.Drawing.Point(311, 207);
            this.telepathyBox.Name = "telepathyBox";
            this.telepathyBox.Size = new System.Drawing.Size(95, 17);
            this.telepathyBox.TabIndex = 56;
            this.telepathyBox.Text = "Has Telepathy";
            this.telepathyBox.UseVisualStyleBackColor = true;
            this.telepathyBox.CheckStateChanged += new System.EventHandler(this.TableUpdate);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(192, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 60;
            this.label17.Text = "--";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 288);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 59;
            this.label18.Text = "Armor Class";
            // 
            // ACmax
            // 
            this.ACmax.AccessibleDescription = "max";
            this.ACmax.AccessibleName = "mons.armorClass";
            this.ACmax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ACmax.Location = new System.Drawing.Point(208, 281);
            this.ACmax.Name = "ACmax";
            this.ACmax.Size = new System.Drawing.Size(69, 20);
            this.ACmax.TabIndex = 58;
            this.ACmax.Text = "";
            this.ACmax.TextChanged += new System.EventHandler(this.TableUpdate);
            // 
            // ACmin
            // 
            this.ACmin.AccessibleDescription = "min";
            this.ACmin.AccessibleName = "mons.armorClass";
            this.ACmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ACmin.Location = new System.Drawing.Point(121, 281);
            this.ACmin.Name = "ACmin";
            this.ACmin.Size = new System.Drawing.Size(69, 20);
            this.ACmin.TabIndex = 57;
            this.ACmin.Text = "";
            this.ACmin.TextChanged += new System.EventHandler(this.TableUpdate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ACmax);
            this.Controls.Add(this.ACmin);
            this.Controls.Add(this.telepathyBox);
            this.Controls.Add(this.lairBox);
            this.Controls.Add(this.legendaryBox);
            this.Controls.Add(this.floatBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.profMax);
            this.Controls.Add(this.profMin);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CRmax);
            this.Controls.Add(this.CRmin);
            this.Controls.Add(this.avgHPmax);
            this.Controls.Add(this.avgHPmin);
            this.Controls.Add(this.maxEXP);
            this.Controls.Add(this.minEXP);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.CheckedListBox monsterTypeCheckBoxList;
        private System.Windows.Forms.CheckedListBox environmentCheckListBox;
        private System.Windows.Forms.CheckedListBox monsterSubtypeCheckListBox;
        private System.Windows.Forms.CheckedListBox alignmentCheckListBox;
        private System.Windows.Forms.CheckedListBox broadAlignmentCheckListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox actionCheckListBox;
        private System.Windows.Forms.CheckedListBox traitsCheckListBox;
        private System.Windows.Forms.CheckedListBox skillsCheckListBox;
        private System.Windows.Forms.CheckedListBox sensesCheckListBox;
        private System.Windows.Forms.CheckedListBox langCheckListBox;
        private System.Windows.Forms.CheckedListBox legendaryActCheckListBox;
        private System.Windows.Forms.CheckedListBox moveTypeCheckListBox;
        private System.Windows.Forms.CheckedListBox savingThrowCheckListBox;
        private System.Windows.Forms.CheckedListBox resistanceCheckListBox;
        private System.Windows.Forms.CheckedListBox immunityCheckListBox;
        private System.Windows.Forms.CheckedListBox weaknessCheckListBox;
        private System.Windows.Forms.RichTextBox minEXP;
        private System.Windows.Forms.RichTextBox maxEXP;
        private System.Windows.Forms.RichTextBox avgHPmax;
        private System.Windows.Forms.RichTextBox avgHPmin;
        private System.Windows.Forms.RichTextBox CRmax;
        private System.Windows.Forms.RichTextBox CRmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox profMax;
        private System.Windows.Forms.RichTextBox profMin;
        private System.Windows.Forms.CheckBox floatBox;
        private System.Windows.Forms.CheckBox legendaryBox;
        private System.Windows.Forms.CheckBox lairBox;
        private System.Windows.Forms.CheckBox telepathyBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox ACmax;
        private System.Windows.Forms.RichTextBox ACmin;
    }
}

