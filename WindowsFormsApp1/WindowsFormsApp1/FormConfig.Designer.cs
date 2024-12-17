namespace WindowsFormsApp1
{
    partial class FormConfig
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
            this.groupBoxCheckStateParameter = new System.Windows.Forms.GroupBox();
            this.radioButtonIndeterminate = new System.Windows.Forms.RadioButton();
            this.radioButtonChecked = new System.Windows.Forms.RadioButton();
            this.groupBoxFlatStyleParameter = new System.Windows.Forms.GroupBox();
            this.radioButtonSystem = new System.Windows.Forms.RadioButton();
            this.radioButtonStandart = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.radioButtonUnchecked = new System.Windows.Forms.RadioButton();
            this.labelCursor = new System.Windows.Forms.Label();
            this.cursorComboBox = new System.Windows.Forms.ComboBox();
            this.radioButtonFlat = new System.Windows.Forms.RadioButton();
            this.radioButtonPopup = new System.Windows.Forms.RadioButton();
            this.groupBoxEnabled = new System.Windows.Forms.GroupBox();
            this.radioButtonFalse = new System.Windows.Forms.RadioButton();
            this.radioButtonTrue = new System.Windows.Forms.RadioButton();
            this.groupBoxCheckStateParameter.SuspendLayout();
            this.groupBoxFlatStyleParameter.SuspendLayout();
            this.groupBoxEnabled.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCheckStateParameter
            // 
            this.groupBoxCheckStateParameter.Controls.Add(this.radioButtonUnchecked);
            this.groupBoxCheckStateParameter.Controls.Add(this.radioButtonIndeterminate);
            this.groupBoxCheckStateParameter.Controls.Add(this.radioButtonChecked);
            this.groupBoxCheckStateParameter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCheckStateParameter.Location = new System.Drawing.Point(53, 68);
            this.groupBoxCheckStateParameter.Name = "groupBoxCheckStateParameter";
            this.groupBoxCheckStateParameter.Size = new System.Drawing.Size(254, 119);
            this.groupBoxCheckStateParameter.TabIndex = 3;
            this.groupBoxCheckStateParameter.TabStop = false;
            this.groupBoxCheckStateParameter.Text = "CheckState параметр";
            // 
            // radioButtonIndeterminate
            // 
            this.radioButtonIndeterminate.AutoSize = true;
            this.radioButtonIndeterminate.Location = new System.Drawing.Point(18, 90);
            this.radioButtonIndeterminate.Name = "radioButtonIndeterminate";
            this.radioButtonIndeterminate.Size = new System.Drawing.Size(128, 25);
            this.radioButtonIndeterminate.TabIndex = 1;
            this.radioButtonIndeterminate.TabStop = true;
            this.radioButtonIndeterminate.Text = "Indeterminate";
            this.radioButtonIndeterminate.UseVisualStyleBackColor = true;
            // 
            // radioButtonChecked
            // 
            this.radioButtonChecked.AutoSize = true;
            this.radioButtonChecked.Checked = true;
            this.radioButtonChecked.Location = new System.Drawing.Point(18, 28);
            this.radioButtonChecked.Name = "radioButtonChecked";
            this.radioButtonChecked.Size = new System.Drawing.Size(94, 25);
            this.radioButtonChecked.TabIndex = 0;
            this.radioButtonChecked.TabStop = true;
            this.radioButtonChecked.Text = "Checked";
            this.radioButtonChecked.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlatStyleParameter
            // 
            this.groupBoxFlatStyleParameter.Controls.Add(this.radioButtonPopup);
            this.groupBoxFlatStyleParameter.Controls.Add(this.radioButtonFlat);
            this.groupBoxFlatStyleParameter.Controls.Add(this.radioButtonSystem);
            this.groupBoxFlatStyleParameter.Controls.Add(this.radioButtonStandart);
            this.groupBoxFlatStyleParameter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFlatStyleParameter.Location = new System.Drawing.Point(53, 204);
            this.groupBoxFlatStyleParameter.Name = "groupBoxFlatStyleParameter";
            this.groupBoxFlatStyleParameter.Size = new System.Drawing.Size(254, 99);
            this.groupBoxFlatStyleParameter.TabIndex = 5;
            this.groupBoxFlatStyleParameter.TabStop = false;
            this.groupBoxFlatStyleParameter.Text = "FlatStyle параметр";
            // 
            // radioButtonSystem
            // 
            this.radioButtonSystem.AutoSize = true;
            this.radioButtonSystem.Location = new System.Drawing.Point(18, 59);
            this.radioButtonSystem.Name = "radioButtonSystem";
            this.radioButtonSystem.Size = new System.Drawing.Size(83, 25);
            this.radioButtonSystem.TabIndex = 1;
            this.radioButtonSystem.Text = "System";
            this.radioButtonSystem.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandart
            // 
            this.radioButtonStandart.AutoSize = true;
            this.radioButtonStandart.Checked = true;
            this.radioButtonStandart.Location = new System.Drawing.Point(18, 28);
            this.radioButtonStandart.Name = "radioButtonStandart";
            this.radioButtonStandart.Size = new System.Drawing.Size(90, 25);
            this.radioButtonStandart.TabIndex = 0;
            this.radioButtonStandart.Text = "Standart";
            this.radioButtonStandart.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(71, 421);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(88, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(197, 421);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnchecked
            // 
            this.radioButtonUnchecked.AutoSize = true;
            this.radioButtonUnchecked.Location = new System.Drawing.Point(18, 59);
            this.radioButtonUnchecked.Name = "radioButtonUnchecked";
            this.radioButtonUnchecked.Size = new System.Drawing.Size(103, 25);
            this.radioButtonUnchecked.TabIndex = 2;
            this.radioButtonUnchecked.TabStop = true;
            this.radioButtonUnchecked.Text = "Uncheked";
            this.radioButtonUnchecked.UseVisualStyleBackColor = true;
            // 
            // labelCursor
            // 
            this.labelCursor.AutoSize = true;
            this.labelCursor.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelCursor.Location = new System.Drawing.Point(49, 31);
            this.labelCursor.Name = "labelCursor";
            this.labelCursor.Size = new System.Drawing.Size(62, 21);
            this.labelCursor.TabIndex = 8;
            this.labelCursor.Text = "Cursor";
            // 
            // cursorComboBox
            // 
            this.cursorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cursorComboBox.FormattingEnabled = true;
            this.cursorComboBox.Location = new System.Drawing.Point(126, 31);
            this.cursorComboBox.Name = "cursorComboBox";
            this.cursorComboBox.Size = new System.Drawing.Size(181, 23);
            this.cursorComboBox.TabIndex = 9;
            // 
            // radioButtonFlat
            // 
            this.radioButtonFlat.AutoSize = true;
            this.radioButtonFlat.Location = new System.Drawing.Point(144, 28);
            this.radioButtonFlat.Name = "radioButtonFlat";
            this.radioButtonFlat.Size = new System.Drawing.Size(56, 25);
            this.radioButtonFlat.TabIndex = 2;
            this.radioButtonFlat.Text = "Flat";
            this.radioButtonFlat.UseVisualStyleBackColor = true;
            // 
            // radioButtonPopup
            // 
            this.radioButtonPopup.AutoSize = true;
            this.radioButtonPopup.Location = new System.Drawing.Point(144, 59);
            this.radioButtonPopup.Name = "radioButtonPopup";
            this.radioButtonPopup.Size = new System.Drawing.Size(78, 25);
            this.radioButtonPopup.TabIndex = 3;
            this.radioButtonPopup.Text = "Popup";
            this.radioButtonPopup.UseVisualStyleBackColor = true;
            // 
            // groupBoxEnabled
            // 
            this.groupBoxEnabled.Controls.Add(this.radioButtonFalse);
            this.groupBoxEnabled.Controls.Add(this.radioButtonTrue);
            this.groupBoxEnabled.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxEnabled.Location = new System.Drawing.Point(53, 320);
            this.groupBoxEnabled.Name = "groupBoxEnabled";
            this.groupBoxEnabled.Size = new System.Drawing.Size(254, 60);
            this.groupBoxEnabled.TabIndex = 6;
            this.groupBoxEnabled.TabStop = false;
            this.groupBoxEnabled.Text = "Enabled параметр";
            // 
            // radioButtonFalse
            // 
            this.radioButtonFalse.AutoSize = true;
            this.radioButtonFalse.Location = new System.Drawing.Point(144, 28);
            this.radioButtonFalse.Name = "radioButtonFalse";
            this.radioButtonFalse.Size = new System.Drawing.Size(67, 25);
            this.radioButtonFalse.TabIndex = 2;
            this.radioButtonFalse.Text = "False";
            this.radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrue
            // 
            this.radioButtonTrue.AutoSize = true;
            this.radioButtonTrue.Checked = true;
            this.radioButtonTrue.Location = new System.Drawing.Point(18, 28);
            this.radioButtonTrue.Name = "radioButtonTrue";
            this.radioButtonTrue.Size = new System.Drawing.Size(62, 25);
            this.radioButtonTrue.TabIndex = 0;
            this.radioButtonTrue.Text = "True";
            this.radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // FormConfig
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(355, 457);
            this.Controls.Add(this.groupBoxEnabled);
            this.Controls.Add(this.cursorComboBox);
            this.Controls.Add(this.labelCursor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxFlatStyleParameter);
            this.Controls.Add(this.groupBoxCheckStateParameter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задайте параметры CheckBox";
            this.groupBoxCheckStateParameter.ResumeLayout(false);
            this.groupBoxCheckStateParameter.PerformLayout();
            this.groupBoxFlatStyleParameter.ResumeLayout(false);
            this.groupBoxFlatStyleParameter.PerformLayout();
            this.groupBoxEnabled.ResumeLayout(false);
            this.groupBoxEnabled.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCheckStateParameter;
        private System.Windows.Forms.RadioButton radioButtonIndeterminate;
        private System.Windows.Forms.RadioButton radioButtonChecked;
        private System.Windows.Forms.GroupBox groupBoxFlatStyleParameter;
        private System.Windows.Forms.RadioButton radioButtonSystem;
        private System.Windows.Forms.RadioButton radioButtonStandart;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButtonUnchecked;
        private System.Windows.Forms.Label labelCursor;
        private System.Windows.Forms.ComboBox cursorComboBox;
        private System.Windows.Forms.RadioButton radioButtonPopup;
        private System.Windows.Forms.RadioButton radioButtonFlat;
        private System.Windows.Forms.GroupBox groupBoxEnabled;
        private System.Windows.Forms.RadioButton radioButtonFalse;
        private System.Windows.Forms.RadioButton radioButtonTrue;
    }
}