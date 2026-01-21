using UnityEngine;

public class Background : MonoBehaviour
{
    public float ScrollSpeed =0.7f;
    private Material myMaterial;
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newoffset =myMaterial.mainTextureOffset;
        newoffset.Set(0,newoffset.y+(ScrollSpeed*Time.deltaTime));
        myMaterial.mainTextureOffset = newoffset;
    }
}
