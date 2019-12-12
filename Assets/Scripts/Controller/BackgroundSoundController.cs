using UnityEngine;

namespace Assets.Scripts.Controller
{
    public class BackgroundSoundController : MonoBehaviour
    {
        private static BackgroundSoundController _instance;
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
            DontDestroyOnLoad(gameObject);
        }
    }
}
