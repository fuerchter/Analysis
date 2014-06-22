using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveSplit.Model;

namespace LiveSplit.Analysis
{
    public partial class AnalysisSettings : UserControl
    {
        public AnalysisSettings()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "#";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Average Time Loss";
            dataGridView1.Columns[3].Name = "%";
        }

        public void UpdateData(LiveSplitState state)
        {
            dataGridView1.Rows.Clear();
            IRun run = state.Run;
            foreach (ISegment segment in run)
            {
                string[] row = new string[] { "", segment.Name, "", "" };
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = dataGridView1.Rows.Count-1;

                //Main calculations
                TimeSpan timeLoss=new TimeSpan();
                float percentage=0;
                int attemptCount = segment.SegmentHistory.Count;
                if (segment.BestSegmentTime != null)
                {
                    foreach (IIndexedTime attempt in segment.SegmentHistory)
                    {
                        if (attempt.Time != null)
                        {
                            timeLoss += (TimeSpan)attempt.Time;
                        }
                        else
                        {
                            attemptCount--; //Skipped split
                        }
                    }

                    if (attemptCount != 0)
                    {
                        timeLoss = TimeSpan.FromTicks(timeLoss.Ticks / attemptCount);
                        TimeSpan bestSegmentTime = (TimeSpan)segment.BestSegmentTime;
                        timeLoss -= bestSegmentTime;

                        percentage = (float)timeLoss.Ticks / (float)bestSegmentTime.Ticks * 100;
                    }
                }
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = timeLoss;

                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value = percentage;
            }
        }
    }
}
