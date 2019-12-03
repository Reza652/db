<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DBproject.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to Gamer&#39;s Delight!<br />
            <br />
            Whether you&#39;re looking for a used game for a nice discount, or<br />
            looking to make a quick buck for a game you&#39;ll never play, we<br />
            have the solution to all of your video game trading needs.</div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign In" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderStyle="Double" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sign Up" BackColor="#CCFFFF" BorderColor="#66CCFF" BorderStyle="Double" />
    </form>
    <p>
        &nbsp;</p>
    </body>
</html>
