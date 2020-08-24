//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.1, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using JCMG.EntitasRedux.Blueprints;
using UnityEngine;

/// <summary>
/// Represents a group of <see cref="JCMG.EntitasRedux.IComponent"/> instances that can be copied to one or more
/// <see cref="GameEntity"/>.
/// </summary>
[CreateAssetMenu(fileName = "NewGameBlueprint", menuName = "EntitasRedux/Game/GameBlueprint")]
public partial class GameBlueprint : BlueprintBase, IGameBlueprint
{
	/// <summary>
	/// Applies all components in the blueprint to <paramref name="entity"/>.
	/// </summary>
	/// <param name="entity"></param>
	public void ApplyToEntity(GameEntity entity)
	{
		for (var i = 0; i < _components.Count; i++)
		{
			var component = _components[i];
			if(_components[i] == null)
			{
				continue;
			}

			var index = GameComponentsLookup.GetComponentIndex(component);
			if (index != -1)
			{
				entity.AddComponent(index, component);
			}
			else
			{
				Debug.LogWarningFormat(
					JCMG.EntitasRedux.RuntimeConstants.COMPONENT_INDEX_DOES_NOT_EXIST_FOR_TYPE_FORMAT,
					component.GetType(),
					typeof(GameComponentsLookup));
			}
		}
	}

	protected override void OnValidate()
	{
		base.OnValidate();

		// Remove any components that no longer belong to this context.
		for (var i = _components.Count - 1; i >= 0; i--)
		{
			var index = GameComponentsLookup.GetComponentIndex(_components[i]);
			if (index == -1)
			{
				_components.RemoveAt(i);
			}
		}
	}
}
