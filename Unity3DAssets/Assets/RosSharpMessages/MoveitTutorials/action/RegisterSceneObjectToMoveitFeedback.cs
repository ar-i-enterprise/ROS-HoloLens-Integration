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
    public class RegisterSceneObjectToMoveitFeedback : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "moveit_tutorials/RegisterSceneObjectToMoveitFeedback";

        // feedback
        public string log;

        public RegisterSceneObjectToMoveitFeedback()
        {
            this.log = "";
        }

        public RegisterSceneObjectToMoveitFeedback(string log)
        {
            this.log = log;
        }
    }
}