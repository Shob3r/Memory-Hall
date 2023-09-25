using UnityEngine;

public class ShowAboutMeGUI : Interactable
{
    public GameObject GUIToShow, RegularGUI;
    protected override void Interact()
    {
        base.Interact();
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        RegularGUI.SetActive(false);
        GUIToShow.SetActive(true);
    }
}
