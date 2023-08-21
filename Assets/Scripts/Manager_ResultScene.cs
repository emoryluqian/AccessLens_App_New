using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager_ResultScene : MonoBehaviour
{
    public GameObject Panel_Summary;    // Summary View
    public GameObject Panel_Suggestion; // Suggestion View
    public GameObject Panel_3DPrint;    // Detailed 3D-printed Augmentation Object View 
    public GameObject Panel_Restart;

    #region Panel_Restart

    public void EnableRestartPanel()
    {
        Panel_Restart.SetActive(true);
    }

    public void DisableRestartPanel()
    {
        Panel_Restart.SetActive(false);
    }

    public void ConfirmRestart()
    {
        SceneManager.LoadScene("Scene_Detection", LoadSceneMode.Single);
    }

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
