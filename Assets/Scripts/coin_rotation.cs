using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_rotation : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 60) * Time.deltaTime);
    }
}
