using UnityEditor;
using UnityEngine;
using MeHAds;

namespace MeHAds
{
    public class MenuItems : MonoBehaviour
    {
        //add Manager To Scene
        [MenuItem("GameObject/MeH Ad System/Add AdsManager To Scene", false, 33)]
        [MenuItem("Assets/MeH AD System/Add AdsManager To Scene", false, 33)]
        [MenuItem("Tools/MeH AD System/Add AdsManager To Scene", false, 33)]
        private static void AddVehicleScripts()
        {
            GameObject myGameobject = new GameObject("AdsManager");

            if (myGameobject == null)
            {
                Debug.LogError("Select A GameObject");
            }
            else
            {
                myGameobject.AddComponent<AdsManager>();
            }
        }
        
        //Open Settings Window
        [MenuItem("Tools/MeH AD System/SettingsWindow", false)]
        public static void  ShowWindow () {
            EditorWindow.GetWindow(typeof(SettingsWindow));
        }
        
        //Open Documentation
        [MenuItem("Tools/MeH AD System/Open Documentation", false)]
        public static void OpenDocwebsite()
        {
            Application.OpenURL("https://github.com/MeH-Development/MeH-Ad-System/wiki");
        }
    }
}
