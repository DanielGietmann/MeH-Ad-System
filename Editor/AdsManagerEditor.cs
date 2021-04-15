using UnityEditor;
using UnityEngine;

namespace MeHAds
{
    [CustomEditor(typeof(AdsManager))]
    public class AdsManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            AdsManager adsManager = (AdsManager) target;
            serializedObject.Update();
            GUILayout.Label("GameID Settings", EditorStyles.label);
            EditorGUILayout.HelpBox("you can find this data in your unity dashboard", MessageType.Info);
            adsManager.gameIdAndroid = EditorGUILayout.TextField("Game ID Android",adsManager.gameIdAndroid);
            adsManager.gameIdIOS = EditorGUILayout.TextField("Game ID IOS", adsManager.gameIdIOS);
            GUILayout.Space(10);
            GUILayout.Label("Banner Settings", EditorStyles.label);
            adsManager.BannerPlacmentOn = GUILayout.Toggle(adsManager.BannerPlacmentOn, "Enable Banner Ads");
            adsManager.bannerplacementid = EditorGUILayout.TextField("Banner ID", adsManager.bannerplacementid);
            GUILayout.Space(10);
            adsManager.dontdestroyonload = GUILayout.Toggle(adsManager.dontdestroyonload, "Dont Destroy On Load");
            GUILayout.Space(10);
            GUILayout.Label("Test Setting", EditorStyles.label);
            adsManager.testMode = GUILayout.Toggle(adsManager.testMode, "Enable Test Mode");
            serializedObject.ApplyModifiedProperties();
        }
    }
}
