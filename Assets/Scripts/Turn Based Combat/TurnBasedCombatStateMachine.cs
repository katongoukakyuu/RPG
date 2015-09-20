using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {

	public enum BattleStates {
		NONE,
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN
	};

	private BattleStates currentState;

	void Start() {
		currentState = BattleStates.START;
	}

	void Update() {
		switch (currentState) {
		case BattleStates.START:
			break;
		case BattleStates.PLAYERCHOICE:
			break;
		case BattleStates.ENEMYCHOICE:
			break;
		case BattleStates.LOSE:
			break;
		case BattleStates.WIN:
			break;
		default:
			break;
		}
		Debug.Log (currentState);
	}

	void OnGUI() {
		if (GUILayout.Button ("NEXT STATE")) {
			switch (currentState) {
			case BattleStates.START:
				currentState = BattleStates.PLAYERCHOICE;
				break;
			case BattleStates.PLAYERCHOICE:
				currentState = BattleStates.ENEMYCHOICE;
				break;
			case BattleStates.ENEMYCHOICE:
				currentState = BattleStates.LOSE;
				break;
			case BattleStates.LOSE:
				currentState = BattleStates.WIN;
				break;
			case BattleStates.WIN:
				currentState = BattleStates.START;
				break;
			default:
				break;
			}
		}
	}
}
