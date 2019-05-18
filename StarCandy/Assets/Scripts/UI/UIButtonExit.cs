using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceCandy
{
    public class UIButtonExit : MonoBehaviour
    {
        void Start()
        {
            Button button = GetComponent<Button>();
            if (button != null)
                button.onClick.AddListener(Quit);
        }

#if UNITY_WEBPLAYER
    public static string quitURL = "https://loam.app";
#endif
        public static void Quit()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
            Application.OpenURL(quitURL);
#else
            Application.Quit();
#endif
        }
    }
}