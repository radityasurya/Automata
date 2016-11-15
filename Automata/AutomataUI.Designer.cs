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
            this.tbBrowse.Size = new System.Drawing.Size(194, 20);
            this.tbBrowse.TabIndex = 0;
            this.tbBrowse.Tag = "";
            this.tbBrowse.Text = "finite.txt";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(215, 30);
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
            this.btnRead.Location = new System.Drawing.Point(12, 59);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 46);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "read NDFA";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // pbDiagram
            // 
            this.pbDiagram.Location = new System.Drawing.Point(12, 224);
            this.pbDiagram.Name = "pbDiagram";
            this.pbDiagram.Size = new System.Drawing.Size(647, 273);
            this.pbDiagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDiagram.TabIndex = 4;
            this.pbDiagram.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(15, 111);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(274, 46);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Diagram";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // AutomataUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 509);
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
    }
}

