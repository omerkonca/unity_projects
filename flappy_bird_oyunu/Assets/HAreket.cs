using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HAreket : MonoBehaviour
{
    public float hareketHizi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * hareketHizi * Time.deltaTime);
    }
}
