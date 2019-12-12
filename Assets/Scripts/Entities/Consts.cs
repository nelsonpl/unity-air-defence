using System.Collections.Generic;
using Assets.Scripts.Toolbox;

namespace Assets.Scripts.Entities
{
    internal static class Consts
    {
        public const string SceneGameExecuteName = "Execute";
        public const string SceneGameMainName = "Main";
        public const int TimeWaitAndCreateAllAirplane = 2;
        public const int QteLifes = 3;
        public const int ScoreSpecial = 10;
        public const float TimeWaitAndCreateOneAirplane = 0.25f;
        public const float DistanceDestroy = 0.5f;

        public static List<EPosition> EPositions = Utils.EPositionList();

    }
}
