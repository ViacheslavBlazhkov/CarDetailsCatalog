using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models;
using CarDetailsCatalog.Models.Abstracts;
using CarDetailsCatalog.Models.Controllers;
using Menu = CarDetailsCatalog.Constants.Menu;

namespace CarDetailsCatalog
{
    public class ContentController
    {
        public Menu CurrentMenu;

        public Brand ChosenBrand;
        public string ChosenModel;
        public DetailType ChosenDetailType;

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
                distance += 80;
            }

            return control;
        }

        public Control GetModelsView()
        {
            var control = GetControl();
            int distance = 0;
            foreach (var car in CarController.Instance.GetModelsByBrandId((int)ChosenBrand))
            {
                var listItem = GetListItem(car.Model);
                listItem.Location = new Point(0, distance);
                listItem.Click += MainForm.GetForm().ChangeControlToDetailTypesView;
                control.Controls.Add(listItem);
                distance += 80;
            }

            return control;
        }

        public Control GetDetailTypesView()
        {
            var control = GetControl();
            int distance = 0;
            foreach (var detailType in (DetailType[])Enum.GetValues(typeof(DetailType)))
            {
                var listItem = GetListItem(detailType.ToString());
                listItem.Location = new Point(0, distance);
                listItem.Click += MainForm.GetForm().ChangeControlToDetailsView;
                control.Controls.Add(listItem);
                distance += 80;
            }

            return control;
        }

        public Control GetDetailsView()
        {
            var control = GetControl();
            var detailType = ChosenDetailType;
            List<ADetail> details = null;
            Car car = CarController.Instance.FindByBrandAndModel(ChosenBrand, ChosenModel);
            switch (ChosenDetailType) // TODO: add other details
            {
                case DetailType.Brakes:
                    details = new List<ADetail>();
                    break;
                case DetailType.Engine:
                    details = EngineController.Instance.GetAllByCarId(car.Id).ToList<ADetail>();
                    break;
                case DetailType.Gearbox:
                    details = new List<ADetail>();
                    break;
                case DetailType.Tires:
                    details = new List<ADetail>();
                    break;
            }

            int distance = 0;
            foreach (var detail in details)
            {
                var listItem = GetListItem(detail.Name);
                listItem.Location = new Point(0, distance);
                control.Controls.Add(listItem);
                distance += 80;
            }

            return control;
        }

        public Control GetControl() // TODO: stylized this
        {
            return new Control
            {
                BackColor = Color.Pink,
                Padding = new Padding(20),
                Size = new Size(600, 500),
            };
        }

        public Button GetListItem(string text) // TODO: stylized this
        {
            return new Button
            {
                BackColor = Color.LightGray,
                Font = new Font("Serif", 24),
                Location = new Point(0, 0),
                Size = new Size(200, 70),
                Text = text,
            };
        }
    }
}