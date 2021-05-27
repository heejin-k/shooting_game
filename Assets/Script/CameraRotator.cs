using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    [SerializeField] float angularVelocity = 30f;
    float horizontalAngle = 0f;
    float verticalAngle = 0f;

    void Update()
    {
        var horizontalRotation = Input.GetAxis("Horizontal") * angularVelocity * Time.deltaTime;
        var verticalRotaion = -Input.GetAxis("Vertical") * angularVelocity * Time.deltaTime;

        horizontalAngle += horizontalRotation;
        verticalAngle += verticalRotaion;

        verticalAngle = Mathf.Clamp(verticalAngle, -80f, 80f);

        transform.rotation = Quaternion.Euler(verticalAngle, horizontalAngle, 0f);
    }

}
