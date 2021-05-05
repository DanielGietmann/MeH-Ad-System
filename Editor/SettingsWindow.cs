using System;
using UnityEditor;
using UnityEngine;

namespace MeHAds
{
    public class SettingsWindow : EditorWindow
    {
        private void OnEnable()
        {
            string IOSID = EditorPrefs.GetString("mehadsiosid");
            string androidID = EditorPrefs.GetString("mehadsandroidid");
        }


        void OnGUI()
        {
            GUILayout.Label ("Base Settings", EditorStyles.boldLabel);
            
            
            
        }
    }
    
}
