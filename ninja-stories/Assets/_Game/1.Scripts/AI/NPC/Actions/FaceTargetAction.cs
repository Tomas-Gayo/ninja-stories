using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "FaceTargetAction", menuName = "Scriptable Objects/FSM/Actions/FaceTargetAction")]
public class FaceTargetAction : FSMAction
{
    NPCSightSensor sensor;
    GameObject target;
    Transform NPC;

    public override void OnUpdate(BaseStateMachine stateMachine)
    {
        target = sensor.CurrentTarget;
        NPC = sensor.transform;

        if (target != null)
        {
            Vector3 relativePos = target.transform.position - NPC.position;
            relativePos.y = 0f;

            Quaternion rotation = Quaternion.LookRotation(relativePos);
            NPC.rotation = rotation;
        }
    }
    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        sensor = stateMachine.GetComponent<NPCSightSensor>();
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }
}
