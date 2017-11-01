using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public Light lampe;

    // COURAGE TU VAS COMPRENDRE EN REFLECHISSANT BIEN !
    void Update()
    {
        // J'appelle la fonction LookMouseCursor définie plus loin
        LookMouseCursor();
        LampeTorche();
    }

    void LookMouseCursor()
    {
        // Je définis le fait que hit sera la variable lorsque le rayon va toucher une surface / Je trace le rayon
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Si le rayon touche quelque chose dans une range de 100
        if (Physics.Raycast(ray, out hit, 100))
        {
            // L'objet regarde vers les coordonnées de hit
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }

    void LampeTorche()
    {   
        // Je switch l'état ON / OFF en appuyant sur F
        if (Input.GetKeyUp(KeyCode.F))
        {
            lampe.enabled = !lampe.enabled;
        }
    }
}
