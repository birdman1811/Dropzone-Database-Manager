namespace Dropzone_Database_Manager.View
{
    partial class AddFactionForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.gamePlayText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoreText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddFactionButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gamePlayText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.imageText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LoreText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Location = new System.Drawing.Point(36, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 423);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(432, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Faction Gameplay";
            // 
            // gamePlayText
            // 
            this.gamePlayText.Location = new System.Drawing.Point(435, 177);
            this.gamePlayText.Multiline = true;
            this.gamePlayText.Name = "gamePlayText";
            this.gamePlayText.Size = new System.Drawing.Size(345, 131);
            this.gamePlayText.TabIndex = 6;
            this.gamePlayText.TextChanged += new System.EventHandler(this.GamePlayText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(432, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Faction Image URL";
            // 
            // imageText
            // 
            this.imageText.Location = new System.Drawing.Point(435, 74);
            this.imageText.Name = "imageText";
            this.imageText.Size = new System.Drawing.Size(345, 20);
            this.imageText.TabIndex = 4;
            this.imageText.TextChanged += new System.EventHandler(this.ImageText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Faction Lore";
            // 
            // LoreText
            // 
            this.LoreText.Location = new System.Drawing.Point(29, 177);
            this.LoreText.Multiline = true;
            this.LoreText.Name = "LoreText";
            this.LoreText.Size = new System.Drawing.Size(345, 131);
            this.LoreText.TabIndex = 2;
            this.LoreText.TextChanged += new System.EventHandler(this.LoreText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faction Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(29, 74);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(345, 20);
            this.nameText.TabIndex = 0;
            this.nameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.AddFactionButton);
            this.panel2.Location = new System.Drawing.Point(721, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 142);
            this.panel2.TabIndex = 1;
            // 
            // AddFactionButton
            // 
            this.AddFactionButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFactionButton.Location = new System.Drawing.Point(20, 25);
            this.AddFactionButton.Name = "AddFactionButton";
            this.AddFactionButton.Size = new System.Drawing.Size(154, 100);
            this.AddFactionButton.TabIndex = 0;
            this.AddFactionButton.Text = "Add Faction";
            this.AddFactionButton.UseVisualStyleBackColor = true;
            this.AddFactionButton.Click += new System.EventHandler(this.AddFactionButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.mainMenuButton);
            this.panel3.Location = new System.Drawing.Point(36, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 142);
            this.panel3.TabIndex = 2;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(20, 25);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(154, 100);
            this.mainMenuButton.TabIndex = 0;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // AddFactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dropzone_Database_Manager.Properties.Resources.Scourge_basic_form_autopsy_illustration_final;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddFactionForm";
            this.Text = "AddFactionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gamePlayText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imageText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoreText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddFactionButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button mainMenuButton;
    }
}