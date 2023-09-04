using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireTrial.Service
{
    public interface ICoreService
    {
        public bool ConvertNumberToText(int num, out string result);
    }
}