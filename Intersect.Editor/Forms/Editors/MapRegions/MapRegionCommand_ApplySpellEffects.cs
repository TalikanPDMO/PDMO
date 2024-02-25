using System;
using System.Drawing;
using Intersect.Editor.Content;
using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Maps.MapRegion;
using Intersect.Utilities;

namespace Intersect.Editor.Forms.Editors.MapRegions
{

    public partial class MapRegionCommandApplySpellEffects : MapRegionCommandControl
    {

        private ApplySpellEffectsCommand mMyCommand;

        public MapRegionCommandApplySpellEffects(ApplySpellEffectsCommand refCommand) : base(refCommand?.ConditionLists?.Data())
        {
            InitializeComponent();
            mMyCommand = refCommand;
            InitLocalization();

            /*nudStr.Value = mMyCommand.StatDiff[(int)Stats.Attack];
            nudDef.Value = mMyCommand.StatDiff[(int)Stats.Defense];
            nudSpd.Value = mMyCommand.StatDiff[(int)Stats.Speed];
            nudMag.Value = mMyCommand.StatDiff[(int)Stats.AbilityPower];
            nudMR.Value = mMyCommand.StatDiff[(int)Stats.MagicResist];

            nudStrPercentage.Value = mMyCommand.PercentageStatDiff[(int)Stats.Attack];
            nudDefPercentage.Value = mMyCommand.PercentageStatDiff[(int)Stats.Defense];
            nudMagPercentage.Value = mMyCommand.PercentageStatDiff[(int)Stats.AbilityPower];
            nudMRPercentage.Value = mMyCommand.PercentageStatDiff[(int)Stats.MagicResist];
            nudSpdPercentage.Value = mMyCommand.PercentageStatDiff[(int)Stats.Speed];

            cmbExtraEffect.SelectedIndex = (int)mMyCommand.Effect;*/

            if (mMyCommand.ConditionLists == null || mMyCommand.ConditionLists.Count == 0)
            {
                btnEditCmdConditions.Text = Strings.MapRegionApplySpellEffects.editconditions.ToString(Strings.MapRegionApplySpellEffects.none);
            }
            else
            {
                btnEditCmdConditions.Text = Strings.MapRegionApplySpellEffects.editconditions.ToString(mMyCommand.ConditionLists.Count);
            }

            cmbSpell.Items.Clear();
            cmbSpell.Items.Add(Strings.General.none);
            cmbSpell.Items.AddRange(SpellBase.EditorFormatNames);
            cmbSpell.SelectedIndex = SpellBase.ListIndex(mMyCommand.SpellId ?? Guid.Empty) + 1;
        }

        private void InitLocalization()
        {
            grpApplySpellEffects.Text = Strings.MapRegionApplySpellEffects.title;
            lblInstructions.Text = Strings.MapRegionApplySpellEffects.instructions;
            lblSpell.Text = Strings.MapRegionApplySpellEffects.spell;
            /*grpStats.Text = Strings.MapRegionApplyStatus.stats;
            lblStr.Text = Strings.MapRegionApplyStatus.attack;
            lblDef.Text = Strings.MapRegionApplyStatus.defense;
            lblSpd.Text = Strings.MapRegionApplyStatus.speed;
            lblMag.Text = Strings.MapRegionApplyStatus.abilitypower;
            lblMR.Text = Strings.MapRegionApplyStatus.magicresist;

            grpEffect.Text = Strings.MapRegionApplyStatus.effectgroup;
            lblEffect.Text = Strings.MapRegionApplyStatus.effectlabel;
            cmbExtraEffect.Items.Clear();
            for (var i = 0; i < Strings.MapRegionApplyStatus.effects.Count; i++)
            {
                cmbExtraEffect.Items.Add(Strings.MapRegionApplyStatus.effects[i]);
            }

            lblSprite.Text = Strings.MapRegionApplyStatus.transformsprite;
            cmbTransform.Items.Clear();
            cmbTransform.Items.Add(Strings.General.none);
            var spriteNames = GameContentManager.GetSmartSortedTextureNames(GameContentManager.TextureType.Entity);
            cmbTransform.Items.AddRange(spriteNames);*/

            btnSave.Text = Strings.MapRegionApplySpellEffects.okay;
            btnCancel.Text = Strings.MapRegionApplySpellEffects.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*mMyCommand.StatDiff[(int)Stats.Attack] = (int)nudStr.Value;
            mMyCommand.StatDiff[(int)Stats.Defense] = (int)nudDef.Value;
            mMyCommand.StatDiff[(int)Stats.Speed] = (int)nudSpd.Value;
            mMyCommand.StatDiff[(int)Stats.AbilityPower] = (int)nudMag.Value;
            mMyCommand.StatDiff[(int)Stats.MagicResist] = (int)nudMR.Value;

            mMyCommand.PercentageStatDiff[(int)Stats.Attack] = (int)nudStrPercentage.Value;
            mMyCommand.PercentageStatDiff[(int)Stats.Defense] = (int)nudDefPercentage.Value;
            mMyCommand.PercentageStatDiff[(int)Stats.Speed] = (int)nudSpdPercentage.Value;
            mMyCommand.PercentageStatDiff[(int)Stats.AbilityPower] = (int)nudMagPercentage.Value;
            mMyCommand.PercentageStatDiff[(int)Stats.MagicResist] = (int)nudMRPercentage.Value;

            mMyCommand.Effect = (StatusTypes)cmbExtraEffect.SelectedIndex;
            if (mMyCommand.Effect == StatusTypes.Transform)
            {
                mMyCommand.Sprite = cmbTransform.Text;
            }
            else
            {
                mMyCommand.Sprite = null;
            }*/
            if (cmbSpell.SelectedIndex == 0)
            {
                mMyCommand.SpellId = null;
            }
            else
            {
                mMyCommand.SpellId = SpellBase.IdFromList(cmbSpell.SelectedIndex - 1);
            }
            ParentForm.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            mMyCommand.ConditionLists.Load(mBackupConditionData); // Cancel possible conditionlist editing
            ParentForm.Close();
        }

