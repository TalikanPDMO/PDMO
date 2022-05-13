using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.GameObjects;

namespace Intersect.Editor.Forms
{

    public partial class FrmRelations : Form
    {
        private Dictionary<string, List<string>> DataDict;
        private string TitleTarget;
        public FrmRelations()
        {
            InitializeComponent();
            DataDict = new Dictionary<string, List<string>>();
            this.Icon = Properties.Resources.Icon;
            this.TitleTarget = "Unknown";
        }
        public FrmRelations(string titleTarget, Dictionary<string, List<string>> dataDict)
        {
            InitializeComponent();
            DataDict = dataDict;
            this.Icon = Properties.Resources.Icon;
            TitleTarget = titleTarget;
        }

        private void frmRelations_Load(object sender, EventArgs e)
        {
            InitLocalization();
            UpdateNodes();
        }

        private void InitLocalization()
        {
            Text = Strings.Relations.title.ToString(TitleTarget);
        }
        public void SetDataDict(Dictionary<string, List<string>> dataDict)
        {
            DataDict = dataDict;
            UpdateNodes();
        }
        protected void UpdateNodes()
        {
            foreach(var list in DataDict)
            {
                var nodeCategory = new DarkUI.Controls.DarkTreeNode(list.Key);
                if (list.Value.Count > 0)
                {
                    foreach (var name in list.Value)
                    {
                        nodeCategory.Nodes.Add(new DarkUI.Controls.DarkTreeNode(name));
                    }

                }
                else
                {
                    nodeCategory.Text += Strings.Relations.none;
                }
                treeViewItems?.Nodes.Add(nodeCategory);
            }
        }
    }

}
