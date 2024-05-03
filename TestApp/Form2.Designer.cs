namespace TestApp
{
    partial class Form2
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
            listBoxHR = new ListBox();
            listBoxManager = new ListBox();
            listBoxDevelopers = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBoxHR
            // 
            listBoxHR.FormattingEnabled = true;
            listBoxHR.Location = new Point(44, 42);
            listBoxHR.Name = "listBoxHR";
            listBoxHR.Size = new Size(188, 346);
            listBoxHR.TabIndex = 0;
            // 
            // listBoxManager
            // 
            listBoxManager.FormattingEnabled = true;
            listBoxManager.Location = new Point(296, 42);
            listBoxManager.Name = "listBoxManager";
            listBoxManager.Size = new Size(190, 346);
            listBoxManager.TabIndex = 1;
            // 
            // listBoxDevelopers
            // 
            listBoxDevelopers.FormattingEnabled = true;
            listBoxDevelopers.Location = new Point(548, 42);
            listBoxDevelopers.Name = "listBoxDevelopers";
            listBoxDevelopers.Size = new Size(205, 346);
            listBoxDevelopers.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 3;
            label1.Text = "HR отдел";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 16);
            label2.Name = "label2";
            label2.Size = new Size(140, 19);
            label2.TabIndex = 4;
            label2.Text = "Отдел менеджмента";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 16);
            label3.Name = "label3";
            label3.Size = new Size(148, 19);
            label3.TabIndex = 5;
            label3.Text = "Отдел разработчиков";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxDevelopers);
            Controls.Add(listBoxManager);
            Controls.Add(listBoxHR);
            Name = "Form2";
            Text = "Сотрудники по отделам";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxHR;
        private ListBox listBoxManager;
        private ListBox listBoxDevelopers;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}