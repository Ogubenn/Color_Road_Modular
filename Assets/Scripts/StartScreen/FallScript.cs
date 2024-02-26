using UnityEngine;

public class FallScript : MonoBehaviour
{
    public GameObject objePrefab; // Býrakýlacak obje
    public Transform dusmeNoktasi; // Düþürme noktasý
    private Rigidbody objeRigidbody; // Býrakýlacak objenin Rigidbody bileþeni
    public GameObject ground;

    void Start()
    {
        objeRigidbody = objePrefab.GetComponent<Rigidbody>(); // Objeye ait Rigidbody bileþenini al
        InvokeRepeating("InstantiateVeBirak", 0f, 10f); // Belirli aralýklarla InstantiateVeBirak fonksiyonunu çaðýr
    }

    void InstantiateVeBirak()
    {
        GameObject yeniObje = Instantiate(objePrefab, dusmeNoktasi.position, Quaternion.identity); // Yeni bir obje instantiate et
        yeniObje.SetActive(true); // Objeyi aktifleþtir
        objeRigidbody = yeniObje.GetComponent<Rigidbody>(); // Yeni objenin Rigidbody bileþenini al

        // Yeni objeyi býrakma iþlemi
        objeRigidbody.isKinematic = false; // Kinematik olmayan bir rigidbody'e sahip olmasý için ayarla
        objeRigidbody.velocity = Vector3.zero; // Hýzýný sýfýrla
        objeRigidbody.angularVelocity = Vector3.zero; // Açýsal hýzýný sýfýrla
    }
}
