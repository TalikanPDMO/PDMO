using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using DarkUI.Forms;

using Intersect.Editor.General;
using Intersect.Editor.Localization;
using Intersect.Editor.Networking;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Crafting;
using Intersect.GameObjects.Events;
using Intersect.GameObjects.Maps;
using Intersect.GameObjects.Maps.MapRegion;
using Intersect.Models;
using Intersect.Utilities;
using Newtonsoft.Json;

namespace Intersect.Editor.Forms.Editors.MapRegions
{

    public partial class FrmMapRegion : EditorForm
    {

        private List<MapRegionBase> mChanged = new List<MapRegionBase>();

        private string mCopiedItem;

        private MapRegionBase mEditorItem;

        private List<string> mKnownFolders = new List<string>();

        public FrmMapRegion()
        {
            ApplyHooks();
            InitializeComponent();
            lstGameObjects.LostFocus += itemList_FocusChanged;
            lstGameObjects.GotFocus += itemList_FocusChanged;
            cmbEventEnter.Items.Clear();
            cmbEventEnter.Items.Add(Strings.General.none);
            cmbEventEnter.Items.AddRange(EventBase.Names);
            cmbEventMove.Items.Clear();
            cmbEventMove.Items.Add(Strings.General.none);
            cmbEventMove.Items.AddRange(EventBase.Names);
            cmbEventExit.Items.Clear();
            cmbEventExit.Items.Add(Strings.General.none);
            cmbEventExit.Items.AddRange(EventBase.Names);

            lstGameObjects.Init(UpdateToolStripItems, AssignEditorItem, toolStripItemNew_Click, toolStripItemCopy_Click, toolStripItemUndo_Click, toolStripItemPaste_Click, toolStripItemDelete_Click, toolStripItemRelations_Click);
        }
        private void AssignEditorItem(Guid id)
        {
            mEditorItem = MapRegionBase.Get(id);
            UpdateEditor();
        }

        protected override void GameObjectUpdatedDelegate(GameObjectType type)
        {
            if (type == GameObjectType.MapRegion)
            {
                InitEditor();
                if (mEditorItem != null && !DatabaseObject<MapRegionBase>.Lookup.Values.Contains(mEditorItem))
                {
                    mEditorItem = null;
                    UpdateEditor();
                }
            }
        }

        private void UpdateEditor()
        {
            if (mEditorItem != null)
            {
                pnlContainer.Show();
                grpCommentary.Show();

                txtCommentary.Text = mEditorItem.Comment;
                txtName.Text = mEditorItem.Name;
                txtDesc.Text = mEditorItem.Description;

                cmbFolder.Text = mEditorItem.Folder;

                cmbEventEnter.SelectedIndex = EventBase.ListIndex(mEditorItem.EnterEventId) + 1;
                cmbEventMove.SelectedIndex = EventBase.ListIndex(mEditorItem.MoveEventId) + 1;
                cmbEventExit.SelectedIndex = EventBase.ListIndex(mEditorItem.ExitEventId) + 1;

                txtEditorName.Text = mEditorItem.EditorName;
                if (mEditorItem.EditorColor == null)
                {
                    mEditorItem.EditorColor = new byte[4] { 150, 0, 0, 0 };
                }
                pnlColor.BackColor = System.Drawing.Color.FromArgb(
                    mEditorItem.EditorColor[0], mEditorItem.EditorColor[1], mEditorItem.EditorColor[2], mEditorItem.EditorColor[3]);


                if (mEditorItem.EnterRequirements == null || mEditorItem.EnterRequirements.Count == 0)
                {
                    btnEditEnterConditions.Text = Strings.MapRegionEditor.editenterconditions.ToString(Strings.MapRegionEditor.none);
                }
                else
                {
                    btnEditEnterConditions.Text = Strings.MapRegionEditor.editenterconditions.ToString(mEditorItem.EnterRequirements.Count);
                }
                txtCannotEnter.Text = mEditorItem.CannotEnterMessage;

                if (mEditorItem.ExitRequirements == null || mEditorItem.ExitRequirements.Count == 0)
                {
                    btnEditExitConditions.Text = Strings.MapRegionEditor.editexitconditions.ToString(Strings.MapRegionEditor.none);
                }
                else
                {
                    btnEditExitConditions.Text = Strings.MapRegionEditor.editexitconditions.ToString(mEditorItem.ExitRequirements.Count);
                }
                txtCannotExit.Text = mEditorItem.CannotExitMessage;

                cmbNewCommand.SelectedIndex = 0;
                ListMapRegionCommands();

                if (mChanged.IndexOf(mEditorItem) == -1)
                {
                    mChanged.Add(mEditorItem);
                    mEditorItem.MakeBackup();
                }
            }
            else
            {
                pnlContainer.Hide();
                grpCommentary.Hide();
            }

            UpdateToolStripItems();
        }
        private void txtCommentary_TextChanged(object sender, EventArgs e)
        {
            mEditorItem.Comment = txtCommentary.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            mEditorItem.Name = txtName.Text;
            lstGameObjects.UpdateText(TextUtils.FormatEditorName(mEditorItem.Name, mEditorItem.EditorName));
        }

