using UnityEditor;
using UnityEngine;
using System.IO;

public class EditorInitialization
{
    private static void Init()
    {
        EditorApplication.OpenScene("Assets/Scenes/initialScene.unity");
        
        OpenVisualStudio();
    }
    
    private static void OpenVisualStudio()
    {
        var split = Application.dataPath.Split('/');
        var solution = split[split.Length - 2] + "-csharp.sln";

        var file = new FileInfo(solution);

        if (file.Exists)
            System.Diagnostics.Process.Start("devenv", " " + solution);
    }
}
