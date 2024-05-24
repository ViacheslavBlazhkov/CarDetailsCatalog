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
            this.label4 = new System.Windows.Forms.Label();
            this.yearInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brandDropdown = new System.Windows.Forms.ComboBox();
            this.addNewDetailTab = new System.Windows.Forms.TabPage();
            this.addNewDetailBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.detailTypeDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.producerDropdown = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.addNewCarTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).BeginInit();
            this.addNewDetailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).BeginInit();
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
            this.addNewCarTab.Controls.Add(this.label4);
            this.addNewCarTab.Controls.Add(this.yearInput);
            this.addNewCarTab.Controls.Add(this.label3);
            this.addNewCarTab.Controls.Add(this.modelTextBox);
            this.addNewCarTab.Controls.Add(this.label1);
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
            this.addCarButton.Text = "Додати";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Рік:";
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
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Модель:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelTextBox.Location = new System.Drawing.Point(23, 153);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(276, 45);
            this.modelTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Бренд:";
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
            this.addNewDetailTab.Controls.Add(this.label7);
            this.addNewDetailTab.Controls.Add(this.producerDropdown);
            this.addNewDetailTab.Controls.Add(this.addNewDetailBtn);
            this.addNewDetailTab.Controls.Add(this.label2);
            this.addNewDetailTab.Controls.Add(this.priceInput);
            this.addNewDetailTab.Controls.Add(this.label5);
            this.addNewDetailTab.Controls.Add(this.nameInput);
            this.addNewDetailTab.Controls.Add(this.label6);
            this.addNewDetailTab.Controls.Add(this.detailTypeDropdown);
            this.addNewDetailTab.Location = new System.Drawing.Point(4, 25);
            this.addNewDetailTab.Name = "addNewDetailTab";
            this.addNewDetailTab.Padding = new System.Windows.Forms.Padding(3);
            this.addNewDetailTab.Size = new System.Drawing.Size(792, 421);
            this.addNewDetailTab.TabIndex = 1;
            this.addNewDetailTab.Text = "Add new Detail";
            this.addNewDetailTab.UseVisualStyleBackColor = true;
            // 
            // addNewDetailBtn
            // 
            this.addNewDetailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewDetailBtn.Location = new System.Drawing.Point(8, 360);
            this.addNewDetailBtn.Name = "addNewDetailBtn";
            this.addNewDetailBtn.Size = new System.Drawing.Size(191, 53);
            this.addNewDetailBtn.TabIndex = 15;
            this.addNewDetailBtn.Text = "Додати";
            this.addNewDetailBtn.UseVisualStyleBackColor = true;
            this.addNewDetailBtn.Click += new System.EventHandler(this.addNewDetailBtn_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Назва:";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameInput.Location = new System.Drawing.Point(8, 121);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(276, 45);
            this.nameInput.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Тип деталі:";
            // 
            // detailTypeDropdown
            // 
            this.detailTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.detailTypeDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailTypeDropdown.FormattingEnabled = true;
            this.detailTypeDropdown.Location = new System.Drawing.Point(8, 38);
            this.detailTypeDropdown.Name = "detailTypeDropdown";
            this.detailTypeDropdown.Size = new System.Drawing.Size(276, 46);
            this.detailTypeDropdown.Sorted = true;
            this.detailTypeDropdown.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ціна:";
            // 
            // priceInput
            // 
            this.priceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceInput.Location = new System.Drawing.Point(8, 297);
            this.priceInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(276, 45);
            this.priceInput.TabIndex = 13;
            this.priceInput.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Виробник:";
            // 
            // producerDropdown
            // 
            this.producerDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.producerDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.producerDropdown.FormattingEnabled = true;
            this.producerDropdown.Location = new System.Drawing.Point(8, 209);
            this.producerDropdown.Name = "producerDropdown";
            this.producerDropdown.Size = new System.Drawing.Size(276, 46);
            this.producerDropdown.Sorted = true;
            this.producerDropdown.TabIndex = 16;
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
            this.addNewDetailTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox producerDropdown;

        private System.Windows.Forms.Button addNewDetailBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown priceInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox detailTypeDropdown;

        private System.Windows.Forms.Button addCarButton;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.NumericUpDown yearInput;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modelTextBox;

        private System.Windows.Forms.ComboBox brandDropdown;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addNewCarTab;
        private System.Windows.Forms.TabPage addNewDetailTab;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        #endregion
    }
}