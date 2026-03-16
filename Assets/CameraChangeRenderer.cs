using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CameraChangeRenderer : MonoBehaviour
{
    private Camera _camera;
    private UniversalAdditionalCameraData additionalData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _camera = this.GetComponent<Camera>();
        additionalData = this.GetComponent<UniversalAdditionalCameraData>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setRenderer(int index)
    {
        additionalData.SetRenderer(index);
    }
}
