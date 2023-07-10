using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete_tenta : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other){
      if(other.CompareTag("deleteador")){
            Destroy(gameObject);
      }
    }
}
