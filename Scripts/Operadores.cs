using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//><

public class Operadores : MonoBehaviour
{
    public Text texto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int precio1 = 5, precio2 = 10;
        int coste = precio1 * precio2 * 2;
        texto.text = $"coste: {coste}\n";       //100
        int media1 = precio1 + precio2 / 2;
        texto.text += $"media1: {media1}\n";    //10
        int media2 = (precio1 + precio2) / 2;
        texto.text += $"media2: {media2}\n";    //7
        float media3 = (precio1 + precio2) / 2;
        texto.text += $"media3: {media3}\n";    //7
        float media4 = (precio1 + precio2) / 2f;
        texto.text += $"media4: {media4}\n\n";  //7,5


        precio1 = 10;
        precio2 = 30;
        precio1 += precio2;
        texto.text += $"precio1: {precio1}\n";          //40
        precio2 -= precio1 * -2;
        texto.text += $"precio2: {precio2}\n";          //110
        bool barato = precio1 > precio2;
        texto.text += $"barato: {barato}\n";            //False
        bool iguales1 = 150 == (precio1 + precio2);
        texto.text += $"iguales1: {iguales1}\n";        //True
        bool iguales2 = 150 == precio1 + precio2;
        texto.text += $"iguales2: {iguales2}\n";        //True
        bool distintos = precio1 != precio2;
        texto.text += $"distintos: {distintos}\n\n";    //True

        int a = 1, b = 2, c = 5, d = 2;
        bool condicion1 = true, condicion2 = false, resultado;

        resultado = condicion1 && condicion2;
        texto.text += $"resultados: {resultado} |";         //False
        resultado = condicion1 || condicion2;
        texto.text += $" {resultado} |";                    //True
        resultado = condicion1 && a < b;                    
        texto.text += $" {resultado} |";                    //True
        resultado = condicion2 && a < b;                    
        texto.text += $" {resultado} |";                    //False
        resultado = condicion1 && !condicion2;
        texto.text += $" {resultado} |";                    //True
        resultado = !(condicion1 && !condicion2);
        texto.text += $" {resultado} |";                    //False
        resultado = !(condicion1 && condicion2);
        texto.text += $" {resultado} |";                    //True
        resultado = condicion1 ^ condicion2;
        texto.text += $" {resultado} |";                    //True
        resultado = condicion1 ^ a != b;
        texto.text += $" {resultado} |";                    //False
        resultado = !condicion1 ^ !(a != b);
        texto.text += $" {resultado} |";                    //False
        resultado = !(condicion1 ^ a != b);                
        texto.text += $" {resultado}\n\n";                    //True 

        a = 10;
        b = 20;
        c = 5;
        d = 2;
        bool condicion = true;
        int expresion = a + b * c / d - (condicion ? a : b) + (b > a ? c : d) + (a + b) / (c + 1) - (d > 1 ? (c * d + a) : (b / d + a));
        texto.text += $"expresion {expresion}\n";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
