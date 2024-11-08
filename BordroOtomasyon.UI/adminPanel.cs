using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BordroOtomasyon.UI
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            grpxTediye = new GroupBox();
            grpxKidem = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            dtpIsBaslangic = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            grpxIkramiye = new GroupBox();
            btnCikis = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dtpTediyeIlk = new DateTimePicker();
            dtpTediyeIki = new DateTimePicker();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            btnHesapla = new Button();
            txtTediye1Sonuc = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txtTediye2Sonuc = new TextBox();
            grpxTediye.SuspendLayout();
            grpxKidem.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 0;
            label1.Text = "Hoşgeldin Admin";
            // 
            // grpxTediye
            // 
            grpxTediye.BackColor = SystemColors.Control;
            grpxTediye.Controls.Add(btnHesapla);
            grpxTediye.Controls.Add(textBox3);
            grpxTediye.Controls.Add(txtTediye2Sonuc);
            grpxTediye.Controls.Add(txtTediye1Sonuc);
            grpxTediye.Controls.Add(textBox2);
            grpxTediye.Controls.Add(label8);
            grpxTediye.Controls.Add(label12);
            grpxTediye.Controls.Add(label11);
            grpxTediye.Controls.Add(label10);
            grpxTediye.Controls.Add(label9);
            grpxTediye.Controls.Add(label7);
            grpxTediye.Controls.Add(label6);
            grpxTediye.Controls.Add(dtpTediyeIki);
            grpxTediye.Controls.Add(dtpTediyeIlk);
            grpxTediye.Location = new Point(390, 72);
            grpxTediye.Name = "grpxTediye";
            grpxTediye.Size = new Size(406, 641);
            grpxTediye.TabIndex = 1;
            grpxTediye.TabStop = false;
            grpxTediye.Text = "Tediye Hesaplaması";
            // 
            // grpxKidem
            // 
            grpxKidem.BackColor = SystemColors.Control;
            grpxKidem.Controls.Add(label5);
            grpxKidem.Controls.Add(label4);
            grpxKidem.Controls.Add(dateTimePicker1);
            grpxKidem.Controls.Add(dtpIsBaslangic);
            grpxKidem.Controls.Add(label3);
            grpxKidem.Controls.Add(label2);
            grpxKidem.Controls.Add(textBox1);
            grpxKidem.Controls.Add(comboBox2);
            grpxKidem.Controls.Add(comboBox1);
            grpxKidem.Location = new Point(12, 72);
            grpxKidem.Name = "grpxKidem";
            grpxKidem.Size = new Size(353, 390);
            grpxKidem.TabIndex = 1;
            grpxKidem.TabStop = false;
            grpxKidem.Text = "Çalışan Bilgileri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 229);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 1;
            label5.Text = "İş Başlangıcı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 170);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 2;
            label4.Text = "Brut Maaş:";
            // 
            // dtpIsBaslangic
            // 
            dtpIsBaslangic.Location = new Point(111, 224);
            dtpIsBaslangic.Name = "dtpIsBaslangic";
            dtpIsBaslangic.Size = new Size(223, 29);
            dtpIsBaslangic.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 114);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 2;
            label3.Text = "Derece:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 52);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 2;
            label2.Text = "Kıdem:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 29);
            textBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboBox2.Location = new Point(111, 111);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(223, 29);
            comboBox2.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "\t\t\t" });
            comboBox1.Location = new Point(111, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 29);
            comboBox1.TabIndex = 0;
            // 
            // grpxIkramiye
            // 
            grpxIkramiye.BackColor = SystemColors.Control;
            grpxIkramiye.Location = new Point(825, 72);
            grpxIkramiye.Name = "grpxIkramiye";
            grpxIkramiye.Size = new Size(406, 641);
            grpxIkramiye.TabIndex = 1;
            grpxIkramiye.TabStop = false;
            grpxIkramiye.Text = "İkramiye Hesaplaması";
            // 
            // btnCikis
            // 
            btnCikis.BackColor = SystemColors.ActiveCaption;
            btnCikis.ForeColor = SystemColors.InactiveBorder;
            btnCikis.Location = new Point(193, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(101, 34);
            btnCikis.TabIndex = 2;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 54);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 1;
            label6.Text = "1.Tediye:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 108);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 1;
            label7.Text = "2.Tediye:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 256);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(516, 100);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(223, 29);
            dateTimePicker1.TabIndex = 0;
            // 
            // dtpTediyeIlk
            // 
            dtpTediyeIlk.Location = new Point(128, 49);
            dtpTediyeIlk.Name = "dtpTediyeIlk";
            dtpTediyeIlk.Size = new Size(223, 29);
            dtpTediyeIlk.TabIndex = 0;
            // 
            // dtpTediyeIki
            // 
            dtpTediyeIki.Location = new Point(128, 102);
            dtpTediyeIki.Name = "dtpTediyeIki";
            dtpTediyeIki.Size = new Size(223, 29);
            dtpTediyeIki.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 256);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(102, 29);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(125, 361);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(102, 29);
            textBox3.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 369);
            label9.Name = "label9";
            label9.Size = new Size(77, 21);
            label9.TabIndex = 1;
            label9.Text = "2.Tediye:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 312);
            label10.Name = "label10";
            label10.Size = new Size(74, 21);
            label10.TabIndex = 1;
            label10.Text = "1.Sonuç:";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(128, 158);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(102, 33);
            btnHesapla.TabIndex = 4;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            // 
            // txtTediye1Sonuc
            // 
            txtTediye1Sonuc.Location = new Point(125, 309);
            txtTediye1Sonuc.Name = "txtTediye1Sonuc";
            txtTediye1Sonuc.Size = new Size(154, 29);
            txtTediye1Sonuc.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(45, 259);
            label11.Name = "label11";
            label11.Size = new Size(77, 21);
            label11.TabIndex = 1;
            label11.Text = "1.Tediye:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(45, 418);
            label12.Name = "label12";
            label12.Size = new Size(74, 21);
            label12.TabIndex = 1;
            label12.Text = "2.Sonuç:";
            // 
            // txtTediye2Sonuc
            // 
            txtTediye2Sonuc.Location = new Point(125, 415);
            txtTediye2Sonuc.Name = "txtTediye2Sonuc";
            txtTediye2Sonuc.Size = new Size(154, 29);
            txtTediye2Sonuc.TabIndex = 3;
            // 
            // adminPanel
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1297, 790);
            Controls.Add(btnCikis);
            Controls.Add(grpxKidem);
            Controls.Add(grpxIkramiye);
            Controls.Add(grpxTediye);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Name = "adminPanel";
            Load += adminPanel_Load;
            grpxTediye.ResumeLayout(false);
            grpxTediye.PerformLayout();
            grpxKidem.ResumeLayout(false);
            grpxKidem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private GroupBox grpxKidem;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox grpxIkramiye;
        private Label label5;
        private DateTimePicker dtpIsBaslangic;
        private Button btnCikis;
        private Label label8;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpTediyeIki;
        private DateTimePicker dtpTediyeIlk;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Button btnHesapla;
        private TextBox textBox3;
        private TextBox txtTediye1Sonuc;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtTediye2Sonuc;
        private Label label12;
        private GroupBox grpxTediye;

        private void adminPanel_Load(object sender, EventArgs e)
        {

        }

       
    }
}
