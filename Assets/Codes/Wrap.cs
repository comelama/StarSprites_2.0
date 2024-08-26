using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrap : MonoBehaviour
{
    private void Update()
    {
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);

        Vector3 moveAdjustment = Vector3.zero;
        if (viewportPosition.x < 0) {
          moveAdjustment.x += 1.08f;
        } else if (viewportPosition.x > 1.08f) {
          moveAdjustment.x -= 1.08f;
        } else if (viewportPosition.y < 0) { 
          moveAdjustment.y += 1.08f;
        } else if(viewportPosition.y > 1.08f) {
          moveAdjustment.y -= 1.08f;
        }

        transform.position = Camera.main.ViewportToWorldPoint(viewportPosition + moveAdjustment);
    }
}
