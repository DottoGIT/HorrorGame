using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrucialController : MonoBehaviour
{
    [SerializeField] Material baseMaterial;
    [SerializeField] Material HighLightMaterial;
    [SerializeField] Renderer BallRenderer;
    private CrucialController LastCrucial;

    private void Update()
    {

        var ray = FlashLightController.ViewRay;
        RaycastHit hit;

        if (LastCrucial != null)
        { 
            LastCrucial.BackToDefault();
        }


        if(Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            var selectionTypeCheck = selection.GetComponent<CrucialController>();
            if (selectionTypeCheck != null && Input.GetMouseButton(0))
            {
                selectionTypeCheck.Highlight();
                LastCrucial = selectionTypeCheck;
            }
        }
    }

    public void Highlight()
    {
      
    }

    public void BackToDefault()
    {
        BallRenderer.material = baseMaterial;
    }
}
