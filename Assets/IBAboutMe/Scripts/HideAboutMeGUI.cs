using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAboutMeGUI : MonoBehaviour
{
    public GameObject InteractGUI;
    public void HideGUI(GameObject GUI)
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        GUI.SetActive(false);
        InteractGUI.SetActive(true);
    }
}
