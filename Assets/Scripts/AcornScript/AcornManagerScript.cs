using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornManagerScript : MonoBehaviour
{
    private float timer = 0f;
    private float spawnAcornTimer = 2;
    public GameObject acornPrefab;

    private void Awake()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnAcornTimer)
        {
            Instantiate(acornPrefab, transform.position, transform.rotation);
            timer = 0f;
        }
    }

}
