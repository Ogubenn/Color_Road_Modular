using UnityEngine;

public class FallScript : MonoBehaviour
{
    public GameObject objePrefab; 
    public Transform dusmeNoktasi; 
    private Rigidbody objeRigidbody; 
    public GameObject ground;

    void Start()
    {
        objeRigidbody = objePrefab.GetComponent<Rigidbody>(); 
        InvokeRepeating("InstantiateVeBirak", 0f, 10f); 
    }

    void InstantiateVeBirak()
    {
        GameObject yeniObje = Instantiate(objePrefab, dusmeNoktasi.position, Quaternion.identity); 
        yeniObje.SetActive(true); 
        objeRigidbody = yeniObje.GetComponent<Rigidbody>();

        
        objeRigidbody.isKinematic = false; 
        objeRigidbody.velocity = Vector3.zero; 
        objeRigidbody.angularVelocity = Vector3.zero; 
    }
}
