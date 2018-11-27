﻿namespace real_estate
{
    partial class FormRS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRS));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSale = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCustomer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employee2 = new real_estate.user_control.Employee();
            this.customer3 = new real_estate.user_control.Customer();
            this.projects1 = new real_estate.user_control.Projects();
            this.products1 = new real_estate.user_control.Products();
            this.customer2 = new real_estate.user_control.Customer();
            this.bill1 = new real_estate.user_control.Bill();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbExit = new System.Windows.Forms.Label();
            this.employee1 = new real_estate.user_control.Employee();
            this.customer1 = new real_estate.user_control.Customer();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSale);
            this.panel2.Controls.Add(this.btnProject);
            this.panel2.Controls.Add(this.btnBill);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Controls.Add(this.btnEmp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 590);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(58, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Real Estate";
            // 
            // btnSale
            // 
            this.btnSale.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSale.BorderRadius = 0;
            this.btnSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSale.ButtonText = "Sales";
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.DisabledColor = System.Drawing.Color.Gray;
            this.btnSale.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSale.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSale.Iconimage")));
            this.btnSale.Iconimage_right = null;
            this.btnSale.Iconimage_right_Selected = null;
            this.btnSale.Iconimage_Selected = null;
            this.btnSale.IconMarginLeft = 0;
            this.btnSale.IconMarginRight = 0;
            this.btnSale.IconRightVisible = true;
            this.btnSale.IconRightZoom = 0D;
            this.btnSale.IconVisible = true;
            this.btnSale.IconZoom = 60D;
            this.btnSale.IsTab = false;
            this.btnSale.Location = new System.Drawing.Point(-3, 444);
            this.btnSale.Name = "btnSale";
            this.btnSale.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSale.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSale.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSale.selected = false;
            this.btnSale.Size = new System.Drawing.Size(206, 48);
            this.btnSale.TabIndex = 6;
            this.btnSale.Text = "Sales";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSale.Textcolor = System.Drawing.Color.White;
            this.btnSale.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnProject
            // 
            this.btnProject.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProject.BorderRadius = 0;
            this.btnProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnProject.ButtonText = "Projects";
            this.btnProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProject.DisabledColor = System.Drawing.Color.Gray;
            this.btnProject.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProject.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProject.Iconimage")));
            this.btnProject.Iconimage_right = null;
            this.btnProject.Iconimage_right_Selected = null;
            this.btnProject.Iconimage_Selected = null;
            this.btnProject.IconMarginLeft = 0;
            this.btnProject.IconMarginRight = 0;
            this.btnProject.IconRightVisible = true;
            this.btnProject.IconRightZoom = 0D;
            this.btnProject.IconVisible = true;
            this.btnProject.IconZoom = 60D;
            this.btnProject.IsTab = false;
            this.btnProject.Location = new System.Drawing.Point(-3, 387);
            this.btnProject.Name = "btnProject";
            this.btnProject.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProject.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnProject.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProject.selected = false;
            this.btnProject.Size = new System.Drawing.Size(209, 59);
            this.btnProject.TabIndex = 5;
            this.btnProject.Text = "Projects";
            this.btnProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProject.Textcolor = System.Drawing.Color.White;
            this.btnProject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnBill
            // 
            this.btnBill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBill.BorderRadius = 0;
            this.btnBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBill.ButtonText = "Bills";
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill.DisabledColor = System.Drawing.Color.Gray;
            this.btnBill.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBill.Iconimage")));
            this.btnBill.Iconimage_right = null;
            this.btnBill.Iconimage_right_Selected = null;
            this.btnBill.Iconimage_Selected = null;
            this.btnBill.IconMarginLeft = 0;
            this.btnBill.IconMarginRight = 0;
            this.btnBill.IconRightVisible = true;
            this.btnBill.IconRightZoom = 0D;
            this.btnBill.IconVisible = true;
            this.btnBill.IconZoom = 60D;
            this.btnBill.IsTab = false;
            this.btnBill.Location = new System.Drawing.Point(-3, 331);
            this.btnBill.Name = "btnBill";
            this.btnBill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBill.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBill.selected = false;
            this.btnBill.Size = new System.Drawing.Size(209, 59);
            this.btnBill.TabIndex = 4;
            this.btnBill.Text = "Bills";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBill.Textcolor = System.Drawing.Color.White;
            this.btnBill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduct.BorderRadius = 0;
            this.btnProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnProduct.ButtonText = "Products";
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProduct.Iconimage")));
            this.btnProduct.Iconimage_right = null;
            this.btnProduct.Iconimage_right_Selected = null;
            this.btnProduct.Iconimage_Selected = null;
            this.btnProduct.IconMarginLeft = 0;
            this.btnProduct.IconMarginRight = 0;
            this.btnProduct.IconRightVisible = true;
            this.btnProduct.IconRightZoom = 0D;
            this.btnProduct.IconVisible = true;
            this.btnProduct.IconZoom = 60D;
            this.btnProduct.IsTab = false;
            this.btnProduct.Location = new System.Drawing.Point(-3, 276);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProduct.selected = false;
            this.btnProduct.Size = new System.Drawing.Size(209, 57);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Products";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProduct.Textcolor = System.Drawing.Color.White;
            this.btnProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.BorderRadius = 0;
            this.btnCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCustomer.ButtonText = "Customers";
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.DisabledColor = System.Drawing.Color.Gray;
            this.btnCustomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCustomer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Iconimage")));
            this.btnCustomer.Iconimage_right = null;
            this.btnCustomer.Iconimage_right_Selected = null;
            this.btnCustomer.Iconimage_Selected = null;
            this.btnCustomer.IconMarginLeft = 0;
            this.btnCustomer.IconMarginRight = 0;
            this.btnCustomer.IconRightVisible = true;
            this.btnCustomer.IconRightZoom = 0D;
            this.btnCustomer.IconVisible = true;
            this.btnCustomer.IconZoom = 60D;
            this.btnCustomer.IsTab = false;
            this.btnCustomer.Location = new System.Drawing.Point(-3, 219);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCustomer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCustomer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCustomer.selected = false;
            this.btnCustomer.Size = new System.Drawing.Size(209, 58);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustomer.Textcolor = System.Drawing.Color.White;
            this.btnCustomer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnEmp
            // 
            this.btnEmp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmp.BorderRadius = 0;
            this.btnEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnEmp.ButtonText = "Employees";
            this.btnEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmp.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmp.Iconimage")));
            this.btnEmp.Iconimage_right = null;
            this.btnEmp.Iconimage_right_Selected = null;
            this.btnEmp.Iconimage_Selected = null;
            this.btnEmp.IconMarginLeft = 0;
            this.btnEmp.IconMarginRight = 0;
            this.btnEmp.IconRightVisible = true;
            this.btnEmp.IconRightZoom = 0D;
            this.btnEmp.IconVisible = true;
            this.btnEmp.IconZoom = 60D;
            this.btnEmp.IsTab = false;
            this.btnEmp.Location = new System.Drawing.Point(-3, 166);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEmp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEmp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmp.selected = false;
            this.btnEmp.Size = new System.Drawing.Size(209, 56);
            this.btnEmp.TabIndex = 1;
            this.btnEmp.Text = "Employees";
            this.btnEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmp.Textcolor = System.Drawing.Color.White;
            this.btnEmp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.employee2);
            this.panel1.Controls.Add(this.customer3);
            this.panel1.Controls.Add(this.projects1);
            this.panel1.Controls.Add(this.products1);
            this.panel1.Controls.Add(this.customer2);
            this.panel1.Controls.Add(this.bill1);
            this.panel1.Location = new System.Drawing.Point(247, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 552);
            this.panel1.TabIndex = 2;
            // 
            // employee2
            // 
            this.employee2.Dock = System.Windows.Forms.DockStyle.Right;
            this.employee2.Location = new System.Drawing.Point(-38, 0);
            this.employee2.Name = "employee2";
            this.employee2.Size = new System.Drawing.Size(961, 552);
            this.employee2.TabIndex = 5;
            // 
            // customer3
            // 
            this.customer3.Location = new System.Drawing.Point(-3, 33);
            this.customer3.Name = "customer3";
            this.customer3.Size = new System.Drawing.Size(923, 560);
            this.customer3.TabIndex = 4;
            // 
            // projects1
            // 
            this.projects1.Location = new System.Drawing.Point(-3, 33);
            this.projects1.Name = "projects1";
            this.projects1.Size = new System.Drawing.Size(923, 557);
            this.projects1.TabIndex = 3;
            // 
            // products1
            // 
            this.products1.Location = new System.Drawing.Point(0, 33);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(923, 557);
            this.products1.TabIndex = 2;
            // 
            // customer2
            // 
            this.customer2.Location = new System.Drawing.Point(3, 45);
            this.customer2.Name = "customer2";
            this.customer2.Size = new System.Drawing.Size(923, 548);
            this.customer2.TabIndex = 1;
            // 
            // bill1
            // 
            this.bill1.Location = new System.Drawing.Point(3, 33);
            this.bill1.Name = "bill1";
            this.bill1.Size = new System.Drawing.Size(923, 560);
            this.bill1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel3.Controls.Add(this.tbExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(206, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 32);
            this.panel3.TabIndex = 3;
            // 
            // tbExit
            // 
            this.tbExit.AutoSize = true;
            this.tbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbExit.Location = new System.Drawing.Point(934, 3);
            this.tbExit.Name = "tbExit";
            this.tbExit.Size = new System.Drawing.Size(26, 25);
            this.tbExit.TabIndex = 0;
            this.tbExit.Text = "X";
            this.tbExit.Click += new System.EventHandler(this.tbExit_Click);
            // 
            // employee1
            // 
            this.employee1.Location = new System.Drawing.Point(0, 0);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(923, 590);
            this.employee1.TabIndex = 1;
            // 
            // customer1
            // 
            this.customer1.Location = new System.Drawing.Point(0, 0);
            this.customer1.Name = "customer1";
            this.customer1.Size = new System.Drawing.Size(923, 590);
            this.customer1.TabIndex = 0;
            // 
            // FormRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 590);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí bất động sản";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCustomer;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmp;
        private user_control.Employee employee1;
        private user_control.Customer customer1;
        private Bunifu.Framework.UI.BunifuFlatButton btnProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnProject;
        private Bunifu.Framework.UI.BunifuFlatButton btnBill;
        private user_control.Projects projects1;
        private user_control.Products products1;
        private user_control.Customer customer2;
        private user_control.Bill bill1;
        private user_control.Employee employee2;
        private user_control.Customer customer3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tbExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnSale;
        private System.Windows.Forms.Label label3;
    }
}

