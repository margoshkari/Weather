
namespace Weather
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
            this.tempLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.tempFeelingsLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.wetLabel = new System.Windows.Forms.Label();
            this.activitylabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.waterTempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.tempLabel.Location = new System.Drawing.Point(14, 94);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(42, 46);
            this.tempLabel.TabIndex = 0;
            this.tempLabel.Text = "0";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cityLabel.Location = new System.Drawing.Point(17, 9);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(56, 31);
            this.cityLabel.TabIndex = 1;
            this.cityLabel.Text = "city";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateLabel.Location = new System.Drawing.Point(19, 60);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(50, 25);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "date";
            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = true;
            this.weatherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.weatherLabel.Location = new System.Drawing.Point(147, 106);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(81, 25);
            this.weatherLabel.TabIndex = 3;
            this.weatherLabel.Text = "weather";
            // 
            // tempFeelingsLabel
            // 
            this.tempFeelingsLabel.AutoSize = true;
            this.tempFeelingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tempFeelingsLabel.Location = new System.Drawing.Point(12, 166);
            this.tempFeelingsLabel.Name = "tempFeelingsLabel";
            this.tempFeelingsLabel.Size = new System.Drawing.Size(55, 25);
            this.tempFeelingsLabel.TabIndex = 3;
            this.tempFeelingsLabel.Text = "temp";
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.windLabel.Location = new System.Drawing.Point(12, 204);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(52, 25);
            this.windLabel.TabIndex = 3;
            this.windLabel.Text = "wind";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pressureLabel.Location = new System.Drawing.Point(12, 242);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(88, 25);
            this.pressureLabel.TabIndex = 3;
            this.pressureLabel.Text = "pressure";
            // 
            // wetLabel
            // 
            this.wetLabel.AutoSize = true;
            this.wetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.wetLabel.Location = new System.Drawing.Point(12, 281);
            this.wetLabel.Name = "wetLabel";
            this.wetLabel.Size = new System.Drawing.Size(42, 25);
            this.wetLabel.TabIndex = 3;
            this.wetLabel.Text = "wet";
            // 
            // activitylabel
            // 
            this.activitylabel.AutoSize = true;
            this.activitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.activitylabel.Location = new System.Drawing.Point(12, 319);
            this.activitylabel.Name = "activitylabel";
            this.activitylabel.Size = new System.Drawing.Size(71, 25);
            this.activitylabel.TabIndex = 3;
            this.activitylabel.Text = "activity";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // waterTempLabel
            // 
            this.waterTempLabel.AutoSize = true;
            this.waterTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.waterTempLabel.Location = new System.Drawing.Point(12, 358);
            this.waterTempLabel.Name = "waterTempLabel";
            this.waterTempLabel.Size = new System.Drawing.Size(107, 25);
            this.waterTempLabel.TabIndex = 3;
            this.waterTempLabel.Text = "water temp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 403);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.waterTempLabel);
            this.Controls.Add(this.activitylabel);
            this.Controls.Add(this.wetLabel);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.tempFeelingsLabel);
            this.Controls.Add(this.weatherLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.tempLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.Label tempFeelingsLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label wetLabel;
        private System.Windows.Forms.Label activitylabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label waterTempLabel;
    }
}

