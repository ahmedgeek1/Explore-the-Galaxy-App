namespace Assessment_5B
{
    partial class SpeedAndDistanceCalculatorForm
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
            this.lblNumberOfDaysUserInputPrompt = new System.Windows.Forms.Label();
            this.lblSpedOfAircraftOutputPrompt = new System.Windows.Forms.Label();
            this.lblDistanceUserInputPrompt = new System.Windows.Forms.Label();
            this.txtBoxNumberOfDays = new System.Windows.Forms.TextBox();
            this.lblDistanceOutput = new System.Windows.Forms.Label();
            this.lblSpeedOutput = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumberOfDaysUserInputPrompt
            // 
            this.lblNumberOfDaysUserInputPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDaysUserInputPrompt.Location = new System.Drawing.Point(45, 105);
            this.lblNumberOfDaysUserInputPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfDaysUserInputPrompt.Name = "lblNumberOfDaysUserInputPrompt";
            this.lblNumberOfDaysUserInputPrompt.Size = new System.Drawing.Size(490, 80);
            this.lblNumberOfDaysUserInputPrompt.TabIndex = 0;
            this.lblNumberOfDaysUserInputPrompt.Text = "Please enter the number of days  the spacecraft has been traveling";
            this.lblNumberOfDaysUserInputPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpedOfAircraftOutputPrompt
            // 
            this.lblSpedOfAircraftOutputPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpedOfAircraftOutputPrompt.Location = new System.Drawing.Point(45, 191);
            this.lblSpedOfAircraftOutputPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpedOfAircraftOutputPrompt.Name = "lblSpedOfAircraftOutputPrompt";
            this.lblSpedOfAircraftOutputPrompt.Size = new System.Drawing.Size(490, 91);
            this.lblSpedOfAircraftOutputPrompt.TabIndex = 1;
            this.lblSpedOfAircraftOutputPrompt.Text = "The speed of the spacecraft is (in MPD) at the end of its last day";
            this.lblSpedOfAircraftOutputPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSpedOfAircraftOutputPrompt.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDistanceUserInputPrompt
            // 
            this.lblDistanceUserInputPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceUserInputPrompt.Location = new System.Drawing.Point(49, 303);
            this.lblDistanceUserInputPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistanceUserInputPrompt.Name = "lblDistanceUserInputPrompt";
            this.lblDistanceUserInputPrompt.Size = new System.Drawing.Size(486, 85);
            this.lblDistanceUserInputPrompt.TabIndex = 2;
            this.lblDistanceUserInputPrompt.Text = "The total distance traveled by the spacecraft to the end of its last traveling da" +
    "y";
            this.lblDistanceUserInputPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxNumberOfDays
            // 
            this.txtBoxNumberOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumberOfDays.Location = new System.Drawing.Point(603, 125);
            this.txtBoxNumberOfDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxNumberOfDays.Name = "txtBoxNumberOfDays";
            this.txtBoxNumberOfDays.Size = new System.Drawing.Size(263, 26);
            this.txtBoxNumberOfDays.TabIndex = 3;
            this.txtBoxNumberOfDays.TextChanged += new System.EventHandler(this.txtBoxNumberOfDays_TextChanged);
            // 
            // lblDistanceOutput
            // 
            this.lblDistanceOutput.BackColor = System.Drawing.Color.White;
            this.lblDistanceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistanceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceOutput.Location = new System.Drawing.Point(603, 327);
            this.lblDistanceOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistanceOutput.Name = "lblDistanceOutput";
            this.lblDistanceOutput.Size = new System.Drawing.Size(264, 48);
            this.lblDistanceOutput.TabIndex = 4;
            this.lblDistanceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDistanceOutput.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblSpeedOutput
            // 
            this.lblSpeedOutput.BackColor = System.Drawing.Color.White;
            this.lblSpeedOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpeedOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedOutput.Location = new System.Drawing.Point(603, 219);
            this.lblSpeedOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeedOutput.Name = "lblSpeedOutput";
            this.lblSpeedOutput.Size = new System.Drawing.Size(264, 48);
            this.lblSpeedOutput.TabIndex = 5;
            this.lblSpeedOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Firebrick;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(236, 456);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(170, 42);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Firebrick;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(473, 456);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 42);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(697, 456);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 42);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(150, 29);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(509, 24);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome to the spacecraft Speed/Distance Calculator";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.Blue;
            this.lblCopyright.Location = new System.Drawing.Point(828, 521);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(111, 15);
            this.lblCopyright.TabIndex = 12;
            this.lblCopyright.Text = "© Ahmed Matoussi";
            // 
            // SpeedAndDistanceCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(951, 545);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSpeedOutput);
            this.Controls.Add(this.lblDistanceOutput);
            this.Controls.Add(this.txtBoxNumberOfDays);
            this.Controls.Add(this.lblDistanceUserInputPrompt);
            this.Controls.Add(this.lblSpedOfAircraftOutputPrompt);
            this.Controls.Add(this.lblNumberOfDaysUserInputPrompt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SpeedAndDistanceCalculatorForm";
            this.Text = "Speed And Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfDaysUserInputPrompt;
        private System.Windows.Forms.Label lblSpedOfAircraftOutputPrompt;
        private System.Windows.Forms.Label lblDistanceUserInputPrompt;
        private System.Windows.Forms.TextBox txtBoxNumberOfDays;
        private System.Windows.Forms.Label lblDistanceOutput;
        private System.Windows.Forms.Label lblSpeedOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCopyright;
    }
}

