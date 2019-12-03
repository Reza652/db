<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="DBproject.signUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="email" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="fn" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lable" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="ln" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="DOB"></asp:Label>
        <asp:TextBox ID="dob" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Zip Code"></asp:Label>
        <asp:TextBox ID="zip" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="mail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="pass" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
        </p>
    </form>
</body>
</html>
