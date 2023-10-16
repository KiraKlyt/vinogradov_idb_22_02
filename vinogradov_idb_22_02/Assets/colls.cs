using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colls : MonoBehaviour
{
    // Start is called before the first frame update
    public Text label;
    int gameCount = 0;
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
  
        label.text = (gameCount).ToString();
        print(collision.collider.name);
        gameCount++;
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
