using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Intersect.Editor.Forms.Editors.Events;
using Intersect.Editor.General;
using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Intersect.Logging;

namespace Intersect.Editor.Forms.Editors.Quest
{

    public partial class QuestTaskAlternativesEditor : UserControl
    {

        public bool Cancelled;

        private QuestBase mMyQuest;

        private QuestBase.TaskAlternative mMyAlternative;

        private List<QuestBase.TaskAlternative> mCopyAlternatives = new List<QuestBase.TaskAlternative>();

        private List<Guid> mRemovedAlternatives;

        public QuestTaskAlternativesEditor(QuestBase refQuest)
        {
            if (refQuest == null)
            {
                Log.Warn($@"{nameof(refQuest)} is null.");
            }
            mMyQuest = refQuest;
            mMyAlternative = null;
            mRemovedAlternatives = new List<Guid>();
            foreach (var alt in refQuest.TaskAlternatives)
            {
                var copyalt = new QuestBase.TaskAlternative(alt.Id);
                
                copyalt.Name = alt.Name;
                copyalt.Description = alt.Description;
                copyalt.AlternativesList = new List<Guid>();
                foreach (var guid in alt.AlternativesList)
                {
                    copyalt.AlternativesList.Add(guid);
                }
                if (alt.EditingEvent != null)
                {
                    copyalt.EditingEvent = new EventBase(alt.EditingEvent.Id, Guid.Empty, 0, 0, false);
                    copyalt.EditingEvent.Load(alt.EditingEvent.JsonData);
                }
                else
                {
                    //Compatibility for quests created before alternativetask feature
                    copyalt.EditingEvent = new EventBase(Guid.Empty, Guid.Empty, 0, 0, false);
                    copyalt.EditingEvent.Name = Strings.TaskAlternativesEditor.completionevent.ToString(mMyQuest.Name, copyalt.Name);
                    if (mMyQuest.AddEvents.ContainsKey(copyalt.Id))
                    {
                        mMyQuest.AddEvents.Remove(copyalt.Id);
                    }
                    mMyQuest.AddEvents.Add(copyalt.Id, copyalt.EditingEvent);
                }
                copyalt.CompletionEventId = alt.CompletionEventId;
                mCopyAlternatives.Add(copyalt);
            }
            InitializeComponent();
            InitLocalization();
            if (refQuest.TaskAlternatives.Count > 0)
            {
                foreach (var alt in refQuest.TaskAlternatives)
                {
                    cmbTaskAlternatives.Items.Add(alt.Name);
                }
                cmbTaskAlternatives.SelectedIndex = 0;
            }
            else
            {
                UpdateFormElements();
            }
        }

        private void InitLocalization()
        {
            grpEditor.Text = Strings.TaskAlternativesEditor.editor;

            lblAlternatives.Text = Strings.TaskAlternativesEditor.taskalts;
            lblNoTaskAlternative.Text = Strings.TaskAlternativesEditor.notaskalt;
            cmbTaskAlternatives.Items.Clear();
            btnNewAlternative.Text = Strings.TaskAlternativesEditor.newalt;
            btnRemoveAlternative.Text = Strings.TaskAlternativesEditor.removealt;

            lblName.Text = Strings.TaskAlternativesEditor.name;
            lblDesc.Text = Strings.TaskAlternativesEditor.desc;

            grpAlternativeTasks.Text = Strings.TaskAlternativesEditor.altedtasks;
            lblTaskOrTaskLink.Text = Strings.TaskAlternativesEditor.task;
            lstTasksOrTaskLinks.Items.Clear();
            cmbTaskAlternatives.Items.Clear();
            lblNoAvailableTask.Text = Strings.TaskAlternativesEditor.noavailabletask;
            btnAddTask.Text = Strings.TaskAlternativesEditor.addtask;
            btnRemoveTask.Text = Strings.TaskAlternativesEditor.removetask;

            btnEditTaskAlternativeEvent.Text = Strings.TaskAlternativesEditor.editcompletionevent;
            btnSave.Text = Strings.TaskAlternativesEditor.ok;
            btnCancel.Text = Strings.TaskAlternativesEditor.cancel;
        }

