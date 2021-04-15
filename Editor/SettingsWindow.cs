using UnityEditor;
using UnityEngine;

namespace MeHAds
{
    public class SettingsWindow : EditorWindow
    {
        void OnGUI()
        {
            GUILayout.Label ("Base Settings", EditorStyles.boldLabel);
        }
    }
}
