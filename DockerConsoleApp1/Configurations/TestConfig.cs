
namespace DockerConsoleApp1.Configurations
{
    internal class TestConfig
    {

        public string Secret { get; set; }
        public InnerTest InnerTest { get; set; }
        public InnerTest[] InnerTests { get; set; }

    }


    public class InnerTest
    {
        public int TestInt { get; set; }
        public string TestString { get; set; }
    }
}
