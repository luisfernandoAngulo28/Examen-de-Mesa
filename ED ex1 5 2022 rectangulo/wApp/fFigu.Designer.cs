namespace wApp
{
    partial class fFigu
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
            this.cmdMovDown = new System.Windows.Forms.Button();
            this.cmdMovUp = new System.Windows.Forms.Button();
            this.cmdMovDer = new System.Windows.Forms.Button();
            this.cmdMovIzq = new System.Windows.Forms.Button();
            this.cmdViewSA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdAtoSA = new System.Windows.Forms.Button();
            this.cmdViewA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFSA = new System.Windows.Forms.Label();
            this.cmdFigura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdMovDown
            // 
            this.cmdMovDown.Location = new System.Drawing.Point(660, 335);
            this.cmdMovDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdMovDown.Name = "cmdMovDown";
            this.cmdMovDown.Size = new System.Drawing.Size(85, 23);
            this.cmdMovDown.TabIndex = 17;
            this.cmdMovDown.Text = "MovDown";
            this.cmdMovDown.UseVisualStyleBackColor = true;
            this.cmdMovDown.Click += new System.EventHandler(this.cmdMovDown_Click_1);
            // 
            // cmdMovUp
            // 
            this.cmdMovUp.Location = new System.Drawing.Point(588, 335);
            this.cmdMovUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdMovUp.Name = "cmdMovUp";
            this.cmdMovUp.Size = new System.Drawing.Size(67, 23);
            this.cmdMovUp.TabIndex = 16;
            this.cmdMovUp.Text = "MovUp";
            this.cmdMovUp.UseVisualStyleBackColor = true;
            this.cmdMovUp.Click += new System.EventHandler(this.cmdMovUp_Click_1);
            // 
            // cmdMovDer
            // 
            this.cmdMovDer.Location = new System.Drawing.Point(511, 335);
            this.cmdMovDer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdMovDer.Name = "cmdMovDer";
            this.cmdMovDer.Size = new System.Drawing.Size(72, 23);
            this.cmdMovDer.TabIndex = 15;
            this.cmdMovDer.Text = "MovDer";
            this.cmdMovDer.UseVisualStyleBackColor = true;
            this.cmdMovDer.Click += new System.EventHandler(this.cmdMovDer_Click_1);
            // 
            // cmdMovIzq
            // 
            this.cmdMovIzq.Location = new System.Drawing.Point(439, 335);
            this.cmdMovIzq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdMovIzq.Name = "cmdMovIzq";
            this.cmdMovIzq.Size = new System.Drawing.Size(67, 23);
            this.cmdMovIzq.TabIndex = 14;
            this.cmdMovIzq.Text = "MovIzq";
            this.cmdMovIzq.UseVisualStyleBackColor = true;
            this.cmdMovIzq.Click += new System.EventHandler(this.cmdMovIzq_Click_1);
            // 
            // cmdViewSA
            // 
            this.cmdViewSA.Location = new System.Drawing.Point(333, 14);
            this.cmdViewSA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdViewSA.Name = "cmdViewSA";
            this.cmdViewSA.Size = new System.Drawing.Size(97, 23);
            this.cmdViewSA.TabIndex = 13;
            this.cmdViewSA.Text = "Dibujar  S";
            this.cmdViewSA.UseVisualStyleBackColor = true;
            this.cmdViewSA.Click += new System.EventHandler(this.cmdViewSA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "...";
            // 
            // cmdAtoSA
            // 
            this.cmdAtoSA.Location = new System.Drawing.Point(219, 14);
            this.cmdAtoSA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdAtoSA.Name = "cmdAtoSA";
            this.cmdAtoSA.Size = new System.Drawing.Size(108, 23);
            this.cmdAtoSA.TabIndex = 11;
            this.cmdAtoSA.Text = "Pasar A to S";
            this.cmdAtoSA.UseVisualStyleBackColor = true;
            this.cmdAtoSA.Click += new System.EventHandler(this.cmdAtoSA_Click);
            // 
            // cmdViewA
            // 
            this.cmdViewA.Location = new System.Drawing.Point(21, 14);
            this.cmdViewA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdViewA.Name = "cmdViewA";
            this.cmdViewA.Size = new System.Drawing.Size(192, 23);
            this.cmdViewA.TabIndex = 10;
            this.cmdViewA.Text = "Dibujar Figura desde A";
            this.cmdViewA.UseVisualStyleBackColor = true;
            this.cmdViewA.Click += new System.EventHandler(this.cmdViewA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "...";
            // 
            // lblFSA
            // 
            this.lblFSA.AutoSize = true;
            this.lblFSA.Location = new System.Drawing.Point(457, 50);
            this.lblFSA.Name = "lblFSA";
            this.lblFSA.Size = new System.Drawing.Size(20, 17);
            this.lblFSA.TabIndex = 18;
            this.lblFSA.Text = "...";
            // 
            // cmdFigura
            // 
            this.cmdFigura.Location = new System.Drawing.Point(461, 14);
            this.cmdFigura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdFigura.Name = "cmdFigura";
            this.cmdFigura.Size = new System.Drawing.Size(178, 23);
            this.cmdFigura.TabIndex = 19;
            this.cmdFigura.Text = "Dibujar Figura desde S";
            this.cmdFigura.UseVisualStyleBackColor = true;
            this.cmdFigura.Click += new System.EventHandler(this.cmdFigura_Click);
            // 
            // fFigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 434);
            this.Controls.Add(this.cmdFigura);
            this.Controls.Add(this.lblFSA);
            this.Controls.Add(this.cmdMovDown);
            this.Controls.Add(this.cmdMovUp);
            this.Controls.Add(this.cmdMovDer);
            this.Controls.Add(this.cmdMovIzq);
            this.Controls.Add(this.cmdViewSA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdAtoSA);
            this.Controls.Add(this.cmdViewA);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fFigu";
            this.Text = "fFigu";
            this.Load += new System.EventHandler(this.fFigu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdMovDown;
        private System.Windows.Forms.Button cmdMovUp;
        private System.Windows.Forms.Button cmdMovDer;
        private System.Windows.Forms.Button cmdMovIzq;
        private System.Windows.Forms.Button cmdViewSA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdAtoSA;
        private System.Windows.Forms.Button cmdViewA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFSA;
        private System.Windows.Forms.Button cmdFigura;
    }
}