using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class FlingQuitInteract : Interactable
{
    public GameObject Player;
    public float Force;
    private Rigidbody PlayerFlinger;
    private int QuitTime;
    protected override void Interact()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
