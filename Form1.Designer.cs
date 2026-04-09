namespace BurgerKiosk
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
            lblTitle = new Label();
            rdoBulburger = new RadioButton();
            pBBul = new PictureBox();
            pBshrimp = new PictureBox();
            rdShrimp = new RadioButton();
            pBchicken = new PictureBox();
            rdChicken = new RadioButton();
            btOrder = new Button();
            btReset = new Button();
            listOrder = new ListBox();
            lblTotal = new Label();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkCorn = new CheckBox();
            GpMenu = new GroupBox();
            GpPlus = new GroupBox();
            Gplist = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pBBul).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBshrimp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBchicken).BeginInit();
            GpMenu.SuspendLayout();
            GpPlus.SuspendLayout();
            Gplist.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("한컴 말랑말랑 Bold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(24, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(336, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거 주문 키오스크🍔";
            lblTitle.Click += lblTitle_Click;
            // 
            // rdoBulburger
            // 
            rdoBulburger.AutoSize = true;
            rdoBulburger.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdoBulburger.Location = new Point(16, 61);
            rdoBulburger.Name = "rdoBulburger";
            rdoBulburger.Size = new Size(150, 35);
            rdoBulburger.TabIndex = 0;
            rdoBulburger.TabStop = true;
            rdoBulburger.Text = "불고기버거";
            rdoBulburger.UseVisualStyleBackColor = true;
            rdoBulburger.CheckedChanged += rdoBulburger_CheckedChanged;
            rdoBulburger.KeyDown += Control_KeyDown;
            rdoBulburger.PreviewKeyDown += Control_PreviewKeyDown;
            // 
            // pBBul
            // 
            pBBul.Image = Properties.Resources.불고기버거;
            pBBul.Location = new Point(172, 46);
            pBBul.Name = "pBBul";
            pBBul.Size = new Size(92, 68);
            pBBul.SizeMode = PictureBoxSizeMode.StretchImage;
            pBBul.TabIndex = 3;
            pBBul.TabStop = false;
            // 
            // pBshrimp
            // 
            pBshrimp.Image = Properties.Resources.새우버거;
            pBshrimp.Location = new Point(172, 136);
            pBshrimp.Name = "pBshrimp";
            pBshrimp.Size = new Size(92, 66);
            pBshrimp.SizeMode = PictureBoxSizeMode.StretchImage;
            pBshrimp.TabIndex = 5;
            pBshrimp.TabStop = false;
            // 
            // rdShrimp
            // 
            rdShrimp.AutoSize = true;
            rdShrimp.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdShrimp.Location = new Point(16, 148);
            rdShrimp.Name = "rdShrimp";
            rdShrimp.Size = new Size(127, 35);
            rdShrimp.TabIndex = 1;
            rdShrimp.TabStop = true;
            rdShrimp.Text = "새우버거";
            rdShrimp.UseVisualStyleBackColor = true;
            rdShrimp.CheckedChanged += rdShrimp_CheckedChanged;
            rdShrimp.KeyDown += Control_KeyDown;
            rdShrimp.PreviewKeyDown += Control_PreviewKeyDown;
            // 
            // pBchicken
            // 
            pBchicken.Image = Properties.Resources.싸이버거;
            pBchicken.Location = new Point(172, 224);
            pBchicken.Name = "pBchicken";
            pBchicken.Size = new Size(92, 62);
            pBchicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pBchicken.TabIndex = 7;
            pBchicken.TabStop = false;
            // 
            // rdChicken
            // 
            rdChicken.AutoSize = true;
            rdChicken.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            rdChicken.Location = new Point(16, 231);
            rdChicken.Name = "rdChicken";
            rdChicken.Size = new Size(127, 35);
            rdChicken.TabIndex = 2;
            rdChicken.TabStop = true;
            rdChicken.Text = "치킨버거";
            rdChicken.UseVisualStyleBackColor = true;
            rdChicken.CheckedChanged += rdChicken_CheckedChanged;
            rdChicken.KeyDown += Control_KeyDown;
            rdChicken.PreviewKeyDown += Control_PreviewKeyDown;
            // 
            // btOrder
            // 
            btOrder.BackColor = Color.LightGreen;
            btOrder.Location = new Point(590, 360);
            btOrder.Name = "btOrder";
            btOrder.Size = new Size(122, 57);
            btOrder.TabIndex = 3;
            btOrder.Text = "주문하기";
            btOrder.UseVisualStyleBackColor = false;
            btOrder.Click += btOrder_Click;
            // 
            // btReset
            // 
            btReset.BackColor = Color.IndianRed;
            btReset.ForeColor = SystemColors.ButtonHighlight;
            btReset.Location = new Point(718, 360);
            btReset.Name = "btReset";
            btReset.Size = new Size(120, 57);
            btReset.TabIndex = 4;
            btReset.Text = "초기화";
            btReset.UseVisualStyleBackColor = false;
            btReset.Click += button2_Click;
            // 
            // listOrder
            // 
            listOrder.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            listOrder.FormattingEnabled = true;
            listOrder.Location = new Point(20, 47);
            listOrder.Name = "listOrder";
            listOrder.Size = new Size(232, 116);
            listOrder.TabIndex = 9;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.DodgerBlue;
            lblTotal.Location = new Point(20, 176);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(132, 30);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "총 금액 : 0원";
            lblTotal.Click += label2_Click;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkPotato.Location = new Point(21, 42);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(128, 35);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            chkPotato.CheckedChanged += chkPotato_CheckedChanged;
            chkPotato.KeyDown += Control_KeyDown;
            chkPotato.PreviewKeyDown += Control_PreviewKeyDown;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCola.Location = new Point(21, 93);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(82, 35);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += checkBox2_CheckedChanged;
            chkCola.KeyDown += Control_KeyDown;
            chkCola.PreviewKeyDown += Control_PreviewKeyDown;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCheese.Location = new Point(21, 138);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(128, 35);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈스틱";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += chkCheese_CheckedChanged;
            chkCheese.KeyDown += Control_KeyDown;
            chkCheese.PreviewKeyDown += Control_PreviewKeyDown;
            // 
            // chkCorn
            // 
            chkCorn.AutoSize = true;
            chkCorn.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCorn.Location = new Point(21, 185);
            chkCorn.Name = "chkCorn";
            chkCorn.Size = new Size(128, 35);
            chkCorn.TabIndex = 3;
            chkCorn.Text = "코울슬로";
            chkCorn.UseVisualStyleBackColor = true;
            chkCorn.CheckedChanged += chkCorn_CheckedChanged;
            chkCorn.KeyDown += Control_KeyDown;
            chkCorn.PreviewKeyDown += Control_PreviewKeyDown;
            // 
            // GpMenu
            // 
            GpMenu.Controls.Add(pBchicken);
            GpMenu.Controls.Add(rdChicken);
            GpMenu.Controls.Add(pBshrimp);
            GpMenu.Controls.Add(rdShrimp);
            GpMenu.Controls.Add(pBBul);
            GpMenu.Controls.Add(rdoBulburger);
            GpMenu.Font = new Font("한컴 말랑말랑 Regular", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 129);
            GpMenu.Location = new Point(24, 112);
            GpMenu.Name = "GpMenu";
            GpMenu.Size = new Size(277, 305);
            GpMenu.TabIndex = 0;
            GpMenu.Text = "메뉴 선택";
            GpMenu.Enter += groupBox1_Enter;
            // 
            // GpPlus
            // 
            GpPlus.Controls.Add(chkCorn);
            GpPlus.Controls.Add(chkCheese);
            GpPlus.Controls.Add(chkCola);
            GpPlus.Controls.Add(chkPotato);
            GpPlus.Font = new Font("한컴 말랑말랑 Regular", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 129);
            GpPlus.Location = new Point(342, 112);
            GpPlus.Name = "GpPlus";
            GpPlus.Size = new Size(186, 258);
            GpPlus.TabIndex = 1;
            GpPlus.Text = "추가 옵션";
            GpPlus.Enter += groupBox1_Enter;
            // 
            // Gplist
            // 
            Gplist.Controls.Add(lblTotal);
            Gplist.Controls.Add(listOrder);
            Gplist.Font = new Font("한컴 말랑말랑 Regular", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Gplist.Location = new Point(573, 112);
            Gplist.Name = "Gplist";
            Gplist.Size = new Size(276, 228);
            Gplist.TabIndex = 2;
            Gplist.Text = "주문 내역";
            Gplist.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 452);
            Controls.Add(Gplist);
            Controls.Add(GpPlus);
            Controls.Add(GpMenu);
            Controls.Add(btReset);
            Controls.Add(btOrder);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)pBBul).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBshrimp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBchicken).EndInit();
            GpMenu.ResumeLayout(false);
            GpMenu.PerformLayout();
            GpPlus.ResumeLayout(false);
            GpPlus.PerformLayout();
            Gplist.ResumeLayout(false);
            Gplist.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        #endregion

        private Label lblTitle;
        private RadioButton rdoBulburger;
        private PictureBox pBBul;
        private PictureBox pBshrimp;
        private RadioButton rdShrimp;
        private PictureBox pBchicken;
        private RadioButton rdChicken;
        private Button btOrder;
        private Button btReset;
        private ListBox listOrder;
        private Label lblTotal;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkCorn;
        private GroupBox GpMenu;
        private GroupBox GpPlus;
        private GroupBox Gplist;
    }
}
