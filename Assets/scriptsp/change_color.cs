using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("vinegar")){
            Renderer renderer = GetComponent<Renderer>();
            Color newColor = HexToColor("#f79055"); 
            renderer.material.color = newColor;
            if (text)
           {//
               ShowText();
            }
        }
    }
    private Color HexToColor(string hex)
    {
        hex = hex.Replace("#", "");
        byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        return new Color32(r, g, b, 255);
    }

    public void ShowText()
    {
        GameObject texto = Instantiate(text);
        texto.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
    }
}
