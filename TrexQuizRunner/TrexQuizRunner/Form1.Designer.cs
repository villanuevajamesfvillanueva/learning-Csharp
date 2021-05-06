
namespace TrexQuizRunner
{
    partial class gameScreen
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
            this.txtScore = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelQuestion = new System.Windows.Forms.Label();
            this.choice1 = new System.Windows.Forms.Label();
            this.choice2 = new System.Windows.Forms.Label();
            this.choice3 = new System.Windows.Forms.Label();
            this.choice4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("LCD Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(29, 31);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(112, 17);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score: 0";
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Black;
            this.ground.Location = new System.Drawing.Point(-14, 378);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(823, 81);
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // trex
            // 
            this.trex.Image = global::TrexQuizRunner.Properties.Resources.running;
            this.trex.Location = new System.Drawing.Point(100, 336);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(40, 43);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trex.TabIndex = 2;
            this.trex.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrexQuizRunner.Properties.Resources.obstacle_1;
            this.pictureBox2.Location = new System.Drawing.Point(521, 333);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "obstacle";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TrexQuizRunner.Properties.Resources.obstacle_2;
            this.pictureBox3.Location = new System.Drawing.Point(690, 345);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // labelQuestion
            // 
            this.labelQuestion.Font = new System.Drawing.Font("LCD Solid", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuestion.Location = new System.Drawing.Point(317, 7);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(461, 106);
            this.labelQuestion.TabIndex = 3;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choice1
            // 
            this.choice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choice1.Location = new System.Drawing.Point(317, 137);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(200, 50);
            this.choice1.TabIndex = 4;
            this.choice1.Tag = "1";
            this.choice1.Text = "choice1";
            this.choice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.choice1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // choice2
            // 
            this.choice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choice2.Location = new System.Drawing.Point(578, 137);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(200, 50);
            this.choice2.TabIndex = 4;
            this.choice2.Tag = "2";
            this.choice2.Text = "choice2";
            this.choice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.choice2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // choice3
            // 
            this.choice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choice3.Location = new System.Drawing.Point(317, 212);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(200, 50);
            this.choice3.TabIndex = 4;
            this.choice3.Tag = "3";
            this.choice3.Text = "choice3";
            this.choice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.choice3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // choice4
            // 
            this.choice4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choice4.Location = new System.Drawing.Point(578, 212);
            this.choice4.Name = "choice4";
            this.choice4.Size = new System.Drawing.Size(200, 50);
            this.choice4.TabIndex = 4;
            this.choice4.Tag = "4";
            this.choice4.Text = "choice4";
            this.choice4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.choice4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.choice4);
            this.Controls.Add(this.choice3);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trex);
            this.Name = "gameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrexQuizRunner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label choice1;
        private System.Windows.Forms.Label choice2;
        private System.Windows.Forms.Label choice3;
        private System.Windows.Forms.Label choice4;
        private System.Windows.Forms.Label labelQuestion;
    }
}

