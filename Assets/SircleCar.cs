using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SircleCar : MonoBehaviour
{
    // Start is called before the first frame update
     public float m_speed= 5;
     public Animator m_animator;
     public Rigidbody m_Rigidbody;
     public VariableJoystick m_Joystick;
     
     public Camera m_Camera;
     
     void start()
     {m_animator= GetComponent<Animator>();}

     //void Update()
     //{transform.rotation=Quaternion.Vector3.forward;}
     //{Vector3.forward= m_Camera.transform.eulerAngles.y*Vector3.forward;}
     
         
     
    

     

  


    void FixedUpdate()
    

    { m_Rigidbody.AddRelativeForce(Vector3.right*m_Joystick.Horizontal*m_speed*Time.fixedDeltaTime+
    Vector3.forward*m_Joystick.Vertical*m_speed*
    Time.fixedDeltaTime);
      //Quaternion deltaRotation= Quaternion.Euler(Vector3.up*Time.fixedDeltaTime*m_Joystick.Horizontal);
      //m_Rigidbody.MoveRotation(m_Rigidbody.rotation*deltaRotation);
     //m_Rigidbody.rotation = Quaternion.LookRotation (Vector3.right);
     m_Rigidbody.rotation= Quaternion.LookRotation( Vector3.forward);
     Quaternion.Euler (0,m_Camera.transform.eulerAngles.y,0);
     //m_Rigidbody.MovePosition( m_Camera.transform.forward);


    
      

     


        } 
    
}
