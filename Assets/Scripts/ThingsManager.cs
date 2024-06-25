using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingsManager : MonoBehaviour
{
    public GameObject[] things;
    public int currentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        //Desactivar todos los elemtos del array
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if (currentIndex >= things.Length)
            {
                currentIndex = 0;
            }
            DeactivateAll();
            ActivaByIndex(currentIndex);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if (currentIndex <= 0)
            {
                currentIndex = things.Length-1;
            }
            DeactivateAll();
            ActivaByIndex(currentIndex);
        }
    }

    void DeactivateAll()
    {
        for (int i = 0; i < things.Length; i++)
        {
            things[i].SetActive(false);
        }
    }

    void ActivaByIndex(int index)
    {
        things[index].SetActive(true);
    }
}
