using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text scoreText;
    public float speed = 3f;
    public Button restartB;
    public int score = 0;
  
    void Update()
    {
        //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        //transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);

        float hor = Input.GetAxisRaw("Horizontal");
        Vector3 dir = new Vector3(hor, 0, 0); 
        transform.Translate(dir.normalized * Time.deltaTime * speed);

    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {   
            SceneManager.LoadScene(2);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Oil"))
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
            Destroy(collision.gameObject);
        }
    }

    
    
   
}
