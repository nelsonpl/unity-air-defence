using System;
using System.Linq;
using Assets.Scripts.Entities;
using UnityEngine;

namespace Assets.Scripts.Controller
{
    public class DestroyController : MonoBehaviour
    {
        public EShapeType Type;
        private bool _isMouseDown;

        void OnMouseDown()
        {
            if (Type == EShapeType.Warplanes)
            {
                // Derruba os aviões que estiverem na mesma posição ou bem próximos
                foreach (var destroyShapeCtrl in FindObjectsOfType<DestroyController>().Where(x => x != this && Vector3.Distance(transform.position, x.transform.position) <= Consts.DistanceDestroy))
                {
                    Statics.Score += Consts.ScoreSpecial;
                    destroyShapeCtrl.DestroyAirplane();
                }
            }

            DestroyAirplane();
        }

        public void DestroyAirplane()
        {
            if (Statics.EGameStatus != EGameStatus.Start)
            {
                return;
            }

            switch (Type)
            {
                case EShapeType.CommercialAirplane:
                    Statics.EGameStatus = EGameStatus.GameOver;
                    break;
                case EShapeType.Warplanes:
                    Statics.Score++;

                    break;
                case EShapeType.Bomb:
                    // Procura todos os shapes instanciados diferentes do atual, destroi os encontrados
                    foreach (var onMouseDownCtrl in FindObjectsOfType<DestroyController>().Where(x => x != this))
                    {
                        onMouseDownCtrl.DestroyAirplane();
                    }
                    break;
            }

            //var explosionAnimationSoundCtrl = GetComponent<ExplosionAnimationSoundController>();
            AnimationController.Instance.ExecuteExplosion(transform.position);

            _isMouseDown = true;
            CreateController.Instance.RemoveShapes();
            Destroy(gameObject);
        }

        void OnBecameInvisible()
        {
            if (!_isMouseDown)
            {
                // Se o avião de guerra sair da tela deve remover uma vida
                if (Type.Equals(EShapeType.Warplanes))
                {
                    Statics.Lifes--;
                }
                CreateController.Instance.RemoveShapes();
                Destroy(gameObject);
            }
        }
    }
}