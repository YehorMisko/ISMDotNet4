namespace ISMDotNet4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ArrayCountLabel = new System.Windows.Forms.Label();
            this.TextBoxArrayCount = new System.Windows.Forms.TextBox();
            this.ButtonInputArray = new System.Windows.Forms.Button();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.ButtonNegativeSum = new System.Windows.Forms.Button();
            this.labelNegativeSumResult = new System.Windows.Forms.Label();
            this.ButtonMaxElement = new System.Windows.Forms.Button();
            this.ButtonMaxElementIndex = new System.Windows.Forms.Button();
            this.ButtonMaxAbsElement = new System.Windows.Forms.Button();
            this.labelMaxElement = new System.Windows.Forms.Label();
            this.labelMaxElementIndex = new System.Windows.Forms.Label();
            this.labelMaxAbsElement = new System.Windows.Forms.Label();
            this.buttonSumOfPositiveIndexes = new System.Windows.Forms.Button();
            this.labelSumOfPositiveIndexes = new System.Windows.Forms.Label();
            this.buttonIntegerAmount = new System.Windows.Forms.Button();
            this.labelIntegerAmount = new System.Windows.Forms.Label();
            this.ReverseSort = new System.Windows.Forms.Button();
            this.dataGridArraySorted = new System.Windows.Forms.DataGridView();
            this.buttonDeleteNegativeElements = new System.Windows.Forms.Button();
            this.dataGridArrayDeletedNegativeElements = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArraySorted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArrayDeletedNegativeElements)).BeginInit();
            this.SuspendLayout();
            // 
            // ArrayCountLabel
            // 
            this.ArrayCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrayCountLabel.AutoSize = true;
            this.ArrayCountLabel.Location = new System.Drawing.Point(134, 55);
            this.ArrayCountLabel.Name = "ArrayCountLabel";
            this.ArrayCountLabel.Size = new System.Drawing.Size(161, 14);
            this.ArrayCountLabel.TabIndex = 0;
            this.ArrayCountLabel.Text = "Array members count = ";
            this.ArrayCountLabel.Click += new System.EventHandler(this.ArrayCountLabel_Click);
            // 
            // TextBoxArrayCount
            // 
            this.TextBoxArrayCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxArrayCount.Location = new System.Drawing.Point(394, 52);
            this.TextBoxArrayCount.Name = "TextBoxArrayCount";
            this.TextBoxArrayCount.Size = new System.Drawing.Size(118, 21);
            this.TextBoxArrayCount.TabIndex = 1;
            // 
            // ButtonInputArray
            // 
            this.ButtonInputArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInputArray.Location = new System.Drawing.Point(642, 50);
            this.ButtonInputArray.Name = "ButtonInputArray";
            this.ButtonInputArray.Size = new System.Drawing.Size(204, 25);
            this.ButtonInputArray.TabIndex = 2;
            this.ButtonInputArray.Text = "Start inputing the Array";
            this.ButtonInputArray.UseVisualStyleBackColor = true;
            this.ButtonInputArray.Click += new System.EventHandler(this.ButtonInputArray_Click);
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AllowUserToAddRows = false;
            this.dataGridViewArray.AllowUserToDeleteRows = false;
            this.dataGridViewArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(14, 92);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.Size = new System.Drawing.Size(888, 78);
            this.dataGridViewArray.TabIndex = 3;
            // 
            // ButtonNegativeSum
            // 
            this.ButtonNegativeSum.Location = new System.Drawing.Point(61, 176);
            this.ButtonNegativeSum.Name = "ButtonNegativeSum";
            this.ButtonNegativeSum.Size = new System.Drawing.Size(176, 25);
            this.ButtonNegativeSum.TabIndex = 4;
            this.ButtonNegativeSum.Text = "Sum of Negative Elements";
            this.ButtonNegativeSum.UseVisualStyleBackColor = true;
            this.ButtonNegativeSum.Click += new System.EventHandler(this.ButtonNegativeSum_Click);
            // 
            // labelNegativeSumResult
            // 
            this.labelNegativeSumResult.AutoSize = true;
            this.labelNegativeSumResult.Location = new System.Drawing.Point(68, 212);
            this.labelNegativeSumResult.Name = "labelNegativeSumResult";
            this.labelNegativeSumResult.Size = new System.Drawing.Size(161, 14);
            this.labelNegativeSumResult.TabIndex = 5;
            this.labelNegativeSumResult.Text = "labelNegativeSumResult";
            this.labelNegativeSumResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNegativeSumResult.Visible = false;
            this.labelNegativeSumResult.Click += new System.EventHandler(this.labelNegativeSumResult_Click);
            // 
            // ButtonMaxElement
            // 
            this.ButtonMaxElement.Location = new System.Drawing.Point(275, 176);
            this.ButtonMaxElement.Name = "ButtonMaxElement";
            this.ButtonMaxElement.Size = new System.Drawing.Size(176, 25);
            this.ButtonMaxElement.TabIndex = 6;
            this.ButtonMaxElement.Text = "Max Element";
            this.ButtonMaxElement.UseVisualStyleBackColor = true;
            this.ButtonMaxElement.Click += new System.EventHandler(this.ButtonMaxElement_Click);
            // 
            // ButtonMaxElementIndex
            // 
            this.ButtonMaxElementIndex.Location = new System.Drawing.Point(482, 176);
            this.ButtonMaxElementIndex.Name = "ButtonMaxElementIndex";
            this.ButtonMaxElementIndex.Size = new System.Drawing.Size(176, 25);
            this.ButtonMaxElementIndex.TabIndex = 7;
            this.ButtonMaxElementIndex.Text = "Max Element Index";
            this.ButtonMaxElementIndex.UseVisualStyleBackColor = true;
            this.ButtonMaxElementIndex.Click += new System.EventHandler(this.ButtonMaxElementIndex_Click);
            // 
            // ButtonMaxAbsElement
            // 
            this.ButtonMaxAbsElement.Location = new System.Drawing.Point(696, 176);
            this.ButtonMaxAbsElement.Name = "ButtonMaxAbsElement";
            this.ButtonMaxAbsElement.Size = new System.Drawing.Size(176, 25);
            this.ButtonMaxAbsElement.TabIndex = 8;
            this.ButtonMaxAbsElement.Text = "Max Absolute Element";
            this.ButtonMaxAbsElement.UseVisualStyleBackColor = true;
            this.ButtonMaxAbsElement.Click += new System.EventHandler(this.ButtonMaxAbsElement_Click);
            // 
            // labelMaxElement
            // 
            this.labelMaxElement.AutoSize = true;
            this.labelMaxElement.Location = new System.Drawing.Point(308, 212);
            this.labelMaxElement.Name = "labelMaxElement";
            this.labelMaxElement.Size = new System.Drawing.Size(112, 14);
            this.labelMaxElement.TabIndex = 9;
            this.labelMaxElement.Text = "labelMaxElement";
            this.labelMaxElement.Visible = false;
            this.labelMaxElement.Click += new System.EventHandler(this.labelMaxElement_Click);
            // 
            // labelMaxElementIndex
            // 
            this.labelMaxElementIndex.AutoSize = true;
            this.labelMaxElementIndex.Location = new System.Drawing.Point(498, 212);
            this.labelMaxElementIndex.Name = "labelMaxElementIndex";
            this.labelMaxElementIndex.Size = new System.Drawing.Size(147, 14);
            this.labelMaxElementIndex.TabIndex = 10;
            this.labelMaxElementIndex.Text = "labelMaxElementIndex";
            this.labelMaxElementIndex.Visible = false;
            // 
            // labelMaxAbsElement
            // 
            this.labelMaxAbsElement.AutoSize = true;
            this.labelMaxAbsElement.Location = new System.Drawing.Point(717, 212);
            this.labelMaxAbsElement.Name = "labelMaxAbsElement";
            this.labelMaxAbsElement.Size = new System.Drawing.Size(133, 14);
            this.labelMaxAbsElement.TabIndex = 11;
            this.labelMaxAbsElement.Text = "labelMaxAbsElement";
            this.labelMaxAbsElement.Visible = false;
            this.labelMaxAbsElement.Click += new System.EventHandler(this.labelMaxAbsElement_Click);
            // 
            // buttonSumOfPositiveIndexes
            // 
            this.buttonSumOfPositiveIndexes.Location = new System.Drawing.Point(61, 250);
            this.buttonSumOfPositiveIndexes.Name = "buttonSumOfPositiveIndexes";
            this.buttonSumOfPositiveIndexes.Size = new System.Drawing.Size(176, 25);
            this.buttonSumOfPositiveIndexes.TabIndex = 12;
            this.buttonSumOfPositiveIndexes.Text = "Sum of Positive Indexes";
            this.buttonSumOfPositiveIndexes.UseVisualStyleBackColor = true;
            this.buttonSumOfPositiveIndexes.Click += new System.EventHandler(this.buttonSumOfPositiveIndexes_Click);
            // 
            // labelSumOfPositiveIndexes
            // 
            this.labelSumOfPositiveIndexes.AutoSize = true;
            this.labelSumOfPositiveIndexes.Location = new System.Drawing.Point(59, 291);
            this.labelSumOfPositiveIndexes.Name = "labelSumOfPositiveIndexes";
            this.labelSumOfPositiveIndexes.Size = new System.Drawing.Size(182, 14);
            this.labelSumOfPositiveIndexes.TabIndex = 13;
            this.labelSumOfPositiveIndexes.Text = "labelSumOfPositiveIndexes";
            this.labelSumOfPositiveIndexes.Visible = false;
            // 
            // buttonIntegerAmount
            // 
            this.buttonIntegerAmount.Location = new System.Drawing.Point(275, 250);
            this.buttonIntegerAmount.Name = "buttonIntegerAmount";
            this.buttonIntegerAmount.Size = new System.Drawing.Size(176, 25);
            this.buttonIntegerAmount.TabIndex = 14;
            this.buttonIntegerAmount.Text = "Integer Amount";
            this.buttonIntegerAmount.UseVisualStyleBackColor = true;
            this.buttonIntegerAmount.Click += new System.EventHandler(this.buttonIntegerAmount_Click);
            // 
            // labelIntegerAmount
            // 
            this.labelIntegerAmount.AutoSize = true;
            this.labelIntegerAmount.Location = new System.Drawing.Point(295, 291);
            this.labelIntegerAmount.Name = "labelIntegerAmount";
            this.labelIntegerAmount.Size = new System.Drawing.Size(133, 14);
            this.labelIntegerAmount.TabIndex = 15;
            this.labelIntegerAmount.Text = "labelIntegerAmount";
            this.labelIntegerAmount.Visible = false;
            this.labelIntegerAmount.Click += new System.EventHandler(this.labelIntegerAmount_Click);
            // 
            // ReverseSort
            // 
            this.ReverseSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReverseSort.Location = new System.Drawing.Point(370, 347);
            this.ReverseSort.Name = "ReverseSort";
            this.ReverseSort.Size = new System.Drawing.Size(176, 25);
            this.ReverseSort.TabIndex = 16;
            this.ReverseSort.Text = "Descending Sort";
            this.ReverseSort.UseVisualStyleBackColor = true;
            this.ReverseSort.Click += new System.EventHandler(this.ReverseSort_Click);
            // 
            // dataGridArraySorted
            // 
            this.dataGridArraySorted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridArraySorted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArraySorted.Location = new System.Drawing.Point(14, 378);
            this.dataGridArraySorted.Name = "dataGridArraySorted";
            this.dataGridArraySorted.Size = new System.Drawing.Size(889, 78);
            this.dataGridArraySorted.TabIndex = 17;
            // 
            // buttonDeleteNegativeElements
            // 
            this.buttonDeleteNegativeElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteNegativeElements.Location = new System.Drawing.Point(370, 470);
            this.buttonDeleteNegativeElements.Name = "buttonDeleteNegativeElements";
            this.buttonDeleteNegativeElements.Size = new System.Drawing.Size(176, 28);
            this.buttonDeleteNegativeElements.TabIndex = 18;
            this.buttonDeleteNegativeElements.Text = "Delete Negative Elements";
            this.buttonDeleteNegativeElements.UseVisualStyleBackColor = true;
            this.buttonDeleteNegativeElements.Click += new System.EventHandler(this.buttonDeleteNegativeElements_Click);
            // 
            // dataGridArrayDeletedNegativeElements
            // 
            this.dataGridArrayDeletedNegativeElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridArrayDeletedNegativeElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArrayDeletedNegativeElements.Location = new System.Drawing.Point(14, 504);
            this.dataGridArrayDeletedNegativeElements.Name = "dataGridArrayDeletedNegativeElements";
            this.dataGridArrayDeletedNegativeElements.Size = new System.Drawing.Size(889, 78);
            this.dataGridArrayDeletedNegativeElements.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(932, 596);
            this.Controls.Add(this.dataGridArrayDeletedNegativeElements);
            this.Controls.Add(this.buttonDeleteNegativeElements);
            this.Controls.Add(this.dataGridArraySorted);
            this.Controls.Add(this.ReverseSort);
            this.Controls.Add(this.labelIntegerAmount);
            this.Controls.Add(this.buttonIntegerAmount);
            this.Controls.Add(this.labelSumOfPositiveIndexes);
            this.Controls.Add(this.buttonSumOfPositiveIndexes);
            this.Controls.Add(this.labelMaxAbsElement);
            this.Controls.Add(this.labelMaxElementIndex);
            this.Controls.Add(this.labelMaxElement);
            this.Controls.Add(this.ButtonMaxAbsElement);
            this.Controls.Add(this.ButtonMaxElementIndex);
            this.Controls.Add(this.ButtonMaxElement);
            this.Controls.Add(this.labelNegativeSumResult);
            this.Controls.Add(this.ButtonNegativeSum);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.ButtonInputArray);
            this.Controls.Add(this.TextBoxArrayCount);
            this.Controls.Add(this.ArrayCountLabel);
            this.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(942, 635);
            this.Name = "Form1";
            this.Text = "Array";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArraySorted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArrayDeletedNegativeElements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArrayCountLabel;
        private System.Windows.Forms.TextBox TextBoxArrayCount;
        private System.Windows.Forms.Button ButtonInputArray;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.Button ButtonNegativeSum;
        private System.Windows.Forms.Label labelNegativeSumResult;
        private System.Windows.Forms.Button ButtonMaxElement;
        private System.Windows.Forms.Button ButtonMaxElementIndex;
        private System.Windows.Forms.Button ButtonMaxAbsElement;
        private System.Windows.Forms.Label labelMaxElement;
        private System.Windows.Forms.Label labelMaxElementIndex;
        private System.Windows.Forms.Label labelMaxAbsElement;
        private System.Windows.Forms.Button buttonSumOfPositiveIndexes;
        private System.Windows.Forms.Label labelSumOfPositiveIndexes;
        private System.Windows.Forms.Button buttonIntegerAmount;
        private System.Windows.Forms.Label labelIntegerAmount;
        private System.Windows.Forms.Button ReverseSort;
        private System.Windows.Forms.DataGridView dataGridArraySorted;
        private System.Windows.Forms.Button buttonDeleteNegativeElements;
        private System.Windows.Forms.DataGridView dataGridArrayDeletedNegativeElements;
    }
}

