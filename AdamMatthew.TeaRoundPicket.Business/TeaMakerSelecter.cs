using AdamMatthew.TeaRoundPicket.Business.Interfaces;
using AdamMatthew.TeaRoundPicket.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdamMatthew.TeaRoundPicket.Business
{
    /// <summary>
    /// Handles tea maker selection
    /// </summary>
    public class TeaMakerSelecter : ITeaMakerSelecter
    {
        private List<Participant> _participants;
        private IRepository _repository;

        public TeaMakerSelecter(IRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Get the next tea maker randomly chosen
        /// </summary>
        /// <returns></returns>
        public Participant GetRandomParticipant()
        {
            _participants = _repository.GetParticipants();

            var random = new Random();
            var i = random.Next(0, _participants.Count - 1);

            return _participants[i];
        }
        /// <summary>
        /// Get the next tea maker based on the next order of rounds
        /// </summary>
        /// <returns></returns>
        public Participant GetNextParticipantInOrder()
        {
            _participants = _repository.GetParticipants();

            var nextParticipant = _participants.OrderBy(x => x.Rounds.OrderByDescending(d => d).FirstOrDefault()).FirstOrDefault();

            return nextParticipant;
        }
        /// <summary>
        /// Get the next tea maker based on statistical analysis of rounds
        /// </summary>
        /// <returns></returns>
        public Participant GetNextParticipantByStats()
        {
            _participants = _repository.GetParticipants();

            var nextParticipant = _participants.OrderBy(x => x.Rounds.Count).FirstOrDefault();

            return nextParticipant;
        }
    }
}
