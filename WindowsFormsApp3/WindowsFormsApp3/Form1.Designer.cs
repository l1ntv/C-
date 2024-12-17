namespace WindowsFormsApp3
{
    partial class FormMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTableCleaner = new System.Windows.Forms.Button();
            this.buttonXmlSaver = new System.Windows.Forms.Button();
            this.buttonXmlLoader = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxLivingEnvironment = new System.Windows.Forms.TextBox();
            this.labelAnimalName = new System.Windows.Forms.Label();
            this.labelIsInRussia = new System.Windows.Forms.Label();
            this.labelLivingEnvironment = new System.Windows.Forms.Label();
            this.labelNutrionNature = new System.Windows.Forms.Label();
            this.labelRedBook = new System.Windows.Forms.Label();
            this.buttonRecordDeleter = new System.Windows.Forms.Button();
            this.buttonRecordEditor = new System.Windows.Forms.Button();
            this.buttonRecordAdder = new System.Windows.Forms.Button();
            this.textBoxAnimalName = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonFromSearcher = new System.Windows.Forms.Button();
            this.labelFromSearcher = new System.Windows.Forms.Label();
            this.checkBoxIsInRussia = new System.Windows.Forms.CheckBox();
            this.comboBoxNutrionNature = new System.Windows.Forms.ComboBox();
            this.checkBoxIsRedBook = new System.Windows.Forms.CheckBox();
            this.checkBoxSearchInRussia = new System.Windows.Forms.CheckBox();
            this.ColumnAnimalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsInRussia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnLivingEnvironment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNutrionNature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRedBook = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.02169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.978308F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.buttonTableCleaner, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonXmlSaver, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonXmlLoader, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(249, 598);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(732, 54);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // buttonTableCleaner
            // 
            this.buttonTableCleaner.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTableCleaner.Location = new System.Drawing.Point(491, 3);
            this.buttonTableCleaner.Name = "buttonTableCleaner";
            this.buttonTableCleaner.Size = new System.Drawing.Size(238, 29);
            this.buttonTableCleaner.TabIndex = 5;
            this.buttonTableCleaner.Text = "Очистить таблицу";
            this.buttonTableCleaner.UseVisualStyleBackColor = true;
            this.buttonTableCleaner.Click += new System.EventHandler(this.buttonTableCleaner_Click);
            // 
            // buttonXmlSaver
            // 
            this.buttonXmlSaver.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonXmlSaver.Location = new System.Drawing.Point(247, 3);
            this.buttonXmlSaver.Name = "buttonXmlSaver";
            this.buttonXmlSaver.Size = new System.Drawing.Size(238, 29);
            this.buttonXmlSaver.TabIndex = 4;
            this.buttonXmlSaver.Text = "Сохранить как XML";
            this.buttonXmlSaver.UseVisualStyleBackColor = true;
            this.buttonXmlSaver.Click += new System.EventHandler(this.buttonXmlSaver_Click);
            // 
            // buttonXmlLoader
            // 
            this.buttonXmlLoader.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonXmlLoader.Location = new System.Drawing.Point(3, 3);
            this.buttonXmlLoader.Name = "buttonXmlLoader";
            this.buttonXmlLoader.Size = new System.Drawing.Size(238, 29);
            this.buttonXmlLoader.TabIndex = 3;
            this.buttonXmlLoader.Text = "Загрузить XML";
            this.buttonXmlLoader.UseVisualStyleBackColor = true;
            this.buttonXmlLoader.Click += new System.EventHandler(this.buttonXmlLoader_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.19553F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.80447F));
            this.tableLayoutPanel.Controls.Add(this.checkBoxIsRedBook, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.textBoxLivingEnvironment, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelAnimalName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelIsInRussia, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelLivingEnvironment, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelNutrionNature, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelRedBook, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.buttonRecordDeleter, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.buttonRecordEditor, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.buttonRecordAdder, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.textBoxAnimalName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonFromSearcher, 1, 10);
            this.tableLayoutPanel.Controls.Add(this.labelFromSearcher, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.checkBoxIsInRussia, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.comboBoxNutrionNature, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.checkBoxSearchInRussia, 1, 9);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 11;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.134063F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.079017F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.134063F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.134063F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.134063F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.134063F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.81562F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.81562F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.89709F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.722336F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(240, 589);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // textBoxLivingEnvironment
            // 
            this.textBoxLivingEnvironment.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxLivingEnvironment.Location = new System.Drawing.Point(87, 85);
            this.textBoxLivingEnvironment.Name = "textBoxLivingEnvironment";
            this.textBoxLivingEnvironment.Size = new System.Drawing.Size(150, 20);
            this.textBoxLivingEnvironment.TabIndex = 11;
            // 
            // labelAnimalName
            // 
            this.labelAnimalName.AutoSize = true;
            this.labelAnimalName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAnimalName.Location = new System.Drawing.Point(3, 0);
            this.labelAnimalName.Name = "labelAnimalName";
            this.labelAnimalName.Size = new System.Drawing.Size(78, 26);
            this.labelAnimalName.TabIndex = 0;
            this.labelAnimalName.Text = "Название животного";
            // 
            // labelIsInRussia
            // 
            this.labelIsInRussia.AutoSize = true;
            this.labelIsInRussia.Location = new System.Drawing.Point(3, 44);
            this.labelIsInRussia.Name = "labelIsInRussia";
            this.labelIsInRussia.Size = new System.Drawing.Size(74, 26);
            this.labelIsInRussia.TabIndex = 1;
            this.labelIsInRussia.Text = "Встречается в России";
            // 
            // labelLivingEnvironment
            // 
            this.labelLivingEnvironment.AutoSize = true;
            this.labelLivingEnvironment.Location = new System.Drawing.Point(3, 82);
            this.labelLivingEnvironment.Name = "labelLivingEnvironment";
            this.labelLivingEnvironment.Size = new System.Drawing.Size(54, 26);
            this.labelLivingEnvironment.TabIndex = 2;
            this.labelLivingEnvironment.Text = "Среда обитания";
            // 
            // labelNutrionNature
            // 
            this.labelNutrionNature.AutoSize = true;
            this.labelNutrionNature.Location = new System.Drawing.Point(3, 126);
            this.labelNutrionNature.Name = "labelNutrionNature";
            this.labelNutrionNature.Size = new System.Drawing.Size(58, 26);
            this.labelNutrionNature.TabIndex = 3;
            this.labelNutrionNature.Text = "Характер питания";
            // 
            // labelRedBook
            // 
            this.labelRedBook.AutoSize = true;
            this.labelRedBook.Location = new System.Drawing.Point(3, 170);
            this.labelRedBook.Name = "labelRedBook";
            this.labelRedBook.Size = new System.Drawing.Size(53, 26);
            this.labelRedBook.TabIndex = 4;
            this.labelRedBook.Text = "Красная книга";
            // 
            // buttonRecordDeleter
            // 
            this.buttonRecordDeleter.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRecordDeleter.Location = new System.Drawing.Point(87, 423);
            this.buttonRecordDeleter.Name = "buttonRecordDeleter";
            this.buttonRecordDeleter.Size = new System.Drawing.Size(150, 30);
            this.buttonRecordDeleter.TabIndex = 6;
            this.buttonRecordDeleter.Text = "Удалить";
            this.buttonRecordDeleter.UseVisualStyleBackColor = true;
            this.buttonRecordDeleter.Click += new System.EventHandler(this.buttonRecordDeleter_Click);
            // 
            // buttonRecordEditor
            // 
            this.buttonRecordEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRecordEditor.Location = new System.Drawing.Point(87, 342);
            this.buttonRecordEditor.Name = "buttonRecordEditor";
            this.buttonRecordEditor.Size = new System.Drawing.Size(150, 30);
            this.buttonRecordEditor.TabIndex = 7;
            this.buttonRecordEditor.Text = "Изменить";
            this.buttonRecordEditor.UseVisualStyleBackColor = true;
            this.buttonRecordEditor.Click += new System.EventHandler(this.buttonRecordEditor_Click);
            // 
            // buttonRecordAdder
            // 
            this.buttonRecordAdder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRecordAdder.Location = new System.Drawing.Point(87, 261);
            this.buttonRecordAdder.Name = "buttonRecordAdder";
            this.buttonRecordAdder.Size = new System.Drawing.Size(150, 30);
            this.buttonRecordAdder.TabIndex = 8;
            this.buttonRecordAdder.Text = "Добавить";
            this.buttonRecordAdder.UseVisualStyleBackColor = true;
            this.buttonRecordAdder.Click += new System.EventHandler(this.buttonRecordAdder_Click);
            // 
            // textBoxAnimalName
            // 
            this.textBoxAnimalName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAnimalName.Location = new System.Drawing.Point(87, 3);
            this.textBoxAnimalName.Name = "textBoxAnimalName";
            this.textBoxAnimalName.Size = new System.Drawing.Size(150, 20);
            this.textBoxAnimalName.TabIndex = 9;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAnimalName,
            this.ColumnIsInRussia,
            this.ColumnLivingEnvironment,
            this.ColumnNutrionNature,
            this.ColumnRedBook});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(249, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(732, 589);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);            // 
            // buttonFromSearcher
            // 
            this.buttonFromSearcher.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFromSearcher.Location = new System.Drawing.Point(87, 546);
            this.buttonFromSearcher.Name = "buttonFromSearcher";
            this.buttonFromSearcher.Size = new System.Drawing.Size(150, 30);
            this.buttonFromSearcher.TabIndex = 17;
            this.buttonFromSearcher.Text = "Поиск";
            this.buttonFromSearcher.UseVisualStyleBackColor = true;
            this.buttonFromSearcher.Click += new System.EventHandler(this.buttonFromSearcher_Click);
            // 
            // labelFromSearcher
            // 
            this.labelFromSearcher.AutoSize = true;
            this.labelFromSearcher.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFromSearcher.Location = new System.Drawing.Point(3, 490);
            this.labelFromSearcher.Name = "labelFromSearcher";
            this.labelFromSearcher.Size = new System.Drawing.Size(78, 39);
            this.labelFromSearcher.TabIndex = 15;
            this.labelFromSearcher.Text = "Поиск по \"Красная книга\":";
            // 
            // checkBoxIsInRussia
            // 
            this.checkBoxIsInRussia.AutoSize = true;
            this.checkBoxIsInRussia.Location = new System.Drawing.Point(87, 47);
            this.checkBoxIsInRussia.Name = "checkBoxIsInRussia";
            this.checkBoxIsInRussia.Size = new System.Drawing.Size(41, 17);
            this.checkBoxIsInRussia.TabIndex = 18;
            this.checkBoxIsInRussia.Text = "Да";
            this.checkBoxIsInRussia.UseVisualStyleBackColor = true;
            // 
            // comboBoxNutrionNature
            // 
            this.comboBoxNutrionNature.FormattingEnabled = true;
            this.comboBoxNutrionNature.Items.AddRange(new object[] {
            "Хищник",
            "Растительноядный",
            "Всеядный"});
            this.comboBoxNutrionNature.Location = new System.Drawing.Point(87, 129);
            this.comboBoxNutrionNature.Name = "comboBoxNutrionNature";
            this.comboBoxNutrionNature.Size = new System.Drawing.Size(150, 21);
            this.comboBoxNutrionNature.TabIndex = 19;
            // 
            // checkBoxIsRedBook
            // 
            this.checkBoxIsRedBook.AutoSize = true;
            this.checkBoxIsRedBook.Location = new System.Drawing.Point(87, 173);
            this.checkBoxIsRedBook.Name = "checkBoxIsRedBook";
            this.checkBoxIsRedBook.Size = new System.Drawing.Size(41, 17);
            this.checkBoxIsRedBook.TabIndex = 20;
            this.checkBoxIsRedBook.Text = "Да";
            this.checkBoxIsRedBook.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearchInRussia
            // 
            this.checkBoxSearchInRussia.AutoSize = true;
            this.checkBoxSearchInRussia.Location = new System.Drawing.Point(87, 493);
            this.checkBoxSearchInRussia.Name = "checkBoxSearchInRussia";
            this.checkBoxSearchInRussia.Size = new System.Drawing.Size(41, 17);
            this.checkBoxSearchInRussia.TabIndex = 21;
            this.checkBoxSearchInRussia.Text = "Да";
            this.checkBoxSearchInRussia.UseVisualStyleBackColor = true;
            // 
            // ColumnAnimalName
            // 
            this.ColumnAnimalName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAnimalName.HeaderText = "Название животного";
            this.ColumnAnimalName.Name = "ColumnAnimalName";
            this.ColumnAnimalName.ReadOnly = true;
            // 
            // ColumnIsInRussia
            // 
            this.ColumnIsInRussia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIsInRussia.FalseValue = "false";
            this.ColumnIsInRussia.HeaderText = "Встречается в России";
            this.ColumnIsInRussia.Name = "ColumnIsInRussia";
            this.ColumnIsInRussia.ReadOnly = true;
            this.ColumnIsInRussia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIsInRussia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnIsInRussia.TrueValue = "true";
            // 
            // ColumnLivingEnvironment
            // 
            this.ColumnLivingEnvironment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnLivingEnvironment.HeaderText = "Среда обитания";
            this.ColumnLivingEnvironment.Name = "ColumnLivingEnvironment";
            this.ColumnLivingEnvironment.ReadOnly = true;
            // 
            // ColumnNutrionNature
            // 
            this.ColumnNutrionNature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNutrionNature.HeaderText = "Характер питания";
            this.ColumnNutrionNature.Name = "ColumnNutrionNature";
            this.ColumnNutrionNature.ReadOnly = true;
            // 
            // ColumnRedBook
            // 
            this.ColumnRedBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRedBook.HeaderText = "Красная книга";
            this.ColumnRedBook.Name = "ColumnRedBook";
            this.ColumnRedBook.ReadOnly = true;
            this.ColumnRedBook.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnRedBook.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животные";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonTableCleaner;
        private System.Windows.Forms.Button buttonXmlSaver;
        private System.Windows.Forms.Button buttonXmlLoader;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox textBoxLivingEnvironment;
        private System.Windows.Forms.Label labelAnimalName;
        private System.Windows.Forms.Label labelIsInRussia;
        private System.Windows.Forms.Label labelLivingEnvironment;
        private System.Windows.Forms.Label labelNutrionNature;
        private System.Windows.Forms.Label labelRedBook;
        private System.Windows.Forms.Button buttonRecordDeleter;
        private System.Windows.Forms.Button buttonRecordEditor;
        private System.Windows.Forms.Button buttonRecordAdder;
        private System.Windows.Forms.TextBox textBoxAnimalName;
        private System.Windows.Forms.Button buttonFromSearcher;
        private System.Windows.Forms.Label labelFromSearcher;
        private System.Windows.Forms.CheckBox checkBoxIsRedBook;
        private System.Windows.Forms.CheckBox checkBoxIsInRussia;
        private System.Windows.Forms.ComboBox comboBoxNutrionNature;
        private System.Windows.Forms.CheckBox checkBoxSearchInRussia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnimalName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsInRussia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLivingEnvironment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNutrionNature;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnRedBook;
    }
}

