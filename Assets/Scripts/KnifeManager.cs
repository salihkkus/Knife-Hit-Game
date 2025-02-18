using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class KnifeManager : MonoBehaviour
{
  [SerializeField] private List<GameObject> knifeList = new List<GameObject>();
  [SerializeField] private GameObject knifePrefab;
  [SerializeField] private int knifeCount;
  private int knifeIndex = 0;

    void Start()
    {
        CreateKnife();
    }

    private void CreateKnife()
    {
        for(int i=0; i < knifeCount; i++)
        {
          GameObject newKnife = Instantiate(knifePrefab , transform.position , quaternion.identity);
          newKnife.SetActive(false);
          knifeList.Add(newKnife);
        }

        knifeList[0].SetActive(true);
    }

    public void SetActiveKnife()
    {
      if(knifeIndex < knifeCount - 1)
      {
        knifeIndex++;
        knifeList[knifeIndex].SetActive(true);
      }
    }

}
