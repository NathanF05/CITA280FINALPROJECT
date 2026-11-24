using UnityEngine;
using UnityEngine.InputSystem;


public class DialController : MonoBehaviour
{
    private Camera myCam;
    private Vector3 dialPosition;


    public bool canTurn = true;
    public int heatValue = 0;
    public float snapTo = 0;




    private void Start()
    {
        myCam = Camera.main;

        dialPosition = gameObject.transform.position;
    }


    private void Update()
    {
        if (canTurn)
        {


            Vector2 mousePos = (Vector2)myCam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            if (Mouse.current.leftButton.isPressed)
            {
                Vector3 mouseToDial = (Vector3)Mouse.current.position.ReadValue() - dialPosition;

                // Translate rotation to 360 degrees
                float newAngle = Mathf.Atan2(mouseToDial.y, mouseToDial.x) * Mathf.Rad2Deg;
                if (newAngle < 0)
                {
                    newAngle += 360;
                }


                // Determine where the dial should snap to
                if (0 <= newAngle && newAngle >= 315)
                {
                    if (snapTo == 270)
                    {
                        snapTo = 0;
                        heatValue = 0;
                    }
                }
                else if (newAngle < 315 && newAngle >= 225)
                {
                    if (snapTo == 0 || snapTo == 180)
                    {
                        snapTo = 270;

                        heatValue = 1;
                    }
                }
                else if (newAngle < 225 && newAngle >= 135)
                {
                    if (snapTo == 270 || snapTo == 90)
                    {
                        snapTo = 180;

                        heatValue = 2;
                    }
                }
                else if (newAngle < 135 && newAngle >= 90)
                {
                    if (snapTo == 180)
                    {
                        snapTo = 90;

                        heatValue = 3;
                    }
                }

                // Rotate the dial to its new position
                transform.eulerAngles = new Vector3(0, 0, snapTo);
            }
        }
    }
}