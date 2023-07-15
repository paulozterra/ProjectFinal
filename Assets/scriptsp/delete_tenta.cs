using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete_tenta : MonoBehaviour
{
    public GameObject text;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("deleteador"))
        {
            //Destroy(GameObject.Find(text.name + "(clone)"));
            Destroy(gameObject);
            if (text)
            {
                ShowText();
            }
        }
    }

    public void ShowText()
    {
        GameObject texto = Instantiate(text);
        texto.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
    }
}
