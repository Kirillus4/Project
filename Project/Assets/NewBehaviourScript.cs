using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Random.Range(-1f, 3f), Random.Range(-1f, 3f), 0f);
    }
}
