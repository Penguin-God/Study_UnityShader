using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBR_Script : MonoBehaviour
{
    private Renderer render = null;

    // 인스펙터에서 가져온 메테리얼을 바꾸면 메테리얼 자체가 바뀌는 것이기 때문에 같은 메테리얼을 쓰는 다른 오브젝트에도 영향을 줌
    // mt = render.material; 형식으로 가져오면 렌더러 컴포넌트에 있는 메테리얼에 접근하는 것이므로 독립적임 (메테리얼을 직접 바꾸지 않음)
    //[SerializeField] Material mt = null;

    void Start()
    {
        //mt.SetFloat("_Vector1", 1);


        render = GetComponent<Renderer>();
        // Renderer 에 matrerial 프로퍼티가 있음 
        render.material.SetFloat("_Vector1", 1);
    }
}
