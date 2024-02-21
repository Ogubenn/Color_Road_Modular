using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMaker : MonoBehaviour
{
    [SerializeField] GameObject groundPrefab;
    public int initialGroundCount = 20;
    public int recycleThreshold = 5; // Yeniden kullanýlabilir zemin sayýsý
    public float groundLength = 10f; // Zemin uzunluðu

    private List<GameObject> groundList = new List<GameObject>();
    private Transform playerTransform;
    private Vector3 nextGroundPosition;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; // Player'ý bul
        nextGroundPosition = Vector3.zero;

        for (int i = 0; i < initialGroundCount; i++)
        {
            SpawnGround();
        }
    }

    private void Update()
    {
        RecycleGround();
    }

    private void SpawnGround()
    {
        GameObject newGround = Instantiate(groundPrefab, nextGroundPosition, Quaternion.identity);
        nextGroundPosition += Vector3.forward * groundLength;
        groundList.Add(newGround);
    }

    private void RecycleGround()
    {
        if (playerTransform.position.z > recycleThreshold * groundLength) // Player tetikleyiciyi geçti mi?
        {
            GameObject oldGround = groundList[0]; // En eski zemin
            groundList.RemoveAt(0); // Listeden kaldýr

            Vector3 newPos = nextGroundPosition + Vector3.forward * groundLength;
            oldGround.transform.position = newPos; // Yeniden kullanmak üzere pozisyonu güncelle
            nextGroundPosition += Vector3.forward * groundLength;
            groundList.Add(oldGround); // Listeye ekle
        }
    }
}
