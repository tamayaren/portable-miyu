using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private GameObject mainFrame;
    [SerializeField] private GameObject transformFrame;
    [SerializeField] private GameObject customizeFrame;
    [SerializeField] private GameObject animationFrame;
    [SerializeField] private GameObject changeFrame;
    [SerializeField] private GameObject notice;

    public void ResetToMain()
    {
        transformFrame.SetActive(false); customizeFrame.SetActive(false); animationFrame.SetActive(false); changeFrame.SetActive(false); 
        mainFrame.SetActive(true);
    }

    public void NoMain()
    {
        mainFrame.SetActive(false);
    }

    public void ToTransform()
    {
        this.NoMain();
        transformFrame.SetActive(true);
    }

    public void ToCustomize()
    {
        this.NoMain();
        customizeFrame.SetActive(true);
    }

    public void ToAnimation()
    {
        this.NoMain();
        animationFrame.SetActive(true);
    }

    public void ToChange()
    {
        this.NoMain();
        changeFrame.SetActive(true);
    }

    public void StartUI()
    {
        notice.SetActive(false);
        this.ResetToMain();
    }
}
