using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject disk;
    public GameObject light;   
      private Light x;

    //public float rotationSpeed = 30f;
    public Vector3 rotateChange;
    private bool flag=false;
    // Start is called before the first frame update
    void Start()
    {
       x = light.GetComponent<Light>();
       x.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(flag)
        {
            // Calculate rotation for this frame
            //float rotationThisFrame = rotationSpeed * Time.deltaTime;

            // Apply the rotation
            disk.transform.Rotate(rotateChange);
        }
    }
    private void OnMouseDown()
    {
        if(flag){
            flag = false;
            x.enabled = false;
        }
        else{
            flag = true;
            x.enabled = true;
        }


    }

}
