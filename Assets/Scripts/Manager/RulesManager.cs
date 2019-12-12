using System;
using System.Collections.Generic;
using Assets.Scripts.Entities;
using System.Linq;

namespace Assets.Scripts.Manager
{
    internal class RulesManager
    {
        public float Time { get; set; }

        private readonly List<Rule> _ruleList;
        private readonly List<Rule> _ruleIntroList;

        private int _index;

        public RulesManager()
        {
            Time = 2;
            _ruleList = new List<Rule>
            {
                #region EASY
                new Rule
                {
                    Time = 1,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownRight, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownLeft, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        }
                    }
                },
                new Rule
                {
                    Time = 1,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.LeftUp, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.LeftDown, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        }
                    }
                },
                new Rule
                {
                    Time = 1,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.RightUp, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.RightDown, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        }
                    }
                },
                new Rule
                {
                    Time = 1,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpRight, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.UpCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.UpLeft, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        }
                    }
                },
                #endregion
                #region NORMAL
                new Rule
                {
                    Time = .75f,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.UpCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightUp, EVelocity = EVelocity.Normal, EType = EShapeType.CommercialAirplane},
                        },
                    }
                },
                new Rule
                {
                    Time = .75f,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownLeftBorder, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownLeft, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownCenter, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownRight, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownRightBorder, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftDown, EVelocity = EVelocity.Slow, EType = EShapeType.CommercialAirplane},
                        },
                    }
                },
                new Rule
                {
                    Time = .75f,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Slow, EType = EShapeType.CommercialAirplane},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.LeftDown, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.LeftUp, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftDown, EVelocity = EVelocity.Fast, EType = EShapeType.CommercialAirplane},
                        },
                    }
                },
                #endregion
                #region HARD
                new Rule
                {
                    Time = .5f,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpLeft, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownRight, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpCenter, EVelocity = EVelocity.Fast, EType = EShapeType.CommercialAirplane},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownLeft, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpRight, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpLeft, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                        },
                    }
                },
                new Rule
                {
                    Time = .5f,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightUp, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.RightDown, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightUp, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.RightDown, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightUp, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.RightDown, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                        },
                    }
                },
                new Rule
                {
                    Time = .5f,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownLeftBorder, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownCenter, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownRightBorder, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftUp, EVelocity = EVelocity.Slow, EType = EShapeType.CommercialAirplane},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpLeft, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownCenter, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.UpRight, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightDown, EVelocity = EVelocity.Slow, EType = EShapeType.CommercialAirplane},
                        },
                    }
                },
                #endregion
                #region EASY
                 new Rule
                {
                    Time = 1f,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpLeftBorder, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.UpLeft, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.UpCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownRight, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownRightBorder, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.DownCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                    }
                },
                 new Rule
                {
                    Time = 1f,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpCenter, EVelocity = EVelocity.Normal, EType = EShapeType.CommercialAirplane},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftUp, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.RightDown, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                    }
                },
                 new Rule
                {
                    Time = 1f,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpLeftBorder, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpLeft, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Normal, EType = EShapeType.CommercialAirplane},
                            new Shape {EPosition = EPosition.UpCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpRight, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpRightBorder, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                    }
                },
                #endregion
                #region SUPERHARD
                  new Rule
                {
                    Time = .25f,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpRight, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.UpRightBorder, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.UpCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftDown, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                            new Shape {EPosition = EPosition.LeftUp, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownCenter, EVelocity = EVelocity.Slow, EType = EShapeType.CommercialAirplane},
                        },
                    }
                },
                  new Rule
                {
                    Time = .25f,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpLeft, EVelocity = EVelocity.Slow, EType = EShapeType.CommercialAirplane},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownLeftBorder, EVelocity = EVelocity.Slow, EType = EShapeType.CommercialAirplane},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.SuperFast, EType = EShapeType.Warplanes},
                        },
                        //
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpRight, EVelocity = EVelocity.Slow, EType = EShapeType.CommercialAirplane},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownRightBorder, EVelocity = EVelocity.Slow, EType = EShapeType.CommercialAirplane},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.Fast, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.SuperFast, EType = EShapeType.Warplanes},
                        },
                    }
                },
                  new Rule
                {
                    Time = .25f,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpRightBorder, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpRight, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpCenter, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpLeft, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.UpLeftBorder, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftUp, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftCenter, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.LeftDown, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownLeftBorder, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownLeft, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownCenter, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownRight, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownRightBorder, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightDown, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightCenter, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.RightUp, EVelocity = EVelocity.Normal, EType = EShapeType.Warplanes},
                        },
                    }
                },
                #endregion
            };

            _ruleIntroList = new List<Rule>
            {
                #region INTRO
                new Rule
                {
                    Time = 1,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownLeft, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        }
                    }
                },
                new Rule
                {
                    Time = 1,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownCenter, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        }
                    }
                },
                new Rule
                {
                    Time = 1,
                    Shapes = new List<List<Shape>>
                    {
                        new List<Shape>
                        {
                            new Shape {EPosition = EPosition.DownRight, EVelocity = EVelocity.Slow, EType = EShapeType.Warplanes},
                        }
                    }
                },
                #endregion
            };
        }

        public Rule GetRule()
        {
            if (_ruleIntroList.Any())
            {
                var intro = _ruleIntroList.FirstOrDefault();
                _ruleIntroList.Remove(intro);
                return intro;
            }
            var config = _ruleList[_index];
            _index++;
            if (_index == _ruleList.Count)
            {
                _index = 0;
            }
            return config;
        }

    }
}