using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class EjemplosString2 : MonoBehaviour
{
    public Text textoUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textoUI.text = string.Concat("Hola", " ", "Mundo") + "\n"; //Hola Mundo
        textoUI.text += "aulaenlanube.com".ToLower() + "\n";    //aulaenlanube.com
        textoUI.text += "aulaenlanube.com".ToUpper() + "\n";    //AULAENLANUBE.COM
        textoUI.text += "  aula en la nube  ".Trim() + "\n";    //aula en la nube
        textoUI.text += "aula en la nube".Substring(5, 5) + "\n";    //en la
        textoUI.text += "aula en la nube".Replace("aula", "unity") + "\n";    //unity en la nube
        textoUI.text += "aulaenlanube.com".Length + "\n";    //16
        textoUI.text += "aula en la nube".IndexOf("en") + "\n"; //5
        textoUI.text += "aula en la nube".IndexOf("e") + "\n"; //5
        textoUI.text += "aula en la nube".IndexOf("E") + "\n"; //-1
        textoUI.text += "aulaenlanube".StartsWith("aula") + "\n"; //True
        textoUI.text += "aulaenlanube".Contains("en") + "\n"; //True

        string[] partes = "aula en la nube".Split(' '); // ["aula", "en", "la", "nube"]
        char[] caracteres = "aula".ToCharArray(); //["a", "u", "l", "a"]

        textoUI.text += new string(caracteres) + "\n"; //aula
        textoUI.text += string.Join(" ", caracteres) + "\n"; //a u l a
        textoUI.text += string.Join(" ", partes) + "\n"; //aula en la nube
        textoUI.text += string.Compare(new string(caracteres), string.Join(" ", caracteres)) + "\n"; //1
    }

    // Update is called once per frame
    void Update()
    {

    }
}