using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintsController : MonoBehaviour
{
    public Text textField;

    public void setText(string text)
    {
        textField.text = text;
    }

}
