namespace Assets.Scripts.Entities
{
    public enum EGameStatus
    {
        Empty,
        Start,
        Pause,
        GameOver
    }

    public enum EPosition
    {
        Empty,
        LeftUp,
        LeftCenter,
        LeftDown,
        RightUp,
        RightCenter,
        RightDown,
        DownLeftBorder,
        DownLeft,
        DownCenter,
        DownRight,
        DownRightBorder,
        UpLeftBorder,
        UpLeft,
        UpCenter,
        UpRight,
        UpRightBorder
    }

    public enum EShapeType
    {
        Empty,
        CommercialAirplane,
        Warplanes,
        Bomb
    }

    public enum EVelocity
    {
        Empty,
        Slow,
        Normal,
        Fast,
        SuperFast
    }
}
