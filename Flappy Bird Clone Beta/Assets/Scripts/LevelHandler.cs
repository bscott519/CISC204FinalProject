using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
