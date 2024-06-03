using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CarDetailsCatalog.Constants;
using CarDetailsCatalog.Models;
using CarDetailsCatalog.Models.Abstracts;
using CarDetailsCatalog.Models.Controllers;
using Menu = CarDetailsCatalog.Constants.Menu;

namespace CarDetailsCatalog.VisualComponents
{
    public class ContentController
    {
        public Menu CurrentMenu;

        public Brand ChosenBrand;
        public string ChosenModel;
        public DetailType ChosenDetailType;
        public IDetail ChosenDetail;
        private List<string> _detailsToCompare = new List<string>();

        private static ContentController _instance;

        public static ContentController GetInstance() => _instance ?? (_instance = new ContentController());

        public Control GetBrandsView()
        {
            var brands = Enum.GetNames(typeof(Brand));
            var control = GetControlWithButtons(brands, MainForm.GetForm().ChangeControlToModelsView);
            foreach (Button btn in control.Controls.OfType<Button>())
            {
                Brand brand = (Brand)Enum.Parse(typeof(Brand), btn.Text);
                btn.Image = Car.GetImageForBrand(brand);
            }

            return control;
        }

        public Control GetModelsView()
        {
            var models = CarController.Instance.GetModelsByBrandId((int)ChosenBrand);
            var titles = models.OrderBy(car => car.Model).Select(car => car.Model).ToArray();
            var control = GetControlWithButtons(titles, MainForm.GetForm().ChangeControlToDetailTypesView);
            return control;
        }

        public Control GetDetailTypesView()
        {
            var detailTypes = Enum.GetNames(typeof(DetailType));
            var control = GetControlWithButtons(detailTypes, MainForm.GetForm().ChangeControlToDetailsView);
            foreach (Button btn in control.Controls.OfType<Button>())
            {
                DetailType detailType = (DetailType)Enum.Parse(typeof(DetailType), btn.Text);
                btn.Image = ADetail.GetImageForDetailType(detailType);
            }

            return control;
        }

