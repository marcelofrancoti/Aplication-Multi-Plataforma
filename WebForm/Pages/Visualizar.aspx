<%@ Page Title="Visualizar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Visualizar.aspx.cs" Inherits="WebForm.Visualizar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <h3>Busca de Cliente</h3>
    
    <div class="form-group">
        <asp:Label ID="BuscaClienteLabel" runat="server" Text="Nome do Cliente" CssClass="control-label col-md-2" AssociatedControlID="BuscaClienteTextBox" />
        <div class="col-md-10">
            <asp:TextBox ID="BuscaClienteTextBox" runat="server" CssClass="form-control" />
        </div>
    </div>

    <div class="col-md-12">
        <div class="btn-group">
            <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" Text="Buscar" CssClass="btn btn-primary" />
        </div>
    </div>

    <h3>Resultados</h3>

    <asp:GridView ID="ClientesGridView" runat="server" CssClass="table table-bordered table-striped">
        <Columns>
            <asp:BoundField DataField="Nome" HeaderText="Nome" />
            <asp:BoundField DataField="CPF" HeaderText="CPF" />
            <asp:BoundField DataField="RG" HeaderText="RG" />
            <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
            <asp:BoundField DataField="Cidade" HeaderText="Cidade" />
            <asp:BoundField DataField="UF" HeaderText="UF" />
        </Columns>
    </asp:GridView>

</asp:Content>
