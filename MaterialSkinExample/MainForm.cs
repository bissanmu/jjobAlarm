using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            // Add dummy data to the listview
            seedListView();

        }

        private void seedListView()
        {
            //Define
            var data = new[]
            {
                new []{"Lollipop", "392", "0.2", "0"},
                new []{"KitKat", "518", "26.0", "7"},
                new []{"Ice cream sandwich", "237", "9.0", "4.3"},
                new []{"Jelly Bean", "375", "0.0", "0.0"},
                new []{"Honeycomb", "408", "3.2", "6.5"}
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                materialListView1.Items.Add(item);
            }
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

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            materialProgressBar1.Value = Math.Min(materialProgressBar1.Value + 10, 100);
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            materialProgressBar1.Value = Math.Max(materialProgressBar1.Value - 10, 0);
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                materialTabControl1.SelectedTab = tabPage3;
                prevBtn.Enabled = true;
            }
            else if (currentTab.Name == "tabPage3")
            {
                // tabPage2에 대한 작업
                materialTabControl1.SelectedTab = tabPage4;
                prevBtn.Enabled = true;
            }
            else if (currentTab.Name == "tabPage4")
            {
                // tabPage2에 대한 작업
                materialTabControl1.SelectedTab = tabPage5;
                prevBtn.Enabled = true;
            }
            else if (currentTab.Name == "tabPage5")
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
                materialTabControl1.SelectedTab = tabPage2;
            }
            else if (currentTab.Name == "tabPage4")
            {
                materialTabControl1.SelectedTab = tabPage3;
            }
            else if (currentTab.Name == "tabPage5")
            {
                materialTabControl1.SelectedTab = tabPage4;
            }
        }
    }
}