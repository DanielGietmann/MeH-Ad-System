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
                Debug.Log("MEHADS | Interstitial ad not ready at the moment! Please try again later!");
            }
        }
            
        public static void ShowRewardedPlacement(string placementid)
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show(placementid);
            }
            else
            {
              Debug.Log("MEHADS | Interstitial ad not ready at the moment! Please try again later!");
            }
        }
    }
}