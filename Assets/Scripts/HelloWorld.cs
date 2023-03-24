using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField]
    int myNumber = 5;

    public bool myBool = false;

    public float myFloat = 0;

    public string myString = "";

    Material myMaterial;

    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<MeshRenderer>().materials[0];
       
        myMaterial.color = new Color(255, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("The value of myNumber is " + myNumber);
    }
}
