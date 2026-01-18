using UnityEngine;

public class Player1 : Paddle
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        { 
            Debug.Log("Escape key pressed. Quitting application.");
            Application.Quit();
        }
            


        bool isUpPressed = Input.GetKey(KeyCode.W);
        bool isDownPressed = Input.GetKey(KeyCode.S);
        
        if (isUpPressed)
        {
            if (transform.position.y >= 5.5f)
            {
                return;
            }
            transform.Translate(Vector2.up * 10f * Time.deltaTime);
        }
        else if (isDownPressed)
        {
            if (transform.position.y <= -5.5f)
            {
                return;
            }
            transform.Translate(Vector2.down * 10f * Time.deltaTime);
        }
    }
}
