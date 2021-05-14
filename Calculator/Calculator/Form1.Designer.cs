
namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblResult = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bNumDiv = new System.Windows.Forms.Button();
            this.bNum9 = new System.Windows.Forms.Button();
            this.bNumMult = new System.Windows.Forms.Button();
            this.bNum6 = new System.Windows.Forms.Button();
            this.bNumPlus = new System.Windows.Forms.Button();
            this.bNumEqual = new System.Windows.Forms.Button();
            this.bNumMinus = new System.Windows.Forms.Button();
            this.bNumPoint = new System.Windows.Forms.Button();
            this.bNum3 = new System.Windows.Forms.Button();
            this.bNum8 = new System.Windows.Forms.Button();
            this.bNum7 = new System.Windows.Forms.Button();
            this.bNum5 = new System.Windows.Forms.Button();
            this.bNum4 = new System.Windows.Forms.Button();
            this.bNum0 = new System.Windows.Forms.Button();
            this.bNumCE = new System.Windows.Forms.Button();
            this.bNumC = new System.Windows.Forms.Button();
            this.bNum2 = new System.Windows.Forms.Button();
            this.bNum1 = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 4);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(10, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bNumDiv
            // 
            this.bNumDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNumDiv.Location = new System.Drawing.Point(178, 102);
            this.bNumDiv.Name = "bNumDiv";
            this.bNumDiv.Size = new System.Drawing.Size(50, 50);
            this.bNumDiv.TabIndex = 19;
            this.bNumDiv.Text = "/";
            this.bNumDiv.UseVisualStyleBackColor = true;
            this.bNumDiv.Click += new System.EventHandler(this.OperandEvent);
            // 
            // bNum9
            // 
            this.bNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNum9.Location = new System.Drawing.Point(122, 102);
            this.bNum9.Name = "bNum9";
            this.bNum9.Size = new System.Drawing.Size(50, 50);
            this.bNum9.TabIndex = 18;
            this.bNum9.Text = "9";
            this.bNum9.UseVisualStyleBackColor = true;
            this.bNum9.Click += new System.EventHandler(this.button_click);
            // 
            // bNumMult
            // 
            this.bNumMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNumMult.Location = new System.Drawing.Point(178, 158);
            this.bNumMult.Name = "bNumMult";
            this.bNumMult.Size = new System.Drawing.Size(50, 50);
            this.bNumMult.TabIndex = 17;
            this.bNumMult.Text = "X";
            this.bNumMult.UseVisualStyleBackColor = true;
            this.bNumMult.Click += new System.EventHandler(this.OperandEvent);
            // 
            // bNum6
            // 
            this.bNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNum6.Location = new System.Drawing.Point(122, 158);
            this.bNum6.Name = "bNum6";
            this.bNum6.Size = new System.Drawing.Size(50, 50);
            this.bNum6.TabIndex = 16;
            this.bNum6.Text = "6";
            this.bNum6.UseVisualStyleBackColor = true;
            this.bNum6.Click += new System.EventHandler(this.button_click);
            // 
            // bNumPlus
            // 
            this.bNumPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNumPlus.Location = new System.Drawing.Point(178, 270);
            this.bNumPlus.Name = "bNumPlus";
            this.bNumPlus.Size = new System.Drawing.Size(50, 50);
            this.bNumPlus.TabIndex = 15;
            this.bNumPlus.Text = "+";
            this.bNumPlus.UseVisualStyleBackColor = true;
            this.bNumPlus.Click += new System.EventHandler(this.OperandEvent);
            // 
            // bNumEqual
            // 
            this.bNumEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNumEqual.Location = new System.Drawing.Point(234, 214);
            this.bNumEqual.Name = "bNumEqual";
            this.bNumEqual.Size = new System.Drawing.Size(50, 106);
            this.bNumEqual.TabIndex = 14;
            this.bNumEqual.Text = "=";
            this.bNumEqual.UseVisualStyleBackColor = true;
            this.bNumEqual.Click += new System.EventHandler(this.bNumEqual_Click);
            // 
            // bNumMinus
            // 
            this.bNumMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNumMinus.Location = new System.Drawing.Point(178, 214);
            this.bNumMinus.Name = "bNumMinus";
            this.bNumMinus.Size = new System.Drawing.Size(50, 50);
            this.bNumMinus.TabIndex = 13;
            this.bNumMinus.Text = "-";
            this.bNumMinus.UseVisualStyleBackColor = true;
            this.bNumMinus.Click += new System.EventHandler(this.OperandEvent);
            // 
            // bNumPoint
            // 
            this.bNumPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNumPoint.Location = new System.Drawing.Point(122, 270);
            this.bNumPoint.Name = "bNumPoint";
            this.bNumPoint.Size = new System.Drawing.Size(50, 50);
            this.bNumPoint.TabIndex = 3;
            this.bNumPoint.Text = ",";
            this.bNumPoint.UseVisualStyleBackColor = true;
            this.bNumPoint.Click += new System.EventHandler(this.button_click);
            // 
            // bNum3
            // 
            this.bNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNum3.Location = new System.Drawing.Point(122, 214);
            this.bNum3.Name = "bNum3";
            this.bNum3.Size = new System.Drawing.Size(50, 50);
            this.bNum3.TabIndex = 11;
            this.bNum3.Text = "3";
            this.bNum3.UseVisualStyleBackColor = true;
            this.bNum3.Click += new System.EventHandler(this.button_click);
            // 
            // bNum8
            // 
            this.bNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNum8.Location = new System.Drawing.Point(66, 102);
            this.bNum8.Name = "bNum8";
            this.bNum8.Size = new System.Drawing.Size(50, 50);
            this.bNum8.TabIndex = 10;
            this.bNum8.Text = "8";
            this.bNum8.UseVisualStyleBackColor = true;
            this.bNum8.Click += new System.EventHandler(this.button_click);
            // 
            // bNum7
            // 
            this.bNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNum7.Location = new System.Drawing.Point(10, 102);
            this.bNum7.Name = "bNum7";
            this.bNum7.Size = new System.Drawing.Size(50, 50);
            this.bNum7.TabIndex = 9;
            this.bNum7.Text = "7";
            this.bNum7.UseVisualStyleBackColor = true;
            this.bNum7.Click += new System.EventHandler(this.button_click);
            // 
            // bNum5
            // 
            this.bNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNum5.Location = new System.Drawing.Point(66, 158);
            this.bNum5.Name = "bNum5";
            this.bNum5.Size = new System.Drawing.Size(50, 50);
            this.bNum5.TabIndex = 8;
            this.bNum5.Text = "5";
            this.bNum5.UseVisualStyleBackColor = true;
            this.bNum5.Click += new System.EventHandler(this.button_click);
            // 
            // bNum4
            // 
            this.bNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNum4.Location = new System.Drawing.Point(10, 158);
            this.bNum4.Name = "bNum4";
            this.bNum4.Size = new System.Drawing.Size(50, 50);
            this.bNum4.TabIndex = 7;
            this.bNum4.Text = "4";
            this.bNum4.UseVisualStyleBackColor = true;
            this.bNum4.Click += new System.EventHandler(this.button_click);
            // 
            // bNum0
            // 
            this.bNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNum0.Location = new System.Drawing.Point(66, 270);
            this.bNum0.Name = "bNum0";
            this.bNum0.Size = new System.Drawing.Size(50, 50);
            this.bNum0.TabIndex = 6;
            this.bNum0.Text = "0";
            this.bNum0.UseVisualStyleBackColor = true;
            this.bNum0.Click += new System.EventHandler(this.button_click);
            // 
            // bNumCE
            // 
            this.bNumCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNumCE.Location = new System.Drawing.Point(234, 158);
            this.bNumCE.Name = "bNumCE";
            this.bNumCE.Size = new System.Drawing.Size(50, 50);
            this.bNumCE.TabIndex = 5;
            this.bNumCE.Text = "CE";
            this.bNumCE.UseVisualStyleBackColor = true;
            this.bNumCE.Click += new System.EventHandler(this.bNumCE_Click);
            // 
            // bNumC
            // 
            this.bNumC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNumC.Location = new System.Drawing.Point(234, 102);
            this.bNumC.Name = "bNumC";
            this.bNumC.Size = new System.Drawing.Size(50, 50);
            this.bNumC.TabIndex = 4;
            this.bNumC.Text = "C";
            this.bNumC.UseVisualStyleBackColor = true;
            this.bNumC.Click += new System.EventHandler(this.bNumC_Click);
            // 
            // bNum2
            // 
            this.bNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNum2.Location = new System.Drawing.Point(66, 214);
            this.bNum2.Name = "bNum2";
            this.bNum2.Size = new System.Drawing.Size(50, 50);
            this.bNum2.TabIndex = 20;
            this.bNum2.Text = "2";
            this.bNum2.UseVisualStyleBackColor = true;
            this.bNum2.Click += new System.EventHandler(this.button_click);
            // 
            // bNum1
            // 
            this.bNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNum1.Location = new System.Drawing.Point(10, 214);
            this.bNum1.Name = "bNum1";
            this.bNum1.Size = new System.Drawing.Size(50, 50);
            this.bNum1.TabIndex = 12;
            this.bNum1.Text = "1";
            this.bNum1.UseVisualStyleBackColor = true;
            this.bNum1.Click += new System.EventHandler(this.button_click);
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverse.Location = new System.Drawing.Point(10, 270);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(50, 50);
            this.btnReverse.TabIndex = 15;
            this.btnReverse.Text = "+/-";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.OperandReverse);
            // 
            // btnMPlus
            // 
            this.btnMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPlus.Location = new System.Drawing.Point(122, 46);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(50, 50);
            this.btnMPlus.TabIndex = 9;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.OperationMemoryPlus);
            // 
            // btnMC
            // 
            this.btnMC.Enabled = false;
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.Location = new System.Drawing.Point(66, 46);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(50, 50);
            this.btnMC.TabIndex = 9;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.OperationMemoryClear);
            // 
            // btnMR
            // 
            this.btnMR.Enabled = false;
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMR.Location = new System.Drawing.Point(10, 46);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(50, 50);
            this.btnMR.TabIndex = 9;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.OperationMemoryResult);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(178, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 9;
            this.button3.Text = "M-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoot.Location = new System.Drawing.Point(234, 46);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(50, 50);
            this.btnRoot.TabIndex = 4;
            this.btnRoot.Text = "√";
            this.btnRoot.UseVisualStyleBackColor = true;
            this.btnRoot.Click += new System.EventHandler(this.Root);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 332);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bNumDiv);
            this.Controls.Add(this.bNum9);
            this.Controls.Add(this.bNumMult);
            this.Controls.Add(this.bNum6);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.bNumPlus);
            this.Controls.Add(this.bNumEqual);
            this.Controls.Add(this.bNumMinus);
            this.Controls.Add(this.bNumPoint);
            this.Controls.Add(this.bNum3);
            this.Controls.Add(this.bNum8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.bNum7);
            this.Controls.Add(this.bNum5);
            this.Controls.Add(this.bNum4);
            this.Controls.Add(this.bNum0);
            this.Controls.Add(this.bNumCE);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.bNumC);
            this.Controls.Add(this.bNum2);
            this.Controls.Add(this.bNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calcolator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bNumDiv;
        private System.Windows.Forms.Button bNum9;
        private System.Windows.Forms.Button bNumMult;
        private System.Windows.Forms.Button bNum6;
        private System.Windows.Forms.Button bNumPlus;
        private System.Windows.Forms.Button bNumEqual;
        private System.Windows.Forms.Button bNumMinus;
        private System.Windows.Forms.Button bNumPoint;
        private System.Windows.Forms.Button bNum3;
        private System.Windows.Forms.Button bNum8;
        private System.Windows.Forms.Button bNum7;
        private System.Windows.Forms.Button bNum5;
        private System.Windows.Forms.Button bNum4;
        private System.Windows.Forms.Button bNum0;
        private System.Windows.Forms.Button bNumCE;
        private System.Windows.Forms.Button bNumC;
        private System.Windows.Forms.Button bNum2;
        private System.Windows.Forms.Button bNum1;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRoot;
    }
}

