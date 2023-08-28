<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DetalhesCliente.aspx.cs" Inherits="DetalhesCliente" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Visualizar</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <nav aria-label="breadcrumb">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="#">Clientes Cadastrados</a></li>
                </ol>
            </nav>
            
            <div class="row">
                <div class="col-md-8">
                    <asp:Button ID="btnVoltar" runat="server" CssClass="btn btn-primary" Text="Voltar" OnClick="btnVoltar_Click" />
                </div>
            </div>

            <br />

            <fieldset>
                <legend>Dados do Cliente</legend>

                <div class="form-group">
                    <label for="txtClienteId" class="col-lg-2 control-label">Cliente ID</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtClienteId" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                    </div>
                </div>

                <!-- Outros campos... -->

            </fieldset>

            <!-- Dados do Endereço... -->

            <div class="form-group">
                <div class="col-lg-offset-2 col-lg-10">
                    <asp:Button ID="btnAlterar" runat="server" CssClass="btn btn-primary" Text="Alterar" OnClick="btnAlterar_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
