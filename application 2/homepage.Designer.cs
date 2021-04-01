namespace application_2
{
    partial class homepage
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxMiximize = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnAddNewItems = new System.Windows.Forms.Button();
            this.btnQuotation = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnUpdateStock);
            this.panelMenu.Controls.Add(this.btnAddNewItems);
            this.panelMenu.Controls.Add(this.btnQuotation);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 490);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 39);
            this.panelLogo.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 39);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(599, 451);
            this.panelDesktop.TabIndex = 2;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.pictureBoxMinimize);
            this.panelTitleBar.Controls.Add(this.pictureBoxMiximize);
            this.panelTitleBar.Controls.Add(this.pictureBoxClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(599, 39);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::application_2.Properties.Resources.Untitled_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimize.Image = global::application_2.Properties.Resources.icons8_filled_circle_16px_1;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(549, 10);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 6;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // pictureBoxMiximize
            // 
            this.pictureBoxMiximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMiximize.Image = global::application_2.Properties.Resources.icons8_filled_circle_16px;
            this.pictureBoxMiximize.Location = new System.Drawing.Point(525, 10);
            this.pictureBoxMiximize.Name = "pictureBoxMiximize";
            this.pictureBoxMiximize.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxMiximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMiximize.TabIndex = 5;
            this.pictureBoxMiximize.TabStop = false;
            this.pictureBoxMiximize.Click += new System.EventHandler(this.pictureBoxMiximize_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::application_2.Properties.Resources.icons8_filled_circle_16px_2;
            this.pictureBoxClose.Location = new System.Drawing.Point(573, 10);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 4;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.Image = global::application_2.Properties.Resources.icons8_installing_updates_24px;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 279);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "    Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateStock.FlatAppearance.BorderSize = 0;
            this.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStock.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateStock.Image = global::application_2.Properties.Resources.icons8_refresh_shield_24px;
            this.btnUpdateStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStock.Location = new System.Drawing.Point(0, 219);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnUpdateStock.Size = new System.Drawing.Size(220, 60);
            this.btnUpdateStock.TabIndex = 4;
            this.btnUpdateStock.Text = "    Update Stocks";
            this.btnUpdateStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStokes_Click);
            // 
            // btnAddNewItems
            // 
            this.btnAddNewItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewItems.FlatAppearance.BorderSize = 0;
            this.btnAddNewItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewItems.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewItems.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewItems.Image = global::application_2.Properties.Resources.icons8_new_job_24px;
            this.btnAddNewItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewItems.Location = new System.Drawing.Point(0, 159);
            this.btnAddNewItems.Name = "btnAddNewItems";
            this.btnAddNewItems.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnAddNewItems.Size = new System.Drawing.Size(220, 60);
            this.btnAddNewItems.TabIndex = 3;
            this.btnAddNewItems.Text = "    Add New Items";
            this.btnAddNewItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewItems.UseVisualStyleBackColor = true;
            this.btnAddNewItems.Click += new System.EventHandler(this.btnAddNewItems_Click);
            // 
            // btnQuotation
            // 
            this.btnQuotation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuotation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuotation.FlatAppearance.BorderSize = 0;
            this.btnQuotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuotation.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuotation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuotation.Image = global::application_2.Properties.Resources.icons8_new_copy_24px;
            this.btnQuotation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuotation.Location = new System.Drawing.Point(0, 99);
            this.btnQuotation.Name = "btnQuotation";
            this.btnQuotation.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnQuotation.Size = new System.Drawing.Size(220, 60);
            this.btnQuotation.TabIndex = 2;
            this.btnQuotation.Text = "    Quotation";
            this.btnQuotation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuotation.UseVisualStyleBackColor = true;
            this.btnQuotation.Click += new System.EventHandler(this.btnQuotation_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.Image = global::application_2.Properties.Resources.icons8_shopping_cart_32px;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 39);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(220, 60);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "   Products";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 490);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(835, 529);
            this.Name = "homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homepage";
            this.Load += new System.EventHandler(this.homepage_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnAddNewItems;
        private System.Windows.Forms.Button btnQuotation;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxMiximize;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}