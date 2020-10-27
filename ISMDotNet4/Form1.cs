using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArrayClassLibrary;

namespace ISMDotNet4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ArrayCountLabel_Click(object sender, EventArgs e)
        {

        }
        int count;
        private void ButtonInputArray_Click(object sender, EventArgs e)
        {
            count = int.Parse(TextBoxArrayCount.Text);
            dataGridViewArray.ColumnCount = count;
            dataGridViewArray.RowCount = 1;
            for(int i = 0; i < count; i++)
            {
                dataGridViewArray.Columns[i].HeaderCell.Value = i.ToString();
            }
        }
        
        private void labelNegativeSumResult_Click(object sender, EventArgs e)
        {

        }
        
        private void ButtonNegativeSum_Click(object sender, EventArgs e)
        {
           double[] arr = new double[count];
           for(int i = 0; i < count; i++)
               {
                double d = Convert.ToDouble(dataGridViewArray.Rows[0].Cells[i].Value);
                arr[i] = d;
               }
            labelNegativeSumResult.Text = MyArray.NegativeElementSum(arr).ToString();
            labelNegativeSumResult.AutoSize = false;
            labelNegativeSumResult.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelNegativeSumResult.Visible = true;
        }

        private void ButtonMaxElement_Click(object sender, EventArgs e)
        {
            double[] arr = new double[count];
            for (int i = 0; i < count; i++)
            {
                double d = Convert.ToDouble(dataGridViewArray.Rows[0].Cells[i].Value);
                arr[i] = d;
            }
            labelMaxElement.Text = MyArray.MaxElement(arr).ToString();
            labelMaxElement.AutoSize = false;
            labelMaxElement.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelMaxElement.Visible = true;
        }
        private void ButtonMaxElementIndex_Click(object sender, EventArgs e)
        {
            double[] arr = new double[count];
            for (int i = 0; i < count; i++)
            {
                double d = Convert.ToDouble(dataGridViewArray.Rows[0].Cells[i].Value);
                arr[i] = d;
            }
            labelMaxElementIndex.Text = MyArray.MaxElementIndex(arr).ToString();
            labelMaxElementIndex.AutoSize = false;
            labelMaxElementIndex.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelMaxElementIndex.Visible = true;
        }

        private void labelMaxElement_Click(object sender, EventArgs e)
        {

        }

        private void ButtonMaxAbsElement_Click(object sender, EventArgs e)
        {
            double[] arr = new double[count];
            for (int i = 0; i < count; i++)
            {
                double d = Convert.ToDouble(dataGridViewArray.Rows[0].Cells[i].Value);
                arr[i] = d;
            }
            labelMaxAbsElement.Text = MyArray.MaxAbsoluteElement(arr).ToString();
            labelMaxAbsElement.AutoSize = false;
            labelMaxAbsElement.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelMaxAbsElement.Visible = true;
        }

        private void labelMaxAbsElement_Click(object sender, EventArgs e)
        {

        }

        private void buttonSumOfPositiveIndexes_Click(object sender, EventArgs e)
        {
            double[] arr = new double[count];
            for (int i = 0; i < count; i++)
            {
                double d = Convert.ToDouble(dataGridViewArray.Rows[0].Cells[i].Value);
                arr[i] = d;
            }
            labelSumOfPositiveIndexes.Text = MyArray.PositiveIndexSum(arr).ToString();
            labelSumOfPositiveIndexes.AutoSize = false;
            labelSumOfPositiveIndexes.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelSumOfPositiveIndexes.Visible = true;
        }

        private void labelIntegerAmount_Click(object sender, EventArgs e)
        {

        }

        private void buttonIntegerAmount_Click(object sender, EventArgs e)
        {
            double[] arr = new double[count];
            for (int i = 0; i < count; i++)
            {
                double d = Convert.ToDouble(dataGridViewArray.Rows[0].Cells[i].Value);
                arr[i] = d;
            }
            labelIntegerAmount.Text = MyArray.IntegerCount(arr).ToString();
            labelIntegerAmount.AutoSize = false;
            labelIntegerAmount.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelIntegerAmount.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReverseSort_Click(object sender, EventArgs e)
        {
            double[] arr = new double[count];
            for (int i = 0; i < count; i++)
            {
                double d = Convert.ToDouble(dataGridViewArray.Rows[0].Cells[i].Value);
                arr[i] = d;
            }
            arr = MyArray.DescendingSort(arr);
            dataGridArraySorted.ColumnCount = arr.Length;
            dataGridArraySorted.RowCount = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                dataGridArraySorted.Rows[0].Cells[i].Value = arr[i].ToString();
                dataGridArraySorted.Columns[i].HeaderCell.Value = i.ToString();
            }
        }

        private void buttonDeleteNegativeElements_Click(object sender, EventArgs e)
        {
            double[] arr = new double[count];
            for (int i = 0; i < count; i++)
            {
                double d = Convert.ToDouble(dataGridViewArray.Rows[0].Cells[i].Value);
                arr[i] = d;
            }
            arr = MyArray.DeleteNegativeElements(arr);
            dataGridArrayDeletedNegativeElements.ColumnCount = arr.Length;
            dataGridArrayDeletedNegativeElements.RowCount = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                dataGridArrayDeletedNegativeElements.Rows[0].Cells[i].Value = arr[i].ToString();
                dataGridArrayDeletedNegativeElements.Columns[i].HeaderCell.Value = i.ToString();
            }
            
        }
    }
}
