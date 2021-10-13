
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(136, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DarkBlue;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Clear.ForeColor = System.Drawing.SystemColors.Control;
            this.Clear.Location = new System.Drawing.Point(26, 123);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(108, 34);
            this.Clear.TabIndex = 26;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.history.Location = new System.Drawing.Point(59, 22);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(400, 18);
            this.history.TabIndex = 29;
            this.history.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(29, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 41);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumBlue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(220, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 59);
            this.label6.TabIndex = 26;
            this.label6.Text = "6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.Tiklanan_Harf);
            this.label6.MouseEnter += new System.EventHandler(this.labels_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.labels_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(4, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 59);
            this.label1.TabIndex = 21;
            this.label1.Text = "7";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Tiklanan_Harf);
            this.label1.MouseEnter += new System.EventHandler(this.labels_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.labels_MouseLeave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(112, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 59);
            this.label2.TabIndex = 22;
            this.label2.Text = "8";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Tiklanan_Harf);
            this.label2.MouseEnter += new System.EventHandler(this.labels_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.labels_MouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MediumBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(220, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 59);
            this.label3.TabIndex = 23;
            this.label3.Text = "9";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.Tiklanan_Harf);
            this.label3.MouseEnter += new System.EventHandler(this.labels_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.labels_MouseLeave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MediumBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(4, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 59);
            this.label4.TabIndex = 24;
            this.label4.Text = "4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Tiklanan_Harf);
            this.label4.MouseEnter += new System.EventHandler(this.labels_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.labels_MouseLeave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MediumBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(112, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 59);
            this.label5.TabIndex = 25;
            this.label5.Text = "5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.Tiklanan_Harf);
            this.label5.MouseEnter += new System.EventHandler(this.labels_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.labels_MouseLeave);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MediumBlue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(4, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 59);
            this.label7.TabIndex = 27;
            this.label7.Text = "1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.Tiklanan_Harf);
            this.label7.MouseEnter += new System.EventHandler(this.labels_MouseEnter);
            this.label7.MouseLeave += new System.EventHandler(this.labels_MouseLeave);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.MediumBlue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(112, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 59);
            this.label8.TabIndex = 28;
            this.label8.Text = "2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.Tiklanan_Harf);
            this.label8.MouseEnter += new System.EventHandler(this.labels_MouseEnter);
            this.label8.MouseLeave += new System.EventHandler(this.labels_MouseLeave);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.MediumBlue;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(220, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 59);
            this.label9.TabIndex = 29;
            this.label9.Text = "3";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.Tiklanan_Harf);
            this.label9.MouseEnter += new System.EventHandler(this.labels_MouseEnter);
            this.label9.MouseLeave += new System.EventHandler(this.labels_MouseLeave);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.MediumBlue;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(112, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 59);
            this.label11.TabIndex = 31;
            this.label11.Text = "0";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.Tiklanan_Harf);
            this.label11.MouseEnter += new System.EventHandler(this.labels_MouseEnter);
            this.label11.MouseLeave += new System.EventHandler(this.labels_MouseLeave);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DarkBlue;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(4, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 59);
            this.label12.TabIndex = 32;
            this.label12.Text = "1/x";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.onedivxbtn_Click);
            this.label12.MouseEnter += new System.EventHandler(this.Islem_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.Islem_MouseLeave);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.DarkBlue;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(112, 1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 59);
            this.label16.TabIndex = 33;
            this.label16.Text = "x²";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.pow2_Click);
            this.label16.MouseEnter += new System.EventHandler(this.Islem_MouseEnter);
            this.label16.MouseLeave += new System.EventHandler(this.Islem_MouseLeave);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.DarkBlue;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(220, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 59);
            this.label17.TabIndex = 34;
            this.label17.Text = "√x";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.Sqrt_Click);
            this.label17.MouseEnter += new System.EventHandler(this.Islem_MouseEnter);
            this.label17.MouseLeave += new System.EventHandler(this.Islem_MouseLeave);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DarkBlue;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(328, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 59);
            this.label14.TabIndex = 35;
            this.label14.Text = "<=";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.backSpace_Click);
            this.label14.MouseEnter += new System.EventHandler(this.Islem_MouseEnter);
            this.label14.MouseLeave += new System.EventHandler(this.Islem_MouseLeave);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.DarkBlue;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(328, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 59);
            this.label18.TabIndex = 36;
            this.label18.Text = "÷";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.dort_islem);
            this.label18.MouseEnter += new System.EventHandler(this.Islem_MouseEnter);
            this.label18.MouseLeave += new System.EventHandler(this.Islem_MouseLeave);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.DarkBlue;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(328, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 59);
            this.label19.TabIndex = 37;
            this.label19.Text = "x";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.Click += new System.EventHandler(this.dort_islem);
            this.label19.MouseEnter += new System.EventHandler(this.Islem_MouseEnter);
            this.label19.MouseLeave += new System.EventHandler(this.Islem_MouseLeave);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.DarkBlue;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(328, 181);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 59);
            this.label20.TabIndex = 38;
            this.label20.Text = "+";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.dort_islem);
            this.label20.MouseEnter += new System.EventHandler(this.Islem_MouseEnter);
            this.label20.MouseLeave += new System.EventHandler(this.Islem_MouseLeave);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.DodgerBlue;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(220, 241);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 59);
            this.label21.TabIndex = 39;
            this.label21.Text = "=";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.Click += new System.EventHandler(this.equal_Click);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.DarkBlue;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.SystemColors.Control;
            this.label22.Location = new System.Drawing.Point(328, 241);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 59);
            this.label22.TabIndex = 40;
            this.label22.Text = "-";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Click += new System.EventHandler(this.dort_islem);
            this.label22.MouseEnter += new System.EventHandler(this.Islem_MouseEnter);
            this.label22.MouseLeave += new System.EventHandler(this.Islem_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkBlue;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label23, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label22, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label20, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label18, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 5);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 157);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 363);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.DarkBlue;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.ForeColor = System.Drawing.SystemColors.Control;
            this.label24.Location = new System.Drawing.Point(4, 301);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 61);
            this.label24.TabIndex = 49;
            this.label24.Text = "sin(x°)";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label24.Click += new System.EventHandler(this.Trigonometri_btns);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.DarkBlue;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.SystemColors.Control;
            this.label23.Location = new System.Drawing.Point(328, 301);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 61);
            this.label23.TabIndex = 48;
            this.label23.Text = "cot(x°)";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label23.Click += new System.EventHandler(this.Trigonometri_btns);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.DarkBlue;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(220, 301);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 61);
            this.label15.TabIndex = 47;
            this.label15.Text = "tan(x°)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.Trigonometri_btns);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.DarkBlue;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(112, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 61);
            this.label13.TabIndex = 46;
            this.label13.Text = "cos(x°)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.Trigonometri_btns);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.MediumBlue;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(4, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 59);
            this.label10.TabIndex = 30;
            this.label10.Text = ",";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.Tiklanan_Harf);
            this.label10.MouseEnter += new System.EventHandler(this.labels_MouseEnter);
            this.label10.MouseLeave += new System.EventHandler(this.labels_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(484, 542);
            this.Controls.Add(this.history);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Trigonometri_btns);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label history;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
    }
}

