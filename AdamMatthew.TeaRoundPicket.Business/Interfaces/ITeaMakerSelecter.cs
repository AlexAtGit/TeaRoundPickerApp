using AdamMatthew.TeaRoundPicket.Business.Models;

namespace AdamMatthew.TeaRoundPicket.Business.Interfaces
{
    public interface ITeaMakerSelecter
    {
        Participant GetRandomParticipant();
        Participant GetNextParticipantInOrder();
        Participant GetNextParticipantByStats();
    }
}
