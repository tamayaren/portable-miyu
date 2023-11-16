using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModelHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject currentModel;

    public void SetModel(GameObject model)
    {
        this.currentModel = model;
    }
}
