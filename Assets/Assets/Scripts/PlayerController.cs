using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform startPos;

    [SerializeField]
    private LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(startPos.position.x,transform.position.y,startPos.position.z);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            {
                if (Physics.Raycast(ray, out hit, layerMask))
                {
                    Debug.DrawLine(transform.position, hit.point);

                    if (hit.transform.gameObject.GetComponent<Outline>() != null)
                    {
                        hit.transform.gameObject.GetComponent<Outline>().enabled = true;

                        Debug.Log("Detect");
                    }

                }
            }
        }
    }
}
