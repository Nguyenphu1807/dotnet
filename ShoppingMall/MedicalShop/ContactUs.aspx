<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="MedicalShop.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
       
        <p>
            <asp:Label ID="ibiMessage" runat="server" ForeColor="#FF6699" Text="ibiMessage"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
           Category : <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True" Text="--Select--"></asp:ListItem>
                <asp:ListItem Text="News" Value="News"></asp:ListItem>
                <asp:ListItem Text="Report" Value="Report"></asp:ListItem>
                <asp:ListItem Text="System" Value="System"></asp:ListItem>
                <asp:ListItem Text="Reminder" Value="Reminder"></asp:ListItem>
            </asp:DropDownList>
        </p>
    <p>
      Description :  <textarea id="TextArea1" cols="20" name="S1" rows="2"></textarea></p>
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    <br />
 </div>
    </form>
</body>
</html>
