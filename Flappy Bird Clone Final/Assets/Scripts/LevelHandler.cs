using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour
{
    public Button EasyButton, MediumButton, HardButton, IntroButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenIntroScene()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public void OpenEasyScene()
    {
        SceneManager.LoadScene("EasyScene");
    }

    public void OpenMediumScene()
    {
        SceneManager.LoadScene("MediumScene");
    }

    public void OpenHardScene()
    {
        SceneManager.LoadScene("HardScene");
    }
}
