namespace Beadando_GX4ZPC_IRF
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
            this.button_menu = new System.Windows.Forms.Button();
            this.label_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_menu
            // 
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_menu.ForeColor = System.Drawing.Color.LightGreen;
            this.button_menu.Location = new System.Drawing.Point(252, 190);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(276, 133);
            this.button_menu.TabIndex = 0;
            this.button_menu.Text = "MENU";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_welcome.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_welcome.ForeColor = System.Drawing.Color.LightGreen;
            this.label_welcome.Location = new System.Drawing.Point(223, 84);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(345, 45);
            this.label_welcome.TabIndex = 1;
            this.label_welcome.Text = "Welcome to our restaurant!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.button_menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Label label_welcome;
    }
}

