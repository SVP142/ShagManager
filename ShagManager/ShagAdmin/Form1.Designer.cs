namespace ShagAdmin
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьМенеджераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьМенеджераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьМенеджераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьМенеджераToolStripMenuItem,
            this.редактироватьМенеджераToolStripMenuItem,
            this.удалитьМенеджераToolStripMenuItem,
            this.статистикаToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // добавитьМенеджераToolStripMenuItem
            // 
            this.добавитьМенеджераToolStripMenuItem.Name = "добавитьМенеджераToolStripMenuItem";
            this.добавитьМенеджераToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.добавитьМенеджераToolStripMenuItem.Text = "Добавить Менеджера";
            // 
            // редактироватьМенеджераToolStripMenuItem
            // 
            this.редактироватьМенеджераToolStripMenuItem.Name = "редактироватьМенеджераToolStripMenuItem";
            this.редактироватьМенеджераToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.редактироватьМенеджераToolStripMenuItem.Text = "Редактировать Менеджера";
            // 
            // удалитьМенеджераToolStripMenuItem
            // 
            this.удалитьМенеджераToolStripMenuItem.Name = "удалитьМенеджераToolStripMenuItem";
            this.удалитьМенеджераToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.удалитьМенеджераToolStripMenuItem.Text = "Удалить Менеджера";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 405);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Администрирование";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьМенеджераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьМенеджераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьМенеджераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
    }
}

