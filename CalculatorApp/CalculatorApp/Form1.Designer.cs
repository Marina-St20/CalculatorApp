namespace CalculatorApp
{
    partial class calculatorForm
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
            backspaceButton = new Button();
            label1 = new Label();
            textDisplay = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            openPButton = new Button();
            closePButton = new Button();
            divideButton = new Button();
            sevenButton = new Button();
            eightButton = new Button();
            nineButton = new Button();
            multiplyButton = new Button();
            fourButton = new Button();
            fiveButton = new Button();
            sixButton = new Button();
            subtractButton = new Button();
            oneButton = new Button();
            twoButton = new Button();
            threeButton = new Button();
            addButton = new Button();
            zeroButton = new Button();
            decimalButton = new Button();
            eButton = new Button();
            equalsButton = new Button();
            SuspendLayout();
            // 
            // backspaceButton
            // 
            backspaceButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            backspaceButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            backspaceButton.Location = new Point(12, 164);
            backspaceButton.Name = "backspaceButton";
            backspaceButton.Size = new Size(94, 82);
            backspaceButton.TabIndex = 0;
            backspaceButton.Text = "BKSP";
            backspaceButton.UseMnemonic = false;
            backspaceButton.UseVisualStyleBackColor = true;
            backspaceButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 93);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // textDisplay
            // 
            textDisplay.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDisplay.ForeColor = SystemColors.WindowFrame;
            textDisplay.Location = new Point(12, 12);
            textDisplay.Multiline = true;
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(459, 133);
            textDisplay.TabIndex = 2;
            textDisplay.TabStop = false;
            textDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // openPButton
            // 
            openPButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            openPButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            openPButton.Location = new Point(133, 164);
            openPButton.Name = "openPButton";
            openPButton.Size = new Size(94, 82);
            openPButton.TabIndex = 3;
            openPButton.Text = "(";
            openPButton.UseMnemonic = false;
            openPButton.UseVisualStyleBackColor = true;
            // 
            // closePButton
            // 
            closePButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            closePButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            closePButton.Location = new Point(255, 164);
            closePButton.Name = "closePButton";
            closePButton.Size = new Size(94, 82);
            closePButton.TabIndex = 4;
            closePButton.Text = ")";
            closePButton.UseMnemonic = false;
            closePButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            divideButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            divideButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            divideButton.Location = new Point(377, 164);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(94, 82);
            divideButton.TabIndex = 5;
            divideButton.Text = "/";
            divideButton.UseMnemonic = false;
            divideButton.UseVisualStyleBackColor = true;
            // 
            // sevenButton
            // 
            sevenButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sevenButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            sevenButton.Location = new Point(12, 272);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(94, 82);
            sevenButton.TabIndex = 6;
            sevenButton.Text = "7";
            sevenButton.UseMnemonic = false;
            sevenButton.UseVisualStyleBackColor = true;
            // 
            // eightButton
            // 
            eightButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            eightButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            eightButton.Location = new Point(133, 272);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(94, 82);
            eightButton.TabIndex = 7;
            eightButton.Text = "8";
            eightButton.UseMnemonic = false;
            eightButton.UseVisualStyleBackColor = true;
            // 
            // nineButton
            // 
            nineButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nineButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            nineButton.Location = new Point(255, 272);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(94, 82);
            nineButton.TabIndex = 8;
            nineButton.Text = "9";
            nineButton.UseMnemonic = false;
            nineButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            multiplyButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            multiplyButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            multiplyButton.Location = new Point(377, 272);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(94, 82);
            multiplyButton.TabIndex = 9;
            multiplyButton.Text = "x";
            multiplyButton.UseMnemonic = false;
            multiplyButton.UseVisualStyleBackColor = true;
            // 
            // fourButton
            // 
            fourButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fourButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            fourButton.Location = new Point(12, 381);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(94, 82);
            fourButton.TabIndex = 10;
            fourButton.Text = "4";
            fourButton.UseMnemonic = false;
            fourButton.UseVisualStyleBackColor = true;
            // 
            // fiveButton
            // 
            fiveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fiveButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            fiveButton.Location = new Point(133, 381);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(94, 82);
            fiveButton.TabIndex = 11;
            fiveButton.Text = "5";
            fiveButton.UseMnemonic = false;
            fiveButton.UseVisualStyleBackColor = true;
            // 
            // sixButton
            // 
            sixButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sixButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            sixButton.Location = new Point(255, 381);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(94, 82);
            sixButton.TabIndex = 12;
            sixButton.Text = "6";
            sixButton.UseMnemonic = false;
            sixButton.UseVisualStyleBackColor = true;
            // 
            // subtractButton
            // 
            subtractButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subtractButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            subtractButton.Location = new Point(377, 381);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(94, 82);
            subtractButton.TabIndex = 13;
            subtractButton.Text = "-";
            subtractButton.UseMnemonic = false;
            subtractButton.UseVisualStyleBackColor = true;
            // 
            // oneButton
            // 
            oneButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            oneButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            oneButton.Location = new Point(12, 490);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(94, 82);
            oneButton.TabIndex = 14;
            oneButton.Text = "1";
            oneButton.UseMnemonic = false;
            oneButton.UseVisualStyleBackColor = true;
            // 
            // twoButton
            // 
            twoButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            twoButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            twoButton.Location = new Point(133, 490);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(94, 82);
            twoButton.TabIndex = 15;
            twoButton.Text = "2";
            twoButton.UseMnemonic = false;
            twoButton.UseVisualStyleBackColor = true;
            // 
            // threeButton
            // 
            threeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            threeButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            threeButton.Location = new Point(255, 490);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(94, 82);
            threeButton.TabIndex = 16;
            threeButton.Text = "3";
            threeButton.UseMnemonic = false;
            threeButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            addButton.Location = new Point(377, 490);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 82);
            addButton.TabIndex = 17;
            addButton.Text = "+";
            addButton.UseMnemonic = false;
            addButton.UseVisualStyleBackColor = true;
            // 
            // zeroButton
            // 
            zeroButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            zeroButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            zeroButton.Location = new Point(12, 598);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(94, 82);
            zeroButton.TabIndex = 18;
            zeroButton.Text = "0";
            zeroButton.UseMnemonic = false;
            zeroButton.UseVisualStyleBackColor = true;
            // 
            // decimalButton
            // 
            decimalButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            decimalButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            decimalButton.Location = new Point(133, 598);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(94, 82);
            decimalButton.TabIndex = 19;
            decimalButton.Text = ".";
            decimalButton.UseMnemonic = false;
            decimalButton.UseVisualStyleBackColor = true;
            // 
            // eButton
            // 
            eButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            eButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            eButton.Location = new Point(255, 598);
            eButton.Name = "eButton";
            eButton.Size = new Size(94, 82);
            eButton.TabIndex = 20;
            eButton.Text = "e";
            eButton.UseMnemonic = false;
            eButton.UseVisualStyleBackColor = true;
            // 
            // equalsButton
            // 
            equalsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            equalsButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            equalsButton.Location = new Point(377, 598);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(94, 82);
            equalsButton.TabIndex = 21;
            equalsButton.Text = "=";
            equalsButton.UseMnemonic = false;
            equalsButton.UseVisualStyleBackColor = true;
            // 
            // calculatorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(483, 690);
            Controls.Add(equalsButton);
            Controls.Add(eButton);
            Controls.Add(decimalButton);
            Controls.Add(zeroButton);
            Controls.Add(addButton);
            Controls.Add(threeButton);
            Controls.Add(twoButton);
            Controls.Add(oneButton);
            Controls.Add(subtractButton);
            Controls.Add(sixButton);
            Controls.Add(fiveButton);
            Controls.Add(fourButton);
            Controls.Add(multiplyButton);
            Controls.Add(nineButton);
            Controls.Add(eightButton);
            Controls.Add(sevenButton);
            Controls.Add(divideButton);
            Controls.Add(closePButton);
            Controls.Add(openPButton);
            Controls.Add(textDisplay);
            Controls.Add(label1);
            Controls.Add(backspaceButton);
            Name = "calculatorForm";
            Text = "CalculatorApp";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backspaceButton;
        private Label label1;
        private TextBox textDisplay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button openPButton;
        private Button closePButton;
        private Button divideButton;
        private Button sevenButton;
        private Button eightButton;
        private Button nineButton;
        private Button multiplyButton;
        private Button fourButton;
        private Button fiveButton;
        private Button sixButton;
        private Button subtractButton;
        private Button oneButton;
        private Button twoButton;
        private Button threeButton;
        private Button addButton;
        private Button zeroButton;
        private Button decimalButton;
        private Button eButton;
        private Button equalsButton;
    }
}
