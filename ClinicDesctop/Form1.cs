
using ClinicSeviceNameSpace;
using System.Collections.ObjectModel;

namespace ClinicDesctop
{
    public partial class VeterinaryClinic : Form
    {
        public VeterinaryClinic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            ICollection<Client> clients = clinicClient.ClientGetAllAsync().Result;

        }

        private void btnGetAllClient_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            ICollection<Client> clients = clinicClient.ClientGetAllAsync().Result;
            listViewClients.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.SurName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.FirstName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Patronymic
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Document
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Birthday.ToString()
                });
                listViewClients.Items.Add(item);
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lis in listViewClients.SelectedItems)
            {
                sNameTextBox.Text = lis.SubItems[1].Text;
                fNameTextBox.Text = lis.SubItems[2].Text;
                pNameTextBox.Text = lis.SubItems[3].Text;
                docTextBox.Text = lis.SubItems[4].Text;
                BirthdayTextBox.Text = lis.SubItems[5].Text;
            }
        }









        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            CreateClientRequest createClientRequest = new CreateClientRequest();
            createClientRequest.FirstName = fNameTextBox.Text;
            createClientRequest.SurName = sNameTextBox.Text;
            createClientRequest.Patronymic = pNameTextBox.Text;
            createClientRequest.Document = docTextBox.Text;
            createClientRequest.Birthday = DateTime.Parse(BirthdayTextBox.Text);
            clinicClient.ClientCreateAsync(createClientRequest);
        }

        private void BirthdayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            UpdateClientRequest updateClientRequest = new UpdateClientRequest();
            foreach (ListViewItem lis in listViewClients.SelectedItems)
            {
                updateClientRequest.ClientId = int.Parse(lis.SubItems[0].Text);

            }
            updateClientRequest.FirstName = fNameTextBox.Text;
            updateClientRequest.SurName = sNameTextBox.Text;
            updateClientRequest.Patronymic = pNameTextBox.Text;
            updateClientRequest.Document = docTextBox.Text;
            updateClientRequest.Birthday = DateTime.Parse(BirthdayTextBox.Text);
            clinicClient.ClientUpdateAsync(updateClientRequest);

        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());

            foreach (ListViewItem lis in listViewClients.SelectedItems)
            {
                clinicClient.ClientDeleteAsync(int.Parse(lis.SubItems[0].Text));
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void GetAllPet_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            ICollection<Pet> pets = clinicClient.PetGetAllAsync().Result;
            listView1.Items.Clear();
            foreach (Pet pet in pets)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pet.PetId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.ClientId.ToString(),
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.Name.ToString(),
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.Birthday.ToString(),
                });

                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (ListViewItem lis in listView1.SelectedItems)
            {
                clientIDTextBox.Text = lis.SubItems[1].Text;
                nameTextBox.Text = lis.SubItems[2].Text;
                birthdayPetTextBox.Text = lis.SubItems[3].Text;
            }

        }

        private void btnCreatePet_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            CreatePetRequest createPetRequest = new CreatePetRequest();
            createPetRequest.ClientId = int.Parse(clientIDTextBox.Text);
            createPetRequest.Name = nameTextBox.Text;
            createPetRequest.Birthday = DateTime.Parse(birthdayPetTextBox.Text);
            clinicClient.PetCreateAsync(createPetRequest);
        }

        private void btnUpdatePet_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            UpdatePetRequest updatePetRequest = new UpdatePetRequest();
            foreach (ListViewItem lis in listView1.SelectedItems)
            {
                updatePetRequest.PetId = int.Parse(lis.SubItems[0].Text);

            }
            updatePetRequest.ClientId = int.Parse(clientIDTextBox.Text);
            updatePetRequest.Name = nameTextBox.Text;
            updatePetRequest.Birthday = DateTime.Parse(birthdayPetTextBox.Text);
            clinicClient.PetUpdateAsync(updatePetRequest);
        }

        private void btnDellPet_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());

            foreach (ListViewItem lis in listView1.SelectedItems)
            {
                clinicClient.PetDeleteAsync(int.Parse(lis.SubItems[0].Text));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            ICollection<Consultation> consultations = clinicClient.ConsultationGetAllAsync().Result;
            listView2.Items.Clear();
            foreach (Consultation consultation in consultations)
            {
                ListViewItem item = new ListViewItem();
                item.Text = consultation.ConsultationId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.ClientId.ToString(),
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.PetId.ToString(),
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.ConsultationDate.ToString(),
                });

                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.Description.ToString(),
                });

                listView2.Items.Add(item);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lis in listView2.SelectedItems)
            {
                clientIdBoxConsul.Text = lis.SubItems[1].Text;
                petIdBoxConsul.Text = lis.SubItems[2].Text;
                dateBoxConsul.Text = lis.SubItems[3].Text;
                descBoxConsul.Text = lis.SubItems[4].Text;
            }
        }

        private void btnCreateCons_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            CreateConsultationRequest createConsultationRequest = new CreateConsultationRequest();
            createConsultationRequest.ClientId = int.Parse(clientIdBoxConsul.Text);
            createConsultationRequest.PetId = int.Parse(petIdBoxConsul.Text);
            createConsultationRequest.ConsultationDate = DateTime.Parse(dateBoxConsul.Text);
            createConsultationRequest.Description = descBoxConsul.Text;
            clinicClient.ConsultationCreateAsync(createConsultationRequest);

        }

        private void btnUpdateCons_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            UpdateConsultationRequest updateConsultationRequest = new UpdateConsultationRequest();
            foreach (ListViewItem lis in listView2.SelectedItems)
            {
                updateConsultationRequest.ConsultationId = int.Parse(lis.SubItems[0].Text);

            }
            updateConsultationRequest.ClientId = int.Parse(clientIdBoxConsul.Text);
            updateConsultationRequest.PetId = int.Parse(petIdBoxConsul.Text);
            updateConsultationRequest.ConsultationDate = DateTime.Parse(dateBoxConsul.Text);
            updateConsultationRequest.Description = descBoxConsul.Text;
            clinicClient.ConsultationUpdateAsync(updateConsultationRequest);
        }

        private void btnDellCons_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());

            foreach (ListViewItem lis in listView2.SelectedItems)
            {
                clinicClient.ConsultationDeleteAsync(int.Parse(lis.SubItems[0].Text));
            }
        }
    }
}
