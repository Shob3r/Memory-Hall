using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class HoldEscToQuit : MonoBehaviour
{
    private PlayerInput Input;
    public TextMeshProUGUI QuitText;
    int QuitCounter = 1;
    void Start()
    {
        Input = new PlayerInput();
        Input.OnFoot.QuitGame.performed += HoldToQuit;
        Input.OnFoot.QuitGame.canceled += HoldToQuitCancelled;
        Input.Enable();
    }

    private void HoldToQuit(InputAction.CallbackContext context)
    {
        StartCoroutine(HoldToQuitHandler());
    }

    private void HoldToQuitCancelled(InputAction.CallbackContext context)
    {
        StopCoroutine(HoldToQuitHandler());
        QuitText.text = string.Empty;
        QuitCounter = 1;
    }
    IEnumerator HoldToQuitHandler()
    {
        Quitter();
        yield return new WaitForSeconds(0.2f);
    }

    private void Quitter()
    {
        
        if(QuitCounter == 1)
        {
            QuitText.text = "Quitting .";
            QuitCounter++;
        }
        if(QuitCounter == 2)
        {
            QuitText.text = "Quitting . .";
            QuitCounter++;
        }
        if(QuitCounter == 3)
        {
            QuitText.text = "Quitting . . .";
            QuitCounter++;
        }
        if(QuitCounter == 4)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            QuitCounter = 1;
#endif
            Application.Quit();
            QuitCounter = 1;
        }
    }
}
