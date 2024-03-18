using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models;
using CarDetailsCatalog.Models.Abstracts;
using CarDetailsCatalog.Models.Controllers;
using CarDetailsCatalog.Models.Details;
using Menu = CarDetailsCatalog.Constants.Menu;

namespace CarDetailsCatalog
{
    public class ContentController
    {
        public Menu CurrentMenu;

        public Brand ChosenBrand;
        public string ChosenModel;
        public DetailType ChosenDetailType;
        public ADetail ChosenDetail;

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
            var brands = Enum.GetNames(typeof(Brand));
            var control = GetControlWithButtons(brands, MainForm.GetForm().ChangeControlToModelsView);
            foreach (Button btn in control.Controls)
            {
                Brand brand = (Brand)Enum.Parse(typeof(Brand), btn.Text);
                btn.Image = Car.GetImageForBrand(brand);
            }

            return control;
        }

        public Control GetModelsView()
        {
            var models = CarController.Instance.GetModelsByBrandId((int)ChosenBrand);
            var titles = models.Select(car => car.Model).ToArray();
            var control = GetControlWithButtons(titles, MainForm.GetForm().ChangeControlToDetailTypesView);
            return control;
        }

        public Control GetDetailTypesView()
        {
            var detailTypes = Enum.GetNames(typeof(DetailType));
            var control = GetControlWithButtons(detailTypes, MainForm.GetForm().ChangeControlToDetailsView);
            foreach (Button btn in control.Controls)
            {
                DetailType detailType = (DetailType)Enum.Parse(typeof(DetailType), btn.Text);
                btn.Image = ADetail.GetImageForDetailType(detailType);
            }

            return control;
        }

        public Control GetDetailsView()
        {
            List<ADetail> details;
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
                default:
                    details = new List<ADetail>();
                    break;
            }

            var titles = details.Select(d => d.Name).ToArray();
            var control = GetControlWithButtons(titles, MainForm.GetForm().ChangeControlToDetailInfoView);
            return control;
        }

        public Control GetDetailInfoView()
        {
            return GetControlWithDetailInfo(ChosenDetail);
        }

        private Control GetControlWithButtons(string[] titles, EventHandler method)
        {
            var control = GetControl();
            int padding = int.Parse((control.Width * 0.01).ToString());
            int distanceX = padding;
            int distanceY = 5;
            int columnSpacing = 20;

            foreach (var item in titles)
            {
                var listItem = GetListItem(item);
                listItem.Location = new Point(distanceX, distanceY);
                listItem.Click += method;
                control.Controls.Add(listItem);
                distanceX += listItem.Width + columnSpacing;
                if (distanceX + listItem.Width - 100 > control.Width)
                {
                    distanceX = padding;
                    distanceY += listItem.Height + columnSpacing;
                }
            }

            return control;
        }

        private Control GetControlWithDetailInfo(ADetail detail)
        {
            var control = GetControl();
            int distanceY = 80;

            Dictionary<string, string> detailCharacteristics;
            Image defaultImage = ADetail.GetImageForDetailType(ChosenDetailType, 200, 200);
            switch (ChosenDetailType)
            {
                case DetailType.Brakes:
                    detailCharacteristics = detail.GetCharacteristics();
                    break;
                case DetailType.Engine:
                    detailCharacteristics = ((Engine)detail).GetCharacteristics();
                    break;
                case DetailType.Gearbox:
                    detailCharacteristics = detail.GetCharacteristics();
                    break;
                case DetailType.Tires:
                    detailCharacteristics = detail.GetCharacteristics();
                    break;
                default:
                    detailCharacteristics = detail.GetCharacteristics();
                    break;
            }

            control.Controls.Add(GetDetailInfoHeader(detailCharacteristics["Назва"]));
            foreach (var characteristic in detailCharacteristics.Where(c => c.Key != "Назва"))
            {
                control.Controls.Add(new Label
                {
                    Font = new Font("Serif", 14),
                    Location = new Point(0, distanceY),
                    Size = new Size((int)(control.Width / 1.7), 25),
                    Text = $"{characteristic.Key}: {characteristic.Value}"
                });
                distanceY += 25;
            }

            control.Controls.Add(new PictureBox
            {
                Image = defaultImage,
                Location = new Point((int)(control.Width / 1.7), 80),
                Size = new Size(200, 200)
            });
            return control;
        }

        private static Control GetDetailInfoHeader(string title)
        {
            var control = new Control()
            {
                BackColor = Color.White,
                Size = new Size(600, 60),
            };
            control.Controls.Add(new Label
            {
                Font = new Font("Serif", 18, FontStyle.Bold),
                Size = new Size(590, 55),
                Text = title,
                TextAlign = ContentAlignment.MiddleCenter
            });
            return control;
        }

        public Control GetControl()
        {
            return new Control
            {
                BackColor = Color.Pink,
                Size = new Size(600, 500),
            };
        }

        public Button GetListItem(string text)
        {
            return new Button
            {
                Cursor = Cursors.Hand,
                BackColor = Color.LightGray,
                Font = new Font("Serif", 24),
                Size = new Size(260, 100),
                Text = text,
                ImageAlign = ContentAlignment.MiddleLeft,
                TextAlign = ContentAlignment.MiddleRight
            };
        }
    }
}