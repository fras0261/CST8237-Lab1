using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

    public float xLimit;
    public float yLimit;
    public float speed;

    private bool xMovingAway = true; 
    private bool yMovingAway = true;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {



        if (xMovingAway == true)
        {
            if (yMovingAway == true)
            {
                transform.localPosition += new Vector3(speed, speed, 0);

                if (transform.localPosition.y >= yLimit )
                    yMovingAway = false;
            }
                
            else
            {
                transform.localPosition += new Vector3(speed, -speed, 0);

                if (transform.localPosition.y <= -yLimit)
                    yMovingAway = true;
            }
                
            if (transform.localPosition.x >= xLimit || transform.localPosition.x <= -xLimit)
                xMovingAway = false;
            
        }
        else if (xMovingAway == false)
        {
            if (yMovingAway == true)
            {
                transform.localPosition += new Vector3(-speed, speed, 0);

                if (transform.localPosition.y >= yLimit || transform.localPosition.y <= -yLimit)
                    yMovingAway = false;
            }

            else
            {
                transform.localPosition += new Vector3(-speed, -speed, 0);
               
                if (transform.localPosition.y <= -yLimit)
                    yMovingAway = true;
            }

            if (transform.localPosition.x <= -xLimit)
                xMovingAway = true;
        }
       
    }
}
