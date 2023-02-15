using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSquaredApplication
{
    public partial class SSquaredEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllEmployeeForSSQ();
                GetAllManagersForSSQ();
                GetAllRolesForSSQ();
                AddEmployee.Visible = false;
            }
        }
        public void GetAllEmployeeForSSQ()
        {
            DataTable dtGetAllEmployee = DataAccess.GetAllEmployee();
            grdEmpList.DataSource = dtGetAllEmployee;
            grdEmpList.DataBind();
        }
        public void GetAllManagersForSSQ()
        {
            DataTable dtGetAllManagers = DataAccess.GetAllManagers();
            ddlManagers.DataSource = dtGetAllManagers;
            ddlManagers.DataValueField = "FullName";
            ddlManagers.DataTextField = "FullName";
            ddlManagers.DataBind();
        }
        public void LoadSelectedManagerEmployee(string managers)
        {
            DataTable dtGetAllEmployee = DataAccess.GetSelectedManagerEmplyeee(managers);
            grdEmpList.DataSource = dtGetAllEmployee;
            grdEmpList.DataBind();
        }
        public void GetAllRolesForSSQ()
        {
            DataTable dtGetAllManagers = DataAccess.GetAllRoles();
            ddlRoles.DataSource = dtGetAllManagers;
            ddlRoles.DataValueField = "SSQRoleID";
            ddlRoles.DataTextField = "Role";
            ddlRoles.DataBind();
            ddlRoles.Items.Insert(0, new ListItem("--Select--", string.Empty));
        }

        protected void btnAddNewEmp_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SSQEnterpriseDB"].ConnectionString);
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("SSquared_sp_InsertEmployee", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@EmpFirstName", txtEmpFirstName.Text);
                sqlCommand.Parameters.AddWithValue("@EmpLastName", txtEmpLastName.Text);
                sqlCommand.Parameters.AddWithValue("@EmployeeID", txtEmpID.Text);
                sqlCommand.Parameters.AddWithValue("@EmpRoles", ddlRoles.SelectedValue);
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
            lblMessage.Text = "A new Employee have been added !";
        }

        protected void btnEmpsManager_Click(object sender, EventArgs e)
        {
            LoadSelectedManagerEmployee(ddlManagers.SelectedItem.Text);
        }


        protected void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee.Visible = true;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            AddEmployee.Visible = false;
        }

    }
}