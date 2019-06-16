using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisibility : MonoBehaviour
{
    // Use this for initialization
    void Update()
    {
        //Set Cursor to not be visible
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
