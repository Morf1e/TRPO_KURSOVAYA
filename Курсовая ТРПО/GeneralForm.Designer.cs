
namespace Курсовая_ТРПО
{
    partial class GeneralForm
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
            this.Table = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Find_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Result_label = new System.Windows.Forms.Label();
            this.Min_Label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.BackgroundColor = System.Drawing.Color.MintCream;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this._Name,
            this.Country,
            this.Batch,
            this.Price});
            this.Table.Location = new System.Drawing.Point(12, 12);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 29;
            this.Table.Size = new System.Drawing.Size(681, 416);
            this.Table.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.HeaderText = "Фамилия пассажира";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 125;
            // 
            // _Name
            // 
            this._Name.HeaderText = "Номер ячейки";
            this._Name.MinimumWidth = 6;
            this._Name.Name = "_Name";
            this._Name.Width = 125;
            // 
            // Country
            // 
            this.Country.HeaderText = "Шифр багажа";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.Width = 125;
            // 
            // Batch
            // 
            this.Batch.HeaderText = "Количество вещей";
            this.Batch.MinimumWidth = 6;
            this.Batch.Name = "Batch";
            this.Batch.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Вес багажа";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.MintCream;
            this.Add_button.Location = new System.Drawing.Point(699, 12);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(220, 35);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "Добавить багаж";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.MintCream;
            this.Delete_button.Location = new System.Drawing.Point(699, 63);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(220, 35);
            this.Delete_button.TabIndex = 5;
            this.Delete_button.Text = "Удалить багаж";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.MintCream;
            this.Edit_button.Location = new System.Drawing.Point(699, 115);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(220, 35);
            this.Edit_button.TabIndex = 7;
            this.Edit_button.Text = "Редактировать багаж";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.MintCream;
            this.Refresh.Location = new System.Drawing.Point(699, 393);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(220, 35);
            this.Refresh.TabIndex = 9;
            this.Refresh.Text = "Обновить данные таблицы";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(700, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Номер:";
            // 
            // Find_Box
            // 
            this.Find_Box.Location = new System.Drawing.Point(764, 218);
            this.Find_Box.Name = "Find_Box";
            this.Find_Box.Size = new System.Drawing.Size(155, 27);
            this.Find_Box.TabIndex = 12;
            this.Find_Box.TextChanged += new System.EventHandler(this.Change);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(699, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cредний вес одной вещи\r\nпо задонному номеру:";
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Location = new System.Drawing.Point(868, 275);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(0, 20);
            this.Result_label.TabIndex = 14;
            // 
            // Min_Label
            // 
            this.Min_Label.AutoSize = true;
            this.Min_Label.Location = new System.Drawing.Point(700, 299);
            this.Min_Label.Name = "Min_Label";
            this.Min_Label.Size = new System.Drawing.Size(218, 40);
            this.Min_Label.TabIndex = 15;
            this.Min_Label.Text = "Число пассажиров с багажом\r\nбольше 10кг:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Location = new System.Drawing.Point(699, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "Список";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(699, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Удалить с МАКС весом";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(926, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Min_Label);
            this.Controls.Add(this.Result_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Find_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GeneralForm";
            this.Text = "Органайзер";
            this.Activated += new System.EventHandler(this.GeneralForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        public System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Find_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.Label Min_Label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

