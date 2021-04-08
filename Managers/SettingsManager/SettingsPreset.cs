﻿using Canty;
using UnityEngine;
using Canty.Managers;

#if UNITY_EDITOR
using UnityEditor;
#endif

/// <summary>
/// Easy preset object with the regular Unity-provided settings.
/// </summary>
public class SettingsPreset : ScriptableObject
{
    // Graphics
    public int PixelLightCount = 4;
    public SettingsManager.TextureQualityTypes TextureQuality = SettingsManager.TextureQualityTypes.FullRes;
    public bool AnisotropicFiltering = true;
    public SettingsManager.AntiAliasingTypes AntiAliasing = SettingsManager.AntiAliasingTypes.MSAAx8;
    public bool SoftParticles = true;
    public bool RealtimeReflectionProbe = true;
    public int VSyncCount = 1;
    [Space(20)]

    // Shadows
    public ShadowQuality ShadowQualityType = ShadowQuality.All;
    public ShadowResolution ShadowResolutionType = ShadowResolution.VeryHigh;
    public ShadowProjection ShadowProjectionType = ShadowProjection.StableFit;
    public SettingsManager.ShadowDistanceTypes ShadowDistance = SettingsManager.ShadowDistanceTypes.Ultra;
    public ShadowmaskMode ShadowmaskModeType = ShadowmaskMode.DistanceShadowmask;
    public int ShadowNearPlaneOffset = 3;
    public SettingsManager.ShadowCascadeTypes ShadowCascadeType = SettingsManager.ShadowCascadeTypes.FourCascade;

#if UNITY_EDITOR
    /// <summary>
    /// Create a SettingsPreset object.
    /// </summary>
    [MenuItem("Assets/Create/Canty/Managers/Settings Preset")]
    public static void CreateAsset()
    {
        EditorUtil.CreateScriptableObject<SettingsPreset>();
    }
#endif
}
