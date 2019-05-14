using System.Collections.Generic;
using UnityEngine;


namespace StarCandy.UI.impl
{
    public class UIPlayerResourcesDisplay : MonoBehaviour
    {
        // Debug
        [Header("Debug")]
        [Tooltip("This causes values being edited in the inspector to be updated by force.")]
        public bool debugEnabled;

        // Links
        [Header("Links")]
        public GameObject collectionArea;
        public UIPlayerResourceItem referenceObject;

        // Public variables
        [Header("Displayable")]
        public List<PlayerResourceEntry> playerResources = new List<PlayerResourceEntry>();

        // Start is called before the first frame update
        void Start()
        {
            if (debugEnabled)
                GlobalLog.Warning("Debug updating is on for " + this.GetType().Name + "!");

            referenceObject.gameObject.SetActive(false);
            DisplayLists();
        }

        // We only update if debug is enabled. If it is, blast 'on value changed' every frame.
        private void Update()
        {
            if (debugEnabled)
            {
                foreach (PlayerResourceEntry entry in playerResources)
                    entry.OnValueChanged?.Invoke();
            }
        }

        // Destroyes previous children and re-creates them
        void DisplayLists()
        {
            UIPlayerResourceItem[] children = collectionArea.GetComponentsInChildren<UIPlayerResourceItem>();
    
            // Destroy each item. Make sure to destroy the game object, otherwise just the component will be removed.
            foreach (UIPlayerResourceItem child in children)
                Destroy(child.gameObject);

            // Create all the objects
            for (int i = 0; i < playerResources.Count; ++i)
            {
                PlayerResourceEntry entry = playerResources[i];

                UIPlayerResourceItem display = Instantiate(referenceObject, collectionArea.transform, false);
                display.DisplayObject = entry;
                display.buttonPlus.onClick.AddListener(() => UpdateResouceEntry(entry, 1));
                display.buttonMinus.onClick.AddListener(() => UpdateResouceEntry(entry, -1));

                display.gameObject.SetActive(true);
            }
        }

        // Callback function
        void UpdateResouceEntry(PlayerResourceEntry entry, int changeAmount)
        {
            entry.value += changeAmount;
            entry.OnValueChanged?.Invoke();
        }
    }
}