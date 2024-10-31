using System.Text.RegularExpressions;

namespace typewriter
{
    public partial class typewriter : Form
    {
        public typewriter()
        {
            InitializeComponent();
        }

        // ���������� ������� ��� �������� �����
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // ������������� ���������� ��������� ��� �������� ����
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;

            // ������������� �� ���������� �������� ���� (Alt + Tab)
            SendKeys.SendWait("%{TAB}");

            // �������� �� ����� ������������ ����
            Thread.Sleep(1500); // ������� �������

            // ��������� ������
            foreach (char c in inputText)
            {

                if (c == '\n') // ���� ������ - ������� ������
                {
                    // ������ �� ������, ����� ������������� ������ �������� ������
                }
                else
                {
                    if (checkBox1.Checked) // ��������� �����
                    {
                        // ���������� ���������� �����
                        string txt = Regex.Replace(c.ToString(), "[+^%~(){}]", "{$0}");
                        SendKeys.SendWait(txt);
                        Thread.Sleep(100); // 100 ����������� ����� ���������, ���� ������� �������
                    }
                    else
                    {
                        string txt = Regex.Replace(c.ToString(), "[+^%~(){}]", "{$0}");
                        SendKeys.SendWait(txt);
                    }
                }
            }
            if (checkBox2.Checked) // ����������� �������� "����"
            {
                SendKeys.SendWait("{ENTER}");
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox3.Checked; //������ ���� ����
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // ��������
        }
    }
}
