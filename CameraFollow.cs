using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject character;

    void Update()
    {
        if(character.transform.position.x > -3.98f)
        {
            transform.position = new Vector3(character.transform.position.x, -2.59f, 0f);
        }
    }
}
