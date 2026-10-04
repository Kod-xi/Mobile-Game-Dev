using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class RenderScaleProbe : MonoBehaviour
{
    [Range(0.3f, 1f)] public float lowScale = .5f;
    UniversalRenderPipelineAsset _urp;
    float _full;

    [SerializeField] private GameObject probeButton;

    void Start()
    {
        _urp = GraphicsSettings.currentRenderPipeline as UniversalRenderPipelineAsset;
        _full = _urp.renderScale;

        if (probeButton != null) probeButton.SetActive(Debug.isDebugBuild);
    }

    public void Toggle()
    {
        bool atFull = Mathf.Approximately(_urp.renderScale, _full);
        _urp.renderScale = atFull ? lowScale : _full;
        Debug.Log($"[Probe] renderScale = {_urp.renderScale}");
    }
}
