using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text1 : MonoBehaviour
{
    public float t_vida=2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t_vida-=Time.deltaTime;
        if(t_vida<=0){
            Destroy(this.gameObject);
        }
    }
}
