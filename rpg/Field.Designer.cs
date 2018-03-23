namespace rpg
{
    partial class Field
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
            this.AttackEnemy = new System.Windows.Forms.Button();
            this.AddEnemy = new System.Windows.Forms.Button();
            this.CehckEnemy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayerWeapon = new System.Windows.Forms.Label();
            this.PlayerHP = new System.Windows.Forms.Label();
            this.PlayerRace = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AttackEnemy
            // 
            this.AttackEnemy.Location = new System.Drawing.Point(279, 56);
            this.AttackEnemy.Name = "AttackEnemy";
            this.AttackEnemy.Size = new System.Drawing.Size(75, 23);
            this.AttackEnemy.TabIndex = 1;
            this.AttackEnemy.Text = "Attack";
            this.AttackEnemy.UseVisualStyleBackColor = true;
            this.AttackEnemy.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddEnemy
            // 
            this.AddEnemy.Location = new System.Drawing.Point(279, 27);
            this.AddEnemy.Name = "AddEnemy";
            this.AddEnemy.Size = new System.Drawing.Size(75, 23);
            this.AddEnemy.TabIndex = 2;
            this.AddEnemy.Text = "AddEnemy";
            this.AddEnemy.UseVisualStyleBackColor = true;
            this.AddEnemy.Click += new System.EventHandler(this.button3_Click);
            // 
            // CehckEnemy
            // 
            this.CehckEnemy.Location = new System.Drawing.Point(191, 56);
            this.CehckEnemy.Name = "CehckEnemy";
            this.CehckEnemy.Size = new System.Drawing.Size(82, 23);
            this.CehckEnemy.TabIndex = 3;
            this.CehckEnemy.Text = "CheckEnemy";
            this.CehckEnemy.UseVisualStyleBackColor = true;
            this.CehckEnemy.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlayerWeapon);
            this.groupBox1.Controls.Add(this.PlayerHP);
            this.groupBox1.Controls.Add(this.PlayerRace);
            this.groupBox1.Controls.Add(this.PlayerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // PlayerWeapon
            // 
            this.PlayerWeapon.AutoSize = true;
            this.PlayerWeapon.Location = new System.Drawing.Point(68, 88);
            this.PlayerWeapon.Name = "PlayerWeapon";
            this.PlayerWeapon.Size = new System.Drawing.Size(10, 13);
            this.PlayerWeapon.TabIndex = 7;
            this.PlayerWeapon.Text = "-";
            // 
            // PlayerHP
            // 
            this.PlayerHP.AutoSize = true;
            this.PlayerHP.Location = new System.Drawing.Point(68, 65);
            this.PlayerHP.Name = "PlayerHP";
            this.PlayerHP.Size = new System.Drawing.Size(13, 13);
            this.PlayerHP.TabIndex = 6;
            this.PlayerHP.Text = "0";
            // 
            // PlayerRace
            // 
            this.PlayerRace.AutoSize = true;
            this.PlayerRace.Location = new System.Drawing.Point(68, 41);
            this.PlayerRace.Name = "PlayerRace";
            this.PlayerRace.Size = new System.Drawing.Size(10, 13);
            this.PlayerRace.TabIndex = 5;
            this.PlayerRace.Text = "-";
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Location = new System.Drawing.Point(68, 20);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(10, 13);
            this.PlayerName.TabIndex = 4;
            this.PlayerName.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weapon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Race:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CehckEnemy);
            this.Controls.Add(this.AddEnemy);
            this.Controls.Add(this.AttackEnemy);
            this.Name = "Field";
            this.Text = "Field";
            this.Load += new System.EventHandler(this.Field_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AttackEnemy;
        private System.Windows.Forms.Button AddEnemy;
        private System.Windows.Forms.Button CehckEnemy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PlayerWeapon;
        private System.Windows.Forms.Label PlayerHP;
        private System.Windows.Forms.Label PlayerRace;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}