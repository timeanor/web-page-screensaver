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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(284, 262);
            this.webBrowser.TabIndex = 0;
            //this.webBrowser.Visible = false;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);

            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Maroon;
            this.closeButton.Location = new System.Drawing.Point(217, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(55, 51);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // leftArrow
            // 
            this.leftArrow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.leftArrow.AutoSize = true;
            this.leftArrow.BackColor = System.Drawing.Color.Transparent;
            this.leftArrow.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftArrow.ForeColor = System.Drawing.Color.Black;
            this.leftArrow.Location = new System.Drawing.Point(8, 197);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(129, 53);
            this.leftArrow.TabIndex = 2;
            this.leftArrow.Text = "< Back";
            this.leftArrow.UseVisualStyleBackColor = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // rightArrow
            // 
            this.rightArrow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rightArrow.AutoSize = true;
            this.rightArrow.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightArrow.ForeColor = System.Drawing.Color.Black;
            this.rightArrow.Location = new System.Drawing.Point(143, 197);
            this.rightArrow.Margin = new System.Windows.Forms.Padding(3, 3, 300, 3);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(140, 53);
            this.rightArrow.TabIndex = 3;
            this.rightArrow.Text = "Forward >";
            this.rightArrow.UseVisualStyleBackColor = true;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.AutoSize = true;
            this.button_minimize.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.DimGray;
            this.button_minimize.Location = new System.Drawing.Point(156, 12);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(55, 51);
            this.button_minimize.TabIndex = 4;
            this.button_minimize.Text = "_";
            this.button_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // ScreensaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

