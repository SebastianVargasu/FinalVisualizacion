using UnityEngine;

public class ContinuousRotation : MonoBehaviour
{
    public float rotationSpeed = 20f; // Velocidad de rotación en grados por segundo
    private Quaternion targetRotation;

    private void Start()
    {
        targetRotation = transform.rotation;
    }

    private void Update()
    {
        // Actualiza la rotación objetivo para rotar 20 grados cada segundo en el eje Y
        targetRotation *= Quaternion.Euler(0f, rotationSpeed * Time.deltaTime, 0f);

        // Interpola suavemente hacia la rotación objetivo
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
}
