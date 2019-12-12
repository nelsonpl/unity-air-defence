using Assets.Scripts.Entities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Controller
{
    public class SceneController : MonoBehaviour
    {
        public void OnGoGameExecute()
        {
            SceneManager.LoadScene(Consts.SceneGameExecuteName);
        }
        public void OnGoGameMain()
        {
            SceneManager.LoadScene(Consts.SceneGameMainName);
        }
    }
}
