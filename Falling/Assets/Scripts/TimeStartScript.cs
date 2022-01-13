using UnityEngine.SceneManagement;
using UnityEngine;


public class TimeStartScript : MonoBehaviour
{
    public GameObject ButtonAgain;
    public string Level;
    public void PauseOff()
    {
        Time.timeScale = 1f;
        ButtonAgain.SetActive(false);
        SceneManager.LoadScene(Level);
    }

    public void ClearBS()
    {
        
       GameCore.Instance.ClearBestScore();
 
    }
}
