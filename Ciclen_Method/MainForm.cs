using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Ciclen_Method
{
    public partial class MainForm : System.Windows.Forms.Form

    {
        // закруглённый button https://www.cyberforum.ru/post9872749.html
        public static double a;
        public static double b;
        //public static double x0;
        //public static double y0;
        public static int N;
        public static int eps;
        static double f;
        public static string uravn = "";
        public static double[] x;
        public static double[] y;
        static bool Eulerbox;
        static bool Chordbox;
        static bool Euler_recalbox;
        static bool Runge_kuttabox;
        static bool Milnabox;
        static bool Adamsbox;
        double x0;
        double y0;
        public MainForm()
        {
            InitializeComponent();
            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            a_textbox.Text = a.ToString();
            b_textbox.Text = b.ToString();
            x0_textbox.Text = x0.ToString();
            y0_textbox.Text = y0.ToString();
            N_numUpDown.Text = N.ToString();
            eps_textbox.Text = eps.ToString();
            if (uravn != "")
            {
                dif_textbox.Text = uravn;
            }
            else
                dif_textbox.Text = "";

            if (Eulerbox == true)
                EulerBox.Checked = true;

            if (Chordbox == true)
                ChordBox.Checked = true;

            if (Euler_recalbox == true)
                Euler_recalBox.Checked = true;

            if (Runge_kuttabox == true)
                Runge_kuttaBox.Checked = true;

            if (Milnabox == true)
                MilnaBox.Checked = true;

            if (Adamsbox == true)
                AdamsBox.Checked = true;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void CreateAndPlaceToPage(Type pageType)
        {
            // создаем новый экземпляр при помощи ссылки на тип
            var userControl = (UserControl)Activator.CreateInstance(pageType);
            // и добавляем его в панель Panel1
            Panel.Controls.Add(userControl);
            // предыдущий размещённый пользовательский элемент удаляем
            if (Panel.Controls.Count > 1)
                Panel.Controls.RemoveAt(0);            
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Number(object sender, KeyPressEventArgs e)// Разрешить вводить только цифры, символ backspace, запятую
        {
            char charCode = e.KeyChar;
            if (!char.IsDigit(charCode) && charCode != 8 && charCode != 44)
                e.Handled = true;
        }
        private void Solve_Click(object sender, EventArgs e)
        {
            try
            {
                ParserFunction.addFunction("sin", new SinFunction());
                ParserFunction.addFunction("pi", new PiFunction());
                ParserFunction.addFunction("exp", new ExpFunction());
                ParserFunction.addFunction("pow", new PowFunction());
                ParserFunction.addFunction("abs", new AbsFunction());
                ParserFunction.addFunction("sqrt", new SqrtFunction());

                ParserFunction.addFunction("x", new XFunction());
                ParserFunction.addFunction("y", new YFunction());

                a = double.Parse(a_textbox.Text);
                b = double.Parse(b_textbox.Text);
                x0 = double.Parse(x0_textbox.Text);
                y0 = double.Parse(y0_textbox.Text);
                N = int.Parse(N_numUpDown.Text);
                eps = int.Parse(eps_textbox.Text);
                uravn = dif_textbox.Text;
                x = new double[N];
                y = new double[N];
                //f = Parser.process(dif_textbox.Text);

                if (EulerBox.Checked == true)
                {
                    Eulerbox = true;
                    Method_Eulers(a, b, x0, N, y0, eps, x, y);
                    //MessageBox.Show($"{f}");

                    //var column1 = new DataGridViewColumn();
                    //column1.HeaderText = "X"; //текст в шапке
                    //column1.Width = 100; //ширина колонки
                    //column1.ReadOnly = true; //значение в этой колонке нельзя править
                    //column1.Name = "x"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
                    //column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
                    //column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
                    //dataGridView1.Columns.Add(column1);
                    //var column2 = new DataGridViewColumn();
                    //column2.HeaderText = "Y"; //текст в шапке
                    //column2.Width = 100; //ширина колонки
                    //column2.ReadOnly = true; //значение в этой колонке нельзя править
                    //column2.Name = "y"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
                    //column2.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
                    //column2.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
                    //dataGridView1.Columns.Add(column2);
                    //dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

                    //for (int i = 0; i < N; i++)
                    //{
                    //    //Добавляем строку, указывая значения колонок поочереди слева направо
                    //   dataGridView1.Rows.Add(i, x[i], Math.Round(y[i], int.Parse(eps_textbox.Text)));
                    //}

                }
                if (ChordBox.Checked)
                {
                    Chordbox = true;
                    Method_Chord(a, b, x0, N, y0, eps);
                }
                if (Euler_recalBox.Checked)
                {
                    Euler_recalbox = true;
                    Method_Euler_recal(a, b, x0, N, y0, eps);
                }
                if (Runge_kuttaBox.Checked)
                {
                    Runge_kuttabox = true;
                    Method_Runge_kutta(a, b, x0, N, y0, eps);
                }
                if (MilnaBox.Checked)
                {
                    Milnabox = true;
                    Method_Milna(a, b, x0, N, y0, eps);
                }
                if (AdamsBox.Checked)
                {
                    Adamsbox = true;
                    Method_Adams(a, b, x0, N, y0, eps);
                }

                if (!EulerBox.Checked)
                    Eulerbox = false;

                if (!ChordBox.Checked)
                    Chordbox = false;

                if (!Euler_recalBox.Checked)
                    Euler_recalbox = false;

                if (!Runge_kuttaBox.Checked)
                    Runge_kuttabox = false;

                if (!MilnaBox.Checked)
                    Milnabox = false;

                if (!AdamsBox.Checked)
                    Adamsbox = false;
                               

               

            }
            catch (Exception exept)
            {
                MessageBox.Show("Решить не удалось" + ".\n " + exept.Message + "\n " + "Проверьте ввод a, b, x0, N, y0, eps.");
            }
        }
        public static double F(double x, double y)
        {

            double F = y - x;
            return F;
        }
        private static void Method_Eulers(double a, double b, double x0, double N, double y0, double eps, double[] x, double[] y)
        {
            double h = (b - a) / N;
            x[0] = a;
            y[0] = b;
            double FuncX;
            double FuncY;
            for (int i = 1; i < N; i++)
            {
                x[i] = x[0] + i * h;
                // y[i] = y[i - 1] + h * F(x[i - 1], y[i - 1]); 
                FuncX = x[i - 1];
                FuncY = y[i - 1];

                f = Parser.process(FuncX, FuncY, uravn);
                y[i] = y[i - 1] + h * f;


            }
        }
        private static void Method_Chord(double a, double b, double x0, double N, double y0, double eps)
        {

        }
        private static void Method_Euler_recal(double a, double b, double x0, double N, double y0, double eps)
        {

        }
        private static void Method_Runge_kutta(double a, double b, double x0, double N, double y0, double eps)
        {

        }
        private static void Method_Milna(double a, double b, double x0, double N, double y0, double eps)
        {

        }
        private static void Method_Adams(double a, double b, double x0, double N, double y0, double eps)
        {

        }

    }

    public class Parser
    {
        public const char START_ARG = '(';
        public const char END_ARG = ')';
        public const char END_LINE = '\n';

        class Cell
        {
            internal Cell(double value, char action)
            {
                Value = value;
                Action = action;
            }

            internal double Value { get; set; }
            internal char Action { get; set; }
        }

        public static double process(double x0, double y0, string data)
        {
            string expression = preprocess(data);
            int from = 0;

            return loadAndCalculate(x0, y0, data, ref from, END_LINE);
        }

        static string preprocess(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentException("Загруженны пустые данные");
            }

            int parentheses = 0;
            StringBuilder result = new StringBuilder(data.Length);

            for (int i = 0; i < data.Length; i++)
            {
                char ch = data[i];
                switch (ch)
                {
                    case ' ':
                    case '\t':
                    case '\n': continue;
                    case END_ARG:
                        parentheses--;
                        break;
                    case START_ARG:
                        parentheses++;
                        break;
                }
                result.Append(ch);
            }

            if (parentheses != 0)
            {
                throw new ArgumentException("Неравновномерные скобки");
            }

            return result.ToString();
        }

        public static double loadAndCalculate(double x0, double y0, string data, ref int from, char to = END_LINE)
        {
            if (from >= data.Length || data[from] == to)
            {
                throw new ArgumentException("Загруженные неверные данные: " + data);
            }

            List<Cell> listToMerge = new List<Cell>(16);
            StringBuilder item = new StringBuilder();

            do
            {
                char ch = data[from++];
                if (stillCollecting(item.ToString(), ch, to))
                {
                    item.Append(ch);
                    if (from < data.Length && data[from] != to)
                    {
                        continue;
                    }
                }
                ParserFunction func = new ParserFunction(data, ref from, item.ToString(), ch);
                double value = func.getValue(x0, y0, data, ref from);

                char action = validAction(ch) ? ch
                                              : updateAction(data, ref from, ch, to);

                listToMerge.Add(new Cell(value, action));
                item.Clear();

            } while (from < data.Length && data[from] != to);

            if (from < data.Length &&
               (data[from] == END_ARG || data[from] == to))
            {
                from++;
            }

            Cell baseCell = listToMerge[0];
            int index = 1;

            return merge(baseCell, ref index, listToMerge);
        }

        static bool stillCollecting(string item, char ch, char to)
        {
            char stopCollecting = (to == END_ARG || to == END_LINE) ?
                                   END_ARG : to;
            return (item.Length == 0 && (ch == '-' || ch == END_ARG)) ||
                  !(validAction(ch) || ch == START_ARG || ch == stopCollecting);
        }

        static bool validAction(char ch)
        {
            return ch == '*' || ch == '/' || ch == '+' || ch == '-' || ch == '^';
        }

        static char updateAction(string item, ref int from, char ch, char to)
        {
            if (from >= item.Length || item[from] == END_ARG || item[from] == to)
            {
                return END_ARG;
            }

            int index = from;
            char res = ch;
            while (!validAction(res) && index < item.Length)
            {
                res = item[index++];
            }

            from = validAction(res) ? index
                                    : index > from ? index - 1
                                                   : from;
            return res;
        }

        static double merge(Cell current, ref int index, List<Cell> listToMerge,
                     bool mergeOneOnly = false)
        {
            while (index < listToMerge.Count)
            {
                Cell next = listToMerge[index++];

                while (!canMergeCells(current, next))
                {
                    merge(next, ref index, listToMerge, true);
                }
                mergeCells(current, next);
                if (mergeOneOnly)
                {
                    return current.Value;
                }
            }

            return current.Value;
        }

        static void mergeCells(Cell leftCell, Cell rightCell)
        {
            switch (leftCell.Action)
            {
                case '^':
                    leftCell.Value = Math.Pow(leftCell.Value, rightCell.Value);
                    break;
                case '*':
                    leftCell.Value *= rightCell.Value;
                    break;
                case '/':
                    if (rightCell.Value == 0)
                    {
                        throw new ArgumentException("Деление на ноль");
                    }
                    leftCell.Value /= rightCell.Value;
                    break;
                case '+':
                    leftCell.Value += rightCell.Value;
                    break;
                case '-':
                    leftCell.Value -= rightCell.Value;
                    break;
            }
            leftCell.Action = rightCell.Action;
        }

        static bool canMergeCells(Cell leftCell, Cell rightCell)
        {
            return getPriority(leftCell.Action) >= getPriority(rightCell.Action);
        }

        static int getPriority(char action)
        {
            switch (action)
            {
                case '^': return 4;
                case '*':
                case '/': return 3;
                case '+':
                case '-': return 2;
            }
            return 0;
        }
    }

    public class ParserFunction
    {
        public ParserFunction()
        {
            m_impl = this;
        }

        internal ParserFunction(string data, ref int from, string item, char ch)
        {

            if (item.Length == 0 && ch == Parser.START_ARG)
            {
                m_impl = s_idFunction;
                return;
            }

            if (m_functions.TryGetValue(item, out m_impl))
            {
                return;
            }

            s_strtodFunction.Item = item;
            m_impl = s_strtodFunction;
        }

        public static void addFunction(string name, ParserFunction function)
        {
            m_functions[name] = function;
        }

        public double getValue(double x0, double y0, string data, ref int from)
        {
            return m_impl.evaluate(x0, y0, data, ref from);
        }

        protected virtual double evaluate(double x0, double y0, string data, ref int from)
        {
            return 0;
        }

        private ParserFunction m_impl;
        private static Dictionary<string, ParserFunction> m_functions = new Dictionary<string, ParserFunction>();

        private static StrtodFunction s_strtodFunction = new StrtodFunction();
        private static IdentityFunction s_idFunction = new IdentityFunction();
    }

    class StrtodFunction : ParserFunction
    {
        protected override double evaluate(double x0, double y0, string data, ref int from)
        {
            double num;
            if (!Double.TryParse(Item, out num))
            {
                throw new ArgumentException("Could not parse token [" + Item + "]");
            }
            return num;
        }
        public string Item { private get; set; }
    }

    class IdentityFunction : ParserFunction
    {
        protected override double evaluate(double x0, double y0, string data, ref int from)
        {
            return Parser.loadAndCalculate(x0, y0, data, ref from, Parser.END_ARG);
        }
    }

    class PiFunction : ParserFunction
    {
        protected override double evaluate(double x0, double y0, string data, ref int from)
        {
            return 3.141592653589793;
        }
    }
    class ExpFunction : ParserFunction
    {
        protected override double evaluate(double x0, double y0, string data, ref int from)
        {
            double arg = Parser.loadAndCalculate(x0, y0, data, ref from, Parser.END_ARG);
            return Math.Exp(arg);
        }
    }
    class PowFunction : ParserFunction
    {
        protected override double evaluate(double x0, double y0, string data, ref int from)
        {
            double arg1 = Parser.loadAndCalculate(x0, y0, data, ref from, ',');
            double arg2 = Parser.loadAndCalculate(x0, y0, data, ref from, Parser.END_ARG);

            return Math.Pow(arg1, arg2);
        }
    }
    class SinFunction : ParserFunction
    {
        protected override double evaluate(double x0, double y0, string data, ref int from)
        {
            double arg = Parser.loadAndCalculate(x0, y0, data, ref from, Parser.END_ARG);
            return Math.Sin(arg);
        }
    }
    class SqrtFunction : ParserFunction
    {
        protected override double evaluate(double x0, double y0, string data, ref int from)
        {
            double arg = Parser.loadAndCalculate(x0, y0, data, ref from, Parser.END_ARG);
            return Math.Sqrt(arg);
        }
    }
    class AbsFunction : ParserFunction
    {
        protected override double evaluate(double x0, double y0, string data, ref int from)
        {
            double arg = Parser.loadAndCalculate(x0, y0, data, ref from, Parser.END_ARG);
            return Math.Abs(arg);
        }
    }
    class XFunction : ParserFunction
    {
        protected override double evaluate(double x0, double y0, string data, ref int from)
        {
            return x0;
        }
    }
    class YFunction : ParserFunction
    {
        protected override double evaluate(double x0, double y0, string data, ref int from)
        {
            return y0;
        }
    }


}
