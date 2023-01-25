namespace MemoryCardGame
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFlips = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.AutoScroll = true;
            this.pnMain.Location = new System.Drawing.Point(12, 12);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(729, 488);
            this.pnMain.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(617, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "New Game";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFlips);
            this.panel2.Controls.Add(this.btnTime);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Location = new System.Drawing.Point(12, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnFlips
            // 
            this.btnFlips.Location = new System.Drawing.Point(525, 5);
            this.btnFlips.Margin = new System.Windows.Forms.Padding(5);
            this.btnFlips.Name = "btnFlips";
            this.btnFlips.Size = new System.Drawing.Size(82, 30);
            this.btnFlips.TabIndex = 4;
            this.btnFlips.Text = "Flips: 0";
            this.btnFlips.UseVisualStyleBackColor = true;
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(427, 5);
            this.btnTime.Margin = new System.Windows.Forms.Padding(5);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(88, 30);
            this.btnTime.TabIndex = 3;
            this.btnTime.Text = "Time: 0s";
            this.btnTime.UseVisualStyleBackColor = true;
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Card Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnMain;
        private Button btnRefresh;
        private Panel panel2;
        private Button btnFlips;
        private Button btnTime;
        public System.Windows.Forms.Timer time;
    }
}