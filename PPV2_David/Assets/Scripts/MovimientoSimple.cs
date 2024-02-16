using System.Collections;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovimientoSimple : MonoBehaviour
{
    public float velocidad = 5f;
    public int movimiento;

    void Update()
    {
        // Obtener la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, movimientoVertical, 0f);

        // Mover el objeto en la dirección calculada
        transform.Translate(movimiento* velocidad * Time.deltaTime, Space.World);
    }
}