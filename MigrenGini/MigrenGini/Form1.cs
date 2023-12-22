using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrenGini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            headache.Items.Add("Yes");
            headache.Items.Add("No");

            bloodType.Items.Add("A Rh+");
            bloodType.Items.Add("B Rh+");
            bloodType.Items.Add("AB Rh+");
            bloodType.Items.Add("0 Rh+");
            bloodType.Items.Add("A Rh-");
            bloodType.Items.Add("B Rh-");
            bloodType.Items.Add("AB Rh-");
            bloodType.Items.Add("0 Rh-");

            hour472.Items.Add("Yes");
            hour472.Items.Add("No");
            hour472.Items.Add("?");

            min5Attack.Items.Add("Yes");
            min5Attack.Items.Add("No");

            unilateral.Items.Add("Yes");
            unilateral.Items.Add("No");

            cigarette.Items.Add("Yes");
            cigarette.Items.Add("No");

            relativeHeadache.Items.Add("Yes");
            relativeHeadache.Items.Add("No");

            alcohol.Items.Add("Yes");
            alcohol.Items.Add("No");

            gender.Items.Add("Female");
            gender.Items.Add("Male");

            pulsative.Items.Add("Yes");
            pulsative.Items.Add("No");

            increaseInMovement.Items.Add("Yes");
            increaseInMovement.Items.Add("No");

            moderateorSevere.Items.Add("Yes");
            moderateorSevere.Items.Add("No");

            photophobiaorPhonophobia.Items.Add("Yes");
            photophobiaorPhonophobia.Items.Add("No");

        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (headache.SelectedItem.ToString() == "No")
			{
				label2.Text = "%100 Nothing";
			}
			else
			{
				if (bloodType.SelectedItem.ToString() == "0 Rh+")
				{
					if (hour472.SelectedItem.ToString() == "?")
					{
						label2.Text = "%100 Nothing";
					}
					else if (hour472.SelectedItem.ToString() == "No")
					{
						if (Convert.ToInt32(computerUsage.Text) > 3)
						{
							if (min5Attack.SelectedItem.ToString() == "No")
							{
								if (unilateral.SelectedItem.ToString() == "No")
								{
									if (cigarette.SelectedItem.ToString() == "No")
									{
										label2.Text = "%66 Migraine %33 Probable";
									}
									else
									{
										label2.Text = "%100 Probable";
									}
								}
								else
								{
									label2.Text = "%100 Probable";
								}
							}
							else
							{
								if (relativeHeadache.SelectedItem.ToString() == "No")
								{
									label2.Text = "%100 Probable";
								}
								else
								{
									label2.Text = "%100 Nothing";
								}
							}

						}
						else if (Convert.ToInt32(computerUsage.Text) < 4)
						{
							if (relativeHeadache.SelectedItem.ToString() == "No")
							{
								if (alcohol.SelectedItem.ToString() == "No")
								{
									label2.Text = "%87 Nothing %13 Probable";
								}
								else
								{
									label2.Text = "%66 Migraine %33 Nothing";
								}
							}
							else
							{
								if (Convert.ToInt32(height.Text) <= 174)
								{
									if (min5Attack.SelectedItem.ToString() == "No")
									{
										label2.Text = "%16 Probable %66 Nothing %16 Migraine";
									}
									else
									{
										label2.Text = "%100 Probable";
									}
								}
								else
								{
									label2.Text = "%100 Probable";
								}
							}
						}
					}
					else if (hour472.SelectedItem.ToString() == "Yes")
					{
						if (gender.SelectedItem.ToString() == "Female")
						{
							if (alcohol.SelectedItem.ToString() == "No")
							{
								label2.Text = "%100 Nothing";
							}
							else
							{
								label2.Text = "%50 Probable %50 Nothing";
							}
						}
						else
						{
							if (pulsative.SelectedItem.ToString() == "No")
							{
								if (increaseInMovement.SelectedItem.ToString() == "No")
								{
									label2.Text = "%100 Nothing";
								}
								else
								{
									label2.Text = "%33 Nothing %66 Migraine";
								}
							}
							else
							{
								label2.Text = "%100 Migraine";
							}
						}
					}
				}
				else if (bloodType.SelectedItem.ToString() == "?")
				{
					if (Convert.ToInt32(weight.Text) <= 84)
					{
						if (Convert.ToInt32(computerUsage.Text) <= 3)
						{
							if (Convert.ToInt32(age.Text) <= 21)
							{
								if (alcohol.SelectedItem.ToString() == "No")
								{
									if (Convert.ToInt32(weight.Text) <= 74)
									{
										label2.Text = "%22 Probable %70 Nothing %7 Migraine";
									}
									else
									{
										label2.Text = "%100 Migraine";
									}
								}
								else
								{
									if (increaseInMovement.SelectedItem.ToString() == "No")
									{
										label2.Text = "%100 Nothing";
									}
									else
									{
										label2.Text = "%71 Probable %28 Nothing";
									}
								}
							}
							else
							{
								label2.Text = "%75 Probable %25 Migraine";
							}
						}
						else 
						{
							if (Convert.ToInt32(height.Text) <= 180)
							{
								if (Convert.ToInt32(age.Text) <= 19)
								{
									label2.Text = "%77 Probable %22 Migraine";
								}
								else
								{
									if (cigarette.SelectedItem.ToString() == "No")
									{
										label2.Text = "%75 Probable %25 Nothing";
									}
									else
									{
										label2.Text = "%100 Nothing";
									}
								}
							}
							else
							{
								if (alcohol.SelectedItem.ToString() == "Yes")
								{
									if (Convert.ToInt32(computerUsage.Text) <= 5)
									{
										label2.Text = "%100 Nothing";
									}
									else
									{
										label2.Text = "%66 Migraine %33 Nothing";
									}
								}
								else
								{
									label2.Text = "%100 Migraine";
								}
							}
						}
					}

                    else
                    {
						label2.Text = "%100 Probable";
					}


				}
				else if (bloodType.SelectedItem.ToString() == "A Rh+")
				{
					if (Convert.ToInt32(height.Text) <= 186)
					{
						if (Convert.ToInt32(height.Text) <= 184)
						{
							if (Convert.ToInt32(height.Text) <= 182)
							{
								if (Convert.ToInt32(computerUsage.Text) <= 5)
								{
									if (alcohol.SelectedItem.ToString() == "Yes")
									{
										label2.Text = "%17 Probable %70 Nothing %11 Migraine";
									}
									else
									{
										label2.Text = "%53 Probable %41 Nothing %4 Migraine";
									}
								}
								else
								{
									label2.Text = "%76 Probable %15 Nothing %7 Migraine";
								}
							}
							else
							{
								label2.Text = "%100 Nothing";
							}
						}
						else
						{
							if (increaseInMovement.SelectedItem.ToString() == "No")
							{
								if (moderateorSevere.SelectedItem.ToString() == "No")
								{
									label2.Text = "%100 Migraine";
								}
								else
								{
									label2.Text = "%50 Probable %50 Migraine";
								}
							}
							else
							{
								label2.Text = "%100 Probable";
							}
						}
					}
					else
					{
						if (photophobiaorPhonophobia.SelectedItem.ToString() == "No")
						{
							label2.Text = "%66 Migraine %33 Nothing";
						}
						else
						{
							label2.Text = "%100 Nothing";
						}
					}
				
				}
			
				else if (bloodType.SelectedItem.ToString() == "A Rh-")
				{
					if (pulsative.SelectedItem.ToString() == "No")
					{
						label2.Text = "%75 Nothing %25 Migraine";
					}
					else
					{
						label2.Text = "%100 Probable";
					}
				}
				else if (bloodType.SelectedItem.ToString() == "AB Rh+")
				{
					if (moderateorSevere.SelectedItem.ToString() == "No")
					{
						if (Convert.ToInt32(age.Text) <= 19)
						{
							if (Convert.ToInt32(height.Text) <= 177)
							{
								label2.Text = "%100 Probable";
							}
							else
							{
								label2.Text = "%100 Nothing";
							}
						}
						else
						{
							label2.Text = "%100 Probable";
						}
					}
					else
					{
						label2.Text = "%50 Nothing %50 Migraine";
					}
				}
				else if (bloodType.SelectedItem.ToString() == "B Rh+")
				{
					if (Convert.ToInt32(weight.Text) <= 74)
					{
						if (Convert.ToInt32(age.Text) <= 19)
						{
							if (Convert.ToInt32(weight.Text) <= 59)
							{
								if (Convert.ToInt32(computerUsage.Text) <= 3)
								{
									label2.Text = "%50 Probable %50 Migraine";
								}
								else
								{
									label2.Text = "%100 Nothing";
								}
							}
							else
							{
								if (Convert.ToInt32(height.Text) <= 179)
								{
									label2.Text = "%100 Probable";
								}
								else
								{
									label2.Text = "%66 Nothing %33 Probable";
								}
							}
						}
						else
						{
							label2.Text = "%100 Nothing";
						}
					}
					else
					{
						if (cigarette.SelectedItem.ToString() == "No")
						{
							if (alcohol.SelectedItem.ToString() == "No")
							{
								label2.Text = "%100 Nothing";
							}
							else
							{
								label2.Text = "%50 Probable %50 Migraine";
							}
						}
						else
						{
							label2.Text = "%100 Migraine";
						}
					}
				}
				else if (bloodType.SelectedItem.ToString() == "B Rh-")
				{
					label2.Text = "%66 Nothing %33 Migraine";
				}
				else
				{
					if (Convert.ToInt32(weight.Text) <= 80)
					{
						label2.Text = "%88 Probable %11 Migraine";
					}
					else
					{
						label2.Text = "%100 Nothing";
					}
				}
			}
		}

       
    }
}

		