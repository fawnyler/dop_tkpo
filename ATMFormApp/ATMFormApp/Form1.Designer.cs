namespace ATMFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWaitingMessage = new System.Windows.Forms.Label();
            this.btnInsertCard = new System.Windows.Forms.Button();
            this.lblAuthMessage = new System.Windows.Forms.Label();
            this.btnSubmitPIN = new System.Windows.Forms.Button();
            this.txtPINInput = new System.Windows.Forms.TextBox();
            this.lblOperationMessage = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.lblWithdrawAmountPrompt = new System.Windows.Forms.Label();
            this.lblDepositAmountPrompt = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.btnConfirmDeposit = new System.Windows.Forms.Button();
            this.btnConfirmWithdrawal = new System.Windows.Forms.Button();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWaitingMessage
            // 
            this.lblWaitingMessage.AutoSize = true;
            this.lblWaitingMessage.Location = new System.Drawing.Point(282, 57);
            this.lblWaitingMessage.Name = "lblWaitingMessage";
            this.lblWaitingMessage.Size = new System.Drawing.Size(195, 16);
            this.lblWaitingMessage.TabIndex = 0;
            this.lblWaitingMessage.Text = "Пожалуйста, вставьте карту";
            // 
            // btnInsertCard
            // 
            this.btnInsertCard.Location = new System.Drawing.Point(301, 91);
            this.btnInsertCard.Name = "btnInsertCard";
            this.btnInsertCard.Size = new System.Drawing.Size(151, 23);
            this.btnInsertCard.TabIndex = 1;
            this.btnInsertCard.Text = "Вставить карту";
            this.btnInsertCard.UseVisualStyleBackColor = true;
            this.btnInsertCard.Click += new System.EventHandler(this.btnInsertCard_Click);
            // 
            // lblAuthMessage
            // 
            this.lblAuthMessage.AutoSize = true;
            this.lblAuthMessage.Location = new System.Drawing.Point(318, 153);
            this.lblAuthMessage.Name = "lblAuthMessage";
            this.lblAuthMessage.Size = new System.Drawing.Size(115, 16);
            this.lblAuthMessage.TabIndex = 2;
            this.lblAuthMessage.Text = "Введите PIN-код";
            this.lblAuthMessage.Visible = false;
            // 
            // btnSubmitPIN
            // 
            this.btnSubmitPIN.Location = new System.Drawing.Point(317, 225);
            this.btnSubmitPIN.Name = "btnSubmitPIN";
            this.btnSubmitPIN.Size = new System.Drawing.Size(121, 23);
            this.btnSubmitPIN.TabIndex = 4;
            this.btnSubmitPIN.Text = "Ввести PIN";
            this.btnSubmitPIN.UseVisualStyleBackColor = true;
            this.btnSubmitPIN.Click += new System.EventHandler(this.btnSubmitPIN_Click);
            // 
            // txtPINInput
            // 
            this.txtPINInput.Location = new System.Drawing.Point(321, 188);
            this.txtPINInput.Name = "txtPINInput";
            this.txtPINInput.Size = new System.Drawing.Size(112, 22);
            this.txtPINInput.TabIndex = 3;
            this.txtPINInput.Visible = false;
            // 
            // lblOperationMessage
            // 
            this.lblOperationMessage.AutoSize = true;
            this.lblOperationMessage.Location = new System.Drawing.Point(298, 289);
            this.lblOperationMessage.Name = "lblOperationMessage";
            this.lblOperationMessage.Size = new System.Drawing.Size(141, 16);
            this.lblOperationMessage.TabIndex = 5;
            this.lblOperationMessage.Text = "Выберите операцию";
            this.lblOperationMessage.Visible = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(256, 329);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(106, 23);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Снять деньги";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Visible = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(391, 329);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(140, 23);
            this.btnDeposit.TabIndex = 7;
            this.btnDeposit.Text = "Положить деньги";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Visible = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(256, 369);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(152, 23);
            this.btnCheckBalance.TabIndex = 8;
            this.btnCheckBalance.Text = "Посмотреть баланс";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Visible = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(456, 369);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Location = new System.Drawing.Point(485, 453);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(100, 22);
            this.txtWithdrawAmount.TabIndex = 11;
            this.txtWithdrawAmount.Visible = false;
            // 
            // lblWithdrawAmountPrompt
            // 
            this.lblWithdrawAmountPrompt.AutoSize = true;
            this.lblWithdrawAmountPrompt.Location = new System.Drawing.Point(259, 456);
            this.lblWithdrawAmountPrompt.Name = "lblWithdrawAmountPrompt";
            this.lblWithdrawAmountPrompt.Size = new System.Drawing.Size(183, 16);
            this.lblWithdrawAmountPrompt.TabIndex = 12;
            this.lblWithdrawAmountPrompt.Text = "Введите сумму для снятия:";
            this.lblWithdrawAmountPrompt.Visible = false;
            // 
            // lblDepositAmountPrompt
            // 
            this.lblDepositAmountPrompt.AutoSize = true;
            this.lblDepositAmountPrompt.Location = new System.Drawing.Point(259, 490);
            this.lblDepositAmountPrompt.Name = "lblDepositAmountPrompt";
            this.lblDepositAmountPrompt.Size = new System.Drawing.Size(218, 16);
            this.lblDepositAmountPrompt.TabIndex = 13;
            this.lblDepositAmountPrompt.Text = "Введите сумму для пополнения:";
            this.lblDepositAmountPrompt.Visible = false;
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(485, 487);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(100, 22);
            this.txtDepositAmount.TabIndex = 14;
            this.txtDepositAmount.Visible = false;
            // 
            // btnConfirmDeposit
            // 
            this.btnConfirmDeposit.Location = new System.Drawing.Point(590, 483);
            this.btnConfirmDeposit.Name = "btnConfirmDeposit";
            this.btnConfirmDeposit.Size = new System.Drawing.Size(154, 31);
            this.btnConfirmDeposit.TabIndex = 16;
            this.btnConfirmDeposit.Text = "Подтвердить";
            this.btnConfirmDeposit.UseVisualStyleBackColor = true;
            this.btnConfirmDeposit.Visible = false;
            this.btnConfirmDeposit.Click += new System.EventHandler(this.btnConfirmDeposit_Click);
            // 
            // btnConfirmWithdrawal
            // 
            this.btnConfirmWithdrawal.Location = new System.Drawing.Point(590, 448);
            this.btnConfirmWithdrawal.Name = "btnConfirmWithdrawal";
            this.btnConfirmWithdrawal.Size = new System.Drawing.Size(154, 32);
            this.btnConfirmWithdrawal.TabIndex = 15;
            this.btnConfirmWithdrawal.Text = "Подтвердить";
            this.btnConfirmWithdrawal.UseVisualStyleBackColor = true;
            this.btnConfirmWithdrawal.Visible = false;
            this.btnConfirmWithdrawal.Click += new System.EventHandler(this.btnConfirmWithdraw_Click);
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Location = new System.Drawing.Point(259, 427);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentBalance.TabIndex = 10;
            this.lblCurrentBalance.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnConfirmDeposit);
            this.Controls.Add(this.btnConfirmWithdrawal);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.lblDepositAmountPrompt);
            this.Controls.Add(this.lblWithdrawAmountPrompt);
            this.Controls.Add(this.txtWithdrawAmount);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblOperationMessage);
            this.Controls.Add(this.txtPINInput);
            this.Controls.Add(this.btnSubmitPIN);
            this.Controls.Add(this.lblAuthMessage);
            this.Controls.Add(this.btnInsertCard);
            this.Controls.Add(this.lblWaitingMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWaitingMessage;
        private System.Windows.Forms.Button btnInsertCard;
        private System.Windows.Forms.Label lblAuthMessage;
        private System.Windows.Forms.Button btnSubmitPIN;
        private System.Windows.Forms.TextBox txtPINInput;
        private System.Windows.Forms.Label lblOperationMessage;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.Label lblWithdrawAmountPrompt;
        private System.Windows.Forms.Label lblDepositAmountPrompt;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Button btnConfirmDeposit;
        private System.Windows.Forms.Button btnConfirmWithdrawal;
        private System.Windows.Forms.Label lblCurrentBalance;
    }
}

