namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tempLabel = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.tempCircle = new System.Windows.Forms.PictureBox();
            this.forecastCircle = new System.Windows.Forms.PictureBox();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // tempLabel
            // 
            this.tempLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("HelvLight", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tempLabel.Location = new System.Drawing.Point(90, 36);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(201, 77);
            this.tempLabel.TabIndex = 1;
            this.tempLabel.Text = "XX °C";
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.Transparent;
            this.iconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBox.Location = new System.Drawing.Point(120, 211);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(200, 113);
            this.iconBox.TabIndex = 2;
            this.iconBox.TabStop = false;
            // 
            // tempCircle
            // 
            this.tempCircle.BackColor = System.Drawing.Color.Transparent;
            this.tempCircle.BackgroundImage = global::XMLWeather.Properties.Resources.light_blue_circle;
            this.tempCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tempCircle.Location = new System.Drawing.Point(60, -42);
            this.tempCircle.Name = "tempCircle";
            this.tempCircle.Size = new System.Drawing.Size(200, 200);
            this.tempCircle.TabIndex = 0;
            this.tempCircle.TabStop = false;
            // 
            // forecastCircle
            // 
            this.forecastCircle.BackColor = System.Drawing.Color.Transparent;
            this.forecastCircle.BackgroundImage = global::XMLWeather.Properties.Resources.light_blue_circle;
            this.forecastCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forecastCircle.Location = new System.Drawing.Point(85, 330);
            this.forecastCircle.Name = "forecastCircle";
            this.forecastCircle.Size = new System.Drawing.Size(150, 150);
            this.forecastCircle.TabIndex = 3;
            this.forecastCircle.TabStop = false;
            this.forecastCircle.Click += new System.EventHandler(this.forecastCircle_Click);
            // 
            // forecastLabel
            // 
            this.forecastLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forecastLabel.AutoSize = true;
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.forecastLabel.Location = new System.Drawing.Point(96, 394);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(127, 23);
            this.forecastLabel.TabIndex = 4;
            this.forecastLabel.Text = "5-Day Forecast";
            this.forecastLabel.UseMnemonic = false;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click_1);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.titleLabel.Location = new System.Drawing.Point(78, 161);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(167, 42);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Today in...";
            // 
            // humidityLabel
            // 
            this.humidityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.humidityLabel.Location = new System.Drawing.Point(3, 211);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(68, 18);
            this.humidityLabel.TabIndex = 6;
            this.humidityLabel.Text = "Humidity:";
            // 
            // windLabel
            // 
            this.windLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windLabel.AutoSize = true;
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.windLabel.Location = new System.Drawing.Point(3, 250);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(40, 18);
            this.windLabel.TabIndex = 7;
            this.windLabel.Text = "Wind";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateLabel.Location = new System.Drawing.Point(3, 289);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(40, 18);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Wind";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.forecastCircle);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.tempCircle);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(320, 480);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastCircle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tempCircle;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.PictureBox forecastCircle;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}
