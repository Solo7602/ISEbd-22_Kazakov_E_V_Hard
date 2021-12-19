
namespace labaBuldozerKazakovISEbd_22
{
    partial class ParkingPlace
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
            this.pictureBoxPark = new System.Windows.Forms.PictureBox();
            this.buttonParking = new System.Windows.Forms.Button();
            this.groupBoxPark = new System.Windows.Forms.GroupBox();
            this.buttonInQueue = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxParking = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.buttonOutQueue = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПарковкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьПарковкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPark)).BeginInit();
            this.groupBoxPark.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPark
            // 
            this.pictureBoxPark.Location = new System.Drawing.Point(0, 27);
            this.pictureBoxPark.Name = "pictureBoxPark";
            this.pictureBoxPark.Size = new System.Drawing.Size(683, 422);
            this.pictureBoxPark.TabIndex = 0;
            this.pictureBoxPark.TabStop = false;
            // 
            // buttonParking
            // 
            this.buttonParking.Location = new System.Drawing.Point(694, 303);
            this.buttonParking.Name = "buttonParking";
            this.buttonParking.Size = new System.Drawing.Size(97, 41);
            this.buttonParking.TabIndex = 1;
            this.buttonParking.Text = "Припарковать бульдозер";
            this.buttonParking.UseVisualStyleBackColor = true;
            this.buttonParking.Click += new System.EventHandler(this.buttonParking_Click);
            // 
            // groupBoxPark
            // 
            this.groupBoxPark.Controls.Add(this.buttonInQueue);
            this.groupBoxPark.Controls.Add(this.maskedTextBoxNumber);
            this.groupBoxPark.Controls.Add(this.label2);
            this.groupBoxPark.Controls.Add(this.label1);
            this.groupBoxPark.Location = new System.Drawing.Point(689, 350);
            this.groupBoxPark.Name = "groupBoxPark";
            this.groupBoxPark.Size = new System.Drawing.Size(112, 99);
            this.groupBoxPark.TabIndex = 3;
            this.groupBoxPark.TabStop = false;
            // 
            // buttonInQueue
            // 
            this.buttonInQueue.Location = new System.Drawing.Point(13, 61);
            this.buttonInQueue.Name = "buttonInQueue";
            this.buttonInQueue.Size = new System.Drawing.Size(88, 38);
            this.buttonInQueue.TabIndex = 3;
            this.buttonInQueue.Text = "Добавить в очередь";
            this.buttonInQueue.UseVisualStyleBackColor = true;
            this.buttonInQueue.Click += new System.EventHandler(this.buttonInQueue_Click);
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(60, 35);
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBoxNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Место:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить бульдозер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Парковки:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(694, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // listBoxParking
            // 
            this.listBoxParking.FormattingEnabled = true;
            this.listBoxParking.Location = new System.Drawing.Point(689, 81);
            this.listBoxParking.Name = "listBoxParking";
            this.listBoxParking.Size = new System.Drawing.Size(106, 82);
            this.listBoxParking.TabIndex = 6;
            this.listBoxParking.SelectedIndexChanged += new System.EventHandler(this.listBoxParking_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(684, 169);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(116, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить парковку";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(684, 52);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(116, 23);
            this.buttonAddParking.TabIndex = 8;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonOutQueue
            // 
            this.buttonOutQueue.Location = new System.Drawing.Point(694, 263);
            this.buttonOutQueue.Name = "buttonOutQueue";
            this.buttonOutQueue.Size = new System.Drawing.Size(96, 34);
            this.buttonOutQueue.TabIndex = 9;
            this.buttonOutQueue.Text = "Забрать из очереди";
            this.buttonOutQueue.UseVisualStyleBackColor = true;
            this.buttonOutQueue.Click += new System.EventHandler(this.buttonOutQueue_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.сохранитьПарковкуToolStripMenuItem,
            this.загрузитьПарковкуToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьПарковкуToolStripMenuItem
            // 
            this.сохранитьПарковкуToolStripMenuItem.Name = "сохранитьПарковкуToolStripMenuItem";
            this.сохранитьПарковкуToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.сохранитьПарковкуToolStripMenuItem.Text = "Сохранить парковку";
            this.сохранитьПарковкуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПарковкуToolStripMenuItem_Click);
            // 
            // загрузитьПарковкуToolStripMenuItem
            // 
            this.загрузитьПарковкуToolStripMenuItem.Name = "загрузитьПарковкуToolStripMenuItem";
            this.загрузитьПарковкуToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.загрузитьПарковкуToolStripMenuItem.Text = "Загрузить парковку";
            this.загрузитьПарковкуToolStripMenuItem.Click += new System.EventHandler(this.загрузитьПарковкуToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt file | *.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt file | *.txt";
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(694, 220);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(94, 37);
            this.button_sort.TabIndex = 11;
            this.button_sort.Text = "Сортировать";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // ParkingPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.buttonOutQueue);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxParking);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxPark);
            this.Controls.Add(this.buttonParking);
            this.Controls.Add(this.pictureBoxPark);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParkingPlace";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPark)).EndInit();
            this.groupBoxPark.ResumeLayout(false);
            this.groupBoxPark.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPark;
        private System.Windows.Forms.Button buttonParking;
        private System.Windows.Forms.GroupBox groupBoxPark;
        private System.Windows.Forms.Button buttonInQueue;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListBox listBoxParking;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.Button buttonOutQueue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПарковкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьПарковкуToolStripMenuItem;
        private System.Windows.Forms.Button button_sort;
    }
}