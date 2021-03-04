
namespace BackendDeveloperApplyProject
{
    partial class Form4
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
            this.buttonguncelle = new System.Windows.Forms.Button();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonlistele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonguncelle
            // 
            this.buttonguncelle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonguncelle.FlatAppearance.BorderSize = 0;
            this.buttonguncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonguncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonguncelle.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguncelle.ForeColor = System.Drawing.Color.White;
            this.buttonguncelle.Location = new System.Drawing.Point(462, 203);
            this.buttonguncelle.Name = "buttonguncelle";
            this.buttonguncelle.Size = new System.Drawing.Size(164, 64);
            this.buttonguncelle.TabIndex = 15;
            this.buttonguncelle.Text = "Task Güncelle ve sil";
            this.buttonguncelle.UseVisualStyleBackColor = false;
            this.buttonguncelle.Click += new System.EventHandler(this.buttonguncelle_Click);
            // 
            // buttonekle
            // 
            this.buttonekle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonekle.FlatAppearance.BorderSize = 0;
            this.buttonekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonekle.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonekle.ForeColor = System.Drawing.Color.White;
            this.buttonekle.Location = new System.Drawing.Point(174, 203);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(164, 64);
            this.buttonekle.TabIndex = 14;
            this.buttonekle.Text = "Task Ekle";
            this.buttonekle.UseVisualStyleBackColor = false;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttonlistele
            // 
            this.buttonlistele.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonlistele.FlatAppearance.BorderSize = 0;
            this.buttonlistele.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonlistele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonlistele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlistele.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlistele.ForeColor = System.Drawing.Color.White;
            this.buttonlistele.Location = new System.Drawing.Point(283, 63);
            this.buttonlistele.Name = "buttonlistele";
            this.buttonlistele.Size = new System.Drawing.Size(164, 64);
            this.buttonlistele.TabIndex = 16;
            this.buttonlistele.Text = "Task Listele";
            this.buttonlistele.UseVisualStyleBackColor = false;
            this.buttonlistele.Click += new System.EventHandler(this.buttonlistele_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonlistele);
            this.Controls.Add(this.buttonguncelle);
            this.Controls.Add(this.buttonekle);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonguncelle;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttonlistele;
    }
}