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
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leírás = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drinkcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_searchbar = new System.Windows.Forms.TextBox();
            this.label_order = new System.Windows.Forms.Label();
            this.comboBox_options = new System.Windows.Forms.ComboBox();
            this.label_search = new System.Windows.Forms.Label();
            this.button_pick = new System.Windows.Forms.Button();
            this.button_random = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.pb_design = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_design)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_menu
            // 
            this.dgv_menu.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Leírás,
            this.Calories,
            this.Price,
            this.Diet,
            this.Type,
            this.Drinkcategory});
            this.dgv_menu.Location = new System.Drawing.Point(21, 86);
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.Size = new System.Drawing.Size(744, 331);
            this.dgv_menu.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Menu";
            this.name.Name = "name";
            this.name.Width = 140;
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
            this.Price.Width = 60;
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
            // label_order
            // 
            this.label_order.AutoSize = true;
            this.label_order.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_order.ForeColor = System.Drawing.Color.LightGreen;
            this.label_order.Location = new System.Drawing.Point(121, 481);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(139, 35);
            this.label_order.TabIndex = 6;
            this.label_order.Text = "YOUR ORDER :";
            // 
            // comboBox_options
            // 
            this.comboBox_options.BackColor = System.Drawing.Color.White;
            this.comboBox_options.FormattingEnabled = true;
            this.comboBox_options.Items.AddRange(new object[] {
            "Vegan",
            "Meatlover",
            "Drinks",
            "Full Menu"});
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
            this.label_search.Size = new System.Drawing.Size(68, 25);
            this.label_search.TabIndex = 8;
            this.label_search.Text = "SEARCH:";
            // 
            // button_pick
            // 
            this.button_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pick.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_pick.ForeColor = System.Drawing.Color.LightGreen;
            this.button_pick.Location = new System.Drawing.Point(163, 423);
            this.button_pick.Name = "button_pick";
            this.button_pick.Size = new System.Drawing.Size(87, 40);
            this.button_pick.TabIndex = 9;
            this.button_pick.Text = "PICK";
            this.button_pick.UseVisualStyleBackColor = true;
            this.button_pick.Click += new System.EventHandler(this.button_pick_Click);
            // 
            // button_random
            // 
            this.button_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_random.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_random.ForeColor = System.Drawing.Color.Yellow;
            this.button_random.Location = new System.Drawing.Point(616, 423);
            this.button_random.Name = "button_random";
            this.button_random.Size = new System.Drawing.Size(149, 40);
            this.button_random.TabIndex = 10;
            this.button_random.Text = "CHEF\'S OFFER";
            this.button_random.UseVisualStyleBackColor = true;
            this.button_random.Click += new System.EventHandler(this.button_random_Click);
            // 
            // button_reset
            // 
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reset.ForeColor = System.Drawing.Color.LightGreen;
            this.button_reset.Location = new System.Drawing.Point(438, 423);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(87, 40);
            this.button_reset.TabIndex = 11;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // dgv_order
            // 
            this.dgv_order.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgv_order.Location = new System.Drawing.Point(282, 481);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.Size = new System.Drawing.Size(243, 272);
            this.dgv_order.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Menu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "calories";
            this.dataGridViewTextBoxColumn3.HeaderText = "Calories";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "diet";
            this.dataGridViewTextBoxColumn5.HeaderText = "Diet";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 51;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn6.HeaderText = "Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 56;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "drinkcategory";
            this.dataGridViewTextBoxColumn7.HeaderText = "Drinkcategory";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 98;
            // 
            // button_confirm
            // 
            this.button_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_confirm.ForeColor = System.Drawing.Color.LightGreen;
            this.button_confirm.Location = new System.Drawing.Point(117, 668);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(133, 40);
            this.button_confirm.TabIndex = 13;
            this.button_confirm.Text = "CONFIRM";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_help
            // 
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_help.ForeColor = System.Drawing.Color.LightGreen;
            this.button_help.Location = new System.Drawing.Point(632, 668);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(133, 40);
            this.button_help.TabIndex = 14;
            this.button_help.Text = "HELP";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // pb_design
            // 
            this.pb_design.BackColor = System.Drawing.Color.LightGreen;
            this.pb_design.Location = new System.Drawing.Point(283, 482);
            this.pb_design.Name = "pb_design";
            this.pb_design.Size = new System.Drawing.Size(42, 44);
            this.pb_design.TabIndex = 15;
            this.pb_design.TabStop = false;
            this.pb_design.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 777);
            this.Controls.Add(this.pb_design);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.dgv_order);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_random);
            this.Controls.Add(this.button_pick);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.comboBox_options);
            this.Controls.Add(this.label_order);
            this.Controls.Add(this.textBox_searchbar);
            this.Controls.Add(this.dgv_menu);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Menu";
            this.Text = "Vegan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_design)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.TextBox textBox_searchbar;
        private System.Windows.Forms.Label label_order;
        private System.Windows.Forms.ComboBox comboBox_options;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Button button_pick;
        private System.Windows.Forms.Button button_random;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leírás;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drinkcategory;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.PictureBox pb_design;
    }
}