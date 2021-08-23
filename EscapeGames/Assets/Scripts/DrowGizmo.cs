#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrowGizmo : MonoBehaviour
{
    [SerializeField]
    enum MODE
    {
        CUBE,
        WIRECUBE,
        SPHERE,
        WIRESPHERE
    }

    [SerializeField,Header("描画モード選択")]
    MODE m_mode;

    [SerializeField, Range(0,5),Header("ギズモの大きさ")]
    float m_gizmoSize = 0.3f;

    [SerializeField, Header("ギズモの色")]
    Color m_gizmoColor = new Color(1f, 0, 0, 0.3f);

    void OnDrawGizmos()
    {
        Gizmos.color = m_gizmoColor;

        Vector3 thisObjPos = this.gameObject.transform.position;
        switch (m_mode)
        {
            case MODE.CUBE:
                Gizmos.DrawCube(thisObjPos,Vector3.one*m_gizmoSize);
                break;

            case MODE.SPHERE:
                Gizmos.DrawSphere(thisObjPos, m_gizmoSize);
                break;

            case MODE.WIRECUBE:
                Gizmos.DrawWireCube(thisObjPos, Vector3.one * m_gizmoSize);
                break;

            case MODE.WIRESPHERE:
                Gizmos.DrawWireSphere(thisObjPos, m_gizmoSize);
                break;
        }

    }

}
#endif