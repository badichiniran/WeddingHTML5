<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GuestList.aspx.cs" Inherits="GuestList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       User name <asp:TextBox ID="TBUserName" runat="server"/><br />

       Password<asp:TextBox ID="TBPass" runat="server"  TextMode="Password"/><br />
        <asp:Button ID="BTNSubmit" runat="server" Text="Submit" OnClick="BTNSubmit_Click" />
    </div>
    </form>
</body>
</html>
