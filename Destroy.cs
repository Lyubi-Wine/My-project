using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectAtStart : MonoBehaviour
{
    // Указываем объект, который нужно уничтожить
    public GameObject objectToDestroy;

    private void Start()
    {
        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);
        }
    }
}