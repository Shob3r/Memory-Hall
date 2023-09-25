using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameWithMouseUnlocked : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
}
