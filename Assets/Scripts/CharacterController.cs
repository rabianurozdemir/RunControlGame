using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameManager gameManagerScript;

    void FixedUpdate() // So movements will be perceived more better
    {
        transform.Translate(transform.forward * 0.5f * Time.deltaTime); // Move the character forward and backward

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            var axis = Input.GetAxis("Mouse X");

            if (axis < 0)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z), 0.3f); // Move the character left

            }
            if (axis > 0)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z), 0.3f); // Move the character right

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Addition") || other.CompareTag("Subtraction") || other.CompareTag("Multipication") || other.CompareTag("Division")) // Check if the character hits the numeric blocks
        {
            int number = int.Parse(other.name);
            gameManagerScript.CharacterManagement(other.tag, number, other.transform); // Call the CharacterManagement method in the GameManager script
        }
    }
}
