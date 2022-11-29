using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;
using System;

public class intersial : MonoBehaviour
{
    private InterstitialAd interstitialAd;

    private string adUnitId= "ca-app-pub-9830950306066848/8333857762";

    private void Start()
    {
        this.RequestAndLoadInterstitialAd();

        MobileAds.Initialize(interstitialAd => { });
    }

    public void RequestAndLoadInterstitialAd()
    {

        if (this.interstitialAd != null)
        {
            this.interstitialAd.Destroy();
        }


        this.interstitialAd = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitialAd.LoadAd(request);

       
        
    }

    public void ShowInterstitialAd()
    {
        if (this.interstitialAd.IsLoaded())
        {
            this.interstitialAd.Show();
        }
        StartCoroutine(bekleme());
    }

    public void DestroyInterstitialAd()
    {
        if (this.interstitialAd != null)
        {
            this.interstitialAd.Destroy();
        }
    }


    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(0.5f);
        RequestAndLoadInterstitialAd();
    }
}
