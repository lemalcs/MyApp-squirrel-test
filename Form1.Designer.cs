namespace MyApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.btn_HiButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RootFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.check_IsInstalled = new System.Windows.Forms.CheckBox();
            this.txt_AppName = new System.Windows.Forms.TextBox();
            this.btn_OpenFileDialog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to MyApp, an example application for Squirrel.Windows.";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(9, 42);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(191, 17);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Executing Assembly Location";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(9, 88);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(129, 17);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Application Version";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationTextBox.Location = new System.Drawing.Point(12, 62);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(458, 23);
            this.locationTextBox.TabIndex = 3;
            this.locationTextBox.TabStop = false;
            // 
            // versionTextBox
            // 
            this.versionTextBox.Location = new System.Drawing.Point(12, 108);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.ReadOnly = true;
            this.versionTextBox.Size = new System.Drawing.Size(139, 23);
            this.versionTextBox.TabIndex = 4;
            this.versionTextBox.TabStop = false;
            // 
            // btn_HiButton
            // 
            this.btn_HiButton.Location = new System.Drawing.Point(352, 108);
            this.btn_HiButton.Name = "btn_HiButton";
            this.btn_HiButton.Size = new System.Drawing.Size(75, 23);
            this.btn_HiButton.TabIndex = 5;
            this.btn_HiButton.Text = "Hi";
            this.btn_HiButton.UseVisualStyleBackColor = true;
            this.btn_HiButton.Click += new System.EventHandler(this.btn_HiButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Root App folder";
            // 
            // txt_RootFolder
            // 
            this.txt_RootFolder.Location = new System.Drawing.Point(15, 164);
            this.txt_RootFolder.Name = "txt_RootFolder";
            this.txt_RootFolder.Size = new System.Drawing.Size(433, 23);
            this.txt_RootFolder.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "App name";
            // 
            // check_IsInstalled
            // 
            this.check_IsInstalled.AutoSize = true;
            this.check_IsInstalled.Location = new System.Drawing.Point(15, 193);
            this.check_IsInstalled.Name = "check_IsInstalled";
            this.check_IsInstalled.Size = new System.Drawing.Size(93, 21);
            this.check_IsInstalled.TabIndex = 9;
            this.check_IsInstalled.Text = "Is installed";
            this.check_IsInstalled.UseVisualStyleBackColor = true;
            // 
            // txt_AppName
            // 
            this.txt_AppName.Location = new System.Drawing.Point(15, 247);
            this.txt_AppName.Name = "txt_AppName";
            this.txt_AppName.Size = new System.Drawing.Size(218, 23);
            this.txt_AppName.TabIndex = 10;
            // 
            // btn_OpenFileDialog
            // 
            this.btn_OpenFileDialog.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_OpenFileDialog.Location = new System.Drawing.Point(352, 247);
            this.btn_OpenFileDialog.Name = "btn_OpenFileDialog";
            this.btn_OpenFileDialog.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenFileDialog.TabIndex = 11;
            this.btn_OpenFileDialog.Text = "Open";
            this.btn_OpenFileDialog.UseVisualStyleBackColor = false;
            this.btn_OpenFileDialog.Click += new System.EventHandler(this.btn_OpenFileDialog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyApp.Properties.Resources.Image_aspx7;
            this.pictureBox1.Location = new System.Drawing.Point(15, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 251);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 552);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_OpenFileDialog);
            this.Controls.Add(this.txt_AppName);
            this.Controls.Add(this.check_IsInstalled);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_RootFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_HiButton);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MyApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label locationLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.TextBox locationTextBox;
		private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.Button btn_HiButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_RootFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check_IsInstalled;
        private System.Windows.Forms.TextBox txt_AppName;
        private System.Windows.Forms.Button btn_OpenFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

