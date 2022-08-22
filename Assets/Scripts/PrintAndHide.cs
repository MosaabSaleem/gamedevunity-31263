using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public GameObject g;
    public Renderer rend;
    private int random;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(g.name + ":" + i);

        if (g.tag == "Red" && i == 100)
        {
            g.SetActive(false);
        }
        if (g.tag == "Blue" && i == random)
        {
            rend.enabled = false;
        }
    }
}
