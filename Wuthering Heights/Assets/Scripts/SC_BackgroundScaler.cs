using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class SC_BackgroundScaler : MonoBehaviour
{
    private Image backgroundImage;
    private RectTransform rt;
    private float ratio;

    void Start()
    {
        // Get the Image component and RectTransform
        backgroundImage = GetComponent<Image>();
        rt = backgroundImage.rectTransform;

        // Ensure the sprite is set and accessible
        if (backgroundImage.sprite != null)
        {
            // Calculate the aspect ratio of the sprite
            ratio = backgroundImage.sprite.bounds.size.x / backgroundImage.sprite.bounds.size.y;
        }
        else
        {
            Debug.LogError("No sprite found on the Image component.");
        }
    }

    void Update()
    {
        // If there is no RectTransform or the sprite is missing, return early
        if (!rt || backgroundImage.sprite == null)
            return;

        // Calculate the desired size based on screen dimensions while preserving the aspect ratio
        float screenAspect = (float)Screen.width / Screen.height;

        // Check if the aspect ratio of the screen and sprite are aligned
        if (screenAspect >= ratio)
        {
            // Scale the background to fit the width
            rt.sizeDelta = new Vector2(Screen.width, Screen.width / ratio);
        }
        else
        {
            // Scale the background to fit the height
            rt.sizeDelta = new Vector2(Screen.height * ratio, Screen.height);
        }
    }
}