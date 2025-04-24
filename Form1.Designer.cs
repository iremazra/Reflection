namespace ReflectionHomework
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
            textBox1 = new TextBox();
            label2 = new Label();
            buttonOdemeYap = new Button();
            labelSonuc = new Label();
            comboBoxOdemeYontemleri = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 49);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Tutar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 117);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 3;
            label2.Text = "Ödeme Yöntemleri:";
            // 
            // buttonOdemeYap
            // 
            buttonOdemeYap.Location = new Point(22, 225);
            buttonOdemeYap.Name = "buttonOdemeYap";
            buttonOdemeYap.Size = new Size(151, 52);
            buttonOdemeYap.TabIndex = 4;
            buttonOdemeYap.Text = "ÖDEME YAP";
            buttonOdemeYap.UseVisualStyleBackColor = true;
            buttonOdemeYap.Click += buttonOdemeYap_Click;
            // 
            // labelSonuc
            // 
            labelSonuc.AutoSize = true;
            labelSonuc.Location = new Point(22, 331);
            labelSonuc.Name = "labelSonuc";
            labelSonuc.Size = new Size(0, 20);
            labelSonuc.TabIndex = 5;
            // 
            // comboBoxOdemeYontemleri
            // 
            comboBoxOdemeYontemleri.FormattingEnabled = true;
            comboBoxOdemeYontemleri.Location = new Point(192, 109);
            comboBoxOdemeYontemleri.Name = "comboBoxOdemeYontemleri";
            comboBoxOdemeYontemleri.Size = new Size(173, 28);
            comboBoxOdemeYontemleri.TabIndex = 6;
            comboBoxOdemeYontemleri.SelectedIndexChanged += comboBoxOdemeYontemleri_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 46);
            label3.Name = "label3";
            label3.Size = new Size(339, 20);
            label3.TabIndex = 7;
            label3.Text = "Dosya yapısı ödevi de bu solution'ın içerisindedir. ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 79);
            label4.Name = "label4";
            label4.Size = new Size(473, 20);
            label4.TabIndex = 8;
            label4.Text = "Startup projesini \"Dosya yapısı\" projesini seçerek ödeve ulaşabilirsiniz!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 462);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxOdemeYontemleri);
            Controls.Add(labelSonuc);
            Controls.Add(buttonOdemeYap);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button buttonOdemeYap;
        private Label labelSonuc;
        private ComboBox comboBoxOdemeYontemleri;
        private Label label3;
        private Label label4;
    }
}
