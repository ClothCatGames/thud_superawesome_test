using System.Collections;
using System.Collections.Generic;
using tv.superawesome.sdk.publisher;
using UnityEngine;

namespace thud.awesomeads.test
{
    public class AdvertTester : MonoBehaviour
    {

        public const int VIDEO_ID = 44338;


        // Start is called before the first frame update
        void Start()
        {
            SAVideoAd.enableTestMode();
            SAVideoAd.setOrientationLandscape();
            SAVideoAd.disableBackButton();
            SAVideoAd.disableCloseButton();
            SAVideoAd.enableCloseAtEnd();
            SAVideoAd.load(VIDEO_ID);
        }



        public void PlayAd()
        {
            if (SAVideoAd.hasAdAvailable(VIDEO_ID))
            { 
                SAVideoAd.play(VIDEO_ID);
            }
        }
    }
}