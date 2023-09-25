using UnityEngine;

public class MusicSwitcherInteract : Interactable
{
    public GameObject MusicSwitcherUI, GameUI;
    protected override void Interact()
    {
        Cursor.lockState = CursorLockMode.None;
        MusicSwitcherUI.SetActive(true);
        GameUI.SetActive(false);
        Time.timeScale = 0;
    }
}
