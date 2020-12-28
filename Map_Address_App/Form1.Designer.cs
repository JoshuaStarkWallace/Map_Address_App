
namespace Map_Address_App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ZipCodeLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.WebBrowserWindow = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.SearchButton);
            this.splitContainer1.Panel1.Controls.Add(this.ZipCodeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.StateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.CityLabel);
            this.splitContainer1.Panel1.Controls.Add(this.ZipCodeTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.StateTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.CityTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.StreetLabel);
            this.splitContainer1.Panel1.Controls.Add(this.StreetTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.WebBrowserWindow);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(101, 282);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ZipCodeLabel
            // 
            this.ZipCodeLabel.AutoSize = true;
            this.ZipCodeLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ZipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipCodeLabel.ForeColor = System.Drawing.Color.White;
            this.ZipCodeLabel.Location = new System.Drawing.Point(33, 246);
            this.ZipCodeLabel.Name = "ZipCodeLabel";
            this.ZipCodeLabel.Size = new System.Drawing.Size(62, 13);
            this.ZipCodeLabel.TabIndex = 7;
            this.ZipCodeLabel.Text = "Zip Code:";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.StateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.ForeColor = System.Drawing.Color.White;
            this.StateLabel.Location = new System.Drawing.Point(54, 203);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(41, 13);
            this.StateLabel.TabIndex = 6;
            this.StateLabel.Text = "State:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.ForeColor = System.Drawing.Color.White;
            this.CityLabel.Location = new System.Drawing.Point(63, 160);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(32, 13);
            this.CityLabel.TabIndex = 5;
            this.CityLabel.Text = "City:";
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Location = new System.Drawing.Point(101, 243);
            this.ZipCodeTextBox.Multiline = true;
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(116, 20);
            this.ZipCodeTextBox.TabIndex = 4;
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(101, 200);
            this.StateTextBox.Multiline = true;
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(116, 20);
            this.StateTextBox.TabIndex = 3;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(101, 157);
            this.CityTextBox.Multiline = true;
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(116, 20);
            this.CityTextBox.TabIndex = 2;
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.StreetLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetLabel.ForeColor = System.Drawing.Color.White;
            this.StreetLabel.Location = new System.Drawing.Point(54, 116);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(45, 13);
            this.StreetLabel.TabIndex = 1;
            this.StreetLabel.Text = "Street:";
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(101, 113);
            this.StreetTextBox.Multiline = true;
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(116, 20);
            this.StreetTextBox.TabIndex = 0;
            // 
            // WebBrowserWindow
            // 
            this.WebBrowserWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowserWindow.Location = new System.Drawing.Point(0, 0);
            this.WebBrowserWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserWindow.Name = "WebBrowserWindow";
            this.WebBrowserWindow.Size = new System.Drawing.Size(530, 450);
            this.WebBrowserWindow.TabIndex = 0;
            this.WebBrowserWindow.Url = new System.Uri("http://maps.google.com", System.UriKind.Absolute);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Map Address App";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label ZipCodeLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox ZipCodeTextBox;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.WebBrowser WebBrowserWindow;
    }
}

