using System;
using System.Windows.Forms;

namespace Collection_Application
{
    public partial class frmCollectionItem : Form
    {
        // New car
        public Car CurrentCar { get; set; }

        public frmCollectionItem()
        {
            InitializeComponent();
        }

        // Initialize
        private void InitializeForm()
        {
            txtName.Clear();
            txtDescription.Clear();
            // Default to current date
            dtpDate.Value = DateTime.Now;
            txtCustom.Clear();
        }

        // Initialize the form
        public void InitializeFormForEdit(Car car)
        {
            txtName.Text = car.Name;
            txtDescription.Text = car.Description;
            dtpDate.Value = car.DateAcquired;
            txtCustom.Text = car.CustomField;
            CurrentCar = car;
        }

        // Validate the form
        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter the car name.");
                return false;
            }


            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Create a new car or update the existing one
                if (CurrentCar == null)
                {
   
                    CurrentCar = new Car(txtName.Text, txtDescription.Text, dtpDate.Value, txtCustom.Text);
                }
                else
                {
                    CurrentCar.Name = txtName.Text;
                    CurrentCar.Description = txtDescription.Text;
                    CurrentCar.DateAcquired = dtpDate.Value; 
                    CurrentCar.CustomField = txtCustom.Text;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
