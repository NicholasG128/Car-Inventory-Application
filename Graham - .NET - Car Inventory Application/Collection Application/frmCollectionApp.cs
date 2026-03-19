using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Collection_Application
{
    public partial class frmCollectionApp : Form
    {
        // Collection
        private List<Car> collection = new List<Car>();
        private CarDatabase carDatabase;

        public frmCollectionApp()
        {
            InitializeComponent();
            // Path
            carDatabase = new CarDatabase("carsCollection.dat");
            LoadCollection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCollectionItem itemForm = new frmCollectionItem();
            if (itemForm.ShowDialog() == DialogResult.OK)
            {
                // After saving, get the new car from the child form
                Car newCar = itemForm.CurrentCar;
                if (newCar != null)
                {
                    // Add the new car
                    collection.Add(newCar);
                    MessageBox.Show("Car added successfully!");
                    // Save
                    SaveCollection();


                    lstItems.Items.Add(newCar.GetCar());
                }
            }
        }


        // Save
        private void SaveCollection()
        {
            try
            {
                carDatabase.SaveCollection(collection);
                MessageBox.Show("Collection saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving the collection: {ex.Message}");
            }
        }

        // Loads the collection
        private void LoadCollection()
        {
            try
            {
                collection = carDatabase.LoadCollection();

                foreach (var car in collection)
                {
                    lstItems.Items.Add(car.GetCar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading the collection: {ex.Message}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Save
                carDatabase.SaveCollection(collection);
                // Notify the user that saved
                MessageBox.Show("Collection saved successfully!");
            }
            catch (Exception ex)
            {
                // Show saving errors
                MessageBox.Show($"Error saving the collection: {ex.Message}");
            }

        }
            private void btnOpen_Click_1(object sender, EventArgs e)
            {
                try
                {
                    // Load the collection
                    collection = carDatabase.LoadCollection();

                    // Clear
                    lstItems.Items.Clear();

                    foreach (Car car in collection)
                    {
                        // Get cars to list
                        lstItems.Items.Add(car.GetCar());
                    }

                    MessageBox.Show("Collection loaded successfully!");
                }
                catch (Exception ex)
                {
                    // Shows error
                    MessageBox.Show($"Error loading the collection: {ex.Message}");
                }
            }
        

            private void btnEdit_Click(object sender, EventArgs e)
            {
                // Ensure an item is selected
                if (lstItems.SelectedItem == null)
                {
                    MessageBox.Show("Please select a car to edit.");
                    return;
                }

                // Get the selected car
                string selectedCarSummary = lstItems.SelectedItem.ToString();
                Car selectedCar = collection.FirstOrDefault(car => car.GetCar() == selectedCarSummary);

                if (selectedCar != null)
                {
                    // Open the form to edit the selected car
                    frmCollectionItem itemForm = new frmCollectionItem();
                    // Pre-fill the form with the selected car
                    itemForm.InitializeFormForEdit(selectedCar);

                    // Show the form
                    if (itemForm.ShowDialog() == DialogResult.OK)
                    {
                        // After saving, update the collection and refresh the display
                        MessageBox.Show("Car updated successfully!");

                        // Update the list box to show the updated car
                        lstItems.Items.Clear();
                        foreach (Car car in collection)
                        {
                            // Add each car’s updated summary to the list
                            lstItems.Items.Add(car.GetCar());
                        }
                        // Save
                        SaveCollection();
                    }
                }
                else
                {
                    MessageBox.Show("Could not find the selected car to edit.");
                }
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                // Ensure an item is selected
                if (lstItems.SelectedItem == null)
                {
                    MessageBox.Show("Please select a car to delete.");
                    return;
                }

                // Get the selected car
                string selectedCarSummary = lstItems.SelectedItem.ToString();
                Car selectedCar = collection.FirstOrDefault(car => car.GetCar() == selectedCarSummary);

                if (selectedCar != null)
                {
                    // Confirm 
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this car?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Remove the car from the collection
                        collection.Remove(selectedCar);

                        lstItems.Items.Remove(selectedCarSummary);

                        // Notify 
                        MessageBox.Show("Car deleted successfully!");

                        // Save
                        SaveCollection();
                    }
                }
                else
                {
                    MessageBox.Show("Could not find the selected car to delete.");
                }
            }
        }
    }


