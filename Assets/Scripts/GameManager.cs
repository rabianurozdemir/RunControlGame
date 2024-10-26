using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target;
    public GameObject subCharacterPrefab;
    public GameObject destinationPoint;
    public GameObject spawnPoint;
    public List<GameObject> subCharacters;


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
                    break; // To prevent all subCharacters to be activated
                }
            }
        }

    }
}
