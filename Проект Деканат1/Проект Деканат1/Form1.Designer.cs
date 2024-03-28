namespace Проект_Деканат1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDeleteStudentTextBox = new System.Windows.Forms.TextBox();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.oldest = new System.Windows.Forms.Label();
            this.youngest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(365, 373);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ФИО";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата рождения";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Стипендия";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddStudentButton.Location = new System.Drawing.Point(6, 29);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(130, 32);
            this.AddStudentButton.TabIndex = 1;
            this.AddStudentButton.Text = "Добавить";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.addNewStudentButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SortButton.Location = new System.Drawing.Point(6, 67);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(130, 32);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Отсортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numDeleteStudentTextBox);
            this.groupBox1.Controls.Add(this.DeleteStudentButton);
            this.groupBox1.Controls.Add(this.AddStudentButton);
            this.groupBox1.Controls.Add(this.SortButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(383, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 151);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // numDeleteStudentTextBox
            // 
            this.numDeleteStudentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numDeleteStudentTextBox.Location = new System.Drawing.Point(142, 110);
            this.numDeleteStudentTextBox.Name = "numDeleteStudentTextBox";
            this.numDeleteStudentTextBox.Size = new System.Drawing.Size(39, 23);
            this.numDeleteStudentTextBox.TabIndex = 4;
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteStudentButton.Location = new System.Drawing.Point(6, 105);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(130, 32);
            this.DeleteStudentButton.TabIndex = 3;
            this.DeleteStudentButton.Text = "Удалить";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.oldest);
            this.groupBox2.Controls.Add(this.youngest);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox2.Location = new System.Drawing.Point(385, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 129);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найти студента";
            // 
            // oldest
            // 
            this.oldest.AutoSize = true;
            this.oldest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.oldest.Location = new System.Drawing.Point(21, 95);
            this.oldest.Name = "oldest";
            this.oldest.Size = new System.Drawing.Size(0, 20);
            this.oldest.TabIndex = 3;
            // 
            // youngest
            // 
            this.youngest.AutoSize = true;
            this.youngest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.youngest.Location = new System.Drawing.Point(21, 45);
            this.youngest.Name = "youngest";
            this.youngest.Size = new System.Drawing.Size(0, 20);
            this.youngest.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Самый старший";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Самый младший";
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveDataButton.Location = new System.Drawing.Point(383, 304);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(130, 43);
            this.SaveDataButton.TabIndex = 5;
            this.SaveDataButton.Text = "Сохранить данные";
            this.SaveDataButton.UseVisualStyleBackColor = true;
            this.SaveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(597, 434);
            this.Controls.Add(this.SaveDataButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox numDeleteStudentTextBox;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label oldest;
        private System.Windows.Forms.Label youngest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveDataButton;
    }
}

