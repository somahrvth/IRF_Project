namespace Beadando_GX4ZPC_IRF
{
    partial class Menu
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
            this.textBox_searchbar = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label_order = new System.Windows.Forms.Label();
            this.comboBox_options = new System.Windows.Forms.ComboBox();
            this.label_search = new System.Windows.Forms.Label();
            this.button_pick = new System.Windows.Forms.Button();
            this.button_random = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
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
            this.dataGridView1.Size = new System.Drawing.Size(744, 331);
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
            // textBox_searchbar
            // 
            this.textBox_searchbar.Location = new System.Drawing.Point(107, 33);
            this.textBox_searchbar.Name = "textBox_searchbar";
            this.textBox_searchbar.Size = new System.Drawing.Size(192, 20);
            this.textBox_searchbar.TabIndex = 4;
            this.textBox_searchbar.TextChanged += new System.EventHandler(this.textBox_searchbar_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(137, 469);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(628, 224);
            this.dataGridView2.TabIndex = 5;
            // 
            // label_order
            // 
            this.label_order.AutoSize = true;
            this.label_order.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_order.ForeColor = System.Drawing.Color.LightGreen;
            this.label_order.Location = new System.Drawing.Point(12, 469);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(123, 35);
            this.label_order.TabIndex = 6;
            this.label_order.Text = "Your Order :";
            // 
            // comboBox_options
            // 
            this.comboBox_options.FormattingEnabled = true;
            this.comboBox_options.Items.AddRange(new object[] {
            "Vegan",
            "Meatlover",
            "Drinks",
            "Menu"});
            this.comboBox_options.Location = new System.Drawing.Point(373, 31);
            this.comboBox_options.Name = "comboBox_options";
            this.comboBox_options.Size = new System.Drawing.Size(152, 21);
            this.comboBox_options.TabIndex = 7;
            this.comboBox_options.Text = "Choose your preference";
            this.comboBox_options.SelectedIndexChanged += new System.EventHandler(this.comboBox_options_SelectedIndexChanged);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_search.ForeColor = System.Drawing.Color.LightGreen;
            this.label_search.Location = new System.Drawing.Point(36, 28);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(65, 25);
            this.label_search.TabIndex = 8;
            this.label_search.Text = "Search:";
            // 
            // button_pick
            // 
            this.button_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pick.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_pick.ForeColor = System.Drawing.Color.LightGreen;
            this.button_pick.Location = new System.Drawing.Point(212, 423);
            this.button_pick.Name = "button_pick";
            this.button_pick.Size = new System.Drawing.Size(87, 40);
            this.button_pick.TabIndex = 9;
            this.button_pick.Text = "PICK";
            this.button_pick.UseVisualStyleBackColor = true;
            // 
            // button_random
            // 
            this.button_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_random.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_random.ForeColor = System.Drawing.Color.LightGreen;
            this.button_random.Location = new System.Drawing.Point(616, 423);
            this.button_random.Name = "button_random";
            this.button_random.Size = new System.Drawing.Size(149, 40);
            this.button_random.TabIndex = 10;
            this.button_random.Text = "CHEF\'S OFFER";
            this.button_random.UseVisualStyleBackColor = true;
            // 
            // button_reset
            // 
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reset.ForeColor = System.Drawing.Color.LightGreen;
            this.button_reset.Location = new System.Drawing.Point(373, 423);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(87, 40);
            this.button_reset.TabIndex = 11;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 777);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_random);
            this.Controls.Add(this.button_pick);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.comboBox_options);
            this.Controls.Add(this.label_order);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox_searchbar);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Menu";
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
        private System.Windows.Forms.TextBox textBox_searchbar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label_order;
        private System.Windows.Forms.ComboBox comboBox_options;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Button button_pick;
        private System.Windows.Forms.Button button_random;
        private System.Windows.Forms.Button button_reset;
    }
}