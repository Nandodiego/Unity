using UnityEngine;

public class Transformaciones : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // mueve el objeto actual a la posicion (3,2,1)
        //transform.position = new Vector3(3, 2, 1);
        //mueve el  objeto actual 1 unidad hacia la derecha
        //transform.position += Vector3.right;
        // mueve el objeto actual 10 unidades hacia la derecha;
        //transform.position += Vector3.right * 10;

        //DIA 2

        // rota el objeto 45 grados alrededor del eje Y:
        //transform.rotation = Quaternion.Euler(0, 45, 0);
        // incrementa la rotacion del objeto en 15 grados alrededor el eje Z
        //transform.rotation = Quaternion.Euler(0, 0, 15);
        // establece la rotacion del objeto a su rotacion original (sin rotacion)
        //transform.rotation = Quaternion.identity;


        //DIA 3

        //escala a un tamaño especifico, objeto a (2,2,2)
        //transform.localScale = new Vector3(2, 2, 2);
        // aumenta el tamaño del objeto en una unidad en todos los ejes
        transform.localScale += new Vector3(1, 1, 1);
        // escala el objeto al doble de su tamaño actual
        transform.localScale *= 2;
        // incrementa el tamaño del objeto en el eje Y en 0.5 unidades
        transform.localScale += new Vector3(0, 0.5f, 0);
        //reestablece el tamaño del objeto a su tamaño original
        //transform.localScale = Vector3.one;
    }

}
