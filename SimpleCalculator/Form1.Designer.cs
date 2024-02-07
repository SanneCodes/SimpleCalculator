namespace SimpleCalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtSvar = new System.Windows.Forms.TextBox();
            this.avslutt = new System.Windows.Forms.Button();
            this.btn_svar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regneartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRegneart = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(464, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Visk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Visk_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(60, 112);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(273, 31);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(60, 274);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(273, 31);
            this.txtNum2.TabIndex = 2;
            // 
            // txtSvar
            // 
            this.txtSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSvar.Location = new System.Drawing.Point(471, 201);
            this.txtSvar.Name = "txtSvar";
            this.txtSvar.Size = new System.Drawing.Size(213, 31);
            this.txtSvar.TabIndex = 3;
            // 
            // avslutt
            // 
            this.avslutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avslutt.Location = new System.Drawing.Point(577, 350);
            this.avslutt.Name = "avslutt";
            this.avslutt.Size = new System.Drawing.Size(107, 40);
            this.avslutt.TabIndex = 4;
            this.avslutt.Text = "Avslutt";
            this.avslutt.UseVisualStyleBackColor = true;
            this.avslutt.Click += new System.EventHandler(this.Avslutt_Click);
            // 
            // btn_svar
            // 
            this.btn_svar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_svar.Location = new System.Drawing.Point(334, 196);
            this.btn_svar.Name = "btn_svar";
            this.btn_svar.Size = new System.Drawing.Size(107, 40);
            this.btn_svar.TabIndex = 5;
            this.btn_svar.Text = "=";
            this.btn_svar.UseVisualStyleBackColor = true;
            this.btn_svar.Click += new System.EventHandler(this.Svar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regneartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regneartToolStripMenuItem
            // 
            this.regneartToolStripMenuItem.Name = "regneartToolStripMenuItem";
            this.regneartToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.regneartToolStripMenuItem.Text = "Regneart";
            this.regneartToolStripMenuItem.Click += new System.EventHandler(this.regneartToolStripMenuItem_Click);
            // 
            // lblRegneart
            // 
            this.lblRegneart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegneart.Location = new System.Drawing.Point(12, 27);
            this.lblRegneart.Name = "lblRegneart";
            this.lblRegneart.Size = new System.Drawing.Size(55, 49);
            this.lblRegneart.TabIndex = 7;
            this.lblRegneart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRegneart);
            this.Controls.Add(this.btn_svar);
            this.Controls.Add(this.avslutt);
            this.Controls.Add(this.txtSvar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtSvar;
        private System.Windows.Forms.Button avslutt;
        private System.Windows.Forms.Button btn_svar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regneartToolStripMenuItem;
        private System.Windows.Forms.TextBox lblRegneart;
    }
}

