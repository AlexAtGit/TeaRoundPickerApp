using AdamMatthew.TeaRoundPicket.Business.Interfaces;
using AdamMatthew.TeaRoundPicket.Business.Models;
using System.Collections.Generic;
using System;
using System.Collections.Concurrent;
using System.Linq;

namespace AdamMatthew.TeaRoundPicket.Data
{
    /// <summary>
    /// Provides access to data from the actual repository, which is typcally a database, but could be a file or some other storage
    /// </summary>
    public class Repository : IRepository
    {
        private ConcurrentDictionary<Participant, TeaPreference> _data;

        public List<Participant> GetParticipants()
        {
            if (_data == null) LoadData();

            return _data.Keys.OrderBy(x => x.Lastname).ToList();
        }

        public List<TeaPreference> GetTeaPreferences()
        {
            if (_data == null) LoadData();

            return _data.Values.ToList();
        }
        public Participant AddParticipant(string firstname, string lastname)
        {
            if (_data == null) LoadData();

            var participant = _data.Keys.FirstOrDefault(x => x.Firstname.Equals(firstname, StringComparison.InvariantCultureIgnoreCase) &&
                                                        x.Lastname.Equals(lastname, StringComparison.InvariantCultureIgnoreCase));
            if (participant != null) throw new Exception("Participant already exists");

            participant = new Participant { Firstname = firstname, Lastname = lastname };
            var teaPreference = new TeaPreference { ParticipantId = participant.Id };
            _data.TryAdd(participant, teaPreference);
            
            SaveChanges();

            return participant;
        }
        public bool RemoveParticipant(string fullName)
        {
            var participant = GetParticipantByName(fullName);
            if (participant == null) return false;

            _data.Remove(participant, out var teaPreference);
            SaveChanges();

            return true;
        }
        public void SelectParticipant(string fullName)
        {
            var participant = GetParticipantByName(fullName);
            if (participant == null) return;

            participant.Rounds.Add(DateTime.Now);
            SaveChanges();
        }

        public Participant GetParticipantByName(string fullName)
        {
            if (_data == null) LoadData();

            if (string.IsNullOrWhiteSpace(fullName)) return null;
            var nameparts = fullName.Split(' '); // This may not always work if full name is made up of more than 2 parts
            if (nameparts.Length != 2) return null;

            var participant = _data.Keys.FirstOrDefault(x => x.Firstname.Equals(nameparts[0].Trim()) && x.Lastname.Equals(nameparts[1].Trim()));
            return participant;
        }

        public TeaPreference GetParticipantPreferences(Participant participant)
        {
            if (_data == null) LoadData();

            var preferences = _data.Values.ToList();

            return preferences.FirstOrDefault(x => x.ParticipantId.Equals(participant.Id));
        }

        /// <summary>
        /// Update tea taking preferences of the specified participant
        /// </summary>
        /// <returns></returns>
        public void UpdateParticipantPreferences(string participantName, bool addMilk, bool addSugar, string selectedTeaBrand)
        {
            var participant = GetParticipantByName(participantName);
            if (participant == null) return;

            // Identify the selected participant
            var teaPreference = GetParticipantPreferences(participant);
            if (teaPreference == null) return;

            teaPreference.AddMilk = addMilk;
            teaPreference.AddSugar = addSugar;
            teaPreference.TeaBrand = Enum.Parse<TeaBrand>(selectedTeaBrand);

            SaveChanges();
        }

        public void SaveChanges()
        {
            // NOT implemented for this exercise
        }

        private void LoadData()
        {
            if (_data == null)
            {
                var now = DateTime.Now;
                // Normally, data is loaded from some database or appropriate repository
                // For the purpose of this exercise, we just use some dummy data
                _data = new ConcurrentDictionary<Participant, TeaPreference>();

                var participant = new Participant { Firstname = "Theresa", Lastname = "May" };
                var teaPreference = new TeaPreference { ParticipantId = participant.Id, AddSugar = true, TeaBrand = TeaBrand.Lipton };
                _data.TryAdd(participant, teaPreference);
                participant.Rounds.Add(now - new TimeSpan(1, 0, 0, 0));
                participant.Rounds.Add(now - new TimeSpan(2, 0, 0, 0));

                participant = new Participant { Firstname = "John", Lastname = "Major" };
                teaPreference = new TeaPreference { ParticipantId = participant.Id, AddMilk = true, AddSugar = true, TeaBrand = TeaBrand.Decaf };
                _data.TryAdd(participant, teaPreference);
                participant.Rounds.Add(now - new TimeSpan(4, 0, 0, 0));
                participant.Rounds.Add(now - new TimeSpan(10, 0, 0, 0));

                participant = new Participant { Firstname = "Tony", Lastname = "Blair" };
                teaPreference = new TeaPreference { ParticipantId = participant.Id, AddMilk = true, TeaBrand = TeaBrand.Twinnings };
                _data.TryAdd(participant, teaPreference);
                participant.Rounds.Add(now - new TimeSpan(0, 1, 0, 0));

                participant = new Participant { Firstname = "Gordon", Lastname = "Brown" };
                teaPreference = new TeaPreference { ParticipantId = participant.Id, TeaBrand = TeaBrand.Lipton };
                _data.TryAdd(participant, teaPreference);
                participant.Rounds.Add(now - new TimeSpan(0, 2, 0, 0));
                participant.Rounds.Add(now - new TimeSpan(0, 3, 0, 0));
                participant.Rounds.Add(now - new TimeSpan(1, 1, 0, 0));
                participant.Rounds.Add(now - new TimeSpan(2, 1, 0, 0));
                participant.Rounds.Add(now - new TimeSpan(2, 2, 0, 0));

                participant = new Participant { Firstname = "David", Lastname = "Cameron" };
                teaPreference = new TeaPreference { ParticipantId = participant.Id, TeaBrand = TeaBrand.Tetley };
                _data.TryAdd(participant, teaPreference);
                participant.Rounds.Add(now - new TimeSpan(0, 3, 0, 0));
                participant.Rounds.Add(now - new TimeSpan(1, 3, 0, 0));
            }
        }
    }
}
