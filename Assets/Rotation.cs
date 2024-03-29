using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneRotationController : MonoBehaviour
{
    public Transform controllerTransform; // R�f�rence au transform du contr�leur VR

    void Update()
    {
        if (controllerTransform != null)
        {
            // R�cup�rer la rotation du contr�leur
            Quaternion controllerRotation = controllerTransform.rotation;

            // Appliquer la rotation au t�l�phone
            transform.rotation = controllerRotation;
        }
    }
}

