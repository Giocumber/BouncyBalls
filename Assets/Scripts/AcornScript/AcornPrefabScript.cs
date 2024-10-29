using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornPrefabScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        //Invoke("DestroyAcorn", 10f);
    }

    private void DestroyAcorn()
    {
        Destroy(gameObject); 
    }

    private void Update()
    {
        if(transform.position.y < -8f)
            Destroy(gameObject);
    }
}
