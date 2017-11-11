using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbFileTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


public class LoginPanel extends JPanel
        {

    private JTextField txtUsername;
        private JTextField textField;

        //	private volatile boolean login = false;

        /**
         * Create the panel.
         */
        public LoginPanel(ActionListener al)
        {
            setLayout(null);

            txtUsername = new JTextField();
            txtUsername.setBounds(180, 100, 86, 20);
            add(txtUsername);
            txtUsername.setColumns(10);

            JLabel lblUsername = new JLabel("Username");
            lblUsername.setBounds(180, 75, 70, 14);
            add(lblUsername);

            JLabel lblPassword = new JLabel("Password");
            lblPassword.setBounds(180, 131, 70, 14);
            add(lblPassword);

            textField = new JTextField();
            textField.setBounds(180, 156, 86, 20);
            add(textField);
            textField.setColumns(10);

            JButton btnLogin = new JButton("Login");
            btnLogin.setBounds(180, 187, 89, 23);
            add(btnLogin);

            btnLogin.addActionListener(al);

        }

        //	public boolean getLogin() {
        //	return login;
        //	}

        /*	private class ButtonListener implements ActionListener {

                public void actionPerformed(ActionEvent e) {
                    String command = e.getActionCommand();
           //         login = true;
           //         System.out.println(command + " " + login);
                }
            } */
    }









}
    }
}
