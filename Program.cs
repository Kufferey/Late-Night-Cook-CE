using System.Numerics;
using Raylib_cs;
using SeventySevenC;
using static Raylib_cs.Raylib;

public class Program
{
    static void Main()
    {
        // GameData.WindowSize = new Vector2(GetMonitorWidth(GetCurrentMonitor()), GetMonitorHeight(GetCurrentMonitor()));
        InitWindow((int)GameData.WindowSize.X, (int)GameData.WindowSize.Y, GameData.WindowName);

        SetWindowState(ConfigFlags.ResizableWindow);
        // SetWindowState(ConfigFlags.FullscreenMode);
        // InitAudioDevice();

        SceneBase.CurrentScene = new SMainMenu();

        SetTargetFPS(60);

        while (!WindowShouldClose())
        {
            BeginDrawing();
            ClearBackground(Color.Black);

            GameData.WindowSize = new Vector2(GetScreenWidth(), GetScreenHeight());

            SceneBase.CurrentScene?.SceneUpdate(GetFrameTime());
            SceneBase.CurrentScene?.SceneDraw(GetFrameTime());

            EndDrawing();
        }

        SceneBase.CurrentScene?.SceneExit();

        CloseWindow();
    }
}