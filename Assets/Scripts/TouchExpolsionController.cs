using UnityEngine;

public class TouchExpolsionController : MonoBehaviour
{
    public GameObject explosionObject;

	void Update ()
    {
        ClickChecker();
    }

    void ClickChecker()
    {
        //on click/touch create an explosion effect on a Collider
        if(Input.GetMouseButtonDown(0))
        {
            Ray charles = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInformation;
            bool hit = Physics.Raycast(charles, out hitInformation);

            if (hit)
            {
                GameObject explosionCloneObjectThatICreatedOnLine21 = Instantiate(explosionObject);
                explosionCloneObjectThatICreatedOnLine21.transform.position = hitInformation.point;
                explosionCloneObjectThatICreatedOnLine21.transform.up = hitInformation.normal;

                Destroy(explosionCloneObjectThatICreatedOnLine21, 5f);
            }
        }
    }
}
