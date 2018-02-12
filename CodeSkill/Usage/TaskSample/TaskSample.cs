using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeSkill.Usage.TaskSample
{
    internal class TaskSample
    {
        private async static void ThrowExceptionAsync()
        {
            var task = Task.Delay(TimeSpan.FromSeconds(10));
            //await task.Wait();
            task.Wait();
            //await Task.Delay(TimeSpan.FromSeconds(10))
            //    .ConfigureAwait(false);
            //await Task.Delay(TimeSpan.FromSeconds(10));
            //throw new InvalidOperationException("invalid operator exception"); // exception cannot be caught by high level
        }

        public static void AsyncVoidExceptions_CannotBeCaughtByCatch()
        {
            try
            {
                ThrowExceptionAsync();
                Console.WriteLine("ThrowExceptionAsync done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        private async static Task ThrowExceptionAsyncTask()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            throw new InvalidOperationException("invalid operator exception"); // exception cannot be caught by high level
        }

        public static async void AsyncTaskExceptions_CanBeCaughtByCatch()
        {
            try
            {
                await ThrowExceptionAsyncTask();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw ex;
            }
        }

        public static async Task AsyncTaskExceptions2_CanBeCaughtByCatch()
        {
            Task task = ThrowExceptionAsyncTask();
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw ex;
            }
        }

        public static Task<int> First()
        {
            return Task<int>.Factory.StartNew(() =>
            {
                throw new Exception(" Exception From First!");
            });
        }

        public static Task<int> Second()
        {
            return Task<int>.Factory.StartNew(() =>
            {
                throw new Exception(" Exception From Second!");
            });
        }

        public static async Task<int> Caclulate()
        {
            return await First() + await Second();
        }

        public static async void Test()
        {
            TaskSample taskSample = new TaskSample();
            TaskSample.AsyncVoidExceptions_CannotBeCaughtByCatch();
            //AsyncTaskExceptions_CanBeCaughtByCatch();
            //AsyncTaskExceptions2_CanBeCaughtByCatch();
            // var task = Caclulate();
            try
            {
                // await task;
                //Caclulate().Wait(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw ex;
            }
            Console.ReadKey();
        }
    }
}