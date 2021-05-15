using UnityEngine;
using DG.Tweening;

public class CarAnimManager : MonoBehaviour
{
    [Header("Doors")]
    public GameObject frontLeftDoor;
    public GameObject frontRightDoor;
    public GameObject backLeftDoor;
    public GameObject backRightDoor;
    public GameObject truckDoor;

    [Header("Door Opening Angle")]
    public float openingAngle;

    private bool isFLD;
    private bool isFRD;
    private bool isBLD;
    private bool isBRD;
    private bool isTD;

    #region Front Doors
    public void ToggleDoorFLD()
    {
        if (!isFLD)
        {
            frontLeftDoor.transform.DOLocalRotate(new Vector3(0, openingAngle, 0), 0.5f);
            isFLD = true;
        }
        else
        {
            frontLeftDoor.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            isFLD = false;
        }
    }

    public void ToggleDoorFRD()
    {
        if (!isFRD)
        {
            frontRightDoor.transform.DOLocalRotate(new Vector3(0, -openingAngle, 0), 0.5f);
            isFRD = true;
        }
        else
        {
            frontRightDoor.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            isFRD = false;
        }
    }
    #endregion

    #region BackDoors
    public void ToggleDoorBLD()
    {
        if (!isBLD)
        {
            backLeftDoor.transform.DOLocalRotate(new Vector3(0, openingAngle, 0), 0.5f);
            isBLD = true;
        }
        else
        {
            backLeftDoor.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            isBLD = false;
        }
    }
    public void ToggleDoorBRD()
    {
        if (!isBRD)
        {
            backRightDoor.transform.DOLocalRotate(new Vector3(0, -openingAngle, 0), 0.5f);
            isBRD = true;
        }
        else
        {
            backRightDoor.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            isBRD = false;
        }
    }

    #endregion

    public void TrunckDoor()
    {
        if (!isTD)
        {
            truckDoor.transform.DOLocalRotate(new Vector3(openingAngle, 0, 0), 0.5f);
            isTD = true;
        }
        else
        {
            truckDoor.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
            isTD = false;
        }
    }
}
