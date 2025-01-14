using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Transformers;

public class MG_manager : MonoBehaviour
{
    GameObject AmmoSlot;
    [SerializeField]
    GameObject AmmoBox;
    private bool AmmoSetUp = false;

    // Start is called before the first frame update
    void Start()
    {
        AmmoSlot = transform.GetChild(2).transform.gameObject;
        transform.GetChild(1).GetComponent<XRSimpleInteractable>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (AmmoSetUp == false)
        {
            if (Vector3.Distance(AmmoSlot.transform.position, AmmoBox.transform.position) < 0.1f)
            {
                SetUpAmmo();
                AmmoSetUp = true;
            }
        }
    }

    private void SetUpAmmo()
    {
        transform.GetChild(1).GetComponent<XRSimpleInteractable>().enabled = true;
        Destroy(AmmoBox.gameObject);
        AmmoSlot.transform.GetChild(0).gameObject.SetActive(true);
    }
}
