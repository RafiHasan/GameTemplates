using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class SpawnObjectAddressable : MonoBehaviour
{
    [SerializeField] AssetReference refrance;
    [SerializeField] AssetLabelReference refrancelabel;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Addressables.LoadAssetAsync<GameObject>("Assets/Prefabs/ResourceBar.prefab").Completed += SpawnObjectAddressable_Completed;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Addressables.LoadAssetAsync<GameObject>(refrance).Completed += SpawnObjectAddressable_Completed;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Addressables.LoadAssetAsync<GameObject>(refrancelabel).Completed += SpawnObjectAddressable_Completed;
        }
    }

    private void SpawnObjectAddressable_Completed(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> obj)
    {
        Instantiate(obj.Result,transform);
    }
}
