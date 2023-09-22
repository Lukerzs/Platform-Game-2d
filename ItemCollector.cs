using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
    [SerializeField] private Text CherrieText;

    [SerializeField] private AudioSource collectionSoundEfects;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEfects.Play();
            Destroy(collision.gameObject);
            cherries++;
            CherrieText.text = "Cherries :" + cherries;
        }
    }
}
