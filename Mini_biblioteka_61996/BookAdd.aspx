
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookAdd.aspx.cs" Inherits="Mini_biblioteka_61996.BookAdd" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        Książki
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Dodawanie Książki</h1>
        <div>
            <ul>
                <li><a href="ReaderAdd.aspx">Dodaj czytelnika</a></li>
                <li><a href="BorrowingAdd.aspx">Wypożyczenia</a></li>
            </ul>
        </div>
         <div>
            <asp:Label ID="lblTitle" runat="server" Text="Tytuł"></asp:Label>
            <asp:TextBox ID="txtTitle" runat="server" style="margin-left: 51px"></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="lblAuthor" runat="server" Text="Autor"></asp:Label>
            <asp:TextBox ID="txtAuthor" runat="server" style="margin-left: 47px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblYear" runat="server" Text="Rok wydania"></asp:Label>
            <asp:TextBox ID="txtYear" TextMode="Number"  runat="server" style="margin-left: 2px"></asp:TextBox>
        </div>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Zapisz" Height="27px" OnClick="Button1_Click" />

        </p>
        <p>
            &nbsp;</p>

    </form>
</body>
</html>
