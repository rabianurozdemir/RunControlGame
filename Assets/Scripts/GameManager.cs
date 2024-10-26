using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject destinationPoint;
    public GameObject spawnPoint;
    public List<GameObject> subCharacters;
    public int currentCharacterCount = 1; // Including main character


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (var item in subCharacters)
            {
                if (!item.activeInHierarchy)
                {
                    item.transform.position = spawnPoint.transform.position; // Set the position of the subCharacter to the spawnPoint
                    item.SetActive(true);
                    currentCharacterCount++;
                    break; // To prevent all subCharacters to be activated
                }
            }
        }

    }
}
