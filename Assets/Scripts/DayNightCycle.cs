using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Durée du cycle en secondes")]
    public float dayDuration = 60f;

    [Header("Référence au Soleil")]
    public Light sun;

    void Update()
    {
        if (sun != null)
        {
            // Calcul de la rotation pour chaque frame
            float rotationThisFrame = (360f / dayDuration) * Time.deltaTime;
            sun.transform.Rotate(Vector3.right, rotationThisFrame);
        }
    }
}
