/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.MoveitTutorials
{
    public class PlanPathAction : Action<PlanPathActionGoal, PlanPathActionResult, PlanPathActionFeedback, PlanPathGoal, ExecutePathResult, PlanPathFeedback>
    {
        [JsonIgnore]
        public const string RosMessageName = "moveit_tutorials/PlanPathAction";

        public PlanPathAction() : base()
        {
            this.action_goal = new PlanPathActionGoal();
            this.action_result = new PlanPathActionResult();
            this.action_feedback = new PlanPathActionFeedback();
        }

    }
}
