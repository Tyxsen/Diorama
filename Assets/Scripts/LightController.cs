using UnityEngine;

[ExecuteInEditMode] // This makes it run in the editor, not just in-game
public class LightController : MonoBehaviour
{
    [SerializeField]
    private Material terrainMaterial; // Drag your "DioramaMaterial" here

    [SerializeField]
    private Light directionalLight; // Drag your scene's Directional Light here

    // IMPORTANT: Change this string to match your property's "Reference" name!
    private string shaderPropertyName = "_Light_Direction";


    void Update()
    {
        // Check if we have the material and light
        if (terrainMaterial == null || directionalLight == null)
        {
            return; // Do nothing if anything is missing
        }

        // Get the light's direction
        // .transform.forward is the direction the light is pointing.
        // Shaders usually want the direction the light is COMING FROM,
        // so we pass the negative .forward vector.
        Vector3 lightDir = -directionalLight.transform.forward;

        // Send the light direction to the shader
        terrainMaterial.SetVector(shaderPropertyName, lightDir);

        // --- Bonus: Pass the light color too! ---
        // If you have a "Light Color" property (e.g., "_Light_Color"),
        // you can uncomment this line:
        // terrainMaterial.SetColor("_Light_Color", directionalLight.color);
    }
}