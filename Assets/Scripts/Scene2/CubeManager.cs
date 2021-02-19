using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public UnityEngine.UI.Text timText, spdText, distText;
    public GameObject land;
    public UnityEngine.PhysicMaterial noFriction;
    int timer = 100, ticks = 100;
    float speed = 1.0f, 
          distance = 1.0f;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        SomeClass2 s = new SomeClass2();
        s.Setup();
        if (land == null)
        {
            startPos = new Vector3(0.0f, 0.0f, 20.0f);
        }
        else
        {
            startPos = land.transform.position + new Vector3(0.0f, 1.0f, 0.0f);
        }
        if (timText == null)
        {
            Debug.Log("Warning: Timer TextBox is not set. Default Cube spawn interval would be 100 ticks.");
        }
        if (spdText == null)
        {
            Debug.Log("Warning: Speed TextBox is not set. Default Cube speed would be 1.");
        }
        if (distText == null)
        {
            Debug.Log("Warning: Distance TextBox is not set. Default Cube travel distance would be 1.");
        }
        if (noFriction == null)
        {
            Debug.Log("Warning: Material for Cubes is not set; traveling distance will be lowered because of friction.");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdTimer();
        if (ticks == 0)
        {
            SpawnCube();
            ticks = timer;
        }
        else
        {
            ticks--;
        }
    }
    void UpdTimer()
    {
        if (timText != null)
        {
            if (timText.text != "")
            {
                try
                {
                    timer = System.Convert.ToInt32(timText.text);
                }
                catch (System.FormatException)
                {
                    Debug.Log("Only digits allowed in Timer field.");
                }
            }
        }
    }
    void UpdSpd()
    {
        if (spdText != null)
        {
            if (spdText.text != "")
            {
                try
                {
                    speed = System.Convert.ToInt32(spdText.text);
                }
                catch (System.FormatException)
                {
                    Debug.Log("Only digits allowed in Speed field.");
                }
            }
        }
    }
    void UpdDist()
    {
        if (distText != null)
        {
            if (distText.text != "")
            {
                try
                {
                    distance = System.Convert.ToInt32(distText.text);
                }
                catch (System.FormatException)
                {
                Debug.Log("Only digits allowed in Distance field.");
                }
            }
        }
    }

    void SpawnCube()
    {
        UpdSpd();
        UpdDist();
        GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        newCube.transform.position = startPos;
        newCube.transform.localEulerAngles += new Vector3(0.0f, Random.Range(0.0f, 360.0f), 0.0f);
        if(noFriction != null)
            newCube.GetComponent<Collider>().sharedMaterial = noFriction;
        newCube.AddComponent<Rigidbody>().velocity = speed * newCube.transform.forward;
        GameObject.Destroy(newCube, distance / speed);
    }
}
