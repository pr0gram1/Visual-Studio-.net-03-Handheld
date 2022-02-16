using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace TomislavApp
{
	
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MainMenu mainMenu2;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
	
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.mainMenu2 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			// 
			// mainMenu2
			// 
			this.mainMenu2.MenuItems.Add(this.menuItem1);
			// 
			// menuItem1
			// 
			this.menuItem1.MenuItems.Add(this.menuItem4);
			this.menuItem1.Text = "File";
			// 
			// menuItem4
			// 
			this.menuItem4.Text = "Exit";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-1256, 24);
			this.pictureBox1.Size = new System.Drawing.Size(2008, 496);
			this.pictureBox1.ParentChanged += new System.EventHandler(this.pictureBox1_ParentChanged_1);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(128, 48);
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(48, 24);
			this.label1.Size = new System.Drawing.Size(160, 20);
			this.label1.Text = "Pr0gram1HandheldTest";
			this.label1.ParentChanged += new System.EventHandler(this.label1_ParentChanged_1);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Text = "Date of Birth";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 96);
			this.label4.Text = "Company";
			this.label4.ParentChanged += new System.EventHandler(this.label4_ParentChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 120);
			this.label5.Text = "Department";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(128, 72);
			this.textBox2.Text = "";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(128, 120);
			this.textBox3.Text = "";
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(128, 96);
			this.textBox4.Text = "";
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 152);
			this.button1.Text = "Submit";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(128, 152);
			this.listBox1.Size = new System.Drawing.Size(100, 100);
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(16, 176);
			this.button2.Text = "Remove";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(16, 200);
			this.button3.Text = "Clear";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(314, 510);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox1);
			this.Menu = this.mainMenu2;
			this.Text = "Form1";

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void label1_ParentChanged(object sender, System.EventArgs e)
		{
			
		}

		private void pictureBox1_ParentChanged(object sender, System.EventArgs e)
		{
		
		}

		private void label1_ParentChanged_1(object sender, System.EventArgs e)
		{
		
		}

		private void label4_ParentChanged(object sender, System.EventArgs e)
		{
		
		}

		private void textBox6_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void textBox4_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void textBox3_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			listBox1.Items.Add(textBox1.Text);
			listBox1.Items.Add(textBox2.Text);
			listBox1.Items.Add(textBox4.Text);
			listBox1.Items.Add(textBox3.Text);

			textBox1.Text="";
			textBox1.Focus();
		
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (listBox1.SelectedIndex != 1)
			{
				listBox1.Items.RemoveAt(listBox1.SelectedIndex);
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			listBox1.Items.Clear();
		}

		private void pictureBox1_ParentChanged_1(object sender, System.EventArgs e)
		{
		
		}
	}
}