        private void UpdateFormElements()
        {
            if (mMyAlternative == null)
            {
                cmbTaskAlternatives.Hide();
                btnRemoveAlternative.Hide();
                lblNoTaskAlternative.Show();
                lblName.Hide();
                lblDesc.Hide();
                txtName.Hide();
                txtDesc.Hide();
                grpAlternativeTasks.Hide();
                btnEditTaskAlternativeEvent.Hide();
            }
            else
            {
                txtName.Text = mMyAlternative.Name;
                txtDesc.Text = mMyAlternative.Description;
                lstTasksOrTaskLinks.Items.Clear();
                foreach (var taskOrLinkId in mMyAlternative.AlternativesList)
                {
                    var link = mMyQuest.ContainsLink(taskOrLinkId);
                    if (link != null)
                    {
                        lstTasksOrTaskLinks.Items.Add(link);
                    }
                    else
                    {
                        var task = mMyQuest.FindTask(taskOrLinkId);
                        lstTasksOrTaskLinks.Items.Add(task);
                    }
                    
                }
                cmbTaskOrTaskLink.Items.Clear();
                foreach (var task in mMyQuest.Tasks)
                {
                    bool addtask = true;
                    foreach (var taskalt in mCopyAlternatives)
                    {
                        if (taskalt.AlternativesList.Contains(task.Id))
                        {
                            addtask = false;
                        }
                    }
                    var tasklink = mMyQuest.FindLink(task.Id);
                    if (tasklink == null && addtask)
                    {
                        // Add a task only if not linked and not already alternative
                        cmbTaskOrTaskLink.Items.Add(task);
                    }
                }
                foreach (var link in mMyQuest.TaskLinks)
                {
                    bool addlink = true;
                    foreach (var taskalt in mCopyAlternatives)
                    {
                        if (taskalt.AlternativesList.Contains(link.Id))
                        {
                            addlink = false;
                        }
                    }
                    if (addlink)
                    {
                        // Add a TaskLink only if not already alternative
                        cmbTaskOrTaskLink.Items.Add(link);
                    }
                }
                if (cmbTaskOrTaskLink.Items.Count > 0)
                {
                    cmbTaskOrTaskLink.SelectedIndex = 0;
                    lblNoAvailableTask.Hide();
                    cmbTaskOrTaskLink.Show();
                }
                else
                {
                    cmbTaskOrTaskLink.SelectedIndex = -1;
                    cmbTaskOrTaskLink.Hide();
                    lblNoAvailableTask.Show();
                }
                lblNoTaskAlternative.Hide();
                btnRemoveAlternative.Show();
                cmbTaskAlternatives.Show();
                lblName.Show();
                lblDesc.Show();
                txtName.Show();
                txtDesc.Show();
                grpAlternativeTasks.Show();
                btnEditTaskAlternativeEvent.Show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyQuest.TaskAlternatives.Clear();
            // Remove all events relative to a removed alt
            foreach(var removeid in mRemovedAlternatives)
            {
                if (mMyQuest.AddEvents.ContainsKey(removeid))
                {
                    mMyQuest.AddEvents.Remove(removeid);
                }
                mMyQuest.RemoveEvents.Add(removeid);
            }
            mRemovedAlternatives.Clear();

            foreach (var copyalt in mCopyAlternatives)
            {
                var alt = new QuestBase.TaskAlternative(copyalt.Id);
                alt.Name = copyalt.Name;
                alt.Description = copyalt.Description;
                alt.AlternativesList = new List<Guid>();
                foreach (var guid in copyalt.AlternativesList)
                {
                    alt.AlternativesList.Add(guid);
                }
                alt.EditingEvent = copyalt.EditingEvent;
                alt.EditingEvent.Name = Strings.TaskAlternativesEditor.completionevent.ToString(mMyQuest.Name, alt.Name);
                if (mMyQuest.AddEvents.ContainsKey(alt.Id))
                {
                    // To be sure to put the edited event in the AddEvents list
                    mMyQuest.AddEvents[alt.Id] = alt.EditingEvent;
                }
                alt.CompletionEventId = copyalt.CompletionEventId;
                mMyQuest.TaskAlternatives.Add(alt);
            }
            ParentForm.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            ParentForm.Close();
        }

        private void cmbTaskAlternatives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTaskAlternatives.SelectedIndex == -1)
            {
                mMyAlternative = null;
            }
            else
            {
                mMyAlternative = mCopyAlternatives[cmbTaskAlternatives.SelectedIndex];
                if (mMyAlternative.EditingEvent == null)
                {
                    mMyAlternative.EditingEvent = new EventBase(Guid.Empty, Guid.Empty, 0, 0, false);
                    mMyAlternative.EditingEvent.Name = Strings.TaskAlternativesEditor.completionevent.ToString(mMyQuest.Name, mMyAlternative.Name);
                }
            }
            UpdateFormElements();
        }

