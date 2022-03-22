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

    public partial class QuestTaskLinksEditor : UserControl
    {

        public bool Cancelled;

        private QuestBase mMyQuest;

        private QuestBase.TaskLink mMyLink;

        private List<QuestBase.TaskLink> mCopyLinks = new List<QuestBase.TaskLink>();

        private List<Guid> mRemovedLinks;

        public QuestTaskLinksEditor(QuestBase refQuest)
        {
            if (refQuest == null)
            {
                Log.Warn($@"{nameof(refQuest)} is null.");
            }
            mMyQuest = refQuest;
            mMyLink = null;
            mRemovedLinks = new List<Guid>();
            foreach (var link in refQuest.TaskLinks)
            {
                var copylink = new QuestBase.TaskLink(link.Id);
                
                copylink.Name = link.Name;
                copylink.Description = link.Description;
                copylink.TasksList = new List<Guid>();
                foreach (var guid in link.TasksList)
                {
                    copylink.TasksList.Add(guid);
                }
                if (link.EditingEvent != null)
                {
                    copylink.EditingEvent = new EventBase(link.EditingEvent.Id, Guid.Empty, 0, 0, false);
                    copylink.EditingEvent.Load(link.EditingEvent.JsonData);
                }
                else
                {
                    //Compatibility for quests created before linktask feature
                    copylink.EditingEvent = new EventBase(copylink.Id, Guid.Empty, 0, 0, false);
                    copylink.EditingEvent.Name = Strings.TaskLinksEditor.completionevent.ToString(mMyQuest.Name, copylink.Name);
                    if (mMyQuest.AddEvents.ContainsKey(copylink.Id))
                    {
                        mMyQuest.AddEvents.Remove(copylink.Id);
                    }
                    mMyQuest.AddEvents.Add(copylink.Id, copylink.EditingEvent);
                }
                copylink.CompletionEventId = link.CompletionEventId;
                mCopyLinks.Add(copylink);
            }
            InitializeComponent();
            InitLocalization();
            if (refQuest.TaskLinks.Count > 0)
            {
                foreach (var link in refQuest.TaskLinks)
                {
                    cmbTaskLinks.Items.Add(link.Name);
                }
                cmbTaskLinks.SelectedIndex = 0;
            }
            else
            {
                UpdateFormElements();
            }
        }

        private void InitLocalization()
        {
            grpEditor.Text = Strings.TaskLinksEditor.editor;

            lblLinks.Text = Strings.TaskLinksEditor.tasklinks;
            lblNoTaskLink.Text = Strings.TaskLinksEditor.notasklink;
            cmbTaskLinks.Items.Clear();
            btnNewLink.Text = Strings.TaskLinksEditor.newlink;
            btnRemoveLink.Text = Strings.TaskLinksEditor.removelink;

            lblName.Text = Strings.TaskLinksEditor.name;
            lblDesc.Text = Strings.TaskLinksEditor.desc;

            grpLinkedTasks.Text = Strings.TaskLinksEditor.linkedtasks;
            lblTask.Text = Strings.TaskLinksEditor.task;
            lstTasks.Items.Clear();
            cmbTaskLinks.Items.Clear();
            lblNoAvailableTask.Text = Strings.TaskLinksEditor.noavailabletask;
            btnAddTask.Text = Strings.TaskLinksEditor.addtask;
            btnRemoveTask.Text = Strings.TaskLinksEditor.removetask;

            btnEditTaskLinkEvent.Text = Strings.TaskLinksEditor.editcompletionevent;
            btnSave.Text = Strings.TaskLinksEditor.ok;
            btnCancel.Text = Strings.TaskLinksEditor.cancel;
        }

        private void UpdateFormElements()
        {
            if (mMyLink == null)
            {
                cmbTaskLinks.Hide();
                btnRemoveLink.Hide();
                lblNoTaskLink.Show();
                lblName.Hide();
                lblDesc.Hide();
                txtName.Hide();
                txtDesc.Hide();
                grpLinkedTasks.Hide();
                btnEditTaskLinkEvent.Hide();
            }
            else
            {
                txtName.Text = mMyLink.Name;
                txtDesc.Text = mMyLink.Description;
                lstTasks.Items.Clear();
                foreach (var taskId in mMyLink.TasksList)
                {
                    var task = mMyQuest.FindTask(taskId);
                    lstTasks.Items.Add(task);
                }
                cmbTask.Items.Clear();
                foreach (var task in mMyQuest.Tasks)
                {
                    bool addtask = true;
                    foreach (var tasklink in mCopyLinks)
                    {
                        if (tasklink.TasksList.Contains(task.Id))
                        {
                            addtask = false;
                        }
                    }
                    if (addtask && mMyQuest.FindAlternative(task.Id) == null)
                    {
                        // Only task with no link and no alternative
                        cmbTask.Items.Add(task);
                    }
                }
                if (cmbTask.Items.Count > 0)
                {
                    cmbTask.SelectedIndex = 0;
                    lblNoAvailableTask.Hide();
                    cmbTask.Show();
                }
                else
                {
                    cmbTask.SelectedIndex = -1;
                    cmbTask.Hide();
                    lblNoAvailableTask.Show();
                }
                lblNoTaskLink.Hide();
                btnRemoveLink.Show();
                cmbTaskLinks.Show();
                lblName.Show();
                lblDesc.Show();
                txtName.Show();
                txtDesc.Show();
                grpLinkedTasks.Show();
                btnEditTaskLinkEvent.Show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyQuest.TaskLinks.Clear();
            // Remove all events relative to a removed link
            foreach(var removeid in mRemovedLinks)
            {
                if (mMyQuest.AddEvents.ContainsKey(removeid))
                {
                    mMyQuest.AddEvents.Remove(removeid);
                }
                mMyQuest.RemoveEvents.Add(removeid);
                foreach(var alt in mMyQuest.TaskAlternatives)
                {
                    if (alt.AlternativesList.Contains(removeid))
                    {
                        alt.AlternativesList.Remove(removeid);
                    }
                }
            }
            mRemovedLinks.Clear();

            foreach (var copylink in mCopyLinks)
            {
                var link = new QuestBase.TaskLink(copylink.Id);
                link.Name = copylink.Name;
                link.Description = copylink.Description;
                link.TasksList = new List<Guid>();
                foreach (var guid in copylink.TasksList)
                {
                    link.TasksList.Add(guid);
                }
                link.EditingEvent = copylink.EditingEvent;
                link.EditingEvent.Name = Strings.TaskLinksEditor.completionevent.ToString(mMyQuest.Name, link.Name);
                if (mMyQuest.AddEvents.ContainsKey(link.Id))
                {
                    // To be sure to put the edited event in the AddEvents list
                    mMyQuest.AddEvents[link.Id] = link.EditingEvent;
                }
                link.CompletionEventId = copylink.CompletionEventId;
                mMyQuest.TaskLinks.Add(link);
            }
            ParentForm.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            ParentForm.Close();
        }

        private void cmbTaskLinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTaskLinks.SelectedIndex == -1)
            {
                mMyLink = null;
            }
            else
            {
                mMyLink = mCopyLinks[cmbTaskLinks.SelectedIndex];
                if (mMyLink.EditingEvent == null)
                {
                    mMyLink.EditingEvent = new EventBase(mMyLink.Id, Guid.Empty, 0, 0, false);
                    mMyLink.EditingEvent.Name = Strings.TaskLinksEditor.completionevent.ToString(mMyQuest.Name, mMyLink.Name);
                }
            }
            UpdateFormElements();
        }

        private void btnEditTaskLinkEvent_Click(object sender, EventArgs e)
        {
            if (mMyLink != null)
            {
                mMyLink.EditingEvent.Name = Strings.TaskLinksEditor.completionevent.ToString(mMyQuest.Name, mMyLink.Name);
                var editor = new FrmEvent(null)
                {
                    MyEvent = mMyLink.EditingEvent
                };

                editor.InitEditor(true, true, true);
                editor.ShowDialog();
                Globals.MainForm.BringToFront();
                BringToFront();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (mMyLink != null)
            {
                mMyLink.Name = txtName.Text;
                cmbTaskLinks.Items[cmbTaskLinks.SelectedIndex] = txtName.Text;
            }   
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            if (mMyLink != null)
            {
                mMyLink.Description = txtDesc.Text;
            }
        }


        private void btnNewLink_Click(object sender, EventArgs e)
        {
            QuestBase.TaskLink tasklink = new QuestBase.TaskLink(Guid.NewGuid());
            tasklink.EditingEvent = new EventBase(tasklink.Id, Guid.Empty, 0, 0, false);
            tasklink.EditingEvent.Name = Strings.TaskLinksEditor.completionevent.ToString(mMyQuest.Name, tasklink.Name);
            mMyQuest.AddEvents.Add(tasklink.Id, tasklink.EditingEvent);
            mCopyLinks.Add(tasklink);
            cmbTaskLinks.Items.Add(tasklink.Name);
            cmbTaskLinks.SelectedIndex = cmbTaskLinks.Items.Count - 1;

        }

        private void btnRemoveLink_Click(object sender, EventArgs e)
        {
            if (mMyLink != null)
            {
                int oldindex = cmbTaskLinks.SelectedIndex;
                mRemovedLinks.Add(mMyLink.Id);

                mCopyLinks.Remove(mMyLink);
                cmbTaskLinks.Items.RemoveAt(cmbTaskLinks.SelectedIndex);
                if (oldindex == 0)
                {
                    if (cmbTaskLinks.Items.Count > 0)
                    {
                        cmbTaskLinks.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbTaskLinks.SelectedIndex = -1;
                        cmbTaskLinks_SelectedIndexChanged(null, null);
                    }
                }
                else
                {
                    cmbTaskLinks.SelectedIndex = oldindex - 1;
                }
                
            }
 
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (mMyLink != null)
            {
                var task = (QuestBase.QuestTask)cmbTask.SelectedItem;
                if (task != null && !mMyLink.TasksList.Contains(task.Id) && mMyQuest.FindAlternative(task.Id) == null)
                {
                    mMyLink.TasksList.Add(task.Id);
                    UpdateFormElements();
                }
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (mMyLink != null && mMyLink.TasksList.Count > 0)
            {
                var task = (QuestBase.QuestTask)lstTasks.SelectedItem;
                if (task != null && mMyLink.TasksList.Contains(task.Id))
                {
                    mMyLink.TasksList.Remove(task.Id);
                    UpdateFormElements();
                }
            }
        }

    }

}
