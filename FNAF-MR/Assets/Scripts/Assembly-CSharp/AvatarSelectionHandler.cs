using System;
using System.Collections.Generic;
using UnityEngine;

public class AvatarSelectionHandler
{
	private readonly Transform _avatarCellParent;

	private readonly AvatarCell _avatarCellPrefab;

	private List<ICellInterface<AvatarCellDataPack>> _avatarCells;

	private Action<string> _selectAvatarCell;

	private PlayerAvatarIconHandler _avatarIconLookup;

	private void ClearCells()
	{
		if (_avatarCells == null)
		{
			return;
		}
		foreach (AvatarCell avatarCell in _avatarCells)
		{
			UnityEngine.Object.Destroy(avatarCell.gameObject);
		}
		_avatarCells.Clear();
	}

	public AvatarSelectionHandler(Transform avatarCellParent, AvatarCell avatarCellPrefab, Action<string> selectAvatarCell, PlayerAvatarIconHandler avatarIconLookup)
	{
		_avatarCells = new List<ICellInterface<AvatarCellDataPack>>();
		_avatarCellParent = avatarCellParent;
		_avatarCellPrefab = avatarCellPrefab;
		_selectAvatarCell = selectAvatarCell;
		_avatarIconLookup = avatarIconLookup;
	}

	public void GenerateCells()
	{
		ClearCells();
		foreach (string allAvatarID in _avatarIconLookup.GetAllAvatarIDs())
		{
			AvatarCell avatarCell = UnityEngine.Object.Instantiate(_avatarCellPrefab, _avatarCellParent);
			AvatarCellDataPack avatarCellDataPack = new AvatarCellDataPack();
			avatarCellDataPack.id = allAvatarID;
			avatarCellDataPack.SelectCell = _selectAvatarCell;
			avatarCell.SetData(avatarCellDataPack);
			_avatarIconLookup.GetAvatarProfileSprite(allAvatarID, avatarCell.SetSprite);
			_avatarCells.Add(avatarCell);
		}
	}
}
