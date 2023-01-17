using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private WorldLimits worldLimits;

    [SerializeField]
    float moveSpeed = 1;

    // equivalent à serializeField
    // public float moveSpeedAlternative = 1;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementInput = new Vector3(horizontalInput, 0, verticalInput);

        //transform.position = transform.position + transform.forward * moveSpeed * Time.deltaTime;
        Vector3 destination = transform.position + movementInput * moveSpeed * Time.deltaTime;
        destination = worldLimits.Clamp(destination);
        transform.position = destination;
    }
}
