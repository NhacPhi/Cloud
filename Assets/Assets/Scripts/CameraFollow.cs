using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform posPlayer;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - posPlayer.position;
    }

    private void LateUpdate()
    {
        Vector3 newPos = posPlayer.position + offset;
        transform.position = newPos;
    }
}
