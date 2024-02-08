namespace arbol2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnpre = new System.Windows.Forms.Button();
            this.btnag = new System.Windows.Forms.Button();
            this.btnpos = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.lsarbol = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnpre
            // 
            this.btnpre.BackColor = System.Drawing.Color.Olive;
            this.btnpre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpre.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnpre.ForeColor = System.Drawing.Color.Black;
            this.btnpre.Location = new System.Drawing.Point(12, 101);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(168, 63);
            this.btnpre.TabIndex = 0;
            this.btnpre.Text = "preorden";
            this.btnpre.UseVisualStyleBackColor = false;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnag
            // 
            this.btnag.BackColor = System.Drawing.Color.Olive;
            this.btnag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnag.Location = new System.Drawing.Point(334, 361);
            this.btnag.Name = "btnag";
            this.btnag.Size = new System.Drawing.Size(112, 34);
            this.btnag.TabIndex = 1;
            this.btnag.Text = "agregar";
            this.btnag.UseVisualStyleBackColor = false;
            this.btnag.Click += new System.EventHandler(this.btnag_Click);
            // 
            // btnpos
            // 
            this.btnpos.BackColor = System.Drawing.Color.Olive;
            this.btnpos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpos.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnpos.Location = new System.Drawing.Point(12, 300);
            this.btnpos.Name = "btnpos";
            this.btnpos.Size = new System.Drawing.Size(168, 57);
            this.btnpos.TabIndex = 2;
            this.btnpos.Text = "posole";
            this.btnpos.UseVisualStyleBackColor = false;
            this.btnpos.Click += new System.EventHandler(this.btnpos_Click);
            // 
            // btnin
            // 
            this.btnin.BackColor = System.Drawing.Color.Olive;
            this.btnin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnin.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnin.Location = new System.Drawing.Point(12, 194);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(168, 62);
            this.btnin.TabIndex = 3;
            this.btnin.Text = "medio";
            this.btnin.UseVisualStyleBackColor = false;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // lsarbol
            // 
            this.lsarbol.FormattingEnabled = true;
            this.lsarbol.ItemHeight = 25;
            this.lsarbol.Location = new System.Drawing.Point(296, 122);
            this.lsarbol.Name = "lsarbol";
            this.lsarbol.Size = new System.Drawing.Size(180, 204);
            this.lsarbol.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arboles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsarbol);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnpos);
            this.Controls.Add(this.btnag);
            this.Controls.Add(this.btnpre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnpre;
        private Button btnag;
        private Button btnpos;
        private Button btnin;
        private ListBox lsarbol;
        private Label label1;
    }
}