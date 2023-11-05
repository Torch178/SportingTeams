namespace SportingTeams
{
    partial class SportingTeamsForm
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
            btnDisplay = new Button();
            btnShowPos = new Button();
            rbBasketball = new RadioButton();
            rbFootball = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(270, 258);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(196, 23);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display Team Information";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnShowPos
            // 
            btnShowPos.Location = new Point(270, 333);
            btnShowPos.Name = "btnShowPos";
            btnShowPos.Size = new Size(196, 23);
            btnShowPos.TabIndex = 1;
            btnShowPos.Text = "Show Available Positions";
            btnShowPos.UseVisualStyleBackColor = true;
            btnShowPos.Click += btnShowPos_Click;
            // 
            // rbBasketball
            // 
            rbBasketball.AutoSize = true;
            rbBasketball.Location = new Point(53, 45);
            rbBasketball.Name = "rbBasketball";
            rbBasketball.Size = new Size(78, 19);
            rbBasketball.TabIndex = 2;
            rbBasketball.TabStop = true;
            rbBasketball.Text = "Basketball";
            rbBasketball.UseVisualStyleBackColor = true;
            // 
            // rbFootball
            // 
            rbFootball.AutoSize = true;
            rbFootball.Location = new Point(53, 88);
            rbFootball.Name = "rbFootball";
            rbFootball.Size = new Size(68, 19);
            rbFootball.TabIndex = 3;
            rbFootball.TabStop = true;
            rbFootball.Text = "Football";
            rbFootball.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Wheat;
            groupBox1.Controls.Add(rbFootball);
            groupBox1.Controls.Add(rbBasketball);
            groupBox1.Location = new Point(252, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 141);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select a Team";
            // 
            // SportingTeamsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowPos);
            Controls.Add(btnDisplay);
            Controls.Add(groupBox1);
            Name = "SportingTeamsForm";
            Text = "Weber Sports Teams";
            Load += SportingTeamsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplay;
        private Button btnShowPos;
        private RadioButton rbBasketball;
        private RadioButton rbFootball;
        private GroupBox groupBox1;
    }
}