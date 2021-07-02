using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour, IClicked
{
    public void onClickAction()
    {
        Debug.Log("Player has been clicked");
    }
}
