using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour, IClicked
{
    public int index;
    public bool isEmpty = true;
    public void onClickAction()
    {
        Debug.Log("Table has been clicked");
    }
}
