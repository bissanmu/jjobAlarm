using MaterialSkin;
using MaterialSkin.Controls;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private String connectionString = "data source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = XE)));USER ID=SCOTT;PASSWORD=TIGER;";
        private bool isRunning = false;
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            // Add dummy data to the listview
            //seedListView();
            //Header 셋팅

            initstep2();
        }

        private async Task RunInfiniteLoopAsync()
        {
            while (isRunning)
            {
                // 여기에 수행할 특정 액션을 작성하세요
                PerformAction();

                // 10초 대기
                await Task.Delay(10000);
            }
        }

        private void PerformAction()
        {
            // 여기에 10초마다 수행할 액션을 구현하세요
            // Console.WriteLine("액션 수행 중...");

            this.Alert("Succees Alert", Form_Alert.enmType.Success);
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.TopMost = true; // Ensure the alert appears on top of other windows
            frm.ShowAlert(msg, type);
        }
        private void initstep2()
        {
            materialListView1.Items.Clear();
            materialListView1.Columns[0].Width = 100;
            materialListView1.Columns[1].Width = 200;
            materialListView1.Columns[2].Width = 200;
            materialListView1.Columns[3].Width = 200;
            materialListView1.Columns[4].Width = 150;
            materialListView1.Columns[5].Width = 150;
        }
 
        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        private int colorSchemeIndex;
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 2) colorSchemeIndex = 0;

            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
            }
        }

        //nextBtn
        private void nextBtn_Click(object sender, EventArgs e)
        {
            // tabControl1은 폼에 있는 TabControl의 이름이라고 가정합니다.
            TabPage currentTab = materialTabControl1.SelectedTab;
            int currentIndex = materialTabControl1.SelectedIndex;

            // 현재 선택된 탭의 이름 출력
            //MessageBox.Show($"현재 선택된 탭: {currentTab.Name}");

            // 현재 선택된 탭의 인덱스 출력
            //MessageBox.Show($"현재 선택된 탭 인덱스: {currentIndex}");
            //MessageBox.Show($" jjob 개발계 status : {materialRadioButton5.Checked}");
            // MessageBox.Show($" jjob 검증계 status : {materialRadioButton6.Checked}");
            // 특정 탭에 따른 작업 수행
            if (currentTab.Name == "tabPage1")
            {
                // tabPage1에 대한 작업
                materialTabControl1.SelectedTab = tabPage2;

            }
            else if (currentTab.Name == "tabPage2")
            {
                // tabPage2에 대한 작업
                displayTab3();
                if (materialListView1.SelectedItems.Count > 0)
                {
                    materialTabControl1.SelectedTab = tabPage3;
                }
                else
                {
                    MessageBox.Show("선택된 내역이 없습니다");
                    materialTabControl1.SelectedTab = tabPage2;
                }
                prevBtn.Enabled = true;
            }
            else if (currentTab.Name == "tabPage3")
            {
                // tabPage2에 대한 작업
                materialTabControl1.SelectedTab = tabPage3;
                prevBtn.Enabled = true;

            }
            else if (currentTab.Name == "tabPage4")
            {
                nextBtn.Enabled = false;
                prevBtn.Enabled = true;
            }
        }
        //prevBtn
        private void prevBtn_Click(object sender, EventArgs e)
        {
            TabPage currentTab = materialTabControl1.SelectedTab;
            int currentIndex = materialTabControl1.SelectedIndex;

            if (currentTab.Name == "tabPage1")
            {
                prevBtn.Enabled = false;
            }
            else if (currentTab.Name == "tabPage2")
            {
                materialTabControl1.SelectedTab = tabPage1;
            }
            else if (currentTab.Name == "tabPage3")
            {
                displayTab3();
                materialTabControl1.SelectedTab = tabPage2;
            }
            else if (currentTab.Name == "tabPage4")
            {
                materialTabControl1.SelectedTab = tabPage3;
            }
 
        }

        public void PopulateListViewFromOracle(MaterialSkin2Framework.Controls.MaterialListView materialListView1, string connectionString, string query)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["status"].ToString());
                                item.SubItems.Add(reader["order_id"].ToString());
                                item.SubItems.Add(reader["name"].ToString());
                                item.SubItems.Add(reader["tags"].ToString());
                                item.SubItems.Add(reader["start_time"].ToString());
                                item.SubItems.Add(reader["end_time"].ToString());
                                materialListView1.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("데이터 조회 중 오류 발생: " + ex.Message);
                }
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            initstep2();
            string query = "SELECT message as status , order_id, name, tags, start_time, end_time FROM jjobs_execution";
            PopulateListViewFromOracle(materialListView1, connectionString, query);
        }


        private void displayTab3()
        {
            if(rDevBtn.Checked == true)
            {
                materialLabel3.Text = "개발계";
            }
            else
            {
                materialLabel3.Text = "검증계";
            }

            if (rJobBtn.Checked == true)
            {
                materialLabel5.Text = "Job 단위";
            }
            else
            {
                materialLabel5.Text = "Folder 단위";
            }

            if (materialListView1.SelectedItems.Count > 0)
            {
                ListViewItem item = materialListView1.SelectedItems[0];

                string column1Data = item.Text; // 첫 번째 열의 데이터
                string column2Data = item.SubItems[1].Text; // 두 번째 열의 데이터
                string column3Data = item.SubItems[2].Text; // 세 번째 열의 데이터
                string column4Data = item.SubItems[3].Text; // 
                string column5Data = item.SubItems[4].Text; // 
                string column6Data = item.SubItems[5].Text; // 
                // 데이터 사용
                // MessageBox.Show($"선택된 항목: {column1Data}, {column2Data}, {column3Data}, {column4Data}, {column5Data}, {column6Data}");

                materialLabel7.Text = column3Data;
                materialLabel9.Text = column5Data;
            }

        }

        private async void materialButton2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedTab = tabPage4;
            if (!isRunning)
            {
                isRunning = true;
                await RunInfiniteLoopAsync();
            }
        }
    }
}