<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_List.aspx.cs" Inherits="ADOCRUD.Student_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student List</title>
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
	<script src="Scripts/bootstrap.min.js"></script>
	<script src="Scripts/jquery-3.6.0.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
			
			<div class="form-group">
					<div class="col-md-2">
						<asp:Label ID="Label5" runat="server" Text="Roll Number" CssClass="control-label"></asp:Label>
					</div>
					<div class="col-md-2">
						<asp:TextBox ID="txtRollNumber" runat="server" CssClass="form-control"></asp:TextBox>
						<asp:Button ID="btnLoadStudent" runat="server" Text="Button" CssClass="btn btn-success" OnClick="btnLoadStudent_Click" />
					</div>
				</div>


			<h2>Student create form</h2>
			<div>
				<div class="form-group">
					<div class="col-md-2">
						<asp:Label ID="Label1" runat="server" Text="Name" CssClass="control-label"></asp:Label>
					</div>
					<div class="col-md-4">
						<asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
					</div>
				</div>
				<div class="form-group">
					<div class="col-md-2">
						<asp:Label ID="Label2" runat="server" Text="Age" CssClass="control-label"></asp:Label>
					</div>
					<div class="col-md-4">
						<asp:TextBox ID="txtAge" runat="server" CssClass="form-control"></asp:TextBox>
					</div>
				</div>
				<div class="form-group">
					<div class="col-md-2">
						<asp:Label ID="Label3" runat="server" Text="Email" CssClass="control-label"></asp:Label>
					</div>
					<div class="col-md-4">
						<asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
					</div>
				</div>
				<div class="form-group">
					<div class="col-md-2">
						<asp:Label ID="Label4" runat="server" Text="DateOfBirth" CssClass="control-label"></asp:Label>
					</div>
					<div class="col-md-4">
						<asp:TextBox ID="txtDateOfBirth" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox>
					</div>
				</div>
				<br />
				<div class="form-group">
					<div class="col-md-2">
						<asp:Button ID="btnCreate" runat="server" Text="Create"  OnClick="btnCreate_Click" CssClass="btn btn-success form-control" />
					</div>
					<div class="col-md-2">
						<asp:Button ID="btnClear" runat="server" Text="Clear"  OnClick="btnClear_Click" CssClass="btn btn-primary form-control" />
					</div>
					<div class="col-md-2">
						<asp:Button ID="btnEdit" runat="server" Text="Edit"  OnClick="btnEdit_Click" CssClass="btn btn-warning form-control" />
					</div>
					<div class="col-md-2">
						<asp:Button ID="btnDelete" runat="server" Text="Delete"  OnClick="btnDelete_Click" CssClass="btn btn-danger form-control" />
					</div>
				</div>
				<div class="form-group">
					<div class="col-md-2">
						<asp:Label ID="lblMessage" runat="server" CssClass="" ></asp:Label>
					</div>
				</div>

			</div>
			<br />
			
			<h2>List of Student</h2>

			<asp:GridView ID="gvStudents" runat="server" CssClass="table table-bordered table-hover"></asp:GridView>

        </div>
    </form>
</body>
</html>
