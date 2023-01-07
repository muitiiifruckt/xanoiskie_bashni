using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ханойские_башни.Custom.CodeeloUI.Controls;

namespace Ханойские_башни
{

    public partial class Form1 : Form
    {
        // стэк для дальнейшего удаления созданных дисков
        Stack<PictureBox> tower_1_picturebox = new Stack<PictureBox>(); 
        Stack<PictureBox> tower_2_picturebox = new Stack<PictureBox>();
        Stack<PictureBox> tower_3_picturebox = new Stack<PictureBox>();
        // стэк для дальнейшего удаления созданных дисков

        // координаты рисунков для дальнейшего реализации анимации
        int x1, y1, x2, y2,s_x,s_y,s_y2,speed, type_of_speed ,time;
        // координаты рисунков для дальнейшего реализации анимации

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 3;// при открытие сразу будет 3 диска 

        }

        // проверка можем ли мы добавить из одной башни во вторую диск
        private bool can_add(Stack <PictureBox> from,Stack <PictureBox> to)
        {
            if(from.Count == 0 ) return false;// из пустого нельзя перекинуть
            if(to.Count == 0 ) return true;// в пустой всегда можно перекинуть
            if(from.Peek().Width >to.Peek().Width ) return false;// больший диск на меньший нельзя перекинуть
            return true;  // в остальных случаях можно перекинуть
        }


        // функция перемещения дисков
        private void move(Stack<PictureBox> from, Stack<PictureBox> to,PictureBox fist_tower, PictureBox second_tower)
        {

            int n = Decimal.ToInt32(numericUpDown1.Value);
            // а тут плавное перемещение графическое

            int y = pic_tower_1.Location.Y; // верхняя точка башни (значение по игрику)

            x1 = fist_tower.Location.X;
            x2 = second_tower.Location.X;




            // Перемещения которые должны произойти по Х и У

            s_x = x2 - x1;

            s_y = from.Peek().Location.Y - y  + from.Peek().Height; // сначала вверх

            if(to.Count==0) // отдельно отработаь слуачай когда башня, в который добавляем пуста
            {
                s_y2 = pic_hotisontal_tower.Location.Y - y;
            }
            else
                s_y2 = to.Peek().Location.Y - y;// потом вниз

                
            transfer(from, to); // перемещаем на форме

            to.Push(from.Pop());// перемещаем в стеках

        }

