using UnityEngine;

public class CarPresenationManager : MonoBehaviour
{
    [Header("Components")]
    public Transform StandTransform;

    private float turnSpeed = 10f;

    void Update()
    {
        StandTransform.transform.Rotate(Vector3.up * (turnSpeed * Time.deltaTime));
        //    StandTransform.transform.Rotate(0, Input.GetAxisRaw("Horizontal") * -turnSpeed  * Time.deltaTime, 0);     
    }
}
