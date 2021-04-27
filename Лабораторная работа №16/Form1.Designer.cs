
namespace Лабораторная_работа__16
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
            this.dvgRaw = new System.Windows.Forms.DataGridView();
            this.dvgSummary = new System.Windows.Forms.DataGridView();
            this.bntLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dvgSummury2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSummury2)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgRaw
            // 
            this.dvgRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRaw.Location = new System.Drawing.Point(13, 13);
            this.dvgRaw.Name = "dvgRaw";
            this.dvgRaw.RowHeadersWidth = 51;
            this.dvgRaw.RowTemplate.Height = 24;
            this.dvgRaw.Size = new System.Drawing.Size(420, 374);
            this.dvgRaw.TabIndex = 0;
            // 
            // dvgSummary
            // 
            this.dvgSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSummary.Location = new System.Drawing.Point(449, 13);
            this.dvgSummary.Name = "dvgSummary";
            this.dvgSummary.RowHeadersWidth = 51;
            this.dvgSummary.RowTemplate.Height = 24;
            this.dvgSummary.Size = new System.Drawing.Size(339, 163);
            this.dvgSummary.TabIndex = 1;
            // 
            // bntLoad
            // 
            this.bntLoad.Location = new System.Drawing.Point(13, 394);
            this.bntLoad.Name = "bntLoad";
            this.bntLoad.Size = new System.Drawing.Size(247, 51);
            this.bntLoad.TabIndex = 2;
            this.bntLoad.Text = "Загрузить данные";
            this.bntLoad.UseVisualStyleBackColor = true;
            this.bntLoad.Click += new System.EventHandler(this.bntLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dvgSummury2
            // 
            this.dvgSummury2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSummury2.Location = new System.Drawing.Point(449, 182);
            this.dvgSummury2.Name = "dvgSummury2";
            this.dvgSummury2.RowHeadersWidth = 51;
            this.dvgSummury2.RowTemplate.Height = 24;
            this.dvgSummury2.Size = new System.Drawing.Size(339, 205);
            this.dvgSummury2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgSummury2);
            this.Controls.Add(this.bntLoad);
            this.Controls.Add(this.dvgSummary);
            this.Controls.Add(this.dvgRaw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Загрузка данных";
            ((System.ComponentModel.ISupportInitialize)(this.dvgRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSummury2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgRaw;
        private System.Windows.Forms.DataGridView dvgSummary;
        private System.Windows.Forms.Button bntLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dvgSummury2;
    }
}

