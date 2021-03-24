using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintsController : MonoBehaviour
{
    public Text textField;

    public void setText(string text)
    {
        textField.enabled = true;
        textField.text = text;
        textField.CrossFadeAlpha(1, 1, false);
        Invoke("disableText", 5);
    }
    public void disableText()
    {
        textField.enabled = false;
    }
}
