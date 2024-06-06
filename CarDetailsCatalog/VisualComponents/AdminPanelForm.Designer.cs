using System.ComponentModel;

namespace CarDetailsCatalog.VisualComponents
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addNewCarTab = new System.Windows.Forms.TabPage();
            this.addCarButton = new System.Windows.Forms.Button();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearInput = new System.Windows.Forms.NumericUpDown();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandDropdown = new System.Windows.Forms.ComboBox();
            this.addNewDetailTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.brakesTab = new System.Windows.Forms.TabPage();
            this.brakesCarModelDropdown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brakesCarBrandDropdown = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.brakesTitleInput = new System.Windows.Forms.TextBox();
            this.brakesProducerDropdown = new System.Windows.Forms.ComboBox();
            this.addNewBrakesBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.brakesPriceInput = new System.Windows.Forms.NumericUpDown();
            this.engineTab = new System.Windows.Forms.TabPage();
            this.engineModelSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.engineCarBrandSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.engineFuelCInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.engineTorqueInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.engineHPInput = new System.Windows.Forms.NumericUpDown();
            this.producerLabel = new System.Windows.Forms.Label();
            this.engineNameInput = new System.Windows.Forms.TextBox();
            this.engineProducerDropdown = new System.Windows.Forms.ComboBox();
            this.addNewEngineBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.enginePriceInput = new System.Windows.Forms.NumericUpDown();
            this.gearboxTab = new System.Windows.Forms.TabPage();
            this.gearboxTypeDropdown = new System.Windows.Forms.ComboBox();
            this.gearboxCarModelDropdown = new System.Windows.Forms.ComboBox();
            this.gearboxCarBrandDropdown = new System.Windows.Forms.ComboBox();
            this.gearboxGearsInput = new System.Windows.Forms.NumericUpDown();
            this.gearboxTitleInput = new System.Windows.Forms.TextBox();
            this.gearboxProducerDropdown = new System.Windows.Forms.ComboBox();
            this.addNewGearboxBtn = new System.Windows.Forms.Button();
            this.gearboxPriceInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tireTab = new System.Windows.Forms.TabPage();
            this.tireCarModelDropdown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tireCarBrandDropdown = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tireTitleInput = new System.Windows.Forms.TextBox();
            this.tireProducerDropdown = new System.Windows.Forms.ComboBox();
            this.addNewTireBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tirePriceInput = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.addNewCarTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).BeginInit();
            this.addNewDetailTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.brakesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brakesPriceInput)).BeginInit();
            this.engineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.engineFuelCInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineTorqueInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineHPInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginePriceInput)).BeginInit();
            this.gearboxTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gearboxGearsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearboxPriceInput)).BeginInit();
            this.tireTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tirePriceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addNewCarTab);
            this.tabControl1.Controls.Add(this.addNewDetailTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // addNewCarTab
            // 
            this.addNewCarTab.Controls.Add(this.addCarButton);
            this.addNewCarTab.Controls.Add(this.yearLabel);
            this.addNewCarTab.Controls.Add(this.yearInput);
            this.addNewCarTab.Controls.Add(this.modelLabel);
            this.addNewCarTab.Controls.Add(this.modelTextBox);
            this.addNewCarTab.Controls.Add(this.brandLabel);
            this.addNewCarTab.Controls.Add(this.brandDropdown);
            this.addNewCarTab.Location = new System.Drawing.Point(4, 25);
            this.addNewCarTab.Name = "addNewCarTab";
            this.addNewCarTab.Padding = new System.Windows.Forms.Padding(3);
            this.addNewCarTab.Size = new System.Drawing.Size(792, 421);
            this.addNewCarTab.TabIndex = 0;
            this.addNewCarTab.Text = "Add new Car";
            this.addNewCarTab.UseVisualStyleBackColor = true;
            // 
            // addCarButton
            // 
            this.addCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarButton.Location = new System.Drawing.Point(23, 338);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(191, 53);
            this.addCarButton.TabIndex = 8;
            this.addCarButton.Text = "Add";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(23, 215);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(100, 23);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Year:";
            // 
            // yearInput
            // 
            this.yearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearInput.Location = new System.Drawing.Point(23, 241);
            this.yearInput.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            this.yearInput.Minimum = new decimal(new int[] { 1800, 0, 0, 0 });
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(276, 45);
            this.yearInput.TabIndex = 6;
            this.yearInput.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // modelLabel
            // 
            this.modelLabel.Location = new System.Drawing.Point(23, 127);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(100, 23);
            this.modelLabel.TabIndex = 5;
            this.modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelTextBox.Location = new System.Drawing.Point(23, 153);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(276, 45);
            this.modelTextBox.TabIndex = 4;
            // 
            // brandLabel
            // 
            this.brandLabel.Location = new System.Drawing.Point(23, 44);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(100, 23);
            this.brandLabel.TabIndex = 2;
            this.brandLabel.Text = "Brand:";
            // 
            // brandDropdown
            // 
            this.brandDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandDropdown.FormattingEnabled = true;
            this.brandDropdown.Location = new System.Drawing.Point(23, 70);
            this.brandDropdown.Name = "brandDropdown";
            this.brandDropdown.Size = new System.Drawing.Size(276, 46);
            this.brandDropdown.Sorted = true;
            this.brandDropdown.TabIndex = 0;
            // 
            // addNewDetailTab
            // 
            this.addNewDetailTab.Controls.Add(this.tabControl2);
            this.addNewDetailTab.Location = new System.Drawing.Point(4, 25);
            this.addNewDetailTab.Name = "addNewDetailTab";
            this.addNewDetailTab.Padding = new System.Windows.Forms.Padding(3);
            this.addNewDetailTab.Size = new System.Drawing.Size(792, 421);
            this.addNewDetailTab.TabIndex = 1;
            this.addNewDetailTab.Text = "Add new Detail";
            this.addNewDetailTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.brakesTab);
            this.tabControl2.Controls.Add(this.engineTab);
            this.tabControl2.Controls.Add(this.gearboxTab);
            this.tabControl2.Controls.Add(this.tireTab);
            this.tabControl2.Location = new System.Drawing.Point(-4, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(800, 425);
            this.tabControl2.TabIndex = 18;
            // 
            // brakesTab
            // 
            this.brakesTab.Controls.Add(this.brakesCarModelDropdown);
            this.brakesTab.Controls.Add(this.label5);
            this.brakesTab.Controls.Add(this.brakesCarBrandDropdown);
            this.brakesTab.Controls.Add(this.label9);
            this.brakesTab.Controls.Add(this.brakesTitleInput);
            this.brakesTab.Controls.Add(this.brakesProducerDropdown);
            this.brakesTab.Controls.Add(this.addNewBrakesBtn);
            this.brakesTab.Controls.Add(this.label10);
            this.brakesTab.Controls.Add(this.label11);
            this.brakesTab.Controls.Add(this.brakesPriceInput);
            this.brakesTab.Location = new System.Drawing.Point(4, 25);
            this.brakesTab.Name = "brakesTab";
            this.brakesTab.Size = new System.Drawing.Size(792, 396);
            this.brakesTab.TabIndex = 2;
            this.brakesTab.Text = "Brakes";
            this.brakesTab.UseVisualStyleBackColor = true;
            // 
            // brakesCarModelDropdown
            // 
            this.brakesCarModelDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brakesCarModelDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brakesCarModelDropdown.FormattingEnabled = true;
            this.brakesCarModelDropdown.Location = new System.Drawing.Point(507, 326);
            this.brakesCarModelDropdown.Name = "brakesCarModelDropdown";
            this.brakesCarModelDropdown.Size = new System.Drawing.Size(276, 46);
            this.brakesCarModelDropdown.Sorted = true;
            this.brakesCarModelDropdown.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(401, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Suitable Car:";
            // 
            // brakesCarBrandDropdown
            // 
            this.brakesCarBrandDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brakesCarBrandDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brakesCarBrandDropdown.FormattingEnabled = true;
            this.brakesCarBrandDropdown.Location = new System.Drawing.Point(225, 326);
            this.brakesCarBrandDropdown.Name = "brakesCarBrandDropdown";
            this.brakesCarBrandDropdown.Size = new System.Drawing.Size(276, 46);
            this.brakesCarBrandDropdown.Sorted = true;
            this.brakesCarBrandDropdown.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Producer:";
            // 
            // brakesTitleInput
            // 
            this.brakesTitleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brakesTitleInput.Location = new System.Drawing.Point(12, 48);
            this.brakesTitleInput.Name = "brakesTitleInput";
            this.brakesTitleInput.Size = new System.Drawing.Size(276, 45);
            this.brakesTitleInput.TabIndex = 27;
            // 
            // brakesProducerDropdown
            // 
            this.brakesProducerDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brakesProducerDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brakesProducerDropdown.FormattingEnabled = true;
            this.brakesProducerDropdown.Location = new System.Drawing.Point(12, 144);
            this.brakesProducerDropdown.Name = "brakesProducerDropdown";
            this.brakesProducerDropdown.Size = new System.Drawing.Size(276, 46);
            this.brakesProducerDropdown.Sorted = true;
            this.brakesProducerDropdown.TabIndex = 32;
            // 
            // addNewBrakesBtn
            // 
            this.addNewBrakesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewBrakesBtn.Location = new System.Drawing.Point(12, 322);
            this.addNewBrakesBtn.Name = "addNewBrakesBtn";
            this.addNewBrakesBtn.Size = new System.Drawing.Size(191, 53);
            this.addNewBrakesBtn.TabIndex = 31;
            this.addNewBrakesBtn.Text = "Add";
            this.addNewBrakesBtn.UseVisualStyleBackColor = true;
            this.addNewBrakesBtn.Click += new System.EventHandler(this.addNewBrakesBtn_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(10, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 28;
            this.label10.Text = "Title:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Price:";
            // 
            // brakesPriceInput
            // 
            this.brakesPriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brakesPriceInput.Location = new System.Drawing.Point(12, 241);
            this.brakesPriceInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.brakesPriceInput.Name = "brakesPriceInput";
            this.brakesPriceInput.Size = new System.Drawing.Size(276, 45);
            this.brakesPriceInput.TabIndex = 29;
            this.brakesPriceInput.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // engineTab
            // 
            this.engineTab.Controls.Add(this.engineModelSelect);
            this.engineTab.Controls.Add(this.label4);
            this.engineTab.Controls.Add(this.engineCarBrandSelect);
            this.engineTab.Controls.Add(this.label3);
            this.engineTab.Controls.Add(this.engineFuelCInput);
            this.engineTab.Controls.Add(this.label2);
            this.engineTab.Controls.Add(this.engineTorqueInput);
            this.engineTab.Controls.Add(this.label1);
            this.engineTab.Controls.Add(this.engineHPInput);
            this.engineTab.Controls.Add(this.producerLabel);
            this.engineTab.Controls.Add(this.engineNameInput);
            this.engineTab.Controls.Add(this.engineProducerDropdown);
            this.engineTab.Controls.Add(this.addNewEngineBtn);
            this.engineTab.Controls.Add(this.titleLabel);
            this.engineTab.Controls.Add(this.priceLabel);
            this.engineTab.Controls.Add(this.enginePriceInput);
            this.engineTab.Location = new System.Drawing.Point(4, 25);
            this.engineTab.Name = "engineTab";
            this.engineTab.Padding = new System.Windows.Forms.Padding(3);
            this.engineTab.Size = new System.Drawing.Size(792, 396);
            this.engineTab.TabIndex = 0;
            this.engineTab.Text = "Engine";
            this.engineTab.UseVisualStyleBackColor = true;
            // 
            // engineModelSelect
            // 
            this.engineModelSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.engineModelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineModelSelect.FormattingEnabled = true;
            this.engineModelSelect.Location = new System.Drawing.Point(503, 337);
            this.engineModelSelect.Name = "engineModelSelect";
            this.engineModelSelect.Size = new System.Drawing.Size(276, 46);
            this.engineModelSelect.Sorted = true;
            this.engineModelSelect.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(397, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Suitable Car:";
            // 
            // engineCarBrandSelect
            // 
            this.engineCarBrandSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.engineCarBrandSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineCarBrandSelect.FormattingEnabled = true;
            this.engineCarBrandSelect.Location = new System.Drawing.Point(221, 337);
            this.engineCarBrandSelect.Name = "engineCarBrandSelect";
            this.engineCarBrandSelect.Size = new System.Drawing.Size(276, 46);
            this.engineCarBrandSelect.Sorted = true;
            this.engineCarBrandSelect.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(397, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fuel Consumption:";
            // 
            // engineFuelCInput
            // 
            this.engineFuelCInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineFuelCInput.Location = new System.Drawing.Point(397, 252);
            this.engineFuelCInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.engineFuelCInput.Name = "engineFuelCInput";
            this.engineFuelCInput.Size = new System.Drawing.Size(276, 45);
            this.engineFuelCInput.TabIndex = 22;
            this.engineFuelCInput.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(397, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Torque:";
            // 
            // engineTorqueInput
            // 
            this.engineTorqueInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineTorqueInput.Location = new System.Drawing.Point(397, 155);
            this.engineTorqueInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.engineTorqueInput.Name = "engineTorqueInput";
            this.engineTorqueInput.Size = new System.Drawing.Size(276, 45);
            this.engineTorqueInput.TabIndex = 20;
            this.engineTorqueInput.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(397, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Horse Power:";
            // 
            // engineHPInput
            // 
            this.engineHPInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineHPInput.Location = new System.Drawing.Point(397, 59);
            this.engineHPInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.engineHPInput.Name = "engineHPInput";
            this.engineHPInput.Size = new System.Drawing.Size(276, 45);
            this.engineHPInput.TabIndex = 18;
            this.engineHPInput.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // producerLabel
            // 
            this.producerLabel.Location = new System.Drawing.Point(8, 129);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(100, 23);
            this.producerLabel.TabIndex = 17;
            this.producerLabel.Text = "Producer:";
            // 
            // engineNameInput
            // 
            this.engineNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineNameInput.Location = new System.Drawing.Point(8, 59);
            this.engineNameInput.Name = "engineNameInput";
            this.engineNameInput.Size = new System.Drawing.Size(276, 45);
            this.engineNameInput.TabIndex = 11;
            // 
            // engineProducerDropdown
            // 
            this.engineProducerDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.engineProducerDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineProducerDropdown.FormattingEnabled = true;
            this.engineProducerDropdown.Location = new System.Drawing.Point(8, 155);
            this.engineProducerDropdown.Name = "engineProducerDropdown";
            this.engineProducerDropdown.Size = new System.Drawing.Size(276, 46);
            this.engineProducerDropdown.Sorted = true;
            this.engineProducerDropdown.TabIndex = 16;
            // 
            // addNewEngineBtn
            // 
            this.addNewEngineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewEngineBtn.Location = new System.Drawing.Point(8, 333);
            this.addNewEngineBtn.Name = "addNewEngineBtn";
            this.addNewEngineBtn.Size = new System.Drawing.Size(191, 53);
            this.addNewEngineBtn.TabIndex = 15;
            this.addNewEngineBtn.Text = "Add";
            this.addNewEngineBtn.UseVisualStyleBackColor = true;
            this.addNewEngineBtn.Click += new System.EventHandler(this.addNewEngineBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(6, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(100, 23);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Title:";
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(8, 226);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 23);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Price:";
            // 
            // enginePriceInput
            // 
            this.enginePriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enginePriceInput.Location = new System.Drawing.Point(8, 252);
            this.enginePriceInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.enginePriceInput.Name = "enginePriceInput";
            this.enginePriceInput.Size = new System.Drawing.Size(276, 45);
            this.enginePriceInput.TabIndex = 13;
            this.enginePriceInput.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // gearboxTab
            // 
            this.gearboxTab.Controls.Add(this.gearboxTypeDropdown);
            this.gearboxTab.Controls.Add(this.gearboxCarModelDropdown);
            this.gearboxTab.Controls.Add(this.gearboxCarBrandDropdown);
            this.gearboxTab.Controls.Add(this.gearboxGearsInput);
            this.gearboxTab.Controls.Add(this.gearboxTitleInput);
            this.gearboxTab.Controls.Add(this.gearboxProducerDropdown);
            this.gearboxTab.Controls.Add(this.addNewGearboxBtn);
            this.gearboxTab.Controls.Add(this.gearboxPriceInput);
            this.gearboxTab.Controls.Add(this.label6);
            this.gearboxTab.Controls.Add(this.label8);
            this.gearboxTab.Controls.Add(this.label12);
            this.gearboxTab.Controls.Add(this.label13);
            this.gearboxTab.Controls.Add(this.label14);
            this.gearboxTab.Controls.Add(this.label15);
            this.gearboxTab.Location = new System.Drawing.Point(4, 25);
            this.gearboxTab.Name = "gearboxTab";
            this.gearboxTab.Padding = new System.Windows.Forms.Padding(3);
            this.gearboxTab.Size = new System.Drawing.Size(792, 396);
            this.gearboxTab.TabIndex = 1;
            this.gearboxTab.Text = "Gearbox";
            this.gearboxTab.UseVisualStyleBackColor = true;
            // 
            // gearboxTypeDropdown
            // 
            this.gearboxTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gearboxTypeDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gearboxTypeDropdown.FormattingEnabled = true;
            this.gearboxTypeDropdown.Location = new System.Drawing.Point(401, 48);
            this.gearboxTypeDropdown.Name = "gearboxTypeDropdown";
            this.gearboxTypeDropdown.Size = new System.Drawing.Size(276, 46);
            this.gearboxTypeDropdown.Sorted = true;
            this.gearboxTypeDropdown.TabIndex = 50;
            // 
            // gearboxCarModelDropdown
            // 
            this.gearboxCarModelDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gearboxCarModelDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gearboxCarModelDropdown.FormattingEnabled = true;
            this.gearboxCarModelDropdown.Location = new System.Drawing.Point(507, 326);
            this.gearboxCarModelDropdown.Name = "gearboxCarModelDropdown";
            this.gearboxCarModelDropdown.Size = new System.Drawing.Size(276, 46);
            this.gearboxCarModelDropdown.Sorted = true;
            this.gearboxCarModelDropdown.TabIndex = 49;
            // 
            // gearboxCarBrandDropdown
            // 
            this.gearboxCarBrandDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gearboxCarBrandDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gearboxCarBrandDropdown.FormattingEnabled = true;
            this.gearboxCarBrandDropdown.Location = new System.Drawing.Point(225, 326);
            this.gearboxCarBrandDropdown.Name = "gearboxCarBrandDropdown";
            this.gearboxCarBrandDropdown.Size = new System.Drawing.Size(276, 46);
            this.gearboxCarBrandDropdown.Sorted = true;
            this.gearboxCarBrandDropdown.TabIndex = 48;
            // 
            // gearboxGearsInput
            // 
            this.gearboxGearsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gearboxGearsInput.Location = new System.Drawing.Point(401, 144);
            this.gearboxGearsInput.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.gearboxGearsInput.Name = "gearboxGearsInput";
            this.gearboxGearsInput.Size = new System.Drawing.Size(276, 45);
            this.gearboxGearsInput.TabIndex = 47;
            this.gearboxGearsInput.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // gearboxTitleInput
            // 
            this.gearboxTitleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gearboxTitleInput.Location = new System.Drawing.Point(12, 48);
            this.gearboxTitleInput.Name = "gearboxTitleInput";
            this.gearboxTitleInput.Size = new System.Drawing.Size(276, 45);
            this.gearboxTitleInput.TabIndex = 42;
            // 
            // gearboxProducerDropdown
            // 
            this.gearboxProducerDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gearboxProducerDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gearboxProducerDropdown.FormattingEnabled = true;
            this.gearboxProducerDropdown.Location = new System.Drawing.Point(12, 144);
            this.gearboxProducerDropdown.Name = "gearboxProducerDropdown";
            this.gearboxProducerDropdown.Size = new System.Drawing.Size(276, 46);
            this.gearboxProducerDropdown.Sorted = true;
            this.gearboxProducerDropdown.TabIndex = 45;
            // 
            // addNewGearboxBtn
            // 
            this.addNewGearboxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewGearboxBtn.Location = new System.Drawing.Point(12, 322);
            this.addNewGearboxBtn.Name = "addNewGearboxBtn";
            this.addNewGearboxBtn.Size = new System.Drawing.Size(191, 53);
            this.addNewGearboxBtn.TabIndex = 44;
            this.addNewGearboxBtn.Text = "Add";
            this.addNewGearboxBtn.UseVisualStyleBackColor = true;
            this.addNewGearboxBtn.Click += new System.EventHandler(this.addNewGearboxBtn_Click);
            // 
            // gearboxPriceInput
            // 
            this.gearboxPriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gearboxPriceInput.Location = new System.Drawing.Point(12, 241);
            this.gearboxPriceInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.gearboxPriceInput.Name = "gearboxPriceInput";
            this.gearboxPriceInput.Size = new System.Drawing.Size(276, 45);
            this.gearboxPriceInput.TabIndex = 43;
            this.gearboxPriceInput.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(401, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Suitable Car:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(401, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 37;
            this.label8.Text = "Gears:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(401, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 35;
            this.label12.Text = "Type:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 33;
            this.label13.Text = "Producer:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(10, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "Title:";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(12, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 30;
            this.label15.Text = "Price:";
            // 
            // tireTab
            // 
            this.tireTab.Controls.Add(this.tireCarModelDropdown);
            this.tireTab.Controls.Add(this.label7);
            this.tireTab.Controls.Add(this.tireCarBrandDropdown);
            this.tireTab.Controls.Add(this.label16);
            this.tireTab.Controls.Add(this.tireTitleInput);
            this.tireTab.Controls.Add(this.tireProducerDropdown);
            this.tireTab.Controls.Add(this.addNewTireBtn);
            this.tireTab.Controls.Add(this.label17);
            this.tireTab.Controls.Add(this.label18);
            this.tireTab.Controls.Add(this.tirePriceInput);
            this.tireTab.Location = new System.Drawing.Point(4, 25);
            this.tireTab.Name = "tireTab";
            this.tireTab.Size = new System.Drawing.Size(792, 396);
            this.tireTab.TabIndex = 3;
            this.tireTab.Text = "Tire";
            this.tireTab.UseVisualStyleBackColor = true;
            // 
            // tireCarModelDropdown
            // 
            this.tireCarModelDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tireCarModelDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireCarModelDropdown.FormattingEnabled = true;
            this.tireCarModelDropdown.Location = new System.Drawing.Point(507, 326);
            this.tireCarModelDropdown.Name = "tireCarModelDropdown";
            this.tireCarModelDropdown.Size = new System.Drawing.Size(276, 46);
            this.tireCarModelDropdown.Sorted = true;
            this.tireCarModelDropdown.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(401, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "Suitable Car:";
            // 
            // tireCarBrandDropdown
            // 
            this.tireCarBrandDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tireCarBrandDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireCarBrandDropdown.FormattingEnabled = true;
            this.tireCarBrandDropdown.Location = new System.Drawing.Point(225, 326);
            this.tireCarBrandDropdown.Name = "tireCarBrandDropdown";
            this.tireCarBrandDropdown.Size = new System.Drawing.Size(276, 46);
            this.tireCarBrandDropdown.Sorted = true;
            this.tireCarBrandDropdown.TabIndex = 50;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(12, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 49;
            this.label16.Text = "Producer:";
            // 
            // tireTitleInput
            // 
            this.tireTitleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireTitleInput.Location = new System.Drawing.Point(12, 48);
            this.tireTitleInput.Name = "tireTitleInput";
            this.tireTitleInput.Size = new System.Drawing.Size(276, 45);
            this.tireTitleInput.TabIndex = 43;
            // 
            // tireProducerDropdown
            // 
            this.tireProducerDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tireProducerDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tireProducerDropdown.FormattingEnabled = true;
            this.tireProducerDropdown.Location = new System.Drawing.Point(12, 144);
            this.tireProducerDropdown.Name = "tireProducerDropdown";
            this.tireProducerDropdown.Size = new System.Drawing.Size(276, 46);
            this.tireProducerDropdown.Sorted = true;
            this.tireProducerDropdown.TabIndex = 48;
            // 
            // addNewTireBtn
            // 
            this.addNewTireBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewTireBtn.Location = new System.Drawing.Point(12, 322);
            this.addNewTireBtn.Name = "addNewTireBtn";
            this.addNewTireBtn.Size = new System.Drawing.Size(191, 53);
            this.addNewTireBtn.TabIndex = 47;
            this.addNewTireBtn.Text = "Add";
            this.addNewTireBtn.UseVisualStyleBackColor = true;
            this.addNewTireBtn.Click += new System.EventHandler(this.addNewTireBtn_Click);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(10, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 44;
            this.label17.Text = "Title:";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(12, 215);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 46;
            this.label18.Text = "Price:";
            // 
            // tirePriceInput
            // 
            this.tirePriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tirePriceInput.Location = new System.Drawing.Point(12, 241);
            this.tirePriceInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.tirePriceInput.Name = "tirePriceInput";
            this.tirePriceInput.Size = new System.Drawing.Size(276, 45);
            this.tirePriceInput.TabIndex = 45;
            this.tirePriceInput.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.tabControl1.ResumeLayout(false);
            this.addNewCarTab.ResumeLayout(false);
            this.addNewCarTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).EndInit();
            this.addNewDetailTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.brakesTab.ResumeLayout(false);
            this.brakesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brakesPriceInput)).EndInit();
            this.engineTab.ResumeLayout(false);
            this.engineTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.engineFuelCInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineTorqueInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineHPInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginePriceInput)).EndInit();
            this.gearboxTab.ResumeLayout(false);
            this.gearboxTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gearboxGearsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearboxPriceInput)).EndInit();
            this.tireTab.ResumeLayout(false);
            this.tireTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tirePriceInput)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox tireCarModelDropdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tireCarBrandDropdown;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tireTitleInput;
        private System.Windows.Forms.ComboBox tireProducerDropdown;
        private System.Windows.Forms.Button addNewTireBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown tirePriceInput;

        private System.Windows.Forms.ComboBox gearboxCarModelDropdown;
        private System.Windows.Forms.ComboBox gearboxCarBrandDropdown;
        private System.Windows.Forms.NumericUpDown gearboxGearsInput;
        private System.Windows.Forms.TextBox gearboxTitleInput;
        private System.Windows.Forms.Button addNewGearboxBtn;
        private System.Windows.Forms.NumericUpDown gearboxPriceInput;
        private System.Windows.Forms.ComboBox gearboxTypeDropdown;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox gearboxProducerDropdown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.ComboBox brakesCarModelDropdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox brakesCarBrandDropdown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox brakesTitleInput;
        private System.Windows.Forms.ComboBox brakesProducerDropdown;
        private System.Windows.Forms.Button addNewBrakesBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown brakesPriceInput;

        private System.Windows.Forms.ComboBox engineModelSelect;

        private System.Windows.Forms.ComboBox engineCarBrandSelect;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown engineHPInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown engineTorqueInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown engineFuelCInput;

        private System.Windows.Forms.TabPage engineTab;
        private System.Windows.Forms.TabPage brakesTab;

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tireTab;
        private System.Windows.Forms.TabPage gearboxTab;

        private System.Windows.Forms.Label producerLabel;
        private System.Windows.Forms.ComboBox engineProducerDropdown;

        private System.Windows.Forms.Button addNewEngineBtn;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown enginePriceInput;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox engineNameInput;

        private System.Windows.Forms.Button addCarButton;

        private System.Windows.Forms.Label yearLabel;

        private System.Windows.Forms.NumericUpDown yearInput;

        private System.Windows.Forms.Label modelLabel;

        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox modelTextBox;

        private System.Windows.Forms.ComboBox brandDropdown;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addNewCarTab;
        private System.Windows.Forms.TabPage addNewDetailTab;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        #endregion
    }
}