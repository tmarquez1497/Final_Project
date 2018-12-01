using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerController : MonoBehaviour
{

    private Rigidbody2D rb2d;
    public float speed;
    public Text GameOverText;
    private bool gameOver;
    public float timeLeft;

    public GameObject Death;
   

    



    // Use this for initialization
    void Start()
    {
        gameOver = false;
        rb2d = GetComponent<Rigidbody2D>();
        
        GameOverText.text = "";
    }

    private void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            GameOver();
            gameObject.SetActive(false);
            Instantiate(Death, transform.position, transform.rotation);


        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(moveHorizontal * speed, rb2d.velocity.y);

        if (Input.GetKey("escape"))
            Application.Quit();


    }

   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            Instantiate(Death, transform.position, transform.rotation);
            Destroy(gameObject);
            GameOver();
            

        }

    }


        public void GameOver()
        {
            
            GameOverText.text = "Game Over!";
            gameOver = true;
            StartCoroutine(ByeAfterDelay(2));
        }

    IEnumerator ByeAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay

       //ADD Game Loader code
    }

}