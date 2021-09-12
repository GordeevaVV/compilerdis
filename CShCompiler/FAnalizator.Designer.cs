
namespace CShCompiler
{
    partial class FAnalizator
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
            this.btRead = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(13, 14);
            this.btRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(170, 47);
            this.btRead.TabIndex = 0;
            this.btRead.Text = "Загрузить";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(206, 14);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(170, 47);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FAnalizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 349);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btRead);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FAnalizator";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализатор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btClose;
    }
}

