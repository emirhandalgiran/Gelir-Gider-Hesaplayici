using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using OfficeOpenXml; // EPPlus NuGet paketinin yüklü olduğundan emin olun

namespace IncomeExpenseTracker
{
    public partial class Form1 : Form
    {
        private List<Income> incomes = new List<Income>();
        private List<Expense> expenses = new List<Expense>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            try
            {
                string type = txtIncomeType.Text;
                decimal amount = Convert.ToDecimal(txtIncomeAmount.Text);
                incomes.Add(new Income { Type = type, Amount = amount });
                MessageBox.Show("Gelir başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIncomeType.Clear();
                txtIncomeAmount.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            try
            {
                string type = txtExpenseType.Text;
                decimal amount = Convert.ToDecimal(txtExpenseAmount.Text);
                expenses.Add(new Expense { Type = type, Amount = amount });
                MessageBox.Show("Gider başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExpenseType.Clear();
                txtExpenseAmount.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal totalIncome = 0;
            decimal totalExpense = 0;

            foreach (var income in incomes)
                totalIncome += income.Amount;

            foreach (var expense in expenses)
                totalExpense += expense.Amount;

            decimal netIncome = totalIncome - totalExpense;

            lblResult.Text = $"Toplam Gelir: {totalIncome} TL\nToplam Gider: {totalExpense} TL\nNet Gelir: {netIncome} TL";
        }

        private void btnSaveToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (incomes.Count == 0 && expenses.Count == 0)
                {
                    MessageBox.Show("Kaydedilecek veri yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Masaüstü yolunu al
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = System.IO.Path.Combine(desktopPath, "GelirGiderTablosu.xlsx");

                using (var package = new ExcelPackage())
                {
                    var incomeSheet = package.Workbook.Worksheets.Add("Gelirler");
                    var expenseSheet = package.Workbook.Worksheets.Add("Giderler");

                    // Gelir sayfası için başlıkları ayarla
                    incomeSheet.Cells[1, 1].Value = "Tür";
                    incomeSheet.Cells[1, 2].Value = "Miktar";

                    for (int i = 0; i < incomes.Count; i++)
                    {
                        incomeSheet.Cells[i + 2, 1].Value = incomes[i].Type;
                        incomeSheet.Cells[i + 2, 2].Value = incomes[i].Amount;
                    }

                    // Gider sayfası için başlıkları ayarla
                    expenseSheet.Cells[1, 1].Value = "Tür";
                    expenseSheet.Cells[1, 2].Value = "Miktar";

                    for (int i = 0; i < expenses.Count; i++)
                    {
                        expenseSheet.Cells[i + 2, 1].Value = expenses[i].Type;
                        expenseSheet.Cells[i + 2, 2].Value = expenses[i].Amount;
                    }

                    // Excel dosyasını masaüstüne kaydet
                    package.SaveAs(new System.IO.FileInfo(filePath));
                }

                MessageBox.Show("Veriler başarıyla Excel'e kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excel'e kaydederken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIncomeType_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Income
    {
        public string Type { get; set; }
        public decimal Amount { get; set; }
    }

    public class Expense
    {
        public string Type { get; set; }
        public decimal Amount { get; set; }
    }
}
