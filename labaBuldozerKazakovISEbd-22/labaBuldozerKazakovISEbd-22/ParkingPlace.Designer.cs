
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
            this.buttonModParking = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPark)).BeginInit();
            this.groupBoxPark.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPark
            // 
            this.pictureBoxPark.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPark.Name = "pictureBoxPark";
            this.pictureBoxPark.Size = new System.Drawing.Size(683, 449);
            this.pictureBoxPark.TabIndex = 0;
            this.pictureBoxPark.TabStop = false;
            // 
            // buttonParking
            // 
            this.buttonParking.Location = new System.Drawing.Point(698, 254);
            this.buttonParking.Name = "buttonParking";
            this.buttonParking.Size = new System.Drawing.Size(97, 41);
            this.buttonParking.TabIndex = 1;
            this.buttonParking.Text = "Припарковать бульдозер";
            this.buttonParking.UseVisualStyleBackColor = true;
            this.buttonParking.Click += new System.EventHandler(this.buttonParking_Click);
            // 
            // buttonModParking
            // 
            this.buttonModParking.Location = new System.Drawing.Point(698, 301);
            this.buttonModParking.Name = "buttonModParking";
            this.buttonModParking.Size = new System.Drawing.Size(96, 53);
            this.buttonModParking.TabIndex = 2;
            this.buttonModParking.Text = "Припарковать улучшенный бульдозер";
            this.buttonModParking.UseVisualStyleBackColor = true;
            this.buttonModParking.Click += new System.EventHandler(this.buttonModParking_Click);
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
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Забрать бульдозер";
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
            this.buttonOutQueue.Location = new System.Drawing.Point(698, 205);
            this.buttonOutQueue.Name = "buttonOutQueue";
            this.buttonOutQueue.Size = new System.Drawing.Size(96, 34);
            this.buttonOutQueue.TabIndex = 9;
            this.buttonOutQueue.Text = "Забрать из очереди";
            this.buttonOutQueue.UseVisualStyleBackColor = true;
            this.buttonOutQueue.Click += new System.EventHandler(this.buttonOutQueue_Click);
            // 
            // ParkingPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOutQueue);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxParking);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxPark);
            this.Controls.Add(this.buttonModParking);
            this.Controls.Add(this.buttonParking);
            this.Controls.Add(this.pictureBoxPark);
            this.Name = "ParkingPlace";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPark)).EndInit();
            this.groupBoxPark.ResumeLayout(false);
            this.groupBoxPark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPark;
        private System.Windows.Forms.Button buttonParking;
        private System.Windows.Forms.Button buttonModParking;
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
    }
}