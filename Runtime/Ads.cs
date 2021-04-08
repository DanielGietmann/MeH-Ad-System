using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

namespace MeHAds{
    public class Ads : MonoBehaviour
    {
        /*
        public static void RewardVideoPlacement(string gameid, bool testmode)
        {         
            Advertisement.Initialize(gameid, testmode);

            ShowRewardedPlacement();
        }
        */
            
        public static void ShowRewardedPlacement(string placementid)
        {
            // Check if UnityAds ready before calling Show method:
            if (Advertisement.IsReady())
            {
                Advertisement.Show("rewardedVideo");
            }
            else
            {
                Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
            }
        }
    }
}