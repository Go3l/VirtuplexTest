using UnityEngine;

public class CarPresenationManager : MonoBehaviour
{
    [Header("Variables")]
    public float turnSpeed = 4.0f;
    public float offSetY = 5.0f;
    public float offSetZ = 5.0f;

    [Header("Components")]
    public Transform carTransform;
    public Transform StandTransform;
    public Camera cam;

    private Vector3 offset;

    public enum PresentationType
    {
        Orbit,
        MouseRotation,
        CarRotation,
        keyRotation
    }

    public PresentationType presentation;

    void Awake()
    {
        presentation = PresentationType.CarRotation;
        offset = new Vector3(carTransform.position.x, carTransform.position.y + offSetY, carTransform.position.z + offSetZ);
    }

    void Update()
    {
        //fix offset orbit and mouse rotation and their speed
        if (presentation == PresentationType.Orbit)
        {
            offset = Quaternion.AngleAxis(turnSpeed, Vector3.up) * offset;
            cam.transform.position = carTransform.position + offset;
            cam.transform.LookAt(carTransform.position);
        }
        else if (presentation == PresentationType.MouseRotation)
        {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
            cam.transform.position = carTransform.position + offset;
            cam.transform.LookAt(carTransform.position);
        }
        else if (presentation == PresentationType.CarRotation)
        {
            StandTransform.transform.Rotate(Vector3.up * (turnSpeed * Time.deltaTime));
        }
        else if(presentation == PresentationType.keyRotation)
        {
           StandTransform.transform.Rotate(0, Input.GetAxisRaw("Horizontal") * -turnSpeed  * Time.deltaTime, 0);
        }
    }
}
