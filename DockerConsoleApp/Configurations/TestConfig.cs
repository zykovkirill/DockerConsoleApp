
namespace DockerConsoleApp.Configurations
{
    internal class TestConfig
    {

        public string Secret { get; set; }
        public string BigSecret { get; set; }
        public string VeryBigSecret { get; set; }
        public InnerTest InnerTest { get; set; }
        public InnerTest[] InnerTests { get; set; }

    }


    public class InnerTest
    {
        public int TestInt { get; set; }
        public string TestString { get; set; }
    }
}
