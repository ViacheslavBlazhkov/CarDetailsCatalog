using System;
using System.Windows.Forms;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Exceptions;
using CarDetailsCatalog.Models.Factories;

namespace CarDetailsCatalog.VisualComponents
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Brand)))
            {
                brandDropdown.Items.Add(item);
            }
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (brandDropdown.Text == "")
                {
                    MessageBox.Show(@"Choose brand from dropdown!", @"Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else if (modelTextBox.Text == "")
                {
                    MessageBox.Show(@"Enter model name!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var brand = (Brand)Enum.Parse(typeof(Brand), brandDropdown.Text);
                    CarFactory.Create(brand, modelTextBox.Text, (int)yearInput.Value);
                    MessageBox.Show(@"Car has been successfully added", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (CarAlreadyExistsException ex)
            {
                MessageBox.Show(ex.Message, @"Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewDetailBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (modelTextBox.Text == "")
                {
                    MessageBox.Show(@"Enter correct brand and model name!", @"Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}