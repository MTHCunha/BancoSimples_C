using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        ContaCorrente conta;
        List<ContaCorrente> contas = new List<ContaCorrente>();
        string a;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtvalor.Value);
            ContaCorrente contaAntiga = contas.Find(c => c.NomeTitular == txtBusca.Text);

            if (contaAntiga != null)
            {
                ContaCorrente contaNova = new ContaCorrente(contaAntiga.Agencia, contaAntiga.NumeroConta, 
                    contaAntiga.NomeTitular, contaAntiga.Saldo);
                try
                {
                    contaNova.Saque(valor);
                    txtSaldo.Value = Convert.ToDecimal(contaNova.Saldo);
                    contas.Add(contaNova);
                    contas.Remove(contaAntiga);
                    MessageBox.Show("Conta atualizada com sucesso. Novo saldo: " + contaNova.Saldo);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                try
                {
                    conta = (new ContaCorrente(
                        int.Parse(txtAgencia.Text),
                        txtConta.Text,
                        txtTitular.Text,
                        Convert.ToDouble(txtSaldo.Value)));
                    conta.Saque(valor);
                    contas.Add(conta);
                    a = conta.Saldo.ToString("0.00");
                    MessageBox.Show($"Saque realizado com sucesso!! Seu saldo é R${a}");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Não deixe campos nulos!!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
           
        }
        private void btnDepósito_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtvalor.Value);
            ContaCorrente contaAntiga = contas.Find(c => c.NomeTitular == txtBusca.Text);

            if (contaAntiga != null)
            {
                ContaCorrente contaNova = new ContaCorrente(contaAntiga.Agencia, contaAntiga.NumeroConta,
                    contaAntiga.NomeTitular, contaAntiga.Saldo);
                try
                {
                    contaNova.Deposito(valor);
                    txtSaldo.Value = Convert.ToDecimal(contaNova.Saldo);
                    contas.Add(contaNova);
                    contas.Remove(contaAntiga);
                    MessageBox.Show("Conta atualizada com sucesso. Novo saldo: " + contaNova.Saldo);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                try
                {
                    conta = (new ContaCorrente(
                        int.Parse(txtAgencia.Text),
                        txtConta.Text,
                        txtTitular.Text,
                        Convert.ToDouble(txtSaldo.Value)));
                    conta.Deposito(valor);
                    contas.Add(conta);
                    a = conta.Saldo.ToString("0.00");
                    MessageBox.Show($"Depósito realizado com sucesso!! Seu saldo é R${a}");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Não deixe campos nulos!!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
        private void btnops_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = null;
            dgv1.DataSource = contas;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string nomeProcurado = txtBusca.Text;
            List<ContaCorrente> contasEncontradas = contas.FindAll(conta => conta.NomeTitular.Contains(nomeProcurado));
            dgv1.DataSource = contasEncontradas;
            foreach(ContaCorrente conta in contasEncontradas)
            {
                txtAgencia.Text = conta.Agencia.ToString();
                txtConta.Text = conta.NumeroConta;
                txtTitular.Text = conta.NomeTitular;
                txtSaldo.Value = Convert.ToDecimal(conta.Saldo); 
            }
            txtBusca.Clear();
            txtBusca.Clear();
            txtBusca.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ContaCorrente removerconta = contas.Find(c => c.NomeTitular == txtBusca.Text);

            if (removerconta != null)
            {
               contas.Remove(removerconta);
                MessageBox.Show("Conta removida com sucesso!");
            }
            else
            {
                MessageBox.Show("Conta não encontrada");
            }
        }
    }
}
