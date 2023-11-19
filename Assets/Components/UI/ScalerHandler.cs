using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScalerHandler : MonoBehaviour
{
    [SerializeField] private GameModelHandler gameModelHandler;

    private Vector3 defaultScale;

    private void Awake()
    {
        if (!ReferenceEquals(null, gameModelHandler.currentModel))
        {
            this.defaultScale = gameModelHandler.currentModel.transform.localScale;
        }
    }

    public void ScaleUp()
    {
        gameModelHandler.currentModel.transform.localScale *= 1.05f;
    }

    public void ScaleDown()
    {
        gameModelHandler.currentModel.transform.localScale *= 0.95f;
    }

    public void ScaleReset()
    {
        gameModelHandler.currentModel.transform.localScale = this.defaultScale;
    }
}
