namespace PharamaciaPerfumes.UI
{
    partial class EmployeesUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Axure Handwriting", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.Location = new System.Drawing.Point(635, 16);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(289, 31);
            this.lblLogo.TabIndex = 6;
            this.lblLogo.Text = "PharamaciaPerfumes";
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCustomer.Font = new System.Drawing.Font("Broadway", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCustomer.Location = new System.Drawing.Point(513, 300);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(185, 149);
            this.btnCustomer.TabIndex = 7;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Cyan;
            this.btnOrders.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnOrders.Location = new System.Drawing.Point(852, 300);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(179, 149);
            this.btnOrders.TabIndex = 8;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // EmployeesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharamaciaPerfumes.UI.Properties.Resources.Best_perfume_for_women_2020;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.lblLogo);
            this.Name = "EmployeesUC";
            this.Size = new System.Drawing.Size(1605, 661);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLogo;
        private Button btnCustomer;
        private Button btnOrders;
    }
}
