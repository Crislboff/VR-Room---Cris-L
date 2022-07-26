using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject itemContainer;

    // Start is called before the first frame update
    void Start()
    {
        GameObject randomItem = itemContainer.transform.GetChild(Random.Range(0, itemContainer.transform.childCount)).gameObject;
        randomItem.transform.localScale = Vector3.one * 0.5f;
    }
}
