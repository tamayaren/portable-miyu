using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMaterialHandler : MonoBehaviour
{
    [SerializeField] private GameModelHandler gameModelHandler;

    [SerializeField] private GameObject clothes;
    [SerializeField] private GameObject hair;
    [SerializeField] private GameObject hair1;


    private IDictionary<MaterialColors, Color> materialColors = new Dictionary<MaterialColors, Color>();

    private void Start()
    {
        materialColors.Add(MaterialColors.White, Color.white);
        materialColors.Add(MaterialColors.Black, Color.black);
        materialColors.Add(MaterialColors.Green, Color.green);
        materialColors.Add(MaterialColors.Teal, new Color(0, 1, 0.4607f, 1));
        materialColors.Add(MaterialColors.Yellow, new Color(1f, 1f, 0, 1));
        materialColors.Add(MaterialColors.Orange, new Color(1f, .6044f, 0, 1));
        materialColors.Add(MaterialColors.Purple, new Color(1f, 0, 1f, 1));
        materialColors.Add(MaterialColors.Violet, new Color(.6121421f, 0, 1f, 1));
        materialColors.Add(MaterialColors.Blue, new Color(0, 0, 1f, 1));
        materialColors.Add(MaterialColors.Cyan, new Color(0, 1f, 1f, 1));
    }

    public void SetColor(MaterialColors color)
    {
        Color materialColor = materialColors[color];

        if (materialColor != null)
        {
            clothes.GetComponent<Renderer>().material.color = materialColor;
            hair.GetComponent<Renderer>().material.color = materialColor;
            hair1.GetComponent<Renderer>().material.color = materialColor;
        }
    }

    public void SetWhite() { this.SetColor(MaterialColors.White); }
    public void SetBlack() { this.SetColor(MaterialColors.Black); }
    public void SetGreen() { this.SetColor(MaterialColors.Green); }
    public void SetTeal() { this.SetColor(MaterialColors.Teal); }
    public void SetYellow() { this.SetColor(MaterialColors.Yellow); }
    public void SetOrange() { this.SetColor(MaterialColors.Orange); }
    public void SetPurple() { this.SetColor(MaterialColors.Purple); }
    public void SetViolet() { this.SetColor(MaterialColors.Violet); }
    public void SetBlue() { this.SetColor(MaterialColors.Blue); }
    public void SetCyan() { this.SetColor(MaterialColors.Cyan); }
}
