using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class BaseShip : MonoBehaviour {

    public float curHull;
    public float maxHull;

    public float curSpeed;
    public float maxSpeed;
    public float brakeSpeed;
    public float acceleration;
    public float turnSpeed;
    public float weight;
    

    protected Rigidbody rigid;
    void Awake( ) {
        rigid = GetComponent<Rigidbody>();
    }

    void Update( ) {
        SpeedUp();
    }

    public void SpeedUp( ) {
        if(rigid.velocity.magnitude < maxSpeed) {
            rigid.AddRelativeForce( Vector3.forward * acceleration * Time.deltaTime );
            curSpeed = rigid.velocity.magnitude;
        }

        
    }

    public void Brake( ) {

        if ( rigid.velocity.magnitude > 0 ) {
            
        }
        else rigid.drag = 0;
    }

    public void TurnLeft( ) {
        rigid.AddRelativeTorque( Vector3.up * turnSpeed * Time.deltaTime );

    }

    public void TurnRight( ) {
        rigid.AddRelativeTorque( -Vector3.up * turnSpeed * Time.deltaTime );
    }
}
