namespace Dropzone_Database_Manager.View
{
    partial class EditWeaponForm
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
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.energySelect = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.MFText = new System.Windows.Forms.TextBox();
            this.ShotsSelect = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.accuracySelect = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.fullRangeText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.counteredRangeText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FireArcsText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CloneWeaponButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditShowButton = new System.Windows.Forms.Button();
            this.EditWeaponButton = new System.Windows.Forms.Button();
            this.AddWeapon = new System.Windows.Forms.Button();
            this.RemoveWeaponButton = new System.Windows.Forms.Button();
            this.WeaponsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptionalCostSelect = new System.Windows.Forms.NumericUpDown();
            this.RemoveRuleButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.RulesListBox = new System.Windows.Forms.ListBox();
            this.isOptionalCheckBox = new System.Windows.Forms.CheckBox();
            this.AddRuleButton = new System.Windows.Forms.Button();
            this.SpecialRuleText = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.energySelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShotsSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accuracySelect)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OptionalCostSelect)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.statsGroupBox);
            this.panel1.Controls.Add(this.CloneWeaponButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.EditShowButton);
            this.panel1.Controls.Add(this.EditWeaponButton);
            this.panel1.Controls.Add(this.AddWeapon);
            this.panel1.Controls.Add(this.RemoveWeaponButton);
            this.panel1.Controls.Add(this.WeaponsListBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 476);
            this.panel1.TabIndex = 4;
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.label2);
            this.statsGroupBox.Controls.Add(this.nameText);
            this.statsGroupBox.Controls.Add(this.label3);
            this.statsGroupBox.Controls.Add(this.energySelect);
            this.statsGroupBox.Controls.Add(this.label1);
            this.statsGroupBox.Controls.Add(this.MFText);
            this.statsGroupBox.Controls.Add(this.ShotsSelect);
            this.statsGroupBox.Controls.Add(this.label4);
            this.statsGroupBox.Controls.Add(this.accuracySelect);
            this.statsGroupBox.Controls.Add(this.label5);
            this.statsGroupBox.Controls.Add(this.fullRangeText);
            this.statsGroupBox.Controls.Add(this.label6);
            this.statsGroupBox.Controls.Add(this.counteredRangeText);
            this.statsGroupBox.Controls.Add(this.label7);
            this.statsGroupBox.Controls.Add(this.FireArcsText);
            this.statsGroupBox.Controls.Add(this.label8);
            this.statsGroupBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statsGroupBox.Location = new System.Drawing.Point(515, 32);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(428, 327);
            this.statsGroupBox.TabIndex = 35;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Weapon Stats";
            this.statsGroupBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weapon Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(14, 59);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(173, 27);
            this.nameText.TabIndex = 2;
            this.nameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Energy";
            // 
            // energySelect
            // 
            this.energySelect.Location = new System.Drawing.Point(14, 133);
            this.energySelect.Name = "energySelect";
            this.energySelect.Size = new System.Drawing.Size(72, 27);
            this.energySelect.TabIndex = 4;
            this.energySelect.ValueChanged += new System.EventHandler(this.EnergySelect_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shots";
            // 
            // MFText
            // 
            this.MFText.Location = new System.Drawing.Point(231, 217);
            this.MFText.Name = "MFText";
            this.MFText.Size = new System.Drawing.Size(173, 27);
            this.MFText.TabIndex = 13;
            this.MFText.TextChanged += new System.EventHandler(this.MFText_TextChanged);
            // 
            // ShotsSelect
            // 
            this.ShotsSelect.Location = new System.Drawing.Point(14, 212);
            this.ShotsSelect.Name = "ShotsSelect";
            this.ShotsSelect.Size = new System.Drawing.Size(72, 27);
            this.ShotsSelect.TabIndex = 6;
            this.ShotsSelect.ValueChanged += new System.EventHandler(this.ShotsSelect_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(10, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Accuracy";
            // 
            // accuracySelect
            // 
            this.accuracySelect.Location = new System.Drawing.Point(14, 292);
            this.accuracySelect.Name = "accuracySelect";
            this.accuracySelect.Size = new System.Drawing.Size(72, 27);
            this.accuracySelect.TabIndex = 8;
            this.accuracySelect.ValueChanged += new System.EventHandler(this.AccuracySelect_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(227, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Range Full";
            // 
            // fullRangeText
            // 
            this.fullRangeText.Location = new System.Drawing.Point(231, 59);
            this.fullRangeText.Name = "fullRangeText";
            this.fullRangeText.Size = new System.Drawing.Size(173, 27);
            this.fullRangeText.TabIndex = 10;
            this.fullRangeText.TextChanged += new System.EventHandler(this.FullRangeText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(227, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Range Countered";
            // 
            // counteredRangeText
            // 
            this.counteredRangeText.Location = new System.Drawing.Point(231, 133);
            this.counteredRangeText.Name = "counteredRangeText";
            this.counteredRangeText.Size = new System.Drawing.Size(173, 27);
            this.counteredRangeText.TabIndex = 12;
            this.counteredRangeText.TextChanged += new System.EventHandler(this.CounteredRangeText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(227, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Move and Fire";
            // 
            // FireArcsText
            // 
            this.FireArcsText.Location = new System.Drawing.Point(231, 292);
            this.FireArcsText.Name = "FireArcsText";
            this.FireArcsText.Size = new System.Drawing.Size(173, 27);
            this.FireArcsText.TabIndex = 16;
            this.FireArcsText.TextChanged += new System.EventHandler(this.FireArcsText_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(227, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fire Arcs";
            // 
            // CloneWeaponButton
            // 
            this.CloneWeaponButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloneWeaponButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloneWeaponButton.Location = new System.Drawing.Point(37, 315);
            this.CloneWeaponButton.Name = "CloneWeaponButton";
            this.CloneWeaponButton.Size = new System.Drawing.Size(174, 35);
            this.CloneWeaponButton.TabIndex = 34;
            this.CloneWeaponButton.Text = "Clone";
            this.CloneWeaponButton.UseVisualStyleBackColor = true;
            this.CloneWeaponButton.Click += new System.EventHandler(this.CloneWeaponButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddButton.Location = new System.Drawing.Point(37, 274);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(174, 35);
            this.AddButton.TabIndex = 33;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditShowButton
            // 
            this.EditShowButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditShowButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditShowButton.Location = new System.Drawing.Point(37, 230);
            this.EditShowButton.Name = "EditShowButton";
            this.EditShowButton.Size = new System.Drawing.Size(174, 35);
            this.EditShowButton.TabIndex = 32;
            this.EditShowButton.Text = "Edit / Show";
            this.EditShowButton.UseVisualStyleBackColor = true;
            this.EditShowButton.Click += new System.EventHandler(this.EditShowButton_Click);
            // 
            // EditWeaponButton
            // 
            this.EditWeaponButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditWeaponButton.Location = new System.Drawing.Point(566, 380);
            this.EditWeaponButton.Name = "EditWeaponButton";
            this.EditWeaponButton.Size = new System.Drawing.Size(174, 64);
            this.EditWeaponButton.TabIndex = 31;
            this.EditWeaponButton.Text = "Edit Weapon";
            this.EditWeaponButton.UseVisualStyleBackColor = true;
            this.EditWeaponButton.Visible = false;
            this.EditWeaponButton.Click += new System.EventHandler(this.EditWeaponButton_Click);
            // 
            // AddWeapon
            // 
            this.AddWeapon.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWeapon.Location = new System.Drawing.Point(746, 380);
            this.AddWeapon.Name = "AddWeapon";
            this.AddWeapon.Size = new System.Drawing.Size(174, 64);
            this.AddWeapon.TabIndex = 30;
            this.AddWeapon.Text = "Add Weapon";
            this.AddWeapon.UseVisualStyleBackColor = true;
            this.AddWeapon.Visible = false;
            this.AddWeapon.Click += new System.EventHandler(this.AddWeapon_Click);
            // 
            // RemoveWeaponButton
            // 
            this.RemoveWeaponButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveWeaponButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveWeaponButton.Location = new System.Drawing.Point(37, 185);
            this.RemoveWeaponButton.Name = "RemoveWeaponButton";
            this.RemoveWeaponButton.Size = new System.Drawing.Size(174, 35);
            this.RemoveWeaponButton.TabIndex = 19;
            this.RemoveWeaponButton.Text = "Remove";
            this.RemoveWeaponButton.UseVisualStyleBackColor = true;
            this.RemoveWeaponButton.Click += new System.EventHandler(this.RemoveWeaponButton_Click);
            // 
            // WeaponsListBox
            // 
            this.WeaponsListBox.FormattingEnabled = true;
            this.WeaponsListBox.Location = new System.Drawing.Point(21, 58);
            this.WeaponsListBox.Name = "WeaponsListBox";
            this.WeaponsListBox.Size = new System.Drawing.Size(200, 121);
            this.WeaponsListBox.TabIndex = 18;
            this.WeaponsListBox.SelectedIndexChanged += new System.EventHandler(this.WeaponsListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OptionalCostSelect);
            this.groupBox1.Controls.Add(this.RemoveRuleButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.RulesListBox);
            this.groupBox1.Controls.Add(this.isOptionalCheckBox);
            this.groupBox1.Controls.Add(this.AddRuleButton);
            this.groupBox1.Controls.Add(this.SpecialRuleText);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(239, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 379);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special";
            this.groupBox1.Visible = false;
            // 
            // OptionalCostSelect
            // 
            this.OptionalCostSelect.Location = new System.Drawing.Point(28, 338);
            this.OptionalCostSelect.Name = "OptionalCostSelect";
            this.OptionalCostSelect.Size = new System.Drawing.Size(72, 27);
            this.OptionalCostSelect.TabIndex = 23;
            this.OptionalCostSelect.ValueChanged += new System.EventHandler(this.OptionalCostSelect_ValueChanged);
            // 
            // RemoveRuleButton
            // 
            this.RemoveRuleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveRuleButton.Location = new System.Drawing.Point(37, 216);
            this.RemoveRuleButton.Name = "RemoveRuleButton";
            this.RemoveRuleButton.Size = new System.Drawing.Size(174, 35);
            this.RemoveRuleButton.TabIndex = 3;
            this.RemoveRuleButton.Text = "Remove";
            this.RemoveRuleButton.UseVisualStyleBackColor = true;
            this.RemoveRuleButton.Click += new System.EventHandler(this.RemoveRuleButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(24, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Optional Cost";
            // 
            // RulesListBox
            // 
            this.RulesListBox.FormattingEnabled = true;
            this.RulesListBox.ItemHeight = 20;
            this.RulesListBox.Location = new System.Drawing.Point(6, 110);
            this.RulesListBox.Name = "RulesListBox";
            this.RulesListBox.Size = new System.Drawing.Size(247, 104);
            this.RulesListBox.TabIndex = 2;
            // 
            // isOptionalCheckBox
            // 
            this.isOptionalCheckBox.AutoSize = true;
            this.isOptionalCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isOptionalCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isOptionalCheckBox.Location = new System.Drawing.Point(28, 271);
            this.isOptionalCheckBox.Name = "isOptionalCheckBox";
            this.isOptionalCheckBox.Size = new System.Drawing.Size(194, 28);
            this.isOptionalCheckBox.TabIndex = 21;
            this.isOptionalCheckBox.Text = "Optional Weapon";
            this.isOptionalCheckBox.UseVisualStyleBackColor = true;
            this.isOptionalCheckBox.CheckedChanged += new System.EventHandler(this.IsOptionalCheckBox_CheckedChanged);
            // 
            // AddRuleButton
            // 
            this.AddRuleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddRuleButton.Location = new System.Drawing.Point(37, 63);
            this.AddRuleButton.Name = "AddRuleButton";
            this.AddRuleButton.Size = new System.Drawing.Size(174, 35);
            this.AddRuleButton.TabIndex = 1;
            this.AddRuleButton.Text = "Add";
            this.AddRuleButton.UseVisualStyleBackColor = true;
            this.AddRuleButton.Click += new System.EventHandler(this.AddRuleButton_Click);
            // 
            // SpecialRuleText
            // 
            this.SpecialRuleText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialRuleText.Location = new System.Drawing.Point(6, 36);
            this.SpecialRuleText.Name = "SpecialRuleText";
            this.SpecialRuleText.Size = new System.Drawing.Size(247, 23);
            this.SpecialRuleText.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleLabel.Location = new System.Drawing.Point(17, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(59, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.ContinueButton);
            this.panel2.Location = new System.Drawing.Point(730, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 127);
            this.panel2.TabIndex = 6;
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
            // EditWeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dropzone_Database_Manager.Properties.Resources.Aways_the_last__blue;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditWeaponForm";
            this.Text = "EditWeaponForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.energySelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShotsSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accuracySelect)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OptionalCostSelect)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox MFText;
        private System.Windows.Forms.NumericUpDown OptionalCostSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox isOptionalCheckBox;
        private System.Windows.Forms.Button AddWeapon;
        private System.Windows.Forms.Button RemoveWeaponButton;
        private System.Windows.Forms.ListBox WeaponsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveRuleButton;
        private System.Windows.Forms.ListBox RulesListBox;
        private System.Windows.Forms.Button AddRuleButton;
        private System.Windows.Forms.TextBox SpecialRuleText;
        private System.Windows.Forms.TextBox FireArcsText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox counteredRangeText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fullRangeText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown accuracySelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ShotsSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown energySelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.Button CloneWeaponButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditShowButton;
        private System.Windows.Forms.Button EditWeaponButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ContinueButton;
    }
}