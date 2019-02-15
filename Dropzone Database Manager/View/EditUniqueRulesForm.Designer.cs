namespace Dropzone_Database_Manager.View
{
    partial class EditUniqueRulesForm
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
            this.removeRuleButton = new System.Windows.Forms.Button();
            this.uniqueRulesListBox = new System.Windows.Forms.ListBox();
            this.addRuleButton = new System.Windows.Forms.Button();
            this.UniqueRuleText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.EditRuleButton = new System.Windows.Forms.Button();
            this.AddThisRuleButton = new System.Windows.Forms.Button();
            this.UpdateCompleteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.UpdateCompleteButton);
            this.panel1.Controls.Add(this.AddThisRuleButton);
            this.panel1.Controls.Add(this.EditRuleButton);
            this.panel1.Controls.Add(this.removeRuleButton);
            this.panel1.Controls.Add(this.uniqueRulesListBox);
            this.panel1.Controls.Add(this.addRuleButton);
            this.panel1.Controls.Add(this.UniqueRuleText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Location = new System.Drawing.Point(149, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 552);
            this.panel1.TabIndex = 5;
            // 
            // removeRuleButton
            // 
            this.removeRuleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeRuleButton.Location = new System.Drawing.Point(369, 98);
            this.removeRuleButton.Name = "removeRuleButton";
            this.removeRuleButton.Size = new System.Drawing.Size(105, 79);
            this.removeRuleButton.TabIndex = 5;
            this.removeRuleButton.Text = "Remove Rule";
            this.removeRuleButton.UseVisualStyleBackColor = true;
            this.removeRuleButton.Click += new System.EventHandler(this.removeRuleButton_Click);
            // 
            // uniqueRulesListBox
            // 
            this.uniqueRulesListBox.FormattingEnabled = true;
            this.uniqueRulesListBox.Location = new System.Drawing.Point(25, 98);
            this.uniqueRulesListBox.Name = "uniqueRulesListBox";
            this.uniqueRulesListBox.Size = new System.Drawing.Size(327, 199);
            this.uniqueRulesListBox.TabIndex = 4;
            // 
            // addRuleButton
            // 
            this.addRuleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRuleButton.Location = new System.Drawing.Point(369, 268);
            this.addRuleButton.Name = "addRuleButton";
            this.addRuleButton.Size = new System.Drawing.Size(105, 79);
            this.addRuleButton.TabIndex = 3;
            this.addRuleButton.Text = "Add Rule";
            this.addRuleButton.UseVisualStyleBackColor = true;
            this.addRuleButton.Click += new System.EventHandler(this.addRuleButton_Click);
            // 
            // UniqueRuleText
            // 
            this.UniqueRuleText.Location = new System.Drawing.Point(24, 320);
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
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleLabel.Location = new System.Drawing.Point(20, 18);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(91, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "TitleLAbel";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(735, 512);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 127);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditRuleButton
            // 
            this.EditRuleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRuleButton.Location = new System.Drawing.Point(369, 183);
            this.EditRuleButton.Name = "EditRuleButton";
            this.EditRuleButton.Size = new System.Drawing.Size(105, 79);
            this.EditRuleButton.TabIndex = 6;
            this.EditRuleButton.Text = "Edit Rule";
            this.EditRuleButton.UseVisualStyleBackColor = true;
            this.EditRuleButton.Click += new System.EventHandler(this.EditRuleButton_Click);
            // 
            // AddThisRuleButton
            // 
            this.AddThisRuleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddThisRuleButton.Location = new System.Drawing.Point(25, 439);
            this.AddThisRuleButton.Name = "AddThisRuleButton";
            this.AddThisRuleButton.Size = new System.Drawing.Size(105, 79);
            this.AddThisRuleButton.TabIndex = 7;
            this.AddThisRuleButton.Text = "Add Rule";
            this.AddThisRuleButton.UseVisualStyleBackColor = true;
            this.AddThisRuleButton.Visible = false;
            this.AddThisRuleButton.Click += new System.EventHandler(this.AddThisRuleButton_Click);
            // 
            // UpdateCompleteButton
            // 
            this.UpdateCompleteButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCompleteButton.Location = new System.Drawing.Point(149, 439);
            this.UpdateCompleteButton.Name = "UpdateCompleteButton";
            this.UpdateCompleteButton.Size = new System.Drawing.Size(105, 79);
            this.UpdateCompleteButton.TabIndex = 8;
            this.UpdateCompleteButton.Text = "Finish Update";
            this.UpdateCompleteButton.UseVisualStyleBackColor = true;
            this.UpdateCompleteButton.Visible = false;
            this.UpdateCompleteButton.Click += new System.EventHandler(this.UpdateCompleteButton_Click);
            // 
            // EditUniqueRulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dropzone_Database_Manager.Properties.Resources.Aways_the_last__blue;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "EditUniqueRulesForm";
            this.Text = "EditUniqueRulesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeRuleButton;
        private System.Windows.Forms.ListBox uniqueRulesListBox;
        private System.Windows.Forms.Button addRuleButton;
        private System.Windows.Forms.TextBox UniqueRuleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdateCompleteButton;
        private System.Windows.Forms.Button AddThisRuleButton;
        private System.Windows.Forms.Button EditRuleButton;
    }
}