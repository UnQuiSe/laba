namespace kishki
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.блюдаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.харчоDataSet = new kishki.харчоDataSet();
            this.блюдаTableAdapter = new kishki.харчоDataSetTableAdapters.БлюдаTableAdapter();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.харчоDataSet1 = new kishki.харчоDataSet1();
            this.продуктыTableAdapter = new kishki.харчоDataSet1TableAdapters.ПродуктыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ингридиентыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.грамовкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.блюдаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.харчоDataSet2 = new kishki.харчоDataSet2();
            this.блюдаTableAdapter1 = new kishki.харчоDataSet2TableAdapters.БлюдаTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.калорийностьВ1ГрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.харчоDataSet3 = new kishki.харчоDataSet3();
            this.продуктыTableAdapter1 = new kishki.харчоDataSet3TableAdapters.ПродуктыTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.kl = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.харчоDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.харчоDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.харчоDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.харчоDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(498, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // блюдаBindingSource
            // 
            this.блюдаBindingSource.DataMember = "Блюда";
            this.блюдаBindingSource.DataSource = this.харчоDataSet;
            // 
            // харчоDataSet
            // 
            this.харчоDataSet.DataSetName = "харчоDataSet";
            this.харчоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // блюдаTableAdapter
            // 
            this.блюдаTableAdapter.ClearBeforeFill = true;
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.харчоDataSet1;
            // 
            // харчоDataSet1
            // 
            this.харчоDataSet1.DataSetName = "харчоDataSet1";
            this.харчоDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеDataGridViewTextBoxColumn,
            this.ингридиентыDataGridViewTextBoxColumn,
            this.грамовкиDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.блюдаBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // ингридиентыDataGridViewTextBoxColumn
            // 
            this.ингридиентыDataGridViewTextBoxColumn.DataPropertyName = "Ингридиенты";
            this.ингридиентыDataGridViewTextBoxColumn.HeaderText = "Ингридиенты";
            this.ингридиентыDataGridViewTextBoxColumn.Name = "ингридиентыDataGridViewTextBoxColumn";
            // 
            // грамовкиDataGridViewTextBoxColumn
            // 
            this.грамовкиDataGridViewTextBoxColumn.DataPropertyName = "Грамовки";
            this.грамовкиDataGridViewTextBoxColumn.HeaderText = "Грамовки";
            this.грамовкиDataGridViewTextBoxColumn.Name = "грамовкиDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // блюдаBindingSource1
            // 
            this.блюдаBindingSource1.DataMember = "Блюда";
            this.блюдаBindingSource1.DataSource = this.харчоDataSet2;
            // 
            // харчоDataSet2
            // 
            this.харчоDataSet2.DataSetName = "харчоDataSet2";
            this.харчоDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // блюдаTableAdapter1
            // 
            this.блюдаTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.продуктDataGridViewTextBoxColumn,
            this.калорийностьВ1ГрDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.продуктыBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(13, 344);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(422, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // продуктDataGridViewTextBoxColumn
            // 
            this.продуктDataGridViewTextBoxColumn.DataPropertyName = "Продукт";
            this.продуктDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.продуктDataGridViewTextBoxColumn.Name = "продуктDataGridViewTextBoxColumn";
            // 
            // калорийностьВ1ГрDataGridViewTextBoxColumn
            // 
            this.калорийностьВ1ГрDataGridViewTextBoxColumn.DataPropertyName = "Калорийность в 1 гр";
            this.калорийностьВ1ГрDataGridViewTextBoxColumn.HeaderText = "Калорийность в 1 гр";
            this.калорийностьВ1ГрDataGridViewTextBoxColumn.Name = "калорийностьВ1ГрDataGridViewTextBoxColumn";
            // 
            // продуктыBindingSource1
            // 
            this.продуктыBindingSource1.DataMember = "Продукты";
            this.продуктыBindingSource1.DataSource = this.харчоDataSet3;
            // 
            // харчоDataSet3
            // 
            this.харчоDataSet3.DataSetName = "харчоDataSet3";
            this.харчоDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продуктыTableAdapter1
            // 
            this.продуктыTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Калорийнось на 100 грамм блюда";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kl
            // 
            this.kl.AutoSize = true;
            this.kl.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kl.ForeColor = System.Drawing.Color.Black;
            this.kl.Location = new System.Drawing.Point(240, 51);
            this.kl.Name = "kl";
            this.kl.Size = new System.Drawing.Size(0, 42);
            this.kl.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Первые блюда",
            "Вторые блюда",
            "Салаты",
            "Десерты"});
            this.comboBox2.Location = new System.Drawing.Point(32, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.kl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.харчоDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.харчоDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.харчоDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.харчоDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private харчоDataSet харчоDataSet;
        private System.Windows.Forms.BindingSource блюдаBindingSource;
        private харчоDataSetTableAdapters.БлюдаTableAdapter блюдаTableAdapter;
        private харчоDataSet1 харчоDataSet1;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private харчоDataSet1TableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private харчоDataSet2 харчоDataSet2;
        private System.Windows.Forms.BindingSource блюдаBindingSource1;
        private харчоDataSet2TableAdapters.БлюдаTableAdapter блюдаTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ингридиентыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn грамовкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private харчоDataSet3 харчоDataSet3;
        private System.Windows.Forms.BindingSource продуктыBindingSource1;
        private харчоDataSet3TableAdapters.ПродуктыTableAdapter продуктыTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn продуктDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn калорийностьВ1ГрDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kl;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

