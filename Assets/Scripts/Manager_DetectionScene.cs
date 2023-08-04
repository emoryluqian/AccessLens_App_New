using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class Manager_DetectionScene : MonoBehaviour
{
    public GameObject Panel_Album;
    public GameObject Panel_Preview;
    public GameObject Panel_Loading;

    public static HashSet<string> InputImages;
    public static DirectoryInfo ResourcesDirect => new DirectoryInfo($@"Assets/Resources");
    public const string ImagePathsFile = "Input Image Paths.txt";
    public static string ImagePathsFilePath => $@"{ResourcesDirect.FullName}\{ImagePathsFile}";

    public static bool IsResultRecieved = false;

    public void Start()
    {
        DisableAlbumPanel();
        DisablePreviewPanel();
        InitializeInputImagePaths();
    }

    #region Panel Management

    public void EnableAlbumPanel()
    {
        Panel_Album.SetActive(true);
    }

    public void DisableAlbumPanel()
    {
        Panel_Album.SetActive(false);
    }

    public void EnablePreviewPanel()
    {
        Panel_Preview.SetActive(true);
    }

    public void DisablePreviewPanel()
    {
        Panel_Preview.SetActive(false);
    }

    public void EnableLoadingPanel()
    {
        Panel_Loading.SetActive(true);
    }

    public void DisableLoadingPanel()
    {
        Panel_Loading.SetActive(false);
    }

    #endregion

    #region I/O Management

    public void Confirm()
    {
        OutputInputImagePaths(); // Output the .txt file for backend to use
        Navigate_ResultScene();
    }

    public void Navigate_ResultScene()
    {
        
        //while (!IsResultRecieved)
        //{
        //    RotateAnimation();
        //}

        SceneManager.LoadScene("Scene_Result", LoadSceneMode.Single);
    }

    private void RotateAnimation()
    {
        float rotationSpeed = 30f;
        float rotationAmount = rotationSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0, 0, rotationAmount));
    }

    private void InitializeInputImagePaths()
    {
        InputImages = new HashSet<string>();
        if (File.Exists(ImagePathsFilePath))
        {
            File.Delete(ImagePathsFilePath);
        }
        File.Create(ImagePathsFile);
        IsResultRecieved = false;
    }

    public void AddInputImages(string imgPath)
    {
        if (String.IsNullOrEmpty(imgPath))
        {
            Console.WriteLine($"Invalid image path: {imgPath}");
        }

        InputImages.Add(imgPath);
    }

    public void OutputInputImagePaths()
    {
        if (InputImages == null || InputImages.Count == 0)
        {
            Console.WriteLine("Empty input image list.");
            return;
        }

        var fileStream = new StreamWriter(ImagePathsFilePath);
        foreach (string imgPath in InputImages)
        {
            if (!String.IsNullOrEmpty(imgPath))
            {
                fileStream.WriteLine(imgPath);
            }
        }
        fileStream.Close();
    }

    #endregion
}
