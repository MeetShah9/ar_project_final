using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        // Provide haptic feedback for phone devices
        ProvideHapticFeedback();

        // Load the "Marketplace" scene
        SceneLoader.Instance.LoadScene("Marketplace");
    }

    private void ProvideHapticFeedback()
    {
        // Check if the platform is Android or iOS for haptic feedback
        if (Application.isMobilePlatform)
        {
            // Vibrate the phone (works on Android and iOS)
            Handheld.Vibrate();
        }
        else
        {
            // If not a mobile platform, no haptic feedback
            Debug.Log("Haptic feedback is only supported on mobile devices.");
        }
    }
}
