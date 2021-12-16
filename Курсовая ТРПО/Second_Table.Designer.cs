
namespace Курсовая_ТРПО
{
    partial class Second_Table
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
            this.Fio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHIFR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ves1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fio1,
            this.Num1,
            this.SHIFR1,
            this.Kol1,
            this.Ves1});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(652, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // Fio1
            // 
            this.Fio1.HeaderText = "Фамилия";
            this.Fio1.MinimumWidth = 6;
            this.Fio1.Name = "Fio1";
            this.Fio1.Width = 125;
            // 
            // Num1
            // 
            this.Num1.HeaderText = "Номер ячейки";
            this.Num1.MinimumWidth = 6;
            this.Num1.Name = "Num1";
            this.Num1.Width = 125;
            // 
            // SHIFR1
            // 
            this.SHIFR1.HeaderText = "Шифр";
            this.SHIFR1.MinimumWidth = 6;
            this.SHIFR1.Name = "SHIFR1";
            this.SHIFR1.Width = 125;
            // 
            // Kol1
            // 
            this.Kol1.HeaderText = "Количество вещей";
            this.Kol1.MinimumWidth = 6;
            this.Kol1.Name = "Kol1";
            this.Kol1.Width = 125;
            // 
            // Ves1
            // 
            this.Ves1.HeaderText = "Вес багажа";
            this.Ves1.MinimumWidth = 6;
            this.Ves1.Name = "Ves1";
            this.Ves1.Width = 125;
            // 
            // Second_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(648, 318);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(666, 365);
            this.MinimumSize = new System.Drawing.Size(666, 365);
            this.Name = "Second_Table";
            this.Text = "Second_Table";
            this.Load += new System.EventHandler(this.Load_Sort_Form);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHIFR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ves1;
    }
}