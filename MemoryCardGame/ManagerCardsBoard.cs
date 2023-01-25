using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCardGame
{
    public class ManagerCardsBoard
    {
        private List<Button> matrix;
        private Panel cardsBoard;
        private Button btnFlips;
        private int flip;
        private int Score = 0;
        private List<Image> images;
        private Stack<Button> cards;
        private Stack<Button> tempCards;
        private System.Windows.Forms.Timer timer;
        public List<Button> Matrix { get => matrix; set => matrix = value; }
        public Panel CardsBoard { get => cardsBoard; set => cardsBoard = value; }
        public List<Image> Images { get => images; set => images = value; }
        public Stack<Button> Cards { get => cards; set => cards = value; }
        public Button BtnFlips { get => btnFlips; set => btnFlips = value; }
        public Stack<Button> TempCards { get => tempCards; set => tempCards = value; }
        public System.Windows.Forms.Timer Timer { get => timer; set => timer = value; }

        public ManagerCardsBoard(Panel panel,Button btnFlips,Button btnTimes,System.Windows.Forms.Timer timer)
        {
            this.CardsBoard = panel;
            this.BtnFlips = btnFlips;
            this.Timer = timer;
            DrawCardsBoard();
            RandomImage();
        }
        public void DrawCardsBoard()
        {
            flip = 0;
            Cards = new Stack<Button>();
            TempCards= new Stack<Button>();
            Matrix = new List<Button>();
            CardsBoard.Controls.Clear();
            {
            for (int i = 0; i < Const.CardsBoard_Heigth; i++)
                for (int j = 0; j < Const.CardsBoard_With; j++)
                {
                    Button btn = new Button();
                    btn.Width = Const.WithCard;
                    btn.Height = Const.HeigthCard;
                    btn.Location = new Point( j*Const.HeigthCard+j*25,i * Const.WithCard + i * 25);
                    btn.Tag = i*Const.CardsBoard_With + j;
                    btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\default.png");
                    btn.BackgroundImageLayout = ImageLayout.Center;
                    btn.Click += Btn_Click;
                    CardsBoard.Controls.Add(btn);
                    Matrix.Add(btn);
                }
            }
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            
            CheckCard(sender as Button);
        }
        public void RandomImage()
        {
            Images = new List<Image>();
            for (int i = 0; i < 24; i++)
            {
                int temp = i % 12;
                string path = Application.StartupPath + string.Format("\\Resources\\Card\\{0}.png", i%12);
                Image img = Image.FromFile(path); 
                img.Tag = temp;
                Images.Add(img);
            }
            Random rd = new Random();
            Images = Images.OrderBy(x => rd.Next()).ToList();
        }
        public void SetImageDefault()
        {
            foreach(Button btn in Matrix)
            {
                btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\default.png");
            }
        }
        public void SetImageDefault(Button btn)
        {
                btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\default.png");
        }
        void CheckCard(Button sender)
        {
            if (TempCards.Count == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    TempCards.Peek().Enabled = true;
                    SetImageDefault(TempCards.Pop());
                }
            }
            UpdateFlips(++flip);
            Button? btn = sender as Button;
            btn.Enabled = false;
            Cards.Push(btn);
            btn.BackgroundImage = Images[(int)btn.Tag];
            if (Cards.Count == 2)
            {
                var newbtn = Cards.Pop();
                var oldbtn = Cards.Pop();
                if (oldbtn.BackgroundImage.Tag.ToString().Equals(newbtn.BackgroundImage.Tag.ToString()))
                {
                    oldbtn.Enabled = false;
                    newbtn.Enabled = false;
                    ++Score;
                }
                else
                {
                    TempCards.Push(newbtn);
                    TempCards.Push(oldbtn);
                }
            }
            CheckEndGame(Score);
        }
        void UpdateFlips(int flip)
        {
            BtnFlips.Text = $"Flips: {flip}";
        }
        void CheckEndGame(int Score)
        {
            if (Score == 12)
            {
                MessageBox.Show("Bạn đã giành chiến thắng","Thông báo",MessageBoxButtons.OK);
                Timer.Stop();
            }
        }
    }
}
