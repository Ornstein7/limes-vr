using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LampController : MonoBehaviour
{
    public GameObject resistanceSocket; // R�f�rence au socket de la r�sistance
    public Material greenMaterial; // Mat�riau vert
    public Material redMaterial; // Mat�riau rouge

    private Renderer lampRenderer; // R�f�rence au Renderer de la lampe
    private bool resistancePlaced = false; // Indique si la r�sistance est plac�e ou non

    void Start()
    {
        // Assurez-vous que le GameObject a un Renderer attach�
        lampRenderer = GetComponent<Renderer>();
        if (lampRenderer == null)
        {
            Debug.LogError("Renderer manquant sur la lampe.");
            enabled = false; // D�sactiver le script s'il n'y a pas de Renderer
        }
    }

    // M�thode appel�e lorsque quelque chose entre en collision avec le socket
    void OnTriggerEnter(Collider other)
    {
        if (!resistancePlaced && other.CompareTag("resistors"))
        {
            // La r�sistance entre en collision avec le socket
            resistancePlaced = true;
            // Changer le mat�riau de la lampe en vert
            lampRenderer.material = greenMaterial;
        }
    }

    // M�thode appel�e lorsque quelque chose quitte la collision avec le socket
    void OnTriggerExit(Collider other)
    {
        if (resistancePlaced && other.CompareTag("resistors"))
        {
            // La r�sistance quitte la collision avec le socket
            resistancePlaced = false;
            // Changer le mat�riau de la lampe en rouge
            lampRenderer.material = redMaterial;
        }
    }
}