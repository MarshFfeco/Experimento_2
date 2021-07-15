using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera cam;

    Vector3 pCam;

    public NavMeshAgent player;

    public float speed = .2f;
    public float strength = 8f;


    private void Start()
    {
        pCam = cam.transform.position - transform.position;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                player.SetDestination(hit.point);
            }
        }

    }

    private void LateUpdate()
    {
        cam.transform.position = transform.position + pCam;
    }

}
