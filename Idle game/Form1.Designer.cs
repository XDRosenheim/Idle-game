namespace Idle_game {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnManuelClick = new System.Windows.Forms.Button();
            this.lblCoins = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.upgrade1 = new System.Windows.Forms.Timer(this.components);
            this.btnUpgOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManuelClick
            // 
            this.btnManuelClick.Location = new System.Drawing.Point(12, 65);
            this.btnManuelClick.Name = "btnManuelClick";
            this.btnManuelClick.Size = new System.Drawing.Size(75, 23);
            this.btnManuelClick.TabIndex = 0;
            this.btnManuelClick.Text = "Click";
            this.btnManuelClick.UseVisualStyleBackColor = true;
            this.btnManuelClick.Click += new System.EventHandler(this.btnManuelClick_Click);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Location = new System.Drawing.Point(29, 29);
            this.lblCoins.Margin = new System.Windows.Forms.Padding(20);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(35, 13);
            this.lblCoins.TabIndex = 1;
            this.lblCoins.Text = "label1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // upgrade1
            // 
            this.upgrade1.Tick += new System.EventHandler(this.upgrade1_Tick);
            // 
            // btnUpgOne
            // 
            this.btnUpgOne.Enabled = false;
            this.btnUpgOne.Location = new System.Drawing.Point(12, 94);
            this.btnUpgOne.Name = "btnUpgOne";
            this.btnUpgOne.Size = new System.Drawing.Size(75, 23);
            this.btnUpgOne.TabIndex = 2;
            this.btnUpgOne.Text = "Upgrade 1";
            this.btnUpgOne.UseVisualStyleBackColor = true;
            this.btnUpgOne.Click += new System.EventHandler(this.btnUpgOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpgOne);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.btnManuelClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManuelClick;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer upgrade1;
        private System.Windows.Forms.Button btnUpgOne;
        private System.Windows.Forms.Label label1;
    }
}

