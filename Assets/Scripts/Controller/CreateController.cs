using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Entities;
using System.Linq;
using Assets.Scripts.Manager;
using Assets.Scripts.Toolbox;

namespace Assets.Scripts.Controller
{
    public class CreateController : MonoBehaviour
    {
        private int _qteShapes;
        private RulesManager _ruleManager;
        private readonly System.Random _random = new System.Random();
        private static CreateController _instance;

        public List<GameObject> PrefabAircrafts;
        public List<GameObject> PrefabAirplaneCommercials;
        public List<GameObject> PrefabBombs;
        public static CreateController Instance { get { return _instance; } }

        void Start()
        {
            _ruleManager = new RulesManager();
            StartCoroutine(WaitAndCreateOneAirplane());
        }

        void Update()
        {
        }

        void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(this.gameObject);
                return;
            }
            else
            {
                _instance = this;
            }
            //DontDestroyOnLoad(gameObject);
        }

        IEnumerator WaitAndCreateOneAirplane()
        {
            yield return new WaitForSeconds(_ruleManager.Time);
            var config = _ruleManager.GetRule();

            _qteShapes = config.Shapes.Sum(x => x.Count);

            foreach (var shapes in config.Shapes)
            {
                foreach (var item in shapes)
                {
                    GameObject go;
                    int indexShape;
                    switch (item.EType)
                    {
                        case EShapeType.CommercialAirplane:
                            indexShape = _random.Next(PrefabAirplaneCommercials.Count - 1);
                            go = PrefabAirplaneCommercials[indexShape];
                            break;
                        case EShapeType.Bomb:
                            indexShape = _random.Next(PrefabBombs.Count - 1);
                            go = PrefabBombs[indexShape];
                            break;
                        default:
                            indexShape = _random.Next(PrefabAircrafts.Count - 1);
                            go = PrefabAircrafts[indexShape];
                            break;
                    }

                    var shapeInstantiate = Instantiate(go);
                    shapeInstantiate.ToFly(item.EPosition, item.EVelocity);
                }
                // utilizado para identificar a regra que esta sendo executada
                //print(config.Tag);
                yield return new WaitForSeconds(config.Time);
            }
        }

        public void RemoveShapes()
        {
            _qteShapes--;

            if (_qteShapes == 0 && Statics.EGameStatus == EGameStatus.Start)
            {
                StartCoroutine(WaitAndCreateOneAirplane());
            }
        }
    }
}
