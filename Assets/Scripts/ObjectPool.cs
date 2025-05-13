using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private int count; //jumlah peluru yg di generate
    [SerializeField] private List<GameObject> generateObjects;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GeneratePoolObject();
        DeactivateAllObjects();
    }

    private void GeneratePoolObject()
    {
        bulletPrefab = (GameObject)Resources.Load("Prefabs/Bullet"); //akses folder prefabs lalu bullet
        for (int i=0; i<count; i++)
            {
                 
                generateObjects.Add(Instantiate(bulletPrefab, transform)); 
                //masukkin ke list .add() dan "transform" itu masukkin ke parent hierarchy
            }

        /* enemies:
        //klo mau load semua dalam suatu folder enemies:
        GameObject[] enemies = Resources.LoadAll<GameObject>("Prefabs/Enemies");
        //ditampung pada list enemies^^^
        for (int j=0; j<enemies.Length; j++)
        {
            for (int i=0; i<count; i++)
            {
                generateObjects.Add(Instantiate(enemies[j], transform)); 
                //generateObjects.Add(Instantiate(bulletPrefab, transform)); 
                //masukkin ke list .add() dan "transform" itu masukkin ke parent hierarchy
                
            }
        }
        */

    
        
    

    }

    private void DeactivateAllObjects()
    {
        foreach (GameObject obj in generateObjects)
        {
            obj.SetActive(false);
        }

        //atau
        //generateObjects.ForEach(obj => obj.SetActive(false));
    }
}
