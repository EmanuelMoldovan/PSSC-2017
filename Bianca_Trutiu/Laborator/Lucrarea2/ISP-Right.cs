
namespace Examples.ISP
{
    interface IWorkOnTask
    {
        int WorkOnTask(string taskId);        
    }
	interface IWorkAssign
    {       
        int AssignTask(string taskId, string developerName);        
    }
	interface IWorkCloseTask
    {       
        int CloseTask(string taskId);
    }
	
	public class TeamLeader : IWorkAssign,IWorkOnTask
    {
        public int AssignTask(string taskId, string developerName)
        {
            // assign the task with taskId for developer with name developerName

            return 1;
        }

        public int WorkOnTask(string taskId)
        {
            // implement a new functionality

            return 1;
        }
    }
	
	 public class Developer : IWorkOnTask
    {
        public int WorkOnTask(string taskId)
        {
            // implement a new functionality

            return 1;
        }
    }
	
	public class BussinessAnalyst : IWorkAssign, IWorkCloseTask
    {
        public int AssignTask(string taskId, string developerName)
        {
            // assign the task with taskId for developer with name developerName

            return 1;
        }

        public int CloseTask(string taskId)
        {
            // verify the status for the task with taskId
            // if done --> mark the task as closed

            return 1;
        }
    }
}