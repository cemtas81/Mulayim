using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;


public class MulayimStandardT : MonoBehaviour
{
    public Joystick LeftJoystick;
    public Joystick RightJoystick;
    
    protected ThirdPersonUserControl Control;
    
    protected float CameraAngle;
    public float CameraAngleSpeed=3f;
    public float CameraHeight;

    // Start is called before the first frame update
    void Start()
    {
        Control = GetComponent<ThirdPersonUserControl>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Control.Hinput= LeftJoystick.Horizontal;
        Control.Vinput= LeftJoystick.Vertical;

        CameraAngle += RightJoystick.Horizontal*CameraAngleSpeed;
        CameraAngle += RightJoystick.Vertical*CameraAngleSpeed;
        Camera.main.transform.position = transform.position+ Quaternion.AngleAxis(CameraAngle,Vector3.up)*new Vector3(0,3,4);
        Camera.main.transform.rotation= Quaternion.LookRotation(transform.position+Vector3.up*CameraHeight -Camera.main.transform.position,Vector3.up);




        
    }
}
