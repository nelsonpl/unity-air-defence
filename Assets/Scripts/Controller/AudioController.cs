using Assets.Scripts.Entities;
using UnityEngine;

namespace Assets.Scripts.Controller
{
    public class AudioController : MonoBehaviour
    {
        public GameObject BtnSoundOn;
        public GameObject BtnSoundOff;

        void Start()
        {
            if (DataBase.Sound.Equals(0))
            {
                BtnSoundOn.SetActive(false);
                BtnSoundOff.SetActive(true);
                AudioListener.volume = 0;
            }
            else
            {
                AudioListener.volume = 1;
                BtnSoundOn.SetActive(true);
                BtnSoundOff.SetActive(false);
            }
        }

        public void SoundToggle()
        {
            if (DataBase.Sound.Equals(0))
            {
                AudioListener.volume = 1;
                DataBase.Sound = 1;
                BtnSoundOn.SetActive(true);
                BtnSoundOff.SetActive(false);
            }
            else
            {
                AudioListener.volume = 0;
                DataBase.Sound = 0;
                BtnSoundOn.SetActive(false);
                BtnSoundOff.SetActive(true);
            }
        }
    }
}
