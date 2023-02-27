using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            currentPos.x = currentPos.x + 3 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            currentPos.x = currentPos.x - 3 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            currentPos.z = currentPos.z - 3 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            currentPos.z = currentPos.z + 3 * Time.deltaTime;
        }
        transform.position = currentPos;
    }
}
