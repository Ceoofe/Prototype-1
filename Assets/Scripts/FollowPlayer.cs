using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -7);
    public Camera mainCam;
    public Camera secondCam;
    bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        secondCam.enabled = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset; //Follows the player
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isPressed == false) // When spacebar is Pressed, it changes to the second camera
        {
            isPressed = true;
            mainCam.enabled = false;
            secondCam.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && isPressed == true) // When spacebar is Pressed again, it reverts back to the main camera
        {
            mainCam.enabled = true;
            secondCam.enabled = false;
            isPressed = false;
        }
    }
}