        private void txtEditorName_TextChanged(object sender, EventArgs e)
        {
            mEditorItem.EditorName = txtEditorName.Text;
            lstGameObjects.UpdateText(TextUtils.FormatEditorName(mEditorItem.Name, mEditorItem.EditorName));
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            mEditorItem.Description = txtDesc.Text;
        }

        private void txtCannotEnter_TextChanged(object sender, EventArgs e)
        {
            mEditorItem.CannotEnterMessage = txtCannotEnter.Text;
        }

        private void txtCannotExit_TextChanged(object sender, EventArgs e)
        {
            mEditorItem.CannotExitMessage = txtCannotExit.Text;
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = pnlColor.BackColor;
            colorDialog.ShowDialog();
            pnlColor.BackColor = System.Drawing.Color.FromArgb(int.Parse(Strings.MapLayers.regionstransparency),
                colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            mEditorItem.EditorColor[0] = byte.Parse(Strings.MapLayers.regionstransparency);
            mEditorItem.EditorColor[1] = colorDialog.Color.R;
            mEditorItem.EditorColor[2] = colorDialog.Color.G;
            mEditorItem.EditorColor[3] = colorDialog.Color.B;
        }

        private void btnEditEnterConditions_Click(object sender, EventArgs e)
        {
            var editForm = new FrmDynamicRequirements(mEditorItem.EnterRequirements, RequirementType.MapRegion);
            editForm.ShowDialog();
            if (mEditorItem.EnterRequirements == null || mEditorItem.EnterRequirements.Count == 0)
            {
                btnEditEnterConditions.Text = Strings.MapRegionEditor.editenterconditions.ToString(Strings.MapRegionEditor.none);
            }
            else
            {
                btnEditEnterConditions.Text = Strings.MapRegionEditor.editenterconditions.ToString(mEditorItem.EnterRequirements.Count);
            }
        }
        private void btnEditExitConditions_Click(object sender, EventArgs e)
        {
            var editForm = new FrmDynamicRequirements(mEditorItem.ExitRequirements, RequirementType.MapRegion);
            editForm.ShowDialog();
            if (mEditorItem.ExitRequirements == null || mEditorItem.ExitRequirements.Count == 0)
            {
                btnEditExitConditions.Text = Strings.MapRegionEditor.editexitconditions.ToString(Strings.MapRegionEditor.none);
            }
            else
            {
                btnEditExitConditions.Text = Strings.MapRegionEditor.editexitconditions.ToString(mEditorItem.ExitRequirements.Count);
            }
        }
        private bool OpenMapRegionCommandEditor(MapRegionCommand command, MapRegionCommandTypes cmdType)
        {
            MapRegionCommandControl cmdWindow = null;
            var frm = new Form();
            switch(cmdType)
            {
                case MapRegionCommandTypes.ApplySpellEffects:
                    cmdWindow = new MapRegionCommandApplySpellEffects((ApplySpellEffectsCommand)command);
                    frm.Text = Strings.MapRegionApplySpellEffects.title;
                    break;
                case MapRegionCommandTypes.PlayAnimation:
                    cmdWindow = new MapRegionCommandPlayAnimation((PlayAnimationCommand)command);
                    frm.Text = Strings.MapRegionPlayAnimation.title;
                    break;
            }
            frm.Controls.Add(cmdWindow);
            frm.Size = new Size(0, 0);
            frm.AutoSize = true;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.BackColor = cmdWindow.BackColor;
            cmdWindow.BringToFront();
            frm.ShowDialog();
            if (!cmdWindow.Cancelled)
            {
                return true;
            }

            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbNewCommand.SelectedIndex > -1)
            {
                MapRegionCommand newCommand = null;
                switch ((MapRegionCommandTypes)cmbNewCommand.SelectedIndex)
                {
                    case MapRegionCommandTypes.ApplySpellEffects:
                        newCommand = new ApplySpellEffectsCommand();
                        break;
                    case MapRegionCommandTypes.PlayAnimation:
                        newCommand = new PlayAnimationCommand();
                        break;
                }
                if (newCommand != null)
                {
                    if (OpenMapRegionCommandEditor(newCommand, newCommand.Type))
                    {
                        mEditorItem.Commands.Add(newCommand);
                        ListMapRegionCommands();
                    }
                }
            }
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            if (lstCommands.SelectedIndex > -1 && mEditorItem.Commands.Count > lstCommands.SelectedIndex)
            {
                var command = mEditorItem.Commands[lstCommands.SelectedIndex];
                var copydata = JsonConvert.SerializeObject(command);
                switch(command.Type)
                {
                    case MapRegionCommandTypes.ApplySpellEffects:
                        mEditorItem.Commands.Add(JsonConvert.DeserializeObject<ApplySpellEffectsCommand>(copydata));
                        break;
                    case MapRegionCommandTypes.PlayAnimation:
                        mEditorItem.Commands.Add(JsonConvert.DeserializeObject<PlayAnimationCommand>(copydata));
                        break;
                }
                ListMapRegionCommands();
            }
        }

