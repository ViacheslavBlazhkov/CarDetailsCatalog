using System;
using System.Windows.Forms;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Exceptions;
using CarDetailsCatalog.Models.Abstracts;
using CarDetailsCatalog.Models.Controllers;
using CarDetailsCatalog.VisualComponents;

namespace CarDetailsCatalog
{
    public partial class MainForm : Form
    {
        private static MainForm _form;

        public MainForm()
        {
            _form = this;
            InitializeComponent();
            using (var context = new AppDbContext())
            {
                context.Database.Initialize(false);
                context.Database.CreateIfNotExists();
            }

            contentControl.Controls.Add(ContentController.GetInstance().GetBrandsView());
        }

        public static MainForm GetForm()
        {
            if (_form == null)
            {
                throw new Exception("Main form is absent");
            }

            return _form;
        }


        public void ChangeControlToBrandsView()
        {
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetBrandsView());
            ContentController.GetInstance().CurrentMenu = Constants.Menu.Brands;
        }

        public void ChangeControlToModelsView(object sender, EventArgs e)
        {
            var brand = (Brand)Enum.Parse(typeof(Brand), ((Button)sender).Text);
            ChangeControlToModelsView(brand);
        }

        public void ChangeControlToModelsView(Brand brand)
        {
            toPrevMenuBtn.Show();
            ContentController.GetInstance().ChosenBrand = brand;
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetModelsView());
            ContentController.GetInstance().CurrentMenu = Constants.Menu.Models;
        }

        public void ChangeControlToDetailTypesView(object sender, EventArgs e)
        {
            var model = ((Button)sender).Text;
            ContentController.GetInstance().ChosenModel = model;
            ChangeControlToDetailTypesView();
        }

        public void ChangeControlToDetailTypesView()
        {
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetDetailTypesView());
            ContentController.GetInstance().CurrentMenu = Constants.Menu.DetailTypes;
        }

        public void ChangeControlToDetailsView(object sender, EventArgs e)
        {
            var detailType = (DetailType)Enum.Parse(typeof(DetailType), ((Button)sender).Text);
            ChangeControlToDetailsView(detailType);
        }

        public void ChangeControlToDetailsView(DetailType detailType)
        {
            ContentController.GetInstance().ChosenDetailType = detailType;
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetDetailsView());
            ContentController.GetInstance().CurrentMenu = Constants.Menu.Details;
        }

        public void ChangeControlToFoundDetailsView(string title)
        {
            toPrevMenuBtn.Show();
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetFoundDetailsView(title));
            ContentController.GetInstance().CurrentMenu = Constants.Menu.Search;
        }

        public void ChangeControlToDetailInfoView(object sender, EventArgs e)
        {
            var detailText = ((Button)sender).Text;
            IDetail detail = DetailController.Instance.FindByName(detailText);
            ContentController.GetInstance().ChosenDetail = detail;
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetDetailInfoView());
            ContentController.GetInstance().CurrentMenu = Constants.Menu.DetailInfo;
        }

        public void ChangeControlToComparingView(object sender, EventArgs e)
        {
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetComparingView());
            ContentController.GetInstance().CurrentMenu = Constants.Menu.Comparing;
        }

        private void toPrevMenuBtn_Click(object sender, EventArgs e)
        {
            switch (ContentController.GetInstance().CurrentMenu)
            {
                case Constants.Menu.Brands:
                    break;
                case Constants.Menu.Search:
                    findInput.Clear();
                    toPrevMenuBtn.Hide();
                    ChangeControlToBrandsView();
                    break;
                case Constants.Menu.Models:
                    toPrevMenuBtn.Hide();
                    ChangeControlToBrandsView();
                    break;
                case Constants.Menu.DetailTypes:
                    ChangeControlToModelsView(ContentController.GetInstance().ChosenBrand);
                    break;
                case Constants.Menu.Details:
                    ChangeControlToDetailTypesView();
                    break;
                case Constants.Menu.DetailInfo:
                    ChangeControlToDetailsView(ContentController.GetInstance().ChosenDetailType);
                    break;
                case Constants.Menu.Comparing:
                    ChangeControlToDetailsView(ContentController.GetInstance().ChosenDetailType);
                    break;
                default:
                    throw new UnknownMenuException();
            }
        }

        private void adminPanelBtn_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminPanelForm = new AdminPanelForm();
            adminPanelForm.Show();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (findInput.Text != String.Empty)
            {
                ChangeControlToFoundDetailsView(findInput.Text);
            }
            else
            {
                MessageBox.Show("Enter some text, please", "Empty input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}