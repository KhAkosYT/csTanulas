namespace OOPProbalkozas
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
            OwnerLabel = new Label();
            AmountLabel = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            CreateBtn = new Button();
            WithdrawBtn = new Button();
            DepositBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            SuspendLayout();
            // 
            // OwnerLabel
            // 
            OwnerLabel.AutoSize = true;
            OwnerLabel.Location = new Point(99, 83);
            OwnerLabel.Name = "OwnerLabel";
            OwnerLabel.Size = new Size(73, 28);
            OwnerLabel.TabIndex = 0;
            OwnerLabel.Text = "Owner:";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(89, 361);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(83, 28);
            AmountLabel.TabIndex = 1;
            AmountLabel.Text = "Amount";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(188, 83);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(249, 34);
            OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(188, 361);
            AmountNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(150, 34);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(490, 83);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 51;
            BankAccountsGrid.Size = new Size(559, 312);
            BankAccountsGrid.TabIndex = 4;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(188, 138);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(113, 49);
            CreateBtn.TabIndex = 5;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(490, 401);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(261, 51);
            WithdrawBtn.TabIndex = 6;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(790, 401);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(259, 51);
            DepositBtn.TabIndex = 7;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 486);
            Controls.Add(DepositBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(CreateBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(AmountLabel);
            Controls.Add(OwnerLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Bank";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OwnerLabel;
        private Label AmountLabel;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button CreateBtn;
        private Button WithdrawBtn;
        private Button DepositBtn;
    }
}
