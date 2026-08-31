namespace CSVConverter
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
            Convert = new Button();
            File_Label = new Label();
            File_Select = new Button();
            panel1 = new Panel();
            Output_Label = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Convert
            // 
            Convert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Convert.Location = new Point(838, 253);
            Convert.Margin = new Padding(6);
            Convert.Name = "Convert";
            Convert.Size = new Size(224, 65);
            Convert.TabIndex = 0;
            Convert.Text = "Convert";
            Convert.UseVisualStyleBackColor = true;
            Convert.Click += button1_Click;
            // 
            // File_Label
            // 
            File_Label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            File_Label.AutoSize = true;
            File_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Label.Location = new Point(48, 56);
            File_Label.Margin = new Padding(6, 0, 6, 0);
            File_Label.MaximumSize = new Size(1400, 0);
            File_Label.MinimumSize = new Size(750, 0);
            File_Label.Name = "File_Label";
            File_Label.RightToLeft = RightToLeft.Yes;
            File_Label.Size = new Size(750, 32);
            File_Label.TabIndex = 1;
            File_Label.Text = "Select a File";
            File_Label.Click += File_Label_Click;
            // 
            // File_Select
            // 
            File_Select.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            File_Select.Location = new Point(838, 35);
            File_Select.Margin = new Padding(6);
            File_Select.Name = "File_Select";
            File_Select.Size = new Size(224, 65);
            File_Select.TabIndex = 2;
            File_Select.Text = "Browse";
            File_Select.UseVisualStyleBackColor = true;
            File_Select.Click += File_Select_Click;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(Output_Label);
            panel1.Controls.Add(File_Select);
            panel1.Controls.Add(File_Label);
            panel1.Controls.Add(Convert);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 349);
            panel1.TabIndex = 3;
            // 
            // Output_Label
            // 
            Output_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Output_Label.AutoSize = true;
            Output_Label.Location = new Point(48, 261);
            Output_Label.MaximumSize = new Size(750, 0);
            Output_Label.MinimumSize = new Size(750, 0);
            Output_Label.Name = "Output_Label";
            Output_Label.Size = new Size(750, 48);
            Output_Label.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1092, 349);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlDarkDark;
            Margin = new Padding(6);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "CSV Converter By Richard H";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Convert;
        private Label File_Label;
        private Button File_Select;
        private Panel panel1;
        private Label Output_Label;
    }
}
