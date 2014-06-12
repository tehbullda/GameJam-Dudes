using UnityEngine;
using System.Collections;

public class SetAlpha : MonoBehaviour
{

    public float DesiredAlpha;

    // Use this for initialization
    void Start() {
        if (DesiredAlpha > 0.0f && DesiredAlpha < 1.0f)
        {
            //renderer.material.SetColor();
            Color newColor;
            newColor = renderer.material.color;
            newColor.a = DesiredAlpha;
            renderer.material.color = newColor;// 1.0f;
            //renderer.material.color.a = DesiredAlpha;
        }
	}

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        DestroyImmediate(renderer.material);
    }
}
