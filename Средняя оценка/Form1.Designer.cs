namespace Средняя_оценка
{
    partial class FormAvgNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvgNote));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_avg = new System.Windows.Forms.Label();
            this.label_qty = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.button_4, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.button_5, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.button_3, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.button_2, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.button_clear, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.label_avg, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label_qty, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(397, 371);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // button_5
            // 
            this.button_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_5.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_5.Location = new System.Drawing.Point(3, 3);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(192, 86);
            this.button_5.TabIndex = 0;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_4.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_4.Location = new System.Drawing.Point(3, 95);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(192, 86);
            this.button_4.TabIndex = 1;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_3
            // 
            this.button_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_3.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_3.Location = new System.Drawing.Point(3, 187);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(192, 86);
            this.button_3.TabIndex = 2;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_2.Location = new System.Drawing.Point(3, 279);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(192, 89);
            this.button_2.TabIndex = 3;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_clear
            // 
            this.button_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_clear.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(201, 279);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(193, 89);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "сброс";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_avg
            // 
            this.label_avg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_avg.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_avg.Location = new System.Drawing.Point(201, 0);
            this.label_avg.Name = "label_avg";
            this.label_avg.Size = new System.Drawing.Size(193, 92);
            this.label_avg.TabIndex = 5;
            this.label_avg.Text = "-";
            this.label_avg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label_avg, "Среднее арифметическое всех оценок");
            // 
            // label_qty
            // 
            this.label_qty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_qty.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_qty.Location = new System.Drawing.Point(201, 92);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(193, 92);
            this.label_qty.TabIndex = 6;
            this.label_qty.Text = "-";
            this.label_qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label_qty, "Количество оценок");
            // 
            // FormAvgNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 371);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(240, 250);
            this.Name = "FormAvgNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Средняя оценка";
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_avg;
        private System.Windows.Forms.Label label_qty;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

