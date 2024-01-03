using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformReseter : MonoBehaviour
{
    public Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("reset");
            transform.position = startingPosition;
        }
    }
}
