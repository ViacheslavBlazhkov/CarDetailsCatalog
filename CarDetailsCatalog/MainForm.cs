using System;
using System.Windows.Forms;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models.Abstracts;
using CarDetailsCatalog.Models.Controllers;
using CarDetailsCatalog.Seeders;
using CarDetailsCatalog.Seeders.Details;

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
                context.Database.Delete();
                context.Database.CreateIfNotExists();
                new CarSeeder(context).Seed();
                new EngineSeeder(context).Seed();
                new GearboxSeeder(context).Seed();
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
            ContentController.GetInstance().CurrentMenu = Constants.Menu.Brands;
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetBrandsView());
        }

        public void ChangeControlToModelsView(object sender, EventArgs e)
        {
            var brand = (Brand)Enum.Parse(typeof(Brand), ((Button)sender).Text);
            ChangeControlToModelsView(brand);
        }

        public void ChangeControlToModelsView(Brand brand)
        {
            toPrevMenuBtn.Show();
            ContentController.GetInstance().CurrentMenu = Constants.Menu.Models;
            ContentController.GetInstance().ChosenBrand = brand;
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetModelsView());
        }

        public void ChangeControlToDetailTypesView(object sender, EventArgs e)
        {
            var model = ((Button)sender).Text;
            ContentController.GetInstance().ChosenModel = model;
            ChangeControlToDetailTypesView();
        }

        public void ChangeControlToDetailTypesView()
        {
            ContentController.GetInstance().CurrentMenu = Constants.Menu.DetailTypes;
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetDetailTypesView());
        }

        public void ChangeControlToDetailsView(object sender, EventArgs e)
        {
            var detailType = (DetailType)Enum.Parse(typeof(DetailType), ((Button)sender).Text);
            ChangeControlToDetailsView(detailType);
        }

        public void ChangeControlToDetailsView(DetailType detailType)
        {
            ContentController.GetInstance().ChosenDetailType = detailType;
            ContentController.GetInstance().CurrentMenu = Constants.Menu.Details;
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetDetailsView());
        }

        public void ChangeControlToDetailInfoView(object sender, EventArgs e)
        {
            var detailText = ((Button)sender).Text;
            ADetail detail;
            switch (ContentController.GetInstance().ChosenDetailType)
            {
                case DetailType.Brakes:
                    detail = EngineController.Instance.FindByName(detailText);
                    break;
                case DetailType.Engine:
                    detail = EngineController.Instance.FindByName(detailText);
                    break;
                case DetailType.Gearbox:
                    detail = GearboxController.Instance.FindByName(detailText);
                    break;
                case DetailType.Tires:
                    detail = EngineController.Instance.FindByName(detailText);
                    break;
                default:
                    throw new Exception("Undefined Detail Type");
            }

            ContentController.GetInstance().ChosenDetail = detail;
            ContentController.GetInstance().CurrentMenu = Constants.Menu.DetailInfo;
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetDetailInfoView());
        }

        private void toPrevMenuBtn_Click(object sender, EventArgs e)
        {
            switch (ContentController.GetInstance().CurrentMenu)
            {
                case Constants.Menu.Brands:
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
            }
        }
    }
}