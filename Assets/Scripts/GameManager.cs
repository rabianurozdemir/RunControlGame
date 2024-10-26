using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target;
    public GameObject subCharacterPrefab;
    public GameObject destinationPoint;
    public GameObject spawnPoint;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(subCharacterPrefab, spawnPoint.transform.position, Quaternion.identity);
        }

    }
}
