namespace Quizgame
{
    partial class FormGame
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.timerQuestion = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(20, 20);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(184, 16);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Câu hỏi sẽ được hiển thị ở đây";
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(20, 80);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(94, 20);
            this.radioButtonA.TabIndex = 1;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "Lựa chọn A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(20, 110);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(94, 20);
            this.radioButtonB.TabIndex = 2;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "Lựa chọn B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(20, 140);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(94, 20);
            this.radioButtonC.TabIndex = 3;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "Lựa chọn C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(20, 170);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(95, 20);
            this.radioButtonD.TabIndex = 4;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "Lựa chọn D";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(20, 210);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 30);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Xác nhận";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.ForeColor = System.Drawing.Color.Red;
            this.labelResult.Location = new System.Drawing.Point(20, 250);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(151, 16);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Kết quả sẽ hiển thị ở đây";
            // 
            // timerQuestion
            // 
            this.timerQuestion.Interval = 1000;
            this.timerQuestion.Tick += new System.EventHandler(this.timerQuestion_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(181, 217);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(72, 16);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.Text = "labelTimer";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.labelQuestion);
            this.Name = "FormGame";
            this.Text = "Trò Chơi Trắc Nghiệm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timerQuestion;
    }
}

