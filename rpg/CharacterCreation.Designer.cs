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
            this.label6 = new System.Windows.Forms.Label();
            this.GenderM = new System.Windows.Forms.RadioButton();
            this.GenderV = new System.Windows.Forms.RadioButton();
            this.DiffSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CharConfirm
            // 
            this.CharConfirm.Location = new System.Drawing.Point(101, 136);
            this.CharConfirm.Name = "CharConfirm";
            this.CharConfirm.Size = new System.Drawing.Size(75, 23);
            this.CharConfirm.TabIndex = 0;
            this.CharConfirm.Text = "Confirm";
            this.CharConfirm.UseVisualStyleBackColor = true;
            this.CharConfirm.Click += new System.EventHandler(this.CharConfirm_Click);
            // 
            // CharName
            // 
            this.CharName.Location = new System.Drawing.Point(76, 33);
            this.CharName.Name = "CharName";
            this.CharName.Size = new System.Drawing.Size(100, 20);
            this.CharName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // CharRace
            // 
            this.CharRace.FormattingEnabled = true;
            this.CharRace.Location = new System.Drawing.Point(76, 83);
            this.CharRace.Name = "CharRace";
            this.CharRace.Size = new System.Drawing.Size(100, 21);
            this.CharRace.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Race:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender:";
            // 
            // GenderM
            // 
            this.GenderM.AutoSize = true;
            this.GenderM.Location = new System.Drawing.Point(76, 60);
            this.GenderM.Name = "GenderM";
            this.GenderM.Size = new System.Drawing.Size(34, 17);
            this.GenderM.TabIndex = 12;
            this.GenderM.TabStop = true;
            this.GenderM.Text = "M";
            this.GenderM.UseVisualStyleBackColor = true;
            // 
            // GenderV
            // 
            this.GenderV.AutoSize = true;
            this.GenderV.Location = new System.Drawing.Point(144, 60);
            this.GenderV.Name = "GenderV";
            this.GenderV.Size = new System.Drawing.Size(32, 17);
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
            this.DiffSelect.Location = new System.Drawing.Point(76, 109);
            this.DiffSelect.Name = "DiffSelect";
            this.DiffSelect.Size = new System.Drawing.Size(100, 21);
            this.DiffSelect.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Diffeculty:";
            // 
            // CharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 222);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton GenderM;
        private System.Windows.Forms.RadioButton GenderV;
        private System.Windows.Forms.ComboBox DiffSelect;
        private System.Windows.Forms.Label label3;
    }
}