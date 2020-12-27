using UniGLTF;
using UnityEngine;

public class GLTFImporter : MonoBehaviour
{
    public string pathToGltf;

    public void Start()
    {
        LoadGLTF();
    }

    public void LoadGLTF()
    {
        var context = new ImporterContext();
        context.Load(pathToGltf);
        context.ShowMeshes();
    }
}
