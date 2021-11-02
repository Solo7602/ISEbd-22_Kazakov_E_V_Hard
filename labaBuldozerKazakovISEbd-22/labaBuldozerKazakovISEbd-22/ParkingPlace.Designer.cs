
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
            this.buttonOutPark = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.buttonParking.Location = new System.Drawing.Point(694, 12);
            this.buttonParking.Name = "buttonParking";
            this.buttonParking.Size = new System.Drawing.Size(97, 41);
            this.buttonParking.TabIndex = 1;
            this.buttonParking.Text = "Припарковать бульдозер";
            this.buttonParking.UseVisualStyleBackColor = true;
            this.buttonParking.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonParking_MouseClick);
            // 
            // buttonModParking
            // 
            this.buttonModParking.Location = new System.Drawing.Point(694, 72);
            this.buttonModParking.Name = "buttonModParking";
            this.buttonModParking.Size = new System.Drawing.Size(96, 53);
            this.buttonModParking.TabIndex = 2;
            this.buttonModParking.Text = "Припарковать улучшенный бульдозер";
            this.buttonModParking.UseVisualStyleBackColor = true;
            this.buttonModParking.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonModParking_MouseClick);
            // 
            // groupBoxPark
            // 
            this.groupBoxPark.Controls.Add(this.buttonOutPark);
            this.groupBoxPark.Controls.Add(this.maskedTextBoxNumber);
            this.groupBoxPark.Controls.Add(this.label2);
            this.groupBoxPark.Controls.Add(this.label1);
            this.groupBoxPark.Location = new System.Drawing.Point(689, 131);
            this.groupBoxPark.Name = "groupBoxPark";
            this.groupBoxPark.Size = new System.Drawing.Size(112, 99);
            this.groupBoxPark.TabIndex = 3;
            this.groupBoxPark.TabStop = false;
            // 
            // buttonOutPark
            // 
            this.buttonOutPark.Location = new System.Drawing.Point(13, 61);
            this.buttonOutPark.Name = "buttonOutPark";
            this.buttonOutPark.Size = new System.Drawing.Size(74, 26);
            this.buttonOutPark.TabIndex = 3;
            this.buttonOutPark.Text = "Забрать";
            this.buttonOutPark.UseVisualStyleBackColor = true;
            this.buttonOutPark.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOutPark_MouseClick);
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
            // ParkingPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPark;
        private System.Windows.Forms.Button buttonParking;
        private System.Windows.Forms.Button buttonModParking;
        private System.Windows.Forms.GroupBox groupBoxPark;
        private System.Windows.Forms.Button buttonOutPark;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}