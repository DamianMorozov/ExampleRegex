namespace StudingRegex
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
            this.SuspendLayout();
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(150, 140);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(1021, 26);
            this.textBoxFind.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Входной текст";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Строка поиска";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMatch
            // 
            this.buttonMatch.Location = new System.Drawing.Point(10, 210);
            this.buttonMatch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(180, 26);
            this.buttonMatch.TabIndex = 6;
            this.buttonMatch.Text = "Поиск";
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
            this.label3.Text = "Строка замены";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(150, 170);
            this.textBoxReplace.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(1021, 26);
            this.textBoxReplace.TabIndex = 5;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(200, 210);
            this.buttonReplace.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(180, 26);
            this.buttonReplace.TabIndex = 7;
            this.buttonReplace.Text = "Замена";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInput.Location = new System.Drawing.Point(10, 35);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(1162, 100);
            this.richTextBoxInput.TabIndex = 1;
            this.richTextBoxInput.Text = "";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxResult.Location = new System.Drawing.Point(12, 245);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.Size = new System.Drawing.Size(1162, 200);
            this.richTextBoxResult.TabIndex = 8;
            this.richTextBoxResult.Text = "";
            // 
            // buttonCsv
            // 
            this.buttonCsv.Location = new System.Drawing.Point(390, 210);
            this.buttonCsv.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCsv.Name = "buttonCsv";
            this.buttonCsv.Size = new System.Drawing.Size(180, 26);
            this.buttonCsv.TabIndex = 9;
            this.buttonCsv.Text = "Разбор csv-файла";
            this.buttonCsv.UseVisualStyleBackColor = true;
            this.buttonCsv.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // buttonReplaceMacro
            // 
            this.buttonReplaceMacro.Location = new System.Drawing.Point(580, 210);
            this.buttonReplaceMacro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReplaceMacro.Name = "buttonReplaceMacro";
            this.buttonReplaceMacro.Size = new System.Drawing.Size(180, 26);
            this.buttonReplaceMacro.TabIndex = 10;
            this.buttonReplaceMacro.Text = "Замена макроимён";
            this.buttonReplaceMacro.UseVisualStyleBackColor = true;
            this.buttonReplaceMacro.Click += new System.EventHandler(this.buttonReplaceMacro_Click);
            // 
            // FormRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 462);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регулярные выражения";
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
    }
}

