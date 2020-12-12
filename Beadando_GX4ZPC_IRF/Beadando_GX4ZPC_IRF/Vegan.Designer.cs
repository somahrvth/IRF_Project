namespace Beadando_GX4ZPC_IRF
{
    partial class Vegan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leírás = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drinkcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox_vegan = new System.Windows.Forms.CheckBox();
            this.checkBox_meatlover = new System.Windows.Forms.CheckBox();
            this.checkBox_drinks = new System.Windows.Forms.CheckBox();
            this.textBox_searchbar = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_options = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Leírás,
            this.Calories,
            this.Price,
            this.Diet,
            this.Type,
            this.Drinkcategory});
            this.dataGridView1.Location = new System.Drawing.Point(21, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Menu";
            this.name.Name = "name";
            // 
            // Leírás
            // 
            this.Leírás.DataPropertyName = "description";
            this.Leírás.HeaderText = "Description";
            this.Leírás.Name = "Leírás";
            this.Leírás.Width = 400;
            // 
            // Calories
            // 
            this.Calories.DataPropertyName = "calories";
            this.Calories.HeaderText = "Calories";
            this.Calories.Name = "Calories";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Diet
            // 
            this.Diet.DataPropertyName = "diet";
            this.Diet.HeaderText = "Diet";
            this.Diet.Name = "Diet";
            this.Diet.Visible = false;
            this.Diet.Width = 51;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Visible = false;
            this.Type.Width = 56;
            // 
            // Drinkcategory
            // 
            this.Drinkcategory.DataPropertyName = "drinkcategory";
            this.Drinkcategory.HeaderText = "Drinkcategory";
            this.Drinkcategory.Name = "Drinkcategory";
            this.Drinkcategory.Visible = false;
            this.Drinkcategory.Width = 98;
            // 
            // checkBox_vegan
            // 
            this.checkBox_vegan.AutoSize = true;
            this.checkBox_vegan.Location = new System.Drawing.Point(582, 13);
            this.checkBox_vegan.Name = "checkBox_vegan";
            this.checkBox_vegan.Size = new System.Drawing.Size(57, 17);
            this.checkBox_vegan.TabIndex = 1;
            this.checkBox_vegan.Text = "Vegan";
            this.checkBox_vegan.UseVisualStyleBackColor = true;
            this.checkBox_vegan.CheckedChanged += new System.EventHandler(this.checkBox_vegan_CheckedChanged);
            // 
            // checkBox_meatlover
            // 
            this.checkBox_meatlover.AutoSize = true;
            this.checkBox_meatlover.Location = new System.Drawing.Point(582, 36);
            this.checkBox_meatlover.Name = "checkBox_meatlover";
            this.checkBox_meatlover.Size = new System.Drawing.Size(73, 17);
            this.checkBox_meatlover.TabIndex = 2;
            this.checkBox_meatlover.Text = "Meatlover";
            this.checkBox_meatlover.UseVisualStyleBackColor = true;
            // 
            // checkBox_drinks
            // 
            this.checkBox_drinks.AutoSize = true;
            this.checkBox_drinks.Location = new System.Drawing.Point(582, 59);
            this.checkBox_drinks.Name = "checkBox_drinks";
            this.checkBox_drinks.Size = new System.Drawing.Size(56, 17);
            this.checkBox_drinks.TabIndex = 3;
            this.checkBox_drinks.Text = "Drinks";
            this.checkBox_drinks.UseVisualStyleBackColor = true;
            // 
            // textBox_searchbar
            // 
            this.textBox_searchbar.Location = new System.Drawing.Point(68, 33);
            this.textBox_searchbar.Name = "textBox_searchbar";
            this.textBox_searchbar.Size = new System.Drawing.Size(183, 20);
            this.textBox_searchbar.TabIndex = 4;
            this.textBox_searchbar.TextChanged += new System.EventHandler(this.textBox_searchbar_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(123, 521);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(546, 193);
            this.dataGridView2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ya Orda";
            // 
            // comboBox_options
            // 
            this.comboBox_options.FormattingEnabled = true;
            this.comboBox_options.Items.AddRange(new object[] {
            "Vegan",
            "Meatlover",
            "Drinks",
            "Menu"});
            this.comboBox_options.Location = new System.Drawing.Point(328, 32);
            this.comboBox_options.Name = "comboBox_options";
            this.comboBox_options.Size = new System.Drawing.Size(152, 21);
            this.comboBox_options.TabIndex = 7;
            this.comboBox_options.Text = "Choose your preference";
            this.comboBox_options.SelectedIndexChanged += new System.EventHandler(this.comboBox_options_SelectedIndexChanged);
            // 
            // Vegan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 777);
            this.Controls.Add(this.comboBox_options);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox_searchbar);
            this.Controls.Add(this.checkBox_drinks);
            this.Controls.Add(this.checkBox_meatlover);
            this.Controls.Add(this.checkBox_vegan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vegan";
            this.Text = "Vegan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leírás;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drinkcategory;
        private System.Windows.Forms.CheckBox checkBox_vegan;
        private System.Windows.Forms.CheckBox checkBox_meatlover;
        private System.Windows.Forms.CheckBox checkBox_drinks;
        private System.Windows.Forms.TextBox textBox_searchbar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_options;
    }
}