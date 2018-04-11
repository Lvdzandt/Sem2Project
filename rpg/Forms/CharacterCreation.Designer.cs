namespace rpg
{
    partial class CharacterCreation
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
            this.CharConfirm = new System.Windows.Forms.Button();
            this.CharName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CharRace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenderV = new System.Windows.Forms.RadioButton();
            this.DiffSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenderM = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TraitBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WeaponSelect = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CharConfirm
            // 
            this.CharConfirm.Location = new System.Drawing.Point(165, 170);
            this.CharConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.CharConfirm.Name = "CharConfirm";
            this.CharConfirm.Size = new System.Drawing.Size(121, 39);
            this.CharConfirm.TabIndex = 0;
            this.CharConfirm.Text = "Confirm";
            this.CharConfirm.UseVisualStyleBackColor = true;
            this.CharConfirm.Click += new System.EventHandler(this.CharConfirm_Click);
            // 
            // CharName
            // 
            this.CharName.Location = new System.Drawing.Point(101, 41);
            this.CharName.Margin = new System.Windows.Forms.Padding(4);
            this.CharName.Name = "CharName";
            this.CharName.Size = new System.Drawing.Size(132, 22);
            this.CharName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // CharRace
            // 
            this.CharRace.FormattingEnabled = true;
            this.CharRace.Location = new System.Drawing.Point(98, 97);
            this.CharRace.Margin = new System.Windows.Forms.Padding(4);
            this.CharRace.Name = "CharRace";
            this.CharRace.Size = new System.Drawing.Size(132, 24);
            this.CharRace.TabIndex = 3;
            this.CharRace.SelectedIndexChanged += new System.EventHandler(this.CharRace_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Race:";
            // 
            // GenderV
            // 
            this.GenderV.AutoSize = true;
            this.GenderV.Location = new System.Drawing.Point(192, 74);
            this.GenderV.Margin = new System.Windows.Forms.Padding(4);
            this.GenderV.Name = "GenderV";
            this.GenderV.Size = new System.Drawing.Size(38, 21);
            this.GenderV.TabIndex = 13;
            this.GenderV.TabStop = true;
            this.GenderV.Text = "V";
            this.GenderV.UseVisualStyleBackColor = true;
            // 
            // DiffSelect
            // 
            this.DiffSelect.FormattingEnabled = true;
            this.DiffSelect.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.DiffSelect.Location = new System.Drawing.Point(335, 41);
            this.DiffSelect.Margin = new System.Windows.Forms.Padding(4);
            this.DiffSelect.Name = "DiffSelect";
            this.DiffSelect.Size = new System.Drawing.Size(132, 24);
            this.DiffSelect.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Diffeculty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Special:";
            // 
            // GenderM
            // 
            this.GenderM.AutoSize = true;
            this.GenderM.Location = new System.Drawing.Point(101, 74);
            this.GenderM.Margin = new System.Windows.Forms.Padding(4);
            this.GenderM.Name = "GenderM";
            this.GenderM.Size = new System.Drawing.Size(40, 21);
            this.GenderM.TabIndex = 12;
            this.GenderM.TabStop = true;
            this.GenderM.Text = "M";
            this.GenderM.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender:";
            // 
            // TraitBox
            // 
            this.TraitBox.Location = new System.Drawing.Point(335, 97);
            this.TraitBox.Margin = new System.Windows.Forms.Padding(4);
            this.TraitBox.Name = "TraitBox";
            this.TraitBox.Size = new System.Drawing.Size(132, 22);
            this.TraitBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Weapon:";
            // 
            // WeaponSelect
            // 
            this.WeaponSelect.FormattingEnabled = true;
            this.WeaponSelect.Location = new System.Drawing.Point(98, 130);
            this.WeaponSelect.Margin = new System.Windows.Forms.Padding(4);
            this.WeaponSelect.Name = "WeaponSelect";
            this.WeaponSelect.Size = new System.Drawing.Size(132, 24);
            this.WeaponSelect.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(485, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 84);
            this.listBox1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Quest:";
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 273);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.WeaponSelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TraitBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiffSelect);
            this.Controls.Add(this.GenderV);
            this.Controls.Add(this.GenderM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CharRace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharName);
            this.Controls.Add(this.CharConfirm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CharacterCreation";
            this.Text = "CharacterCreation";
            this.Load += new System.EventHandler(this.CharacterCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CharConfirm;
        private System.Windows.Forms.TextBox CharName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CharRace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton GenderV;
        private System.Windows.Forms.ComboBox DiffSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton GenderM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TraitBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox WeaponSelect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
    }
}