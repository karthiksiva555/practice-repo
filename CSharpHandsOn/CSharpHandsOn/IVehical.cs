namespace CSharpHandsOn
{
    public interface IVehical
    {
        int ID { get; set; }
        string Name { get; set; }

        void Drive();
        void TakeTurn();
    }
}