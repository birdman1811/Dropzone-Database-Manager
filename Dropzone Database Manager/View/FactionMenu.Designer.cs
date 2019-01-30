namespace Dropzone_Database_Manager.View
{
    partial class FactionMenu
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
            this.AddFactionButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.AddFactionButton);
            this.panel1.Location = new System.Drawing.Point(297, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 254);
            this.panel1.TabIndex = 0;
            // 
            // AddFactionButton
            // 
            this.AddFactionButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFactionButton.Location = new System.Drawing.Point(52, 69);
            this.AddFactionButton.Name = "AddFactionButton";
            this.AddFactionButton.Size = new System.Drawing.Size(118, 111);
            this.AddFactionButton.TabIndex = 0;
            this.AddFactionButton.Text = "Add Faction";
            this.AddFactionButton.UseVisualStyleBackColor = true;
            this.AddFactionButton.Click += new System.EventHandler(this.AddFactionButton_Click);
            // 
            // FactionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dropzone_Database_Manager.Properties.Resources.Scourge_basic_form_autopsy_illustration_final;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FactionMenu";
            this.Text = "FactionMenu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddFactionButton;
    }
}