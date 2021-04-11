using UnityEditor;
using UnityEngine;
using MeHAds;

namespace MeHAds
{
    public class MenuItems : MonoBehaviour
    {
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
    }
}
