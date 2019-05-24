using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnCars : MonoBehaviour
{
    public GameObject[] cars;
    private float[] posX = { 1.49f, 0.55f, -1.44f, -0.51f };
    void Start()
    {
        StartCoroutine(spawn());

        IEnumerator spawn()
        {
            while (true)
            {
                Instantiate(cars[Random.Range(0, cars.Length)],
                    new Vector3(posX[Random.Range(0, 4)], 6f, -1),
                    Quaternion.Euler(new Vector3(0, 0, 0)));
                yield return new WaitForSeconds(2.5f);
            }
        }
    }

}
