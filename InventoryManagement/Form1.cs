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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (KeyValuePair<string, decimal> item in firstaidList)
            {
                listBox1.Items.Add(item.Key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rdoFood_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (KeyValuePair<string, decimal> food in foodList)
            {
                listBox1.Items.Add(food.Key);
            }
        }

        private void rdoWeapons_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (KeyValuePair<string, decimal> weapon in weaponList)
            {
                listBox1.Items.Add(weapon.Key);
            }
        }

       // private string MasterList(string list, string name)
       // {
          //  string newString = "";
          //  foreach (KeyValuePair<string, decimal> finalList in list)
           // {
                //newString += finalList.Key + "\t" + finalList.Value + "\n";
           // }
           
      //  }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            string foodString = "";
            string aidString = "";
            string weaponString = "";
            foreach (KeyValuePair<string, decimal> item in foodList)
            {
                foodString +=item.Key + "\t" + item.Value + "\n";
            }
            foreach (KeyValuePair<string, decimal> item in firstaidList)
            {
                aidString += item.Key + "\t" + item.Value + "\n";
            }
            foreach (KeyValuePair<string, decimal> item in weaponList)
            {
                weaponString +=item.Key + "\t" + item.Value + "\n";
            }
            string bigList = "Food:\n" + foodString + "\n"+"First Aid:\n"+ aidString + "\n"+ "Weapons:\n" + weaponString;
            MessageBox.Show(bigList,"Master List");
        }
    }
}
