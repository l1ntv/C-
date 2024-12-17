namespace WindowsFormsApp1
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
            this.buttonChangeCheckBox = new System.Windows.Forms.Button();
            this.labelChangeMainForm = new System.Windows.Forms.Label();
            this.myCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonChangeCheckBox
            // 
            this.buttonChangeCheckBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeCheckBox.Location = new System.Drawing.Point(321, 344);
            this.buttonChangeCheckBox.Name = "buttonChangeCheckBox";
            this.buttonChangeCheckBox.Size = new System.Drawing.Size(174, 77);
            this.buttonChangeCheckBox.TabIndex = 0;
            this.buttonChangeCheckBox.Text = "Настроить";
            this.buttonChangeCheckBox.UseVisualStyleBackColor = true;
            this.buttonChangeCheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonChangeCheckBox_Click);
            // 
            // labelChangeMainForm
            // 
            this.labelChangeMainForm.AutoSize = true;
            this.labelChangeMainForm.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChangeMainForm.Location = new System.Drawing.Point(186, 139);
            this.labelChangeMainForm.Name = "labelChangeMainForm";
            this.labelChangeMainForm.Size = new System.Drawing.Size(469, 23);
            this.labelChangeMainForm.TabIndex = 1;
            this.labelChangeMainForm.Text = "Щёлкните по кнопке для задания свойств CheckBox";
            // 
            // myCheckBox
            // 
            this.myCheckBox.AutoSize = true;
            this.myCheckBox.Checked = true;
            this.myCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.myCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.myCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.myCheckBox.Location = new System.Drawing.Point(304, 237);
            this.myCheckBox.Name = "myCheckBox";
            this.myCheckBox.Size = new System.Drawing.Size(216, 35);
            this.myCheckBox.TabIndex = 2;
            this.myCheckBox.Text = "Мой CheckBox";
            this.myCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 540);
            this.Controls.Add(this.myCheckBox);
            this.Controls.Add(this.labelChangeMainForm);
            this.Controls.Add(this.buttonChangeCheckBox);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChangeCheckBox;
        private System.Windows.Forms.Label labelChangeMainForm;
        private System.Windows.Forms.CheckBox myCheckBox;
    }
}

