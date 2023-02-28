using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playercounter : MonoBehaviour
{
    int health = 3;

    public TMP_Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        healthText.text = health.ToString();
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
