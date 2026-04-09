namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rdoBulburger.Checked = false;
            rdShrimp.Checked = false;
            rdChicken.Checked = false;

            // 2. 체크박스 초기화 (추가 옵션 모두 해제)
            chkPotato.Checked = false;
            chkCheese.Checked = false;
            chkCorn.Checked = false;
            chkCola.Checked = false;

            listOrder.Items.Clear(); // 주문 내역 초기화
            lblTotal.Text = "총 금액: 0원"; // 총 금액 초기화
        }

        private void rdoBulburger_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdShrimp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdChicken_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPotato_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCorn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            int totalCost = 0;
            

            // 2. 메뉴 선택 확인 (이미 작성하신 로직을 변수 기준으로 수정)
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

            // 3. 추가 옵션 확인 (CheckBox들 - if문 독립적으로 사용)
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
            

            // 4. 최종 결과를 Label 컨트롤에 출력 (이때 .Text 속성을 사용합니다)
            // 예: lblTotalCost라는 이름의 Label이 있다면
            lblTotal.Text = "총 금액: " + totalCost.ToString() + "원";
            
        }
    }
}
