using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class scriptPos : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject CUB;
    public GameObject Sphere;

    public bool gm = true;
    public bool gm2 = true;

    void Start()
    {
        CUB.transform.position = new Vector3(3, 2, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
       


    }
    public void button_click()
    {
    
        gm = !gm;
        CUB.SetActive(gm);
  
    }
    public void button_click2()
    {

        gm2 = !gm2;
        Sphere.SetActive(gm2);

    }


}
