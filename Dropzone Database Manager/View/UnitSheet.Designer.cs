namespace Dropzone_Database_Manager.View
{
    partial class UnitSheet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.factionCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AircraftGroup = new System.Windows.Forms.GroupBox();
            this.LandingZoneCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.infrantryGroup = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FortitudeSelect = new System.Windows.Forms.NumericUpDown();
            this.CQBSelect = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.removeSpecialButton = new System.Windows.Forms.Button();
            this.addSpecialButton = new System.Windows.Forms.Button();
            this.specialText = new System.Windows.Forms.TextBox();
            this.specialListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeTransportButton = new System.Windows.Forms.Button();
            this.addTransportButton = new System.Windows.Forms.Button();
            this.transportText = new System.Windows.Forms.TextBox();
            this.transportListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SCRemoveButton = new System.Windows.Forms.Button();
            this.SCAddButton = new System.Windows.Forms.Button();
            this.SCText = new System.Windows.Forms.TextBox();
            this.SCListBox = new System.Windows.Forms.ListBox();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pointsSelect = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.DamageSelect = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.counterMeasuresGroup = new System.Windows.Forms.GroupBox();
            this.removeCMButton = new System.Windows.Forms.Button();
            this.addCMButton = new System.Windows.Forms.Button();
            this.cmText = new System.Windows.Forms.TextBox();
            this.cmListBox = new System.Windows.Forms.ListBox();
            this.moveSelect = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.armourSelect = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.AircraftGroup.SuspendLayout();
            this.infrantryGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FortitudeSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CQBSelect)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DamageSelect)).BeginInit();
            this.counterMeasuresGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armourSelect)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.factionCombo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.AircraftGroup);
            this.panel1.Controls.Add(this.infrantryGroup);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.TypeCombo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.categoryCombo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pointsSelect);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DamageSelect);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.counterMeasuresGroup);
            this.panel1.Controls.Add(this.moveSelect);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.armourSelect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Location = new System.Drawing.Point(22, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 473);
            this.panel1.TabIndex = 4;
            // 
            // factionCombo
            // 
            this.factionCombo.FormattingEnabled = true;
            this.factionCombo.Items.AddRange(new object[] {
            "UCM",
            "Scourge",
            "PHR",
            "Shaltari",
            "Resistance",
            "Fauna",
            "Civilian"});
            this.factionCombo.Location = new System.Drawing.Point(643, 62);
            this.factionCombo.Name = "factionCombo";
            this.factionCombo.Size = new System.Drawing.Size(121, 21);
            this.factionCombo.TabIndex = 27;
            this.factionCombo.SelectedIndexChanged += new System.EventHandler(this.factionCombo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(639, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Faction";
            // 
            // AircraftGroup
            // 
            this.AircraftGroup.Controls.Add(this.LandingZoneCombo);
            this.AircraftGroup.Controls.Add(this.label8);
            this.AircraftGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AircraftGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AircraftGroup.Location = new System.Drawing.Point(456, 97);
            this.AircraftGroup.Name = "AircraftGroup";
            this.AircraftGroup.Size = new System.Drawing.Size(159, 83);
            this.AircraftGroup.TabIndex = 25;
            this.AircraftGroup.TabStop = false;
            this.AircraftGroup.Text = "Aircraft";
            // 
            // LandingZoneCombo
            // 
            this.LandingZoneCombo.FormattingEnabled = true;
            this.LandingZoneCombo.Items.AddRange(new object[] {
            "Tiny",
            "S",
            "M",
            "L"});
            this.LandingZoneCombo.Location = new System.Drawing.Point(25, 49);
            this.LandingZoneCombo.Name = "LandingZoneCombo";
            this.LandingZoneCombo.Size = new System.Drawing.Size(121, 28);
            this.LandingZoneCombo.TabIndex = 18;
            this.LandingZoneCombo.SelectedIndexChanged += new System.EventHandler(this.LandingZoneCombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(26, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Landing Zone";
            // 
            // infrantryGroup
            // 
            this.infrantryGroup.Controls.Add(this.label10);
            this.infrantryGroup.Controls.Add(this.label9);
            this.infrantryGroup.Controls.Add(this.FortitudeSelect);
            this.infrantryGroup.Controls.Add(this.CQBSelect);
            this.infrantryGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infrantryGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infrantryGroup.Location = new System.Drawing.Point(638, 97);
            this.infrantryGroup.Name = "infrantryGroup";
            this.infrantryGroup.Size = new System.Drawing.Size(200, 100);
            this.infrantryGroup.TabIndex = 24;
            this.infrantryGroup.TabStop = false;
            this.infrantryGroup.Text = "Infantry Stats";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(111, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Fortitude";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(1, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "CQB";
            // 
            // FortitudeSelect
            // 
            this.FortitudeSelect.Location = new System.Drawing.Point(115, 62);
            this.FortitudeSelect.Name = "FortitudeSelect";
            this.FortitudeSelect.Size = new System.Drawing.Size(74, 27);
            this.FortitudeSelect.TabIndex = 22;
            this.FortitudeSelect.ValueChanged += new System.EventHandler(this.FortitudeSelect_ValueChanged);
            // 
            // CQBSelect
            // 
            this.CQBSelect.DecimalPlaces = 1;
            this.CQBSelect.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.CQBSelect.Location = new System.Drawing.Point(5, 61);
            this.CQBSelect.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CQBSelect.Name = "CQBSelect";
            this.CQBSelect.Size = new System.Drawing.Size(74, 27);
            this.CQBSelect.TabIndex = 20;
            this.CQBSelect.ValueChanged += new System.EventHandler(this.CQBSelect_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeSpecialButton);
            this.groupBox3.Controls.Add(this.addSpecialButton);
            this.groupBox3.Controls.Add(this.specialText);
            this.groupBox3.Controls.Add(this.specialListBox);
            this.groupBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(690, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 204);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Special";
            // 
            // removeSpecialButton
            // 
            this.removeSpecialButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeSpecialButton.Location = new System.Drawing.Point(95, 70);
            this.removeSpecialButton.Name = "removeSpecialButton";
            this.removeSpecialButton.Size = new System.Drawing.Size(83, 29);
            this.removeSpecialButton.TabIndex = 3;
            this.removeSpecialButton.Text = "Remove";
            this.removeSpecialButton.UseVisualStyleBackColor = true;
            this.removeSpecialButton.Click += new System.EventHandler(this.removeSpecialButton_Click);
            // 
            // addSpecialButton
            // 
            this.addSpecialButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addSpecialButton.Location = new System.Drawing.Point(6, 70);
            this.addSpecialButton.Name = "addSpecialButton";
            this.addSpecialButton.Size = new System.Drawing.Size(83, 29);
            this.addSpecialButton.TabIndex = 2;
            this.addSpecialButton.Text = "Add";
            this.addSpecialButton.UseVisualStyleBackColor = true;
            this.addSpecialButton.Click += new System.EventHandler(this.addSpecialButton_Click);
            // 
            // specialText
            // 
            this.specialText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialText.Location = new System.Drawing.Point(6, 26);
            this.specialText.Name = "specialText";
            this.specialText.Size = new System.Drawing.Size(214, 23);
            this.specialText.TabIndex = 1;
            // 
            // specialListBox
            // 
            this.specialListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialListBox.FormattingEnabled = true;
            this.specialListBox.ItemHeight = 16;
            this.specialListBox.Location = new System.Drawing.Point(6, 114);
            this.specialListBox.Name = "specialListBox";
            this.specialListBox.Size = new System.Drawing.Size(214, 84);
            this.specialListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeTransportButton);
            this.groupBox2.Controls.Add(this.addTransportButton);
            this.groupBox2.Controls.Add(this.transportText);
            this.groupBox2.Controls.Add(this.transportListBox);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(456, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 204);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transport";
            // 
            // removeTransportButton
            // 
            this.removeTransportButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeTransportButton.Location = new System.Drawing.Point(95, 70);
            this.removeTransportButton.Name = "removeTransportButton";
            this.removeTransportButton.Size = new System.Drawing.Size(83, 29);
            this.removeTransportButton.TabIndex = 3;
            this.removeTransportButton.Text = "Remove";
            this.removeTransportButton.UseVisualStyleBackColor = true;
            this.removeTransportButton.Click += new System.EventHandler(this.removeTransportButton_Click);
            // 
            // addTransportButton
            // 
            this.addTransportButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addTransportButton.Location = new System.Drawing.Point(6, 70);
            this.addTransportButton.Name = "addTransportButton";
            this.addTransportButton.Size = new System.Drawing.Size(83, 29);
            this.addTransportButton.TabIndex = 2;
            this.addTransportButton.Text = "Add";
            this.addTransportButton.UseVisualStyleBackColor = true;
            this.addTransportButton.Click += new System.EventHandler(this.addTransportButton_Click);
            // 
            // transportText
            // 
            this.transportText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportText.Location = new System.Drawing.Point(30, 26);
            this.transportText.Name = "transportText";
            this.transportText.Size = new System.Drawing.Size(100, 23);
            this.transportText.TabIndex = 1;
            // 
            // transportListBox
            // 
            this.transportListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportListBox.FormattingEnabled = true;
            this.transportListBox.ItemHeight = 16;
            this.transportListBox.Location = new System.Drawing.Point(30, 114);
            this.transportListBox.Name = "transportListBox";
            this.transportListBox.Size = new System.Drawing.Size(120, 84);
            this.transportListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SCRemoveButton);
            this.groupBox1.Controls.Add(this.SCAddButton);
            this.groupBox1.Controls.Add(this.SCText);
            this.groupBox1.Controls.Add(this.SCListBox);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(238, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 204);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Squad Coherancy";
            // 
            // SCRemoveButton
            // 
            this.SCRemoveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SCRemoveButton.Location = new System.Drawing.Point(95, 70);
            this.SCRemoveButton.Name = "SCRemoveButton";
            this.SCRemoveButton.Size = new System.Drawing.Size(83, 29);
            this.SCRemoveButton.TabIndex = 3;
            this.SCRemoveButton.Text = "Remove";
            this.SCRemoveButton.UseVisualStyleBackColor = true;
            this.SCRemoveButton.Click += new System.EventHandler(this.SCRemoveButton_Click);
            // 
            // SCAddButton
            // 
            this.SCAddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SCAddButton.Location = new System.Drawing.Point(6, 70);
            this.SCAddButton.Name = "SCAddButton";
            this.SCAddButton.Size = new System.Drawing.Size(83, 29);
            this.SCAddButton.TabIndex = 2;
            this.SCAddButton.Text = "Add";
            this.SCAddButton.UseVisualStyleBackColor = true;
            this.SCAddButton.Click += new System.EventHandler(this.SCAddButton_Click);
            // 
            // SCText
            // 
            this.SCText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCText.Location = new System.Drawing.Point(30, 26);
            this.SCText.Name = "SCText";
            this.SCText.Size = new System.Drawing.Size(100, 23);
            this.SCText.TabIndex = 1;
            // 
            // SCListBox
            // 
            this.SCListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCListBox.FormattingEnabled = true;
            this.SCListBox.ItemHeight = 16;
            this.SCListBox.Location = new System.Drawing.Point(30, 114);
            this.SCListBox.Name = "SCListBox";
            this.SCListBox.Size = new System.Drawing.Size(120, 84);
            this.SCListBox.TabIndex = 0;
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Items.AddRange(new object[] {
            "Vehicle",
            "Aircraft",
            "Infantry"});
            this.TypeCombo.Location = new System.Drawing.Point(238, 181);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(121, 21);
            this.TypeCombo.TabIndex = 14;
            this.TypeCombo.SelectedIndexChanged += new System.EventHandler(this.TypeCombo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(234, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Type";
            // 
            // categoryCombo
            // 
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "Command",
            "Standard",
            "Troops",
            "Scout",
            "Heavy",
            "Support",
            "Exotic",
            "Transport",
            "Airstrike",
            "Grasping*",
            "*",
            "Gate",
            "Drill"});
            this.categoryCombo.Location = new System.Drawing.Point(456, 62);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(121, 21);
            this.categoryCombo.TabIndex = 12;
            this.categoryCombo.SelectedIndexChanged += new System.EventHandler(this.categoryCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(452, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Category";
            // 
            // pointsSelect
            // 
            this.pointsSelect.Location = new System.Drawing.Point(238, 120);
            this.pointsSelect.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pointsSelect.Name = "pointsSelect";
            this.pointsSelect.Size = new System.Drawing.Size(74, 20);
            this.pointsSelect.TabIndex = 10;
            this.pointsSelect.ValueChanged += new System.EventHandler(this.pointsSelect_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(234, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Points";
            // 
            // DamageSelect
            // 
            this.DamageSelect.Location = new System.Drawing.Point(238, 62);
            this.DamageSelect.Name = "DamageSelect";
            this.DamageSelect.Size = new System.Drawing.Size(74, 20);
            this.DamageSelect.TabIndex = 8;
            this.DamageSelect.ValueChanged += new System.EventHandler(this.DamageSelect_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(234, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Damage Points";
            // 
            // counterMeasuresGroup
            // 
            this.counterMeasuresGroup.Controls.Add(this.removeCMButton);
            this.counterMeasuresGroup.Controls.Add(this.addCMButton);
            this.counterMeasuresGroup.Controls.Add(this.cmText);
            this.counterMeasuresGroup.Controls.Add(this.cmListBox);
            this.counterMeasuresGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterMeasuresGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.counterMeasuresGroup.Location = new System.Drawing.Point(15, 229);
            this.counterMeasuresGroup.Name = "counterMeasuresGroup";
            this.counterMeasuresGroup.Size = new System.Drawing.Size(184, 204);
            this.counterMeasuresGroup.TabIndex = 6;
            this.counterMeasuresGroup.TabStop = false;
            this.counterMeasuresGroup.Text = "Counter Measures";
            // 
            // removeCMButton
            // 
            this.removeCMButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeCMButton.Location = new System.Drawing.Point(95, 70);
            this.removeCMButton.Name = "removeCMButton";
            this.removeCMButton.Size = new System.Drawing.Size(83, 29);
            this.removeCMButton.TabIndex = 3;
            this.removeCMButton.Text = "Remove";
            this.removeCMButton.UseVisualStyleBackColor = true;
            this.removeCMButton.Click += new System.EventHandler(this.removeCMButton_Click);
            // 
            // addCMButton
            // 
            this.addCMButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addCMButton.Location = new System.Drawing.Point(6, 70);
            this.addCMButton.Name = "addCMButton";
            this.addCMButton.Size = new System.Drawing.Size(83, 29);
            this.addCMButton.TabIndex = 2;
            this.addCMButton.Text = "Add";
            this.addCMButton.UseVisualStyleBackColor = true;
            this.addCMButton.Click += new System.EventHandler(this.addCMButton_Click);
            // 
            // cmText
            // 
            this.cmText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmText.Location = new System.Drawing.Point(30, 26);
            this.cmText.Name = "cmText";
            this.cmText.Size = new System.Drawing.Size(100, 23);
            this.cmText.TabIndex = 1;
            // 
            // cmListBox
            // 
            this.cmListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmListBox.FormattingEnabled = true;
            this.cmListBox.ItemHeight = 16;
            this.cmListBox.Location = new System.Drawing.Point(30, 114);
            this.cmListBox.Name = "cmListBox";
            this.cmListBox.Size = new System.Drawing.Size(120, 84);
            this.cmListBox.TabIndex = 0;
            // 
            // moveSelect
            // 
            this.moveSelect.Location = new System.Drawing.Point(15, 181);
            this.moveSelect.Name = "moveSelect";
            this.moveSelect.Size = new System.Drawing.Size(74, 20);
            this.moveSelect.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Movement";
            // 
            // armourSelect
            // 
            this.armourSelect.Location = new System.Drawing.Point(15, 120);
            this.armourSelect.Name = "armourSelect";
            this.armourSelect.Size = new System.Drawing.Size(74, 20);
            this.armourSelect.TabIndex = 3;
            this.armourSelect.ValueChanged += new System.EventHandler(this.armourSelect_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(11, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Armour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(15, 62);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(185, 20);
            this.nameText.TabIndex = 0;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.ContinueButton);
            this.panel2.Location = new System.Drawing.Point(732, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 127);
            this.panel2.TabIndex = 5;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.Location = new System.Drawing.Point(30, 38);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(176, 69);
            this.ContinueButton.TabIndex = 0;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // UnitSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dropzone_Database_Manager.Properties.Resources.Aways_the_last__blue;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UnitSheet";
            this.Text = "UnitSheet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AircraftGroup.ResumeLayout(false);
            this.AircraftGroup.PerformLayout();
            this.infrantryGroup.ResumeLayout(false);
            this.infrantryGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FortitudeSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CQBSelect)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DamageSelect)).EndInit();
            this.counterMeasuresGroup.ResumeLayout(false);
            this.counterMeasuresGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armourSelect)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox factionCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox AircraftGroup;
        private System.Windows.Forms.ComboBox LandingZoneCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox infrantryGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown FortitudeSelect;
        private System.Windows.Forms.NumericUpDown CQBSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button removeSpecialButton;
        private System.Windows.Forms.Button addSpecialButton;
        private System.Windows.Forms.TextBox specialText;
        private System.Windows.Forms.ListBox specialListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeTransportButton;
        private System.Windows.Forms.Button addTransportButton;
        private System.Windows.Forms.TextBox transportText;
        private System.Windows.Forms.ListBox transportListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SCRemoveButton;
        private System.Windows.Forms.Button SCAddButton;
        private System.Windows.Forms.TextBox SCText;
        private System.Windows.Forms.ListBox SCListBox;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown pointsSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown DamageSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox counterMeasuresGroup;
        private System.Windows.Forms.Button removeCMButton;
        private System.Windows.Forms.Button addCMButton;
        private System.Windows.Forms.TextBox cmText;
        private System.Windows.Forms.ListBox cmListBox;
        private System.Windows.Forms.NumericUpDown moveSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown armourSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ContinueButton;
    }
}