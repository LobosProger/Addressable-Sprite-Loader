using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableSpriteLoader : MonoBehaviour
{
	[Header("Link on the sprite")]
	[SerializeField] private AssetReference loadableSpriteAsset;
	[SerializeField] private SpriteRenderer spriteRenderer;

	private AsyncOperationHandle<Sprite> asyncOperationHandle;

	public void LoadSpriteFromMemory()
	{
		if(loadableSpriteAsset != null && spriteRenderer != null)
		{
			StartCoroutine(LoadingSpriteFromMemory());
		}
	}

	public void UnloadSpriteInMemory()
	{
		spriteRenderer.sprite = null;
		Addressables.Release(asyncOperationHandle);
	}

	private IEnumerator LoadingSpriteFromMemory()
	{
		asyncOperationHandle = loadableSpriteAsset.LoadAssetAsync<Sprite>();
		yield return asyncOperationHandle;

		if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
		{
			// Sprite is loaded from memory and ready for usage
			Sprite sprite = asyncOperationHandle.Result;
			spriteRenderer.sprite = sprite;
		}
	}
}