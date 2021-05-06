
namespace TrexQuizRunner
{
    partial class welcomeScreen
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
            this.startButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trex = new System.Windows.Forms.PictureBox();
            this.soundEnabled = new System.Windows.Forms.PictureBox();
            this.soundMuted = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundMuted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("LCD Solid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(318, 329);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(178, 64);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startGame);
            // 
            // helpButton
            // 
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.Font = new System.Drawing.Font("LCD Solid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpButton.Location = new System.Drawing.Point(318, 399);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(178, 32);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.showHelp);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("LCD Solid", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(141, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(543, 81);
            this.title.TabIndex = 2;
            this.title.Text = "Trex Quiz Runner";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "beta v1.0.0";
            // 
            // trex
            // 
            this.trex.Image = global::TrexQuizRunner.Properties.Resources.running;
            this.trex.Location = new System.Drawing.Point(120, 47);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(40, 43);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trex.TabIndex = 4;
            this.trex.TabStop = false;
            // 
            // soundEnabled
            // 
            this.soundEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundEnabled.Image = global::TrexQuizRunner.Properties.Resources.volume;
            this.soundEnabled.Location = new System.Drawing.Point(763, 415);
            this.soundEnabled.Name = "soundEnabled";
            this.soundEnabled.Size = new System.Drawing.Size(16, 16);
            this.soundEnabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundEnabled.TabIndex = 5;
            this.soundEnabled.TabStop = false;
            this.soundEnabled.Click += new System.EventHandler(this.enableSound);
            // 
            // soundMuted
            // 
            this.soundMuted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundMuted.Image = global::TrexQuizRunner.Properties.Resources.mute;
            this.soundMuted.Location = new System.Drawing.Point(763, 415);
            this.soundMuted.Name = "soundMuted";
            this.soundMuted.Size = new System.Drawing.Size(16, 16);
            this.soundMuted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundMuted.TabIndex = 5;
            this.soundMuted.TabStop = false;
            this.soundMuted.Click += new System.EventHandler(this.disableSound);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrexQuizRunner.Properties.Resources.jurassicGIF1;
            this.pictureBox1.Location = new System.Drawing.Point(42, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 145);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrexQuizRunner.Properties.Resources.jurassicGIF2;
            this.pictureBox2.Location = new System.Drawing.Point(523, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // welcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.soundMuted);
            this.Controls.Add(this.soundEnabled);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.startButton);
            this.Name = "welcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrexQuizRunner WelcomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundMuted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox soundEnabled;
        private System.Windows.Forms.PictureBox soundMuted;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}