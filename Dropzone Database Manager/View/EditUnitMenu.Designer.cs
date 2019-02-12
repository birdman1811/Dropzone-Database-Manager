namespace Dropzone_Database_Manager.View
{
    partial class EditUnitMenu
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
            this.FactionCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FactionSelectButton = new System.Windows.Forms.Button();
            this.UnitCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnitPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.UnitPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.FactionSelectButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FactionCombo);
            this.panel1.Location = new System.Drawing.Point(246, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 248);
            this.panel1.TabIndex = 0;
            // 
            // FactionCombo
            // 
            this.FactionCombo.FormattingEnabled = true;
            this.FactionCombo.Location = new System.Drawing.Point(34, 61);
            this.FactionCombo.Name = "FactionCombo";
            this.FactionCombo.Size = new System.Drawing.Size(131, 21);
            this.FactionCombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faction";
            // 
            // FactionSelectButton
            // 
            this.FactionSelectButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactionSelectButton.Location = new System.Drawing.Point(34, 130);
            this.FactionSelectButton.Name = "FactionSelectButton";
            this.FactionSelectButton.Size = new System.Drawing.Size(131, 64);
            this.FactionSelectButton.TabIndex = 4;
            this.FactionSelectButton.Text = "Select Faction";
            this.FactionSelectButton.UseVisualStyleBackColor = true;
            this.FactionSelectButton.Click += new System.EventHandler(this.FactionSelectButton_Click);
            // 
            // UnitCombo
            // 
            this.UnitCombo.FormattingEnabled = true;
            this.UnitCombo.Location = new System.Drawing.Point(34, 61);
            this.UnitCombo.Name = "UnitCombo";
            this.UnitCombo.Size = new System.Drawing.Size(131, 21);
            this.UnitCombo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unit";
            // 
            // UnitPanel
            // 
            this.UnitPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.UnitPanel.Controls.Add(this.button1);
            this.UnitPanel.Controls.Add(this.label2);
            this.UnitPanel.Controls.Add(this.UnitCombo);
            this.UnitPanel.Location = new System.Drawing.Point(530, 180);
            this.UnitPanel.Name = "UnitPanel";
            this.UnitPanel.Size = new System.Drawing.Size(198, 248);
            this.UnitPanel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select Unit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.MainMenu);
            this.panel2.Location = new System.Drawing.Point(706, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 5;
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(16, 22);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(163, 56);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // EditUnitMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dropzone_Database_Manager.Properties.Resources.Aways_the_last__blue;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UnitPanel);
            this.Controls.Add(this.panel1);
            this.Name = "EditUnitMenu";
            this.Text = "EditUnitMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UnitPanel.ResumeLayout(false);
            this.UnitPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FactionSelectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FactionCombo;
        private System.Windows.Forms.ComboBox UnitCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel UnitPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MainMenu;
    }
}