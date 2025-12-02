using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3(0f, 2f, 1f);
    private Vector3 offset2 = new Vector3(0f, 3.62f, -5.16f);
    public Camera secondCamera;
    public Camera currentCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentCamera.enabled = true;
        currentCamera.GetComponent<AudioListener>().enabled = true;
        secondCamera.enabled = false;
        secondCamera.GetComponent<AudioListener>().enabled = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Đã nhấn phím C");
            currentCamera.enabled = false;
            currentCamera.GetComponent<AudioListener>().enabled = false;
            secondCamera.enabled = true;
            secondCamera.GetComponent<AudioListener>().enabled = true;

        }
        else if(Input.GetKeyDown(KeyCode.Z))
        {
            currentCamera.enabled = true;
            currentCamera.GetComponent<AudioListener>().enabled = true;
            secondCamera.enabled = false;
            secondCamera.GetComponent<AudioListener>().enabled = false;
        }

        switch (currentCamera.enabled)
        {
            case true:
                currentCamera.transform.position = player.transform.position + offset1;
                break;
            case false:
                secondCamera.transform.position = player.transform.position + offset2;
                break;
        }
      
    }
}
