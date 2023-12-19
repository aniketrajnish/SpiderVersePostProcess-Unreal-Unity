using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[System.Serializable]
public class StylizedRenderFeature : ScriptableRendererFeature
{
    [SerializeField]
    private Shader m_bloomShader;
    [SerializeField]
    private Shader m_stylShader;

    public Texture2D[] m_BlueNoise256Textures;

    private Material m_bloomMaterial;
    private Material m_StylMaterial;

    private StylizedPass m_stylPass;

    public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
    {
        if (renderingData.cameraData.cameraType == CameraType.Game)
        {
            renderer.EnqueuePass(m_stylPass);
        }
    }

    public override void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData)
    {
        if (renderingData.cameraData.cameraType == CameraType.Game)
        {
            m_stylPass.ConfigureInput(ScriptableRenderPassInput.Depth);
            m_stylPass.ConfigureInput(ScriptableRenderPassInput.Color);
            m_stylPass.SetTarget(renderer.cameraColorTargetHandle, renderer.cameraDepthTargetHandle);
        }
    }

    public override void Create()
    {
        m_bloomMaterial = CoreUtils.CreateEngineMaterial(m_bloomShader);
        m_StylMaterial = CoreUtils.CreateEngineMaterial(m_stylShader);
        m_stylPass = new StylizedPass(m_bloomMaterial, m_StylMaterial);
    }

    protected override void Dispose(bool disposing)
    {
        CoreUtils.Destroy(m_bloomMaterial);
        CoreUtils.Destroy(m_StylMaterial);
    }
}
