using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeController : MonoBehaviour
{

    //private Slider sliderX;
    //private Slider sliderY;


    // Start is called before the first frame update
    void Start()
    {
        //sliderX.value = 0.5f;
        //sliderX.value = 0.5f;
    }




    public void ChangePosX(float xPos)
    {
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }

    public void ChangePosY(float yPos)
    {
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }

    public void Big(float resize = 1f)
    {
        transform.localScale = new Vector3(transform.localScale.x + resize, transform.localScale.y + resize, transform.localScale.z + resize);

    }

    public void Small(float resize = -1f)
    {
        transform.localScale = new Vector3(transform.localScale.x + resize, transform.localScale.y + resize, transform.localScale.z + resize);
    }
}
