using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdamMatthew.TeaRoundPicket.Business;
using AdamMatthew.TeaRoundPicket.Business.Interfaces;
using AdamMatthew.TeaRoundPicket.Business.Models;
using AdamMatthew.TeaRoundPicket.Data;

namespace AdamMatthew.TeaRoundPicket.UI
{
    public partial class MainForm : Form
    {
        #region Fields
        private IRepository _repository;
        private ICollection<Participant> _participants;
        private ICollection<TeaPreference> _preferences;
        private ITeaMakerSelecter _teaMakerSelecter;
        private const string FullNameFormat = "{0} {1}";
        #endregion Fields

        #region Construction
        public MainForm()
        {
            InitializeComponent();

            //this.Load += new EventHandler(async (s, e) => await MainForm_LoadAsync(s, e));
            this.Load += new System.EventHandler(this.MainForm_Load);
        }
        #endregion Construction

        #region Events
        //private async Task MainForm_LoadAsync(object sender, EventArgs e) // Use this signature in case we switch to working with async
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Ideally the repository class is injected by IoC. This is skipped for this exercise. 
                // Also skpiied is the ability to log messages for future debugging
                _repository = new Repository();

                _participants = _repository.GetParticipants();
                _preferences = _repository.GetTeaPreferences();

                _teaMakerSelecter = new TeaMakerSelecter(_repository);

                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Random tea maker selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonRandom_Click(object sender, EventArgs e)
        {
            var participant = _teaMakerSelecter.GetRandomParticipant();

            var selectedParticipant = string.Format(FullNameFormat, participant.Firstname, participant.Lastname);
            comboBoxParticipants.SelectedItem = GetSelectedParticipantItem(selectedParticipant);
            comboBoxParticipants.Enabled = false;
        }

        /// <summary>
        /// Next in order tea maker selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonNextInOrder_Click(object sender, EventArgs e)
        {
            var participant = _teaMakerSelecter.GetNextParticipantInOrder();

            var selectedParticipant = string.Format(FullNameFormat, participant.Firstname, participant.Lastname);
            comboBoxParticipants.SelectedItem = GetSelectedParticipantItem(selectedParticipant);

            comboBoxParticipants.Enabled = false;
        }

        /// <summary>
        /// Next tea maker statistical selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonNextStatistically_Click(object sender, EventArgs e)
        {
            var participant = _teaMakerSelecter.GetNextParticipantByStats();

            var selectedParticipant = string.Format(FullNameFormat, participant.Firstname, participant.Lastname);
            comboBoxParticipants.SelectedItem = GetSelectedParticipantItem(selectedParticipant);

            comboBoxParticipants.Enabled = false;
        }

        /// <summary>
        /// Next tea maker manually selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonManual_Click(object sender, EventArgs e)
        {
            comboBoxParticipants.Enabled = true;
        }

        /// <summary>
        /// Update participant preferences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxParticipants.SelectedItem == null || comboBoxTeaBrands.SelectedItem == null) return;

            var selectedName     = listBoxParticipants.SelectedItem as string;
            var selectedTeaBrand = comboBoxTeaBrands.SelectedItem as string;

            _repository.UpdateParticipantPreferences(selectedName, checkBoxAddMilk.Checked, checkBoxAddSugar.Checked, selectedTeaBrand);
        }

        /// <summary>
        /// Add participant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new ParticipantForm();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _repository.AddParticipant(dlg.Firstname, dlg.Lastname);

                    UpdateUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Remove participant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxParticipants.SelectedItem == null) return;

            _repository.RemoveParticipant(listBoxParticipants.SelectedItem as string);

            UpdateUI();
        }

        /// <summary>
        /// Participant selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxParticipants.SelectedItem == null) return;

            var selectedName  = listBoxParticipants.SelectedItem as string;
            // Identify the selected participant
            var participant   = _participants.First(x => selectedName.Equals(string.Format(FullNameFormat, x.Firstname, x.Lastname)));
            var teaPreference = _preferences.First(x => x.ParticipantId.Equals(participant.Id));

            checkBoxAddMilk.Checked = teaPreference.AddMilk;
            checkBoxAddSugar.Checked = teaPreference.AddSugar;

            var selectedTeaBrand = teaPreference.TeaBrand.ToString();
            comboBoxTeaBrands.SelectedItem = GetSelectedTeaBrandItem(selectedTeaBrand);
        }

        /// <summary>
        /// Tea maker selected and accepted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (comboBoxParticipants.SelectedItem == null) return;

            var selectedName = comboBoxParticipants.SelectedItem as string;

            _repository.SelectParticipant(selectedName);
        }
        #endregion Events

        #region Private Methods
        private void PopulateComboBoxListOfParticipant()
        {
            comboBoxParticipants.Items.Clear();
            if (_participants == null) return;

            foreach (var participant in _participants)
            {
                comboBoxParticipants.Items.Add(string.Format(FullNameFormat, participant.Firstname, participant.Lastname));
            }
        }
        private void PopulateListOfParticipant()
        {
            listBoxParticipants.Items.Clear();
            if (_participants == null) return;

            foreach (var participant in _participants)
            {
                listBoxParticipants.Items.Add(string.Format(FullNameFormat, participant.Firstname, participant.Lastname));
            }
        }
        private void PopulateComboBoxTeaBrands()
        {
            comboBoxTeaBrands.Items.Clear();

            var enumValues = Enum.GetValues(typeof(TeaBrand));

            foreach (var enumValue in enumValues)
            {
                comboBoxTeaBrands.Items.Add(enumValue);
            }
        }
        private void UpdateUI()
        {
            PopulateComboBoxListOfParticipant();
            PopulateListOfParticipant();
            PopulateComboBoxTeaBrands();

            radioButtonRandom.Enabled = _participants.Count > 0;
            radioButtonNextInOrder.Enabled = _participants.Count > 0;
            radioButtonManual.Enabled = _participants.Count > 0;
            radioButtonNextStatistically.Enabled = _participants.Count > 0;

            radioButtonManual.Checked = true;

            comboBoxParticipants.Enabled = radioButtonManual.Checked;
        }
        private object GetSelectedParticipantItem(string selectedParticipant)
        {
            foreach (var item in comboBoxParticipants.Items)
            {
                var itemText = item.ToString();
                if (itemText.Equals(selectedParticipant)) return item;
            }

            return null;
        }
        private object GetSelectedTeaBrandItem(string selectedTeaBrand)
        {
            foreach (var item in comboBoxTeaBrands.Items)
            {
                var itemText = item.ToString();
                if (itemText.Equals(selectedTeaBrand)) return item;
            }

            return null;
        }
        #endregion Private Methods
    }
}
