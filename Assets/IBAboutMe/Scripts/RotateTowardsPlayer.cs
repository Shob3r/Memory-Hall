using UnityEngine;

public class RotateTowardsPlayer : MonoBehaviour
{
    // Thanks to the unity docs for giving me code to steal

    public Transform Player;
    public float RotationSpeed = 1.5f;

    private void Update()
    {
        Vector3 PlayerPosition = Player.position - transform.position;
        float SingleStep = RotationSpeed * Time.deltaTime;
        Vector3 RotationDirection = Vector3.RotateTowards(transform.forward, PlayerPosition, SingleStep, 0.0f);

        Debug.DrawRay(transform.position, RotationDirection, Color.red);

        transform.rotation = Quaternion.LookRotation(RotationDirection);
    }

}