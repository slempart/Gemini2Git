namespace Gemini2Git.UI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtGemini = new System.Windows.Forms.TextBox();
            this.dgvGit = new System.Windows.Forms.DataGridView();
            this.btnAktualisieren = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timStatus = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGemini
            // 
            this.txtGemini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGemini.Location = new System.Drawing.Point(13, 24);
            this.txtGemini.Name = "txtGemini";
            this.txtGemini.Size = new System.Drawing.Size(562, 26);
            this.txtGemini.TabIndex = 0;
            // 
            // dgvGit
            // 
            this.dgvGit.AllowUserToAddRows = false;
            this.dgvGit.AllowUserToDeleteRows = false;
            this.dgvGit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGit.Location = new System.Drawing.Point(13, 77);
            this.dgvGit.Name = "dgvGit";
            this.dgvGit.ReadOnly = true;
            this.dgvGit.Size = new System.Drawing.Size(562, 150);
            this.dgvGit.TabIndex = 1;
            this.dgvGit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGit_CellClick);
            // 
            // btnAktualisieren
            // 
            this.btnAktualisieren.Location = new System.Drawing.Point(13, 48);
            this.btnAktualisieren.Name = "btnAktualisieren";
            this.btnAktualisieren.Size = new System.Drawing.Size(75, 23);
            this.btnAktualisieren.TabIndex = 2;
            this.btnAktualisieren.Text = "Aktualisieren";
            this.btnAktualisieren.UseVisualStyleBackColor = true;
            this.btnAktualisieren.Click += new System.EventHandler(this.btnAktualisieren_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(19, 234);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 3;
            // 
            // timStatus
            // 
            this.timStatus.Interval = 500;
            this.timStatus.Tick += new System.EventHandler(this.timStatus_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 261);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAktualisieren);
            this.Controls.Add(this.dgvGit);
            this.Controls.Add(this.txtGemini);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGemini;
        private System.Windows.Forms.DataGridView dgvGit;
        private System.Windows.Forms.Button btnAktualisieren;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timStatus;
    }
}

