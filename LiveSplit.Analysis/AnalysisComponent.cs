using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;

namespace LiveSplit.Analysis
{
    class AnalysisComponent : IComponent
    {
        private LiveSplitState state;
        private AnalysisSettings settings;

        public string ComponentName { get { return "Analysis"; } }
        public IDictionary<string, Action> ContextMenuControls { get; protected set; }

        public float HorizontalWidth { get { return 0; } }
        public float MinimumHeight { get { return 0; } }
        public float MinimumWidth { get { return 0; } }
        public float PaddingBottom { get { return 0; } }
        public float PaddingLeft { get { return 0; } }
        public float PaddingRight { get { return 0; } }
        public float PaddingTop { get { return 0; } }
        public float VerticalHeight { get { return 0; } }

        public AnalysisComponent(LiveSplitState state)
        {
            this.state = state;
            settings = new AnalysisSettings();
        }

        public void DrawHorizontal(System.Drawing.Graphics g, LiveSplitState state, float height, System.Drawing.Region clipRegion)
        {

        }

        public void DrawVertical(System.Drawing.Graphics g, LiveSplitState state, float width, System.Drawing.Region clipRegion)
        {

        }

        public XmlNode GetSettings(XmlDocument document)
        {
            return document.CreateElement("Settings");
        }

        public System.Windows.Forms.Control GetSettingsControl(LayoutMode mode)
        {
            settings.UpdateData(state);
            return settings;
        }

        public void RenameComparison(string oldName, string newName) { }
        public void SetSettings(XmlNode settings) { }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            this.state = state;
        }
    }
}
