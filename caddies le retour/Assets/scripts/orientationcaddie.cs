using UnityEngine;
using System.Collections;

public class orientationcaddie : MonoBehaviour
{


    void Update()
    {
        transform.LookAt(Camera.main.transform.position);
    }

}
