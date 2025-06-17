using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatronicBillboardView : MonoBehaviour
{
	private const int _numBillboardToShow = 3;

	[SerializeField]
	private BillboardIndicator[] _billboardIndicators;

	[SerializeField]
	private GameObject _billboardBg;

	[SerializeField]
	private GameObject _billboardBgImage;

	private List<string> _cpuIds;

	private float _showDuration;

	private float _hideDuration;

	private TextAnim[] _textAnims;

	private void Awake()
	{
		_cpuIds = new List<string>(new string[5] { "FreddyFazbear", "Ballora", "ToyFreddy", "Mangle", "Springtrap" });
		HideAllBillboards();
	}

	public void Init()
	{
		_showDuration = 1f;
		_hideDuration = 0.2f;
	}

	public void ShowBillboardsFor(string cpuId)
	{
		if (!_cpuIds.Contains(cpuId))
		{
			HideAllBillboards();
			return;
		}
		List<int> list = GenerateIndicesToShow(_cpuIds.IndexOf(cpuId), _cpuIds.Count, 3);
		list.Shuffle();
		StartCoroutine(ShowBillboardsAtIndexForSeconds(list, GenerateIndicesToShow(list.IndexOf(_cpuIds.IndexOf(cpuId)), _textAnims.Length, list.Count), _showDuration, _hideDuration));
	}

	private List<int> GenerateIndicesToShow(int correctIndex, int numSourceOptions, int numOptionsToChoose)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < numSourceOptions; i++)
		{
			list.Add(i);
		}
		list.Remove(correctIndex);
		Debug.Log(list.Count);
		Debug.Log("Correct: " + correctIndex + " - SourceList: " + list[0] + " " + list[1]);
		List<int> list2 = GenerateNonRepeatingRandomElements(list, numOptionsToChoose - 1);
		list2.Add(correctIndex);
		return list2;
	}

	private IEnumerator ShowBillboardsAtIndexForSeconds(List<int> billboardIndices, List<int> animIndices, float showDuration, float hideDuration)
	{
		int loopIDX = 0;
		while (true)
		{
			_billboardBgImage.SetActive(value: false);
			ShowBillboardAtIndex(billboardIndices[loopIDX], animIndices[loopIDX]);
			yield return new WaitForSeconds(showDuration);
			HideAllBillboards();
			loopIDX++;
			if (loopIDX >= billboardIndices.Count)
			{
				break;
			}
			_billboardBgImage.gameObject.SetActive(value: true);
			yield return new WaitForSeconds(hideDuration);
		}
		_billboardBgImage.SetActive(value: false);
		yield return null;
	}

	private void ShowBillboardAtIndex(int billboardIndex, int animIndex)
	{
		if (_billboardIndicators.Length > billboardIndex && _textAnims.Length > animIndex)
		{
			BillboardIndicator obj = _billboardIndicators[billboardIndex];
			obj.gameObject.SetActive(value: true);
			_billboardBg.SetActive(value: true);
			obj.PlayAnimation(_textAnims[animIndex]);
		}
		else
		{
			HideAllBillboards();
		}
	}

	private void HideAllBillboards()
	{
		BillboardIndicator[] billboardIndicators = _billboardIndicators;
		for (int i = 0; i < billboardIndicators.Length; i++)
		{
			billboardIndicators[i].gameObject.SetActive(value: false);
		}
		_billboardBg.SetActive(value: false);
	}

	public AnimatronicBillboardView()
	{
		_showDuration = 1f;
		_hideDuration = 0.2f;
		_textAnims = new TextAnim[3]
		{
			TextAnim.Steady,
			TextAnim.Flashing,
			TextAnim.Jitter
		};
	}

	internal static List<int> GenerateNonRepeatingRandomElements(List<int> sourceList, int numToSelect)
	{
		int i = 0;
		int num = -1;
		List<int> list = new List<int>();
		for (; i < numToSelect; i++)
		{
			num = sourceList[Random.Range(0, sourceList.Count)];
			list.Add(num);
			sourceList.Remove(num);
		}
		return list;
	}
}
