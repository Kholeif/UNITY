using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("lallo", 0, 4f);
    }

    void lallo()
    {
        GameObject go = Instantiate(character, character.transform.position, this.transform.rotation);
        go.transform.Rotate(new Vector3(0, Random.Range(-90,90), 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
