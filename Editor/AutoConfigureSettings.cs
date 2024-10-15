using UnityEditor;
using UnityEngine; // For Debug.Log

[InitializeOnLoad]
public static class AutoConfigureSettings
{
    static AutoConfigureSettings()
    {
        SetManagedStrippingLevelAndCompression();
    }

    private static void SetManagedStrippingLevelAndCompression()
    {
        // Check if the active build target is WebGL
        if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.WebGL)
        {
            // Convert BuildTarget to BuildTargetGroup
            BuildTargetGroup buildTargetGroup = BuildTargetGroup.WebGL;

            // Set managed stripping level to Minimal if not already set
            var currentStrippingLevel = PlayerSettings.GetManagedStrippingLevel(buildTargetGroup);
            if (currentStrippingLevel != ManagedStrippingLevel.Minimal)
            {
                PlayerSettings.SetManagedStrippingLevel(buildTargetGroup, ManagedStrippingLevel.Minimal);
                Debug.Log("Managed stripping level set to Minimal for WebGL builds.");
            }

            // Set WebGL compression format to None if not already set
            if (PlayerSettings.WebGL.compressionFormat != WebGLCompressionFormat.Disabled)
            {
                PlayerSettings.WebGL.compressionFormat = WebGLCompressionFormat.Disabled;
                Debug.Log("WebGL compression format set to None (Disabled).");
            }
        }
    }
}
