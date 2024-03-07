namespace kutuphaneProjesi
{
    partial class emanetler
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_emanet = new System.Windows.Forms.Button();
            this.btn_teslim = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Crimson;
            this.flowLayoutPanel1.Controls.Add(this.btn_emanet);
            this.flowLayoutPanel1.Controls.Add(this.btn_teslim);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(431, 110);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // btn_emanet
            // 
            this.btn_emanet.BackColor = System.Drawing.Color.Orange;
            this.btn_emanet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emanet.Font = new System.Drawing.Font("MV Boli", 19.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_emanet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_emanet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_emanet.Location = new System.Drawing.Point(3, 3);
            this.btn_emanet.Name = "btn_emanet";
            this.btn_emanet.Size = new System.Drawing.Size(208, 102);
            this.btn_emanet.TabIndex = 4;
            this.btn_emanet.Text = "Emanet Ver";
            this.btn_emanet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_emanet.UseVisualStyleBackColor = false;
            this.btn_emanet.Click += new System.EventHandler(this.btn_emanet_Click);
            // 
            // btn_teslim
            // 
            this.btn_teslim.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_teslim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teslim.Font = new System.Drawing.Font("MV Boli", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_teslim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_teslim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teslim.Location = new System.Drawing.Point(217, 3);
            this.btn_teslim.Name = "btn_teslim";
            this.btn_teslim.Size = new System.Drawing.Size(208, 102);
            this.btn_teslim.TabIndex = 6;
            this.btn_teslim.Text = "Teslim Al";
            this.btn_teslim.UseVisualStyleBackColor = false;
            this.btn_teslim.Click += new System.EventHandler(this.btn_teslim_Click);
            // 
            // emanetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(450, 135);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "emanetler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emanetler";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_emanet;
        private System.Windows.Forms.Button btn_teslim;
    }
}