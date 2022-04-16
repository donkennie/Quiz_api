using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_api.Models
{
    public class ParticipantResult
    {
        public int ParticipantId { get; set; }

        public int Score { get; set; }

        public int TimeTaken { get; set; }
    }
}
