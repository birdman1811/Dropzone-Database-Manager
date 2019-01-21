namespace Dropzone_Database_Manager.View
{
    partial class AddUnitSummaryForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeRuleButton = new System.Windows.Forms.Button();
            this.uniqueRulesListBox = new System.Windows.Forms.ListBox();
            this.addRuleButton = new System.Windows.Forms.Button();
            this.UniqueRuleText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.unitCompleteButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.mainMenuButton);
            this.panel2.Location = new System.Drawing.Point(12, 504);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 145);
            this.panel2.TabIndex = 3;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(20, 21);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(143, 99);
            this.mainMenuButton.TabIndex = 1;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.removeRuleButton);
            this.panel1.Controls.Add(this.uniqueRulesListBox);
            this.panel1.Controls.Add(this.addRuleButton);
            this.panel1.Controls.Add(this.UniqueRuleText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(228, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 463);
            this.panel1.TabIndex = 4;
            // 
            // removeRuleButton
            // 
            this.removeRuleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeRuleButton.Location = new System.Drawing.Point(370, 243);
            this.removeRuleButton.Name = "removeRuleButton";
            this.removeRuleButton.Size = new System.Drawing.Size(105, 79);
            this.removeRuleButton.TabIndex = 5;
            this.removeRuleButton.Text = "Remove Rule";
            this.removeRuleButton.UseVisualStyleBackColor = true;
            // 
            // uniqueRulesListBox
            // 
            this.uniqueRulesListBox.FormattingEnabled = true;
            this.uniqueRulesListBox.Location = new System.Drawing.Point(25, 243);
            this.uniqueRulesListBox.Name = "uniqueRulesListBox";
            this.uniqueRulesListBox.Size = new System.Drawing.Size(327, 199);
            this.uniqueRulesListBox.TabIndex = 4;
            this.uniqueRulesListBox.SelectedIndexChanged += new System.EventHandler(this.UniqueRulesListBox_SelectedIndexChanged);
            // 
            // addRuleButton
            // 
            this.addRuleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRuleButton.Location = new System.Drawing.Point(370, 112);
            this.addRuleButton.Name = "addRuleButton";
            this.addRuleButton.Size = new System.Drawing.Size(105, 79);
            this.addRuleButton.TabIndex = 3;
            this.addRuleButton.Text = "Add Rule";
            this.addRuleButton.UseVisualStyleBackColor = true;
            this.addRuleButton.Click += new System.EventHandler(this.AddRuleButton_Click);
            // 
            // UniqueRuleText
            // 
            this.UniqueRuleText.Location = new System.Drawing.Point(24, 112);
            this.UniqueRuleText.Multiline = true;
            this.UniqueRuleText.Name = "UniqueRuleText";
            this.UniqueRuleText.Size = new System.Drawing.Size(328, 113);
            this.UniqueRuleText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit Unique Rules";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(20, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(91, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "TitleLAbel";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Controls.Add(this.unitCompleteButton);
            this.panel3.Location = new System.Drawing.Point(770, 504);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 145);
            this.panel3.TabIndex = 5;
            // 
            // unitCompleteButton
            // 
            this.unitCompleteButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitCompleteButton.Location = new System.Drawing.Point(20, 21);
            this.unitCompleteButton.Name = "unitCompleteButton";
            this.unitCompleteButton.Size = new System.Drawing.Size(143, 99);
            this.unitCompleteButton.TabIndex = 1;
            this.unitCompleteButton.Text = "Add Unit";
            this.unitCompleteButton.UseVisualStyleBackColor = true;
            this.unitCompleteButton.Click += new System.EventHandler(this.UnitCompleteButton_Click);
            // 
            // AddUnitSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dropzone_Database_Manager.Properties.Resources.UCM_Flak_Team_Illustration_x2_jpg_WIP_8;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddUnitSummaryForm";
            this.Text = "AddUnitSummaryForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeRuleButton;
        private System.Windows.Forms.ListBox uniqueRulesListBox;
        private System.Windows.Forms.Button addRuleButton;
        private System.Windows.Forms.TextBox UniqueRuleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button unitCompleteButton;
    }
}