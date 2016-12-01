using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Xbox.Services.Multiplayer
{
    public class MultiplayerSessionMember
    {

        public Microsoft.Xbox.Services.Tournaments.TournamentArbitrationStatus ArbitrationStatus
        {
            get;
            private set;
        }

        public Dictionary<string, Microsoft.Xbox.Services.Tournaments.TournamentTeamResult> Results
        {
            get;
            private set;
        }

        public IList<string> Encounters
        {
            get;
            set;
        }

        public IList<string> Groups
        {
            get;
            set;
        }

        public MultiplayerSessionReference TournamentTeamSessionRef
        {
            get;
            private set;
        }

        public MultiplayerMeasurementFailure InitializationFailureCause
        {
            get;
            private set;
        }

        public DateTimeOffset JoinTime
        {
            get;
            private set;
        }

        public uint InitializationEpisode
        {
            get;
            private set;
        }

        public uint ActiveTitleId
        {
            get;
            private set;
        }

        public NetworkAddressTranslationSetting Nat
        {
            get;
            private set;
        }

        public string DeviceToken
        {
            get;
            private set;
        }

        public IList<MultiplayerQualityOfServiceMeasurements> MemberMeasurements
        {
            get;
            private set;
        }

        public IList<MultiplayerSessionMember> MembersInGroup
        {
            get;
            private set;
        }

        public string MemberServerMeasurementsJson
        {
            get;
            private set;
        }

        public string MatchmakingResultServerMeasurementsJson
        {
            get;
            private set;
        }

        public bool InitializeRequested
        {
            get;
            private set;
        }

        public bool IsCurrentUser
        {
            get;
            private set;
        }

        public bool IsTurnAvailable
        {
            get;
            private set;
        }

        public MultiplayerSessionMemberStatus Status
        {
            get;
            private set;
        }

        public string Gamertag
        {
            get;
            private set;
        }

        public string MemberCustomPropertiesJson
        {
            get;
            private set;
        }

        public Dictionary<string, string> Roles
        {
            get;
            private set;
        }

        public string SecureDeviceAddressBase64
        {
            get;
            private set;
        }

        public string MemberCustomConstantsJson
        {
            get;
            private set;
        }

        public string XboxUserId
        {
            get;
            private set;
        }

        public string TeamId
        {
            get;
            private set;
        }

        public uint MemberId
        {
            get;
            private set;
        }

    }
}