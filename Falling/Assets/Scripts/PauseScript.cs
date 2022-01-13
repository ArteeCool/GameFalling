using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject PauseMenu;
    public void PauseOn()
    {
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
    }
    public void PauseOff()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }
}
