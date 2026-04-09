namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 초기화 버튼 (기존 button2)
        private void button2_Click(object sender, EventArgs e)
        {
            // 라디오 버튼 초기화
            rdoBulburger.Checked = false;
            rdShrimp.Checked = false;
            rdChicken.Checked = false;

            // 체크박스 초기화
            chkPotato.Checked = false;
            chkCheese.Checked = false;
            chkCorn.Checked = false;
            chkCola.Checked = false;

            // 출력 항목 초기화
            listOrder.Items.Clear();
            lblTotal.Text = "총 금액: 0원";
        }

        // 주문하기 버튼
        private void btOrder_Click(object sender, EventArgs e)
        {
            // 1. 유효성 검사 (아무것도 선택하지 않은 경우)
            if (!rdoBulburger.Checked && !rdShrimp.Checked && !rdChicken.Checked)
            {
                listOrder.Items.Clear();
                listOrder.Items.Add("메뉴를 선택해주세요.");
                lblTotal.Text = "주문을 다시 확인해주세요.";
                return; // 아래 계산 로직을 실행하지 않고 여기서 중단
            }

            // 2. 계산 시작
            int totalCost = 0;
            listOrder.Items.Clear(); // 리스트박스를 비우고 새로 담기 시작

            // 메인 메뉴 확인 (라디오 버튼)
            if (rdoBulburger.Checked)
            {
                totalCost += 5000;
                listOrder.Items.Add("불고기버거 5,000원");
            }
            else if (rdShrimp.Checked)
            {
                totalCost += 4000;
                listOrder.Items.Add("새우버거 4,000원");
            }
            else if (rdChicken.Checked)
            {
                totalCost += 3000;
                listOrder.Items.Add("치킨버거 3,000원");
            }

            // 3. 추가 옵션 확인 (체크박스 - 독립적 if문)
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                listOrder.Items.Add("감자튀김 3,500원");
            }

            if (chkCola.Checked)
            {
                totalCost += 2500;
                listOrder.Items.Add("콜라 2,500원");
            }

            if (chkCheese.Checked)
            {
                totalCost += 1500;
                listOrder.Items.Add("치즈스틱 1,500원");
            }

            if (chkCorn.Checked)
            {
                totalCost += 500;
                listOrder.Items.Add("코울슬로 500원");
            }

            // 4. 최종 결과 출력 (쉼표 포맷 "N0" 추가)
            lblTotal.Text = "총 금액: " + totalCost.ToString("N0") + "원";
        }

        // 아래 사용하지 않는 이벤트 핸들러들은 그대로 두셔도 되고 삭제하셔도 됩니다.
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

