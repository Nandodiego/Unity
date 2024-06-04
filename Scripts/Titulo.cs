using UnityEngine;
using UnityEngine.UI;

public class Titulo : MonoBehaviour
{
    public Text textoUI;
    public float velocidad = 5f;
    public GameObject cubo1;
    public GameObject cubo2;
    public GameObject cubo3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ejemplos numeros enteros
        textoUI.text = "Ejemplos numeros enteros:\n";

        int num1 = 1;
        int num2 = 2;
        textoUI.text += num1 + num2 + "\n";     // 3

        int numeroMaximo = int.MaxValue;        //2147483647
        int numeroMinimo = int.MinValue;        //-2147483648
        uint numeroMaximoU = uint.MaxValue;     //4294967295
        uint numeroMinimoU = uint.MinValue;     //0

        textoUI.text += "Numero maximo int: " + numeroMaximo + "\n";        //2147483647
        textoUI.text += "Numero minimo int: " + numeroMinimo + "\n";        //-2147483648
        textoUI.text += "Numero maximo uint: " + numeroMaximoU + "\n";      //4294967295
        textoUI.text += "Numero minimo uint: " + numeroMinimoU + "\n";      //0

        int max = numeroMaximo + 1;         //causara un overflow
        int min = numeroMinimo - 1;         //causara un underflow
        uint maxU = numeroMaximoU + 1;      //causara un overflow
        uint minU = numeroMinimoU - 1;      //causara  un underflow

        textoUI.text += "Numero maximo int + 1: " + max + "\n";        //2147483647
        textoUI.text += "Numero minimo int - 1: " + min + "\n";        //-2147483648
        textoUI.text += "Numero maximo uint + 1: " + maxU + "\n";      //0
        textoUI.text += "Numero minimo uint - 1: " + minU + "\n";      //4294967295

        //ejemplos numeros reales 
        textoUI.text += "\n Ejemplos numeros reales :\n";

        float num3 = 0.5f;
        float num4 = 3f;
        textoUI.text += num3 + num4 + "\n";     // 3.5

        float floatNumero = 1.123456789f;           //6-9 digitos de precision aprox
        double doubleNumero = 1.123467890123456;    //15-17 digitos de precision aprox

        textoUI.text += "Numero float: " + floatNumero + "\n";      //1.123457
        textoUI.text += "Numero double: " + doubleNumero + "\n";    //1.1234678901235
    }

    private void Update()
    {
        //rotamos los cubos 1 y 2
        cubo2.transform.Rotate(0, velocidad * Time.deltaTime, 0);
        cubo1.transform.Rotate(0, velocidad * Time.deltaTime, 0);
    }

    private void FixedUpdate()
    {
        //rotamos el cubo 3
        cubo3.transform.Rotate(0, velocidad * Time.deltaTime, 0);
    }
}
