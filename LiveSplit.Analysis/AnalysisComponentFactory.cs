using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;
using LiveSplit.UI.Components;

namespace LiveSplit.Analysis
{
    class AnalysisComponentFactory : IComponentFactory
    {
        public string ComponentName { get { return "Analysis"; } }

        public string UpdateName { get { return ""; } }
        public string UpdateURL { get { return ""; } }
        public System.Version Version { get { return new Version(); } }
        public string XMLURL { get { return ""; } }

        public IComponent Create(LiveSplitState state)
        {
            return new AnalysisComponent(state);
        }
    }
}
