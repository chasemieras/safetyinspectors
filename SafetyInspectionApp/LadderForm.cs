using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SafetyInspectionApp
{
    public class LadderForm
    {
        FormHelper formHelper = new FormHelper();

        public void generateLadderForm() 
        {
            GroupBox LadderInspectGroup = new GroupBox();
            Button NextLadderFormButton = new Button();
            GroupBox LadderMaterial = new System.Windows.Forms.GroupBox();
            RadioButton AluminumRadioButton = new System.Windows.Forms.RadioButton();
            RadioButton FiberglassRadioButton = new System.Windows.Forms.RadioButton();
            GroupBox LadderType = new System.Windows.Forms.GroupBox();
            RadioButton ExtensionRadioButton = new System.Windows.Forms.RadioButton();
            RadioButton PodiumRadioButton = new System.Windows.Forms.RadioButton();
            RadioButton SetpLadderRadioButton = new System.Windows.Forms.RadioButton();
            GroupBox LadderInfo = new System.Windows.Forms.GroupBox();
            TextBox textBox2 = new System.Windows.Forms.TextBox();
            TextBox textBox1 = new System.Windows.Forms.TextBox();
            Label label2 = new System.Windows.Forms.Label();
            Label label1 = new System.Windows.Forms.Label();

            // 
            // LadderInspectGroup
            // 
            LadderInspectGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            LadderInspectGroup.Controls.Add(NextLadderFormButton);
            LadderInspectGroup.Controls.Add(LadderMaterial);
            LadderInspectGroup.Controls.Add(LadderType);
            LadderInspectGroup.Controls.Add(LadderInfo);
            LadderInspectGroup.Location = new System.Drawing.Point(250, 12);
            LadderInspectGroup.MaximumSize = new System.Drawing.Size(440, 900);
            LadderInspectGroup.MinimumSize = new System.Drawing.Size(220, 450);
            LadderInspectGroup.Name = "LadderInspectGroup";
            LadderInspectGroup.Size = new System.Drawing.Size(220, 450);
            LadderInspectGroup.TabIndex = 0;
            LadderInspectGroup.TabStop = false;
            LadderInspectGroup.Text = "Ladder Inspection";
            // 
            // NextLadderFormButton
            // 
            NextLadderFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            NextLadderFormButton.Location = new System.Drawing.Point(33, 329);
            NextLadderFormButton.Name = "NextLadderFormButton";
            NextLadderFormButton.Size = new System.Drawing.Size(157, 25);
            NextLadderFormButton.TabIndex = 4;
            NextLadderFormButton.Text = "Next";
            NextLadderFormButton.UseVisualStyleBackColor = true;
            NextLadderFormButton.Click += new System.EventHandler(NextLadderFormButton_Click);
            // 
            // LadderMaterial
            // 
            LadderMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            LadderMaterial.Controls.Add(AluminumRadioButton);
            LadderMaterial.Controls.Add(FiberglassRadioButton);
            LadderMaterial.Location = new System.Drawing.Point(30, 234);
            LadderMaterial.Name = "LadderMaterial";
            LadderMaterial.Size = new System.Drawing.Size(163, 89);
            LadderMaterial.TabIndex = 3;
            LadderMaterial.TabStop = false;
            LadderMaterial.Text = "Ladder Material";
            // 
            // AluminumRadioButton
            // 
            AluminumRadioButton.AutoSize = true;
            AluminumRadioButton.Location = new System.Drawing.Point(7, 48);
            AluminumRadioButton.Name = "AluminumRadioButton";
            AluminumRadioButton.Size = new System.Drawing.Size(82, 19);
            AluminumRadioButton.TabIndex = 0;
            AluminumRadioButton.TabStop = true;
            AluminumRadioButton.Text = "Aluminum";
            AluminumRadioButton.UseVisualStyleBackColor = true;
            // 
            // FiberglassRadioButton
            // 
            FiberglassRadioButton.AutoSize = true;
            FiberglassRadioButton.Location = new System.Drawing.Point(7, 23);
            FiberglassRadioButton.Name = "FiberglassRadioButton";
            FiberglassRadioButton.Size = new System.Drawing.Size(77, 19);
            FiberglassRadioButton.TabIndex = 0;
            FiberglassRadioButton.TabStop = true;
            FiberglassRadioButton.Text = "Fiberglass";
            FiberglassRadioButton.UseVisualStyleBackColor = true;
            // 
            // LadderType
            // 
            LadderType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            LadderType.Controls.Add(ExtensionRadioButton);
            LadderType.Controls.Add(PodiumRadioButton);
            LadderType.Controls.Add(SetpLadderRadioButton);
            LadderType.Location = new System.Drawing.Point(30, 126);
            LadderType.Name = "LadderType";
            LadderType.Size = new System.Drawing.Size(163, 114);
            LadderType.TabIndex = 3;
            LadderType.TabStop = false;
            LadderType.Text = "Ladder Type";
            // 
            // ExtensionRadioButton
            // 
            ExtensionRadioButton.AutoSize = true;
            ExtensionRadioButton.Location = new System.Drawing.Point(7, 73);
            ExtensionRadioButton.Name = "ExtensionRadioButton";
            ExtensionRadioButton.Size = new System.Drawing.Size(76, 19);
            ExtensionRadioButton.TabIndex = 0;
            ExtensionRadioButton.TabStop = true;
            ExtensionRadioButton.Text = "Extension";
            ExtensionRadioButton.UseVisualStyleBackColor = true;
            // 
            // PodiumRadioButton
            // 
            PodiumRadioButton.AutoSize = true;
            PodiumRadioButton.Location = new System.Drawing.Point(7, 48);
            PodiumRadioButton.Name = "PodiumRadioButton";
            PodiumRadioButton.Size = new System.Drawing.Size(67, 19);
            PodiumRadioButton.TabIndex = 0;
            PodiumRadioButton.TabStop = true;
            PodiumRadioButton.Text = "Podium";
            PodiumRadioButton.UseVisualStyleBackColor = true;
            // 
            // SetpLadderRadioButton
            // 
            SetpLadderRadioButton.AutoSize = true;
            SetpLadderRadioButton.Location = new System.Drawing.Point(7, 23);
            SetpLadderRadioButton.Name = "SetpLadderRadioButton";
            SetpLadderRadioButton.Size = new System.Drawing.Size(87, 19);
            SetpLadderRadioButton.TabIndex = 0;
            SetpLadderRadioButton.TabStop = true;
            SetpLadderRadioButton.Text = "Step Ladder";
            SetpLadderRadioButton.UseVisualStyleBackColor = true;
            // 
            // LadderInfo
            // 
            LadderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            LadderInfo.Controls.Add(textBox2);
            LadderInfo.Controls.Add(textBox1);
            LadderInfo.Controls.Add(label2);
            LadderInfo.Controls.Add(label1);
            LadderInfo.Location = new System.Drawing.Point(30, 22);
            LadderInfo.Name = "LadderInfo";
            LadderInfo.Size = new System.Drawing.Size(163, 100);
            LadderInfo.TabIndex = 2;
            LadderInfo.TabStop = false;
            LadderInfo.Text = "Basic Ladder Info";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(105, 27);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ladder#";
            textBox2.Size = new System.Drawing.Size(52, 23);
            textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(68, 55);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Location";
            textBox1.Size = new System.Drawing.Size(89, 23);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Location:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Ladder Number:";

        }

        private void NextLadderFormButton_Click(object sender, EventArgs e)
        {
            formHelper.createConditionSection();
        }
    }
}
