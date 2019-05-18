using System;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

namespace SpaceCandy
{
    public class SplashVideoAdvance : MonoBehaviour
    {
        // Variables
        public VideoPlayer videoPlayer;
        public string targetScene;
        private bool isLoadingScene;

        // Startup Checks
        private void Start()
        {
            if (videoPlayer == null)
                GlobalLog.Error("A video player should be defined or this won't work!");

            isLoadingScene = false;
        }

        // See if we're done
        private void Update()
        {
            if(!videoPlayer.isPlaying && videoPlayer.frame > (long)videoPlayer.frameCount / 2)
            {
                if (!isLoadingScene)
                {
                    isLoadingScene = true;
                    SceneManager.LoadScene(targetScene);
                }
            }
        }
    }
}
