namespace pl.polidea.lab.Web_Page_Screensaver
{
    partial class ScreensaverForm
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.closeButton = new System.Windows.Forms.Button();
            this.leftArrow = new System.Windows.Forms.Button();
            this.rightArrow = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.RandomToggle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(627, 416);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.DimGray;
            this.closeButton.Location = new System.Drawing.Point(560, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(55, 51);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // leftArrow
            // 
            this.leftArrow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.leftArrow.AutoSize = true;
            this.leftArrow.BackColor = System.Drawing.Color.Black;
            this.leftArrow.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.leftArrow.FlatAppearance.BorderSize = 3;
            this.leftArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.leftArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftArrow.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftArrow.ForeColor = System.Drawing.Color.White;
            this.leftArrow.Location = new System.Drawing.Point(167, 369);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(140, 47);
            this.leftArrow.TabIndex = 2;
            this.leftArrow.Text = "<< Back";
            this.leftArrow.UseVisualStyleBackColor = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            this.leftArrow.Visible = false;
            // 
            // rightArrow
            // 
            this.rightArrow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rightArrow.AutoSize = true;
            this.rightArrow.BackColor = System.Drawing.Color.Black;
            this.rightArrow.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.rightArrow.FlatAppearance.BorderSize = 3;
            this.rightArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.rightArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightArrow.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightArrow.ForeColor = System.Drawing.Color.White;
            this.rightArrow.Location = new System.Drawing.Point(313, 369);
            this.rightArrow.Margin = new System.Windows.Forms.Padding(3, 3, 300, 3);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(140, 47);
            this.rightArrow.TabIndex = 3;
            this.rightArrow.Text = "Fwd >>";
            this.rightArrow.UseVisualStyleBackColor = false;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            this.rightArrow.Visible = false;
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.AutoSize = true;
            this.button_minimize.BackColor = System.Drawing.Color.Transparent;
            this.button_minimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.DimGray;
            this.button_minimize.Location = new System.Drawing.Point(499, 12);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(55, 51);
            this.button_minimize.TabIndex = 4;
            this.button_minimize.Text = "_";
            this.button_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // RandomToggle
            // 
            this.RandomToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RandomToggle.AutoSize = true;
            this.RandomToggle.BackColor = System.Drawing.Color.Black;
            this.RandomToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RandomToggle.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.RandomToggle.FlatAppearance.BorderSize = 3;
            this.RandomToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RandomToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomToggle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomToggle.ForeColor = System.Drawing.Color.White;
            this.RandomToggle.Location = new System.Drawing.Point(0, 347);
            this.RandomToggle.Margin = new System.Windows.Forms.Padding(3, 3, 300, 3);
            this.RandomToggle.Name = "RandomToggle";
            this.RandomToggle.Size = new System.Drawing.Size(188, 69);
            this.RandomToggle.TabIndex = 7;
            this.RandomToggle.Text = "Random Slide";
            this.RandomToggle.UseVisualStyleBackColor = false;
            this.RandomToggle.Click += new System.EventHandler(this.RandomToggle_Click);
            this.RandomToggle.Visible = false;
            // 
            // ScreensaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(627, 416);
            this.Controls.Add(this.RandomToggle);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.leftArrow);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.webBrowser);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScreensaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ScreensaverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button leftArrow;
        private System.Windows.Forms.Button rightArrow;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button RandomToggle;
    }
}

