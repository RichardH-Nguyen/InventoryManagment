using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SortedList<string, decimal> foodList = new SortedList<string, decimal>
            { ["Lunch Meat"] = 7, ["Bread"] = 6, ["Oranges"] = 12, ["Carrots"] = 4, ["Twinkies"] = 40 };

        SortedList<string, decimal> weaponList = new SortedList<string, decimal>
            { ["Steak Knife"] = 4, ["Shotgun"] = 2, ["Hand Grenade"] = 20, ["Laser Gun"] = 2 };

        SortedList<string, decimal> firstaidList = new SortedList<string, decimal>
            { ["Bandage"] = 10, ["Rubbing Alchohol"] = 4, ["Hand Sanitizer"] = 2, ["Gauze"] = 5 };

        string aidString = "";
        string foodString = "";
        string weaponString = "";
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList(firstaidList);
        }
        private void UpdateList(SortedList<string, decimal> list)
        {
            listBox1.Items.Clear();
            foreach (KeyValuePair<string, decimal> item in list)
            {
                listBox1.Items.Add(item.Key);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string listItem = listBox1.GetItemText(listBox1.SelectedItem);
            decimal value = nudAmount.Value;
            subtract(value, listItem, foodList);
            subtract(value, listItem, weaponList);
            subtract(value, listItem, firstaidList);
            nudAmount.Value = 0;
        }

        private void rdoFood_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList(foodList);
        }

        private void rdoWeapons_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList(weaponList);
        }

        private string MasterList(SortedList<string,decimal> list, string name)
        {
            name = "";
            foreach (KeyValuePair<string, decimal> item in list)
            {
                name += item.Key + "\t" + item.Value + "\n";
            }
            return name;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           foodString = MasterList(foodList, foodString);
           aidString =  MasterList(firstaidList, aidString);
           weaponString =  MasterList(weaponList, weaponString);
            string bigList = "Food:\n" + foodString + "\n"+"First Aid:\n"+ aidString + "\n"+ "Weapons:\n" + weaponString;
            MessageBox.Show(bigList,"Master List");
        }
        private bool subtract(decimal value,string item, SortedList<string, decimal> list)
        {
            if (list.ContainsKey(item))
            {
                int itemIndex = list.IndexOfKey(item);
                list[item] -= value;
                return true;
            }
            else
                return false;
                
        }

        private bool AddValue(decimal value, string item, SortedList<string, decimal> list)
        {
            if (list.ContainsKey(item))
            {
                int itemIndex = list.IndexOfKey(item);
                list[item] += value;
                return true;
            }
            else
                return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string listItem = listBox1.GetItemText(listBox1.SelectedItem);
            decimal value = nudAmount.Value;
            AddValue(value, listItem, foodList);
            AddValue(value, listItem, weaponList);
            AddValue(value, listItem, firstaidList);
            nudAmount.Value = 0;
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to add this item to the selected catagory?";
            DialogResult button = MessageBox.Show(message, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (button == DialogResult.Yes)
            {
                if (rdoFood.Checked)
                {
                    foodList.Add(txtAddItem.Text, 0);
                    UpdateList(foodList);
                }
                else if (rdoWeapons.Checked)
                {
                    weaponList.Add(txtAddItem.Text, 0);
                    UpdateList(weaponList);
                }
                else if (radioButton3.Checked)
                {
                    firstaidList.Add(txtAddItem.Text, 0);
                    UpdateList(firstaidList);
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
