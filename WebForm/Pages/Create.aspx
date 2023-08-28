<%@ Page Title="Create" Async="true"  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="WebForm.Create" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <style>
        .form-horizontal .form-group {
            margin-bottom: 20px;
        }

        .form-horizontal .control-label {
            text-align: right;
        }

        .btn-group {
            margin-top: 10px;
        }
    </style>

    <div class="col-md-12">
        <div class="btn-group">
            <asp:Button ID="VoltarButton" runat="server" Text="Voltar" CssClass="btn btn-primary" />
        </div>
    </div>

    <div class="form-horizontal">
        <h3>Dados do Cliente</h3>

        <div class="form-group">
            <asp:Label ID="NomeLabel" runat="server" Text="Nome" CssClass="control-label col-md-2" AssociatedControlID="NomeTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="NomeTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="NomeValidator" runat="server" ControlToValidate="NomeTextBox" ErrorMessage="Nome é obrigatório" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="CPFLabel" runat="server" Text="CPF" CssClass="control-label col-md-2" AssociatedControlID="CPFTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="CPFTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="CPFValidator" runat="server" ControlToValidate="CPFTextBox" ErrorMessage="CPF é obrigatório" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="RGLabel" runat="server" Text="RG" CssClass="control-label col-md-2" AssociatedControlID="RGTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="RGTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="RGValidator" runat="server" ControlToValidate="RGTextBox" ErrorMessage="RG é obrigatório" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="DataExpedicaoLabel" runat="server" Text="Data de Expedição" CssClass="control-label col-md-2" AssociatedControlID="DataExpedicaoTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="DataExpedicaoTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="DataExpedicaoValidator" runat="server" ControlToValidate="DataExpedicaoTextBox" ErrorMessage="Data de Expedição é obrigatória" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="OrgaoExpedicaoLabel" runat="server" Text="Órgão de Expedição" CssClass="control-label col-md-2" AssociatedControlID="OrgaoExpedicaoTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="OrgaoExpedicaoTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="OrgaoExpedicaoValidator" runat="server" ControlToValidate="OrgaoExpedicaoTextBox" ErrorMessage="Órgão de Expedição é obrigatório" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="UFLabel" runat="server" Text="UF" CssClass="control-label col-md-2" AssociatedControlID="UFTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="UFTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="UFValidator" runat="server" ControlToValidate="UFTextBox" ErrorMessage="UF é obrigatório" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="DataNascimentoLabel" runat="server" Text="Data de Nascimento" CssClass="control-label col-md-2" AssociatedControlID="DataNascimentoTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="DataNascimentoTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="DataNascimentoValidator" runat="server" ControlToValidate="DataNascimentoTextBox" ErrorMessage="Data de Nascimento é obrigatória" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="SexoLabel" runat="server" Text="Sexo" CssClass="control-label col-md-2" AssociatedControlID="SexoDropDownList" />
            <div class="col-md-10">
                <asp:DropDownList ID="SexoDropDownList" runat="server" CssClass="form-control">
                    <asp:ListItem Value="">Selecione</asp:ListItem>
                    <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
                    <asp:ListItem Value="Feminino">Feminino</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="SexoValidator" runat="server" ControlToValidate="SexoDropDownList" ErrorMessage="Sexo é obrigatório" InitialValue="" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="EstadoCivilLabel" runat="server" Text="Estado Civil" CssClass="control-label col-md-2" AssociatedControlID="EstadoCivilDropDownList" />
            <div class="col-md-10">
                <asp:DropDownList ID="EstadoCivilDropDownList" runat="server" CssClass="form-control">
                    <asp:ListItem Value="">Selecione</asp:ListItem>
                    <asp:ListItem Value="Solteiro">Solteiro</asp:ListItem>
                    <asp:ListItem Value="Casado">Casado</asp:ListItem>
                    <asp:ListItem Value="Divorciado">Divorciado</asp:ListItem>
                    <asp:ListItem Value="Viúvo">Viúvo</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="EstadoCivilValidator" runat="server" ControlToValidate="EstadoCivilDropDownList" ErrorMessage="Estado Civil é obrigatório" InitialValue="" CssClass="text-danger" />
            </div>
        </div>

        <h3>Endereço</h3>

        <div class="form-group">
            <asp:Label ID="CEPLabel" runat="server" Text="CEP" CssClass="control-label col-md-2" AssociatedControlID="CEPTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="CEPTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="CEPValidator" runat="server" ControlToValidate="CEPTextBox" ErrorMessage="CEP é obrigatório" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="LogradouroLabel" runat="server" Text="Logradouro" CssClass="control-label col-md-2" AssociatedControlID="LogradouroTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="LogradouroTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="LogradouroValidator" runat="server" ControlToValidate="LogradouroTextBox" ErrorMessage="Logradouro é obrigatório" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="NumeroLabel" runat="server" Text="Número" CssClass="control-label col-md-2" AssociatedControlID="NumeroTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="NumeroTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="NumeroValidator" runat="server" ControlToValidate="NumeroTextBox" ErrorMessage="Número é obrigatório" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="ComplementoLabel" runat="server" Text="Complemento" CssClass="control-label col-md-2" AssociatedControlID="ComplementoTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="ComplementoTextBox" runat="server" CssClass="form-control" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="BairroLabel" runat="server" Text="Bairro" CssClass="control-label col-md-2" AssociatedControlID="BairroTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="BairroTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="BairroValidator" runat="server" ControlToValidate="BairroTextBox" ErrorMessage="Bairro é obrigatório" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="CidadeLabel" runat="server" Text="Cidade" CssClass="control-label col-md-2" AssociatedControlID="CidadeTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="CidadeTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="CidadeValidator" runat="server" ControlToValidate="CidadeTextBox" ErrorMessage="Cidade é obrigatório" CssClass="text-danger" />
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="UFEnderecoLabel" runat="server" Text="UF" CssClass="control-label col-md-2" AssociatedControlID="UFEnderecoTextBox" />
            <div class="col-md-10">
                <asp:TextBox ID="UFEnderecoTextBox" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="UFEnderecoValidator" runat="server" ControlToValidate="UFEnderecoTextBox" ErrorMessage="UF é obrigatório" CssClass="text-danger" />
            </div>
        </div>

        <div class="col-md-12">
            <div class="btn-group">
                <asp:Button ID="SalvarButton" runat="server" OnClick="btnSubmit_Click" Text="Salvar" CssClass="btn btn-primary" />
            </div>
        </div>

    </div>

</asp:Content>
