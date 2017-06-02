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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResultMatch = new System.Windows.Forms.TextBox();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.textBoxResultReplace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(150, 7);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(461, 26);
            this.textBoxInput.TabIndex = 0;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(150, 37);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(461, 26);
            this.textBoxFind.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Входная строка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Строка поиска";
            // 
            // textBoxResultMatch
            // 
            this.textBoxResultMatch.Location = new System.Drawing.Point(150, 67);
            this.textBoxResultMatch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResultMatch.Name = "textBoxResultMatch";
            this.textBoxResultMatch.ReadOnly = true;
            this.textBoxResultMatch.Size = new System.Drawing.Size(461, 26);
            this.textBoxResultMatch.TabIndex = 4;
            // 
            // buttonMatch
            // 
            this.buttonMatch.Location = new System.Drawing.Point(10, 70);
            this.buttonMatch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(127, 26);
            this.buttonMatch.TabIndex = 5;
            this.buttonMatch.Text = "Поиск";
            this.buttonMatch.UseVisualStyleBackColor = true;
            this.buttonMatch.Click += new System.EventHandler(this.buttonMatch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Строка замены";
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(150, 102);
            this.textBoxReplace.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(461, 26);
            this.textBoxReplace.TabIndex = 6;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(10, 135);
            this.buttonReplace.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(127, 26);
            this.buttonReplace.TabIndex = 9;
            this.buttonReplace.Text = "Замена";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // textBoxResultReplace
            // 
            this.textBoxResultReplace.Location = new System.Drawing.Point(150, 137);
            this.textBoxResultReplace.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResultReplace.Name = "textBoxResultReplace";
            this.textBoxResultReplace.ReadOnly = true;
            this.textBoxResultReplace.Size = new System.Drawing.Size(461, 26);
            this.textBoxResultReplace.TabIndex = 8;
            // 
            // FormRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.textBoxResultReplace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.buttonMatch);
            this.Controls.Add(this.textBoxResultMatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.textBoxInput);
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

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResultMatch;
        private System.Windows.Forms.Button buttonMatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.TextBox textBoxResultReplace;
    }
}

