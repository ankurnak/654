using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace ExpressionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetDesign();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string expression = expressionTextBox.Text;
            try
            {
                double result = ExpressionCalculator.Calculate(expression);
                resultLabel.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid expression: " + ex.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            expressionTextBox.Text += "+";
        }

        private void substract_Click(object sender, EventArgs e)
        {
            expressionTextBox.Text += "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            expressionTextBox.Text += "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            expressionTextBox.Text += "/";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            expressionTextBox.Text = "";
            resultLabel.Text = "";
        }

        private void img_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    string expression = ReadExpressionFromImage(imagePath);
                    expressionTextBox.Text = expression;

                    try
                    {
                        double result = ExpressionCalculator.Calculate(expression);
                        resultLabel.Text = result.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid expression: " + ex.Message);
                    }
                }
            }
        }

        private void txt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string expression = ReadExpressionFromFile(filePath);
                    expressionTextBox.Text = expression;

                    try
                    {
                        double result = ExpressionCalculator.Calculate(expression);
                        resultLabel.Text = result.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid expression: " + ex.Message);
                    }
                }
            }
        }

        private string ReadExpressionFromImage(string imagePath)
        {
            using (var engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default))
            {
                using (var image = new Bitmap(imagePath))
                {
                    using (var page = engine.Process(image, PageSegMode.Auto))
                    {
                        return page.GetText().Trim();
                    }
                }
            }
        }

        private string ReadExpressionFromFile(string filePath)
        {
            return File.ReadAllText(filePath).Trim();
        }

        private void SetDesign()
        {
          
            expressionTextBox.BackColor = Color.White;
            expressionTextBox.Font = new Font("Arial", 12, FontStyle.Regular);

            resultLabel.BackColor = Color.White;
            resultLabel.Font = new Font("Arial", 12, FontStyle.Bold);

        
            Calculate.BackColor = Color.FromArgb(0, 123, 255); 
            Calculate.ForeColor = Color.White;
            Calculate.Font = new Font("Arial", 12, FontStyle.Bold);

            add.BackColor = Color.FromArgb(0, 123, 255); 
            add.ForeColor = Color.White;
            add.Font = new Font("Arial", 12, FontStyle.Bold);

            substract.BackColor = Color.FromArgb(0, 123, 255); 
            substract.ForeColor = Color.White;
            substract.Font = new Font("Arial", 12, FontStyle.Bold);

            multiply.BackColor = Color.FromArgb(0, 123, 255); 
            multiply.ForeColor = Color.White;
            multiply.Font = new Font("Arial", 12, FontStyle.Bold);

            divide.BackColor = Color.FromArgb(0, 123, 255); 
            divide.ForeColor = Color.White;
            divide.Font = new Font("Arial", 12, FontStyle.Bold);

            clear.BackColor = Color.FromArgb(255, 61, 61); 
            clear.ForeColor = Color.White;
            clear.Font = new Font("Arial", 12, FontStyle.Bold);

            img.BackColor = Color.FromArgb(76, 175, 80); 
            img.ForeColor = Color.White;
            img.Font = new Font("Arial", 12, FontStyle.Bold);

            txt.BackColor = Color.FromArgb(76, 175, 80); 
            txt.ForeColor = Color.White;
            txt.Font = new Font("Arial", 12, FontStyle.Bold);
        }

    }
    public static class ExpressionCalculator
    {
        public static double Calculate(string expression)
        {
       
            ValidateExpression(expression);

            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        private static void ValidateExpression(string expression)
        {
           
            string validChars = "0123456789.+-*/";
            if (expression.Any(c => !validChars.Contains(c)))
            {
                throw new Exception("Invalid characters in expression");
            }

       
            string[] operators = { "+", "-", "*", "/" };
            if (expression.Split(operators, StringSplitOptions.RemoveEmptyEntries).Length == 0)
            {
                throw new Exception("No valid operators in expression");
            }


            if (!IsExpressionValid(expression))
            {
                throw new Exception("Invalid expression format");
            }
        }

        private static bool IsExpressionValid(string expression)
        {
        
            string[] operators = { "+", "-", "*", "/" };
            string[] tokens = expression.Split(operators, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length < 2)
            {
                return false;
            }

       
            for (int i = 0; i < tokens.Length - 1; i++)
            {
                if (!IsNumber(tokens[i]) || !operators.Contains(expression[expression.IndexOf(tokens[i]) + tokens[i].Length].ToString()))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsNumber(string token)
        {
            double number;
            return double.TryParse(token, out number);
        }
    }
}
