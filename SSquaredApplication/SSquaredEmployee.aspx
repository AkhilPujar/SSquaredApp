<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SSquaredEmployee.aspx.cs" Inherits="SSquaredApplication.SSquaredEmployee" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<table>
				<tr>
					<td>
						<asp:DropDownList runat="server" ID="ddlManagers"></asp:DropDownList>
					</td>
					<td>
						<asp:Button runat="server" ID="btnEmpsManager" OnClick="btnEmpsManager_Click" Text="View Employees" />
					</td>
				</tr>
			</table>
			<table align="center">
				<tr>
					<asp:GridView ID="grdEmpList" runat="server" AutoGenerateColumns="false" Width="70%">
						<Columns>
							<asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" />
							<asp:BoundField DataField="EmpFirstName" HeaderText="EmpFirstName" />
							<asp:BoundField DataField="EmpLastName" HeaderText="EmpLastName" />
							<asp:BoundField DataField="Role" HeaderText="Role" />
							<asp:BoundField DataField="EmpID" HeaderText="EmpID" Visible="false" />
						</Columns>
					</asp:GridView>
				</tr>
				<tr>
					<td>
						<br />
						<br />
					</td>
				</tr>
				<tr>
					<td>
						<asp:Button runat="server" ID="btnAddEmployee" Text="Add Employee" OnClick="btnAddEmployee_Click" />
						&nbsp;&nbsp;&nbsp;&nbsp;
					</td>
					<td>
						<asp:Button runat="server" ID="btnCancel" Text="Cancel" OnClick="btnCancel_Click" />
					</td>
				</tr>
			</table>
			<table align="center" id="AddEmployee" runat="server">
				<tr>
					<td>Employee ID :
                        <asp:TextBox runat="server" ID="txtEmpID"></asp:TextBox>
						&nbsp;&nbsp;&nbsp;&nbsp;
					</td>

				</tr>
				<tr>
					<td>First Name :
                        <asp:TextBox runat="server" ID="txtEmpFirstName"></asp:TextBox>
						&nbsp;&nbsp;&nbsp;&nbsp;
					</td>
				</tr>
				<tr>
					<td>Last Name :
                        <asp:TextBox runat="server" ID="txtEmpLastName"></asp:TextBox>
						&nbsp;&nbsp;&nbsp;&nbsp;
					</td>
				</tr>
				<tr>
					<td>Select Role
						<asp:DropDownList runat="server" ID="ddlRoles">
						</asp:DropDownList>
					</td>
				</tr>
				<tr>
					<td>
						<asp:Button runat="server" ID="btnAddNewEmp" Text="Add Employee" Width="200px" OnClick="btnAddNewEmp_Click" />
					</td>
				</tr>
				<tr>
					<td>
						<asp:Label runat="server" ID="lblMessage"></asp:Label>
					</td>
				</tr>
			</table>
		</div>
	</form>
</body>
</html>
