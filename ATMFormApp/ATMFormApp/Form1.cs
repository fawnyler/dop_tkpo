using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMFormApp
{
    public partial class Form1 : Form
    {
        private string pinCode = "1234";  
        private string enteredPin = "";
        private decimal currentBalance = 0.0m;

        public Form1()
        {
            InitializeComponent();
            InitializeSteps();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWaitingMessage.Visible = true;
            btnInsertCard.Visible = true;
            lblAuthMessage.Visible = false;
            txtPINInput.Visible = false;
            btnSubmitPIN.Visible = false;

            lblOperationMessage.Visible = false;
            btnWithdraw.Visible = false;
            btnDeposit.Visible = false;
            btnCheckBalance.Visible = false;
            btnLogout.Visible = false;

            lblWithdrawAmountPrompt.Visible = false;
            txtWithdrawAmount.Visible = false;
            btnConfirmWithdrawal.Visible = false;

            lblDepositAmountPrompt.Visible = false;
            txtDepositAmount.Visible = false;
            btnConfirmDeposit.Visible = false;
        }

        private void InitializeSteps()
        {
            lblWaitingMessage.Visible = true;
            btnInsertCard.Visible = true;

            lblAuthMessage.Visible = false;
            txtPINInput.Visible = false;
            btnSubmitPIN.Visible = false;

            lblOperationMessage.Visible = false;
            btnWithdraw.Visible = false;
            btnDeposit.Visible = false;
            btnCheckBalance.Visible = false;
            btnLogout.Visible = false;

            lblWithdrawAmountPrompt.Visible = false;
            txtWithdrawAmount.Visible = false;
            lblDepositAmountPrompt.Visible = false;
            txtDepositAmount.Visible = false;

            lblCurrentBalance.Visible = false;
        }

        // Событие для кнопки "Вставить карту"
        private void btnInsertCard_Click(object sender, EventArgs e)
        {
            lblWaitingMessage.Visible = false;
            btnInsertCard.Visible = false;

            lblAuthMessage.Visible = true;
            txtPINInput.Visible = true;
            btnSubmitPIN.Visible = true;
        }

        // Событие для кнопки "Ввести PIN"
        private void btnSubmitPIN_Click(object sender, EventArgs e)
        {
            string correctPIN = "1234"; 

            if (txtPINInput.Text == correctPIN)
            {
                lblAuthMessage.Visible = false;
                txtPINInput.Visible = false;
                btnSubmitPIN.Visible = false;

                lblOperationMessage.Visible = true;
                btnWithdraw.Visible = true;
                btnDeposit.Visible = true;
                btnCheckBalance.Visible = true;
                btnLogout.Visible = true;
            }
            else
            {
                MessageBox.Show("Неверный PIN-код. Попробуйте снова.");
            }
        }

        // Обработчик для кнопки "Снять деньги"
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            lblWithdrawAmountPrompt.Visible = true;
            txtWithdrawAmount.Visible = true;
            btnConfirmWithdrawal.Visible = true;

            lblDepositAmountPrompt.Visible = false;
            txtDepositAmount.Visible = false;
            btnConfirmDeposit.Visible = false;
        }

        // Обработчик для кнопки "Подтвердить снятие"
        private void btnConfirmWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtWithdrawAmount.Text, out decimal withdrawAmount))
            {
                if (withdrawAmount > 0 && withdrawAmount <= currentBalance)
                {
                    currentBalance -= withdrawAmount;
                    MessageBox.Show($"Снято: {withdrawAmount:C}. Новый баланс: {currentBalance:C}");
                    txtWithdrawAmount.Clear();
                    lblWithdrawAmountPrompt.Visible = false;
                    txtWithdrawAmount.Visible = false;
                    btnConfirmWithdrawal.Visible = false;
                }
                else
                {
                    MessageBox.Show("Недостаточно средств или неверная сумма.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректную сумму.");
            }
        }

        // Обработчик для кнопки "Положить деньги"
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            lblDepositAmountPrompt.Visible = true;
            txtDepositAmount.Visible = true;
            btnConfirmDeposit.Visible = true;

            lblWithdrawAmountPrompt.Visible = false;
            txtWithdrawAmount.Visible = false;
            btnConfirmWithdrawal.Visible = false;
        }

        // Обработчик для кнопки "Подтвердить пополнение"
        private void btnConfirmDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDepositAmount.Text, out decimal depositAmount))
            {
                if (depositAmount > 0)
                {
                    currentBalance += depositAmount;
                    MessageBox.Show($"Пополнено: {depositAmount:C}. Новый баланс: {currentBalance:C}");
                    txtDepositAmount.Clear();
                    lblDepositAmountPrompt.Visible = false;
                    txtDepositAmount.Visible = false;
                    btnConfirmDeposit.Visible = false;
                }
                else
                {
                    MessageBox.Show("Введите корректную сумму для пополнения.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректную сумму.");
            }
        }


        // Обработчик для кнопки "Посмотреть баланс"
        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            lblCurrentBalance.Visible = true;
            lblCurrentBalance.Text = $"Баланс: {currentBalance:C}";
        }

        // Обработчик для кнопки "Выйти"
        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblCurrentBalance.Visible = false;

            btnLogout.Visible = false;

            lblWaitingMessage.Visible = true;
            btnInsertCard.Visible = true;

            lblAuthMessage.Visible = false;
            txtPINInput.Visible = false;
            btnSubmitPIN.Visible = false;
            lblOperationMessage.Visible = false;
            btnWithdraw.Visible = false;
            btnDeposit.Visible = false;
            btnCheckBalance.Visible = false;

            txtPINInput.Clear();
            txtWithdrawAmount.Clear();
            txtDepositAmount.Clear();
        }


    }

}
