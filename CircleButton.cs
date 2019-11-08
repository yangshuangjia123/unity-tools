using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//直接把这个代码替代ugui的button按钮上的image脚本，然后再给这个按钮加一个Circle Collider2D就行了，Circle Collider2D的区域就是点击的区域。
//同理不规则图形的按钮都可以做了
public class CircleButton : Image
{
    private CircleCollider2D collider2d;
    void Start()
    {
        collider2d = GetComponent<CircleCollider2D>();
    }
    public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)

    {
        bool isRay = base.IsRaycastLocationValid(screenPoint, eventCamera);
        if (isRay && (collider2d != null))
        {
            bool isTrig = collider2d.OverlapPoint(screenPoint);
            return isTrig;
        }
        return isRay;
    }
}
