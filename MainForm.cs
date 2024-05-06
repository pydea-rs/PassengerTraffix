using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;

namespace PassengerTraffix
{
    public partial class MainForm : Form
    {
        private PersianDateTime expireDate = PersianDateTime.Now.AddMonths(1);
        private List<Passenger> passengers;
        private Passenger selectedPassenegr = null;
        const string VALIDATION_FILE = "./val.exp";
 
        public static PersianDateTime NextDeadLine(int delta = 1) {
            return PersianDateTime.Now.AddMonths(delta);
        }

        public void RegisterNextDeadLine(PersianDateTime deadline)
        {
            try
            {
                this.expireDate = deadline;
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(VALIDATION_FILE))
                {
                    sw.Write(deadline.ToStringFormat(SQLiteInterface.DATE_FORMAT));
                }
            }
            catch(Exception ex)
            {
                MessageBoxFarsi.Show("مشکلی در ثبت تاریخ پیش آمد!", ex.Message);
            }
        }
        public MainForm()
        {
            InitializeComponent();
            this.passengers = new List<Passenger>();

            /*try
            {
                // read expiration date:
                string date = System.IO.File.ReadAllText(VALIDATION_FILE);
                this.expireDate = PersianDateTime.Parse(date, SQLiteInterface.DATE_FORMAT);
                Console.WriteLine(this.expireDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                RegisterNextDeadLine(NextDeadLine());
            }*/
        }

