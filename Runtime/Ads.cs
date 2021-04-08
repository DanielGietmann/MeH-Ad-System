using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

namespace MeHAds{
    public class Ads : MonoBehaviour
    {
        public static void ShowPlacement(string placementid) {
            
            if (Advertisement.IsReady()) {
                Advertisement.Show(placementid);
            } 
            else {
                Debug.LogError("MEHADS | Interstitial ad not ready at the moment! Please try again later!");
            }
        }
            
        public static void ShowRewardedPlacement(string placementid)
        {
            // Check if UnityAds ready before calling Show method:
            if (Advertisement.IsReady())
            {
                Advertisement.Show(placementid);
            }
            else
            {
              Debug.LogError("MEHADS | Interstitial ad not ready at the moment! Please try again later!");
            }
        }
    }
}