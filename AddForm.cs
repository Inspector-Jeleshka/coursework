using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
	public partial class AddForm : Form
	{
		private TextBox[] textBoxes;

		public AddForm(int textBoxAmount, string[] textBoxLabels) : this(textBoxAmount, textBoxLabels, new string[textBoxAmount])
		{ }
		public AddForm(int textBoxAmount, string[] textBoxLabels, string[] initialValues)
		{
			InitializeComponent();

			Point startPoint = new(30, 40);
			Size textBoxSize = new(200, 23);
			Label[] labels = new Label[textBoxAmount];
			textBoxes = new TextBox[textBoxAmount];
			for (int i = 0; i < textBoxAmount; i++)
			{
				labels[i] = new();
				textBoxes[i] = new();
				labels[i].Location = new(startPoint.X, startPoint.Y + i * 50);
				textBoxes[i].Location = new(startPoint.X, startPoint.Y + 20 + i * 50);
				labels[i].AutoSize = true;
				textBoxes[i].Size = new(textBoxSize.Width, textBoxSize.Height);
				labels[i].Text = textBoxLabels[i];
				textBoxes[i].Text = initialValues[i];
				Controls.Add(labels[i]);
				Controls.Add(textBoxes[i]);
			}
		}

		public List<string> Result { get; private set; }

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void confirmButton_Click(object sender, EventArgs e)
		{
			Result = new();
			foreach (var textBox in textBoxes)
			{
				if (string.IsNullOrEmpty(textBox.Text))
				{
					MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
					return;
				}

				Result.Add(textBox.Text);
			}

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
