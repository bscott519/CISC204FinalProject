using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelHandler : MonoBehaviour
{
    public Button EasyButton, MediumButton, HardButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenEasyScene()
    {
        SceneManager.LoadScene("EasyLevel");
    }

    public void OpenMediumScene()
    {
        SceneManager.LoadScene("BaseLevel");
    }

    public void OpenHardScene()
    {
        SceneManager.LoadScene("HardLevel");
    }
}
