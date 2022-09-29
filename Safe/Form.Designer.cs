namespace Safe
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridLabel = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitBtn = new System.Windows.Forms.Label();
            this.StepLabel = new System.Windows.Forms.Label();
            this.StepQuantity = new System.Windows.Forms.Label();
            this.NewGameBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gridLabel
            // 
            this.GridLabel.AutoSize = true;
            this.GridLabel.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GridLabel.ForeColor = System.Drawing.Color.White;
            this.GridLabel.Location = new System.Drawing.Point(207, 66);
            this.GridLabel.Name = "gridLabel";
            this.GridLabel.Size = new System.Drawing.Size(173, 30);
            this.GridLabel.TabIndex = 1;
            this.GridLabel.Text = "Grid Size:";
            // 
            // comboBox
            // 
            this.ComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBox.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20});
            this.ComboBox.Location = new System.Drawing.Point(386, 63);
            this.ComboBox.Name = "comboBox";
            this.ComboBox.Size = new System.Drawing.Size(50, 39);
            this.ComboBox.TabIndex = 2;
            this.ComboBox.Text = "4";
            // 
            // submitBtn
            // 
            this.SubmitBtn.AutoSize = true;
            this.SubmitBtn.BackColor = System.Drawing.Color.Transparent;
            this.SubmitBtn.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitBtn.ForeColor = System.Drawing.Color.Turquoise;
            this.SubmitBtn.Location = new System.Drawing.Point(271, 113);
            this.SubmitBtn.Name = "submitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(109, 30);
            this.SubmitBtn.TabIndex = 4;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            this.SubmitBtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.SubmitBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // stepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StepLabel.ForeColor = System.Drawing.Color.White;
            this.StepLabel.Location = new System.Drawing.Point(737, 66);
            this.StepLabel.Name = "stepLabel";
            this.StepLabel.Size = new System.Drawing.Size(109, 30);
            this.StepLabel.TabIndex = 5;
            this.StepLabel.Text = "Steps:";
            // 
            // stepQuantity
            // 
            this.StepQuantity.AutoSize = true;
            this.StepQuantity.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StepQuantity.ForeColor = System.Drawing.Color.White;
            this.StepQuantity.Location = new System.Drawing.Point(838, 66);
            this.StepQuantity.Name = "stepQuantity";
            this.StepQuantity.Size = new System.Drawing.Size(30, 31);
            this.StepQuantity.TabIndex = 6;
            this.StepQuantity.Text = "0";
            // 
            // newGameBtn
            // 
            this.NewGameBtn.AutoSize = true;
            this.NewGameBtn.BackColor = System.Drawing.Color.Transparent;
            this.NewGameBtn.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewGameBtn.ForeColor = System.Drawing.Color.Turquoise;
            this.NewGameBtn.Location = new System.Drawing.Point(737, 113);
            this.NewGameBtn.Name = "newGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(141, 30);
            this.NewGameBtn.TabIndex = 7;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            this.NewGameBtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.NewGameBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(984, 665);
            this.Controls.Add(this.NewGameBtn);
            this.Controls.Add(this.StepQuantity);
            this.Controls.Add(this.StepLabel);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.GridLabel);
            this.Name = "Form1";
            this.Text = "Safe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label GridLabel;
        private ComboBox ComboBox;
        private Label SubmitBtn;
        private Label StepLabel;
        private Label StepQuantity;
        private Label NewGameBtn;
    }
}