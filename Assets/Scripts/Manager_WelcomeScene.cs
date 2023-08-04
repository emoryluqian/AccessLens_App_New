using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager_WelcomeScene : MonoBehaviour
{
    public void Navigate_DetectionScene()
    {
        SceneManager.LoadScene("Scene_Detection", LoadSceneMode.Single);
    }

    private void Clear()
    {

    }
}
