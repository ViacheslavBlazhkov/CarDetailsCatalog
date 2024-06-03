namespace CarDetailsCatalog
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.contentControl = new System.Windows.Forms.Control();
            this.toPrevMenuBtn = new System.Windows.Forms.Button();
            this.adminPanelBtn = new System.Windows.Forms.Button();
            this.findInput = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contentControl
            // 
            this.contentControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contentControl.Location = new System.Drawing.Point(12, 74);
            this.contentControl.Name = "contentControl";
            this.contentControl.Size = new System.Drawing.Size(776, 364);
            this.contentControl.TabIndex = 0;
            this.contentControl.Text = "control1";
            // 
            // toPrevMenuBtn
            // 
            this.toPrevMenuBtn.Location = new System.Drawing.Point(12, 12);
            this.toPrevMenuBtn.Name = "toPrevMenuBtn";
            this.toPrevMenuBtn.Size = new System.Drawing.Size(116, 56);
            this.toPrevMenuBtn.TabIndex = 1;
            this.toPrevMenuBtn.Text = "Go Back";
            this.toPrevMenuBtn.UseVisualStyleBackColor = true;
            this.toPrevMenuBtn.Visible = false;
            this.toPrevMenuBtn.Click += new System.EventHandler(this.toPrevMenuBtn_Click);
            // 
            // adminPanelBtn
            // 
            this.adminPanelBtn.Location = new System.Drawing.Point(672, 12);
            this.adminPanelBtn.Name = "adminPanelBtn";
            this.adminPanelBtn.Size = new System.Drawing.Size(116, 56);
            this.adminPanelBtn.TabIndex = 2;
            this.adminPanelBtn.Text = "Admin Panel";
            this.adminPanelBtn.UseVisualStyleBackColor = true;
            this.adminPanelBtn.Click += new System.EventHandler(this.adminPanelBtn_Click);
            // 
            // findInput
            // 
            this.findInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findInput.Location = new System.Drawing.Point(134, 23);
            this.findInput.Name = "findInput";
            this.findInput.Size = new System.Drawing.Size(410, 45);
            this.findInput.TabIndex = 3;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(550, 23);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(116, 45);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "Find Details";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.findInput);
            this.Controls.Add(this.adminPanelBtn);
            this.Controls.Add(this.toPrevMenuBtn);
            this.Controls.Add(this.contentControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox findInput;
        private System.Windows.Forms.Button findButton;

        private System.Windows.Forms.Button adminPanelBtn;

        private System.Windows.Forms.Button toPrevMenuBtn;

        private System.Windows.Forms.Control contentControl;

        #endregion
    }
}