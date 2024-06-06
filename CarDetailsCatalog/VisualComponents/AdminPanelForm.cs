using System;
using System.Windows.Forms;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Exceptions;
using CarDetailsCatalog.Models.Abstracts;
using CarDetailsCatalog.Models.Controllers;
using CarDetailsCatalog.Models.Details;
using CarDetailsCatalog.Models.Factories;

namespace CarDetailsCatalog.VisualComponents
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
            LoadDataToSelects();
        }

        private void LoadDataToSelects()
        {
            foreach (var item in Enum.GetValues(typeof(Brand)))
            {
                brandDropdown.Items.Add(item);
                engineCarBrandSelect.Items.Add(item);
                brakesCarBrandDropdown.Items.Add(item);
                gearboxCarBrandDropdown.Items.Add(item);
                tireCarBrandDropdown.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(Producer)))
            {
                brakesProducerDropdown.Items.Add(item);
                engineProducerDropdown.Items.Add(item);
                gearboxProducerDropdown.Items.Add(item);
                tireProducerDropdown.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(GearboxType)))
            {
                gearboxTypeDropdown.Items.Add(item);
            }

            foreach (var car in CarController.Instance.GetAll())
            {
                brakesCarModelDropdown.Items.Add(car.Model);
                engineModelSelect.Items.Add(car.Model);
                gearboxCarModelDropdown.Items.Add(car.Model);
                tireCarModelDropdown.Items.Add(car.Model);
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
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewEngineBtn_Click(object sender, EventArgs e)
        {
            if (engineNameInput.Text == "" || engineProducerDropdown.Text == "" || enginePriceInput.Text == "" ||
                engineHPInput.Text == "" || engineTorqueInput.Text == "" || engineFuelCInput.Text == "" ||
                engineCarBrandSelect.Text == "" || engineModelSelect.Text == "")
            {
                MessageBox.Show(@"Fill all inputs!", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            var car = CarController.Instance.FindByBrandAndModel(
                (Brand)Enum.Parse(typeof(Brand), engineCarBrandSelect.Text), engineModelSelect.Text);
            var producer = (Producer)Enum.Parse(typeof(Producer), engineProducerDropdown.Text);
            DetailFactory.CreateEngine(
                engineNameInput.Text,
                producer,
                new[] { car.Id },
                double.Parse(enginePriceInput.Text),
                int.Parse(engineHPInput.Text),
                int.Parse(engineTorqueInput.Text),
                double.Parse(engineFuelCInput.Text)
            );
            MessageBox.Show(@"Engine has been successfully added", @"Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void addNewBrakesBtn_Click(object sender, EventArgs e)
        {
            if (brakesTitleInput.Text == "" || brakesProducerDropdown.Text == "" || brakesPriceInput.Text == "" ||
                brakesCarBrandDropdown.Text == "" || brakesCarModelDropdown.Text == "")
            {
                MessageBox.Show(@"Fill all inputs!", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            var car = CarController.Instance.FindByBrandAndModel(
                (Brand)Enum.Parse(typeof(Brand), brakesCarBrandDropdown.Text), brakesCarModelDropdown.Text);
            var producer = (Producer)Enum.Parse(typeof(Producer), brakesProducerDropdown.Text);
            DetailFactory.CreateBrakes(
                brakesTitleInput.Text,
                producer,
                new[] { car.Id },
                double.Parse(brakesPriceInput.Text)
            );
            MessageBox.Show(@"Brakes has been successfully added", @"Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void addNewGearboxBtn_Click(object sender, EventArgs e)
        {
            if (gearboxTitleInput.Text == "" || gearboxPriceInput.Text == "" || gearboxProducerDropdown.Text == "" ||
                gearboxTypeDropdown.Text == "" || gearboxGearsInput.Text == "" || gearboxCarBrandDropdown.Text == "" ||
                gearboxCarModelDropdown.Text == "")
            {
                MessageBox.Show(@"Fill all inputs!", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            var car = CarController.Instance.FindByBrandAndModel(
                (Brand)Enum.Parse(typeof(Brand), gearboxCarBrandDropdown.Text), gearboxCarModelDropdown.Text);
            var producer = (Producer)Enum.Parse(typeof(Producer), gearboxProducerDropdown.Text);
            var type = (GearboxType)Enum.Parse(typeof(GearboxType), gearboxTypeDropdown.Text);
            DetailFactory.CreateGearbox(
                gearboxTitleInput.Text,
                producer,
                new[] { car.Id },
                double.Parse(gearboxPriceInput.Text),
                type,
                int.Parse(gearboxGearsInput.Text)
            );
            MessageBox.Show(@"Gearbox has been successfully added", @"Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void addNewTireBtn_Click(object sender, EventArgs e)
        {
            if (tireTitleInput.Text == "" || tireProducerDropdown.Text == "" || tirePriceInput.Text == "" ||
                tireCarBrandDropdown.Text == "" || tireCarModelDropdown.Text == "")
            {
                MessageBox.Show(@"Fill all inputs!", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            var car = CarController.Instance.FindByBrandAndModel(
                (Brand)Enum.Parse(typeof(Brand), tireCarBrandDropdown.Text), tireCarModelDropdown.Text);
            var producer = (Producer)Enum.Parse(typeof(Producer), tireProducerDropdown.Text);

            DetailFactory.CreateTire(
                tireTitleInput.Text,
                producer,
                new[] { car.Id },
                double.Parse(tirePriceInput.Text)
            );
            MessageBox.Show(@"Tire has been successfully added", @"Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}