<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowingAdd.aspx.cs" Inherits="Mini_biblioteka_61996.BorrowingAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        Wypożyczenia
    </title>
</head>
<body>
    <form id="form1" runat="server">
                <h1>Dodawanie Wypożyczenia</h1>

        <div>
            <ul>
                <li><a href="BookAdd.aspx">Dodaj książkę</a></li>
                <li><a href="ReaderAdd.aspx">Dodaj czytelnika</a></li>
            </ul>
        </div>

        <div>
            <asp:Label ID="lblBorrowDate" runat="server" Text="Data wypozyczenia"></asp:Label>
            <asp:Calendar ID="cldBorrowDate" runat="server" style="margin-top: 5px"></asp:Calendar>
        </div>
        <div>
            <p></p>
        </div>
        <div>
            <asp:Label ID="lblReturnDate" runat="server" Text="Data zwrotu"></asp:Label>
            <asp:Calendar ID="cldReturnDate" runat="server" style="margin-top: 5px"></asp:Calendar>`
        </div>
        <div>
            <asp:Label ID="BookList" runat="server" Text="Książka"></asp:Label>
            <asp:DropDownList ID="ddlBook" runat="server" style="margin-left: 13px"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="ReaderList" runat="server" Text="Czytelnik"></asp:Label>
            <asp:DropDownList ID="ddlReader" runat="server" style="margin-left: 6px"></asp:DropDownList>
        </div>
        <asp:Button ID="Button3" runat="server" Text="Zapisz" OnClick="Button3_Click" style="margin-top: 19px" />


        <asp:GridView ID="BorrowsView" runat="server" style="margin-top: 29px"></asp:GridView>


    </form>


</body>
</html>
