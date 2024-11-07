using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject destinationPoint;
    public List<GameObject> subCharacters;
    public int currentCharacterCount = 1; // Including main character


    void Start()
    {

    }

    void Update()
    {
    }

    public void CharacterManagement(string name, Transform transform)
    {
        switch (name)
        {
            case "x2":
                int count = 0;
                foreach (var item in subCharacters)
                {
                    if (count < currentCharacterCount)
                    {
                        if (!item.activeInHierarchy)
                        {
                            item.transform.position = transform.position + new Vector3(0, 0f, -0.4f); // Set the position of the sub character to the position of the numeric block
                            item.SetActive(true);
                            count++;
                        }
                    }
                    else
                    {
                        count = 0;
                        break;
                    }

                }
                currentCharacterCount *= 2;
                break;

            case "+3":
                int count2 = 0;
                foreach (var item in subCharacters)
                {
                    if (count2 < 3)
                    {
                        if (!item.activeInHierarchy)
                        {
                            item.transform.position = transform.position + new Vector3(0, 0f, -0.4f); // Set the position of the sub character to the position of the numeric block
                            item.SetActive(true);
                            count2++;
                        }
                    }
                    else
                    {
                        count2 = 0;
                        break;
                    }
                }
                currentCharacterCount += 3;
                break;


            case "-4":
                if (currentCharacterCount <= 4)
                {
                    foreach (var item in subCharacters)
                    {

                        item.transform.position = Vector3.zero;
                        item.SetActive(false);
                    }
                    currentCharacterCount = 1;
                }
                else
                {
                    int count3 = 0;
                    foreach (var item in subCharacters)
                    {
                        if (count3 < 4)
                        {
                            if (item.activeInHierarchy)
                            {
                                item.transform.position = Vector3.zero;
                                item.SetActive(false);
                                count3++;
                            }
                        }
                        else
                        {
                            count3 = 0;
                            break;
                        }
                    }
                    currentCharacterCount -= 4;
                }
                break;

            case "/2":
                if (currentCharacterCount <= 2)
                {
                    foreach (var item in subCharacters)
                    {

                        item.transform.position = Vector3.zero;
                        item.SetActive(false);
                    }
                    currentCharacterCount = 1;
                }
                else
                {
                    int count3 = 0;
                    foreach (var item in subCharacters)
                    {
                        if (count3 != currentCharacterCount / 2)
                        {
                            if (item.activeInHierarchy)
                            {
                                item.transform.position = Vector3.zero;
                                item.SetActive(false);
                                count3++;
                            }
                        }
                        else
                        {
                            count3 = 0;
                            break;
                        }
                    }

                    if (currentCharacterCount % 2 == 0)
                    {
                        currentCharacterCount /= 2;
                    }
                    else
                    {
                        currentCharacterCount = (currentCharacterCount / 2) + 1;
                    }
                }
                break;

            default:
                break;
        }
    }
}
