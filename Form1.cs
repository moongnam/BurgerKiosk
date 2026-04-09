using System;
using System.Drawing;
using System.Windows.Forms;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // 1. 초기 체크 해제
            rdoBulburger.Checked = false;
            rdShrimp.Checked = false;
            rdChicken.Checked = false;

            // 2. 탭이 버거 그룹박스로 먼저 오게 설정
            // GpMenu가 첫 번째 탭 순서(TabIndex=0)여야 합니다.
            rdoBulburger.TabStop = true;
            GpMenu.Focus();
        }

        // 주문하기 버튼
        private void btOrder_Click(object sender, EventArgs e)
        {
            if (!rdoBulburger.Checked && !rdShrimp.Checked && !rdChicken.Checked)
            {
                listOrder.Items.Clear();
                listOrder.Items.Add("메뉴를 선택해주세요.");
                lblTotal.Text = "주문을 다시 확인해주세요.";
                return;
            }

            int totalCost = 0;
            listOrder.Items.Clear();

            if (rdoBulburger.Checked) { totalCost += 5000; listOrder.Items.Add("불고기버거 5,000원"); }
            else if (rdShrimp.Checked) { totalCost += 4000; listOrder.Items.Add("새우버거 4,000원"); }
            else if (rdChicken.Checked) { totalCost += 3000; listOrder.Items.Add("치킨버거 3,000원"); }

            if (chkPotato.Checked) { totalCost += 3500; listOrder.Items.Add("감자튀김 3,500원"); }
            if (chkCola.Checked) { totalCost += 2500; listOrder.Items.Add("콜라 2,500원"); }
            if (chkCheese.Checked) { totalCost += 1500; listOrder.Items.Add("치즈스틱 1,500원"); }
            if (chkCorn.Checked) { totalCost += 500; listOrder.Items.Add("코울슬로 500원"); }

            lblTotal.Text = "총 금액: " + totalCost.ToString("N0") + "원";
        }

        // 초기화 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            rdoBulburger.Checked = false;
            rdShrimp.Checked = false;
            rdChicken.Checked = false;
            chkPotato.Checked = false;
            chkCheese.Checked = false;
            chkCorn.Checked = false;
            chkCola.Checked = false;

            listOrder.Items.Clear();
            lblTotal.Text = "총 금액: 0원";
            rdoBulburger.TabStop = true;
            rdoBulburger.Focus();
        }

        // 키보드 조작 보조: 방향키로 라디오버튼 사이 이동할 때 체크되도록 함
        

        // 비어있던 이벤트 핸들러들 (삭제하면 디자이너 에러나니 그대로 둡니다)
        private void label2_Click(object sender, EventArgs e) { }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void rdoBulburger_CheckedChanged(object sender, EventArgs e) { }
        private void rdShrimp_CheckedChanged(object sender, EventArgs e) { }
        private void rdChicken_CheckedChanged(object sender, EventArgs e) { }
        private void chkPotato_CheckedChanged(object sender, EventArgs e) { }
        private void chkCheese_CheckedChanged(object sender, EventArgs e) { }
        private void chkCorn_CheckedChanged(object sender, EventArgs e) { }
    }
}