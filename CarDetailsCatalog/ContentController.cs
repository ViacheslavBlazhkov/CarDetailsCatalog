using System;
using System.Drawing;
using System.Windows.Forms;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models.Controllers;

namespace CarDetailsCatalog
{
    public class ContentController
    {
        private static ContentController _instance;

        private ContentController()
        {
        }

        public static ContentController GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ContentController();
            }

            return _instance;
        }

        public Control GetBrandsView()
        {
            var control = GetControl();
            int distance = 0;
            foreach (var car in (Brand[])Enum.GetValues(typeof(Brand)))
            {
                var listItem = GetListItem(car.ToString());
                listItem.Location = new Point(0, distance);
                listItem.Click += MainForm.GetForm().ChangeControlToModelsView;
                control.Controls.Add(listItem);
                distance += 40;
            }

            return control;
        }

        public Control GetModelsView(int brandId)
        {
            var control = GetControl();
            int distance = 0;
            foreach (var car in CarController.GetModelsByBrandId(brandId))
            {
                var listItem = GetListItem(car.Model);
                listItem.Location = new Point(0, distance);
                control.Controls.Add(listItem);
                distance += 40;
            }

            return control;
        }

        public Control GetControl()
        {
            return new Control
            {
                Size = new Size(600, 500),
                BackColor = Color.Pink,
                Location = new Point(0, 0)
            };
        }

        public Button GetListItem(string text)
        {
            return new Button
            {
                Text = text,
                Size = new Size(100, 30),
                BackColor = Color.LightGray,
                Location = new Point(0, 0)
            };
        }
    }
}