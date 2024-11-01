﻿namespace LiftDemo_A
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.liftTimerUp = new System.Windows.Forms.Timer(this.components);
			this.doorTimer = new System.Windows.Forms.Timer(this.components);
			this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
			this.liftTimerDown = new System.Windows.Forms.Timer(this.components);
			this.doorRight_1 = new System.Windows.Forms.PictureBox();
			this.doorLeft_1 = new System.Windows.Forms.PictureBox();
			this.doorRight_G = new System.Windows.Forms.PictureBox();
			this.doorLeft_G = new System.Windows.Forms.PictureBox();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Open = new System.Windows.Forms.Button();
			this.btn_G = new System.Windows.Forms.Button();
			this.buttton1 = new System.Windows.Forms.Button();
			this.liftPanel = new System.Windows.Forms.PictureBox();
			this.mainElevator = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liftPanel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainElevator)).BeginInit();
			this.SuspendLayout();
			// 
			// liftTimerUp
			// 
			this.liftTimerUp.Interval = 50;
			this.liftTimerUp.Tick += new System.EventHandler(this.liftTimerUp_Tick);
			// 
			// doorTimer
			// 
			this.doorTimer.Tick += new System.EventHandler(this.door_Timer_Tick);
			// 
			// dataGridViewLogs
			// 
			this.dataGridViewLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLogs.Location = new System.Drawing.Point(816, 0);
			this.dataGridViewLogs.Name = "dataGridViewLogs";
			this.dataGridViewLogs.RowHeadersWidth = 51;
			this.dataGridViewLogs.RowTemplate.Height = 24;
			this.dataGridViewLogs.Size = new System.Drawing.Size(301, 564);
			this.dataGridViewLogs.TabIndex = 10;
			// 
			// liftTimerDown
			// 
			this.liftTimerDown.Tick += new System.EventHandler(this.liftTimerDown_Tick);
			// 
			// doorRight_1
			// 
			this.doorRight_1.BackgroundImage = global::LiftDemo_A.Properties.Resources.download;
			this.doorRight_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.doorRight_1.Image = global::LiftDemo_A.Properties.Resources.paabel1;
			this.doorRight_1.Location = new System.Drawing.Point(174, 0);
			this.doorRight_1.Name = "doorRight_1";
			this.doorRight_1.Size = new System.Drawing.Size(81, 208);
			this.doorRight_1.TabIndex = 9;
			this.doorRight_1.TabStop = false;
			// 
			// doorLeft_1
			// 
			this.doorLeft_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.doorLeft_1.Image = global::LiftDemo_A.Properties.Resources.paabel;
			this.doorLeft_1.Location = new System.Drawing.Point(93, 0);
			this.doorLeft_1.Name = "doorLeft_1";
			this.doorLeft_1.Size = new System.Drawing.Size(83, 208);
			this.doorLeft_1.TabIndex = 8;
			this.doorLeft_1.TabStop = false;
			this.doorLeft_1.Click += new System.EventHandler(this.doorLeft_1_Click);
			// 
			// doorRight_G
			// 
			this.doorRight_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.doorRight_G.Image = global::LiftDemo_A.Properties.Resources.paabel3;
			this.doorRight_G.Location = new System.Drawing.Point(174, 356);
			this.doorRight_G.Name = "doorRight_G";
			this.doorRight_G.Size = new System.Drawing.Size(81, 208);
			this.doorRight_G.TabIndex = 7;
			this.doorRight_G.TabStop = false;
			// 
			// doorLeft_G
			// 
			this.doorLeft_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.doorLeft_G.Image = global::LiftDemo_A.Properties.Resources.paabel2;
			this.doorLeft_G.Location = new System.Drawing.Point(93, 356);
			this.doorLeft_G.Name = "doorLeft_G";
			this.doorLeft_G.Size = new System.Drawing.Size(83, 208);
			this.doorLeft_G.TabIndex = 6;
			this.doorLeft_G.TabStop = false;
			// 
			// btn_Close
			// 
			this.btn_Close.BackgroundImage = global::LiftDemo_A.Properties.Resources.images;
			this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_Close.Location = new System.Drawing.Point(513, 356);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(80, 77);
			this.btn_Close.TabIndex = 5;
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_Open
			// 
			this.btn_Open.BackgroundImage = global::LiftDemo_A.Properties.Resources._162616_200;
			this.btn_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_Open.Location = new System.Drawing.Point(409, 356);
			this.btn_Open.Name = "btn_Open";
			this.btn_Open.Size = new System.Drawing.Size(80, 77);
			this.btn_Open.TabIndex = 4;
			this.btn_Open.UseVisualStyleBackColor = true;
			this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
			// 
			// btn_G
			// 
			this.btn_G.BackgroundImage = global::LiftDemo_A.Properties.Resources.dbutton;
			this.btn_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_G.Location = new System.Drawing.Point(460, 208);
			this.btn_G.Name = "btn_G";
			this.btn_G.Size = new System.Drawing.Size(80, 79);
			this.btn_G.TabIndex = 3;
			this.btn_G.UseVisualStyleBackColor = true;
			this.btn_G.Click += new System.EventHandler(this.btn_G_click);
			// 
			// buttton1
			// 
			this.buttton1.BackgroundImage = global::LiftDemo_A.Properties.Resources.button1;
			this.buttton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttton1.Location = new System.Drawing.Point(460, 92);
			this.buttton1.Name = "buttton1";
			this.buttton1.Size = new System.Drawing.Size(80, 81);
			this.buttton1.TabIndex = 2;
			this.buttton1.UseVisualStyleBackColor = true;
			this.buttton1.Click += new System.EventHandler(this.btn_1_click);
			// 
			// liftPanel
			// 
			this.liftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("liftPanel.BackgroundImage")));
			this.liftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.liftPanel.Location = new System.Drawing.Point(389, 28);
			this.liftPanel.Name = "liftPanel";
			this.liftPanel.Size = new System.Drawing.Size(218, 509);
			this.liftPanel.TabIndex = 1;
			this.liftPanel.TabStop = false;
			// 
			// mainElevator
			// 
			this.mainElevator.BackgroundImage = global::LiftDemo_A.Properties.Resources.images__1_;
			this.mainElevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.mainElevator.Location = new System.Drawing.Point(93, 356);
			this.mainElevator.Name = "mainElevator";
			this.mainElevator.Size = new System.Drawing.Size(162, 208);
			this.mainElevator.TabIndex = 0;
			this.mainElevator.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(460, 96);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 77);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btn_1_click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BackgroundImage = global::LiftDemo_A.Properties.Resources.bgimage;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1124, 565);
			this.Controls.Add(this.dataGridViewLogs);
			this.Controls.Add(this.doorRight_1);
			this.Controls.Add(this.doorLeft_1);
			this.Controls.Add(this.doorRight_G);
			this.Controls.Add(this.doorLeft_G);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.btn_Open);
			this.Controls.Add(this.btn_G);
			this.Controls.Add(this.buttton1);
			this.Controls.Add(this.liftPanel);
			this.Controls.Add(this.mainElevator);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liftPanel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainElevator)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox mainElevator;
		private System.Windows.Forms.PictureBox liftPanel;
		private System.Windows.Forms.Button buttton1;
		private System.Windows.Forms.Button btn_G;
		private System.Windows.Forms.Button btn_Open;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Timer liftTimerUp;
		private System.Windows.Forms.PictureBox doorLeft_G;
		private System.Windows.Forms.PictureBox doorRight_G;
		private System.Windows.Forms.PictureBox doorRight_1;
		private System.Windows.Forms.PictureBox doorLeft_1;
		private System.Windows.Forms.Timer doorTimer;
		private System.Windows.Forms.DataGridView dataGridViewLogs;
		private System.Windows.Forms.Timer liftTimerDown;
        private System.Windows.Forms.Button button1;
    }
}

