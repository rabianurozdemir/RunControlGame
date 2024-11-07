using System.Collections;
using System.Collections.Generic;
using System.Threading;
using SpecialOperations;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject destinationPoint;
    public List<GameObject> subCharacters;
    public static int currentCharacterCount = 1; // Including main character


    void Start()
    {

    }

    void Update()
    {
    }

    public void CharacterManagement(string operationType, int number, Transform transform)
    {
        switch (operationType)
        {
            case "Multipication":
                MathematicalOperations.Multipication(number, subCharacters, transform);
                break;

            case "Addition":
                MathematicalOperations.Addition(number, subCharacters, transform);
                break;


            case "Subtraction":
                MathematicalOperations.Subtraction(number, subCharacters);
                break;

            case "Division":
                MathematicalOperations.Division(number, subCharacters);
                break;

            default:
                break;
        }
    }
}
