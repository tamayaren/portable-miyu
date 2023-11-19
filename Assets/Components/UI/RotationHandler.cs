using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class RotationHandler : MonoBehaviour
{
    [SerializeField]
    private GameModelHandler gameModelMain;

    public void RotateLeft()
    {
        gameModelMain.currentModel.transform.Rotate(0f, -10f, 0f, Space.Self);
    }

    public void RotateRight()
    {
        gameModelMain.currentModel.transform.Rotate(0f, 10f, 0f, Space.Self);
    }

    public void Reset()
    {
        gameModelMain.currentModel.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
