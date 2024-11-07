using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpecialOperations
{
    public class MathematicalOperations : MonoBehaviour
    {
        public static void Multipication(int number, List<GameObject> subCharacters, Transform transform)
        {
            int loopCount = (GameManager.currentCharacterCount * number) - GameManager.currentCharacterCount;
            int count = 0;
            foreach (var item in subCharacters)
            {
                if (count < loopCount)
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
            GameManager.currentCharacterCount *= number;
        }

        public static void Addition(int number, List<GameObject> subCharacters, Transform transform)
        {
            int count2 = 0;
            foreach (var item in subCharacters)
            {
                if (count2 < number)
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
            GameManager.currentCharacterCount += number;
        }

        public static void Subtraction(int number, List<GameObject> subCharacters)
        {
            if (GameManager.currentCharacterCount <= number)
            {
                foreach (var item in subCharacters)
                {

                    item.transform.position = Vector3.zero;
                    item.SetActive(false);
                }
                GameManager.currentCharacterCount = 1;
            }
            else
            {
                int count3 = 0;
                foreach (var item in subCharacters)
                {
                    if (count3 != number)
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
                GameManager.currentCharacterCount -= number;
            }
        }

        public static void Division(int number, List<GameObject> subCharacters)
        {
            if (GameManager.currentCharacterCount <= number)
            {
                foreach (var item in subCharacters)
                {

                    item.transform.position = Vector3.zero;
                    item.SetActive(false);
                }
                GameManager.currentCharacterCount = 1;
            }
            else
            {
                int count3 = 0;
                foreach (var item in subCharacters)
                {
                    if (count3 != GameManager.currentCharacterCount / number)
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

                if (GameManager.currentCharacterCount % number == 0)
                {
                    GameManager.currentCharacterCount /= number;
                }
                else if (GameManager.currentCharacterCount % number == 1)
                {
                    GameManager.currentCharacterCount = (GameManager.currentCharacterCount / number) + 1;
                }
                else if (GameManager.currentCharacterCount % number == 2)
                {
                    GameManager.currentCharacterCount = (GameManager.currentCharacterCount / number) + 2;
                }
            }
        }
    }
}


