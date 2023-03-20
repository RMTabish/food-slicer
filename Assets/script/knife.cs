
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : MonoBehaviour
{
    public float timeElapsed = 0f;

    private float ClickTimeframe = 0.1f;

    public Animator KnifeAnimator;
    public bool isCutting;
    private Rect screenBounds;


void Start()
{
    float screenMidX = Screen.width / 2f; // get the horizontal midpoint of the screen
    float screenBottomY = Screen.height - 250f; // get the bottom y-coordinate of the screen (subtract 250 to lower the bounds)

    float boundsWidth = 50;  // set the width of the bounds to 1.5 times the horizontal midpoint of the screen to remove the clickable area to the right of the center
    float boundsHeight = 400f; // set the height of the bounds to 400 pixels to increase the clickable area

    float boundsX = screenMidX - boundsWidth / 2f; // set the x-coordinate of the bounds to the midpoint minus half of the width
    float boundsY = screenBottomY - boundsHeight; // set the y-coordinate of the bounds to the bottom of the screen minus the height of the bounds

    screenBounds = new Rect(boundsX, boundsY, boundsWidth, boundsHeight);
}




    public void SETcut(bool state)
    {
        isCutting = state;
        KnifeAnimator.SetBool("isCutting", state);

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0) && screenBounds.Contains(Input.mousePosition) && isCutting == false)
        {
            timeElapsed = 0f;

            SETcut(true);
        }
        else
        {
            timeElapsed += Time.fixedDeltaTime;

            if (timeElapsed >= ClickTimeframe && isCutting)
            {
                SETcut(false);
                timeElapsed = 0f;
            }
        }
    }
}
