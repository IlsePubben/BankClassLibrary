namespace DemoForm
{
    partial class DisplayAccountForm
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
            this.TransactionListBox = new System.Windows.Forms.ListBox();
            this.LocationPanel = new DemoForm.CustomTextBoxControl();
            this.TransactionDatePanel = new DemoForm.CustomTextBoxControl();
            this.TransactionAmountPanel = new DemoForm.CustomTextBoxControl();
            this.TransactionTypePanel = new DemoForm.CustomTextBoxControl();
            this.CustomerNamePanel = new DemoForm.CustomTextBoxControl();
            this.DepositAmountTextBox = new System.Windows.Forms.TextBox();
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawAmountTextBox = new System.Windows.Forms.TextBox();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.BalancePanel = new DemoForm.CustomTextBoxControl();
            this.SuspendLayout();
            // 
            // TransactionListBox
            // 
            this.TransactionListBox.FormattingEnabled = true;
            this.TransactionListBox.ItemHeight = 16;
            this.TransactionListBox.Location = new System.Drawing.Point(25, 13);
            this.TransactionListBox.Name = "TransactionListBox";
            this.TransactionListBox.Size = new System.Drawing.Size(305, 356);
            this.TransactionListBox.TabIndex = 0;
            this.TransactionListBox.SelectedIndexChanged += new System.EventHandler(this.TransactionListBox_SelectedIndexChanged);
            // 
            // LocationPanel
            // 
            this.LocationPanel.LabelText = "Location";
            this.LocationPanel.Location = new System.Drawing.Point(387, 273);
            this.LocationPanel.Name = "LocationPanel";
            this.LocationPanel.Size = new System.Drawing.Size(352, 38);
            this.LocationPanel.TabIndex = 5;
            this.LocationPanel.TextInput = "";
            // 
            // TransactionDatePanel
            // 
            this.TransactionDatePanel.LabelText = "Transaction date";
            this.TransactionDatePanel.Location = new System.Drawing.Point(387, 228);
            this.TransactionDatePanel.Name = "TransactionDatePanel";
            this.TransactionDatePanel.Size = new System.Drawing.Size(352, 38);
            this.TransactionDatePanel.TabIndex = 4;
            this.TransactionDatePanel.TextInput = "";
            // 
            // TransactionAmountPanel
            // 
            this.TransactionAmountPanel.LabelText = "Transaction amount";
            this.TransactionAmountPanel.Location = new System.Drawing.Point(387, 183);
            this.TransactionAmountPanel.Name = "TransactionAmountPanel";
            this.TransactionAmountPanel.Size = new System.Drawing.Size(352, 38);
            this.TransactionAmountPanel.TabIndex = 3;
            this.TransactionAmountPanel.TextInput = "";
            // 
            // TransactionTypePanel
            // 
            this.TransactionTypePanel.LabelText = "Transaction type";
            this.TransactionTypePanel.Location = new System.Drawing.Point(387, 138);
            this.TransactionTypePanel.Name = "TransactionTypePanel";
            this.TransactionTypePanel.Size = new System.Drawing.Size(352, 38);
            this.TransactionTypePanel.TabIndex = 2;
            this.TransactionTypePanel.TextInput = "";
            // 
            // CustomerNamePanel
            // 
            this.CustomerNamePanel.LabelText = "Customer name";
            this.CustomerNamePanel.Location = new System.Drawing.Point(387, 13);
            this.CustomerNamePanel.Name = "CustomerNamePanel";
            this.CustomerNamePanel.Size = new System.Drawing.Size(352, 38);
            this.CustomerNamePanel.TabIndex = 1;
            this.CustomerNamePanel.TextInput = "";
            // 
            // DepositAmountTextBox
            // 
            this.DepositAmountTextBox.Location = new System.Drawing.Point(25, 386);
            this.DepositAmountTextBox.Name = "DepositAmountTextBox";
            this.DepositAmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.DepositAmountTextBox.TabIndex = 6;
            this.DepositAmountTextBox.Text = "1000";
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(49, 415);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(75, 29);
            this.DepositButton.TabIndex = 7;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawAmountTextBox
            // 
            this.WithdrawAmountTextBox.Location = new System.Drawing.Point(229, 385);
            this.WithdrawAmountTextBox.Name = "WithdrawAmountTextBox";
            this.WithdrawAmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.WithdrawAmountTextBox.TabIndex = 8;
            this.WithdrawAmountTextBox.Text = "500";
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(245, 414);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(84, 30);
            this.WithdrawButton.TabIndex = 9;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // BalancePanel
            // 
            this.BalancePanel.LabelText = "Balance";
            this.BalancePanel.Location = new System.Drawing.Point(387, 58);
            this.BalancePanel.Name = "BalancePanel";
            this.BalancePanel.Size = new System.Drawing.Size(352, 38);
            this.BalancePanel.TabIndex = 10;
            this.BalancePanel.TextInput = "";
            // 
            // DisplayAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.BalancePanel);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.WithdrawAmountTextBox);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.DepositAmountTextBox);
            this.Controls.Add(this.LocationPanel);
            this.Controls.Add(this.TransactionDatePanel);
            this.Controls.Add(this.TransactionAmountPanel);
            this.Controls.Add(this.TransactionTypePanel);
            this.Controls.Add(this.CustomerNamePanel);
            this.Controls.Add(this.TransactionListBox);
            this.Name = "DisplayAccountForm";
            this.Text = "Account information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TransactionListBox;
        private CustomTextBoxControl CustomerNamePanel;
        private CustomTextBoxControl TransactionTypePanel;
        private CustomTextBoxControl TransactionAmountPanel;
        private CustomTextBoxControl TransactionDatePanel;
        private CustomTextBoxControl LocationPanel;
        private System.Windows.Forms.TextBox DepositAmountTextBox;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.TextBox WithdrawAmountTextBox;
        private System.Windows.Forms.Button WithdrawButton;
        private CustomTextBoxControl BalancePanel;
    }
}