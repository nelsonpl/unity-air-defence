using System;
using System.Collections.Generic;
using Assets.Scripts.Entities;
using UnityEngine;

namespace Assets.Scripts.Toolbox
{
    internal static class Utils
    {
        internal static Vector3 GetPosition(EPosition ePosition)
        {
            switch (ePosition)
            {
                case EPosition.LeftUp:
                    return new Vector3(-9, 2.5F);
                case EPosition.LeftCenter:
                    return new Vector3(-9, 0);
                case EPosition.LeftDown:
                    return new Vector3(-9, -2.5F);

                case EPosition.RightUp:
                    return new Vector3(9, 2.5F);
                case EPosition.RightCenter:
                    return new Vector3(9, 0);
                case EPosition.RightDown:
                    return new Vector3(9, -2.5F);

                case EPosition.DownLeftBorder:
                    return new Vector3(-5, -6);
                case EPosition.DownLeft:
                    return new Vector3(-2.5F, -6);
                case EPosition.DownCenter:
                    return new Vector3(0, -6);
                case EPosition.DownRight:
                    return new Vector3(2.5F, -6);
                case EPosition.DownRightBorder:
                    return new Vector3(5, -6);

                case EPosition.UpLeftBorder:
                    return new Vector3(-5, 6);
                case EPosition.UpLeft:
                    return new Vector3(-2.5F, 6);
                case EPosition.UpCenter:
                    return new Vector3(0, 6);
                case EPosition.UpRight:
                    return new Vector3(2.5F, 6);
                case EPosition.UpRightBorder:
                    return new Vector3(5, 6);
            }
            return new Vector3();
        }

        internal static List<EPosition> EPositionList()
        {
            return new List<EPosition>
            {
                EPosition.DownLeftBorder,
                EPosition.DownLeft,
                EPosition.DownCenter,
                EPosition.DownRight,
                EPosition.DownRightBorder,

                EPosition.UpLeftBorder,
                EPosition.UpLeft,
                EPosition.UpCenter,
                EPosition.UpRight,
                EPosition.UpRightBorder,

                EPosition.LeftUp,
                EPosition.LeftCenter,
                EPosition.LeftDown,

                EPosition.RightUp,
                EPosition.RightCenter,
                EPosition.RightDown
            };
        }

        internal static List<EVelocity> EVelocityList()
        {
            return new List<EVelocity>
            {
                EVelocity.Slow,
                EVelocity.Normal,
                EVelocity.Fast,
                EVelocity.SuperFast
            };
        }

        internal static List<EShapeType> EShapeTypeList()
        {
            return new List<EShapeType>
            {
                EShapeType.Warplanes,
                EShapeType.Bomb,
                EShapeType.CommercialAirplane
            };
        }

        internal static Vector3 GetRotate(EPosition ePosition)
        {
            switch (ePosition)
            {
                case EPosition.LeftUp:
                case EPosition.LeftCenter:
                case EPosition.LeftDown:
                    return new Vector3(0, 0, 270);

                case EPosition.RightUp:
                case EPosition.RightCenter:
                case EPosition.RightDown:
                    return new Vector3(0, 0, 90);

                case EPosition.DownLeftBorder:
                case EPosition.DownLeft:
                case EPosition.DownCenter:
                case EPosition.DownRight:
                case EPosition.DownRightBorder:
                    return new Vector3(0, 0, 0);

                case EPosition.UpLeftBorder:
                case EPosition.UpLeft:
                case EPosition.UpCenter:
                case EPosition.UpRight:
                case EPosition.UpRightBorder:
                    return new Vector3(0, 0, 180);
            }
            return new Vector3();
        }

        internal static Vector2 GetVelocity(EPosition ePosition, EVelocity eVelocity)
        {
            switch (ePosition)
            {
                case EPosition.LeftUp:
                case EPosition.LeftCenter:
                case EPosition.LeftDown:
                    return new Vector2(GetVelocity(eVelocity), 0);

                case EPosition.RightUp:
                case EPosition.RightCenter:
                case EPosition.RightDown:
                    return new Vector2(-GetVelocity(eVelocity), 0);

                case EPosition.DownLeftBorder:
                case EPosition.DownLeft:
                case EPosition.DownCenter:
                case EPosition.DownRight:
                case EPosition.DownRightBorder:
                    return new Vector2(0, GetVelocity(eVelocity));

                case EPosition.UpLeftBorder:
                case EPosition.UpLeft:
                case EPosition.UpCenter:
                case EPosition.UpRight:
                case EPosition.UpRightBorder:
                    return new Vector2(0, -GetVelocity(eVelocity));
            }
            return new Vector2();
        }

        public static void MakeSound(AudioClip clip, Vector3 position)
        {
            AudioSource.PlayClipAtPoint(clip, position);
        }

        private static float GetVelocity(EVelocity eVelocity)
        {
            switch (eVelocity)
            {
                case EVelocity.Slow:
                    return 4f;
                case EVelocity.Normal:
                    return 4.5f;
                case EVelocity.Fast:
                    return 6f;
                case EVelocity.SuperFast:
                default:
                    return 8f;
            }
        }
    }
}
