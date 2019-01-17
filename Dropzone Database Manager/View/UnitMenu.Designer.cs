namespace Dropzone_Database_Manager.View
{
    partial class UnitMenu
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
            this.addUnitBUtton = new System.Windows.Forms.Button();
            this.editUnitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.editUnitButton);
            this.panel1.Controls.Add(this.addUnitBUtton);
            this.panel1.Location = new System.Drawing.Point(317, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 145);
            this.panel1.TabIndex = 0;
            // 
            // addUnitBUtton
            // 
            this.addUnitBUtton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUnitBUtton.Location = new System.Drawing.Point(14, 28);
            this.addUnitBUtton.Name = "addUnitBUtton";
            this.addUnitBUtton.Size = new System.Drawing.Size(143, 99);
            this.addUnitBUtton.TabIndex = 0;
            this.addUnitBUtton.Text = "Add Unit";
            this.addUnitBUtton.UseVisualStyleBackColor = true;
            // 
            // editUnitButton
            // 
            this.editUnitButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUnitButton.Location = new System.Drawing.Point(162, 28);
            this.editUnitButton.Name = "editUnitButton";
            this.editUnitButton.Size = new System.Drawing.Size(143, 99);
            this.editUnitButton.TabIndex = 1;
            this.editUnitButton.Text = "Edit / Delete Unit";
            this.editUnitButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.mainMenuButton);
            this.panel2.Location = new System.Drawing.Point(762, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 145);
            this.panel2.TabIndex = 1;
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
            // UnitMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dropzone_Database_Manager.Properties.Resources.UCM_Heavy_Hazard_suit__Final_x;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UnitMenu";
            this.Text = "UnitMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editUnitButton;
        private System.Windows.Forms.Button addUnitBUtton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mainMenuButton;
    }
}