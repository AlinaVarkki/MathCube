
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{

    string gameId = "3563021";
    bool testMode = true;
    public bool finished;
    void Start()
    {
        // Initialize the Ads service:
        Advertisement.Initialize(gameId, testMode);
        // Show an ad:
   
    }

    public void showAd() {
        Time.timeScale = 0;
        if (Advertisement.IsReady())
        {
            finished = false;
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("video", options);
        }
   }

    private void HandleShowResult(ShowResult result)
    {
        
        switch (result)
        {
            case ShowResult.Finished:
                Time.timeScale = 1;
                Debug.Log("The ad was successfully shown.");
                //
                // YOUR CODE TO REWARD THE GAMER
                // Give coins etc.
                break;
            case ShowResult.Skipped:
                Time.timeScale = 1;
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Time.timeScale = 1;
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }
}