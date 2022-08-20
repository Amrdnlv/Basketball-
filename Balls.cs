using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basketball_OOP
{
    class Balls
    {
        int user1_score; // счет игрока 1
        int user2_score; //счет игрока 2 
        int user_game; // играет первый игрок или второй
        int x_default; // расположение шара по х
        int y_default; // расположение шара по у
        bool reverse; // флаг что мяч ударился о щит корзины
        bool done; // флаг для выигрыш/ проигрыш игрока
        int tick_done; // счетчик для продолжения игры после попадания в корщзину

        public Balls() // консруктор для инициализации полей
        {
            user1_score = 0;
            user2_score = 0;
            user_game = 0;
            x_default = 55;
            y_default = 290;
            reverse = false;
            done = false;
            tick_done = 0;
        }

        public int User_game
        {
                get { return user_game; }
            set { user_game = value; }
        }
        public int X_default
        {
            get { return x_default; }
        }
        public int Y_default
        {
            get { return y_default; }
        }

        public void defolt() // приведение к начальным значениям шара при новой игре
        {
            x_default = 55;
            y_default = 290;
            reverse = false;
        }
        
        public void sider(int i)
        {
            if(i == 1) x_default += 12; else x_default -= 12;
        }
       
        public void power(int i)
        {
            if(i == 1) y_default -= 12; else y_default += 12;
        }

        public int move(int tick)
        {
            x_default += 8;
            y_default -= 8;
            if (tick >= 25)
            {
                y_default += 10;
                if (x_default >= 500 || reverse == true)
                {
                    reverse = true;
                    x_default -= 10;
                }
                if ((x_default >= 440 && y_default >= 140) || done)
                {
                    done = true;
                    tick_done++;
                    if(x_default > 465)
                    {
                        x_default -= 3;
                    }
                    else x_default = 465;

                    y_default += 5 ;
                }
            }

            if (tick_done == 5 && done)
            {
                tick_done = 0;
                done = false; 
                if (user_game == 0) user1_score += 3; // добавление очков игравшему игроку
                else user2_score += 3;
                return 0;
            }
            if (tick > 90) return 2;
            return 1;
            
        }

        public int get_score()
        {
            if (user_game == 0) return user1_score;
            return user2_score;
        }
    }
    
}

