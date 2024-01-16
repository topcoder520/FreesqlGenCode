using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class TaskUtilExtend
    {
        public static async void Await(this Task task,Action? success,Action<Exception>? fail)
        {
			try
			{
				await task;
				success?.Invoke();
            }
			catch (Exception e)
			{
				fail?.Invoke(e);
			}
        }
    }
}
