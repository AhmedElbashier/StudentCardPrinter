// Decompiled with JetBrains decompiler
// Type: CardPrinter.Database
// Assembly: CardPrinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B4231750-BA60-4095-99B7-120F870E96E2
// Assembly location: D:\#ACMST\Projects\Regestier office\Debug\app.publish\CardPrinter.exe

using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CardPrinter
{
  internal class Database
  {
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;
    private MySqlDataAdapter mySqlDataAdapter;
    private MySqlCommand cmd;

    public Database() => this.Initialize();

    private void Initialize()
    {
      this.server = "192.168.1.4";
      this.database = "acmst";
      this.uid = "root";
      this.password = "";
      this.connection = new MySqlConnection("SERVER=" + this.server + ";DATABASE=" + this.database + ";UID=" + this.uid + ";PASSWORD=" + this.password + "; pooling = false; convert zero datetime=True");
    }

    private bool OpenConnection()
    {
      try
      {
        if (this.connection.State != ConnectionState.Open)
          this.connection.Open();
        return true;
      }
      catch (MySqlException ex)
      {
        switch (ex.Number)
        {
          case 0:
            int num1 = (int) MessageBox.Show("Cannot connect to server.  Contact administrator");
            break;
          case 1045:
            int num2 = (int) MessageBox.Show("Invalid username/password, please try again");
            break;
          default:
            int num3 = (int) MessageBox.Show(ex.Message);
            break;
        }
        return false;
      }
    }

    private bool CloseConnection()
    {
      try
      {
        this.connection.Close();
        return true;
      }
      catch (MySqlException ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
        return false;
      }
    }

    public DataTable getData()
    {
      if (!this.OpenConnection())
        return (DataTable) null;
      this.mySqlDataAdapter = new MySqlDataAdapter("SELECT arabicFullName, collegeNumber, stdYear,program,class,semester,pic,id FROM studants std where year(applyDate) = 2019 and NOT EXISTS ( SELECT * FROM cards c WHERE c.studantId = std.id)", this.connection);
      DataSet dataSet = new DataSet();
      this.mySqlDataAdapter.Fill(dataSet);
      this.CloseConnection();
      return dataSet.Tables[0];
    }

    public int getStudant(string CollegeNumber)
    {
      if (!this.OpenConnection())
        return 0;
      this.mySqlDataAdapter = new MySqlDataAdapter("SELECT arabicFullName, collegeNumber, stdYear,program,class,semester,pic,id FROM studants where stdYear = '2019-2020' and collegeNumber = '" + CollegeNumber + "'", this.connection);
      DataSet dataSet = new DataSet();
      this.mySqlDataAdapter.Fill(dataSet);
      this.CloseConnection();
      return int.Parse(dataSet.Tables[0].Rows[0].ItemArray.GetValue(7).ToString());
    }

    public void addUser(int id)
    {
      if (!this.OpenConnection())
        return;
      this.cmd = new MySqlCommand("insert into cards values(null,1," + (object) id + ",0,null,null)", this.connection);
      this.cmd.ExecuteNonQuery();
    }
  }
}
