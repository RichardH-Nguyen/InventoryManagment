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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.txtAddItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.rdoWeapons.Location = new System.Drawing.Point(192, 19);
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
            this.radioButton3.Location = new System.Drawing.Point(94, 19);
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
            this.gboCategories.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gboCategories.Controls.Add(this.radioButton3);
            this.gboCategories.Controls.Add(this.rdoWeapons);
            this.gboCategories.Controls.Add(this.rdoFood);
            this.gboCategories.ForeColor = System.Drawing.SystemColors.Control;
            this.gboCategories.Location = new System.Drawing.Point(11, 27);
            this.gboCategories.Name = "gboCategories";
            this.gboCategories.Size = new System.Drawing.Size(272, 46);
            this.gboCategories.TabIndex = 3;
            this.gboCategories.TabStop = false;
            this.gboCategories.Text = "Categories";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(163, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nudAmount
            // 
            this.nudAmount.BackColor = System.Drawing.SystemColors.MenuText;
            this.nudAmount.ForeColor = System.Drawing.SystemColors.Window;
            this.nudAmount.Location = new System.Drawing.Point(34, 144);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(56, 20);
            this.nudAmount.TabIndex = 5;
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(15, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Take";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(85, 259);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(226, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 32);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Green;
            this.btnShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShow.Location = new System.Drawing.Point(328, 11);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(77, 67);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "&Show Current Supplies";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(15, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.BackColor = System.Drawing.Color.Green;
            this.btnItemAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnItemAdd.Location = new System.Drawing.Point(305, 213);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(94, 23);
            this.btnItemAdd.TabIndex = 11;
            this.btnItemAdd.Text = "Add to Category";
            this.btnItemAdd.UseVisualStyleBackColor = false;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // txtAddItem
            // 
            this.txtAddItem.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAddItem.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAddItem.Location = new System.Drawing.Point(305, 187);
            this.txtAddItem.Name = "txtAddItem";
            this.txtAddItem.Size = new System.Drawing.Size(100, 20);
            this.txtAddItem.TabIndex = 12;
            this.txtAddItem.TextChanged += new System.EventHandler(this.txtAddItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Inventory Management";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(417, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddItem);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gboCategories);
            this.Name = "Form1";
            this.Text = "Zombie Apocalypse Survival Supplies";
            this.gboCategories.ResumeLayout(false);
            this.gboCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.TextBox txtAddItem;
        private System.Windows.Forms.Label label1;
    }
}

