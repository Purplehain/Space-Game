using UnityEngine;
using System.Collections;

public class PlayerShip : BaseShip {
    CameraScript cam;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        PlayerInput();
	}

    void PlayerInput( ) {
        if(Input.GetAxis("Vertical") > 0 ) { SpeedUp(); }
        else if(Input.GetAxis("Vertical") < 0 ){ Brake(); }

        if(Input.GetAxis("Horizontal") < 0) { TurnRight(); }
        else if(Input.GetAxis("Horizontal") > 0) { TurnLeft(); }
        

    }
}
