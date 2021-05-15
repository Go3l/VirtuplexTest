using System.Collections.Generic;
using UnityEngine;

public class CarColorManager : MonoBehaviour
{
    [Header("Components")]
    public GameObject carObject;
    public Material originalCarMaterial;

    [Header("Colors")]
    public Color[] colorList;

    private List<GameObject> carColorList = new List<GameObject>();

    private void Awake()
    {
        carColorList = GetAllChilds();
    }

    public void ChangeCarColor(int colorIndex)
    {
        foreach (var child in carColorList)
        {
            child.GetComponent<Renderer>().material.SetColor("_Color", colorList[colorIndex]);
        }
    }

    private List<GameObject> GetAllChilds()
    {
        List<GameObject> result = new List<GameObject>();

        if (carObject.transform.childCount > 0)
        {
            foreach (Transform child in carObject.transform)
            {
                Searcher(result, child.gameObject);
            }
        }
        return result;
    }

    private void Searcher(List<GameObject> list, GameObject root)
    {
        if (root.gameObject.GetComponent<Renderer>() != null && root.gameObject.GetComponent<Renderer>().sharedMaterial == originalCarMaterial)
            list.Add(root);

        if (root.transform.childCount > 0)
        {
            foreach (Transform child in root.transform)
            {
                Searcher(list, child.gameObject);
            }
        }
    }
}
