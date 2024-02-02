namespace Auto
{
    partial class MainForm
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
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.AutoScroll = true;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ViewPanel.Location = new System.Drawing.Point(0, 182);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1032, 473);
            this.ViewPanel.TabIndex = 8;
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(1032, 55);
            this.UserPanel.TabIndex = 9;
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 55);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(1032, 127);
            this.FiltrPanel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1032, 655);
            this.Controls.Add(this.FiltrPanel);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.ViewPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Panel FiltrPanel;
    }
}

