using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using _1_intro_async_await;
using _2_task_parallel_library;
using _3_parallel_for_foreach_invoke;
using _4_asynchronous_programming_othertopics;
using _5_parallel_linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PlinqTests
    {
        [TestMethod]
        public void _1_Plinq_Tests()
        {
            _1_Plinq taskrun = new _1_Plinq();
            taskrun.DoWork();
        }

        [TestMethod]
        public void _1_Plinq_OddNumbers_Tests()
        {
            _1_Plinq taskrun = new _1_Plinq();
            taskrun.DoWork2();
        }

        [TestMethod]
        public void _1_Plinq_EvenNumbers_Tests()
        {
            _1_Plinq taskrun = new _1_Plinq();
            taskrun.DoWork3();
        }
    }
}
