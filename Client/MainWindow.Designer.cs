namespace Client
{
    partial class MainWindow
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
            this.CurseTabel = new System.Windows.Forms.DataGridView();
            this.PartTabel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NumePart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumePartTxt = new System.Windows.Forms.TextBox();
            this.NumeEchipaTxt = new System.Windows.Forms.TextBox();
            this.CapacitateBox = new System.Windows.Forms.ComboBox();
            this.SubmitBttn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ClearSearchBttn = new System.Windows.Forms.Button();
            this.SearchBttn = new System.Windows.Forms.Button();
            this.Team = new System.Windows.Forms.Label();
            this.ClearSubmitBttn = new System.Windows.Forms.Button();
            this.LogoutBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CurseTabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartTabel)).BeginInit();
            this.SuspendLayout();
            // 
            // CurseTabel
            // 
            this.CurseTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurseTabel.Location = new System.Drawing.Point(66, 31);
            this.CurseTabel.Name = "CurseTabel";
            this.CurseTabel.Size = new System.Drawing.Size(350, 175);
            this.CurseTabel.TabIndex = 0;
            // 
            // PartTabel
            // 
            this.PartTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartTabel.Location = new System.Drawing.Point(66, 273);
            this.PartTabel.Name = "PartTabel";
            this.PartTabel.Size = new System.Drawing.Size(350, 165);
            this.PartTabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inscriere Noi Participanti";
            // 
            // NumePart
            // 
            this.NumePart.AutoSize = true;
            this.NumePart.Location = new System.Drawing.Point(514, 100);
            this.NumePart.Name = "NumePart";
            this.NumePart.Size = new System.Drawing.Size(88, 13);
            this.NumePart.TabIndex = 3;
            this.NumePart.Text = "Nume Participant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nume Echipa";
            // 
            // NumePartTxt
            // 
            this.NumePartTxt.Location = new System.Drawing.Point(608, 97);
            this.NumePartTxt.Name = "NumePartTxt";
            this.NumePartTxt.Size = new System.Drawing.Size(137, 20);
            this.NumePartTxt.TabIndex = 5;
            // 
            // NumeEchipaTxt
            // 
            this.NumeEchipaTxt.Location = new System.Drawing.Point(608, 140);
            this.NumeEchipaTxt.Name = "NumeEchipaTxt";
            this.NumeEchipaTxt.Size = new System.Drawing.Size(137, 20);
            this.NumeEchipaTxt.TabIndex = 6;
            // 
            // CapacitateBox
            // 
            this.CapacitateBox.FormattingEnabled = true;
            this.CapacitateBox.Location = new System.Drawing.Point(608, 185);
            this.CapacitateBox.Name = "CapacitateBox";
            this.CapacitateBox.Size = new System.Drawing.Size(137, 21);
            this.CapacitateBox.TabIndex = 7;
            // 
            // SubmitBttn
            // 
            this.SubmitBttn.Location = new System.Drawing.Point(608, 233);
            this.SubmitBttn.Name = "SubmitBttn";
            this.SubmitBttn.Size = new System.Drawing.Size(137, 40);
            this.SubmitBttn.TabIndex = 8;
            this.SubmitBttn.Text = "Submit";
            this.SubmitBttn.UseVisualStyleBackColor = true;
            this.SubmitBttn.Click += new System.EventHandler(this.handleSubmit);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(66, 247);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(159, 20);
            this.SearchTextBox.TabIndex = 9;
            // 
            // ClearSearchBttn
            // 
            this.ClearSearchBttn.Location = new System.Drawing.Point(250, 233);
            this.ClearSearchBttn.Name = "ClearSearchBttn";
            this.ClearSearchBttn.Size = new System.Drawing.Size(75, 34);
            this.ClearSearchBttn.TabIndex = 10;
            this.ClearSearchBttn.Text = "Clear";
            this.ClearSearchBttn.UseVisualStyleBackColor = true;
            this.ClearSearchBttn.Click += new System.EventHandler(this.handleClear_Search);
            // 
            // SearchBttn
            // 
            this.SearchBttn.Location = new System.Drawing.Point(341, 233);
            this.SearchBttn.Name = "SearchBttn";
            this.SearchBttn.Size = new System.Drawing.Size(75, 34);
            this.SearchBttn.TabIndex = 11;
            this.SearchBttn.Text = "Search";
            this.SearchBttn.UseVisualStyleBackColor = true;
            this.SearchBttn.Click += new System.EventHandler(this.handleSearch);
            // 
            // Team
            // 
            this.Team.AutoSize = true;
            this.Team.Location = new System.Drawing.Point(63, 222);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(74, 13);
            this.Team.TabIndex = 12;
            this.Team.Text = "Nume Echipa:";
            // 
            // ClearSubmitBttn
            // 
            this.ClearSubmitBttn.Location = new System.Drawing.Point(608, 296);
            this.ClearSubmitBttn.Name = "ClearSubmitBttn";
            this.ClearSubmitBttn.Size = new System.Drawing.Size(137, 40);
            this.ClearSubmitBttn.TabIndex = 13;
            this.ClearSubmitBttn.Text = "Clear";
            this.ClearSubmitBttn.UseVisualStyleBackColor = true;
            this.ClearSubmitBttn.Click += new System.EventHandler(this.ClearInscText);
            // 
            // LogoutBttn
            // 
            this.LogoutBttn.Location = new System.Drawing.Point(608, 381);
            this.LogoutBttn.Name = "LogoutBttn";
            this.LogoutBttn.Size = new System.Drawing.Size(137, 27);
            this.LogoutBttn.TabIndex = 14;
            this.LogoutBttn.Text = "Logout";
            this.LogoutBttn.UseVisualStyleBackColor = true;
            this.LogoutBttn.Click += new System.EventHandler(this.LogoutBttnClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutBttn);
            this.Controls.Add(this.ClearSubmitBttn);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.SearchBttn);
            this.Controls.Add(this.ClearSearchBttn);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SubmitBttn);
            this.Controls.Add(this.CapacitateBox);
            this.Controls.Add(this.NumeEchipaTxt);
            this.Controls.Add(this.NumePartTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumePart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartTabel);
            this.Controls.Add(this.CurseTabel);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.CurseTabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartTabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CurseTabel;
        private System.Windows.Forms.DataGridView PartTabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumePart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumePartTxt;
        private System.Windows.Forms.TextBox NumeEchipaTxt;
        private System.Windows.Forms.ComboBox CapacitateBox;
        private System.Windows.Forms.Button SubmitBttn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button ClearSearchBttn;
        private System.Windows.Forms.Button SearchBttn;
        private System.Windows.Forms.Label Team;
        private System.Windows.Forms.Button ClearSubmitBttn;
        private System.Windows.Forms.Button LogoutBttn;
    }
}