# AccessLens_App
<strong>An inaccessibility detection mobile application. Developed with the Unity IDE </strong>

## Requirements  
    "Editor Version": "2022.3.4f1",
    "AR Foundation": "5.0.7",
    "Apple ARKit XR Plugin": "5.0.7",
    "Google ARCore XR Plugin" : "5.0.6",
    "Magic Leap XR Plugin" : "7.0.0", 
    "OpenXR Plugin": "1.8.1"

## Designed AccessLens Views
1. Detection View
2. Summary View
3. Suggestion View

## Project Scenes
1. Scene_Welcome
2. Scene_Detection
3. Scene_Result

## Designed AccessLens Views and Project Scenes Relationships
| Designed AccessLens View  |        Project Scene      |
| ------------------------- | ------------------------- |
| (None)                    | Scene_Welcome             |
| Detection View            | Scene_Detection           |
| Summary View              | Scene_Result              |
| Suggestion View           | Scene_Result              |


## Project Organization
1. Scenes location: AccessLens_App/Assets/Scenes
2. Scripts location: AccessLens_App/Assets/Scripts
3. Resource location: AccessLens_App/Assets/Resource
4. Icon location: AccessLens_App/Assets/Icon
5. Input Image Paths File Location: AccessLens_App/Assets/Resource/Input Image Paths.txt
6. Dictionary File Location: AccessLens_App/Assets/Resource/\<file name\>
7. Backend Code Folder Location: (Will discuss later)

## Frontend to Backend Communication
*  At the end of the `Detection` process, frontend will output a `.txt` textfile `Input Image Paths.txt`
*  To nativage to this file, please refer to previous section `Project Organization` point `5`
*  The `Input Image Paths.txt` file contains all path of the images that users want to upload <strong>at a single run</strong>.
*  Each file path takes an <strong>individual line</strong>, so the please use `Readline()` or any similar feature to read the file. 
*  Each new run clears out the file.
*  Only <strong>distinct</strong> image paths are written to this file, so don't worry about repetitive image paths.

## Backend to Frontend Communication
*  Backend should send out a signal to the Frontend to indicate the successful return of result
*  Maybe a newly added `.json` file can be a good signal
*  If use `.json` file as the signal, please clears out or delete the file at every <strong>new run</strong>. 

## Scene Organazation
1. Logical manager: each scene has a game object that acts like a logical manager, and the logical manager is links to a script `.cs` file  that manages all logics and codes associate with this scene
2. By default, all codes links to Unity project uses the programming language `C#`, so all script file ends with `.cs`

## Naming Convention
* `Property_Name` or `Role_Object`
`Property_Name` example:
* a `Scene` object named `Detection` : `Scene_Detection`
* a `Panel` object named `3DModel` : `Panel_3DModel`
`Role_Object` example:
* a new game object acts like a logic `Manager` for `Scene_Detect` : `Manager_DetectScene`
* a new game object acts like a logic `Manager` for `Panel_3DModel` : `Manager_3DModelPanel`
