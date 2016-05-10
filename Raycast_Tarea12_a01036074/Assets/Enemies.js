#pragma strict
var goal: Transform;
function Start () {
      
}

function Update () {
	var agent: NavMeshAgent = GetComponent.<NavMeshAgent>();
  	agent.SetDestination(goal.transform.position);
}