using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


namespace StarCandy.UI.impl
{
    public class UIPlayerResourceItem : MonoBehaviour
    {
        // Links
        public TextMeshProUGUI nameText;
        public TextMeshProUGUI valueText;
        public Button buttonPlus;
        public Button buttonMinus;
        public Image icon;

        // The object bound to the display currently
        private IUIResourceDisplayable displayObject;
        public IUIResourceDisplayable DisplayObject
        {
            get
            {
                return displayObject;
            }
            set
            {
                // If we had a previous value, unbind our update function.
                if (displayObject != null)
                    displayObject.OnValueChanged -= UpdateValues;

                // Set our new data reference, then bind to the change
                displayObject = value;
                displayObject.OnValueChanged += UpdateValues;

                // Update the visuals
                UpdateValues();
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            if (nameText == null)
                GlobalLog.Error("Text to display the resource name must be specified!");

            if (valueText == null)
                GlobalLog.Error("Text to display the resource value must be specified!");

            if (buttonPlus == null)
                GlobalLog.Error("Plus button must be specified!");

            if (buttonMinus == null)
                GlobalLog.Error("Minus button must be specified!");

            if (icon == null)
                GlobalLog.Error("Icon must not be null! While the icon's sprite can be null, it must have a defined spot!");
        }

        // Updates the UI
        private void UpdateValues()
        {
            nameText.text = displayObject.Name;
            valueText.text = String.Format("{0:#,##0}", displayObject.Value); // Adds commas, so 1234 displays as 1,234
            icon.sprite = displayObject.Icon; 
        }
    }
}