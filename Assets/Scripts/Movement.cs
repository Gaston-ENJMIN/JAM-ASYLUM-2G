using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    void Update()
    {
        LookMouseCursor();
    }

    void LookMouseCursor()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }
}
