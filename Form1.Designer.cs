namespace VTI_Utility_HeicConvert
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
            label4 = new Label();
            saveBtn = new Button();
            FormatSelect = new ComboBox();
            HeicFilePath = new TextBox();
            openBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 41);
            label1.TabIndex = 0;
            label1.Text = "Heic Converter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Heic file:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 3;
            label4.Text = "Format:";
            // 
            // saveBtn
            // 
            saveBtn.Enabled = false;
            saveBtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.Location = new Point(12, 188);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(776, 72);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // FormatSelect
            // 
            FormatSelect.FormattingEnabled = true;
            FormatSelect.Items.AddRange(new object[] { ".jpg", ".bmp", ".png" });
            FormatSelect.Location = new Point(96, 127);
            FormatSelect.Name = "FormatSelect";
            FormatSelect.Size = new Size(190, 33);
            FormatSelect.TabIndex = 5;
            FormatSelect.SelectedIndexChanged += FormatSelect_SelectedIndexChanged;
            // 
            // HeicFilePath
            // 
            HeicFilePath.Enabled = false;
            HeicFilePath.Location = new Point(96, 71);
            HeicFilePath.Name = "HeicFilePath";
            HeicFilePath.Size = new Size(566, 31);
            HeicFilePath.TabIndex = 6;
            // 
            // openBtn
            // 
            openBtn.Location = new Point(668, 71);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(120, 31);
            openBtn.TabIndex = 7;
            openBtn.Text = "Browse";
            openBtn.UseVisualStyleBackColor = true;
            openBtn.Click += openBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 272);
            Controls.Add(openBtn);
            Controls.Add(HeicFilePath);
            Controls.Add(FormatSelect);
            Controls.Add(saveBtn);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "VTI Utilities";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Button saveBtn;
        private ComboBox FormatSelect;
        private TextBox HeicFilePath;
        private Button openBtn;
    }
}