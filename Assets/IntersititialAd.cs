using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class IntersititialAd : MonoBehaviour
{
    private InterstitialAd inter;
    // Start is called before the first frame update
    void Start()
    {
        inter = new InterstitialAd("ca - app - pub - 9830950306066848 / 8333857762");
        AdRequest request = new AdRequest.Builder().Build();
        inter.LoadAd(request);
        inter.Show();
    }

    // Update is called once per frame
    public void ReklamShow()
    {
        inter.Show(); 
    }
}
