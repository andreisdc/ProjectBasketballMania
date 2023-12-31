using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInitializer : MonoBehaviour, IUnityAdsInitializationListener
{
	[SerializeField] string _androidGameId = "5295551";
	[SerializeField] string _iOSGameId = "5295550";
	[SerializeField] bool _testMode = true;
	private string _gameId;

	void Awake()
	{
		InitializeAds();
	}

	public void InitializeAds()
	{
		_gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
			? _iOSGameId
			: _androidGameId;
		Advertisement.Initialize(_gameId, _testMode, this);
	}

	public void OnInitializationComplete()
	{
		Debug.Log("Unity Ads initialization complete.");
	}

	public void OnInitializationFailed(UnityAdsInitializationError error, string message)
	{
		Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
	}
}