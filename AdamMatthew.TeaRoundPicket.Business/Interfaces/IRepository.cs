using AdamMatthew.TeaRoundPicket.Business.Models;
using System.Collections.Generic;

namespace AdamMatthew.TeaRoundPicket.Business.Interfaces
{
    public interface IRepository
    {
        List<Participant> GetParticipants();

        List<TeaPreference> GetTeaPreferences();
        Participant AddParticipant(string firstname, string lastname);
        bool RemoveParticipant(string fullName);
        void SelectParticipant(string fullName);
        Participant GetParticipantByName(string fullName);
        TeaPreference GetParticipantPreferences(Participant participant);
        void UpdateParticipantPreferences(string participantName, bool addMilk, bool addSugar, string selectedTeaBrand);
        void SaveChanges();
    }
}
