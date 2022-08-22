using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 red = new Vector3(2, 0, 0);
        Vector3 blue = new Vector3(-2, 0, 0);
        Instantiate(redObj, red, Quaternion.identity);
        Instantiate (blueObj, blue, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
