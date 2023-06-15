﻿using System.Threading;

namespace BDanMuLib.Interfaces
{
    public interface IBarrageCancellationService
    {
        bool Cancel(string connectionId);

        void SetConnectionIdWithCancellationToken(string connectionId);

        CancellationTokenSource Get(string connectionId);

        int ConnectionCount();
    }
}