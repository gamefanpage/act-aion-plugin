﻿// <auto-generated />
namespace AionParse_Plugin
{
    partial class AionParseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextboxLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxDefaultCharacter = new System.Windows.Forms.TextBox();
            this.ApplyDefaultCharacter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckboxGuessDoTCasters = new System.Windows.Forms.CheckBox();
            this.CheckboxDebugParse = new System.Windows.Forms.CheckBox();
            this.CheckboxTagBlockedAttacks = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.CheckboxLinkPets = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TextboxLog
            // 
            this.TextboxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxLog.Location = new System.Drawing.Point(34, 37);
            this.TextboxLog.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxLog.Multiline = true;
            this.TextboxLog.Name = "TextboxLog";
            this.TextboxLog.ReadOnly = true;
            this.TextboxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextboxLog.Size = new System.Drawing.Size(560, 437);
            this.TextboxLog.TabIndex = 0;
            this.TextboxLog.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log";
            // 
            // TextboxDefaultCharacter
            // 
            this.TextboxDefaultCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxDefaultCharacter.Location = new System.Drawing.Point(623, 37);
            this.TextboxDefaultCharacter.Name = "TextboxDefaultCharacter";
            this.TextboxDefaultCharacter.Size = new System.Drawing.Size(122, 22);
            this.TextboxDefaultCharacter.TabIndex = 2;
            this.TextboxDefaultCharacter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxDefaultCharacter_KeyDown);
            // 
            // ApplyDefaultCharacter
            // 
            this.ApplyDefaultCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyDefaultCharacter.Location = new System.Drawing.Point(762, 36);
            this.ApplyDefaultCharacter.Name = "ApplyDefaultCharacter";
            this.ApplyDefaultCharacter.Size = new System.Drawing.Size(75, 23);
            this.ApplyDefaultCharacter.TabIndex = 3;
            this.ApplyDefaultCharacter.Text = "Apply";
            this.ApplyDefaultCharacter.UseVisualStyleBackColor = true;
            this.ApplyDefaultCharacter.Click += new System.EventHandler(this.ApplyDefaultCharacter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Default Character";
            // 
            // CheckboxGuessDoTCasters
            // 
            this.CheckboxGuessDoTCasters.AutoSize = true;
            this.CheckboxGuessDoTCasters.Checked = true;
            this.CheckboxGuessDoTCasters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxGuessDoTCasters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxGuessDoTCasters.Location = new System.Drawing.Point(623, 79);
            this.CheckboxGuessDoTCasters.Name = "CheckboxGuessDoTCasters";
            this.CheckboxGuessDoTCasters.Size = new System.Drawing.Size(161, 20);
            this.CheckboxGuessDoTCasters.TabIndex = 5;
            this.CheckboxGuessDoTCasters.Text = "Guess Indirect Casters";
            this.CheckboxGuessDoTCasters.UseVisualStyleBackColor = true;
            this.CheckboxGuessDoTCasters.CheckedChanged += new System.EventHandler(this.CheckboxGuessDoTCasters_CheckedChanged);
            // 
            // CheckboxDebugParse
            // 
            this.CheckboxDebugParse.AutoSize = true;
            this.CheckboxDebugParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxDebugParse.Location = new System.Drawing.Point(623, 457);
            this.CheckboxDebugParse.Name = "CheckboxDebugParse";
            this.CheckboxDebugParse.Size = new System.Drawing.Size(109, 17);
            this.CheckboxDebugParse.TabIndex = 99;
            this.CheckboxDebugParse.Text = "Debug Messages";
            this.CheckboxDebugParse.UseVisualStyleBackColor = true;
            this.CheckboxDebugParse.CheckedChanged += new System.EventHandler(this.CheckboxDebugParse_CheckedChanged);
            // 
            // CheckboxTagBlockedAttacks
            // 
            this.CheckboxTagBlockedAttacks.AutoSize = true;
            this.CheckboxTagBlockedAttacks.Checked = true;
            this.CheckboxTagBlockedAttacks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxTagBlockedAttacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxTagBlockedAttacks.Location = new System.Drawing.Point(623, 106);
            this.CheckboxTagBlockedAttacks.Name = "CheckboxTagBlockedAttacks";
            this.CheckboxTagBlockedAttacks.Size = new System.Drawing.Size(152, 20);
            this.CheckboxTagBlockedAttacks.TabIndex = 7;
            this.CheckboxTagBlockedAttacks.Text = "Tag Blocked Attacks";
            this.toolTip1.SetToolTip(this.CheckboxTagBlockedAttacks, "When checked, the parser will parse blocked attacks and attempt to label the foll" +
                    "owing attack as (special) blocked.");
            this.CheckboxTagBlockedAttacks.UseVisualStyleBackColor = true;
            this.CheckboxTagBlockedAttacks.CheckedChanged += new System.EventHandler(this.CheckboxTagBlockedAttacks_CheckedChanged);
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 10000;
            this.toolTip2.InitialDelay = 500;
            this.toolTip2.ReshowDelay = 100;
            // 
            // CheckboxLinkPets
            // 
            this.CheckboxLinkPets.AutoSize = true;
            this.CheckboxLinkPets.Enabled = false;
            this.CheckboxLinkPets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxLinkPets.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CheckboxLinkPets.Location = new System.Drawing.Point(623, 133);
            this.CheckboxLinkPets.Name = "CheckboxLinkPets";
            this.CheckboxLinkPets.Size = new System.Drawing.Size(174, 20);
            this.CheckboxLinkPets.TabIndex = 100;
            this.CheckboxLinkPets.Text = "Link Pets with Summoner";
            this.CheckboxLinkPets.UseVisualStyleBackColor = true;
            this.CheckboxLinkPets.CheckedChanged += new System.EventHandler(this.CheckboxLinkPets_CheckedChanged);
            // 
            // AionParseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CheckboxLinkPets);
            this.Controls.Add(this.CheckboxTagBlockedAttacks);
            this.Controls.Add(this.CheckboxDebugParse);
            this.Controls.Add(this.CheckboxGuessDoTCasters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApplyDefaultCharacter);
            this.Controls.Add(this.TextboxDefaultCharacter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AionParseForm";
            this.Size = new System.Drawing.Size(1334, 507);
            this.Load += new System.EventHandler(this.AionParseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxDefaultCharacter;
        private System.Windows.Forms.Button ApplyDefaultCharacter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckboxGuessDoTCasters;
        private System.Windows.Forms.CheckBox CheckboxDebugParse;
        private System.Windows.Forms.CheckBox CheckboxTagBlockedAttacks;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.CheckBox CheckboxLinkPets;
    }
}