using UnityEngine;

public class BackGround : MonoBehaviour
{
    // 자동 스크롤
    public float scrollSpeed = 1f;
    private Material myMaterial;

    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newOffset = myMaterial.mainTextureOffset;
        newOffset.Set(0,newOffset.y + (scrollSpeed * Time.deltaTime));

        myMaterial.mainTextureOffset = newOffset;
    }
}
