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
            this.gridLabel = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Label();
            this.stepLabel = new System.Windows.Forms.Label();
            this.stepQuantity = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Label();
            this.menuBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gridLabel
            // 
            this.gridLabel.AutoSize = true;
            this.gridLabel.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridLabel.ForeColor = System.Drawing.Color.White;
            this.gridLabel.Location = new System.Drawing.Point(387, 276);
            this.gridLabel.Name = "gridLabel";
            this.gridLabel.Size = new System.Drawing.Size(173, 30);
            this.gridLabel.TabIndex = 1;
            this.gridLabel.Text = "Grid Size:";
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
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
            this.comboBox.Location = new System.Drawing.Point(566, 273);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(50, 38);
            this.comboBox.TabIndex = 2;
            this.comboBox.Text = "4";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.AutoSize = true;
            this.submitBtn.BackColor = System.Drawing.Color.Transparent;
            this.submitBtn.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.ForeColor = System.Drawing.Color.Turquoise;
            this.submitBtn.Location = new System.Drawing.Point(445, 321);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(109, 30);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            this.submitBtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.submitBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stepLabel.ForeColor = System.Drawing.Color.White;
            this.stepLabel.Location = new System.Drawing.Point(429, 9);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(109, 30);
            this.stepLabel.TabIndex = 5;
            this.stepLabel.Text = "Steps:\r\n";
            this.stepLabel.Visible = false;
            // 
            // stepQuantity
            // 
            this.stepQuantity.AutoSize = true;
            this.stepQuantity.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stepQuantity.ForeColor = System.Drawing.Color.White;
            this.stepQuantity.Location = new System.Drawing.Point(534, 9);
            this.stepQuantity.Name = "stepQuantity";
            this.stepQuantity.Size = new System.Drawing.Size(29, 30);
            this.stepQuantity.TabIndex = 6;
            this.stepQuantity.Text = "0";
            this.stepQuantity.Visible = false;
            // 
            // restartBtn
            // 
            this.restartBtn.AutoSize = true;
            this.restartBtn.BackColor = System.Drawing.Color.Transparent;
            this.restartBtn.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restartBtn.ForeColor = System.Drawing.Color.Turquoise;
            this.restartBtn.Location = new System.Drawing.Point(257, 9);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(125, 30);
            this.restartBtn.TabIndex = 7;
            this.restartBtn.Text = "Restart";
            this.restartBtn.Visible = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            this.restartBtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.restartBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // menuBtn
            // 
            this.menuBtn.AutoSize = true;
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuBtn.ForeColor = System.Drawing.Color.Turquoise;
            this.menuBtn.Location = new System.Drawing.Point(618, 9);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(77, 30);
            this.menuBtn.TabIndex = 8;
            this.menuBtn.Text = "Menu";
            this.menuBtn.Visible = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            this.menuBtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.menuBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(984, 665);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.stepQuantity);
            this.Controls.Add(this.stepLabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.gridLabel);
            this.Name = "Form";
            this.Text = "Safe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label gridLabel;
        private ComboBox comboBox;
        private Label submitBtn;
        private Label stepLabel;
        private Label stepQuantity;
        private Label restartBtn;
        private Label menuBtn;
    }
}