        /*private void cmbTransform_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTransform.SelectedIndex > 0)
            {
                var bmp = new Bitmap(picSprite.Width, picSprite.Height);
                var g = Graphics.FromImage(bmp);
                var src = Image.FromFile(GameContentManager.GraphResFolder + "/entities/" + cmbTransform.Text);
                g.DrawImage(
                    src,
                    new Rectangle(
                        picSprite.Width / 2 - src.Width / (Options.Instance.Sprites.NormalFrames * 2), picSprite.Height / 2 - src.Height / (Options.Instance.Sprites.Directions * 2), src.Width / Options.Instance.Sprites.NormalFrames,
                        src.Height / Options.Instance.Sprites.Directions
                    ), new Rectangle(0, 0, src.Width / Options.Instance.Sprites.NormalFrames, src.Height / Options.Instance.Sprites.Directions), GraphicsUnit.Pixel
                );

                g.Dispose();
                src.Dispose();
                picSprite.BackgroundImage = bmp;
            }
            else
            {
                picSprite.BackgroundImage = null;
            }
        }*/

        /*private void cmbExtraEffect_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSprite.Visible = false;
            cmbTransform.Visible = false;
            picSprite.Visible = false;
            if (cmbExtraEffect.SelectedIndex == 6) //Transform
            {
                lblSprite.Visible = true;
                cmbTransform.Visible = true;
                picSprite.Visible = true;

                cmbTransform.SelectedIndex =
                    cmbTransform.FindString(TextUtils.NullToNone(mMyCommand.Sprite));

                if (cmbTransform.SelectedIndex > 0)
                {
                    var bmp = new Bitmap(picSprite.Width, picSprite.Height);
                    var g = Graphics.FromImage(bmp);
                    var src = Image.FromFile(GameContentManager.GraphResFolder + "/entities/" + cmbTransform.Text);
                    g.DrawImage(
                        src,
                        new Rectangle(
                            picSprite.Width / 2 - src.Width / (Options.Instance.Sprites.NormalFrames * 2), picSprite.Height / 2 - src.Height / (Options.Instance.Sprites.Directions * 2), src.Width / Options.Instance.Sprites.NormalFrames,
                            src.Height / Options.Instance.Sprites.Directions
                        ), new Rectangle(0, 0, src.Width / Options.Instance.Sprites.NormalFrames, src.Height / Options.Instance.Sprites.Directions), GraphicsUnit.Pixel
                    );

                    g.Dispose();
                    src.Dispose();
                    picSprite.BackgroundImage = bmp;
                }
                else
                {
                    picSprite.BackgroundImage = null;
                }
            }
        }*/
        private void btnEditCmdConditions_Click(object sender, EventArgs e)
        {
            var editForm = new FrmDynamicRequirements(mMyCommand.ConditionLists, RequirementType.MapRegion);
            editForm.ShowDialog();
            if (mMyCommand.ConditionLists == null || mMyCommand.ConditionLists.Count == 0)
            {
                btnEditCmdConditions.Text = Strings.MapRegionApplySpellEffects.editconditions.ToString(Strings.MapRegionApplySpellEffects.none);
            }
            else
            {
                btnEditCmdConditions.Text = Strings.MapRegionApplySpellEffects.editconditions.ToString(mMyCommand.ConditionLists.Count);
            }
        }

    }

}
