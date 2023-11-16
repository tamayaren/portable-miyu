using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainNavigatorHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject navigation;

    [SerializeField]
    private GameObject collapseButton;

    public void ShowNavigator()
    {
        navigation?.SetActive(true);
    }

    public void HideNavigator()
    {
        navigation?.SetActive(false);
    }

    public void HideCollapseButton()
    {
        collapseButton?.SetActive(false);
    }

    public void ShowCollapseButton()
    {
        collapseButton?.SetActive(true);
    }
}
