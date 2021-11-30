namespace Lab2.HomeWorks
{
    public class ClassTest1 : AClassTest, Interface
    {
        public override string Print()
        {
            return "It is ClassTest1";
        }
        public string PringFromInterface()
        {
            return "It is ClassTest1Interface";
        }
    }
}
