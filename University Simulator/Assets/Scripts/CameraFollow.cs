using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


    //public GameObject player;
    //public Camera mainCamera;

    //public float pixelToUnits;

    //void Update()
    //{
    //    if (player != null)
    //    {
    //        float playerX = player.transform.position.x;
    //        float playerY = player.transform.position.y;

    //        float roundedX = RoundToNearestPixel(playerX);
    //        float roundedY = RoundToNearestPixel(playerY);

    //        Vector3 newPos = new Vector3(roundedX, roundedY, -10f);

    //        mainCamera.transform.position = newPos;
    //    }
    //}


    //public float RoundToNearestPixel(float pos)
    //{
    //    float valueInUnits = pos * pixelToUnits;
    //    valueInUnits = Mathf.Round(valueInUnits);
    //    float roundedUnits = valueInUnits * (1 / pixelToUnits);


    //    return roundedUnits;
    //}


    private Transform playerTransform;
    public float followSpeed;

    public Vector3 cameraOffSet;
    public float xMin;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void FixedUpdate()
    {
        Vector3 targetPos = playerTransform.position + cameraOffSet;
        Vector3 clampedPos = new Vector3(Mathf.Clamp(targetPos.x, xMin, float.MaxValue), targetPos.y, targetPos.z);
        Vector3 smoothPos = Vector3.SmoothDamp(transform.position, clampedPos, ref velocity, followSpeed = Time.fixedDeltaTime);


        transform.position = smoothPos;
    }



}
