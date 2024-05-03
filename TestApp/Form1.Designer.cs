namespace TestApp
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
            list = new ListBox();
            addButton = new Button();
            nameAdd = new TextBox();
            ageAdd = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            position = new ComboBox();
            РасчетЗП = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            calcButton = new Button();
            hoursCald = new TextBox();
            nameCalc = new TextBox();
            groupBox2 = new GroupBox();
            nameDel = new Label();
            nameDelete = new TextBox();
            deleteButton = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            РасчетЗП.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // list
            // 
            list.FormattingEnabled = true;
            list.Location = new Point(466, 43);
            list.Name = "list";
            list.Size = new Size(279, 460);
            list.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(190, 138);
            addButton.Name = "addButton";
            addButton.Size = new Size(115, 26);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // nameAdd
            // 
            nameAdd.Location = new Point(23, 71);
            nameAdd.Name = "nameAdd";
            nameAdd.Size = new Size(115, 26);
            nameAdd.TabIndex = 2;
            // 
            // ageAdd
            // 
            ageAdd.Location = new Point(190, 71);
            ageAdd.MaxLength = 2;
            ageAdd.Name = "ageAdd";
            ageAdd.Size = new Size(115, 26);
            ageAdd.TabIndex = 3;
            ageAdd.KeyPress += ageNum;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(position);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(ageAdd);
            groupBox1.Controls.Add(nameAdd);
            groupBox1.Location = new Point(40, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 192);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 111);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 7;
            label3.Text = "Должность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 40);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 6;
            label2.Text = "Возраст";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(36, 19);
            label1.TabIndex = 5;
            label1.Text = "Имя";
            // 
            // position
            // 
            position.FormattingEnabled = true;
            position.Location = new Point(23, 137);
            position.Name = "position";
            position.Size = new Size(115, 27);
            position.TabIndex = 4;
            // 
            // РасчетЗП
            // 
            РасчетЗП.Controls.Add(label5);
            РасчетЗП.Controls.Add(label4);
            РасчетЗП.Controls.Add(calcButton);
            РасчетЗП.Controls.Add(hoursCald);
            РасчетЗП.Controls.Add(nameCalc);
            РасчетЗП.Location = new Point(40, 255);
            РасчетЗП.Name = "РасчетЗП";
            РасчетЗП.Size = new Size(349, 115);
            РасчетЗП.TabIndex = 5;
            РасчетЗП.TabStop = false;
            РасчетЗП.Text = "РасчетЗП";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 22);
            label5.Name = "label5";
            label5.Size = new Size(41, 19);
            label5.TabIndex = 7;
            label5.Text = "Часы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 19);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 6;
            label4.Text = "Имя";
            // 
            // calcButton
            // 
            calcButton.Location = new Point(190, 73);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(115, 26);
            calcButton.TabIndex = 2;
            calcButton.Text = "Рассчитать";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // hoursCald
            // 
            hoursCald.Location = new Point(190, 41);
            hoursCald.MaxLength = 3;
            hoursCald.Name = "hoursCald";
            hoursCald.Size = new Size(115, 26);
            hoursCald.TabIndex = 1;
            hoursCald.KeyPress += hoursNum;
            // 
            // nameCalc
            // 
            nameCalc.Location = new Point(21, 41);
            nameCalc.Name = "nameCalc";
            nameCalc.Size = new Size(115, 26);
            nameCalc.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nameDel);
            groupBox2.Controls.Add(nameDelete);
            groupBox2.Controls.Add(deleteButton);
            groupBox2.Location = new Point(41, 388);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(349, 115);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Удаление";
            // 
            // nameDel
            // 
            nameDel.AutoSize = true;
            nameDel.Location = new Point(23, 32);
            nameDel.Name = "nameDel";
            nameDel.Size = new Size(36, 19);
            nameDel.TabIndex = 7;
            nameDel.Text = "Имя";
            // 
            // nameDelete
            // 
            nameDelete.Location = new Point(23, 54);
            nameDelete.Name = "nameDelete";
            nameDelete.Size = new Size(115, 26);
            nameDelete.TabIndex = 1;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(189, 54);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(115, 26);
            deleteButton.TabIndex = 0;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(466, 524);
            button4.Name = "button4";
            button4.Size = new Size(279, 26);
            button4.TabIndex = 7;
            button4.Text = "Показать по департаментам";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(РасчетЗП);
            Controls.Add(groupBox1);
            Controls.Add(list);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            РасчетЗП.ResumeLayout(false);
            РасчетЗП.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox list;
        private Button addButton;
        private TextBox nameAdd;
        private TextBox ageAdd;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox position;
        private GroupBox РасчетЗП;
        private Label label5;
        private Label label4;
        private Button calcButton;
        private TextBox hoursCald;
        private TextBox nameCalc;
        private GroupBox groupBox2;
        private Label nameDel;
        private TextBox nameDelete;
        private Button deleteButton;
        private Button button4;
    }
}
