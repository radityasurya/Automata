namespace Automata
{
    partial class AutomataUI
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbBrowse = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.pbDiagram = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lbFinite = new System.Windows.Forms.Label();
            this.lbWords = new System.Windows.Forms.Label();
            this.lbDFA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCheck = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbBrowse
            // 
            this.tbBrowse.Location = new System.Drawing.Point(15, 33);
            this.tbBrowse.Name = "tbBrowse";
            this.tbBrowse.Size = new System.Drawing.Size(253, 20);
            this.tbBrowse.TabIndex = 0;
            this.tbBrowse.Tag = "";
            this.tbBrowse.Text = "finite.txt";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(274, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(74, 25);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Finite File";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(15, 59);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(91, 50);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "read NDFA";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // pbDiagram
            // 
            this.pbDiagram.Location = new System.Drawing.Point(12, 167);
            this.pbDiagram.Name = "pbDiagram";
            this.pbDiagram.Size = new System.Drawing.Size(647, 273);
            this.pbDiagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDiagram.TabIndex = 4;
            this.pbDiagram.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 115);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(337, 46);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Diagram";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbFinite
            // 
            this.lbFinite.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbFinite.Location = new System.Drawing.Point(112, 59);
            this.lbFinite.Name = "lbFinite";
            this.lbFinite.Size = new System.Drawing.Size(75, 50);
            this.lbFinite.TabIndex = 6;
            this.lbFinite.Text = "Finite";
            this.lbFinite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWords
            // 
            this.lbWords.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbWords.Location = new System.Drawing.Point(274, 59);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(75, 50);
            this.lbWords.TabIndex = 7;
            this.lbWords.Text = "Words";
            this.lbWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDFA
            // 
            this.lbDFA.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbDFA.Location = new System.Drawing.Point(193, 59);
            this.lbDFA.Name = "lbDFA";
            this.lbDFA.Size = new System.Drawing.Size(75, 50);
            this.lbDFA.TabIndex = 8;
            this.lbDFA.Text = "DFA";
            this.lbDFA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Check String";
            // 
            // tbCheck
            // 
            this.tbCheck.Location = new System.Drawing.Point(378, 33);
            this.tbCheck.Name = "tbCheck";
            this.tbCheck.Size = new System.Drawing.Size(208, 20);
            this.tbCheck.TabIndex = 9;
            this.tbCheck.Tag = "";
            this.tbCheck.Text = "aaaa";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(592, 30);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(74, 25);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // AutomataUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 445);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCheck);
            this.Controls.Add(this.lbDFA);
            this.Controls.Add(this.lbWords);
            this.Controls.Add(this.lbFinite);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pbDiagram);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbBrowse);
            this.Name = "AutomataUI";
            this.Text = "Automata";
            ((System.ComponentModel.ISupportInitialize)(this.pbDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbBrowse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.PictureBox pbDiagram;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lbFinite;
        private System.Windows.Forms.Label lbWords;
        private System.Windows.Forms.Label lbDFA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCheck;
        private System.Windows.Forms.Button btnCheck;
    }
}

