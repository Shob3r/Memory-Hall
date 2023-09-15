using UnityEngine;

public class TeleportToSurface : MonoBehaviour
{
    public GameObject Player;
    private Vector3 IslandPos = new Vector3(4,10,7);
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Teleporting Player to Surface");
        Player.transform.position = IslandPos;
    }
}
