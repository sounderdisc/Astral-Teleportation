using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwitch : MonoBehaviour
{
    // these are instantiated via inspector in the scene. I used this technique in Objective.cs as well. I think we may be able to do the same thing in a Start() function, but im not sure
    public CanvasGroup mainMenu;
    public CanvasGroup levelSelect;

    public void levelSelectButton()
    {
        hide(mainMenu);
        show(levelSelect);
    }

    public void returnFromLevelSelect()
    {
        hide(levelSelect);
        show(mainMenu);
    }

    private void hide(CanvasGroup targetGroup)
    {
        targetGroup.alpha = 0f; //this makes everything transparent
        targetGroup.blocksRaycasts = false; //this prevents the UI element to receive input events
    }

    private void show(CanvasGroup targetGroup)
    {
        targetGroup.alpha = 1f;
        targetGroup.blocksRaycasts = true;
    }
}
