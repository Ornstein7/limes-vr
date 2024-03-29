using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneRotationController : MonoBehaviour
{
    public Transform controllerTransform; // Référence au transform du contrôleur VR

    void Update()
    {
        if (controllerTransform != null)
        {
            // Récupérer la rotation du contrôleur
            Quaternion controllerRotation = controllerTransform.rotation;

            // Appliquer la rotation au téléphone
            transform.rotation = controllerRotation;
        }
    }
}

