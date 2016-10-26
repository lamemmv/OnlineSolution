using PasswordEncryption.Data;
using PasswordEncryption.Entities;
using SimpleInjector;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using System.Linq;

namespace PasswordEncryption
{
    public partial class Main : Form
    {
        private IDataService _dataService;
        private IEnumerable<UserDTO> _users;

        public Main(Container container)
        {
            InitializeComponent();
            GetConnectionString();
            _dataService = container.GetInstance<IDataService>();
            GetUsers();
        }

        private void GetUsers()
        {
            _users = _dataService.GetUsers();
            Log(string.Format("Loaded {0} users.", _users.ToList().Count));
        }

        private void GetConnectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            txtConnectionString.Text = connectionString;
        }

        private void rdnMD5_CheckedChanged(object sender, System.EventArgs e)
        {
            btnDecrypt.Enabled = false;
            btnEncrypt.Enabled = true;
        }

        private void rdnPlaintextPassword_CheckedChanged(object sender, System.EventArgs e)
        {
            btnDecrypt.Enabled = false;
            btnEncrypt.Enabled = false;
        }

        private void rdnCustom_CheckedChanged(object sender, System.EventArgs e)
        {
            btnDecrypt.Enabled = true;
            btnEncrypt.Enabled = true;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Log(string message)
        {
            txtLogs.AppendText(message);
        }

        private void btnEncrypt_Click(object sender, System.EventArgs e)
        {
            _dataService.EncyptUserPasswords(_users);
        }
    }
}
