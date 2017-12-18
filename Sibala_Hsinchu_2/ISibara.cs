namespace Sibala_Hsinchu_2
{
    public interface ISibara
    {
        int Points { get; }
        int MaxPoint { get; }
        SibaraStatus.DiceTypeEnum DiceType { get; }
    }
}