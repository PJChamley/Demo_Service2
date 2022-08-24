using Demo.Common;

namespace Demo.Service2
{
    public class Service2 : IService
    {
        public string ValuePassedIn { get; set; }

        public string DoSomeWork()
        {
            return $"Value: ${ValuePassedIn} was found in {Environment.NewLine}Property:'ValuePassedIn' ";
        }
        public string FakeMethodHere()
        {
            return "Service 2 - Fake Method";
        }
    }
}