using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject deathVFX;
    public GameObject squirrel;
    public GameObject acorn;

    private CameraShake cameraShake;
    private AudioManager audioManager;

    private void Start()
    {
        cameraShake =  GameObject.Find("Main Camera").GetComponent<CameraShake>();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    public void Die()
    {
        audioManager.PlaySFX(audioManager.deathSFX);
        cameraShake.StartShake();

        Instantiate(deathVFX, squirrel.transform.position, Quaternion.identity);
        squirrel.SetActive(false);

        Instantiate(deathVFX, acorn.transform.position, Quaternion.identity);
        acorn.SetActive(false);
    }

}
