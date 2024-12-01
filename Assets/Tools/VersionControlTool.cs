using UnityEditor;
using UnityEngine;

namespace Tools
{
    public class VersionControlTool : EditorWindow
    {
        [MenuItem("Tools/VersionControl")]
        static void OpenWindow()
        {
            var window = EditorWindow.GetWindow<VersionControlTool>();
            window.Show();
        }
    }
}
