using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModelHandler : MonoBehaviour
{
    public GameObject currentModel;

    public void SetModel(GameObject model)
    {
        this.currentModel = model;
    }

    public void GetContentPlaced()
    {

    }
}
