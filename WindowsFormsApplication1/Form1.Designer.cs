namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Classes = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Organizations = new System.Windows.Forms.ListBox();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.DriverNameBox = new System.Windows.Forms.TextBox();
            this.PriceofHourBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceperkmBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RouteTimeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RouteNumberBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SaveLoadBox = new System.Windows.Forms.ComboBox();
            this.Savesr = new System.Windows.Forms.Button();
            this.Loadsr = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Classes
            // 
            this.Classes.FormattingEnabled = true;
            this.Classes.Location = new System.Drawing.Point(54, 47);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(121, 24);
            this.Classes.TabIndex = 0;
            this.Classes.SelectedIndexChanged += new System.EventHandler(this.Classes_SelectedIndexChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(489, 51);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(142, 22);
            this.NameBox.TabIndex = 3;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(489, 108);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(142, 22);
            this.PhoneBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Class";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Class);
            // 
            // Organizations
            // 
            this.Organizations.FormattingEnabled = true;
            this.Organizations.ItemHeight = 16;
            this.Organizations.Location = new System.Drawing.Point(197, 46);
            this.Organizations.Name = "Organizations";
            this.Organizations.Size = new System.Drawing.Size(241, 404);
            this.Organizations.TabIndex = 8;
            this.Organizations.Click += new System.EventHandler(this.Organizations_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(54, 121);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(121, 32);
            this.Change.TabIndex = 9;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(54, 159);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(121, 32);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DriverNameBox
            // 
            this.DriverNameBox.Location = new System.Drawing.Point(489, 161);
            this.DriverNameBox.Name = "DriverNameBox";
            this.DriverNameBox.Size = new System.Drawing.Size(142, 22);
            this.DriverNameBox.TabIndex = 11;
            // 
            // PriceofHourBox
            // 
            this.PriceofHourBox.Location = new System.Drawing.Point(489, 216);
            this.PriceofHourBox.Name = "PriceofHourBox";
            this.PriceofHourBox.Size = new System.Drawing.Size(142, 22);
            this.PriceofHourBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "DriverName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price";
            // 
            // PriceperkmBox
            // 
            this.PriceperkmBox.Location = new System.Drawing.Point(489, 324);
            this.PriceperkmBox.Name = "PriceperkmBox";
            this.PriceperkmBox.Size = new System.Drawing.Size(142, 22);
            this.PriceperkmBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Priceperkm";
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(489, 270);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(142, 22);
            this.NumberBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Number";
            // 
            // RouteTimeBox
            // 
            this.RouteTimeBox.Location = new System.Drawing.Point(489, 376);
            this.RouteTimeBox.Name = "RouteTimeBox";
            this.RouteTimeBox.Size = new System.Drawing.Size(142, 22);
            this.RouteTimeBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "RouteTime";
            // 
            // RouteNumberBox
            // 
            this.RouteNumberBox.Location = new System.Drawing.Point(489, 428);
            this.RouteNumberBox.Name = "RouteNumberBox";
            this.RouteNumberBox.Size = new System.Drawing.Size(142, 22);
            this.RouteNumberBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "RouteNumber";
            // 
            // SaveLoadBox
            // 
            this.SaveLoadBox.FormattingEnabled = true;
            this.SaveLoadBox.Location = new System.Drawing.Point(54, 214);
            this.SaveLoadBox.Name = "SaveLoadBox";
            this.SaveLoadBox.Size = new System.Drawing.Size(121, 24);
            this.SaveLoadBox.TabIndex = 23;
            // 
            // Savesr
            // 
            this.Savesr.Location = new System.Drawing.Point(54, 285);
            this.Savesr.Name = "Savesr";
            this.Savesr.Size = new System.Drawing.Size(121, 32);
            this.Savesr.TabIndex = 24;
            this.Savesr.Text = "Save";
            this.Savesr.UseVisualStyleBackColor = true;
            this.Savesr.Click += new System.EventHandler(this.Savesr_Click);
            // 
            // Loadsr
            // 
            this.Loadsr.Location = new System.Drawing.Point(54, 247);
            this.Loadsr.Name = "Loadsr";
            this.Loadsr.Size = new System.Drawing.Size(121, 32);
            this.Loadsr.TabIndex = 25;
            this.Loadsr.Text = "Load";
            this.Loadsr.UseVisualStyleBackColor = true;
            this.Loadsr.Click += new System.EventHandler(this.Loadsr_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 486);
            this.Controls.Add(this.Loadsr);
            this.Controls.Add(this.Savesr);
            this.Controls.Add(this.SaveLoadBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RouteNumberBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RouteTimeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceperkmBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceofHourBox);
            this.Controls.Add(this.DriverNameBox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Organizations);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Classes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Classes;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Organizations;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox DriverNameBox;
        private System.Windows.Forms.TextBox PriceofHourBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceperkmBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RouteTimeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RouteNumberBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SaveLoadBox;
        private System.Windows.Forms.Button Savesr;
        private System.Windows.Forms.Button Loadsr;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}

