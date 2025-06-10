namespace MathQuiz
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
            this.lbltime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblplusLeft = new System.Windows.Forms.Label();
            this.lblplusRight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblplussign = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.lblminussign = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblminusRight = new System.Windows.Forms.Label();
            this.lblminusLeft = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.lblmulsign = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltimesRight = new System.Windows.Forms.Label();
            this.lbltimesLeft = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.lbldivsign = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbldividedRight = new System.Windows.Forms.Label();
            this.lbldividedLeft = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltime
            // 
            this.lbltime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbltime.Location = new System.Drawing.Point(268, 9);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(200, 30);
            this.lbltime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(161, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // lblplusLeft
            // 
            this.lblplusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblplusLeft.Location = new System.Drawing.Point(50, 75);
            this.lblplusLeft.Name = "lblplusLeft";
            this.lblplusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblplusLeft.TabIndex = 2;
            this.lblplusLeft.Text = "?";
            this.lblplusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblplusRight
            // 
            this.lblplusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblplusRight.Location = new System.Drawing.Point(182, 75);
            this.lblplusRight.Name = "lblplusRight";
            this.lblplusRight.Size = new System.Drawing.Size(60, 50);
            this.lblplusRight.TabIndex = 3;
            this.lblplusRight.Text = "?";
            this.lblplusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(248, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblplussign
            // 
            this.lblplussign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblplussign.Location = new System.Drawing.Point(116, 75);
            this.lblplussign.Name = "lblplussign";
            this.lblplussign.Size = new System.Drawing.Size(60, 50);
            this.lblplussign.TabIndex = 5;
            this.lblplussign.Text = "+";
            this.lblplussign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sum.Location = new System.Drawing.Point(314, 84);
            this.sum.MaximumSize = new System.Drawing.Size(100, 0);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 1;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.difference.Location = new System.Drawing.Point(314, 134);
            this.difference.MaximumSize = new System.Drawing.Size(100, 0);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 35);
            this.difference.TabIndex = 2;
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // lblminussign
            // 
            this.lblminussign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblminussign.Location = new System.Drawing.Point(116, 125);
            this.lblminussign.Name = "lblminussign";
            this.lblminussign.Size = new System.Drawing.Size(60, 50);
            this.lblminussign.TabIndex = 10;
            this.lblminussign.Text = "-";
            this.lblminussign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(248, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 9;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblminusRight
            // 
            this.lblminusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblminusRight.Location = new System.Drawing.Point(182, 125);
            this.lblminusRight.Name = "lblminusRight";
            this.lblminusRight.Size = new System.Drawing.Size(60, 50);
            this.lblminusRight.TabIndex = 8;
            this.lblminusRight.Text = "?";
            this.lblminusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblminusLeft
            // 
            this.lblminusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblminusLeft.Location = new System.Drawing.Point(50, 125);
            this.lblminusLeft.Name = "lblminusLeft";
            this.lblminusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblminusLeft.TabIndex = 7;
            this.lblminusLeft.Text = "?";
            this.lblminusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.product.Location = new System.Drawing.Point(314, 184);
            this.product.MaximumSize = new System.Drawing.Size(100, 0);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 35);
            this.product.TabIndex = 3;
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // lblmulsign
            // 
            this.lblmulsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblmulsign.Location = new System.Drawing.Point(116, 175);
            this.lblmulsign.Name = "lblmulsign";
            this.lblmulsign.Size = new System.Drawing.Size(60, 50);
            this.lblmulsign.TabIndex = 15;
            this.lblmulsign.Text = "*";
            this.lblmulsign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(248, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 14;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltimesRight
            // 
            this.lbltimesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbltimesRight.Location = new System.Drawing.Point(182, 175);
            this.lbltimesRight.Name = "lbltimesRight";
            this.lbltimesRight.Size = new System.Drawing.Size(60, 50);
            this.lbltimesRight.TabIndex = 13;
            this.lbltimesRight.Text = "?";
            this.lbltimesRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltimesLeft
            // 
            this.lbltimesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbltimesLeft.Location = new System.Drawing.Point(50, 175);
            this.lbltimesLeft.Name = "lbltimesLeft";
            this.lbltimesLeft.Size = new System.Drawing.Size(60, 50);
            this.lbltimesLeft.TabIndex = 12;
            this.lbltimesLeft.Text = "?";
            this.lbltimesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.quotient.Location = new System.Drawing.Point(314, 234);
            this.quotient.MaximumSize = new System.Drawing.Size(100, 0);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 35);
            this.quotient.TabIndex = 4;
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // lbldivsign
            // 
            this.lbldivsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbldivsign.Location = new System.Drawing.Point(116, 225);
            this.lbldivsign.Name = "lbldivsign";
            this.lbldivsign.Size = new System.Drawing.Size(60, 50);
            this.lbldivsign.TabIndex = 20;
            this.lbldivsign.Text = "÷";
            this.lbldivsign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(248, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 19;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldividedRight
            // 
            this.lbldividedRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbldividedRight.Location = new System.Drawing.Point(182, 225);
            this.lbldividedRight.Name = "lbldividedRight";
            this.lbldividedRight.Size = new System.Drawing.Size(60, 50);
            this.lbldividedRight.TabIndex = 18;
            this.lbldividedRight.Text = "?";
            this.lbldividedRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldividedLeft
            // 
            this.lbldividedLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbldividedLeft.Location = new System.Drawing.Point(50, 225);
            this.lbldividedLeft.Name = "lbldividedLeft";
            this.lbldividedLeft.Size = new System.Drawing.Size(60, 50);
            this.lbldividedLeft.TabIndex = 17;
            this.lbldividedLeft.Text = "?";
            this.lbldividedLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnstart
            // 
            this.btnstart.AutoSize = true;
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnstart.Location = new System.Drawing.Point(178, 293);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(139, 34);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Start The Quiz";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.lbldivsign);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbldividedRight);
            this.Controls.Add(this.lbldividedLeft);
            this.Controls.Add(this.product);
            this.Controls.Add(this.lblmulsign);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbltimesRight);
            this.Controls.Add(this.lbltimesLeft);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.lblminussign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblminusRight);
            this.Controls.Add(this.lblminusLeft);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.lblplussign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblplusRight);
            this.Controls.Add(this.lblplusLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblplusLeft;
        private System.Windows.Forms.Label lblplusRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblplussign;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label lblminussign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblminusRight;
        private System.Windows.Forms.Label lblminusLeft;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label lblmulsign;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbltimesRight;
        private System.Windows.Forms.Label lbltimesLeft;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label lbldivsign;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbldividedRight;
        private System.Windows.Forms.Label lbldividedLeft;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Timer timer1;
    }
}

