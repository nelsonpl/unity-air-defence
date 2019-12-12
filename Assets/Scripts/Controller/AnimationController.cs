using Assets.Scripts.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Assets.Scripts.Toolbox;

namespace Assets.Scripts.Controller
{
    public class AnimationController : MonoBehaviour
    {
        private static AnimationController _instance;
        public static AnimationController Instance { get { return _instance; } }
        public GameObject Explosion;
        public AudioClip ExplosionSound;

        private List<GameObject> _explosions = new List<GameObject>();

        void Start()
        {
            InvokeRepeating("ClearExplosions", 5, 5);
        }

        internal void ExecuteExplosion(Vector3 position)
        {
            var explosion = Instantiate(Explosion);
            explosion.transform.position = position;
            Utils.MakeSound(ExplosionSound, position);
            _explosions.Add(explosion);
        }

        void ClearExplosions()
        {
            _explosions.Where(x => x != null).ToList().ForEach(Destroy);
            _explosions = new List<GameObject>();
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
            //DontDestroyOnLoad(this.gameObject);
        }
    }
}