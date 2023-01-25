namespace MemoryCardGame
{
    public partial class Main : Form
    {
        private List<Button> matrix;
        private int counttime = 0;
        public List<Button> Matrix { get => matrix; set => matrix = value; }
        private ManagerCardsBoard ManagerCardsBoard;
        public Main()
        {
            InitializeComponent();
            pnMain.Enabled = false;
            ManagerCardsBoard = new ManagerCardsBoard(pnMain,btnFlips,btnTime,time);
            Matrix = ManagerCardsBoard.Matrix;
            this.Show();
            Start start = new Start();
            start.StartGame += Start_StartGame;
            start.ShowDialog();
        }

        private void Start_StartGame(object? sender, EventArgs e)
        {
            btnRefresh_Click(sender, new EventArgs());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ManagerCardsBoard.DrawCardsBoard();
            ManagerCardsBoard.RandomImage();
            ManagerCardsBoard.SetImageDefault();
            pnMain.Enabled = true;
            counttime = 0;
            btnFlips.Text = $"Flips: 0";
            time.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnTime.Text = $"Times: {++counttime}s";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if((MessageBox.Show("B?n có mu?n thoát hay không?","Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK))
            {
                e.Cancel = true;
            }
        }
    }
}