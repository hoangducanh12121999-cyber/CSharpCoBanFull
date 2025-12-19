

using System;
using System.Diagnostics;
using System.Drawing;

public class Program
{   
    // Khởi tạo kích thước khung chơi
    const int width = 40;
    const int height = 20;

    // Khởi tạo rắn và tường 
    const char wallChar = '#';
    const char headChar = 'O';
    const char bodyChar = 'o';
    const char foodChar = '*';

    // Tốc độ di chuyển của rắn (giảm để tăng tốc)
    static int speed = 120;

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.CursorVisible = false; // Ẩn con trỏ
        LoadHighScore(); // Tải highscore từ file
        while (currentState != AppState.GameOver)
        {
            if (currentState == AppState.MainMenu)
            {
                ShowMenu();
            }
            else if (currentState == AppState.Playing)
            {
                InitializeGame();
                GameLoop();
            }
        }
    }

    // Hướng di chuyển
    static class Direction
    {
        public const int Up = 0;
        public const int Down = 1;
        public const int Left = 2;
        public const int Right = 3;
    }

    // Trạng thái trò chơi
    static int direction = Direction.Right;
    static LinkedList<Point> snake = new LinkedList<Point>();
    static Point food;
    static bool hasFood = false;
    static Random rand = new Random();

    static int score = 0;
    static bool gameOver = false;
    static bool paused = false;

    // Trạng thái ứng dụng
    enum AppState
    {
        MainMenu,
        Playing,
        GameOver
    }
    static AppState currentState = AppState.MainMenu;

    static int highscore = 0;
    static string highScoreFile = "highscore.txt";

    // Hiển thị menu chính
    static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("~~~ RẮN SĂN MỒI ~~~");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("1. Bắt đầu");
        Console.WriteLine("2. Hướng dẫn");
        Console.WriteLine("Esc. Thoát");
        Console.WriteLine();
        Console.WriteLine($"Highscore: {highscore}");

        while (true)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
            {
                currentState = AppState.Playing;
                return;
            }
            else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
            {
                ShowInstructions();
                Console.WriteLine("Nhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey(true);
                break;
            }
            else if (key == ConsoleKey.Escape)
            {
                currentState = AppState.GameOver;
                return;
            }
        }
    }

    // Hiển thị hướng dẫn chơi
    static void ShowInstructions()
    {
        Console.Clear();
        Console.WriteLine("~~~ HƯỚNG DẪN ~~~");
        Console.WriteLine("Điều khiển: Phím mũi tên");
        Console.WriteLine("P: Tạm dừng");
        Console.WriteLine("R: Khởi động lại khi đang chơi");
        Console.WriteLine("Esc: Trở về menu / thoát");
    }

    // Khởi tạo trò chơi
    static void InitializeGame()
    {
        Console.Clear();
        snake.Clear();
        score = 0;
        direction = Direction.Right;
        paused = false;
        gameOver = false;
        speed = 120;

        int sx = width / 2;
        int sy = height / 2;
        snake.AddFirst(new Point(sx, sy));
        snake.AddLast(new Point(sx - 1, sy));
        snake.AddLast(new Point(sx - 2, sy));

        SpawnFood();
    }

    // Tạo thức ăn ở vị trí ngẫu nhiên không trùng với rắn
    static void SpawnFood()
    {
        int x, y;
        do
        {
            x = rand.Next(1, width - 1);
            y = rand.Next(1, height - 1);
        } while (IsPointOnSnake(x, y));
        food = new Point(x, y);
        hasFood = true;
    }

    // Kiểm tra điểm có trùng với rắn không
    static bool IsPointOnSnake(int x, int y)
    {
        foreach (var segment in snake)
        {
            if (segment.X == x && segment.Y == y)
                return true;
        }
        return false;
    }

    // Vòng lặp trò chơi chính
    static void GameLoop()
    {
        var timeSpeed = new Stopwatch();
        timeSpeed.Start();

        while (!gameOver && currentState == AppState.Playing)
        {
            long frameStart = timeSpeed.ElapsedMilliseconds;

            HandleInput();

            if (!paused)
            {
                Update();    
            }

            Draw();

            long frameTime = timeSpeed.ElapsedMilliseconds - frameStart;
            int delay = Math.Max(1, speed - (int)frameTime);
            System.Threading.Thread.Sleep(delay);
        }

        Console.SetCursorPosition(0, height + 2);
        Console.WriteLine("=== GAME OVER ===");
        Console.WriteLine();
        Console.WriteLine($"Điểm: {score}   Highscore: {highscore}");
        if (score > highscore)
        {
            highscore = score;
            SaveHighScore();
            Console.WriteLine("Chúc mừng! Bạn có highscore mới!");
        }
        Console.WriteLine("Nhấn R để chơi lại, M để về Menu, Esc để thoát...");
    }

    public static void SaveHighScore()
    {
        // Lưu highscore vào file, dùng try-catch để tránh lỗi khi có vấn đề với file
        try
        {
            System.IO.File.WriteAllText(highScoreFile, highscore.ToString());
        }
        catch
        {
            // Ignore file write errors
        }
    }

    public static void LoadHighScore()
    {
        // Đọc highscore từ file, dùng try-catch để tránh lỗi khi file không tồn tại hoặc có vấn đề
        try
        {
            if (System.IO.File.Exists(highScoreFile)) // Kiểm tra file có tồn tại không
            {
                string content = System.IO.File.ReadAllText(highScoreFile); // Đọc nội dung file
                int hs;
                if (int.TryParse(content, out hs)) // Chuyển đổi nội dung sang số nguyên
                {
                    highscore = hs;
                }
            }
        }
        catch
        {
            // Ignore file read errors
        }
    }

    // Xử lý nhập từ bàn phím
    public static void HandleInput()
    {
        while (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (direction != Direction.Down)
                        direction = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    if (direction != Direction.Up)
                        direction = Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    if (direction != Direction.Right)
                        direction = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    if (direction != Direction.Left)
                        direction = Direction.Right;
                    break;
                case ConsoleKey.Escape:
                    currentState = AppState.MainMenu;
                    gameOver = true;
                    return; // thoát ngay khỏi hàm
            }
        }
    }

    // Cập nhật trạng thái trò chơi, di chuyển rắn, kiểm tra va chạm, ăn mồi
    public static void Update()
    {
        // Cập nhật vị trí rắn
        var head = snake.First.Value; // Lấy đầu rắn, tạo biến mới để tính toán vị trí mới
        int newX = head.X;
        int newY = head.Y;

        // Cập nhật theo hướng di chuyển
        switch (direction)
        {
            case Direction.Up:
                newY--;
                break;
            case Direction.Down:
                newY++;
                break;
            case Direction.Left:
                newX--;
                break;
            case Direction.Right:
                newX++;
                break;
        }

        // Tạo điểm mới cho đầu rắn
        Point newHead = new Point(newX, newY);

        // Kiểm tra va chạm với tường
        if (newX == 0)
            newX = width - 2;
        else if (newX == width - 1)
            newX = 1;
        else if (newY == 0)
            newY = height - 2;
        else if (newY == height - 1)
            newY = 1;

        // Kiểm tra va chạm với thức ăn và chính nó
        bool ateFood = hasFood && newHead.Equals(food);
        if (!ateFood) // Không ăn mồi thì di chuyển bình thường: thêm đầu mới, bỏ đuôi
        {
            snake.AddFirst(newHead);
            snake.RemoveLast();
        }
        else  // Ăn mồi thì chỉ thêm đầu mới, không bỏ đuôi, tăng điểm và tạo mồi mới
        {
            {
                snake.AddFirst(newHead);
                score++;
                hasFood = false;
                SpawnFood();
                if (speed > 10)
                    speed -= 5; // Tăng tốc độ khi ăn mồi
            }
        }
        // Kiểm tra va chạm với chính nó 
        int i = 0;
        foreach (var segment in snake)
        {
            if (i > 0 && segment.Equals(newHead)) // Bỏ qua đầu rắn khi kiểm tra va chạm 
            {
                gameOver = true;
                currentState = AppState.GameOver;
                break;
            }
            i++;
        }
    }

    // Vẽ khung chơi, rắn và thức ăn
    public static void Draw()
    {
        // Vẽ khung chơi 
        Console.SetCursorPosition(0, 0);
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (y == 0 || y == height - 1 || x == 0 || x == width - 1)
                {
                    Console.Write(wallChar); // Vẽ tường
                }
                else if (hasFood && x == food.X && y == food.Y)
                {
                    Console.Write(foodChar); // Vẽ thức ăn
                }
                else
                {
                    bool isSnakePart = false; // Kiểm tra xem có phải phần của rắn không
                    int i = 0;
                    foreach (var segment in snake)
                    {
                        if (segment.X == x && segment.Y == y)
                        {
                            Console.Write(i == 0 ? headChar : bodyChar); // Vẽ rắn
                            isSnakePart = true;
                            break;
                        }
                        i++;
                    }
                    if (!isSnakePart) // Nếu không phải phần của rắn
                    {
                        Console.Write(' '); // Vẽ khoảng trống
                    }
                }
            }
            Console.WriteLine(); // Xuống dòng sau mỗi hàng
        }
    }



}