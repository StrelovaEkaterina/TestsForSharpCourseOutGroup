namespace Lab2.HomeWorks
{
    public class ClassTest2 : AClassTest, Interface
    {
        public override string Print()
        {
            return "It is ClassTest2";
        }

        public string PringFromInterface()
        {
            return "It is ClassTest2Interface";
        }
    }
}
