
namespace Курсовая_ТРПО
{
    partial class Shablon_Delete
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
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_Box = new System.Windows.Forms.TextBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер ячейки, которую нужно удалить";
            // 
            // Delete_Box
            // 
            this.Delete_Box.Location = new System.Drawing.Point(393, 18);
            this.Delete_Box.Name = "Delete_Box";
            this.Delete_Box.Size = new System.Drawing.Size(157, 27);
            this.Delete_Box.TabIndex = 1;
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.MintCream;
            this.Delete_Button.Location = new System.Drawing.Point(217, 82);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(139, 34);
            this.Delete_Button.TabIndex = 2;
            this.Delete_Button.Text = "Удалить";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Shablon_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(562, 128);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Delete_Box);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(580, 175);
            this.MinimumSize = new System.Drawing.Size(580, 175);
            this.Name = "Shablon_Delete";
            this.Text = "Shablon_Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Delete_Box;
        private System.Windows.Forms.Button Delete_Button;
    }
}