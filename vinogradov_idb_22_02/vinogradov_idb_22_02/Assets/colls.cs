using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;
public class colls : MonoBehaviour
{
    public Text label;
    public int count = 10000;
    public int gamColl = 1;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        label.text = (gamColl).ToString();
        gamColl += 1;
        print(collision.collider.name);
    }
  
}
