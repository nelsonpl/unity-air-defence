using UnityEngine;
using Assets.Scripts.Entities;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Controller
{
    public class StatusController : MonoBehaviour
    {
        public Text TxtScore;
        public Text TxtScoreMax;
        public GameObject PanelGameOver;
        public GameObject PanelPause;
        public GameObject BtnPause;
        public GameObject BtnResume;
        public GameObject Life01Green;
        public GameObject Life02Green;
        public GameObject Life03Green;
        public GameObject Life01Red;
        public GameObject Life02Red;
        public GameObject Life03Red;
        private int _scoreMax;

        void Start()
        {
            Time.timeScale = 1;
            Statics.Lifes = Consts.QteLifes;
            Statics.Score = 0;
            Statics.EGameStatus = EGameStatus.Start;
            TxtScoreMax.text = DataBase.Score.ToString();
            _scoreMax = DataBase.Score;
        }

        void Update()
        {
            TxtScore.text = Statics.Score.ToString();
            if (Statics.Score > _scoreMax)
            {
                TxtScoreMax.text = Statics.Score.ToString();
            }

            switch (Statics.Lifes)
            {
                case 2:
                    Life01Green.SetActive(false);
                    Life01Red.SetActive(true);
                    break;
                case 1:
                    Life02Green.SetActive(false);
                    Life02Red.SetActive(true);
                    break;
                case 0:
                    Statics.EGameStatus = EGameStatus.GameOver;
                    break;
            }

            if (Statics.EGameStatus == EGameStatus.GameOver)
            {
                Life01Green.SetActive(false);
                Life03Green.SetActive(false);
                Life02Green.SetActive(false);

                Life01Red.SetActive(true);
                Life03Red.SetActive(true);
                Life02Red.SetActive(true);

                PanelGameOver.SetActive(true);
                if (Statics.Score > DataBase.Score)
                {
                    DataBase.Score = Statics.Score;
                }
            }
        }

        public void OnPauseAndResumeGame()
        {
            if (Time.timeScale == 0)
            {
                BtnPause.SetActive(true);
                PanelPause.SetActive(false);
                Time.timeScale = 1;
                Statics.EGameStatus = EGameStatus.Start;
            }
            else
            {
                BtnPause.SetActive(false);
                PanelPause.SetActive(true);
                Time.timeScale = 0;
                Statics.EGameStatus = EGameStatus.Pause;

            }
        }
    }
}
