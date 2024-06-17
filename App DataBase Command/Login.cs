using App_DataBase_Command.Class;

namespace App_DataBase_Command
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ConectarBtm_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioTxb.Text;
            string contraseña = ContraseñaTxb.Text;

            UsuarioTxb.Clear();
            ContraseñaTxb.Clear();

            DataBase dataBase = new DataBase(usuario, contraseña);

            if (dataBase.Connect())
            {
                QueryDataBase queryDataBase = new QueryDataBase(dataBase);
                queryDataBase.Show();

                this.Hide();
            }
        }
    }
}
