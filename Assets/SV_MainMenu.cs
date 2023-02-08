using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SV_MainMenu : MonoBehaviour
{

    public void PlayNowButton()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
