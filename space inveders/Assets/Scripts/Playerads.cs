using UnityEngine.Advertisements;
using UnityEngine;
using System.Collections;
public class Playerads : MonoBehaviour
{

    public void ShowAds()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleAdsResult });
        }

    }

    private void HandleAdsResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("palyer finished add + 5 coins");
                break;
            case ShowResult.Skipped:
                Debug.Log("player skipped ad thefore there is no reward");
                break;
            case ShowResult.Failed:
                Debug.Log("the player fails to launch the ad? internet?");
                break;
        }
    }
}
