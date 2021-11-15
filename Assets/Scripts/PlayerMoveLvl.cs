using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerMoveLvl : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody2D rig;
    public float mapWidth = 5f;
    public Text score;
    public static int scoreValuer;
    public float slowness = 10f;
    public GameObject obj;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;

 

    private void Start()
    {
       
        scoreValuer = 0;
        rig = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {

        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        Vector2 newPosition = rig.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        rig.MovePosition(newPosition);


    }
    private void Update()
    {
        
        score.text = scoreValuer.ToString();

        if (scoreValuer == 15)
        {
            WinLvl();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Empty")
        {
            EndGame();

        }
        else
        {
            scoreValuer++;

            FindObjectOfType<BeerDestr>().Destr();

        }

    }

    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }
    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f / slowness);
        Destroy(gameObject);




        if (scoreValuer < 10)
        {
            obj1.SetActive(true);
            Time.timeScale = 1f;
            Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;



        }
        else if (scoreValuer >= 10 && scoreValuer < 30)
        {
            obj2.SetActive(true);
            Time.timeScale = 1f;
            Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        }
        else if (scoreValuer >= 30 && scoreValuer < 45)
        {
            obj3.SetActive(true);
            Time.timeScale = 1f;
            Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        }
        else if (scoreValuer >= 45 && scoreValuer < 70)
        {
            obj4.SetActive(true);
            Time.timeScale = 1f;
            Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        }
    }
    
    void WinLvl()
    {
        //Destroy(gameObject);
        //obj.SetActive(true);
        StartCoroutine(NextLevel());
    }

    IEnumerator NextLevel()
    {
        obj.SetActive(true);

        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;
        

        yield return new WaitForSeconds(0.2f / slowness);
        Destroy(gameObject);



        //obj.SetActive(true);
        if (Time.timeScale< 1f)
        {
            Time.timeScale = 1f;
            Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        }
    }

    public void NextLvlo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