        private void lstCommands_DoubleClick(object sender, EventArgs e)
        {
            if (lstCommands.SelectedIndex > -1 && mEditorItem.Commands.Count > lstCommands.SelectedIndex)
            {
                if (OpenMapRegionCommandEditor(mEditorItem.Commands[lstCommands.SelectedIndex], mEditorItem.Commands[lstCommands.SelectedIndex].Type))
                {
                    ListMapRegionCommands();
                }
            }
        }

        private void ListMapRegionCommands()
        {
            lstCommands.Items.Clear();
            foreach (var command in mEditorItem.Commands)
            {
                if (command != null)
                {
                    lstCommands.Items.Add(GetMapRegionCommandDescription(command));
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCommands.SelectedIndex > -1 && mEditorItem.Commands.Count > lstCommands.SelectedIndex)
            {
                var i = lstCommands.SelectedIndex;
                lstCommands.Items.RemoveAt(i);
                mEditorItem.Commands.RemoveAt(i);
                ListMapRegionCommands();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (var item in mChanged)
            {
                item.RestoreBackup();
                item.DeleteBackup();
            }

            Hide();
            Globals.CurrentEditor = -1;
            Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Send Changed items
            foreach (var item in mChanged)
            {
                PacketSender.SendSaveObject(item);
                item.DeleteBackup();
            }

            Hide();
            Globals.CurrentEditor = -1;
            Dispose();
        }

        private void toolStripItemNew_Click(object sender, EventArgs e)
        {
            PacketSender.SendCreateObject(GameObjectType.MapRegion);
        }

        private void toolStripItemDelete_Click(object sender, EventArgs e)
        {
            if (mEditorItem != null && lstGameObjects.Focused)
            {
                if (DarkMessageBox.ShowWarning(
                        Strings.MapRegionEditor.deleteprompt, Strings.MapRegionEditor.deletetitle, DarkDialogButton.YesNo,
                        Properties.Resources.Icon
                    ) ==
                    DialogResult.Yes)
                {
                    PacketSender.SendDeleteObject(mEditorItem);
                }
            }
        }

        private void toolStripItemCopy_Click(object sender, EventArgs e)
        {
            if (mEditorItem != null && lstGameObjects.Focused)
            {
                mCopiedItem = mEditorItem.JsonData;
                toolStripItemPaste.Enabled = true;
            }
        }

        private void toolStripItemPaste_Click(object sender, EventArgs e)
        {
            if (mEditorItem != null && mCopiedItem != null && lstGameObjects.Focused)
            {
                mEditorItem.Load(mCopiedItem, true);
                UpdateEditor();
            }
        }

        private void toolStripItemUndo_Click(object sender, EventArgs e)
        {
            if (mChanged.Contains(mEditorItem) && mEditorItem != null)
            {
                if (DarkMessageBox.ShowWarning(
                        Strings.MapRegionEditor.undoprompt, Strings.MapRegionEditor.undotitle, DarkDialogButton.YesNo,
                        Properties.Resources.Icon
                    ) ==
                    DialogResult.Yes)
                {
                    mEditorItem.RestoreBackup();
                    UpdateEditor();
                }
            }
        }

        private void toolStripItemRelations_Click(object sender, EventArgs e)
        {
            if (mEditorItem != null)
            {
                Dictionary<string, List<string>> dataDict = new Dictionary<string, List<string>>();
                //Retrieve all maps related to the npc
                var mapList = MapBase.Lookup.Where(pair => ((MapBase)pair.Value)?.MapRegionIds?.Cast<Guid?>().Any(id => id == mEditorItem.Id) ?? false)
                    .OrderBy(p => p.Value?.Name)
                    .Select(pair => pair.Value?.Name ?? MapBase.Deleted)
                    .ToList();
                dataDict.Add(Strings.Relations.maps, mapList);

                string titleTarget = "MapRegion : " + TextUtils.FormatEditorName(mEditorItem.Name, mEditorItem.EditorName);
                var relationsfrm = new FrmRelations(titleTarget, dataDict);
                relationsfrm.ShowDialog();
            }
        }

        private void itemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Z)
                {
                    toolStripItemUndo_Click(null, null);
                }
                else if (e.KeyCode == Keys.V)
                {
                    toolStripItemPaste_Click(null, null);
                }
                else if (e.KeyCode == Keys.C)
                {
                    toolStripItemCopy_Click(null, null);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Delete)
                {
                    toolStripItemDelete_Click(null, null);
                }
            }
        }