        private void btnEditTaskAlternativeEvent_Click(object sender, EventArgs e)
        {
            if (mMyAlternative != null)
            {
                mMyAlternative.EditingEvent.Name = Strings.TaskAlternativesEditor.completionevent.ToString(mMyQuest.Name, mMyAlternative.Name);
                var editor = new FrmEvent(null)
                {
                    MyEvent = mMyAlternative.EditingEvent
                };

                editor.InitEditor(true, true, true);
                editor.ShowDialog();
                Globals.MainForm.BringToFront();
                BringToFront();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (mMyAlternative != null)
            {
                mMyAlternative.Name = txtName.Text;
                cmbTaskAlternatives.Items[cmbTaskAlternatives.SelectedIndex] = txtName.Text;
            }   
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            if (mMyAlternative != null)
            {
                mMyAlternative.Description = txtDesc.Text;
            }
        }


        private void btnNewAlternative_Click(object sender, EventArgs e)
        {
            QuestBase.TaskAlternative taskalt = new QuestBase.TaskAlternative(Guid.NewGuid());
            taskalt.EditingEvent = new EventBase(Guid.Empty, Guid.Empty, 0, 0, false);
            taskalt.EditingEvent.Name = Strings.TaskAlternativesEditor.completionevent.ToString(mMyQuest.Name, taskalt.Name);
            mMyQuest.AddEvents.Add(taskalt.Id, taskalt.EditingEvent);
            mCopyAlternatives.Add(taskalt);
            cmbTaskAlternatives.Items.Add(taskalt.Name);
            cmbTaskAlternatives.SelectedIndex = cmbTaskAlternatives.Items.Count - 1;

        }

        private void btnRemoveAlternative_Click(object sender, EventArgs e)
        {
            if (mMyAlternative != null)
            {
                int oldindex = cmbTaskAlternatives.SelectedIndex;
                mRemovedAlternatives.Add(mMyAlternative.Id);

                mCopyAlternatives.Remove(mMyAlternative);
                cmbTaskAlternatives.Items.RemoveAt(cmbTaskAlternatives.SelectedIndex);
                if (oldindex == 0)
                {
                    if (cmbTaskAlternatives.Items.Count > 0)
                    {
                        cmbTaskAlternatives.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbTaskAlternatives.SelectedIndex = -1;
                        cmbTaskAlternatives_SelectedIndexChanged(null, null);
                    }
                }
                else
                {
                    cmbTaskAlternatives.SelectedIndex = oldindex - 1;
                }
                
            }
 
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (mMyAlternative != null)
            {
                if (cmbTaskOrTaskLink.SelectedItem is QuestBase.QuestTask)
                {
                    var task = (QuestBase.QuestTask)cmbTaskOrTaskLink.SelectedItem;
                    if (task != null && !mMyAlternative.AlternativesList.Contains(task.Id))
                    {
                        mMyAlternative.AlternativesList.Add(task.Id);
                        UpdateFormElements();
                    }
                }
                else if (cmbTaskOrTaskLink.SelectedItem is QuestBase.TaskLink)
                {
                    var link = (QuestBase.TaskLink)cmbTaskOrTaskLink.SelectedItem;
                    if (link != null && !mMyAlternative.AlternativesList.Contains(link.Id))
                    {
                        mMyAlternative.AlternativesList.Add(link.Id);
                        UpdateFormElements();
                    }
                }

            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (mMyAlternative != null && mMyAlternative.AlternativesList.Count > 0)
            {
                if (cmbTaskOrTaskLink.SelectedItem is QuestBase.QuestTask)
                {
                    var task = (QuestBase.QuestTask)lstTasksOrTaskLinks.SelectedItem;
                    if (task != null && mMyAlternative.AlternativesList.Contains(task.Id))
                    {
                        mMyAlternative.AlternativesList.Remove(task.Id);
                        UpdateFormElements();
                    }
                }
                else if (cmbTaskOrTaskLink.SelectedItem is QuestBase.TaskLink)
                {
                    var link = (QuestBase.TaskLink)cmbTaskOrTaskLink.SelectedItem;
                    if (link != null && !mMyAlternative.AlternativesList.Contains(link.Id))
                    {
                        mMyAlternative.AlternativesList.Remove(link.Id);
                        UpdateFormElements();
                    }
                }
            }
        }

    }

}
