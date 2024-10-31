using System.Text.RegularExpressions;

namespace typewriter
{
    public partial class typewriter : Form
    {
        public typewriter()
        {
            InitializeComponent();
        }

        // Обработчик события для закрытия формы
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Останавливаем выполнение программы при закрытии окна
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;

            // Переключаемся на предыдущее активное окно (Alt + Tab)
            SendKeys.SendWait("%{TAB}");

            // Задержка на время переключения окна
            Thread.Sleep(1500); // полторы секунды

            // Обработка текста
            foreach (char c in inputText)
            {

                if (c == '\n') // Если символ - перенос строки
                {
                    // Ничего не делаем, чтобы заблокировать лишние переносы строки
                }
                else
                {
                    if (checkBox1.Checked) // Медленный режим
                    {
                        // Экранируем проблемные знаки
                        string txt = Regex.Replace(c.ToString(), "[+^%~(){}]", "{$0}");
                        SendKeys.SendWait(txt);
                        Thread.Sleep(100); // 100 миллисекунд между символами, если чекбокс включен
                    }
                    else
                    {
                        string txt = Regex.Replace(c.ToString(), "[+^%~(){}]", "{$0}");
                        SendKeys.SendWait(txt);
                    }
                }
            }
            if (checkBox2.Checked) // Заканчивать клавишей "ВВОД"
            {
                SendKeys.SendWait("{ENTER}");
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox3.Checked; //Поверх всех окон
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // Очистить
        }
    }
}
