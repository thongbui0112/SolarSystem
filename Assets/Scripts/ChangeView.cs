using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour
{
    public GameObject target;
    private void OnMouseDown()
    {
        LookAt.target = this.target;
        Camera.main.fieldOfView = Mathf.Clamp(25 * target.transform.localScale.x, 1, 100);
    }
}
