using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Numerics;
using UnityEngine.UI;

public class UIPlayerResourceItem : MonoBehaviour
{
    // Variables
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI valueText;
    public Button buttonPlus;
    public Button buttonMinus;

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
    }

    // Updates the UI
    private void UpdateValues()
    {
        nameText.text = displayObject.Name;
        valueText.text = "" + displayObject.Value;
    }
}
