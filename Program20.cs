using System;
using System.Windows.Forms;

public class LoginForm : Form
{
    TextBox usernameTextBox = new TextBox();
    TextBox passwordTextBox = new TextBox();
    TextBox retypePasswordTextBox = new TextBox();
    Button loginButton = new Button();
    CheckBox rememberCheckBox = new CheckBox();

    public LoginForm()
    {
        this.Text = "Login Form";

        usernameTextBox.SetBounds(10, 10, 200, 20);
        passwordTextBox.SetBounds(10, 40, 200, 20);
        retypePasswordTextBox.SetBounds(10, 70, 200, 20);
        loginButton.SetBounds(10, 100, 200, 30);
        loginButton.Text = "Login";
        rememberCheckBox.SetBounds(10, 140, 200, 20);
        rememberCheckBox.Text = "Remember Me";

        loginButton.Click += LoginButton_Click;

        this.Controls.Add(usernameTextBox);
        this.Controls.Add(passwordTextBox);
        this.Controls.Add(retypePasswordTextBox);
        this.Controls.Add(loginButton);
        this.Controls.Add(rememberCheckBox);
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text) || string.IsNullOrEmpty(retypePasswordTextBox.Text))
        {
            MessageBox.Show("Please fill in all fields.");
            return;
        }

        if (passwordTextBox.Text != retypePasswordTextBox.Text)
        {
            MessageBox.Show("Passwords do not match.");
            return;
        }

        MessageBox.Show("Login successful!");
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new LoginForm());
    }
}
