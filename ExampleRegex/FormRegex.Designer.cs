namespace ExmampleRegex
{
    partial class FormRegex
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
			this.textBoxFind = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonMatch = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxReplace = new System.Windows.Forms.TextBox();
			this.buttonReplace = new System.Windows.Forms.Button();
			this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
			this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
			this.buttonCsv = new System.Windows.Forms.Button();
			this.buttonReplaceMacro = new System.Windows.Forms.Button();
			this.buttonLoadFile = new System.Windows.Forms.Button();
			this.groupBoxSettings = new System.Windows.Forms.GroupBox();
			this.checkBoxEndWith = new System.Windows.Forms.CheckBox();
			this.checkBoxStartWith = new System.Windows.Forms.CheckBox();
			this.checkBoxIgnoreCase = new System.Windows.Forms.CheckBox();
			this.groupBoxSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxFind
			// 
			this.textBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFind.Enabled = false;
			this.textBoxFind.Location = new System.Drawing.Point(150, 139);
			this.textBoxFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxFind.Name = "textBoxFind";
			this.textBoxFind.Size = new System.Drawing.Size(484, 26);
			this.textBoxFind.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(961, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input text";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 140);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Search substring";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonMatch
			// 
			this.buttonMatch.Enabled = false;
			this.buttonMatch.Location = new System.Drawing.Point(198, 200);
			this.buttonMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonMatch.Name = "buttonMatch";
			this.buttonMatch.Size = new System.Drawing.Size(180, 30);
			this.buttonMatch.TabIndex = 6;
			this.buttonMatch.Text = "Search";
			this.buttonMatch.UseVisualStyleBackColor = true;
			this.buttonMatch.Click += new System.EventHandler(this.buttonMatch_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 175);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Replace substring";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxReplace
			// 
			this.textBoxReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxReplace.Enabled = false;
			this.textBoxReplace.Location = new System.Drawing.Point(150, 169);
			this.textBoxReplace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxReplace.Name = "textBoxReplace";
			this.textBoxReplace.Size = new System.Drawing.Size(484, 26);
			this.textBoxReplace.TabIndex = 5;
			// 
			// buttonReplace
			// 
			this.buttonReplace.Enabled = false;
			this.buttonReplace.Location = new System.Drawing.Point(10, 239);
			this.buttonReplace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonReplace.Name = "buttonReplace";
			this.buttonReplace.Size = new System.Drawing.Size(180, 30);
			this.buttonReplace.TabIndex = 7;
			this.buttonReplace.Text = "Replace";
			this.buttonReplace.UseVisualStyleBackColor = true;
			this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
			// 
			// richTextBoxInput
			// 
			this.richTextBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxInput.Location = new System.Drawing.Point(10, 34);
			this.richTextBoxInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.richTextBoxInput.Name = "richTextBoxInput";
			this.richTextBoxInput.Size = new System.Drawing.Size(962, 100);
			this.richTextBoxInput.TabIndex = 1;
			this.richTextBoxInput.Text = "";
			this.richTextBoxInput.TextChanged += new System.EventHandler(this.richTextBoxInput_TextChanged);
			// 
			// richTextBoxResult
			// 
			this.richTextBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxResult.Location = new System.Drawing.Point(12, 276);
			this.richTextBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.richTextBoxResult.Name = "richTextBoxResult";
			this.richTextBoxResult.ReadOnly = true;
			this.richTextBoxResult.Size = new System.Drawing.Size(962, 185);
			this.richTextBoxResult.TabIndex = 8;
			this.richTextBoxResult.Text = "";
			// 
			// buttonCsv
			// 
			this.buttonCsv.Enabled = false;
			this.buttonCsv.Location = new System.Drawing.Point(386, 200);
			this.buttonCsv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonCsv.Name = "buttonCsv";
			this.buttonCsv.Size = new System.Drawing.Size(180, 30);
			this.buttonCsv.TabIndex = 9;
			this.buttonCsv.Text = "Parsing file";
			this.buttonCsv.UseVisualStyleBackColor = true;
			this.buttonCsv.Click += new System.EventHandler(this.buttonWord_Click);
			// 
			// buttonReplaceMacro
			// 
			this.buttonReplaceMacro.Enabled = false;
			this.buttonReplaceMacro.Location = new System.Drawing.Point(198, 240);
			this.buttonReplaceMacro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonReplaceMacro.Name = "buttonReplaceMacro";
			this.buttonReplaceMacro.Size = new System.Drawing.Size(180, 30);
			this.buttonReplaceMacro.TabIndex = 10;
			this.buttonReplaceMacro.Text = "Replace macro names";
			this.buttonReplaceMacro.UseVisualStyleBackColor = true;
			this.buttonReplaceMacro.Click += new System.EventHandler(this.buttonReplaceMacro_Click);
			// 
			// buttonLoadFile
			// 
			this.buttonLoadFile.Location = new System.Drawing.Point(10, 200);
			this.buttonLoadFile.Margin = new System.Windows.Forms.Padding(4);
			this.buttonLoadFile.Name = "buttonLoadFile";
			this.buttonLoadFile.Size = new System.Drawing.Size(180, 30);
			this.buttonLoadFile.TabIndex = 11;
			this.buttonLoadFile.Text = "Load file";
			this.buttonLoadFile.UseVisualStyleBackColor = true;
			this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
			// 
			// groupBoxSettings
			// 
			this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxSettings.Controls.Add(this.checkBoxIgnoreCase);
			this.groupBoxSettings.Controls.Add(this.checkBoxEndWith);
			this.groupBoxSettings.Controls.Add(this.checkBoxStartWith);
			this.groupBoxSettings.Location = new System.Drawing.Point(641, 139);
			this.groupBoxSettings.Name = "groupBoxSettings";
			this.groupBoxSettings.Size = new System.Drawing.Size(330, 131);
			this.groupBoxSettings.TabIndex = 15;
			this.groupBoxSettings.TabStop = false;
			this.groupBoxSettings.Text = "Settings";
			// 
			// checkBoxEndWith
			// 
			this.checkBoxEndWith.AutoSize = true;
			this.checkBoxEndWith.Enabled = false;
			this.checkBoxEndWith.Location = new System.Drawing.Point(110, 20);
			this.checkBoxEndWith.Name = "checkBoxEndWith";
			this.checkBoxEndWith.Size = new System.Drawing.Size(89, 24);
			this.checkBoxEndWith.TabIndex = 16;
			this.checkBoxEndWith.Text = "End with";
			this.checkBoxEndWith.UseVisualStyleBackColor = true;
			// 
			// checkBoxStartWith
			// 
			this.checkBoxStartWith.AutoSize = true;
			this.checkBoxStartWith.Enabled = false;
			this.checkBoxStartWith.Location = new System.Drawing.Point(10, 20);
			this.checkBoxStartWith.Name = "checkBoxStartWith";
			this.checkBoxStartWith.Size = new System.Drawing.Size(95, 24);
			this.checkBoxStartWith.TabIndex = 15;
			this.checkBoxStartWith.Text = "Start with";
			this.checkBoxStartWith.UseVisualStyleBackColor = true;
			// 
			// checkBoxIgnoreCase
			// 
			this.checkBoxIgnoreCase.AutoSize = true;
			this.checkBoxIgnoreCase.Checked = true;
			this.checkBoxIgnoreCase.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxIgnoreCase.Enabled = false;
			this.checkBoxIgnoreCase.Location = new System.Drawing.Point(10, 50);
			this.checkBoxIgnoreCase.Name = "checkBoxIgnoreCase";
			this.checkBoxIgnoreCase.Size = new System.Drawing.Size(112, 24);
			this.checkBoxIgnoreCase.TabIndex = 17;
			this.checkBoxIgnoreCase.Text = "Ignore case";
			this.checkBoxIgnoreCase.UseVisualStyleBackColor = true;
			// 
			// FormRegex
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 461);
			this.Controls.Add(this.groupBoxSettings);
			this.Controls.Add(this.buttonLoadFile);
			this.Controls.Add(this.buttonReplaceMacro);
			this.Controls.Add(this.buttonCsv);
			this.Controls.Add(this.richTextBoxResult);
			this.Controls.Add(this.richTextBoxInput);
			this.Controls.Add(this.buttonReplace);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxReplace);
			this.Controls.Add(this.buttonMatch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxFind);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRegex";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Regex";
			this.groupBoxSettings.ResumeLayout(false);
			this.groupBoxSettings.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button buttonCsv;
        private System.Windows.Forms.Button buttonReplaceMacro;
		private System.Windows.Forms.Button buttonLoadFile;
		private System.Windows.Forms.GroupBox groupBoxSettings;
		private System.Windows.Forms.CheckBox checkBoxIgnoreCase;
		private System.Windows.Forms.CheckBox checkBoxEndWith;
		private System.Windows.Forms.CheckBox checkBoxStartWith;
	}
}

