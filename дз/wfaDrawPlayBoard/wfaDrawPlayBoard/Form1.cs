namespace wfaDrawPlayBoard
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            this.Text = "Выбор типа доски";
            this.Size = new Size(300, 150);

            Label label = new Label();
            label.Text = "Выберите тип доски:";
            label.Location = new Point(20, 20);

            boardTypeComboBox = new ComboBox();
            boardTypeComboBox.Items.AddRange(new string[] { "Игральная", "Шахматная" });
            boardTypeComboBox.Location = new Point(150, 20);

            drawBoardButton = new Button();
            drawBoardButton.Text = "Нарисовать доску";
            drawBoardButton.Location = new Point(100, 50);
            drawBoardButton.Click += DrawBoardButton_Click;

            this.Controls.Add(label);
        }

        private void DrawBoardButton_Click(object? sender, EventArgs e)
        {
            int cellSize = 50;
            int rows = 8;
            int columns = 8;

            if (boardTypeComboBox.SelectedItem.ToString() == "Игральная")
            {
                wfaDrawPlayBoard playBoard = new wfaDrawPlayBoard(cellSize, rows, columns, "игральная");
                playBoard.Show();
            }
            else if (boardTypeComboBox.SelectedItem.ToString() == "Шахматная")
            {
                wfaDrawPlayBoard chessBoard = new wfaDrawPlayBoard(cellSize, rows, columns, "шахматная");
                chessBoard.Show();
            }
        }
        public static void Main()
        {
            Application.Run(new Form1());
        }
    }
    public class wfaDrawPlayBoard : Form
    {
        private int cellSize;
        private int rows;
        private int columns;
        private string boardType;

        public wfaDrawPlayBoard(int cellSize, int rows, int columns, string boardType)
        {
            this.cellSize = cellSize;
            this.rows = rows;
            this.columns = columns;
            this.boardType = boardType;
            this.ClientSize = new Size(columns * cellSize, rows * cellSize);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            if (boardType == "игральная")
            {
                DrawCheckeredBoard(g, cellSize, rows, columns, Color.LightGray, Color.DarkGray);
            }
            else if (boardType == "шахматная")
            {
                DrawCheckeredBoard(g, cellSize, rows, columns, Color.Beige, Color.SaddleBrown);
            }
        }
        private void DrawCheckeredBoard(Graphics g, int cellSize, int rows, int columns, Color lightColor, Color darkColor)
        {
            Brush lightBrush = new SolidBrush(lightColor);
            Brush darkBrush = new SolidBrush(darkColor);

            bool darkCell = false;
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Rectangle rect = new Rectangle(column * cellSize, row * cellSize, cellSize, cellSize);
                    g.FillRectangle(darkCell ? darkBrush : lightBrush, rect);
                    darkCell = !darkCell;
                }
                darkCell = !darkCell;
            }
        }
    }
}
