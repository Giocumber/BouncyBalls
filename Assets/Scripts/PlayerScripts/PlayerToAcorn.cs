using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerToAcorn : MonoBehaviour
{
    public GameObject parentObject;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Acorn"))
            transform.SetParent(collision.transform);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Acorn"))
            transform.SetParent(parentObject.transform);
    }
}
