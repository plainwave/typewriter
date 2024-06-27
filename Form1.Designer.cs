namespace typewriter
{
    partial class typewriter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(typewriter));
            textBox1 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(2, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(796, 361);
            textBox1.TabIndex = 0;
            textBox1.WordWrap = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            button1.Location = new Point(2, 364);
            button1.Name = "button1";
            button1.Size = new Size(630, 59);
            button1.TabIndex = 1;
            button1.Text = "Type for me!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(60, 430);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Slow mode";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox2.Location = new Point(291, 430);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(180, 29);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "End with \"ENTER\"";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox3.Location = new Point(572, 430);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(152, 29);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Always on top";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            button2.Location = new Point(629, 364);
            button2.Name = "button2";
            button2.Size = new Size(169, 59);
            button2.TabIndex = 5;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // typewriter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(button2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "typewriter";
            Opacity = 0.94D;
            Text = "typewriter | *Characters input depends on current keyboard layout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button2;
    }
}
