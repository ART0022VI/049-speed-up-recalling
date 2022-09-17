using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MEC;
using Qurre;
using Qurre.Events;
using Qurre.API;
using Qurre.API.Events;

namespace _049fix
{
    public class plfix : Plugin
    {
        public override string Developer => "ГIеJIbмeнь#3519";
        public override string Name => "049Fix";
        public override Version Version => new Version(1, 0, 0);
        public override void Disable()
        {
            Scp049.StartRecall -= Start;
        }

        public override void Enable()
        {
            Scp049.StartRecall += Start;
        }
        public void Start(StartRecallEvent ev)
        {
            ev.Target.Role = RoleType.Scp0492;
            Timing.CallDelayed(0.5f, () => { ev.Target.Position = ev.Scp049.Position; });
        }
    }
}
