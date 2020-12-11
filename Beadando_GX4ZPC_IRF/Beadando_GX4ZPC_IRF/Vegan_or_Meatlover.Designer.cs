namespace Beadando_GX4ZPC_IRF
{
    partial class Vegan_or_Meatlover
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
            this.vegan_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vegan_button
            // 
            this.vegan_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vegan_button.Location = new System.Drawing.Point(244, 80);
            this.vegan_button.Name = "vegan_button";
            this.vegan_button.Size = new System.Drawing.Size(321, 133);
            this.vegan_button.TabIndex = 1;
            this.vegan_button.Text = "VEGAN";
            this.vegan_button.UseVisualStyleBackColor = true;
            this.vegan_button.Click += new System.EventHandler(this.vegan_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(198, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 133);
            this.button1.TabIndex = 2;
            this.button1.Text = "MEATLOVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vegan_or_Meatlover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vegan_button);
            this.Name = "Vegan_or_Meatlover";
            this.Text = "Vegan_or_Meatlover";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vegan_button;
        private System.Windows.Forms.Button button1;
    }
}