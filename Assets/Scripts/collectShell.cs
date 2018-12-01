using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectShell : MonoBehaviour {

    public GameObject explosion;
    public Text countText;
    private AudioSource source;

    private int count;


    private void Start()
    {
        source = GetComponent<AudioSource>();
        count = 0;
        SetCountText();

    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 10;
            SetCountText();
            source.Play();
            Instantiate(explosion, transform.position, transform.rotation);

            Destroy(other.gameObject);
        }


    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();

      


    }


}
