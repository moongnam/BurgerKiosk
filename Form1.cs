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
            ResetAllControls();
        }

        // 공통 로직: 모든 컨트롤을 초기화 상태로 만듦
        private void ResetAllControls()
        {
            rdoBulburger.Checked = false;
            rdShrimp.Checked = false;
            rdChicken.Checked = false;

            chkPotato.Checked = false;
            chkCheese.Checked = false;
            chkCorn.Checked = false;
            chkCola.Checked = false;

            // ★핵심★ 체크가 안 되어 있어도 탭 키가 멈추게 설정
            // 불고기버거에 탭 정거장을 강제로 세웁니다.
            rdoBulburger.TabStop = true;

            listOrder.Items.Clear();
            lblTotal.Text = "총 금액: 0원";

            // 초기화 후 포커스를 타이틀로 보내서 자동 체크 방지
            lblTitle.Focus();
        }

        private void UpdateOrder()
        {
            // [방어막] 아무것도 체크 안 됐을 땐 0원 유지
            if (!rdoBulburger.Checked && !rdShrimp.Checked && !rdChicken.Checked)
            {
                listOrder.Items.Clear();
                lblTotal.Text = "총 금액: 0원";
                // 체크가 다 풀린 상태에서도 탭은 올 수 있게 TabStop 유지
                rdoBulburger.TabStop = true;
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

        private void btOrder_Click(object sender, EventArgs e)
        {
            if (!rdoBulburger.Checked && !rdShrimp.Checked && !rdChicken.Checked)
            {
                listOrder.Items.Clear();
                listOrder.Items.Add("메뉴를 선택해주세요.");
                lblTotal.Text = "주문을 다시 확인해주세요.";
                return;
            }
            MessageBox.Show("주문이 완료되었습니다!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetAllControls();
        }

        // --- 이벤트 핸들러 ---
        private void rdoBulburger_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void rdShrimp_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void rdChicken_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void chkPotato_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void chkCheese_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void chkCorn_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { UpdateOrder(); }

        private void label2_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}