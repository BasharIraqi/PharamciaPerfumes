namespace PharamaciaPerfumes.UI
{
    partial class OrderUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderUC));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtAddProduct = new System.Windows.Forms.TextBox();
            this.lbAdd = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtOrderDId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdatePanel = new System.Windows.Forms.Panel();
            this.dgvUpdate = new System.Windows.Forms.DataGridView();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lbUpdate = new System.Windows.Forms.ListBox();
            this.txtOrderUId = new System.Windows.Forms.TextBox();
            this.btnUShow = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            this.UpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).BeginInit();
            this.ShowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderToolStripMenuItem,
            this.deleteOrderToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.showOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.addOrderToolStripMenuItem.Text = "Add Order";
            this.addOrderToolStripMenuItem.Click += new System.EventHandler(this.addOrderToolStripMenuItem_Click);
            // 
            // deleteOrderToolStripMenuItem
            // 
            this.deleteOrderToolStripMenuItem.Name = "deleteOrderToolStripMenuItem";
            this.deleteOrderToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.deleteOrderToolStripMenuItem.Text = "Delete Order";
            this.deleteOrderToolStripMenuItem.Click += new System.EventHandler(this.deleteOrderToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.updateToolStripMenuItem.Text = " Update Order";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // showOrderToolStripMenuItem
            // 
            this.showOrderToolStripMenuItem.Name = "showOrderToolStripMenuItem";
            this.showOrderToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.showOrderToolStripMenuItem.Text = "Show Order";
            this.showOrderToolStripMenuItem.Click += new System.EventHandler(this.showOrderToolStripMenuItem_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPanel.BackgroundImage")));
            this.AddPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPanel.Controls.Add(this.btnOrder);
            this.AddPanel.Controls.Add(this.txtAddProduct);
            this.AddPanel.Controls.Add(this.lbAdd);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Controls.Add(this.btnAdd);
            this.AddPanel.Location = new System.Drawing.Point(13, 81);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(357, 522);
            this.AddPanel.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(137, 453);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Add Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txtAddProduct
            // 
            this.txtAddProduct.Location = new System.Drawing.Point(137, 357);
            this.txtAddProduct.Name = "txtAddProduct";
            this.txtAddProduct.Size = new System.Drawing.Size(100, 23);
            this.txtAddProduct.TabIndex = 10;
            this.txtAddProduct.Text = "Product Id";
            this.txtAddProduct.Click += new System.EventHandler(this.txtAddProduct_Click);
            // 
            // lbAdd
            // 
            this.lbAdd.FormattingEnabled = true;
            this.lbAdd.ItemHeight = 15;
            this.lbAdd.Location = new System.Drawing.Point(21, 108);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(322, 229);
            this.lbAdd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Axure Handwriting", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "PharamaciaPerfumes";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(252, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DeletePanel
            // 
            this.DeletePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeletePanel.BackgroundImage")));
            this.DeletePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeletePanel.Controls.Add(this.btnDelete);
            this.DeletePanel.Controls.Add(this.txtOrderDId);
            this.DeletePanel.Controls.Add(this.label2);
            this.DeletePanel.Location = new System.Drawing.Point(376, 81);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(362, 522);
            this.DeletePanel.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(156, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtOrderDId
            // 
            this.txtOrderDId.Location = new System.Drawing.Point(131, 198);
            this.txtOrderDId.Name = "txtOrderDId";
            this.txtOrderDId.Size = new System.Drawing.Size(100, 23);
            this.txtOrderDId.TabIndex = 7;
            this.txtOrderDId.Text = "Order Id";
            this.txtOrderDId.Click += new System.EventHandler(this.txtOrderDId_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Axure Handwriting", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "PharamaciaPerfumes";
            // 
            // UpdatePanel
            // 
            this.UpdatePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdatePanel.BackgroundImage")));
            this.UpdatePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdatePanel.Controls.Add(this.dgvUpdate);
            this.UpdatePanel.Controls.Add(this.txtUpdate);
            this.UpdatePanel.Controls.Add(this.btnRemoveOrder);
            this.UpdatePanel.Controls.Add(this.btnAddOrder);
            this.UpdatePanel.Controls.Add(this.lbUpdate);
            this.UpdatePanel.Controls.Add(this.txtOrderUId);
            this.UpdatePanel.Controls.Add(this.btnUShow);
            this.UpdatePanel.Controls.Add(this.btnUpdate);
            this.UpdatePanel.Controls.Add(this.label3);
            this.UpdatePanel.Location = new System.Drawing.Point(744, 81);
            this.UpdatePanel.Name = "UpdatePanel";
            this.UpdatePanel.Size = new System.Drawing.Size(374, 522);
            this.UpdatePanel.TabIndex = 3;
            // 
            // dgvUpdate
            // 
            this.dgvUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdate.Location = new System.Drawing.Point(131, 135);
            this.dgvUpdate.Name = "dgvUpdate";
            this.dgvUpdate.RowTemplate.Height = 25;
            this.dgvUpdate.Size = new System.Drawing.Size(240, 150);
            this.dgvUpdate.TabIndex = 18;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(128, 357);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(100, 23);
            this.txtUpdate.TabIndex = 17;
            this.txtUpdate.Text = "Product Id";
            this.txtUpdate.Click += new System.EventHandler(this.txtUpdate_Click);
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.Location = new System.Drawing.Point(70, 386);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveOrder.TabIndex = 16;
            this.btnRemoveOrder.Text = "Remove";
            this.btnRemoveOrder.UseVisualStyleBackColor = true;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(192, 386);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 15;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lbUpdate
            // 
            this.lbUpdate.FormattingEnabled = true;
            this.lbUpdate.ItemHeight = 15;
            this.lbUpdate.Location = new System.Drawing.Point(3, 106);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(350, 229);
            this.lbUpdate.TabIndex = 14;
            // 
            // txtOrderUId
            // 
            this.txtOrderUId.Location = new System.Drawing.Point(70, 77);
            this.txtOrderUId.Name = "txtOrderUId";
            this.txtOrderUId.Size = new System.Drawing.Size(100, 23);
            this.txtOrderUId.TabIndex = 13;
            this.txtOrderUId.Text = "Order Id";
            this.txtOrderUId.Click += new System.EventHandler(this.txtOrderUId_Click);
            // 
            // btnUShow
            // 
            this.btnUShow.Location = new System.Drawing.Point(192, 77);
            this.btnUShow.Name = "btnUShow";
            this.btnUShow.Size = new System.Drawing.Size(75, 23);
            this.btnUShow.TabIndex = 12;
            this.btnUShow.Text = "Show";
            this.btnUShow.UseVisualStyleBackColor = true;
            this.btnUShow.Click += new System.EventHandler(this.btnUShow_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 426);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Axure Handwriting", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "PharamaciaPerfumes";
            // 
            // ShowPanel
            // 
            this.ShowPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPanel.BackgroundImage")));
            this.ShowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPanel.Controls.Add(this.dgvShow);
            this.ShowPanel.Controls.Add(this.btnShow);
            this.ShowPanel.Controls.Add(this.txtOrderId);
            this.ShowPanel.Controls.Add(this.label4);
            this.ShowPanel.Location = new System.Drawing.Point(1124, 81);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(390, 522);
            this.ShowPanel.TabIndex = 4;
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(94, 183);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 25;
            this.dgvShow.Size = new System.Drawing.Size(240, 150);
            this.dgvShow.TabIndex = 16;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(259, 134);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(118, 135);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(100, 23);
            this.txtOrderId.TabIndex = 14;
            this.txtOrderId.Text = "Order Id";
            this.txtOrderId.Click += new System.EventHandler(this.txtOrderId_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Axure Handwriting", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "PharamaciaPerfumes";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Axure Handwriting", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.Location = new System.Drawing.Point(634, 36);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(289, 31);
            this.lblLogo.TabIndex = 5;
            this.lblLogo.Text = "PharamaciaPerfumes";
            // 
            // OrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.ShowPanel);
            this.Controls.Add(this.UpdatePanel);
            this.Controls.Add(this.DeletePanel);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "OrderUC";
            this.Size = new System.Drawing.Size(1533, 648);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            this.UpdatePanel.ResumeLayout(false);
            this.UpdatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).EndInit();
            this.ShowPanel.ResumeLayout(false);
            this.ShowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addOrderToolStripMenuItem;
        private ToolStripMenuItem deleteOrderToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem showOrderToolStripMenuItem;
        private Panel AddPanel;
        private Panel DeletePanel;
        private Panel UpdatePanel;
        private Panel ShowPanel;
        private Label lblLogo;
        private Label label1;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtOrderDId;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOrderUId;
        private Button btnUShow;
        private Button btnUpdate;
        private DataGridView dgvShow;
        private Button btnShow;
        private TextBox txtOrderId;
        private Button btnOrder;
        private TextBox txtAddProduct;
        private ListBox lbAdd;
        private ListBox lbUpdate;
        private TextBox txtUpdate;
        private Button btnRemoveOrder;
        private Button btnAddOrder;
        private DataGridView dgvUpdate;
    }
}
