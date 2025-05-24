namespace SeventySevenC;

public abstract class SceneBase : BaseObject
{

    public static Scene? CurrentScene { get; set; }

    public  abstract void SceneStart();
    public abstract void SceneChange(Scene from, Scene to);
    public abstract void SceneExit();
    public abstract void SceneUpdate(double delta);
    public abstract void SceneDraw(double delta);
}