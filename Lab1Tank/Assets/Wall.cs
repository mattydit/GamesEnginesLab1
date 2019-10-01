using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int width = 20;
    public float height = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        int halfWidth = width / 2;

        while(height <= 10)
        {
            for (int i = -halfWidth; i < halfWidth; i++)
            {
                Vector3 pos = transform.position + new Vector3(i, height, 0);

                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = pos;

                //give random colour
                cube.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.value, 1, 1);

                //parenting
                cube.transform.parent = this.transform;

                cube.AddComponent<Rigidbody>();
            }

            height++;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
