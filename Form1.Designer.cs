using System;

namespace WindowsFormsApp1
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
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.TotalItemBox = new System.Windows.Forms.TextBox();
            this.TotalItemLabel = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.StartShoppingButton = new System.Windows.Forms.Button();
            this.StartShoppingPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.returnShop = new System.Windows.Forms.Button();
            this.SearchItemPanel = new System.Windows.Forms.Panel();
            this.cartList = new System.Windows.Forms.ListBox();
            this.CartButton = new System.Windows.Forms.Button();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.ItemNameBox = new System.Windows.Forms.TextBox();
            this.FinishButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ItemValueBox = new System.Windows.Forms.TextBox();
            this.ItemValueLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchItemBox = new System.Windows.Forms.TextBox();
            this.SearchItemLabel = new System.Windows.Forms.Label();
            this.CheckoutPanel = new System.Windows.Forms.Panel();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.ItemNumberBox = new System.Windows.Forms.TextBox();
            this.ItemNumber = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.PayButton = new System.Windows.Forms.Button();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.CartTotalLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CSSLabel = new System.Windows.Forms.Label();
            this.ExDateBox = new System.Windows.Forms.TextBox();
            this.ExpirationLabel = new System.Windows.Forms.Label();
            this.cardBox = new System.Windows.Forms.TextBox();
            this.CardLabel = new System.Windows.Forms.Label();
            this.LogInPanel.SuspendLayout();
            this.NamePanel.SuspendLayout();
            this.StartShoppingPanel.SuspendLayout();
            this.SearchItemPanel.SuspendLayout();
            this.CheckoutPanel.SuspendLayout();
            this.CardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(3, 46);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(96, 20);
            this.CustomerLabel.TabIndex = 0;
            this.CustomerLabel.Text = "Customer Id";
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(105, 43);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(100, 26);
            this.IdBox.TabIndex = 1;
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(211, 32);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(75, 45);
            this.LogInButton.TabIndex = 2;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogInPanel
            // 
            this.LogInPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogInPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogInPanel.Controls.Add(this.LogOutButton);
            this.LogInPanel.Controls.Add(this.CustomerLabel);
            this.LogInPanel.Controls.Add(this.LogInButton);
            this.LogInPanel.Controls.Add(this.IdBox);
            this.LogInPanel.Location = new System.Drawing.Point(1, 0);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(291, 95);
            this.LogInPanel.TabIndex = 3;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Enabled = false;
            this.LogOutButton.Location = new System.Drawing.Point(10, 3);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(119, 34);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // NamePanel
            // 
            this.NamePanel.Controls.Add(this.TotalItemBox);
            this.NamePanel.Controls.Add(this.TotalItemLabel);
            this.NamePanel.Controls.Add(this.LastNameBox);
            this.NamePanel.Controls.Add(this.LastNameLabel);
            this.NamePanel.Controls.Add(this.firstNameBox);
            this.NamePanel.Controls.Add(this.FirstNameLabel);
            this.NamePanel.Location = new System.Drawing.Point(294, 0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(565, 95);
            this.NamePanel.TabIndex = 4;
            this.NamePanel.Visible = false;
            // 
            // TotalItemBox
            // 
            this.TotalItemBox.Enabled = false;
            this.TotalItemBox.Location = new System.Drawing.Point(501, 30);
            this.TotalItemBox.Name = "TotalItemBox";
            this.TotalItemBox.Size = new System.Drawing.Size(49, 26);
            this.TotalItemBox.TabIndex = 5;
            // 
            // TotalItemLabel
            // 
            this.TotalItemLabel.AutoSize = true;
            this.TotalItemLabel.Location = new System.Drawing.Point(403, 33);
            this.TotalItemLabel.Name = "TotalItemLabel";
            this.TotalItemLabel.Size = new System.Drawing.Size(92, 20);
            this.TotalItemLabel.TabIndex = 5;
            this.TotalItemLabel.Text = "Total Items:";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Enabled = false;
            this.LastNameBox.Location = new System.Drawing.Point(297, 30);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(101, 26);
            this.LastNameBox.TabIndex = 5;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(199, 33);
            this.LastNameLabel.MaximumSize = new System.Drawing.Size(200, 200);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(94, 20);
            this.LastNameLabel.TabIndex = 5;
            this.LastNameLabel.Text = "Last Name :";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Enabled = false;
            this.firstNameBox.Location = new System.Drawing.Point(99, 30);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(94, 26);
            this.firstNameBox.TabIndex = 5;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(4, 33);
            this.FirstNameLabel.MaximumSize = new System.Drawing.Size(200, 200);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(94, 20);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "First Name :";
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Enabled = false;
            this.CheckOutButton.Location = new System.Drawing.Point(162, 21);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(126, 34);
            this.CheckOutButton.TabIndex = 5;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartShoppingButton
            // 
            this.StartShoppingButton.Location = new System.Drawing.Point(136, 21);
            this.StartShoppingButton.Name = "StartShoppingButton";
            this.StartShoppingButton.Size = new System.Drawing.Size(131, 34);
            this.StartShoppingButton.TabIndex = 6;
            this.StartShoppingButton.Text = "Shop";
            this.StartShoppingButton.UseVisualStyleBackColor = true;
            this.StartShoppingButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // StartShoppingPanel
            // 
            this.StartShoppingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartShoppingPanel.Controls.Add(this.DeleteButton);
            this.StartShoppingPanel.Controls.Add(this.returnShop);
            this.StartShoppingPanel.Controls.Add(this.SearchItemPanel);
            this.StartShoppingPanel.Controls.Add(this.StartShoppingButton);
            this.StartShoppingPanel.Location = new System.Drawing.Point(1, 98);
            this.StartShoppingPanel.Name = "StartShoppingPanel";
            this.StartShoppingPanel.Size = new System.Drawing.Size(429, 281);
            this.StartShoppingPanel.TabIndex = 7;
            this.StartShoppingPanel.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(10, 21);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(98, 34);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // returnShop
            // 
            this.returnShop.Location = new System.Drawing.Point(316, 21);
            this.returnShop.Name = "returnShop";
            this.returnShop.Size = new System.Drawing.Size(104, 34);
            this.returnShop.TabIndex = 7;
            this.returnShop.Text = "Return";
            this.returnShop.UseVisualStyleBackColor = true;
            this.returnShop.Visible = false;
            this.returnShop.Click += new System.EventHandler(this.returnShop_Click);
            // 
            // SearchItemPanel
            // 
            this.SearchItemPanel.Controls.Add(this.cartList);
            this.SearchItemPanel.Controls.Add(this.CartButton);
            this.SearchItemPanel.Controls.Add(this.ItemLabel);
            this.SearchItemPanel.Controls.Add(this.ItemNameBox);
            this.SearchItemPanel.Controls.Add(this.FinishButton);
            this.SearchItemPanel.Controls.Add(this.AddButton);
            this.SearchItemPanel.Controls.Add(this.ItemValueBox);
            this.SearchItemPanel.Controls.Add(this.ItemValueLabel);
            this.SearchItemPanel.Controls.Add(this.SearchButton);
            this.SearchItemPanel.Controls.Add(this.SearchItemBox);
            this.SearchItemPanel.Controls.Add(this.SearchItemLabel);
            this.SearchItemPanel.Location = new System.Drawing.Point(-1, 61);
            this.SearchItemPanel.Name = "SearchItemPanel";
            this.SearchItemPanel.Size = new System.Drawing.Size(429, 223);
            this.SearchItemPanel.TabIndex = 8;
            this.SearchItemPanel.Visible = false;
            // 
            // cartList
            // 
            this.cartList.FormattingEnabled = true;
            this.cartList.ItemHeight = 20;
            this.cartList.Location = new System.Drawing.Point(0, 11);
            this.cartList.MultiColumn = true;
            this.cartList.Name = "cartList";
            this.cartList.Size = new System.Drawing.Size(429, 204);
            this.cartList.TabIndex = 15;
            this.cartList.Visible = false;
            // 
            // CartButton
            // 
            this.CartButton.Location = new System.Drawing.Point(158, 145);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(119, 35);
            this.CartButton.TabIndex = 8;
            this.CartButton.Text = "View Cart";
            this.CartButton.UseVisualStyleBackColor = true;
            this.CartButton.Click += new System.EventHandler(this.CartButton_Click);
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Location = new System.Drawing.Point(252, 88);
            this.ItemLabel.MaximumSize = new System.Drawing.Size(200, 200);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(45, 20);
            this.ItemLabel.TabIndex = 14;
            this.ItemLabel.Text = "Item:";
            // 
            // ItemNameBox
            // 
            this.ItemNameBox.Enabled = false;
            this.ItemNameBox.Location = new System.Drawing.Point(303, 85);
            this.ItemNameBox.Name = "ItemNameBox";
            this.ItemNameBox.Size = new System.Drawing.Size(100, 26);
            this.ItemNameBox.TabIndex = 13;
            // 
            // FinishButton
            // 
            this.FinishButton.Enabled = false;
            this.FinishButton.Location = new System.Drawing.Point(301, 145);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(84, 35);
            this.FinishButton.TabIndex = 12;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(11, 145);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(124, 35);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add To Cart";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // ItemValueBox
            // 
            this.ItemValueBox.Enabled = false;
            this.ItemValueBox.Location = new System.Drawing.Point(126, 85);
            this.ItemValueBox.Name = "ItemValueBox";
            this.ItemValueBox.Size = new System.Drawing.Size(100, 26);
            this.ItemValueBox.TabIndex = 10;
            // 
            // ItemValueLabel
            // 
            this.ItemValueLabel.AutoSize = true;
            this.ItemValueLabel.Location = new System.Drawing.Point(30, 88);
            this.ItemValueLabel.MaximumSize = new System.Drawing.Size(200, 200);
            this.ItemValueLabel.Name = "ItemValueLabel";
            this.ItemValueLabel.Size = new System.Drawing.Size(90, 20);
            this.ItemValueLabel.TabIndex = 9;
            this.ItemValueLabel.Text = "Item Value:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(279, 23);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 34);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // SearchItemBox
            // 
            this.SearchItemBox.Location = new System.Drawing.Point(149, 27);
            this.SearchItemBox.Name = "SearchItemBox";
            this.SearchItemBox.Size = new System.Drawing.Size(100, 26);
            this.SearchItemBox.TabIndex = 7;
            // 
            // SearchItemLabel
            // 
            this.SearchItemLabel.AutoSize = true;
            this.SearchItemLabel.Location = new System.Drawing.Point(30, 30);
            this.SearchItemLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.SearchItemLabel.Name = "SearchItemLabel";
            this.SearchItemLabel.Size = new System.Drawing.Size(100, 20);
            this.SearchItemLabel.TabIndex = 6;
            this.SearchItemLabel.Text = "Search Item:";
            // 
            // CheckoutPanel
            // 
            this.CheckoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckoutPanel.Controls.Add(this.CardPanel);
            this.CheckoutPanel.Controls.Add(this.CheckOutButton);
            this.CheckoutPanel.Location = new System.Drawing.Point(428, 98);
            this.CheckoutPanel.Name = "CheckoutPanel";
            this.CheckoutPanel.Size = new System.Drawing.Size(431, 281);
            this.CheckoutPanel.TabIndex = 0;
            this.CheckoutPanel.Visible = false;
            // 
            // CardPanel
            // 
            this.CardPanel.Controls.Add(this.ItemNumberBox);
            this.CardPanel.Controls.Add(this.ItemNumber);
            this.CardPanel.Controls.Add(this.BackButton);
            this.CardPanel.Controls.Add(this.PayButton);
            this.CardPanel.Controls.Add(this.totalBox);
            this.CardPanel.Controls.Add(this.CartTotalLabel);
            this.CardPanel.Controls.Add(this.textBox1);
            this.CardPanel.Controls.Add(this.CSSLabel);
            this.CardPanel.Controls.Add(this.ExDateBox);
            this.CardPanel.Controls.Add(this.ExpirationLabel);
            this.CardPanel.Controls.Add(this.cardBox);
            this.CardPanel.Controls.Add(this.CardLabel);
            this.CardPanel.Location = new System.Drawing.Point(-1, 61);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(431, 219);
            this.CardPanel.TabIndex = 6;
            this.CardPanel.Visible = false;
            // 
            // ItemNumberBox
            // 
            this.ItemNumberBox.Location = new System.Drawing.Point(240, 149);
            this.ItemNumberBox.Name = "ItemNumberBox";
            this.ItemNumberBox.Size = new System.Drawing.Size(59, 26);
            this.ItemNumberBox.TabIndex = 11;
            // 
            // ItemNumber
            // 
            this.ItemNumber.AutoSize = true;
            this.ItemNumber.Location = new System.Drawing.Point(180, 152);
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.Size = new System.Drawing.Size(54, 20);
            this.ItemNumber.TabIndex = 10;
            this.ItemNumber.Text = "Item#:";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(312, 82);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(104, 32);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(310, 146);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(106, 32);
            this.PayButton.TabIndex = 8;
            this.PayButton.Text = "PAY";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(99, 149);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(66, 26);
            this.totalBox.TabIndex = 7;
            // 
            // CartTotalLabel
            // 
            this.CartTotalLabel.AutoSize = true;
            this.CartTotalLabel.Location = new System.Drawing.Point(15, 152);
            this.CartTotalLabel.Name = "CartTotalLabel";
            this.CartTotalLabel.Size = new System.Drawing.Size(82, 20);
            this.CartTotalLabel.TabIndex = 6;
            this.CartTotalLabel.Text = "Cart Total:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 26);
            this.textBox1.TabIndex = 5;
            // 
            // CSSLabel
            // 
            this.CSSLabel.AutoSize = true;
            this.CSSLabel.Location = new System.Drawing.Point(205, 88);
            this.CSSLabel.Name = "CSSLabel";
            this.CSSLabel.Size = new System.Drawing.Size(46, 20);
            this.CSSLabel.TabIndex = 4;
            this.CSSLabel.Text = "CSS:";
            // 
            // ExDateBox
            // 
            this.ExDateBox.Location = new System.Drawing.Point(99, 85);
            this.ExDateBox.Name = "ExDateBox";
            this.ExDateBox.Size = new System.Drawing.Size(100, 26);
            this.ExDateBox.TabIndex = 3;
            // 
            // ExpirationLabel
            // 
            this.ExpirationLabel.AutoSize = true;
            this.ExpirationLabel.Location = new System.Drawing.Point(23, 88);
            this.ExpirationLabel.Name = "ExpirationLabel";
            this.ExpirationLabel.Size = new System.Drawing.Size(70, 20);
            this.ExpirationLabel.TabIndex = 2;
            this.ExpirationLabel.Text = "Ex Date:";
            // 
            // cardBox
            // 
            this.cardBox.Location = new System.Drawing.Point(132, 27);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(270, 26);
            this.cardBox.TabIndex = 1;
            // 
            // CardLabel
            // 
            this.CardLabel.AutoSize = true;
            this.CardLabel.Location = new System.Drawing.Point(23, 30);
            this.CardLabel.Name = "CardLabel";
            this.CardLabel.Size = new System.Drawing.Size(107, 20);
            this.CardLabel.TabIndex = 0;
            this.CardLabel.Text = "Card Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(861, 379);
            this.Controls.Add(this.CheckoutPanel);
            this.Controls.Add(this.StartShoppingPanel);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.LogInPanel);
            this.Name = "Form1";
            this.Text = "Shopper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LogInPanel.ResumeLayout(false);
            this.LogInPanel.PerformLayout();
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            this.StartShoppingPanel.ResumeLayout(false);
            this.SearchItemPanel.ResumeLayout(false);
            this.SearchItemPanel.PerformLayout();
            this.CheckoutPanel.ResumeLayout(false);
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Panel LogInPanel;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox TotalItemBox;
        private System.Windows.Forms.Label TotalItemLabel;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button StartShoppingButton;
        private System.Windows.Forms.Panel StartShoppingPanel;
        private System.Windows.Forms.Panel CheckoutPanel;
        private System.Windows.Forms.Label SearchItemLabel;
        private System.Windows.Forms.Panel SearchItemPanel;
        private System.Windows.Forms.TextBox SearchItemBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox ItemValueBox;
        private System.Windows.Forms.Label ItemValueLabel;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.Label ExpirationLabel;
        private System.Windows.Forms.TextBox cardBox;
        private System.Windows.Forms.Label CardLabel;
        private System.Windows.Forms.Label CSSLabel;
        private System.Windows.Forms.TextBox ExDateBox;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label CartTotalLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.TextBox ItemNameBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label ItemNumber;
        private System.Windows.Forms.TextBox ItemNumberBox;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.ListBox cartList;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Button returnShop;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsColumn;
    }
}

