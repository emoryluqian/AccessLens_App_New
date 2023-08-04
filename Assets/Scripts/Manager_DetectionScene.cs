using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Manager_DetectionScene : MonoBehaviour
{
    public static GameObject Panel_Album;
    public static GameObject Panel_Preview;

    public static HashSet<string> InputImages;
    public static DirectoryInfo ResourcesDirect => new DirectoryInfo($@"Assets/Resources");
    public const string ImagePathsFile = "Input Image Paths.txt";
    public static string ImagePathsFilePath => $@"{ResourcesDirect.FullName}\{ImagePathsFile}";
    

    public static void InitializeDetectionScene()
    {
        DisableAlbumPanel();
        DisablePreviewPanel();
        InitializeInputImagePaths();
    }

    public static void EnableAlbumPanel()
    {
        Panel_Album.SetActive(true);
    }

    public static void DisableAlbumPanel()
    {
        Panel_Preview.SetActive(false);
    }

    public static void EnablePreviewPanel()
    {
        Panel_Preview.SetActive(true);
    }

    public static void DisablePreviewPanel()
    {
        Panel_Preview.SetActive(false);
    }

    private static void InitializeInputImagePaths()
    {
        InputImages = new HashSet<string>();
        if (File.Exists(ImagePathsFilePath))
        {
            File.Delete(ImagePathsFilePath);
        }
        File.Create(ImagePathsFile);
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
}