        private SurveillanceForm frmSurveillance;
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnSubmit;
            this.Text = "Created By thcpp@fsociety";
            cbTargetUnit.DropDownHeight = cbTargetUnit.ItemHeight * 20;
            cbTargetUnit.DropDownHeight = cbPassengers.ItemHeight * 15;
        }

        private void numericTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static bool IsNumberInputValid(string numericInput, byte samenessCriterion)
        {
            bool idioticAscending = true, idioticDescending = true;
            byte sameChars = 0;
            for (byte j = 0; j < numericInput.Length - 1; j++)
            {
                if (numericInput[j] < '0' || numericInput[j] > '9')
                    throw new InvalidInputException("کدملی", "فقط شامل ارقام انگلیسی");

                sameChars += (byte)(numericInput[j] == numericInput[j + 1] ? 1 : 0);
                if (numericInput[j] != numericInput[j + 1] && numericInput[j] != numericInput[j + 1] + 1)
                    idioticAscending = false;
                if (numericInput[j] != numericInput[j + 1] && numericInput[j] != numericInput[j + 1] - 1)
                    idioticDescending = false;

            }

            return numericInput[numericInput.Length - 1] >= '0' && numericInput[numericInput.Length - 1] <= '9' &&
                sameChars < samenessCriterion && !idioticAscending && !idioticDescending;
        }

        public static bool IsPhonenumberPrefixValid(string prefix)
        {
            string[] acceptablePrefixes = { "911", "921", "912", "901", "902", "936", "935", "937", "938", "939", "903", "930", "931", "933", "920", "921", "922", "990", "991", "992", "996", "905", "13", "21"};
            for (byte i = 0; i < acceptablePrefixes.Length; i++)
                if (acceptablePrefixes[i] == prefix)
                    return true;
            return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //if (PersianDateTime.Now.CompareTo(this.expireDate) >= 0)
                //    return;
                string targetUnit = cbTargetUnit.SelectedIndex >= 0 ? cbTargetUnit.SelectedItem.ToString().Trim() : null,
                    firstname = TraffixTools.RemoveWhiteSpaces(txtFirstName.Text),
                    lastname = TraffixTools.RemoveWhiteSpaces(txtLastName.Text),
                    nationalID = txtNationalID.Text.Trim(),
                    phonenumber = txtPhonenumber.Text.Trim(),
                    vehicleModel = TraffixTools.RemoveWhiteSpaces(txtVehicleModel.Text);

                short closetNumber = 0;

                Plate plate = null;
                string emptyFields = "";
                if (firstname == "")
                    emptyFields += "نام\n";
                if (lastname == "")
                    emptyFields += "نام خانوادگی\n";
                if (nationalID == "")
                    emptyFields += "کد ملی\n";
                if (targetUnit == null)
                    emptyFields += "واحد مراجعه\n";
                if (phonenumber == "")
                    emptyFields += "شماره تلفن\n";

                if (checkHasARide.Checked)
                {
                    if (vehicleModel == "")
                        emptyFields += "مدل خودرو\n";
                    string platePart1 = txtPlate1stSection.Text.Trim(),
                        platePart2 = txtPlate2ndSection.Text.Trim(),
                        plateLetter = txtPlateLetter.Text.Trim(),
                        iranID = txtPlateIranID.Text.Trim();

                    if (platePart1 == "" || platePart2 == "" || iranID == "" || plateLetter == "")
                        emptyFields += "پلاک خودرو\n";
                    else
                        plate = new Plate(short.Parse(platePart1), plateLetter, short.Parse(platePart2), short.Parse(iranID));
                }
                if (emptyFields != "")
                    throw new FillRequiredFieldsException(emptyFields);

                // nationalID check:
                if (nationalID.Length < 10)
                    throw new InvalidInputException("کدملی", "10 رقمی");
                if(!IsNumberInputValid(nationalID, 7))
                    throw new InvalidInputException("کدملی", "معتبر");

                // phoneNumber check:
                if (phonenumber.Length < 11)
                    throw new InvalidInputException("شماره تلفن", "11 رقمی");
                if (phonenumber[0] != '0' || !IsNumberInputValid(phonenumber, 8))
                    throw new InvalidInputException("شماره تلفن", "معتبر");
                if (!IsPhonenumberPrefixValid(phonenumber.Substring(1, phonenumber[1] == '9' ? 3 : 2))) // cut the prefix part of the phone number, length 3 for mobile numbers and 2 for home telephone numbers.
                    throw new InvalidInputException("شماره تلفن", "پیش شماره معتبر داشته");

                try
                {
                    string num = txtClosetNumber.Text.Trim();
                    if(num != "" && num.Length > 0)
                        closetNumber = short.Parse(txtClosetNumber.Text.Trim());
                }
                catch
                {
                    throw new InvalidInputException("شماره کمد", "عدد");
                }

                Passenger passenger;
                if (this.selectedPassenegr == null)
                {

                    passenger = new Passenger(firstname, lastname, nationalID, phonenumber, targetUnit, closetNumber,
                        vehicleModel, plate, PersianDateTime.Now, (short)DateTime.Now.Hour, (short)DateTime.Now.Minute, this.checkIsEntering.Checked);
                }
                else
                {
                    selectedPassenegr.Firstname = firstname;
                    selectedPassenegr.Lastname = lastname;
                    selectedPassenegr.NationalID = nationalID;
                    selectedPassenegr.Phonenumber = phonenumber;
                    selectedPassenegr.TargetUnit = targetUnit;
                    selectedPassenegr.ClosetNumber = closetNumber;
                    selectedPassenegr.VehicleModel = vehicleModel;
                    selectedPassenegr.Plate = plate;
                    selectedPassenegr.Entering = this.checkIsEntering.Checked;
                    selectedPassenegr.Date = PersianDateTime.Now;
                    selectedPassenegr.Time = new TimeSpan((short)DateTime.Now.Hour, (short)DateTime.Now.Minute, 0);
                    passenger = selectedPassenegr;
                }

                bool done = SQLiteInterface.Database.Update(passenger);
                if (!done)
                    throw new Exception("مشکلی غیر منتظره حین ذخیره اطلاعات پیش آمد.");
                MessageBoxFarsi.Show(passenger.ToString() + " ثبت شد.", "Okey Dokey");
                this.ClearForm();
                cbTargetUnit.SelectedIndex = -1;
                cbPassengers.DataSource = null;
                if (selectedPassenegr == null)
                {
                    int i = 0;
                    for (i = 0; i < this.passengers.Count; i++)
                    {
                        if (this.passengers[i].NationalID == passenger.NationalID)
                        {
                            this.passengers[i] = passenger;
                            break;
                        }
                    }
                    if (i >= this.passengers.Count) // if its a new person
                        this.passengers.Add(passenger);
                    else // if there is old traffix, its no use then, replace the passenger object with new traffix
                        this.passengers[i] = passenger;
                }
                else
                {
                    this.selectedPassenegr = null;
                }

                cbPassengers.DataSource = this.passengers;
                cbPassengers.DisplayMember = "FullName";
                cbPassengers.SelectedIndex = -1;
            }
            catch (DatabaseOutOfReachException dox)
            {
                MessageBoxFarsi.Show(dox.Message, "خطای در اتصال به پایگاه داده", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
            catch (FillRequiredFieldsException frx)
            {
                MessageBoxFarsi.Show(frx.Message, "هشدار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }

        }

        private void ClearForm()
        {
            txtPlate1stSection.Text = txtPlate2ndSection.Text = txtPlateIranID.Text = txtPlateLetter.Text =
                txtPlateIranID.Text = txtNationalID.Text = txtVehicleModel.Text = txtVehicleModel.Text =
                txtPhonenumber.Text = txtFirstName.Text = txtLastName.Text = this.txtClosetNumber.Text = "";
            cbTargetUnit.Text = "";
            checkHasARide.Checked = false;
            checkIsEntering.Checked = true;
            this.selectedPassenegr = null;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            // check are you sure?
            this.Close();
        }

        private void mnuSurveillanceMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //if (PersianDateTime.Now.CompareTo(this.expireDate) >= 0)
                //    return;
                if (this.frmSurveillance == null)
                {
                    string password = Microsoft.VisualBasic.Interaction.InputBox("رمز عبور را وارد کنید:", "رمز عبور");
                    if (password != "110110")
                        throw new WrongCredentialsException();
                    //ask for admin passowrd
                    this.frmSurveillance = new SurveillanceForm(this);
                    this.frmSurveillance.Show();
                }
            }
            catch(WrongCredentialsException ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBoxFarsi.Show("یک خطای نامشخص اتفاق افتاده است. لطفا متن خطای انگلیسی را به واحد فاوا گزارش دهید:\n" + ex.Message, "خطای نامشخص",
                    MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
        }

        public void CloseSurveillanceForm()
        {
            this.frmSurveillance = null;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.frmSurveillance != null)
                this.frmSurveillance.Close();
        }

        private void txtPlateLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == ' ';
        }

        private void txtNationalID_TextChanged(object sender, EventArgs e)
        {
            if (txtNationalID.Text.Length >= 10)
                txtPhonenumber.Focus();
        }

        private void txtPlate1stSection_TextChanged(object sender, EventArgs e)
        {
            if (txtPlate1stSection.Text.Length >= 2)
                txtPlateLetter.Focus();
        }

        private void txtPlate2ndSection_TextChanged(object sender, EventArgs e)
        {
            if(txtPlate2ndSection.Text.Length >= 3)
                txtPlateIranID.Focus();
        }

        private void txtPlateIranID_TextChanged(object sender, EventArgs e)
        {
            if (txtPlateIranID.Text.Length >= 2)
                checkIsEntering.Focus();
        }

        private void checkHasARide_CheckedChanged(object sender, EventArgs e)
        {
            txtVehicleModel.Enabled = txtPlate1stSection.Enabled = txtPlate2ndSection.Enabled =
                txtPlateIranID.Enabled = txtPlateLetter.Enabled = checkHasARide.Checked;
            if (checkHasARide.Checked)
            {
                checkHasARide.BackColor = Color.Lime;
                checkHasARide.Text = "سواره";
                txtPlate1stSection.BackColor = txtPlate2ndSection.BackColor =
                txtVehicleModel.BackColor = txtPlateIranID.BackColor = txtPlateLetter.BackColor = Color.White;
            }
            else
            {
                checkHasARide.BackColor = Color.White;
                checkHasARide.Text = "پیاده";
                txtPlate1stSection.BackColor = txtPlate2ndSection.BackColor =
                txtVehicleModel.BackColor = txtPlateIranID.BackColor = txtPlateLetter.BackColor = Color.Silver;
            }
            txtVehicleModel.Text = txtPlate1stSection.Text = txtPlate2ndSection.Text =
                txtPlateIranID.Text = txtPlateLetter.Text = "";
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            this.Text = "                                                                                                          " +
                PersianDateTime.Now.ToLongDateString() + " " + PersianDateTime.Now.ToLongTimeString();
        }

        private void checkIsEntering_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsEntering.Checked)
            {
                checkIsEntering.BackColor = Color.SpringGreen;
                checkIsEntering.Text = "ورود";
            }
            else
            {
                checkIsEntering.BackColor = Color.Coral;
                checkIsEntering.Text = "خروج";
            }
        }

        private void txtPhonenumber_TextChanged(object sender, EventArgs e)
        {
            if (txtPhonenumber.Text.Length >= 11)
                cbTargetUnit.Focus();
        }

        private void cbPassengers_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (cbPassengers.SelectedIndex >= 0 && cbPassengers.SelectedIndex <= cbPassengers.Items.Count)
                {
                    this.ClearForm();
                    this.selectedPassenegr = cbPassengers.SelectedItem as Passenger;
                    LoadPassenger(this.selectedPassenegr);
                    
                }
            }
        }

        private void LoadPassenger(Passenger passenger)
        {
            txtFirstName.Text = passenger.Firstname;
            txtLastName.Text = passenger.Lastname;
            txtClosetNumber.Text = passenger.ClosetNumber.ToString();
            txtNationalID.Text = passenger.NationalID;
            txtPhonenumber.Text = passenger.Phonenumber;
            cbTargetUnit.SelectedItem = passenger.TargetUnit;
            txtClosetNumber.Text = passenger.ClosetNumber > 0 ? passenger.ClosetNumber.ToString() : "";
            if (passenger.VehicleModel.Trim() != "")
            {
                checkHasARide.Checked = true;
                txtVehicleModel.Text = passenger.VehicleModel;
                txtPlate1stSection.Text = passenger.Plate.FirstSection.ToString();
                txtPlate2ndSection.Text = passenger.Plate.SecondSection.ToString();
                txtPlateLetter.Text = passenger.Plate.Letter;
                txtPlateIranID.Text = passenger.Plate.IranID.ToString();
            }
        }

        private void mnuClearForm_Click(object sender, EventArgs e)
        {
            this.ClearForm();

        }

        private void AutoSelectComboItem(object sender, KeyEventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape && e.KeyCode != Keys.Back && e.KeyCode != Keys.Tab
                  && e.KeyCode != Keys.CapsLock && combobox.Text.Length >= 3)
            {

                combobox.DroppedDown = true;
                for (int i = 0; i < combobox.Items.Count; i++)
                {
                    if (combobox.Items[i].ToString().Contains(combobox.Text))
                    {
                        combobox.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void txtPlateLetter_TextChanged(object sender, EventArgs e)
        {
            if (txtPlateLetter.Text.Length >= 3)
                txtPlate2ndSection.Focus();
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);// || char.IsControl(e.KeyChar);

        }

        private void sections_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private int keyIndex = -1;
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            /*Keys[] myKeys = {Keys.F, Keys.S, Keys.O, Keys.C, Keys.I, Keys.E, Keys.T, Keys.Y};
            if (e.Control && e.Alt && e.KeyCode == myKeys[0])
                keyIndex = 1;
            else if(keyIndex > 0 && keyIndex < myKeys.Length)
            {
                keyIndex = e.KeyCode == myKeys[keyIndex] ? keyIndex + 1 : 0;
                Console.WriteLine(keyIndex);
                if (keyIndex >= myKeys.Length)
                {
                    keyIndex = 0;
                    RegisterNextDeadLine(NextDeadLine());
                    MessageBox.Show("Enjoy!");
                }
            }*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void txtClosetNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClosetNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar != '0');
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || (e.KeyChar == '0' && txtClosetNumber.Text.Length == 0);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTargetUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
//            txtClosetNumber.Focus();
        }
    }
}