        private void UpdateToolStripItems()
        {
            toolStripItemCopy.Enabled = mEditorItem != null && lstGameObjects.Focused;
            toolStripItemPaste.Enabled = mEditorItem != null && mCopiedItem != null && lstGameObjects.Focused;
            toolStripItemDelete.Enabled = mEditorItem != null && lstGameObjects.Focused;
            toolStripItemUndo.Enabled = mEditorItem != null && lstGameObjects.Focused;
            toolStripItemRelations.Enabled = mEditorItem != null;
        }

        private void itemList_FocusChanged(object sender, EventArgs e)
        {
            UpdateToolStripItems();
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.N)
                {
                    toolStripItemNew_Click(null, null);
                }
            }
        }

        private void frmMapRegion_Load(object sender, EventArgs e)
        {
            InitLocalization();
        }

        private void InitLocalization()
        {
            Text = Strings.MapRegionEditor.title;
            toolStripItemNew.Text = Strings.MapRegionEditor.New;
            toolStripItemDelete.Text = Strings.MapRegionEditor.delete;
            toolStripItemCopy.Text = Strings.MapRegionEditor.copy;
            toolStripItemPaste.Text = Strings.MapRegionEditor.paste;
            toolStripItemUndo.Text = Strings.MapRegionEditor.undo;
            toolStripItemRelations.Text = Strings.MapRegionEditor.relations;

            grpCrafts.Text = Strings.MapRegionEditor.regions;
            grpCommentary.Text = Strings.MapRegionEditor.commentary;

            grpGeneral.Text = Strings.MapRegionEditor.general;
            lblName.Text = Strings.MapRegionEditor.name;
            lblDesc.Text = Strings.MapRegionEditor.description;

            grpEditorParams.Text = Strings.MapRegionEditor.editorparams;
            lblEditorName.Text = Strings.MapRegionEditor.editorname;
            lblEditorColor.Text = Strings.MapRegionEditor.editorcolor;
            btnSelectColor.Text = Strings.MapRegionEditor.selectcolor;

            grpEvents.Text = Strings.MapRegionEditor.events;
            lblEventEnter.Text = Strings.MapRegionEditor.onenter;
            lblEventMove.Text = Strings.MapRegionEditor.onmove;
            lblEventExit.Text = Strings.MapRegionEditor.onexit;

            grpConditions.Text = Strings.MapRegionEditor.conditions;
            lblCannotEnter.Text = Strings.MapRegionEditor.cannotenter;
            lblCannotExit.Text = Strings.MapRegionEditor.cannotexit;

            grpCommands.Text = Strings.MapRegionEditor.commands;
            lblEditCommand.Text = Strings.MapRegionEditor.editcommands;
            lblNewCommand.Text = Strings.MapRegionEditor.newcommand;
            btnAdd.Text = Strings.MapRegionEditor.add;
            btnRemove.Text = Strings.MapRegionEditor.remove;
            btnDuplicate.Text = Strings.MapRegionEditor.duplicate;
            cmbNewCommand.Items.Clear();
            for (var i = 0; i < Strings.MapRegionEditor.commandtypes.Count;i++)
            {
                cmbNewCommand.Items.Add(Strings.MapRegionEditor.commandtypes[i]);
            }

            //Searching/Sorting
            btnAlphabetical.ToolTipText = Strings.MapRegionEditor.sortalphabetically;
            txtSearch.Text = Strings.MapRegionEditor.searchplaceholder;
            lblFolder.Text = Strings.MapRegionEditor.folderlabel;

            btnSave.Text = Strings.MapRegionEditor.save;
            btnCancel.Text = Strings.MapRegionEditor.cancel;
        }

        private string GetMapRegionCommandDescription(MapRegionCommand command)
        {
            var commandData = "Command Description";
            switch (command.Type)
            {
                case MapRegionCommandTypes.ApplySpellEffects:
                    var statuscommand = (ApplySpellEffectsCommand)command;
                    var spell = SpellBase.Get(statuscommand.SpellId ?? Guid.Empty);
                    if (spell != null)
                    {
                        commandData = TextUtils.FormatEditorName(spell.Name, spell.EditorName) + ": ";
                        if (spell.Combat.HoTDoT)
                        {
                            commandData += Strings.MapRegionEditor.hotdot;
                        }
                        if (spell.Combat.StatDiff.Any(s => s != 0) || spell.Combat.PercentageStatDiff.Any(s => s != 0))
                        {
                            if (commandData.Length > 0)
                            {
                                commandData += " | ";
                            }
                            commandData += Strings.MapRegionEditor.changestat;
                        }
                        if (spell.Combat.Effect != StatusTypes.None)
                        {
                            if (commandData.Length > 0)
                            {
                                commandData += " | ";
                            }
                            commandData += Strings.MapRegionEditor.effect.ToString(Strings.SpellEditor.effects[(int)spell.Combat.Effect]);
                        }
                    }
                    else
                    {
                        commandData = Strings.MapRegionEditor.unknown;
                    }
                    /*for (var i =0; i<(int)Stats.StatCount;i++)
                    {
                        var statString = "";
                        if (statuscommand.StatDiff[i] != 0)
                        {
                            statString += statuscommand.StatDiff[i].ToString("+#;-#;0");
                        }
                        if (statuscommand.PercentageStatDiff[i] != 0)
                        {
                            statString += statuscommand.PercentageStatDiff[i].ToString("+#;-#;0") + "%";
                        }
                        if (statString.Length > 0)
                        {
                            commandData += Strings.MapRegionEditor.commandstats[i].ToString(statString) + " ";
                        }
                    }
                    if (statuscommand.Effect != StatusTypes.None)
                    {
                        if (commandData.Length > 0)
                        {
                            commandData += "| ";
                        }
                        commandData += Strings.MapRegionEditor.effect.ToString(Strings.MapRegionApplyStatus.effects[(int)statuscommand.Effect]);
                    }*/
                    
                    break;
                case MapRegionCommandTypes.PlayAnimation:
                    var animcommand = (PlayAnimationCommand)command;
                    var anim = AnimationBase.Get(animcommand.AnimId ?? Guid.Empty);
                    if (anim != null)
                    {
                        commandData = anim.Name + ": " + Strings.MapRegionEditor.screeneffect.ToString(anim.ScreenEffects.Count);
                    }
                    else
                    {
                        commandData = Strings.MapRegionEditor.unknown;
                    }
                    break;
            }
            return Strings.MapRegionEditor.commandsitem.ToString(
                Strings.MapRegionEditor.commandtypes[(int)command.Type],
                command.ConditionLists.Count,
                commandData);

        }
        
        private void cmbEventEnter_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.EnterEvent = EventBase.Get(EventBase.IdFromList(cmbEventEnter.SelectedIndex - 1));
        }

        private void cmbEventMove_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.MoveEvent = EventBase.Get(EventBase.IdFromList(cmbEventMove.SelectedIndex - 1));
        }

        private void cmbEventExit_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.ExitEvent = EventBase.Get(EventBase.IdFromList(cmbEventExit.SelectedIndex - 1));
        }

        #region "Item List - Folders, Searching, Sorting, Etc"

        public void InitEditor()
        {
            //Collect folders
            var mFolders = new List<string>();
            foreach (var itm in MapRegionBase.Lookup)
            {
                if (!string.IsNullOrEmpty(((MapRegionBase) itm.Value).Folder) &&
                    !mFolders.Contains(((MapRegionBase) itm.Value).Folder))
                {
                    mFolders.Add(((MapRegionBase) itm.Value).Folder);
                    if (!mKnownFolders.Contains(((MapRegionBase) itm.Value).Folder))
                    {
                        mKnownFolders.Add(((MapRegionBase) itm.Value).Folder);
                    }
                }
            }

            mFolders.Sort();
            mKnownFolders.Sort();
            cmbFolder.Items.Clear();
            cmbFolder.Items.Add("");
            cmbFolder.Items.AddRange(mKnownFolders.ToArray());

            var items = MapRegionBase.Lookup.OrderBy(p => p.Value?.Name).Select(pair => new KeyValuePair<Guid, KeyValuePair<string, string>>(pair.Key,
                new KeyValuePair<string, string>(
                    TextUtils.FormatEditorName(((MapRegionBase)pair.Value)?.Name, ((MapRegionBase)pair.Value)?.EditorName) ?? Models.DatabaseObject<MapRegionBase>.Deleted, ((MapRegionBase)pair.Value)?.Folder ?? ""))).ToArray();
            lstGameObjects.Repopulate(items, mFolders, btnAlphabetical.Checked, CustomSearch(), txtSearch.Text);
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            var folderName = "";
            var result = DarkInputBox.ShowInformation(
                Strings.MapRegionEditor.folderprompt, Strings.MapRegionEditor.foldertitle, ref folderName,
                DarkDialogButton.OkCancel
            );

            if (result == DialogResult.OK && !string.IsNullOrEmpty(folderName))
            {
                if (!cmbFolder.Items.Contains(folderName))
                {
                    mEditorItem.Folder = folderName;
                    lstGameObjects.ExpandFolder(folderName);
                    InitEditor();
                    cmbFolder.Text = folderName;
                }
            }
        }

        private void cmbFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.Folder = cmbFolder.Text;
            InitEditor();
        }

        private void btnAlphabetical_Click(object sender, EventArgs e)
        {
            btnAlphabetical.Checked = !btnAlphabetical.Checked;
            InitEditor();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            InitEditor();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = Strings.MapRegionEditor.searchplaceholder;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
            txtSearch.Focus();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = Strings.MapRegionEditor.searchplaceholder;
        }

        private bool CustomSearch()
        {
            return !string.IsNullOrWhiteSpace(txtSearch.Text) &&
                   txtSearch.Text != Strings.MapRegionEditor.searchplaceholder;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == Strings.MapRegionEditor.searchplaceholder)
            {
                txtSearch.SelectAll();
            }
        }

        #endregion

    }

}
