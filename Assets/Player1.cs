using UnityEngine;

public class Player1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isUpPressed = Input.GetKey(KeyCode.W);
        bool isDownPressed = Input.GetKey(KeyCode.S);
        
        if (isUpPressed)
        {
            transform.Translate(Vector2.up * 10f * Time.deltaTime);
        }
        else if (isDownPressed)
        {
            transform.Translate(Vector2.down * 10f * Time.deltaTime);
        }
    }
}