        public Control GetDetailsView()
        {
            _detailsToCompare.Clear();
            List<ADetail> details;
            Car car = CarController.Instance.FindByBrandAndModel(ChosenBrand, ChosenModel);
            switch (ChosenDetailType)
            {
                case DetailType.Brakes:
                    details = new List<ADetail>();
                    break;
                case DetailType.Engine:
                    details = EngineController.Instance.GetAllByCarId(car.Id).ToList<ADetail>();
                    break;
                case DetailType.Gearbox:
                    details = GearboxController.Instance.GetAllByCarId(car.Id).ToList<ADetail>();
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
            foreach (Button btn in control.Controls.OfType<Button>())
            {
                var addBtn = new Button
                {
                    BackColor = Color.DarkSeaGreen,
                    Location = new Point(10, btn.Height - 50),
                    Text = @"+",
                    Size = new Size(40, 40),
                    Tag = btn.Text
                };
                addBtn.Click += AddDetailToCompare;
                btn.Controls.Add(addBtn);
            }

            var comparePanel = GetCompareControlForDetailsView();
            control.Controls.Add(comparePanel);
            comparePanel.Location = new Point(0, control.Height / 2);
            return control;
        }

        public Control GetFoundDetailsView(string title)
        {
            _detailsToCompare.Clear();
            List<ADetail> details = new List<ADetail>();
            details.AddRange(EngineController.Instance.SearchByTitle(title).ToList<ADetail>());
            details.AddRange(GearboxController.Instance.SearchByTitle(title).ToList<ADetail>());

            var titles = details.Select(d => d.Name).ToArray();
            var control = GetControlWithButtons(titles, MainForm.GetForm().ChangeControlToDetailInfoView);
            foreach (Button btn in control.Controls.OfType<Button>())
            {
                var addBtn = new Button
                {
                    BackColor = Color.DarkSeaGreen,
                    Location = new Point(10, btn.Height - 50),
                    Text = @"+",
                    Size = new Size(40, 40),
                    Tag = btn.Text
                };
                addBtn.Click += AddDetailToCompare;
                btn.Controls.Add(addBtn);
            }

            var comparePanel = GetCompareControlForDetailsView();
            control.Controls.Add(comparePanel);
            comparePanel.Location = new Point(0, control.Height / 2);
            return control;
        }

        private Control GetCompareControlForDetailsView()
        {
            var control = new Control
            {
                BackColor = Color.LightGray,
                Height = 100,
                Width = 600,
            };
            control.Controls.Add(new Label
            {
                AccessibleName = @"detailToCompare_0",
                BackColor = Color.DarkSeaGreen,
                Font = new Font("Serif", 12),
                Location = new Point(10, 0),
                Size = new Size(120, 40),
            });
            var removeBtn1 = new Button
            {
                BackColor = Color.DarkSeaGreen,
                Font = new Font("Serif", 12),
                Location = new Point(140, 0),
                Size = new Size(40, 40),
                Text = @"X",
                Tag = "detailToCompare_0"
            };
            removeBtn1.Click += RemoveDetailFromCompare;
            control.Controls.Add(new Label
            {
                AccessibleName = @"detailToCompare_1",
                BackColor = Color.DarkSeaGreen,
                Font = new Font("Serif", 12),
                Location = new Point(220, 0),
                Size = new Size(120, 40),
            });
            var removeBtn2 = new Button
            {
                BackColor = Color.DarkSeaGreen,
                Font = new Font("Serif", 12),
                Location = new Point(350, 0),
                Size = new Size(40, 40),
                Tag = "detailToCompare_1",
                Text = @"X",
            };
            removeBtn2.Click += RemoveDetailFromCompare;
            control.Controls.AddRange(new Control[] { removeBtn1, removeBtn2 });
            var compareBtn = new Button
            {
                AccessibleName = @"compareBtn",
                BackColor = Color.DarkSeaGreen,
                Text = @"Compare",
                Location = new Point(control.Width - 150, 0),
                Size = new Size(100, 40),
                Visible = false
            };
            compareBtn.Click += MainForm.GetForm().ChangeControlToComparingView;
            control.Controls.Add(compareBtn);
            return control;
        }

        public Control GetComparingView()
        {
            var firstDetail = DetailController.Instance.FindByName(_detailsToCompare[0]);
            var secondDetail = DetailController.Instance.FindByName(_detailsToCompare[1]);
            var control = GetControl();
            var paramsWithColors = ADetail.GetParamsWithColors(firstDetail.GetCharacteristics(),
                secondDetail.GetCharacteristics());
            var leftSide = GetControlForDetail(firstDetail, control.Width / 2, control.Height, paramsWithColors[0]);
            var rightSide = GetControlForDetail(secondDetail, control.Width / 2, control.Height, paramsWithColors[1]);
            rightSide.Location = new Point(control.Width / 2, 0);
            control.Controls.AddRange(new[] { leftSide, rightSide });
            return control;
        }

        private Control GetControlForDetail(IDetail detail, int width, int height,
            Dictionary<string, Color> paramsWithColors)
        {
            var distanceY = 100;
            var control = new Control
            {
                Height = height,
                Width = width,
            };
            var detailCharacteristics = detail.GetCharacteristics();
            var header = GetDetailInfoHeader(detailCharacteristics["Title"], control.Width,
                ContentAlignment.MiddleLeft);
            control.Controls.Add(header);
            foreach (var characteristic in detailCharacteristics.Where(c => c.Key != "Title"))
            {
                var color = paramsWithColors.FirstOrDefault(p => p.Key == characteristic.Key).Value;
                control.Controls.Add(new Label
                {
                    BackColor = color,
                    Font = new Font("Serif", 14),
                    Location = new Point(0, distanceY),
                    Size = new Size((int)(control.Width / 1.2), 25),
                    Text = $@"{characteristic.Key}: {characteristic.Value}"
                });
                distanceY += 25;
            }

            return control;
        }

        private void AddDetailToCompare(object sender, EventArgs eventArgs)
        {
            if (_detailsToCompare.Count < 2)
            {
                var elem = ((Button)sender).Tag.ToString();
                Label label1 = (Label)FindControlByAccessibleName(MainForm.GetForm(), "detailToCompare_0");
                Label label2 = (Label)FindControlByAccessibleName(MainForm.GetForm(), "detailToCompare_1");
                if (label1.Text == "")
                {
                    label1.Text = elem;
                }
                else if (label2.Text == "")
                {
                    label2.Text = elem;
                }

                _detailsToCompare.Add(elem);

                if (_detailsToCompare.Count == 2)
                {
                    var compareBtn = (Button)FindControlByAccessibleName(MainForm.GetForm(), "compareBtn");
                    compareBtn.Visible = true;
                }
            }
        }

        private void RemoveDetailFromCompare(object sender, EventArgs eventArgs)
        {
            var label = FindControlByAccessibleName(MainForm.GetForm(), ((Button)sender).Tag.ToString());
            _detailsToCompare.Remove(label.Text);
            label.Text = "";
            var compareBtn = (Button)FindControlByAccessibleName(MainForm.GetForm(), "compareBtn");
            compareBtn.Visible = false;
        }

        public Control GetDetailInfoView() => GetControlWithDetailInfo(ChosenDetail);

        private Control GetControlWithButtons(string[] titles, EventHandler method)
        {
            var control = GetControl();
            int padding = int.Parse((control.Width * 0.01).ToString(CultureInfo.CurrentCulture));
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

        private Control GetControlWithDetailInfo(IDetail detail)
        {
            var control = GetControl();
            int distanceY = 80;

            Dictionary<string, string> detailCharacteristics = detail.GetCharacteristics();
            Image defaultImage = ADetail.GetImageForDetailType(ChosenDetailType, 200, 200);

            control.Controls.Add(GetDetailInfoHeader(detailCharacteristics["Title"]));
            foreach (var characteristic in detailCharacteristics.Where(c => c.Key != "Title"))
            {
                control.Controls.Add(new Label
                {
                    Font = new Font("Serif", 14),
                    Location = new Point(0, distanceY),
                    Size = new Size((int)(control.Width / 1.7), 25),
                    Text = $@"{characteristic.Key}: {characteristic.Value}"
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

        private static Control GetDetailInfoHeader(string title, int width = 600,
            ContentAlignment contAlign = ContentAlignment.MiddleCenter)
        {
            var control = new Control()
            {
                BackColor = Color.White,
                Size = new Size(width, 60),
            };
            control.Controls.Add(new Label
            {
                Font = new Font("Serif", 18, FontStyle.Bold),
                Size = new Size(590, 55),
                Text = title,
                TextAlign = contAlign
            });
            return control;
        }

        private Control GetControl()
        {
            return new Control
            {
                BackColor = Color.Pink,
                Size = new Size(600, 500),
            };
        }

        private Button GetListItem(string text)
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

        private Control FindControlByAccessibleName(Control parent, string accessibleName)
        {
            if (parent.AccessibleName == accessibleName)
            {
                return parent;
            }

            foreach (Control child in parent.Controls)
            {
                Control foundControl = FindControlByAccessibleName(child, accessibleName);
                if (foundControl != null)
                {
                    return foundControl;
                }
            }

            return null;
        }
    }
}