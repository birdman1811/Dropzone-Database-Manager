namespace Dropzone_Database_Manager.View
{
    partial class StartMenu
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
            this.UnitsButton = new System.Windows.Forms.Button();
            this.FactionsButton = new System.Windows.Forms.Button();
            this.RulesButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.UsersButton);
            this.panel1.Controls.Add(this.RulesButton);
            this.panel1.Controls.Add(this.FactionsButton);
            this.panel1.Controls.Add(this.UnitsButton);
            this.panel1.Location = new System.Drawing.Point(292, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 275);
            this.panel1.TabIndex = 0;
            // 
            // UnitsButton
            // 
            this.UnitsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsButton.Location = new System.Drawing.Point(239, 43);
            this.UnitsButton.Name = "UnitsButton";
            this.UnitsButton.Size = new System.Drawing.Size(164, 82);
            this.UnitsButton.TabIndex = 0;
            this.UnitsButton.Text = "Units";
            this.UnitsButton.UseVisualStyleBackColor = true;
            // 
            // FactionsButton
            // 
            this.FactionsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactionsButton.Location = new System.Drawing.Point(36, 43);
            this.FactionsButton.Name = "FactionsButton";
            this.FactionsButton.Size = new System.Drawing.Size(164, 82);
            this.FactionsButton.TabIndex = 1;
            this.FactionsButton.Text = "Factions";
            this.FactionsButton.UseVisualStyleBackColor = true;
            // 
            // RulesButton
            // 
            this.RulesButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesButton.Location = new System.Drawing.Point(36, 152);
            this.RulesButton.Name = "RulesButton";
            this.RulesButton.Size = new System.Drawing.Size(164, 82);
            this.RulesButton.TabIndex = 2;
            this.RulesButton.Text = "Rules";
            this.RulesButton.UseVisualStyleBackColor = true;
            // 
            // UsersButton
            // 
            this.UsersButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersButton.Location = new System.Drawing.Point(239, 152);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(164, 82);
            this.UsersButton.TabIndex = 3;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dropzone_Database_Manager.Properties.Resources._1_Overgrown_Final;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button RulesButton;
        private System.Windows.Forms.Button FactionsButton;
        private System.Windows.Forms.Button UnitsButton;
    }
}