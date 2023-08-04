# AccessLens_App
<strong>An inaccessibility detection mobile application. </strong>

## Requirements
    "Unity IDE"
    "Editor Version": "2022.3.4f1",
    "com.unity.barracuda": "1.0.3",
    "com.unity.xr.arfoundation": "4.0.8",
    "com.unity.xr.arkit": "4.0.8",
    "com.unity.xr.arcore": "4.0.8",

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

## Scene Organazation
1. Logical manager: each scene has a game object that acts like a logical manager, and the logical manager is links to a script `.cs`file  that manages all logics and codes associate with this scene
2. By default, all codes links to Unity project uses the programming language `C#`, so all file ends with `.cs`

## Naming Convention
* `Property_Name` or `Role_Object`
`Property_Name` example:
* a `Scene` object named `Detection` : `Scene_Detection`
* a `Panel` object named `3DModel` : `Panel_3DModel`
`Role_Object` example:
* a new game object acts like a logic `Manager` for `Scene_Detect` : `Manager_DetectScene`
* a new game object acts like a logic `Manager` for `Panel_3DModel` : `Manager_3DModelPanel`
