using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace StarCandy
{
    // Load the specified scene immediately and block the thread to do so by default.
    // To not block the thread, specify async loading.
    public class LoadSceneOnAwake : MonoBehaviour
    {
        public string sceneName;
        public bool loadAsync = false;
        public LoadSceneMode loadMode = LoadSceneMode.Additive;

        // Runs before Start()
        void Awake()
        {
            if (sceneName != null && sceneName.Length > 0)
            {
                if (loadAsync)
                    SceneManager.LoadSceneAsync(sceneName);
                else
                    SceneManager.LoadScene(sceneName, loadMode);
            }
            else
            {
                GlobalLog.Error("A scene name wasn't specified for loading!");
            }
        }
    }
}