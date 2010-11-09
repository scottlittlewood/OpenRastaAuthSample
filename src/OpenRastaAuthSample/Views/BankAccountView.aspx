<%@ Page Language="C#" Inherits="OpenRasta.Codecs.WebForms.ResourceView<BankAccountResource>" MasterPageFile="~/Views/HomeView.Master" %>

<asp:Content ContentPlaceHolderID="body" ID="content" runat="server">
    <div>
        The balance for <%= Resource.AccountHolder %> is <%= Resource.Balance %>
    </div>
</asp:Content>
