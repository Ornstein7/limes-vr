using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LampController : MonoBehaviour
{
    public GameObject resistanceSocket; // Référence au socket de la résistance
    public Material greenMaterial; // Matériau vert
    public Material redMaterial; // Matériau rouge

    private Renderer lampRenderer; // Référence au Renderer de la lampe
    private bool resistancePlaced = false; // Indique si la résistance est placée ou non

    void Start()
    {
        // Assurez-vous que le GameObject a un Renderer attaché
        lampRenderer = GetComponent<Renderer>();
        if (lampRenderer == null)
        {
            Debug.LogError("Renderer manquant sur la lampe.");
            enabled = false; // Désactiver le script s'il n'y a pas de Renderer
        }
    }

    // Méthode appelée lorsque quelque chose entre en collision avec le socket
    void OnTriggerEnter(Collider other)
    {
        if (!resistancePlaced && other.CompareTag("resistors"))
        {
            // La résistance entre en collision avec le socket
            resistancePlaced = true;
            // Changer le matériau de la lampe en vert
            lampRenderer.material = greenMaterial;
        }
    }

    // Méthode appelée lorsque quelque chose quitte la collision avec le socket
    void OnTriggerExit(Collider other)
    {
        if (resistancePlaced && other.CompareTag("resistors"))
        {
            // La résistance quitte la collision avec le socket
            resistancePlaced = false;
            // Changer le matériau de la lampe en rouge
            lampRenderer.material = redMaterial;
        }
    }
}