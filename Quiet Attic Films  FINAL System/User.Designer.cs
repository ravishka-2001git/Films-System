
namespace Quiet_Attic_Films__FINAL_System
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.PictureBox();
            this.btnU_production = new System.Windows.Forms.Button();
            this.btnU_CR = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.btnU_production);
            this.panel1.Controls.Add(this.btnU_CR);
            this.panel1.Location = new System.Drawing.Point(12, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 566);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(217, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 753);
            this.panel2.TabIndex = 1;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(-2, 24);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(122, 60);
            this.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Back.TabIndex = 96;
            this.btn_Back.TabStop = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btnU_production
            // 
            this.btnU_production.BackColor = System.Drawing.Color.Transparent;
            this.btnU_production.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnU_production.BackgroundImage")));
            this.btnU_production.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnU_production.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnU_production.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnU_production.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU_production.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnU_production.Location = new System.Drawing.Point(14, 202);
            this.btnU_production.Name = "btnU_production";
            this.btnU_production.Size = new System.Drawing.Size(173, 124);
            this.btnU_production.TabIndex = 12;
            this.btnU_production.Text = "Production";
            this.btnU_production.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnU_production.UseVisualStyleBackColor = false;
            this.btnU_production.Click += new System.EventHandler(this.btnU_production_Click);
            // 
            // btnU_CR
            // 
            this.btnU_CR.BackColor = System.Drawing.Color.Transparent;
            this.btnU_CR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnU_CR.BackgroundImage")));
            this.btnU_CR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnU_CR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnU_CR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnU_CR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU_CR.ForeColor = System.Drawing.Color.Silver;
            this.btnU_CR.Location = new System.Drawing.Point(0, 14);
            this.btnU_CR.Name = "btnU_CR";
            this.btnU_CR.Size = new System.Drawing.Size(199, 125);
            this.btnU_CR.TabIndex = 11;
            this.btnU_CR.Text = "Client Registration";
            this.btnU_CR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnU_CR.UseVisualStyleBackColor = false;
            this.btnU_CR.Click += new System.EventHandler(this.btnU_CR_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayment.BackgroundImage")));
            this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnPayment.Location = new System.Drawing.Point(14, 389);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(173, 145);
            this.btnPayment.TabIndex = 14;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "User";
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btn_Back;
        private System.Windows.Forms.Button btnU_production;
        private System.Windows.Forms.Button btnU_CR;
        private System.Windows.Forms.Button btnPayment;
    }
}