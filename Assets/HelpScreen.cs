using UnityEngine;

public class HelpScreen : MonoBehaviour
{
    public GameObject helpScreenUI;
    private bool isHelpScreenActive = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            isHelpScreenActive = !isHelpScreenActive;
            helpScreenUI.SetActive(isHelpScreenActive);

            Time.timeScale = isHelpScreenActive ? 0f : 1f;
        }
    }
}
