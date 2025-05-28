namespace Shared.Win
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            firstNumber = new TextBox();
            secondNumber = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMult = new Button();
            btnDivide = new Button();
            label3 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 62);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Primeiro Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 134);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 1;
            label2.Text = "Segundo Número";
            // 
            // firstNumber
            // 
            firstNumber.Location = new Point(37, 100);
            firstNumber.Name = "firstNumber";
            firstNumber.Size = new Size(150, 31);
            firstNumber.TabIndex = 2;
            // 
            // secondNumber
            // 
            secondNumber.Location = new Point(41, 166);
            secondNumber.Name = "secondNumber";
            secondNumber.Size = new Size(150, 31);
            secondNumber.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(41, 238);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Somar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(191, 238);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(112, 34);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "Subtrair";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(41, 294);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(112, 34);
            btnMult.TabIndex = 6;
            btnMult.Text = "Multiplicar";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(191, 294);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(112, 34);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "Dividir";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Location = new Point(233, 103);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 8;
            label3.Text = "Resultado:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10F);
            lblResult.Location = new Point(236, 130);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 28);
            lblResult.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 384);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(btnDivide);
            Controls.Add(btnMult);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(secondNumber);
            Controls.Add(firstNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox firstNumber;
        private TextBox secondNumber;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMult;
        private Button btnDivide;
        private Label label3;
        private Label lblResult;
    }
}
