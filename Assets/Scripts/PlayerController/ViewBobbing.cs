using UnityEngine;

public class ViewBobbing : MonoBehaviour
{
    public GameObject Player;
    public Camera Cam;
    public float sineBob = 0.25f;
    public float BobMultiplier = 0.25f;
    private bool IsViewBobbingEnabled;

    public void EnableViewBobbing()
    {
        IsViewBobbingEnabled = true;
    }
    public void DisableViewBobbing()
    {
        IsViewBobbingEnabled = false;
    }
    void Update() 
    {
        if (IsViewBobbingEnabled)
        {
            Cam.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 0.2f + (Mathf.Abs(Mathf.Sin(Time.fixedTime * sineBob)) * BobMultiplier), Player.transform.position.z);
        }
    }
}