        // перемещение дисков на форме
        private void transfer(Stack<PictureBox> from, Stack<PictureBox> to)
        {

            // получаем значение типа скорости из нижнего нумерика
            type_of_speed = Decimal.ToInt32(numericUpDown2.Value);
            switch (type_of_speed) // 5 скоростей 
            {
                case 1:
                    time = 1;
                    speed = 1;
                    break;
                case 2:
                    time = 1;
                    speed = 2;
                    break;
                case 3:
                    time = 0;
                    speed = 1;
                    break;
                case 4:
                    time = 0;   
                    speed = 2;
                    break;
                case 5:
                    time = 0;   
                    speed = 20;
                    break;
            }

            // если скорость от 3 и более вертикальная анимация будет представлять просто одно перемещение
            if (speed > 3)
            {
                from.Peek().Top = from.Peek().Top - s_y;
            }
            else
            {
                for (int i = 0; i < Math.Abs(s_y) / speed; i++)
                {
                    from.Peek().Top = from.Peek().Top - speed;
                    Thread.Sleep(time);
                }
            }
                

            int sgn = Math.Abs(s_x) / s_x; // чтоб правильно вычислять в какую сторону двигать диск ( влево и враво)
            for (int i = 0; i < Math.Abs(s_x)/speed; i++)
            {
                from.Peek().Left = from.Peek().Left + speed * sgn;
                Thread.Sleep(time);
            }
        // если скорость от 3 и более вертикальная анимация будет представлять просто одно перемещение
            if (speed > 3)
                {
                    from.Peek().Top = from.Peek().Top + s_y2;
                }
            else
            {
                for (int i = 0; i < Math.Abs(s_y2 / speed); i++)
                {
                    from.Peek().Top = from.Peek().Top + speed;
                    Thread.Sleep(time);
                }
            }
            


        }
        // главная фунция решения 
        private void solve()
        {
            int n = Decimal.ToInt32(numericUpDown1.Value);// количество дисков
            // "Цикличное решение"
            /*  Обозначим через «1 - 2» такое действие: переложить диск или с 1 - го штыря на 2 - й,
                  или со 2 - го на 1 - й, в зависимости от того, где он меньше. Тогда,
                  чтобы решить головоломку с чётным количеством дисков,
                  надо многократно повторять действия: 1 - 2, 1 - 3, 2 - 3.
                  Если число дисков нечётно — 1 - 3, 1 - 2, 2 - 3.*/
            //"Цикличное решение"
            if (n%2==0)
                {
                    while (tower_3_picturebox.Count != n )
                    {
                    // 1 - 2
                        if (can_add(tower_1_picturebox, tower_2_picturebox))
                        {
                            move(tower_1_picturebox, tower_2_picturebox, pic_tower_1, pic_tower_2);// 1 -> 2

                        }
                        else if (tower_3_picturebox.Count != n)
                    {
                            move(tower_2_picturebox, tower_1_picturebox, pic_tower_2, pic_tower_1);//2 -> 1
                        }
                        // 1- 3
                        if  (can_add(tower_1_picturebox, tower_3_picturebox) && tower_3_picturebox.Count != n)
                        {
                            move(tower_1_picturebox, tower_3_picturebox, pic_tower_1, pic_tower_3);// 1 -> 3
                        }
                        else if (tower_3_picturebox.Count != n)
                    {
                            move(tower_3_picturebox, tower_1_picturebox, pic_tower_3, pic_tower_1);//3 -> 1
                        }
                        // 2 - 3
                        if (can_add(tower_2_picturebox, tower_3_picturebox) && tower_3_picturebox.Count != n)
                    {
                            move(tower_2_picturebox, tower_3_picturebox, pic_tower_2, pic_tower_3);// 2 -> 3
                        }
                        else if (tower_3_picturebox.Count != n)
                    {
                            move(tower_3_picturebox, tower_2_picturebox, pic_tower_3, pic_tower_2);//3 -> 2
                        }
                    }
                }
               else
                {
                    while (tower_3_picturebox.Count != n )
                    {

                    // 1- 3
                    if (can_add(tower_1_picturebox, tower_3_picturebox))
                        {
                            move(tower_1_picturebox, tower_3_picturebox, pic_tower_1, pic_tower_3);// 1 -> 3
                        }
                        else if (tower_3_picturebox.Count != n)
                    {
                            move(tower_3_picturebox, tower_1_picturebox, pic_tower_3, pic_tower_1);//3 -> 1
                        }
                        // 1 - 2
                        if (can_add(tower_1_picturebox, tower_2_picturebox) && tower_3_picturebox.Count != n)
                        {
                            move(tower_1_picturebox, tower_2_picturebox, pic_tower_1, pic_tower_2);// 1 -> 2
                        }
                        else if ( tower_3_picturebox.Count != n)
                        {
                            move(tower_2_picturebox, tower_1_picturebox, pic_tower_2, pic_tower_1);//2 -> 1
                        }
                        // 2 - 3
                        if (can_add(tower_2_picturebox, tower_3_picturebox) && tower_3_picturebox.Count != n)
                        {
                            move(tower_2_picturebox, tower_3_picturebox, pic_tower_2, pic_tower_3);// 2 -> 3
                        }
                        else if (tower_3_picturebox.Count != n)
                    {
                            move(tower_3_picturebox, tower_2_picturebox, pic_tower_3, pic_tower_2);//3 -> 2
                        }
                    }

                }


        }

        

        private void create_disks(int n) // создание дисков ( чисто графика )
        {
            
            int weight = 350 / n;// длина дисков ( подбирал их сам , именно подбирал...)
            int hight = 388 / n;// ширина дисков


       
            for (int i = n; i >=1; i--)
            {
                Random random = new Random();
                CustomPictureBox pic = new CustomPictureBox();
                pic.BorderColorFirst = Color.FromArgb(random.Next(255) * i % 255, random.Next(255) * i % 255, random.Next(255) * i % 255);// рандомные цвета самих ДИСКОВ
                pic.BackColor = Color.Black;// это цвет РАМКИ !
                pic.Location = new Point(179 - (weight * (i)) / 2, 596 - (n - (i - 1)) * hight);// местоположение дисков
                pic.Size = new Size(weight * i, hight);//размеры
                this.Controls.Add(pic);// само добавление на форму 
                tower_1_picturebox.Push(pic);// закидываем в стэк, чтобы потом с ними работать
                pic.BringToFront();// на передний план диски ( иначе перекрывает башнями )
            }
        }

        
        

        private void button_solve_Click(object sender, EventArgs e) // нажимаем на кнопку solve  и все начинает двигаться
        {
            
            solve();// запуск решения
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) // при изменение значения нумерика...3
        {
            // удаление предыдущих дисков ( чтобы изчесли из формы )
            foreach (PictureBox pic in tower_1_picturebox) 
                pic.Dispose();
            foreach (PictureBox pic in tower_2_picturebox) 
                pic.Dispose();
            foreach (PictureBox pic in tower_3_picturebox) 
                pic.Dispose();
            // удаление предыдущих дисков

            // также удаление из стеков
            tower_1_picturebox.Clear();
            tower_2_picturebox.Clear();
            tower_3_picturebox.Clear();
            // также удаление из стеков

            // получение числа с нумерик... и запуск функции создании дисков
            int value = Decimal.ToInt32(numericUpDown1.Value);
            create_disks(value);
        }
 
    }

}

