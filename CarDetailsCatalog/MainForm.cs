using System;
using System.Windows.Forms;
using CarDetailsCatalog.Constants;

namespace CarDetailsCatalog
{
    public partial class MainForm : Form
    {
        private static MainForm _form;

        public MainForm()
        {
            _form = this;
            InitializeComponent();
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

        public void ChangeControlToModelsView(object sender, EventArgs e)
        {
            var chosenBrand = ((Button)sender).Text;
            var brand = (Brand)Enum.Parse(typeof(Brand), chosenBrand);
            contentControl.Controls.Clear();
            contentControl.Controls.Add(ContentController.GetInstance().GetModelsView((int)brand));
        }
    }
}