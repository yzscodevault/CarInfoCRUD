using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6._2
{
    public partial class Form1 : Form
    {
        CarRecords carRecords;
        public Form1()
        {
            InitializeComponent();
        }

        public void ClearAll()
        {
            txbxCarVIN.Clear();
            txbxCarMake.Clear();
            txbxCarModel.Clear();
            txbxCarYear.Clear();
            txbxCarPrice.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            carRecords = new CarRecords();
            dataGridCars.DataSource = carRecords.GetCars();
            btnCarSubmitRecord.Enabled = false;
            btnCarUpdateRecord.Enabled = false;
        }

        private void btnCarAddRecord_Click(object sender, EventArgs e)
        {
                btnCarSubmitRecord.Enabled = true;            
        }

        private void btnCarSubmitRecord_Click(object sender, EventArgs e)
        {
            short carYear = Convert.ToInt16(txbxCarYear.Text);
            short currentYear = Convert.ToInt16(DateTime.Today.Year);
            if (!string.IsNullOrWhiteSpace(txbxCarMake.Text) && !string.IsNullOrWhiteSpace(txbxCarModel.Text) &&
                !string.IsNullOrWhiteSpace(txbxCarVIN.Text) && (carYear >= 1885 && carYear <= currentYear))
            {
                var newrecords = new Car();
                newrecords.VIN = txbxCarVIN.Text;
                newrecords.Make = txbxCarMake.Text;
                newrecords.Model = txbxCarModel.Text;
                newrecords.Year = Convert.ToInt16(txbxCarYear.Text);
                newrecords.Price = Convert.ToDecimal(txbxCarPrice.Text);
                carRecords.AddRecord(newrecords);
            }
            else
            {
                MessageBox.Show("Need Valid Information on All fields with price as optional");
            }
            ClearAll();
            btnCarSubmitRecord.Enabled = false;
        }

        private void btnCarSelectToUpdate_Click(object sender, EventArgs e)
        {
            var selectedvin = dataGridCars.CurrentRow.Cells[0].Value;
            var foundcar = carRecords.FindACar(Convert.ToString(selectedvin));
            txbxCarVIN.ReadOnly = true;
            txbxCarVIN.Text = Convert.ToString(selectedvin);
            txbxCarMake.Text = foundcar.Make.ToString();
            txbxCarModel.Text = foundcar.Model.ToString();
            txbxCarYear.Text = foundcar.Year.ToString();
            txbxCarPrice.Text = foundcar.Price.ToString();
            btnCarUpdateRecord.Enabled = true;
        }

        private void btnCarUpdateRecord_Click(object sender, EventArgs e)
        {
            string vin = txbxCarVIN.Text;
            var cartoupdate = carRecords.FindACar(vin);
            cartoupdate.Make = txbxCarMake.Text;
            cartoupdate.Model = txbxCarModel.Text;
            cartoupdate.Year = Convert.ToInt16(txbxCarYear.Text);
            cartoupdate.Price = Convert.ToDecimal(txbxCarPrice.Text);
            carRecords.UpdateRecord(vin, cartoupdate);
            ClearAll();
            btnCarUpdateRecord.Enabled = false;
        }

        private void btnCarDeleteRecord_Click(object sender, EventArgs e)
        {
            string vin = Convert.ToString(dataGridCars.CurrentRow.Cells[0].Value);
            carRecords.DeleteRecord(carRecords.FindACar(vin));
            MessageBox.Show("Car record is deleted");
            dataGridCars.DataSource = null;
            dataGridCars.DataSource = carRecords.GetCars();
        }

        private void btnCarRefreshRecord_Click(object sender, EventArgs e)
        {
            dataGridCars.DataSource = null;
            dataGridCars.DataSource = carRecords.GetCars();
            ClearAll();
        }
    }
}
