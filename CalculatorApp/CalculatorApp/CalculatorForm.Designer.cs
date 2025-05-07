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
            textDisplay = new Label();
            SuspendLayout();
            // 
            // backspaceButton
            // 
            backspaceButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            backspaceButton.BackColor = SystemColors.Window;
            backspaceButton.FlatAppearance.BorderColor = Color.Black;
            backspaceButton.FlatAppearance.BorderSize = 0;
            backspaceButton.FlatStyle = FlatStyle.Flat;
            backspaceButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            backspaceButton.ForeColor = Color.FromArgb(64, 64, 64);
            backspaceButton.Location = new Point(12, 164);
            backspaceButton.Name = "backspaceButton";
            backspaceButton.Size = new Size(94, 82);
            backspaceButton.TabIndex = 0;
            backspaceButton.TabStop = false;
            backspaceButton.Text = "BKSP";
            backspaceButton.UseMnemonic = false;
            backspaceButton.UseVisualStyleBackColor = false;
            backspaceButton.Click += backspaceButton_Click;
            // 
            // openPButton
            // 
            openPButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            openPButton.BackColor = SystemColors.Window;
            openPButton.FlatAppearance.BorderSize = 0;
            openPButton.FlatStyle = FlatStyle.Flat;
            openPButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            openPButton.ForeColor = Color.FromArgb(64, 64, 64);
            openPButton.Location = new Point(133, 164);
            openPButton.Name = "openPButton";
            openPButton.Size = new Size(94, 82);
            openPButton.TabIndex = 1;
            openPButton.TabStop = false;
            openPButton.Text = "(";
            openPButton.UseMnemonic = false;
            openPButton.UseVisualStyleBackColor = false;
            openPButton.Click += openPButton_Click;
            // 
            // closePButton
            // 
            closePButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            closePButton.BackColor = SystemColors.Window;
            closePButton.FlatAppearance.BorderSize = 0;
            closePButton.FlatStyle = FlatStyle.Flat;
            closePButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            closePButton.ForeColor = Color.FromArgb(64, 64, 64);
            closePButton.Location = new Point(255, 164);
            closePButton.Name = "closePButton";
            closePButton.Size = new Size(94, 82);
            closePButton.TabIndex = 2;
            closePButton.TabStop = false;
            closePButton.Text = ")";
            closePButton.UseMnemonic = false;
            closePButton.UseVisualStyleBackColor = false;
            closePButton.Click += closePButton_Click;
            // 
            // divideButton
            // 
            divideButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            divideButton.BackColor = SystemColors.Window;
            divideButton.FlatAppearance.BorderSize = 0;
            divideButton.FlatStyle = FlatStyle.Flat;
            divideButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            divideButton.ForeColor = Color.FromArgb(64, 64, 64);
            divideButton.Location = new Point(377, 164);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(94, 82);
            divideButton.TabIndex = 3;
            divideButton.TabStop = false;
            divideButton.Text = "/";
            divideButton.UseMnemonic = false;
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += divideButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sevenButton.BackColor = SystemColors.Window;
            sevenButton.FlatAppearance.BorderSize = 0;
            sevenButton.FlatStyle = FlatStyle.Flat;
            sevenButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            sevenButton.ForeColor = Color.FromArgb(64, 64, 64);
            sevenButton.Location = new Point(12, 272);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(94, 82);
            sevenButton.TabIndex = 4;
            sevenButton.TabStop = false;
            sevenButton.Text = "7";
            sevenButton.UseMnemonic = false;
            sevenButton.UseVisualStyleBackColor = false;
            sevenButton.Click += sevenButton_Click;
            // 
            // eightButton
            // 
            eightButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            eightButton.BackColor = SystemColors.Window;
            eightButton.FlatAppearance.BorderSize = 0;
            eightButton.FlatStyle = FlatStyle.Flat;
            eightButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            eightButton.ForeColor = Color.FromArgb(64, 64, 64);
            eightButton.Location = new Point(133, 272);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(94, 82);
            eightButton.TabIndex = 5;
            eightButton.TabStop = false;
            eightButton.Text = "8";
            eightButton.UseMnemonic = false;
            eightButton.UseVisualStyleBackColor = false;
            eightButton.Click += eightButton_Click;
            // 
            // nineButton
            // 
            nineButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nineButton.BackColor = SystemColors.Window;
            nineButton.FlatAppearance.BorderSize = 0;
            nineButton.FlatStyle = FlatStyle.Flat;
            nineButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            nineButton.ForeColor = Color.FromArgb(64, 64, 64);
            nineButton.Location = new Point(255, 272);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(94, 82);
            nineButton.TabIndex = 6;
            nineButton.TabStop = false;
            nineButton.Text = "9";
            nineButton.UseMnemonic = false;
            nineButton.UseVisualStyleBackColor = false;
            nineButton.Click += nineButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            multiplyButton.BackColor = SystemColors.Window;
            multiplyButton.FlatAppearance.BorderSize = 0;
            multiplyButton.FlatStyle = FlatStyle.Flat;
            multiplyButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            multiplyButton.ForeColor = Color.FromArgb(64, 64, 64);
            multiplyButton.Location = new Point(377, 272);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(94, 82);
            multiplyButton.TabIndex = 7;
            multiplyButton.TabStop = false;
            multiplyButton.Text = "x";
            multiplyButton.UseMnemonic = false;
            multiplyButton.UseVisualStyleBackColor = false;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // fourButton
            // 
            fourButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fourButton.BackColor = SystemColors.Window;
            fourButton.FlatAppearance.BorderSize = 0;
            fourButton.FlatStyle = FlatStyle.Flat;
            fourButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            fourButton.ForeColor = Color.FromArgb(64, 64, 64);
            fourButton.Location = new Point(12, 381);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(94, 82);
            fourButton.TabIndex = 8;
            fourButton.TabStop = false;
            fourButton.Text = "4";
            fourButton.UseMnemonic = false;
            fourButton.UseVisualStyleBackColor = false;
            fourButton.Click += fourButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fiveButton.BackColor = SystemColors.Window;
            fiveButton.FlatAppearance.BorderSize = 0;
            fiveButton.FlatStyle = FlatStyle.Flat;
            fiveButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            fiveButton.ForeColor = Color.FromArgb(64, 64, 64);
            fiveButton.Location = new Point(133, 381);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(94, 82);
            fiveButton.TabIndex = 9;
            fiveButton.TabStop = false;
            fiveButton.Text = "5";
            fiveButton.UseMnemonic = false;
            fiveButton.UseVisualStyleBackColor = false;
            fiveButton.Click += fiveButton_Click;
            // 
            // sixButton
            // 
            sixButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sixButton.BackColor = SystemColors.Window;
            sixButton.FlatAppearance.BorderSize = 0;
            sixButton.FlatStyle = FlatStyle.Flat;
            sixButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            sixButton.ForeColor = Color.FromArgb(64, 64, 64);
            sixButton.Location = new Point(255, 381);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(94, 82);
            sixButton.TabIndex = 10;
            sixButton.TabStop = false;
            sixButton.Text = "6";
            sixButton.UseMnemonic = false;
            sixButton.UseVisualStyleBackColor = false;
            sixButton.Click += sixButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subtractButton.BackColor = SystemColors.Window;
            subtractButton.FlatAppearance.BorderSize = 0;
            subtractButton.FlatStyle = FlatStyle.Flat;
            subtractButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            subtractButton.ForeColor = Color.FromArgb(64, 64, 64);
            subtractButton.Location = new Point(377, 381);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(94, 82);
            subtractButton.TabIndex = 11;
            subtractButton.TabStop = false;
            subtractButton.Text = "-";
            subtractButton.UseMnemonic = false;
            subtractButton.UseVisualStyleBackColor = false;
            subtractButton.Click += subtractButton_Click;
            // 
            // oneButton
            // 
            oneButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            oneButton.BackColor = SystemColors.Window;
            oneButton.FlatAppearance.BorderSize = 0;
            oneButton.FlatStyle = FlatStyle.Flat;
            oneButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            oneButton.ForeColor = Color.FromArgb(64, 64, 64);
            oneButton.Location = new Point(12, 490);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(94, 82);
            oneButton.TabIndex = 12;
            oneButton.TabStop = false;
            oneButton.Text = "1";
            oneButton.UseMnemonic = false;
            oneButton.UseVisualStyleBackColor = false;
            oneButton.Click += oneButton_Click;
            // 
            // twoButton
            // 
            twoButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            twoButton.BackColor = SystemColors.Window;
            twoButton.FlatAppearance.BorderSize = 0;
            twoButton.FlatStyle = FlatStyle.Flat;
            twoButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            twoButton.ForeColor = Color.FromArgb(64, 64, 64);
            twoButton.Location = new Point(133, 490);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(94, 82);
            twoButton.TabIndex = 13;
            twoButton.TabStop = false;
            twoButton.Text = "2";
            twoButton.UseMnemonic = false;
            twoButton.UseVisualStyleBackColor = false;
            twoButton.Click += twoButton_Click;
            // 
            // threeButton
            // 
            threeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            threeButton.BackColor = SystemColors.Window;
            threeButton.FlatAppearance.BorderSize = 0;
            threeButton.FlatStyle = FlatStyle.Flat;
            threeButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            threeButton.ForeColor = Color.FromArgb(64, 64, 64);
            threeButton.Location = new Point(255, 490);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(94, 82);
            threeButton.TabIndex = 14;
            threeButton.TabStop = false;
            threeButton.Text = "3";
            threeButton.UseMnemonic = false;
            threeButton.UseVisualStyleBackColor = false;
            threeButton.Click += threeButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addButton.BackColor = SystemColors.Window;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            addButton.ForeColor = Color.FromArgb(64, 64, 64);
            addButton.Location = new Point(377, 490);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 82);
            addButton.TabIndex = 15;
            addButton.TabStop = false;
            addButton.Text = "+";
            addButton.UseMnemonic = false;
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            zeroButton.BackColor = SystemColors.Window;
            zeroButton.FlatAppearance.BorderSize = 0;
            zeroButton.FlatStyle = FlatStyle.Flat;
            zeroButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            zeroButton.ForeColor = Color.FromArgb(64, 64, 64);
            zeroButton.Location = new Point(12, 598);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(94, 82);
            zeroButton.TabIndex = 16;
            zeroButton.TabStop = false;
            zeroButton.Text = "0";
            zeroButton.UseMnemonic = false;
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += zeroButton_Click;
            // 
            // decimalButton
            // 
            decimalButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            decimalButton.BackColor = SystemColors.Window;
            decimalButton.FlatAppearance.BorderSize = 0;
            decimalButton.FlatStyle = FlatStyle.Flat;
            decimalButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            decimalButton.ForeColor = Color.FromArgb(64, 64, 64);
            decimalButton.Location = new Point(133, 598);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(94, 82);
            decimalButton.TabIndex = 17;
            decimalButton.TabStop = false;
            decimalButton.Text = ".";
            decimalButton.UseMnemonic = false;
            decimalButton.UseVisualStyleBackColor = false;
            decimalButton.Click += decimalButton_Click;
            // 
            // eButton
            // 
            eButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            eButton.BackColor = SystemColors.Window;
            eButton.FlatAppearance.BorderSize = 0;
            eButton.FlatStyle = FlatStyle.Flat;
            eButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            eButton.ForeColor = Color.FromArgb(64, 64, 64);
            eButton.Location = new Point(255, 598);
            eButton.Name = "eButton";
            eButton.Size = new Size(94, 82);
            eButton.TabIndex = 18;
            eButton.TabStop = false;
            eButton.Text = "%";
            eButton.UseMnemonic = false;
            eButton.UseVisualStyleBackColor = false;
            eButton.Click += percentButton_Click;
            // 
            // equalsButton
            // 
            equalsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            equalsButton.BackColor = SystemColors.Window;
            equalsButton.FlatAppearance.BorderSize = 0;
            equalsButton.FlatStyle = FlatStyle.Flat;
            equalsButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            equalsButton.ForeColor = Color.FromArgb(64, 64, 64);
            equalsButton.Location = new Point(377, 598);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(94, 82);
            equalsButton.TabIndex = 19;
            equalsButton.TabStop = false;
            equalsButton.Text = "=";
            equalsButton.UseMnemonic = false;
            equalsButton.UseVisualStyleBackColor = false;
            equalsButton.Click += equalsButton_Click;
            // 
            // textDisplay
            // 
            textDisplay.BackColor = Color.White;
            textDisplay.Font = new Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDisplay.ForeColor = SystemColors.WindowFrame;
            textDisplay.Location = new Point(12, 12);
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(459, 133);
            textDisplay.TabIndex = 20;
            textDisplay.TextAlign = ContentAlignment.BottomRight;
            // 
            // calculatorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(483, 690);
            Controls.Add(textDisplay);
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
            Controls.Add(backspaceButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "calculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalculatorApp";
            KeyDown += calculatorForm_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Button backspaceButton;
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
        private Label textDisplay;
    }
}
