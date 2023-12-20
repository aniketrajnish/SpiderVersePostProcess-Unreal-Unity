using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Serializable, VolumeComponentMenuForRenderPipeline("Makra/Stylized Bloom", typeof(UniversalRenderPipeline))]
public class StylizedPP : VolumeComponent, IPostProcessComponent
{
    [Header("Copy Pasta Bloom Settings")]
    public FloatParameter threshold = new FloatParameter(0.9f, true);

    public FloatParameter intensity = new FloatParameter(1, true);

    public ClampedFloatParameter scatter = new ClampedFloatParameter(0.7f, 0, 1, true);

    [HideInInspector] public IntParameter clamp = new IntParameter(65472, true);

    [HideInInspector] public ClampedIntParameter maxIterations = new ClampedIntParameter(6, 0, 10);

    [HideInInspector] public NoInterpColorParameter tint = new NoInterpColorParameter(Color.white);

    [Header("Benday Dots Settings")]
    public IntParameter dotsDensity = new IntParameter(10, true);

    public ClampedFloatParameter dotsCutoff = new ClampedFloatParameter(0.4f, 0, 1, true);

    public Vector2Parameter scrollVelocity = new Vector2Parameter(new Vector2());

    public bool IsActive()
    {
        if (!AnyPropertiesIsOverridden())
        {
            return false;
        }
        return (intensity.value > 0);
    }

    public bool IsTileCompatible() => true;
}
