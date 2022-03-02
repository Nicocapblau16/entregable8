using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{
    public void ChangePosX(float xPos)
    {
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }

    public void ChangePosY(float yPos)
    {
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }

    public void ResizeCube(float sizeMultiplier)
    {
        transform.localScale = sizeMultiplier * Vector3.one;
    }
}
