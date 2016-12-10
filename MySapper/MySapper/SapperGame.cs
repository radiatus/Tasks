using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySapper
{
    public enum GameStatus {ON, VICTORY, FAIL }

    public partial class SapperGame : Form
    {

        private Cells[,] playingField;//Игровое поле из клеток, двумерный массив клеток по факту

        private int countRow;//кол-во строк

        private int countColumn;//кол-во столбцов

        private int countMine;//Кол-во мин, задаёт пользователь

        private int countFlag;

        private GameStatus status;//Статус игры, нужна для проверки старта игры, активной части игры и итогового поражения либо победы

        private Graphics g;//Нужно для отрисовки графики

        private const int cellSize = 40;//Размер клетки в пикселях

        private SapperDrawing ds;//нужна только и исключительно для того, что бы использовать один раз при рисовании, да, костыль, но хотелось распихать по классам разные методы

        public SapperGame()
        {
            InitializeComponent();
            g = fuckingPanel.CreateGraphics();
        }//Просто начинает игру и задаёт графическую панель через объект класса Graphics 

        private void startGame_Click(object sender, EventArgs e)
        {
            ds = new SapperDrawing();
            countRow = Convert.ToInt32(width.Text);
            countColumn = Convert.ToInt32(length.Text);
            playingField = new Cells[countRow, countColumn];
            countMine = Convert.ToInt32(numberOfMine.Text);
            countFlag = 0;
            //this.ClientSize = new Size(cellSize * lengthField + 25, cellSize * widthField + 100);//Задаёт размер формы, надо бы как-то переделать, но пока что пофигу
            InitNewGameField();
            ShowField();
        }//Задаёт размер поля в клетках и кол-во мин на этом поле, а потом и размер самого поля в пикселях

        private void NewGameInitializationField()//Отчистка поля и создание клеток из массива клеток
        {
            for (int row = 0; row < countRow; row++)
                for (int col = 0; col < countColumn; col++)
                {
                    playingField[row, col] = new Cells(cellSize);//Вполне возможно, что тут конструктор лишний и можно просто обойтись удобной константой, но выделываться хочется
                }
        }

        private void InitNewGameField()//Создаёт мины на поле и задаёт кол-во мин вокруг каждой клетки с миной, изначально алгоритм был другим, но ну его нафиг
        {
            status = GameStatus.ON;//Задаём начальный статус игры

            NewGameInitializationField();//Очистка поля

            int row, col;// Индексы клеток, вспомогательные, для рандома
            int n = 0;// Счётчик кол-ва мин, поставленных на данный момент
            Random rnd = new Random();
            //Алгоритм такой: мы вставляем в рандомную клетку мину и прибавляем к счётчику кол-ва мин у каждой клетки вокруг
            do
            {
                row = rnd.Next(countRow);
                col = rnd.Next(countColumn);
                if (!playingField[row, col].MineInCell)
                {
                    playingField[row, col].MineInCell = true;
                    if (row != 0 && col != 0)
                    {
                        playingField[row - 1, col - 1].MineAround++;
                    }
                    if (row != 0)
                    {
                        playingField[row - 1, col].MineAround++;
                    }
                    if (row != 0 && col != countColumn - 1)
                    {
                        playingField[row - 1, col + 1].MineAround++;
                    }
                    if (col != 0)
                    {
                        playingField[row, col - 1].MineAround++;
                    }
                    if (col != countColumn - 1)
                    {
                        playingField[row, col + 1].MineAround++;
                    }
                    if (row != countRow - 1 && col != 0)
                    {
                        playingField[row + 1, col - 1].MineAround++;
                    }
                    if (row != countRow - 1)
                    {
                        playingField[row + 1, col].MineAround++;
                    }
                    if (row != countRow - 1 && col != countColumn - 1)
                    {
                        playingField[row + 1, col + 1].MineAround++;
                    }
                    n++;
                }
            } while (n != countMine);
        }

        private void ShowField()//Обычный цикл, заполняющий клетками всё поле
        {

            for (int row = 0; row < countRow; row++)
                for (int col = 0; col < countColumn; col++)
                    ds.DrawCell(g, row, col, playingField[row, col], status);
        }

        private void OpenCells(int row, int col)
        {

            if (playingField[row, col].MineInCell)//Если открытая клетка оказывается с миной - делает статус - проигрышем
            {
                status = GameStatus.FAIL;
                playingField[row, col].SellBackColor = Brushes.Red;
            }
            else
            {
                if (!playingField[row, col].OpenCell && playingField[row, col].MineAround == 0)//Если эта клетка не была ранее открыта и в ней 0 мин
                {

                    playingField[row, col].OpenTheCage();//Открывает клетку

                    //Открывает клетки сверху, снизу, справа, слева, и 4 клетки по диагонали, да, мне тоже не нравится 8 ифов, но идей нет, 3 часа ночи, и так рекурсия(чутка стырено)
                    if (col != 0) OpenCells(row, col - 1);//слева
                    if (row != 0) OpenCells(row - 1, col);//сверху
                    if (col != countRow - 1) OpenCells(row, col + 1);//справа
                    if (row != countColumn - 1) OpenCells(row + 1, col);//снизу
                    if (row != 0 && col != 0) OpenCells(row - 1, col - 1);//слева сверху
                    if (row != 0 && col != countRow - 1) OpenCells(row - 1, col + 1);//справа сверху
                    if (row != countColumn - 1 && col != 0) OpenCells(row + 1, col - 1);//слева снизу
                    if (row != countColumn - 1 && col != countRow - 1) OpenCells(row + 1, col + 1);//справа снизу
                }
                else if (!playingField[row, col].OpenCell && playingField[row, col].MineAround != 0)
                {
                    playingField[row, col].OpenTheCage();
                }
                    
            }
            ds.DrawCell(g, row, col, playingField[row, col], status);
        }

        private void fuckingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            //Игра завершена
            if (status == GameStatus.VICTORY || status == GameStatus.FAIL) return;//После завершения игры поле неактивно

            //Ну тут всё просто, деление для того, что бы получить номер клетки, типа 480 координата по вертикали и 200 по горизонтали превращаются в 12 строку и 5 столбец
            int row = e.Y / cellSize;//e.Y - это координата, в которую мы кликнули мышкой по вертикали
            int col = e.X / cellSize;//e.X - это координата, в которую мы кликнули мышкой по горизонтали

            // щелчок левой кнопки мыши
            if (e.Button == MouseButtons.Left && !playingField[row,col].FlagInCell)//Определяет, какая кнопка нажата, тут правая, топовая штука, msdn рулит, а ещё не даёт открывать клетки с флагами
            {
                OpenCells(row, col);
            }

            if (status == GameStatus.FAIL)
            {
                ShowField();
                MessageBox.Show("Флеймстрайки уйдут с арены!", "Лошара!");
            }
            // щелчок правой кнопки мыши
            if (e.Button == MouseButtons.Right)
            {
                if (!playingField[row, col].FlagInCell && !playingField[row, col].OpenCell)
                {
                    playingField[row, col].FlagInCell = true;
                    countFlag++;
                }
                else if (playingField[row, col].FlagInCell && !playingField[row, col].OpenCell)
                {
                    playingField[row, col].FlagInCell = false;
                    countFlag--;
                }
                    

                ds.DrawCell(g, row, col, playingField[row, col], status);
                if (CheckIfVictory())
                {
                    status = GameStatus.VICTORY;
                    MessageBox.Show("Иееее, нагиииб, пацаны!", "Победа!");
                }
            }
        }

        private bool CheckIfVictory()
        {
            int trueMine = 0;  // кол-во правильно найденных мин
            for (int row = 0; row < countRow; row++)
            {
                for (int col = 0; col < countColumn; col++)
                {
                    if (playingField[row, col].MineInCell && playingField[row, col].FlagInCell)
                    {
                        trueMine++;
                    }
                }
            }
            return (trueMine == countMine && countFlag == countMine);//Условие на одновременно кол-во правильно расставленных мин и на кол-во флагов равное кол-ву мин
        }
    }
}
