using System;
using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

namespace MeHAds
{
    public class AdsManager : MonoBehaviour
    {
        public string gameIdAndroid;
        public string gameIdIOS;       
        public bool testMode;
        public bool dontdestroyonload;
        public bool BannerPlacmentOn;

        private void Awake()
        {
            if(dontdestroyonload)
            {
                DontDestroyOnLoad(this.gameObject);
            };
        }

        void InitAds()
        {
            #if UNITY_ANDROID
            Advertisement.Initialize(gameIdAndroid, testMode);
            Debug.Log("MEHADS | Android Init");
            #elif UNITY_IOS
             Advertisement.Initialize(gameIdIOS, testMode);
            Debug.Log("MEHADS | IOS Init");
            #else
            Debug.Log("MEHADS | KEINE PLATFORM");
            #endif
        }

        private void Start()
        {
            InitAds();
            if(BannerPlacmentOn)
            {
                BannerOn();
            }
        }

        
        public string bannerplacementid;        

        void BannerOn()
        {
            StartCoroutine(ShowBannerWhenInitialized());
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        }
        
        
        IEnumerator ShowBannerWhenInitialized()
        {
            while (!Advertisement.isInitialized)
            {
                yield return new WaitForSeconds(0.5f);
            }

            Advertisement.Banner.Show(bannerplacementid);
            Debug.Log("MEHADS | Banner Init");
        }
    }
}
