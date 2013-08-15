namespace BinPackr
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.containerPanel = new System.Windows.Forms.Panel();
      this.panel = new System.Windows.Forms.Panel();
      this.groupBoxPanelSize = new System.Windows.Forms.GroupBox();
      this.buttonSetPanelSize = new System.Windows.Forms.Button();
      this.labelHeight = new System.Windows.Forms.Label();
      this.panelHeightInput = new System.Windows.Forms.TextBox();
      this.panelWidthInput = new System.Windows.Forms.TextBox();
      this.labelWidth = new System.Windows.Forms.Label();
      this.groupBoxPopulate = new System.Windows.Forms.GroupBox();
      this.sizeSelect = new System.Windows.Forms.ComboBox();
      this.buttonPopulate = new System.Windows.Forms.Button();
      this.labelCount = new System.Windows.Forms.Label();
      this.countInput = new System.Windows.Forms.TextBox();
      this.labelSize = new System.Windows.Forms.Label();
      this.groupBoxOperate = new System.Windows.Forms.GroupBox();
      this.buttonSort = new System.Windows.Forms.Button();
      this.buttonScramble = new System.Windows.Forms.Button();
      this.buttonShowHideDebug = new System.Windows.Forms.Button();
      this.groupBoxLog = new System.Windows.Forms.GroupBox();
      this.log = new System.Windows.Forms.ListBox();
      this.containerPanel.SuspendLayout();
      this.groupBoxPanelSize.SuspendLayout();
      this.groupBoxPopulate.SuspendLayout();
      this.groupBoxOperate.SuspendLayout();
      this.groupBoxLog.SuspendLayout();
      this.SuspendLayout();
      // 
      // containerPanel
      // 
      this.containerPanel.AutoScroll = true;
      this.containerPanel.BackColor = System.Drawing.Color.Transparent;
      this.containerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.containerPanel.Controls.Add(this.panel);
      this.containerPanel.Location = new System.Drawing.Point(13, 13);
      this.containerPanel.Name = "containerPanel";
      this.containerPanel.Size = new System.Drawing.Size(523, 352);
      this.containerPanel.TabIndex = 6;
      // 
      // panel
      // 
      this.panel.BackColor = System.Drawing.Color.White;
      this.panel.ImeMode = System.Windows.Forms.ImeMode.On;
      this.panel.Location = new System.Drawing.Point(0, 0);
      this.panel.Margin = new System.Windows.Forms.Padding(0);
      this.panel.Name = "panel";
      this.panel.Size = new System.Drawing.Size(521, 350);
      this.panel.TabIndex = 0;
      this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPaint);
      // 
      // groupBoxPanelSize
      // 
      this.groupBoxPanelSize.Controls.Add(this.buttonSetPanelSize);
      this.groupBoxPanelSize.Controls.Add(this.labelHeight);
      this.groupBoxPanelSize.Controls.Add(this.panelHeightInput);
      this.groupBoxPanelSize.Controls.Add(this.panelWidthInput);
      this.groupBoxPanelSize.Controls.Add(this.labelWidth);
      this.groupBoxPanelSize.Location = new System.Drawing.Point(14, 372);
      this.groupBoxPanelSize.Name = "groupBoxPanelSize";
      this.groupBoxPanelSize.Size = new System.Drawing.Size(170, 105);
      this.groupBoxPanelSize.TabIndex = 0;
      this.groupBoxPanelSize.TabStop = false;
      this.groupBoxPanelSize.Text = "Panel Size";
      // 
      // buttonSetPanelSize
      // 
      this.buttonSetPanelSize.Location = new System.Drawing.Point(9, 71);
      this.buttonSetPanelSize.Name = "buttonSetPanelSize";
      this.buttonSetPanelSize.Size = new System.Drawing.Size(155, 23);
      this.buttonSetPanelSize.TabIndex = 3;
      this.buttonSetPanelSize.Text = "Set Panel Size";
      this.buttonSetPanelSize.UseVisualStyleBackColor = true;
      this.buttonSetPanelSize.Click += new System.EventHandler(this.SetPanelSizeClick);
      // 
      // labelHeight
      // 
      this.labelHeight.AutoSize = true;
      this.labelHeight.Location = new System.Drawing.Point(6, 48);
      this.labelHeight.Name = "labelHeight";
      this.labelHeight.Size = new System.Drawing.Size(38, 13);
      this.labelHeight.TabIndex = 3;
      this.labelHeight.Text = "Height";
      // 
      // panelHeightInput
      // 
      this.panelHeightInput.Location = new System.Drawing.Point(74, 45);
      this.panelHeightInput.Name = "panelHeightInput";
      this.panelHeightInput.Size = new System.Drawing.Size(90, 20);
      this.panelHeightInput.TabIndex = 2;
      this.panelHeightInput.Text = "350";
      this.panelHeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // panelWidthInput
      // 
      this.panelWidthInput.Location = new System.Drawing.Point(74, 22);
      this.panelWidthInput.Name = "panelWidthInput";
      this.panelWidthInput.Size = new System.Drawing.Size(90, 20);
      this.panelWidthInput.TabIndex = 1;
      this.panelWidthInput.Text = "521";
      this.panelWidthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // labelWidth
      // 
      this.labelWidth.AutoSize = true;
      this.labelWidth.Location = new System.Drawing.Point(6, 22);
      this.labelWidth.Name = "labelWidth";
      this.labelWidth.Size = new System.Drawing.Size(35, 13);
      this.labelWidth.TabIndex = 0;
      this.labelWidth.Text = "Width";
      // 
      // groupBoxPopulate
      // 
      this.groupBoxPopulate.Controls.Add(this.sizeSelect);
      this.groupBoxPopulate.Controls.Add(this.buttonPopulate);
      this.groupBoxPopulate.Controls.Add(this.labelCount);
      this.groupBoxPopulate.Controls.Add(this.countInput);
      this.groupBoxPopulate.Controls.Add(this.labelSize);
      this.groupBoxPopulate.Location = new System.Drawing.Point(190, 372);
      this.groupBoxPopulate.Name = "groupBoxPopulate";
      this.groupBoxPopulate.Size = new System.Drawing.Size(170, 105);
      this.groupBoxPopulate.TabIndex = 0;
      this.groupBoxPopulate.TabStop = false;
      this.groupBoxPopulate.Text = "Populate";
      // 
      // sizeSelect
      // 
      this.sizeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.sizeSelect.FormattingEnabled = true;
      this.sizeSelect.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
      this.sizeSelect.Location = new System.Drawing.Point(74, 19);
      this.sizeSelect.Name = "sizeSelect";
      this.sizeSelect.Size = new System.Drawing.Size(90, 21);
      this.sizeSelect.TabIndex = 4;
      // 
      // buttonPopulate
      // 
      this.buttonPopulate.Location = new System.Drawing.Point(9, 71);
      this.buttonPopulate.Name = "buttonPopulate";
      this.buttonPopulate.Size = new System.Drawing.Size(155, 23);
      this.buttonPopulate.TabIndex = 6;
      this.buttonPopulate.Text = "Generate Blocks";
      this.buttonPopulate.UseVisualStyleBackColor = true;
      this.buttonPopulate.Click += new System.EventHandler(this.PopulateClick);
      // 
      // labelCount
      // 
      this.labelCount.AutoSize = true;
      this.labelCount.Location = new System.Drawing.Point(6, 48);
      this.labelCount.Name = "labelCount";
      this.labelCount.Size = new System.Drawing.Size(35, 13);
      this.labelCount.TabIndex = 3;
      this.labelCount.Text = "Count";
      // 
      // countInput
      // 
      this.countInput.Location = new System.Drawing.Point(74, 45);
      this.countInput.Name = "countInput";
      this.countInput.Size = new System.Drawing.Size(90, 20);
      this.countInput.TabIndex = 5;
      this.countInput.Text = "30";
      this.countInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // labelSize
      // 
      this.labelSize.AutoSize = true;
      this.labelSize.Location = new System.Drawing.Point(6, 22);
      this.labelSize.Name = "labelSize";
      this.labelSize.Size = new System.Drawing.Size(62, 13);
      this.labelSize.TabIndex = 0;
      this.labelSize.Text = "Size Range";
      // 
      // groupBoxOperate
      // 
      this.groupBoxOperate.Controls.Add(this.buttonSort);
      this.groupBoxOperate.Controls.Add(this.buttonScramble);
      this.groupBoxOperate.Controls.Add(this.buttonShowHideDebug);
      this.groupBoxOperate.Location = new System.Drawing.Point(366, 372);
      this.groupBoxOperate.Name = "groupBoxOperate";
      this.groupBoxOperate.Size = new System.Drawing.Size(170, 105);
      this.groupBoxOperate.TabIndex = 7;
      this.groupBoxOperate.TabStop = false;
      this.groupBoxOperate.Text = "Operate";
      // 
      // buttonSort
      // 
      this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonSort.Location = new System.Drawing.Point(9, 19);
      this.buttonSort.Name = "buttonSort";
      this.buttonSort.Size = new System.Drawing.Size(155, 23);
      this.buttonSort.TabIndex = 8;
      this.buttonSort.Text = "Sort";
      this.buttonSort.UseVisualStyleBackColor = true;
      this.buttonSort.Click += new System.EventHandler(this.SortClick);
      // 
      // buttonScramble
      // 
      this.buttonScramble.Location = new System.Drawing.Point(9, 45);
      this.buttonScramble.Name = "buttonScramble";
      this.buttonScramble.Size = new System.Drawing.Size(155, 23);
      this.buttonScramble.TabIndex = 7;
      this.buttonScramble.Text = "Scramble";
      this.buttonScramble.UseVisualStyleBackColor = true;
      this.buttonScramble.Click += new System.EventHandler(this.ScrambleClick);
      // 
      // buttonShowHideDebug
      // 
      this.buttonShowHideDebug.Location = new System.Drawing.Point(9, 71);
      this.buttonShowHideDebug.Name = "buttonShowHideDebug";
      this.buttonShowHideDebug.Size = new System.Drawing.Size(155, 23);
      this.buttonShowHideDebug.TabIndex = 6;
      this.buttonShowHideDebug.Text = "Show Log";
      this.buttonShowHideDebug.UseVisualStyleBackColor = true;
      this.buttonShowHideDebug.Click += new System.EventHandler(this.ToggleLogClick);
      // 
      // groupBoxLog
      // 
      this.groupBoxLog.Controls.Add(this.log);
      this.groupBoxLog.Location = new System.Drawing.Point(13, 484);
      this.groupBoxLog.Name = "groupBoxLog";
      this.groupBoxLog.Size = new System.Drawing.Size(522, 137);
      this.groupBoxLog.TabIndex = 8;
      this.groupBoxLog.TabStop = false;
      this.groupBoxLog.Text = "Log";
      // 
      // log
      // 
      this.log.FormattingEnabled = true;
      this.log.Location = new System.Drawing.Point(10, 20);
      this.log.Name = "log";
      this.log.Size = new System.Drawing.Size(502, 108);
      this.log.TabIndex = 0;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(549, 634);
      this.Controls.Add(this.groupBoxLog);
      this.Controls.Add(this.groupBoxOperate);
      this.Controls.Add(this.groupBoxPopulate);
      this.Controls.Add(this.groupBoxPanelSize);
      this.Controls.Add(this.containerPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.Text = "BinPackr";
      this.containerPanel.ResumeLayout(false);
      this.groupBoxPanelSize.ResumeLayout(false);
      this.groupBoxPanelSize.PerformLayout();
      this.groupBoxPopulate.ResumeLayout(false);
      this.groupBoxPopulate.PerformLayout();
      this.groupBoxOperate.ResumeLayout(false);
      this.groupBoxLog.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel containerPanel;
    private System.Windows.Forms.Panel panel;
    private System.Windows.Forms.GroupBox groupBoxPanelSize;
    private System.Windows.Forms.Label labelHeight;
    private System.Windows.Forms.TextBox panelHeightInput;
    private System.Windows.Forms.TextBox panelWidthInput;
    private System.Windows.Forms.Label labelWidth;
    private System.Windows.Forms.Button buttonSetPanelSize;
    private System.Windows.Forms.GroupBox groupBoxPopulate;
    private System.Windows.Forms.Button buttonPopulate;
    private System.Windows.Forms.Label labelCount;
    private System.Windows.Forms.TextBox countInput;
    private System.Windows.Forms.Label labelSize;
    private System.Windows.Forms.ComboBox sizeSelect;
    private System.Windows.Forms.GroupBox groupBoxOperate;
    private System.Windows.Forms.Button buttonSort;
    private System.Windows.Forms.Button buttonScramble;
    private System.Windows.Forms.Button buttonShowHideDebug;
    private System.Windows.Forms.GroupBox groupBoxLog;
    private System.Windows.Forms.ListBox log;
  }
}