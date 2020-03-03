/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

using RosSharp.RosBridgeClient.Messages.Standard;
using RosSharp.RosBridgeClient.MessageTypes.Actionlib;

namespace RosSharp.RosBridgeClient.MessageTypes.MoveitTutorials
{
    public class ExecutePathActionResult : ActionResult<ExecutePathResult>
    {
        [JsonIgnore]
        public const string RosMessageName = "moveit_tutorials/ExecutePathActionResult";

        public ExecutePathActionResult() : base()
        {
            this.result = new ExecutePathResult();
        }

        public ExecutePathActionResult(Header header, GoalStatus status, ExecutePathResult result) : base(header, status)
        {
            this.result = result;
        }
    }
}