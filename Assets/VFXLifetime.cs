using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXLifetime : MonoBehaviour
{
    public float lifeTime;

    void Awake()
    {
        Invoke("DestroyVFX", lifeTime);
    }

    private void DestroyVFX()
    {
        Destroy(gameObject);
    }
}
