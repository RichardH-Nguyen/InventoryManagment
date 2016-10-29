namespace InventoryManagement
{
    partial class Form1
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
            this.rdoFood = new System.Windows.Forms.RadioButton();
            this.rdoWeapons = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.gboCategories = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.gboCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoFood
            // 
            this.rdoFood.AutoSize = true;
            this.rdoFood.Location = new System.Drawing.Point(12, 19);
            this.rdoFood.Name = "rdoFood";
            this.rdoFood.Size = new System.Drawing.Size(49, 17);
            this.rdoFood.TabIndex = 0;
            this.rdoFood.TabStop = true;
            this.rdoFood.Text = "Food";
            this.rdoFood.UseVisualStyleBackColor = true;
            this.rdoFood.CheckedChanged += new System.EventHandler(this.rdoFood_CheckedChanged);
            // 
            // rdoWeapons
            // 
            this.rdoWeapons.AutoSize = true;
            this.rdoWeapons.Location = new System.Drawing.Point(118, 19);
            this.rdoWeapons.Name = "rdoWeapons";
            this.rdoWeapons.Size = new System.Drawing.Size(71, 17);
            this.rdoWeapons.TabIndex = 1;
            this.rdoWeapons.TabStop = true;
            this.rdoWeapons.Text = "Weapons";
            this.rdoWeapons.UseVisualStyleBackColor = true;
            this.rdoWeapons.CheckedChanged += new System.EventHandler(this.rdoWeapons_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "First Aid";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // gboCategories
            // 
            this.gboCategories.Controls.Add(this.radioButton3);
            this.gboCategories.Controls.Add(this.rdoWeapons);
            this.gboCategories.Controls.Add(this.rdoFood);
            this.gboCategories.Location = new System.Drawing.Point(11, 12);
            this.gboCategories.Name = "gboCategories";
            this.gboCategories.Size = new System.Drawing.Size(250, 81);
            this.gboCategories.TabIndex = 3;
            this.gboCategories.TabStop = false;
            this.gboCategories.Text = "Categories";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(205, 125);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(56, 20);
            this.nudAmount.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(233, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(227, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 32);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(329, 49);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(77, 67);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "&Show Current Supplies";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(451, 452);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gboCategories);
            this.Name = "Form1";
            this.Text = "Survival Supplies";
            this.gboCategories.ResumeLayout(false);
            this.gboCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoFood;
        private System.Windows.Forms.RadioButton rdoWeapons;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox gboCategories;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
    }
}

