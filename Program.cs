using Raylib_cs;

Raylib.InitWindow(800, 480, "Greed");

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    Raylib.DrawText("Hello, world!", 0, 0, 40, Color.BLACK);
    if(Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
    {
        Raylib.DrawCircleV(Raylib.GetMousePosition(),10,Color.BLUE);
    }
    Raylib.EndDrawing();
}

Raylib.CloseWindow();